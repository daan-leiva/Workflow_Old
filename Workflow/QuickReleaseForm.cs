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
    public partial class QuickReleaseForm : Form
    {
        public QuickReleaseForm()
        {
            InitializeComponent();
        }

        private void QuickReleaseForm_Load(object sender, EventArgs e)
        {
            // add set up for all combo boxes
            SetUpDropdown(comboBox1);
            SetUpDropdown(comboBox2);
            SetUpDropdown(comboBox3);
            SetUpDropdown(comboBox4);
            SetUpDropdown(comboBox5);
            SetUpDropdown(comboBox6);
            SetUpDropdown(comboBox7);
            SetUpDropdown(comboBox8);
            SetUpDropdown(comboBox9);
            SetUpDropdown(comboBox10);
            SetUpDropdown(comboBox11);
            SetUpDropdown(comboBox12);
            SetUpDropdown(comboBox13);
            SetUpDropdown(comboBox14);
            SetUpDropdown(comboBox15);
        }

        private void SetUpDropdown(ComboBox combo_box)
        {
            combo_box.Items.Add("Yes");
            combo_box.Items.Add("No");
            combo_box.Items.Add("N/A");

            combo_box.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
