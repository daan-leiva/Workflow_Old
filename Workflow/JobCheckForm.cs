using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workflow
{
    public partial class JobCheckForm : Form
    {
        public JobCheckForm()
        {
            InitializeComponent();
            testCommentPopUp1.Visible = false;
        }


        private void JobCheckForm_Load(object sender, EventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (testCommentPopUp1.Visible == true)
            {
                testCommentPopUp1.Visible = false;
            }
            else
                testCommentPopUp1.Visible = true;
            
        }
    }
}
