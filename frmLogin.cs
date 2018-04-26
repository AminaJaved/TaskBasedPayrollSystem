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
    public partial class frmLogin : Form
    {
        private static frmLogin l = null;
        public frmLogin()
        {
            InitializeComponent();
        }
        public static frmLogin getInstance()
        {
            if (l == null)
            {
                l = new frmLogin();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void cmdLogin_Click(object sender, EventArgs e)
        {
           Boolean isAdmin = false;
                foreach (Employee a in EmployeeDL.adminName  )
                {
                    
                    if (a.AdminName == txtUserName.Text && a.AdminPassword == txtPassword.Text)
                    {
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        isAdmin = true;
                       //MyUtil.loginUser = a;
                    }

                    this.Hide();
                   

                }
                
                if (isAdmin)
                {
                    frmAdminHome admin = new frmAdminHome();
                    admin.Show();
                   MessageBox.Show("Admin Login Successfully");
                   goto found;
                }
               /* else
                {
                   MessageBox.Show("invalid user");
                }
            */
                Boolean isFound = false;
                foreach (Employee i in EmployeeDL.employeeName)
                {
                    if (i.EmployeeName == txtUserName.Text && i.EmployeePassword == txtPassword.Text)
                    {
                        isFound = true;
                        txtUserName.Text = "";
                        txtPassword.Text = "";
                        MyUtil.loginUser = i;
                       
                    }

                    

                }

                if (isFound)
                {
                    this.Hide();
                    EmployeeHome contact = new EmployeeHome();
                    contact.Show();
                    MessageBox.Show("Logged in as an Employee");
                }
             else
             {
               MessageBox.Show("Employee not Registered!");
              }

            found:
                int y = 5;
            
        }
            
        
            
                

    

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminReg l = frmAdminReg.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
