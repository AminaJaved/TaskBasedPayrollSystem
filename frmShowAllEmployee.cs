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
    public partial class frmShowAllEmployee : Form
{   private static frmShowAllEmployee l = null;
       
        public frmShowAllEmployee()
        {
            InitializeComponent();
        }
        public static frmShowAllEmployee getInstance()
        {
            if (l == null)
            {
                l = new frmShowAllEmployee();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        private void frmShowAllEmployee_Load(object sender, EventArgs e)
        {
            BindingSource source = new BindingSource();
            source.DataSource = EmployeeDL.employeeName;
            dataGrid.DataSource = source;
            dataGrid.Columns[1].Visible = false;
            dataGrid.Columns[2].Visible = false;
            dataGrid.Columns[4].Visible = false;
            dataGrid.Columns[5].Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminHome l = frmAdminHome.getInstance();
            l.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDeleteEmployee l = frmDeleteEmployee.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
