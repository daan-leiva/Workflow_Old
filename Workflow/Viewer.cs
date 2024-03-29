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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void viewContractReviewButton_Click(object sender, EventArgs e)
        {
            Form contractReviewForm = new ContractReviewCheckList();
            contractReviewForm.Show();
        }

        private void viewQuickReleaseButton_Click(object sender, EventArgs e)
        {
            Form quickReleaseForm = new QuickReleaseForm();
            quickReleaseForm.Show();
        }

        private void viewRollsFormButton_Click(object sender, EventArgs e)
        {
            Form rollsRoycePOReview = new RollsRoycePOReview("12345", false);
            rollsRoycePOReview.Show();
        }

        private void viewHondaPOFormButton_Click(object sender, EventArgs e)
        {
            Form hondaPOReview = new HondaPOReview("12345", false, 101);
            hondaPOReview.Show();
        }

        private void createWorkflowButton_Click(object sender, EventArgs e)
        {
            Form createWorkflowForm = new CreateWorkflow();
            createWorkflowForm.Show();
        }

        private void contractReviewWorkflowButton_Click(object sender, EventArgs e)
        {
            Form contractReviewWorkflowForm = new ContractReview();
            contractReviewWorkflowForm.Show();
        }

        private void jobListVieweButton_Click(object sender, EventArgs e)
        {
            Form jobListViewer = new JobListViewer();
            jobListViewer.Show();
        }

        private void contractReviewQAButton_Click(object sender, EventArgs e)
        {
            Form contractReviewQAForm = new ContractReviewCheckList_QA("10", 101);
            contractReviewQAForm.Show();
        }

        private void contractReviewQEButton_Click(object sender, EventArgs e)
        {
            Form contractReviewQEForm = new ContractReviewCheckList_QE("10", 101);
            contractReviewQEForm.Show();
        }

        private void contractReviewMEButton_Click(object sender, EventArgs e)
        {
            Form contractReviewMEForm = new ContractReviewCheckList_ME("10", 101);
            contractReviewMEForm.Show();
        }

        private void statusPageButton_Click(object sender, EventArgs e)
        {
            //Form statusForm = new StatusPage();
            //statusForm.Show();
        }
    }
}
