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
            decimal currentHoldingQuantity = this.CurrentHoldingQuantity(ticker);
            //check if already holding
            if (currentHoldingQuantity >= 1)
            {
                decimal newQuantity = quantity + currentHoldingQuantity;
                string query = $"UPDATE holdings SET quantity={newQuantity} WHERE ticker='{ticker}'";
                currentDBConnection.Update(query);
            }
            else if (currentHoldingQuantity == 0)
            {
                string query = $"INSERT into holdings VALUES ('{ticker}', {quantity})";
                currentDBConnection.Insert(query);
            }
            else
            {
                //Error Mesg
            }
        }

        public void SellTrade(string ticker, decimal quantity)
        {
            decimal currentHoldingQuantity = this.CurrentHoldingQuantity(ticker);
            if (currentHoldingQuantity >= quantity)
            {
                decimal newQuantity = currentHoldingQuantity - quantity;
                string query = $"UPDATE holdings SET quantity={newQuantity} WHERE ticker='{ticker}'";
                currentDBConnection.Update(query);
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

        private void RecordTransaction(string ticker, decimal quantity)
        {
            //need to finish recording amounts 
            string query = $"INSERT into transactions VALUES ('{ticker}', {quantity})";
            currentDBConnection.Insert(query);
        }

    }
}
