using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1;

namespace WindowsFormsApplication2
{
    public partial class frmAdminHome : Form
    {
        private static frmAdminHome l = null;
        public frmAdminHome()
        {
            InitializeComponent();
        }
        public static frmAdminHome getInstance()
        {
            if (l == null)
            {
                l = new frmAdminHome();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmAdminHome_Load(object sender, EventArgs e)
        {
            foreach (Employee user in EmployeeDL.adminName)
            {
                ctlEmployeeDisplay ctl = new ctlEmployeeDisplay(user.AdminImage, user.AdminName);
                flowLayoutPanel1.Controls.Add(ctl);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            frmStart l = frmStart.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmEmployee l = frmEmployee.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAddTask l = frmAddTask.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeleteEmployee l = frmDeleteEmployee.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmShowAllEmployee l = frmShowAllEmployee.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
