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
    public partial class frmAddTask : Form
    {
        private static frmAddTask l = null;
        public frmAddTask()
        {
            InitializeComponent();
        }
        public static frmAddTask getInstance()
        {
            if (l == null)
            {
                l = new frmAddTask();
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
            bool blank = false;
            if (txtTask.Text == "")
            {
                MessageBox.Show("Task must be added");
                blank = true;
            }
            if (txtDes.Text == "")
            {
                MessageBox.Show("Designation should not be Blank");
                blank = true;
            }
            if (txtDetail.Text == "")
            {
                MessageBox.Show("Details must be Added");
                blank = true;
            }
            if (blank == false)
            {
                Task pd = new Task();
                pd.Tasks = txtTask.Text;
                pd.Designation = txtDes.Text;
                pd.TaskDetails = txtDetail.Text;
                TaskDL.tsk.Add(pd);
                MessageBox.Show("Taks Added");

                BindingSource source = new BindingSource();
                source.DataSource = TaskDL.tsk;
                dataGrid.DataSource = source;
            }
        }
        private void frmAddTask_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmAdminHome l = frmAdminHome.getInstance();
            l.Show();
            this.Hide();
        }
    }
}
