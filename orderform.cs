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
    public partial class orderform : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection
        ("datasource=localhost;port=3307;Database=MES;username=root;password=123qwe");
        MySqlCommand mySqlCommand;
        MySqlDataAdapter mySqlDataAdapter;
        public orderform()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string insertQuery =
            "START TRANSACTION; " +
            "INSERT INTO order_info_head(ORDER_NO) VALUES('" 
            + orderNotxt.Text + "');"  +
            "INSERT INTO order_info_body(DATA_ID, ORDER_NO) VALUES('" +
             dataIdtxt.Text + "','" + orderNotxt.Text + "');" +
             "COMMIT;";

            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand(insertQuery, mySqlConnection);

            try
            {
                    if(mySqlCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("성공");
                }
                else
                {
                    MessageBox.Show("성공");
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message);  }
        }
    }
}
