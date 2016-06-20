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
    public partial class StatusPageQuickRelease : Form
    {
        string jobNo;
        string partNo;
        string customer;
        string type;

        public StatusPageQuickRelease(string jobNo, string partNo, string customer, string type)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.partNo = partNo;
            this.customer = customer;
            this.type = type;
        }

        private void StatusPage_Load(object sender, EventArgs e)
        {
            // set up job number label
            jobNoLabel.Text = jobNo;
            partNoLabel.Text = partNo;
            customerLabel.Text = customer;

            // load dummy objects into workflow list
            workflowList.Items.Add("0001");
            workflowList.Items.Add("0002");
            workflowList.Items.Add("0003");

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
                step2Label.Text = "Contract Review CheckList ME";
                step3Label.Text = "Contract Review CheckList QA";
                step4Label.Text = "Contract Review CheckList QE";
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
            step1Details.DoubleClick += this.step1Details_Enter;
            step2Details.DoubleClick += this.step2Details_Enter;
            step3Details.DoubleClick += this.step3Details_Enter;
            step4Details.DoubleClick += this.step4Details_Enter;
        }

        private void step1Details_Enter(object sender, EventArgs e)
        {
            if(customer.Equals("Honda"))
            {
                Form hondaPo = new HondaPOReview(jobNo, true);
                hondaPo.Show();
            }
            else if(customer.Equals("Rolls Royce"))
            {
                Form rollsPO = new RollsRoycePOReview(jobNo, true);
                rollsPO.Show();
            }
        }

        private void step1Label_DoubleClick(object sender, EventArgs e)
        {
            if (customer.Equals("Honda"))
            {
                Form hondaPo = new HondaPOReview(jobNo, true);
                hondaPo.Show();
            }
            else if (customer.Equals("Rolls Royce"))
            {
                Form rollsPO = new RollsRoycePOReview(jobNo, true);
                rollsPO.Show();
            }
        }

        private void step2Details_Enter(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_ME();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Engineering();
                quickReleaseForm.Show();
            }
        }

        private void step2Label_DoubleClick(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_ME();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Engineering();
                quickReleaseForm.Show();
            }
        }

        private void step3Details_Enter(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QA();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Quality();
                quickReleaseForm.Show();
            }
        }

        private void step3Label_DoubleClick(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QA();
                contractReviewME.Show();
            }
            else if (type.Equals("Quick Release"))
            {
                Form quickReleaseForm = new QuickReleaseForm_Quality();
                quickReleaseForm.Show();
            }
        }

        private void step4Details_Enter(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QE();
                contractReviewME.Show();
            }
        }

        private void step4Label_DoubleClick(object sender, EventArgs e)
        {
            if (type.Equals("Contract Review"))
            {
                Form contractReviewME = new ContractReviewCheckList_QE();
                contractReviewME.Show();
            }
        }
    }
}
