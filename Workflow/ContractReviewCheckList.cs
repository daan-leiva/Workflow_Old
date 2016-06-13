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
            textBox9.Visible = false;
            for(int i=1; i<95; i+=2)
            {
                tableLayoutPanel1.RowStyles[i].Height = 0;
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (textBox8.Visible == false)
            {
                textBox8.Visible = true;
                tableLayoutPanel1.RowStyles[1].Height = 2;
            }
            else
            {
                tableLayoutPanel1.RowStyles[1].Height = 0;
                textBox8.Visible = false;
            }
                
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
