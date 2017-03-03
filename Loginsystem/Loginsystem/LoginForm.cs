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
using System.IO;

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
            /*
             2. Crypto
            */

            string SQLConnectionString = null;
            string Execute = "SELECT * FROM ID where USERNAME = '" + textBoxUsername.Text + "'";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("..\\..\\..\\Data.xml");

            XmlNodeList xmlListNode = xmlDoc.SelectNodes("root/Information/Database");
            foreach (XmlNode iCounterNode in xmlListNode)
            {
                string datasource = iCounterNode["datasource"].InnerText;
                string port = iCounterNode["port"].InnerText;

                string username = iCounterNode["username"].InnerText;
                string password = iCounterNode["password"].InnerText;

                string database = iCounterNode["database"].InnerText;
                
                SQLConnectionString = "datasource=" + datasource + ";" + "port=" + port + ";" + "username=" + username + ";" + "password=" + password + ";" + "database=" + database + ";";
            }

            MySqlConnection MySqlConnection = new MySqlConnection(SQLConnectionString);
            MySqlCommand MySqlCommand = new MySqlCommand(Execute, MySqlConnection);

            MySqlCommand.CommandTimeout = 30;
            MySqlDataReader MySqlReader;

            try
            {
                MySqlConnection.Open(); //Open the sql connection
                MySqlReader = MySqlCommand.ExecuteReader();

                if (MySqlReader.HasRows)
                {

                    MySqlReader.Read();
                    
                    const int POS_PASSWD = 2; /*Naja geht halt so warum nicht global ? :=) */

                    if (textBoxPassword.Text == MySqlReader.GetString(POS_PASSWD))
                    {
                        MessageBox.Show("Login Successfull");
                    }
                    else
                    {
                        MessageBox.Show("Username or Password wrong");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password wrong");
                }
                MySqlConnection.Close(); //Closing the sql connection
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }

            textBoxUsername.Text = "";
            textBoxPassword.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateLoginForm CreateLoginForm = new CreateLoginForm();
            CreateLoginForm.Show();
        }
    }
}
