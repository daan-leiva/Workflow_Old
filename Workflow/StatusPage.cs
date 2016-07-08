using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace Workflow
{
    public partial class StatusPage : Form
    {
        string jobNo;
        string partNo;
        string customer;
        Status_Type type;

        enum Status_Type { ContractReview, QuickRelease, None };

        public StatusPage(string jobNo, string partNo, string customer, string type)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.partNo = partNo;
            this.customer = customer;

            if (type.Equals("Nothing"))
                this.type = Status_Type.None;
            else if (type.Equals("Contract Review"))
                this.type = Status_Type.ContractReview;
            else
                this.type = Status_Type.QuickRelease;
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

            // update layout shape
            UpdateLayout(this.type);

            // set up detail events double click
            step1Details.DoubleClick += this.step1Details_DoubleClick;
            step2Details.DoubleClick += this.step2Details_DoubleClick;
            step3Details.DoubleClick += this.step3Details_DoubleClick;
            step4Details.DoubleClick += this.step4Details_DoubleClick;

            // add workflows to workflow
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT Job, Workflow_ID\n" +
                    "FROM [ATI_Workflow].[dbo].[StatusData]\n" +
                    "WHERE Job = '" + jobNo + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                // check that there is more than one valid row
                while (reader.Read() && !reader.IsDBNull(0))
                {
                    if (!reader.IsDBNull(1))
                        workflowListBox.Items.Add(reader.GetInt32(1));
                }
            }

            // if list is > 1 then select and activate first workflow and load info
            if (workflowListBox.Items.Count > 0)
                workflowListBox.SelectedIndex = 0;
        }

        private void UpdateLayout(Status_Type type)
        {
            // disable the forms that are not needed for this type
            if (type == Status_Type.None) // only needs PO Form
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
            else if (type == Status_Type.ContractReview)
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
            else if (type == Status_Type.QuickRelease)
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
        }

        private void UpdateFromDB(int workflowID)
        {
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT [Job]\n" +
                    ",[JobCreator_UserName]\n" +
                    ",[Workflow_ID]\n" +
                    ",[Type]\n" +
                    ",[LastUpdated]\n" +
                    ",[POReview_Status]\n" +
                    ",[POReview_UserName]\n" +
                    ",[POReview_TimeStamp]\n" +
                    ",[QuickRelease_Engineering_Status]\n" +
                    ",[QuickRelease_Engineer_UserName]\n" +
                    ",[QuickRelease_Engineering_TimeStamp]\n" +
                    ",[QuickRelease_Quality_Status]\n" +
                    ",[QuickRelease_Quality_UserName]\n" +
                    ",[QuickRelease_Quality_TimeStamp]\n" +
                    ",[ContractReview_ME_Status]\n" +
                    ",[ContractReview_ME_UserName]\n" +
                    ",[ContractReview_ME_TimeStamp]\n" +
                    ",[ContractReview_QA_Status]\n" +
                    ",[ContractReview_QA_UserName]\n" +
                    ",[ContractReview_QA_TimeStamp]\n" +
                    ",[ContractReview_QE_Status]\n" +
                    ",[ContractReview_QE_UserName]\n" +
                    ",[ContractReview_QE_TimeStamp]\n" +
                    "FROM[ATI_Workflow].[dbo].[StatusData]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflowID + "';";
            }
        }

        private void step1Details_DoubleClick(object sender, EventArgs e)
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
            // TO_DO
        }

        private void workflowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workflowListBox.SelectedItem != null)
                UpdateFromDB(int.Parse(workflowListBox.SelectedItem.ToString()));
        }
    }
}
