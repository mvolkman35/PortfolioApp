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
        //Make instance of connector class to use as neede
        DBConnect currentDBConnection = new DBConnect();
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

        }

        private void DB_ToDatagridview()
        {
            //NEED to add a join to this table to pull from stock profile and transaction, showing descrip
            //showing description, current price and paid price using sql commands
            DataTable table = new DataTable();
            table = currentDBConnection.Select();

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            dataGridView1.DataSource = bSource;
        }

}
