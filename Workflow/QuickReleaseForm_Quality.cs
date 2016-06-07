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
    public partial class QuickReleaseForm_Quality : Form
    {
        public QuickReleaseForm_Quality()
        {
            InitializeComponent();
        }

        private void QuickReleaseForm_Load(object sender, EventArgs e)
        {
            // add set up for all combo boxes
            SetUpDropdown(comboBox2);
            SetUpDropdown(comboBox4);
            SetUpDropdown(comboBox5);
            SetUpDropdown(comboBox6);
            SetUpDropdown(comboBox7);
            SetUpDropdown(comboBox8);
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
    }
}
