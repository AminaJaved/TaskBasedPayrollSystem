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
    public partial class frmAdminReg : Form
    {
        private static frmAdminReg l = null;
        public frmAdminReg()
        {
            InitializeComponent();
        }
        public static frmAdminReg getInstance()
        {
            if (l == null)
            {
                l = new frmAdminReg();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            Image img = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        int count = 0;
        private void cmdSignup_Click(object sender, EventArgs e)
        {

            bool exist = false;
            bool blank = false;
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Username should not be Blank");
                blank = true;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("PAssword should not be Blank");
                blank = true;
            }
            foreach (Employee x in EmployeeDL.adminName)
            {
                if (x.AdminName == txtUserName.Text)
                {
                    MessageBox.Show("Username is already registered");
                    exist = true;

                }
            }

            if (count<1 && blank != true )
                {


                    Employee a = new Employee();
                    a.AdminName = txtUserName.Text;
                    a.AdminPassword = txtPassword.Text;
                    a.AdminImage = pictureBox1.Image;
                    EmployeeDL.adminName.Add(a);
                    txtPassword.Text = "";
                    txtUserName.Text = "";                    
                    pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.blank_dp;
                    MessageBox.Show("Registered as an Admin");
                    count++;
                

                
            }
            else
            {
                MessageBox.Show("Only one Admin can register");
            }
            
        }

        private void llLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            frmLogin l = frmLogin.getInstance();
            l.Show();
            this.Hide();
        }

        private void frmAdminReg_Load(object sender, EventArgs e)
        {

        }
    }
}
