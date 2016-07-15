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
    public partial class RollsRoycePOReview : Form
    {
        string jobNo;
        bool readOnly;
        public string type { get; set; }

        public RollsRoycePOReview(string jobNo, bool readOnly)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.readOnly = readOnly;
            type = "Invalid";
        }

        private void RollsRoycePOReview_Load(object sender, EventArgs e)
        {
            this.jobNoLabel.Text = jobNo;

            // disable if readonly
            if (readOnly)
                submitButton.Hide();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // go to status page with job, partNo and customer
            if (partNoLabel.Text.Trim().Length == 0)
                return;

            // calculate the type of form to create after
            string type = string.Empty;
            if (question3YesRadioButton.Checked || question4YesRadioButton.Checked
                || question5YesRadioButton.Checked || question6YesRadioButton.Checked)
                type = "Contract Review";
            else if (!question3YesRadioButton.Checked || !question4YesRadioButton.Checked
                || !question5YesRadioButton.Checked || !question6YesRadioButton.Checked)
            {
                if (question1NewRadioButton.Checked)
                    type = "Quick Release";
                else if (question1ActiveRadioButton.Checked || question1CompleteRadioButton.Checked)
                    type = "Nothing";
            }


            if (this.Modal)
            {
                // submit query info: TOD_DO

                this.Close();
            }
            else
            {
                // load status page
                this.Hide();
                Form statusForm = new StatusPage(jobNo, partNoLabel.Text.Trim(), "ROLLS", type);
                statusForm.FormClosed += (s, args) => this.Close();
                statusForm.Show();
            }
        }
    }
}
