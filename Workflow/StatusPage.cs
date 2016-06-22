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
    public partial class StatusPage : Form
    {
        string jobNo;
        string partNo;
        string customer;
        string type;
        int workflowCount;

        public StatusPage(string jobNo, string partNo, string customer, string type)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.partNo = partNo;
            this.customer = customer;
            this.type = type;
            this.workflowCount = 1;
        }

        private void StatusPage_Load(object sender, EventArgs e)
        {
            // set up job number label
            jobNoLabel.Text = jobNo;
            partNoLabel.Text = partNo;
            customerLabel.Text = customer;

            // load dummy objects into workflow list
            createWorkflowButton_Click(new object(), new EventArgs());
            createWorkflowButton_Click(new object(), new EventArgs());
            createWorkflowButton_Click(new object(), new EventArgs());

            // disable the forms that are not needed for this type
            if (type.Equals("Nothing")) // only needs PO Form
            {
                // Show step 1
                step1Label.Show();
                step1Details.Show();
                // Hide step 2-4
                step2Label.Hide();
                step2Details.Hide();
                step3Label.Hide();
                step3Details.Hide();
                step4Label.Hide();
                step4Details.Hide();
            }
            else if (type.Equals("Contract Review"))
            {
                // Show step 1 - 4
                step1Label.Show();
                step1Details.Show();
                step2Label.Show();
                step2Details.Show();
                step3Label.Show();
                step3Details.Show();
                step4Label.Show();
                step4Details.Show();

                // rename steps 2-4
                step2Label.Text = "Contract Review Check List ME";
                step3Label.Text = "Contract Review Check List QA";
                step4Label.Text = "Contract Review Check List QE";
            }
            else if (type.Equals("Quick Release"))
            {
                // Show step 1 - 3
                step1Label.Show();
                step1Details.Show();
                step2Label.Show();
                step2Details.Show();
                step3Label.Show();
                step3Details.Show();

                // Hide step 4
                step4Label.Hide();
                step4Details.Hide();

                // rename steps 2-3
                step2Label.Text = "Quick Release Engineering";
                step3Label.Text = "Quick Release Quality";
            }

            // set up detail events double click
            step1Details.DoubleClick += this.step1Details_DoubleClick;
            step2Details.DoubleClick += this.step2Details_DoubleClick;
            step3Details.DoubleClick += this.step3Details_DoubleClick;
            step4Details.DoubleClick += this.step4Details_DoubleClick;
        }

        private void step1Details_DoubleClick(object sender, EventArgs e)
        {
            if(customer.Equals("HONDA AERO"))
            {
                Form hondaPo = new HondaPOReview(jobNo, true);
                hondaPo.Show();
            }
            else if(customer.Equals("ROLLS"))
            {
                Form rollsPO = new RollsRoycePOReview(jobNo, true);
                rollsPO.Show();
            }
        }

        private void step1Label_DoubleClick(object sender, EventArgs e)
        {
            if (customer.Equals("HONDA AERO"))
            {
                Form hondaPo = new HondaPOReview(jobNo, true);
                hondaPo.Show();
            }
            else if (customer.Equals("ROLLS"))
            {
                Form rollsPO = new RollsRoycePOReview(jobNo, true);
                rollsPO.Show();
            }
        }

        private void step2Details_DoubleClick(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_ME();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Engineering(jobNo, partNo);
                quickReleaseForm.Show();
            }
        }

        private void step2Label_DoubleClick_1(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_ME();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Engineering(jobNo, partNo);
                quickReleaseForm.Show();
            }
        }

        private void step3Details_DoubleClick(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QA();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Quality(jobNo, partNo);
                quickReleaseForm.Show();
            }
        }

        private void step3Label_DoubleClick_1(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QA();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Quality(jobNo, partNo);
                quickReleaseForm.Show();
            }
        }

        private void step4Details_DoubleClick(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QE();
                contractReviewME.Show();
            }
        }

        private void step4Label_DoubleClick_1(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QE();
                contractReviewME.Show();
            }
        }

        private void createWorkflowButton_Click(object sender, EventArgs e)
        {
            workflowList.Items.Add(workflowCount.ToString("D" + 4));
            workflowCount++;
        }
    }
}
