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
    public partial class EmployeeHome : Form
    {
        //DateTimePicker date = new DateTimePicker();
        private static EmployeeHome l = null;
        public EmployeeHome()
        {
            InitializeComponent();          
           
            Employee currentUser = MyUtil.loginUser;            
            pictureBox1.Image = currentUser.UserImage;

            //BindingSource sourc = new BindingSource();
            //sourc.DataSource = null;//MyUtil.loginUser.contacts;
            //dataGridView1.DataSource = sourc;
            
            
        }
        public static EmployeeHome getInstance()
        {
            if (l == null)
            {
                l = new EmployeeHome();
                l.Show();
                return l;
            }
            else
            {
                return l;
            }
        }
        
        private void EmployeeHome_Load(object sender, EventArgs e)
        {   
            Employee currentUser = MyUtil.loginUser;
            //linkLabel2.Text = currentUser.EmployeeName;
            label1.Text = currentUser.EmployeeName;
           // pictureBox1.Image = currentUser.UserImage;
            /*
            
            currentUser.UserImage = pictureBox1.Image;
            
             * 
             * */
           
            //date.Visible = false;
            //date.CustomFormat = "dd/MM/yyyy";
            //date.ValueChanged += dg1_ValueChanged;

            //dataGridView1.Dock = DockStyle.Fill;
            //dataGridView1.Controls.Add(date);
            //dataGridView1.CellClick += dataGridView1_CellClick;

            //Employee currentUser = MyUtil.loginUser;
            
            
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmStart l = frmStart.getInstance();
            l.Show();
            this.Hide();
            //foreach (Task t in TaskDL.tsk)
            //{
            //    if (t.Task_Done == true)
            //    {
            //        t.Task_Done = false;
            //    }
            //}
        }




        int i;
        private void button2_Click(object sender, EventArgs e)
        {
            i = 0;
            bool isFound = false;
            //Employee currentUser = MyUtil.loginUser;
            Employee currentUser = MyUtil.loginUser;
            if (i == 0)
            {
                foreach (Task t in TaskDL.tsk)
                {
                    if (t.EmpName == currentUser.EmployeeName)
                    {
                        isFound = true;
                        
                        //Employee currentUser = MyUtil.loginUser;
                        currentUser.contacts.Add(t);

                        BindingSource source = new BindingSource();
                        source.DataSource = MyUtil.loginUser.contacts;
                        dataGridView1.DataSource = source;
                        
                    }
                    i++;
                }
                if (isFound == false)
                {
                    MessageBox.Show("Tasks have not been assigned by the Admin Yet! Please Wait");
                }
            }
            else
            {
                foreach (Task s in TaskDL.tsk)
                {
                    if (s.EmpName == currentUser.EmployeeName)
                    {
                        isFound = true;
                        foreach (Task l in currentUser.contacts)
                        {
                            if (l.Tasks != s.Tasks && l.TaskDetails != s.TaskDetails)
                            {
                                currentUser.contacts.Add(s);

                                BindingSource source = new BindingSource();
                                source.DataSource = MyUtil.loginUser.contacts;
                                dataGridView1.DataSource = source;
                                i++;
                            }
                            
                        }
                        if (isFound == false)
                        {
                            MessageBox.Show("Tasks have not been assigned by the Admin Yet! Please Wait");
                        }
                    }
                }
            }
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.ColumnIndex == 0)
        //    {
        //        Rectangle cellRectangle = dataGridView1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);
        //        date.Location = cellRectangle.Location;
        //        date.Width = cellRectangle.Width;
        //        try
        //        {
        //            date.Value = DateTime.Parse(dataGridView1.CurrentCell.Value.ToString());

        //        }
        //        catch { }
        //        date.Visible = true;
        //    }
        //    else
        //    {
        //        date.Visible = false;
        //    }
        //}
        //private void dg1_ValueChanged(object sender, EventArgs e)
        //{
        //    dataGridView1.CurrentCell.Value = date.Value.ToString("dd/MM/yyyy");
        //    date.Visible = false;
        //}
        

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Image img = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox1.Image = img;
            Employee currentUser = MyUtil.loginUser;
            currentUser.UserImage= pictureBox1.Image;

        }

        private void cmdC_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        int pay;
        private void button1_Click(object sender, EventArgs e)
        {
            pay = 0;
            Employee currentUser = MyUtil.loginUser;
            foreach (Task t in currentUser.contacts)
            {
                
                if (t.Task_Done == true)
                {
                    pay=pay+10;
                }
            }
            
            string myString = pay.ToString();
            lblPay.Text = myString;

            //frmPaySlip l = frmPaySlip.getInstance();
            //l.Show();
            //this.Hide();

        }

        private void lblPay_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {


        }

        private void button3_Click(object sender, EventArgs e)
        {

            frmPaySlip l = frmPaySlip.getInstance();
            l.Show();
            //this.Hide();
        }
        void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if (System.Uri.IsWellFormedUriString(r.Cells["Links"].Value.ToString(), UriKind.Absolute))
                {
                    r.Cells["Links"] = new DataGridViewLinkCell();
                    DataGridViewLinkCell c = r.Cells["Links"] as DataGridViewLinkCell;
                }
            }
        }

        // And handle the click too
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewLinkCell)
            {
                System.Diagnostics.Process.Start(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value as string);
            }
        }
        
    }
}
