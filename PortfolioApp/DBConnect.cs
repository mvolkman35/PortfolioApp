using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioApp
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public DBConnect()
        {
            Initialize();
        }

        //Initialize values
        private void Initialize()
        {
            server = "localhost";
            database = "portfolio_app";
            uid = "root";
            password = "B@ndit5446";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server.  Contact administrator");
                        break;

                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        public void Insert(string query)
        {

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        //Update command
        public void Update(string query)
        {
            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand();

                cmd.CommandText = query;

                cmd.Connection = connection;


                cmd.ExecuteNonQuery();

                this.CloseConnection();
            }
        }

        public void Delete(string query)
        {

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        public DataTable Select(string query)
        {

            DataTable table = new DataTable();

            //Open connection
            if (this.OpenConnection() == true)
            {
                MySqlDataAdapter DBDataAdapter = new MySqlDataAdapter();
                DBDataAdapter.SelectCommand = new MySqlCommand(query, connection);

                DBDataAdapter.Fill(table);

                this.CloseConnection();

                return table;
            }
            else
            {
                return table;
            }
        }

        public decimal ScalarQuery(string query)
        {
            decimal scalarValue = 0;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);


                if (cmd.ExecuteScalar() != null)
                {
                    scalarValue = decimal.Parse(cmd.ExecuteScalar() + "");
                }

                this.CloseConnection();

                return scalarValue;
            }
            else
            {
                return scalarValue;
            }
        }
    }
}
