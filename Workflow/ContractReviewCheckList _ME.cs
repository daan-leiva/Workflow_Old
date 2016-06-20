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
            
        }
        #region buttonclicks
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
        #endregion


        

        

        private void ContractReviewCheckList_ME_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 79; i += 2)
            {
                tableLayoutPanel1.RowStyles[i].Height = 0;
            }
        }

        #region textChange
        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox8.Text == "")
            {
                button1.Text = "Create Note";

            }
            else
                button1.Text = "View/Edit";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (textBox9.Text == "")
            {
                button2.Text = "Create Note";

            }
            else
                button2.Text = "View/Edit";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox10.Text == "")
            {
                button3.Text = "Create Note";

            }
            else
                button3.Text = "View/Edit";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text == "")
            {
                button4.Text = "Create Note";

            }
            else
                button4.Text = "View/Edit";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (textBox12.Text == "")
            {
                button5.Text = "Create Note";

            }
            else
                button5.Text = "View/Edit";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (textBox13.Text == "")
            {
                button6.Text = "Create Note";

            }
            else
                button6.Text = "View/Edit";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (textBox14.Text == "")
            {
                button7.Text = "Create Note";

            }
            else
                button7.Text = "View/Edit";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (textBox15.Text == "")
            {
                button8.Text = "Create Note";

            }
            else
                button8.Text = "View/Edit";
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (textBox16.Text == "")
            {
                button9.Text = "Create Note";

            }
            else
                button9.Text = "View/Edit";
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (textBox17.Text == "")
            {
                button10.Text = "Create Note";

            }
            else
                button10.Text = "View/Edit";
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (textBox18.Text == "")
            {
                button11.Text = "Create Note";

            }
            else
                button11.Text = "View/Edit";
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (textBox19.Text == "")
            {
                button12.Text = "Create Note";

            }
            else
                button12.Text = "View/Edit";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (textBox20.Text == "")
            {
                button13.Text = "Create Note";

            }
            else
                button13.Text = "View/Edit";
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (textBox21.Text == "")
            {
                button14.Text = "Create Note";

            }
            else
                button14.Text = "View/Edit";
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (textBox22.Text == "")
            {
                button15.Text = "Create Note";

            }
            else
                button15.Text = "View/Edit";
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (textBox23.Text == "")
            {
                button16.Text = "Create Note";

            }
            else
                button16.Text = "View/Edit";
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (textBox24.Text == "")
            {
                button17.Text = "Create Note";

            }
            else
                button17.Text = "View/Edit";
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (textBox25.Text == "")
            {
                button18.Text = "Create Note";

            }
            else
                button18.Text = "View/Edit";
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (textBox26.Text == "")
            {
                button19.Text = "Create Note";

            }
            else
                button19.Text = "View/Edit";
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (textBox27.Text == "")
            {
                button20.Text = "Create Note";

            }
            else
                button20.Text = "View/Edit";
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (textBox28.Text == "")
            {
                button21.Text = "Create Note";

            }
            else
                button21.Text = "View/Edit";
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (textBox29.Text == "")
            {
                button22.Text = "Create Note";

            }
            else
                button22.Text = "View/Edit";
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (textBox30.Text == "")
            {
                button23.Text = "Create Note";

            }
            else
                button23.Text = "View/Edit";
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (textBox31.Text == "")
            {
                button24.Text = "Create Note";

            }
            else
                button24.Text = "View/Edit";
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (textBox32.Text == "")
            {
                button25.Text = "Create Note";

            }
            else
                button25.Text = "View/Edit";
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (textBox33.Text == "")
            {
                button26.Text = "Create Note";

            }
            else
                button26.Text = "View/Edit";
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (textBox34.Text == "")
            {
                button27.Text = "Create Note";

            }
            else
                button27.Text = "View/Edit";
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (textBox35.Text == "")
            {
                button28.Text = "Create Note";

            }
            else
                button28.Text = "View/Edit";
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (textBox36.Text == "")
            {
                button29.Text = "Create Note";

            }
            else
                button29.Text = "View/Edit";
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (textBox37.Text == "")
            {
                button30.Text = "Create Note";

            }
            else
                button30.Text = "View/Edit";
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (textBox38.Text == "")
            {
                button31.Text = "Create Note";

            }
            else
                button31.Text = "View/Edit";
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (textBox39.Text == "")
            {
                button32.Text = "Create Note";

            }
            else
                button32.Text = "View/Edit";
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (textBox40.Text == "")
            {
                button33.Text = "Create Note";

            }
            else
                button33.Text = "View/Edit";
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (textBox41.Text == "")
            {
                button34.Text = "Create Note";

            }
            else
                button34.Text = "View/Edit";
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (textBox42.Text == "")
            {
                button35.Text = "Create Note";

            }
            else
                button35.Text = "View/Edit";
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (textBox43.Text == "")
            {
                button36.Text = "Create Note";

            }
            else
                button36.Text = "View/Edit";
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (textBox44.Text == "")
            {
                button37.Text = "Create Note";

            }
            else
                button37.Text = "View/Edit";
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (textBox45.Text == "")
            {
                button38.Text = "Create Note";

            }
            else
                button38.Text = "View/Edit";
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (textBox46.Text == "")
            {
                button39.Text = "Create Note";

            }
            else
                button39.Text = "View/Edit";
        }
        #endregion
    }
}
