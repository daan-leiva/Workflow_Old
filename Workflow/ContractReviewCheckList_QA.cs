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
    public partial class ContractReviewCheckList_QA : Form
    {
        public ContractReviewCheckList_QA()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Visible = !textBox8.Visible;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox9.Visible = !textBox9.Visible;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox10.Visible = !textBox10.Visible;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox11.Visible = !textBox11.Visible;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox12.Visible = !textBox12.Visible;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox13.Visible = !textBox13.Visible;
        }
    }
}
