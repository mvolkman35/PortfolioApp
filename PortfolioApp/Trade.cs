using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioApp
{
    class Trade
    {
        DBConnect currentDBConnection = new DBConnect();
        private string ticker;
        private decimal quantity;
        JSONParseQuote response;
        decimal lastPrice;
        decimal cashAmount;
        decimal currentCash;
        decimal currentHoldingQuantity;
        string description;
        string assetType;

        public Trade(string ticker, decimal quantity)
        {
            this.ticker = ticker;
            this.quantity = quantity;
            response = APIQuoteInfo.GetPriceInfo(ticker.ToUpper());
            lastPrice = response.Ticker.LastPrice;
            description = response.Ticker.Description;
            assetType = response.Ticker.AssetType;
            cashAmount = lastPrice * quantity;
            currentCash = this.CurrentHoldingQuantity("CASH");
            currentHoldingQuantity = this.CurrentHoldingQuantity(ticker);

        }

        public void BuyTrade()
        {

            //see if enough cash to buy
            if (currentCash >= cashAmount)
            {
                //check if already holding
                if (currentHoldingQuantity >= 1)
                {
                    decimal newQuantity = quantity + currentHoldingQuantity;
                    string query = $"UPDATE holdings SET quantity={newQuantity} WHERE ticker='{ticker}'";
                    currentDBConnection.Update(query);

                    RecordTransaction("BUY", ticker, quantity, lastPrice, cashAmount);
                    CashAdjustment("BUY", cashAmount, currentCash);
                }
                else if (currentHoldingQuantity == 0)
                {
                    string query = $"INSERT into holdings VALUES ('{ticker}', {quantity})";
                    currentDBConnection.Insert(query);

                    RecordTransaction("BUY", ticker, quantity, lastPrice, cashAmount);
                    RecordStockProfile(description, ticker, assetType, lastPrice) ;
                    CashAdjustment("BUY", cashAmount, currentCash);
                }
                else
                {
                    MessageBox.Show("Please review and re-enter trade.");
                }
            }
            else
            {
                MessageBox.Show("Please make sure there is enough cash.");
            }
        }

        public void SellTrade()
        {

            // test if holding
            if (currentHoldingQuantity > quantity)
            {
                decimal newQuantity = currentHoldingQuantity - quantity;
                string query = $"UPDATE holdings SET quantity={newQuantity} WHERE ticker='{ticker}'";
                currentDBConnection.Update(query);
                RecordTransaction("SELL", ticker, quantity, lastPrice, cashAmount);
                CashAdjustment("SELL", cashAmount, currentCash);

            }
            else if (currentHoldingQuantity == quantity)
            {
                string query = $"DELETE FROM holdings WHERE ticker='{ticker}'";
                currentDBConnection.Delete(query);
                //No trans reccorded, holding removed and holdings table removes related transactions
                CashAdjustment("SELL", cashAmount, currentCash);
            }
            else 
            {
                MessageBox.Show("You do not own this stock.");
            }

        }

        private decimal CurrentHoldingQuantity(string ticker)
        {
            decimal quantity = 0;
            string query = $"SELECT Quantity FROM holdings WHERE ticker='{ticker}'";
            quantity = Decimal.ToInt32(currentDBConnection.ScalarQuery(query));
            return quantity;
        }

        private void RecordTransaction(string action, string ticker, decimal quantity, 
            decimal lastPrice, decimal cashAmount)
        {
            string query = $"INSERT into transactions (trade_action, ticker, quantity_change, trade_price, cash_amount) VALUES ('{action}', '{ticker}', {quantity}, {lastPrice}, {cashAmount});";
            currentDBConnection.Insert(query);
        }

        private void RecordStockProfile(string description, string ticker, string assetType, decimal lastPrice)
        {

            string query = $"INSERT into stock_profile VALUES ('{description}', '{ticker}', '{assetType}', {lastPrice});";
            currentDBConnection.Insert(query);
        }

        private void CashAdjustment(string action, decimal cashAmount, decimal currentCash)
        {
            decimal newCashAmount = currentCash;
            if (action == "BUY")
            {
                newCashAmount = currentCash - cashAmount;
            }
            else if (action == "SELL")
            {
                newCashAmount = currentCash + cashAmount;
            }
            
            string query = $"UPDATE holdings SET quantity={newCashAmount} WHERE ticker='CASH'";
            currentDBConnection.Update(query);
        }
    }
}
