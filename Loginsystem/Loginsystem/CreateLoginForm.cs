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

namespace Loginsystem
{
    public partial class CreateLoginForm : Form
    {
        public CreateLoginForm()
        {
            InitializeComponent();
        }


        private void buttonSendToDataBase_Click(object sender, EventArgs e)
        {
            string username = textBoxCreateUsername.Text;
            string password = textBoxCreatePassword.Text;
            string email = textBoxCreateEMail.Text;
            int userID;

            "INSERT INTO id (ID, USERNAME, PASSWORD, EMAIL) values (" + userID + "," + username + "," + password +"," + email + ");" 
        }
    }
}
