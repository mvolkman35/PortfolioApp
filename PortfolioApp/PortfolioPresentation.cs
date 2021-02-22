using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            
            string query = "SELECT holdings.ticker, company_description, asset_type, quantity, last_price " +
                "FROM holdings INNER JOIN stock_profile ON holdings.ticker = stock_profile.ticker " +
                "ORDER BY holdings.ticker ASC;";
            dataGridView1.DataSource = DB_DatagridView(query);
        }

        //End Region - Current Portfolio

        //Region - Get Quote Info

        private void buttonGetQuote_Click(object sender, EventArgs e)
        {
            string userInputTicker = tickerVerifier(textBoxTickerInput.Text);
            if (userInputTicker != "invalid")
            {
                JSONParseQuote response = APIQuoteInfo.GetPriceInfo(userInputTicker);
                decimal lastPrice = response.Ticker.LastPrice;
                string description = response.Ticker.Description;
                string assetType = response.Ticker.AssetType;
                double volume = response.Ticker.TotalVolume;

                labelLastPrice.Text = lastPrice.ToString();
                labelQuoteDescription.Text = description;
                labelQuoteAssetType.Text = assetType;
                labelVolume.Text = volume.ToString();
            }
            else
            {
                MessageBox.Show("Enter valid ticker.");
            }

        }

        //End Region - Get Quote Info

        //Region - Transactions

        private void buttonTradeSubmit_Click(object sender, EventArgs e)
        {


            string userInputTicker = tickerVerifier(textBoxTradeTicker.Text);
            decimal userInputQuantity = quantityVerifier(textBoxQuantity.Text);


            if (userInputTicker != "invalid" && userInputTicker != "CASH" && userInputQuantity != 0)
            {
                Trade trade = new Trade(userInputTicker, userInputQuantity);

                if (comboBoxBuySell.Text == "BUY")
                {
                    trade.BuyTrade();
                }
                else if (comboBoxBuySell.Text == "SELL")
                {
                    trade.SellTrade();
                }
                else
                {
                    MessageBox.Show("Enter a action.");
                }
            }
            else
            {
                MessageBox.Show("Please review ticker and quantity. No cash entry as well.");
            }

        }


        

        private void buttonFetchTransactions_Click(object sender, EventArgs e)
        {
            string query = "SELECT * from transactions";
            dataGridViewTransactions.DataSource = DB_DatagridView(query);
        }

        //End Region - Transactions

        //Region - UI helper methods
        private BindingSource DB_DatagridView(string query)
        {
            DBConnect currentDBConnection = new DBConnect();
            DataTable table = new DataTable();
            table = currentDBConnection.Select(query);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;
            return bSource;
        }



        private string tickerVerifier(string userInputTicker)
        {
            string verifiedTicker = "invalid";
            Regex rgx = new Regex(@"^[A-Za-z]{1,5}$");
            if (rgx.IsMatch(userInputTicker))
            {
                verifiedTicker = userInputTicker.ToUpper();
                return verifiedTicker;
            }
            else
            {
                return verifiedTicker;
            }
        }

        private decimal quantityVerifier(string userInputQuantity)
        {
            decimal verifiedQuantity = 0;
            Regex rgx = new Regex(@"^\d+$");
            if (rgx.IsMatch(userInputQuantity))
            {
                verifiedQuantity = ConvertStringtoDecimal(userInputQuantity);
                return verifiedQuantity;
            }
            else
            {
                return verifiedQuantity;
            }
        }


        private decimal ConvertStringtoDecimal(string stringVal)
        {
            decimal decimalVal = 0;
            try
            {
                decimalVal = System.Convert.ToDecimal(stringVal);
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.Message);
            }

            return decimalVal;
        }

    }

}
