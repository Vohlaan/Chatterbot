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
            MySqlConnection MySqlConnection = new MySqlConnection(SQLConnectionString);
            MySqlCommand MySqlCommand = new MySqlCommand(Execute, MySqlConnection);

            MySqlCommand.CommandTimeout = 30;
            MySqlDataReader MySqlReader;
        }
    }
}
