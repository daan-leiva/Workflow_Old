﻿using System;
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
    public partial class HondaPOReview : Form
    {
        string jobNo;
        bool readOnly;

        public HondaPOReview(string jobNo, bool readOnly)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.readOnly = readOnly;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // go to status page with job, partNo and customer
            if (partNoLabel.Text.Trim().Length == 0)
                return;
            // calculate the type of form to create after
            string type = string.Empty;
            if (question4YesCheckBox.Checked || question5YesCheckBox.Checked
                || question5YesCheckBox.Checked || question6YesCheckBox.Checked)
                type = "Contract Review";
            else if (!question4YesCheckBox.Checked || !question5YesCheckBox.Checked
                || !question5YesCheckBox.Checked || !question6YesCheckBox.Checked)
            {
                if (question1NewCheckBox.Checked)
                    type = "Quick Release";
                else if (question1ActiveCheckBox.Checked || question1CompleteCheckBox.Checked)
                    type = "Nothing";
            }

            // load status page
            this.Hide();
            Form statusForm = new StatusPageQuickRelease(jobNo, partNoLabel.Text.Trim(), "Honda", type);
            statusForm.FormClosed += (s, args) => this.Close();
            statusForm.Show();
        }

        private void HondaPOReview_Load(object sender, EventArgs e)
        {
            // load label values
            jobLabel.Text = jobNo;

            // disable form if it is readonly
            if (readOnly)
                submitButton.Hide();
        }
    }
}
