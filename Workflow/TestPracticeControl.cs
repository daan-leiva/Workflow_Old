using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workflow
{
    public partial class TestPracticeControl : UserControl
    {
        public TestPracticeControl()
        {
            InitializeComponent();

        }

        public event EventHandler NameChange;

        protected virtual void OnNameChange(EventArgs e)
        {
            EventHandler handler = NameChange;
            if(handler != null)
            {
                this.label1_FullName.Text = this.textBox1_FirstName.Text + " " + this.textBox2_MiddleName.Text + " " + this.textBox3_LastName.Text;
            }
            
        }

        private void label1_FullName_Paint(object sender, PaintEventArgs e)
        {

        }
    }

    
}
