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
    public partial class QuickReleaseForm_Engineering : Form
    {
        string jobNo;
        string partNo;

        public QuickReleaseForm_Engineering(string jobNo, string partNo)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.partNo = partNo;
        }

        private void QuickReleaseForm_Load(object sender, EventArgs e)
        {
            // add set up for all combo boxes
            SetUpDropdown(comboBox1);
            SetUpDropdown(comboBox3);
            SetUpDropdown(comboBox9);
            SetUpDropdown(comboBox10);
            SetUpDropdown(comboBox11);
            SetUpDropdown(comboBox12);
            SetUpDropdown(comboBox13);
            SetUpDropdown(comboBox14);
            SetUpDropdown(comboBox15);
            // initialize texboxes
            jobTextBox.Text = jobNo;
            partNumberTextBox.Text = partNo;
        }

        private void SetUpDropdown(ComboBox combo_box)
        {
            // clear items
            combo_box.Items.Clear();

            combo_box.Items.Add("Yes");
            combo_box.Items.Add("No");
            combo_box.Items.Add("N/A");

            combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
