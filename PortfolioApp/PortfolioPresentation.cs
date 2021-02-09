using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioApp
{
    public partial class PortfolioPresentation : Form
    {

        public PortfolioPresentation()
        {
            InitializeComponent();
        }

        //Region - Current Portfolio

        private void clickButtonFetchPort_Click(object sender, EventArgs e)
        {
            //Update Stock Profile Page from last from API
            
            string query = "SELECT * from holdings";
            dataGridView1.DataSource = DB_DatagridView(query);
        }

        //End Region - Current Portfolio

        //Region - Get Quote Info

        private void buttonGetQuote_Click(object sender, EventArgs e)
        {
            var response = APIQuoteInfo.GetPriceInfo();
            decimal lastPrice = response.Ticker.LastPrice;
            string description = response.Ticker.Description;
            string assetType = response.Ticker.AssetType;
            double volume = response.Ticker.TotalVolume;

            labelLastPrice.Text = lastPrice.ToString();
            labelQuoteDescription.Text = description;
            labelQuoteAssetType.Text = assetType;
            labelVolume.Text = volume.ToString();

        }

        //End Region - Get Quote Info

        //Region - Transactions

        private void buttonTradeSubmit_Click(object sender, EventArgs e)
        {
            Trade trade = new Trade();
            string ticker = textBoxTradeTicker.Text.ToUpper();
            decimal quantity = ConvertStringtoDecimal(textBoxQuantity.Text);

            if (comboBoxBuySell.Text == "BUY")
            {
                trade.BuyTrade(ticker, quantity);
            }
            else if (comboBoxBuySell.Text == "SELL")
            {
                trade.SellTrade(ticker, quantity);
            }
            else
            {
                //Please select action mesg
            }

        }


        //End Region - Transactions

        private void buttonFetchTransactions_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from transactions";
            dataGridViewTransactions.DataSource = DB_DatagridView(query);
        }


        private BindingSource DB_DatagridView(string query)
        {
            DBConnect currentDBConnection = new DBConnect();
            //NEED to add a join to this table to pull from stock profile and transaction,
            //showing description, current price and market value using sql commands
            DataTable table = new DataTable();
            table = currentDBConnection.Select(query);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }


        private decimal ConvertStringtoDecimal(string stringVal)
        {
            decimal decimalVal = 0;
            try
            {
                decimalVal = System.Convert.ToDecimal(stringVal);
            }
            catch (System.OverflowException)
            {
                //System.Console.WriteLine(
                //    "The conversion from string to decimal overflowed.");
            }
            catch (System.FormatException)
            {
                //System.Console.WriteLine(
                //    "The string is not formatted as a decimal.");
            }
            catch (System.ArgumentNullException)
            {
                //System.Console.WriteLine(
                //    "The string is null.");
            }

            return decimalVal;
        }


    }

}
