using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class LoginForm : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection
        ("datasource=localhost;port=3307;Database=MES;username=root;password=123qwe");
        MySqlCommand mySqlCommand;
        MySqlDataAdapter mySqlDataAdapter;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
