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
            textBox10.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            textBox18.Visible = false;
            textBox19.Visible = false;
            textBox20.Visible = false;
            textBox21.Visible = false;
            textBox22.Visible = false;
            textBox23.Visible = false;
            textBox24.Visible = false;
            textBox25.Visible = false;
            textBox26.Visible = false;
            textBox27.Visible = false;
            textBox28.Visible = false;
            textBox29.Visible = false;
            textBox30.Visible = false;
            textBox31.Visible = false;
            textBox32.Visible = false;
            textBox33.Visible = false;
            textBox34.Visible = false;
            textBox35.Visible = false;
            textBox36.Visible = false;
            textBox37.Visible = false;
            textBox38.Visible = false;
            textBox39.Visible = false;
            textBox40.Visible = false;
            textBox41.Visible = false;
            textBox42.Visible = false;
            textBox43.Visible = false;
            textBox44.Visible = false;
            textBox45.Visible = false;
            textBox46.Visible = false;
            textBox47.Visible = false;
            textBox48.Visible = false;
            textBox49.Visible = false;
            textBox50.Visible = false;
            textBox51.Visible = false;
            textBox52.Visible = false;

            //Will Hide all rows with textboxes
            for (int i=1; i<94; i+=2)
            {
                //Skip 13th index there is no textbox there
                if(i == 13)
                {
                    i = i + 1;
                }

                tableLayoutPanel1.RowStyles[i].Height = 0; //hide row
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
