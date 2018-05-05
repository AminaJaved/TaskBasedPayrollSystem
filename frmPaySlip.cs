using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class frmPaySlip : Form
    {
        private static frmPaySlip l = null;
        public frmPaySlip()
        {
            InitializeComponent();
            
        }
        public static frmPaySlip getInstance()
        {
            if (l == null)
            {
                l = new frmPaySlip();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        int pay;
        private void frmPaySlip_Load(object sender, EventArgs e)
        {
            pay = 0;
            
            foreach (Task t in TaskDL.tsk)
            {
               
                if (t.Task_Done == true)
                {
                    pay=pay+10;
                    paydata ctl = new paydata(t.Tasks, t.TaskDetails);
                    flowLayoutPanel1.Controls.Add(ctl);
                    
                }
            }

            string myString = pay.ToString();
            lblslip.Text = myString;
            lblDate.Text = DateTime.Now.ToLongDateString();
        }

        private void GoBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //EmployeeHome l = EmployeeHome.getInstance();
            //l.Show();
            this.Hide();
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblslip_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
