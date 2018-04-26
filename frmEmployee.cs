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
    public partial class frmEmployee : Form
    {
        private static frmEmployee l = null;
        public frmEmployee()
        {
            InitializeComponent();
        }
        public static frmEmployee getInstance()
        {
            if (l == null)
            {
                l = new frmEmployee();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            bool exist = false;
            bool blank = false;
            if (txtEmployeeName.Text == "")
            {
                MessageBox.Show("Username should not be Blank");
                blank = true;
            }
            if (txtEmployeePassword.Text == "")
            {
                MessageBox.Show("PAssword should not be Blank");
                blank = true;
            }
            if (txtEmployeeID.Text == "")
            {
                MessageBox.Show("ID must be Assign to Employee");
                blank = true;
            }
            if (txtEmployeeDesignation.Text == "")
            {
                MessageBox.Show("Designation should be mentioned");
                blank = true;
            }
            foreach (Employee x in EmployeeDL.employeeName)
            {
                if (x.EmployeeID == txtEmployeeID.Text )
                {
                    MessageBox.Show("ID should be Unique");
                    exist = true;

                }
                if (x.EmployeeName == txtEmployeeName.Text && x.EmployeePassword==txtEmployeePassword.Text)
                {
                    MessageBox.Show("Employee name and password Already taken, Change Name or Password");
                    exist = true;

                }
              goto abc;
                
            }
            abc:
                foreach (Employee y in EmployeeDL.adminName)
                {
                    if (y.AdminName == txtEmployeeName.Text && y.AdminPassword == txtEmployeePassword.Text)
                    {
                        MessageBox.Show("Employee cann't be register, This is Admin Name & Password");
                        exist = true;

                    }

                }
                if (exist != true && blank != true)
                {
                    Employee a = new Employee();
                    a.EmployeeName = txtEmployeeName.Text;
                    a.EmployeePassword = txtEmployeePassword.Text;
                    a.EmployeeID = txtEmployeeID.Text;
                    a.EmployeeDesignation = txtEmployeeDesignation.Text;
                    // a.AdminImage = pictureBox1.Image;
                    EmployeeDL.employeeName.Add(a);
                    txtEmployeePassword.Text = "";
                    txtEmployeeName.Text = "";
                    txtEmployeeDesignation.Text = "";
                    txtEmployeeID.Text = "";
                    // checkBox1.CheckState = CheckState.Unchecked;
                    //pictureBox1.Image = WindowsFormsApplication1.Properties.Resources.noProfile;
                    MessageBox.Show("Employee is added");
                }

            }
        

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminHome l = frmAdminHome.getInstance();
            l.Show();
            this.Hide();
        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
