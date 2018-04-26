using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ctlEmployeeDisplay : UserControl
    {
        public ctlEmployeeDisplay()
        {
            InitializeComponent();
        }
        public ctlEmployeeDisplay(Image userImage, string userName)
        {
            InitializeComponent();
            lblUserName.Text = userName;
            pictureBox1.Image = userImage;
        }
        private void ctlEmployeeDisplay_Load(object sender, EventArgs e)
        {

        }
    }
}
