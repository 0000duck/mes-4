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
    public partial class production_plan : Form
    {
        public production_plan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            production_plan_reg production_Plan_Reg = new production_plan_reg();
            production_Plan_Reg.ShowDialog();
        }
    }
}
