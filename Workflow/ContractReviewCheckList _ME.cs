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
    public partial class ContractReviewCheckList_ME : Form
    {
        public ContractReviewCheckList_ME()
        {
            InitializeComponent();
            for(int i=1; i<80; i+=2)
            {
                tableLayoutPanel1.RowStyles[i].Height = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox8.Visible = !textBox8.Visible;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            textBox9.Visible = !textBox9.Visible;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox10.Visible = !textBox10.Visible;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            textBox11.Visible = !textBox11.Visible;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            textBox12.Visible = !textBox12.Visible;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            textBox13.Visible = !textBox13.Visible;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            textBox14.Visible = !textBox14.Visible;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            textBox15.Visible = !textBox15.Visible;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            textBox16.Visible = !textBox16.Visible;

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            textBox17.Visible = !textBox17.Visible;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox18.Visible = !textBox18.Visible;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            textBox19.Visible = !textBox19.Visible;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            textBox20.Visible = !textBox20.Visible;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            textBox21.Visible = !textBox21.Visible;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            textBox22.Visible = !textBox22.Visible;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox23.Visible = !textBox23.Visible;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            textBox24.Visible = !textBox24.Visible;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            textBox25.Visible = !textBox25.Visible;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            textBox26.Visible = !textBox26.Visible;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            textBox27.Visible = !textBox27.Visible;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            textBox28.Visible = !textBox28.Visible;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            textBox29.Visible = !textBox29.Visible;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            textBox30.Visible = !textBox30.Visible;
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            textBox31.Visible = !textBox31.Visible;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            textBox32.Visible = !textBox32.Visible;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            textBox33.Visible = !textBox33.Visible;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            textBox34.Visible = !textBox34.Visible;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            textBox35.Visible = !textBox35.Visible;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            textBox36.Visible = !textBox36.Visible;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            textBox37.Visible = !textBox37.Visible;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            textBox38.Visible = !textBox38.Visible;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            textBox39.Visible = !textBox39.Visible;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            textBox40.Visible = !textBox40.Visible;
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            textBox41.Visible = !textBox41.Visible;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            textBox42.Visible = !textBox42.Visible;
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            textBox43.Visible = !textBox43.Visible;
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            textBox44.Visible = !textBox44.Visible;
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            textBox45.Visible = !textBox45.Visible;

        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            textBox46.Visible = !textBox46.Visible;

        }


        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                button2.Text = "Create";
               
            }
            else
                button2.Text = "View/Edit";

        }

       

        
    }
}
