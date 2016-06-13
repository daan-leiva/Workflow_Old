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
    public partial class JobListViewer : Form
    {
        public JobListViewer()
        {
            InitializeComponent();
        }

        private void JobListViewer_Load(object sender, EventArgs e)
        {
            // set date time picker range to between a year from now and today
            startDateTimePicker.Value = DateTime.Now.AddYears(-1);
            endDateTimePicker.Value = DateTime.Now;
        }

        private void customerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void partNoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void jobTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateDataGridView(object sender, EventArgs e)
        {

        }
    }
}
