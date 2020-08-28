using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class Form2 : Form
    {
        Form1 form1;
        baljoo baljoo1;
        work_instruction work_Instruction;
        production_plan production_Plan;
        production_plan_con production_Plan_Con;

        MySqlConnection mySqlConnection = new MySqlConnection
        ("datasource=localhost;port=3307;Database=MES;username=root;password=123qwe");
        MySqlCommand mySqlCommand;
        MySqlDataAdapter mySqlDataAdapter;
        public Form2()
        {
            InitializeComponent();
        }

        private Form ShowForm(Form form, Type type)
        {
            if (form == null)
            {
                form = (Form)Activator.CreateInstance(type);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            if (form.IsDisposed)
            {
                form = (Form)Activator.CreateInstance(type);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            }
            else
            {
                form.Activate();
            }

            return form;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void 주문내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if(this.ActiveMdiChild != form1)
                {
                    ActiveMdiChild.Close();
                }

                form1 = ShowForm(form1, typeof(Form1)) as Form1;
            }
            else
            {
                form1 = ShowForm(form1, typeof(Form1)) as Form1;
            }
        }

        private void 발주등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != baljoo1)
                {
                    ActiveMdiChild.Close();
                }

                baljoo1 = ShowForm(baljoo1, typeof(baljoo)) as baljoo;
            }
            else
            {
                baljoo1 = ShowForm(baljoo1, typeof(baljoo)) as baljoo;
            }
        }

        private void 작업지시등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != work_Instruction)
                {
                    ActiveMdiChild.Close();
                }

                work_Instruction = ShowForm(work_Instruction, typeof(work_instruction)) as work_instruction;
            }
            else
            {
                work_Instruction = ShowForm(work_Instruction, typeof(work_instruction)) as work_instruction;
            }
        }

        private void 생산계획등록ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != production_Plan)
                {
                    ActiveMdiChild.Close();
                }

                production_Plan = ShowForm(production_Plan, typeof(production_plan)) as production_plan;
            }
            else
            {
                production_Plan = ShowForm(production_Plan, typeof(production_plan)) as production_plan;
            }
        }

        private void 생산계획현황ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != production_Plan_Con)
                {
                    ActiveMdiChild.Close();
                }

                production_Plan_Con = ShowForm(production_Plan_Con, typeof(production_plan_con)) as production_plan_con;
            }
            else
            {
                production_Plan_Con = ShowForm(production_Plan_Con, typeof(production_plan_con)) as production_plan_con;
            }
        }

        private void 주문정보ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

