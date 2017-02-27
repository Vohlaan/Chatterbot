using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Xml;

namespace Loginsystem
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            CurrentTimeTimer.Start();
        }

        private void CurrentTimeTimer_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabelTimeText.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {

            string SQLDatabaseName = "lizenz";
            string SQLConnectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=" + SQLDatabaseName + ";";

            string Execute = "SELECT * FROM ID where USERNAME = '" +textBoxUsername.Text+ "'";

            MySqlConnection MySqlConnection = new MySqlConnection(SQLConnectionString);
            MySqlCommand MySqlCommand = new MySqlCommand(Execute, MySqlConnection);

            MySqlCommand.CommandTimeout = 30;
            MySqlDataReader MySqlReader;

            try
            {

                MySqlConnection.Open();
                MySqlReader = MySqlCommand.ExecuteReader();

                if (MySqlReader.HasRows)
                {

                    while (MySqlReader.Read())
                    {
                       
                        if (textBoxPassword.Text == MySqlReader.GetString(2))
                        {
                            MessageBox.Show("Login Successfull");
                        }
                        else
                        {
                            MessageBox.Show("Username or Password a wrong");
                        }
                    }
                }
                else {
                    MessageBox.Show("Username or Password a wrong");
                }

            }
            catch (Exception ex){

                MessageBox.Show("Username or Password a wrong");
            }

            MySqlConnection.Close();
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
        }
    }
}
