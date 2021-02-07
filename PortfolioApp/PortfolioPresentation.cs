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

        private void clickButtonFetchPort_Click(object sender, EventArgs e)
        {
            DB_ToDatagridview();
        }

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

        private void DB_ToDatagridview()
        {
            DBConnect currentDBConnection = new DBConnect();
            //NEED to add a join to this table to pull from stock profile and transaction,
            //showing description, current price and paid price using sql commands
            DataTable table = new DataTable();
            table = currentDBConnection.Select();

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataGridView1.DataSource = bSource;
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
