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
    public partial class frmDeleteEmployee : Form
    {
        private static frmDeleteEmployee l = null;
        public frmDeleteEmployee()
        {
            InitializeComponent();
        }
        public static frmDeleteEmployee getInstance()
        {
            if (l == null)
            {
                l = new frmDeleteEmployee();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void frmDeleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminHome l = frmAdminHome.getInstance();
            l.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {   Boolean isAdmin = false;
            foreach (Employee a in EmployeeDL.employeeName)
            {
                
                if (a.EmployeeName == txtName.Text && a.EmployeeID == txtID.Text)
                {
                    txtName.Text = "";
                    txtID.Text = "";
                    isAdmin = true;
                    a.EmployeeID = null;
                    a.EmployeeName = null;
                    a.EmployeePassword = null;
                    a.EmployeeDesignation = null;
                    MessageBox.Show("Employee deleted Successfully!");
                    
                }
            }
                
                
                if(isAdmin==false)
                {
                    MessageBox.Show("Employee not registered");

                    
                }
            }
        }
    }

