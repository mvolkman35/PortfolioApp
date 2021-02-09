using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortfolioApp
{
    class Trade
    {
        DBConnect currentDBConnection = new DBConnect();
        public Trade() 
        {
            //Set up all values needed like ticker, quantity, last price, cash amount
        }

        public void BuyTrade(string ticker, decimal quantity)
        {

            //set needed variables
            //var response = APIQuoteInfo.GetPriceInfo();
            //decimal lastPrice = response.Ticker.LastPrice;
            decimal lastPrice = 100;
            decimal cashAmount = lastPrice * quantity;

            //check if already holding
            decimal currentHoldingQuantity = this.CurrentHoldingQuantity(ticker);
            if (currentHoldingQuantity >= 1)
            {
                decimal newQuantity = quantity + currentHoldingQuantity;
                string query = $"UPDATE holdings SET quantity={newQuantity} WHERE ticker='{ticker}'";
                currentDBConnection.Update(query);

                RecordTransaction("BUY", ticker, quantity, lastPrice, cashAmount);

            }
            else if (currentHoldingQuantity == 0)
            {
                string query = $"INSERT into holdings VALUES ('{ticker}', {quantity})";
                currentDBConnection.Insert(query);

                RecordTransaction("BUY", ticker, quantity, lastPrice, cashAmount);
            }
            else
            {
                //Error Mesg
            }
        }

        public void SellTrade(string ticker, decimal quantity)
        {
            decimal currentHoldingQuantity = this.CurrentHoldingQuantity(ticker);
            if (currentHoldingQuantity > quantity)
            {
                decimal newQuantity = currentHoldingQuantity - quantity;
                string query = $"UPDATE holdings SET quantity={newQuantity} WHERE ticker='{ticker}'";
                currentDBConnection.Update(query);

                
            }
            else if (currentHoldingQuantity == quantity)
            {
                string query = $"DELETE FROM holdings WHERE ticker='{ticker}'";
                currentDBConnection.Delete(query);
            }
            else 
            { 
                //Error Mesg
            }

        }

        private decimal CurrentHoldingQuantity(string ticker)
        {
            decimal quantity = 0;
            string query = $"SELECT Quantity FROM holdings WHERE ticker='{ticker}'";
            quantity = Decimal.ToInt32(currentDBConnection.ScalarQuery(query));
            return quantity;
        }

        //Need current cash amount method

        private void RecordTransaction(string action, string ticker, decimal quantity, 
            decimal lastPrice, decimal cashAmount)
        {
            string query = $"INSERT into transactions (trade_action, ticker, quantity_change, trade_price, cash_amount) VALUES ('{action}', '{ticker}', {quantity}, {lastPrice}, {cashAmount});";
            currentDBConnection.Insert(query);
        }

    }
}
