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
    public partial class ContractReviewCheckList : Form
    {
        public ContractReviewCheckList()
        {
            InitializeComponent();
            textBox8.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox8.Visible == false)
            {
                textBox8.Visible = true;
            }
            else
                textBox8.Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
