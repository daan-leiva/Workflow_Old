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

            if (type.Equals("Contract Review"))
                this.type = Status_Type.ContractReview;
            else if (type.Equals("Quick Release"))
                this.type = Status_Type.QuickRelease;
            else
                this.type = Status_Type.None;
        }

        private void StatusPage_Load(object sender, EventArgs e)
        {
            // set up lead labels
            jobNoLabel.Text = jobNo;
            partNoLabel.Text = partNo;
            customerLabel.Text = customer;
            currentUserLabel.Text = Globals.userName;

            // update layout shape
            UpdateLayout();

            // set up detail events double click
            step1Details.DoubleClick += this.step1_DoubleClick;
            step2Details.DoubleClick += this.step2_DoubleClick;
            step3Details.DoubleClick += this.step3_DoubleClick;
            step4Details.DoubleClick += this.step4_DoubleClick;
            step5Details.DoubleClick += this.step5_DoubleClick;
            step1Label.DoubleClick += this.step1_DoubleClick;
            step2Label.DoubleClick += this.step2_DoubleClick;
            step3Label.DoubleClick += this.step3_DoubleClick;
            step4Label.DoubleClick += this.step4_DoubleClick;
            step5Label.DoubleClick += this.step5_DoubleClick;

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

            // if list is > 0 then select and activate first workflow and load info
            if (workflowListBox.Items.Count > 0)
                workflowListBox.SelectedIndex = 0;
        }

        private void UpdateLayout()
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
                step5Label.Hide();
                step5Details.Hide();
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
                step5Label.Show();
                step5Details.Show();

                // rename steps 2-5
                step2Label.Text = "Assign Workflow";
                step3Label.Text = "Contract Review Check List ME";
                step4Label.Text = "Contract Review Check List QA";
                step5Label.Text = "Contract Review Check List QE";
            }
            else if (type == Status_Type.QuickRelease)
            {
                // Show step 1 - 3
                step1Label.Show();
                step1Details.Show();
                step3Label.Show();
                step3Details.Show();
                step4Label.Show();
                step4Details.Show();

                // Hide step 4
                step5Label.Hide();
                step5Details.Hide();

                // rename steps 2-3
                step3Label.Text = "Quick Release Engineering";
                step4Label.Text = "Quick Release Quality";
            }
        }

        private void UpdateFromDB(int workflowID)
        {
            // once layout is updated pull info
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT [Job]\n" +
                    ",[Type]\n" +
                    ",[LastUpdated]\n" +
                    ",[POReview_Status]\n" +
                    ",[POReview_UserName]\n" +
                    ",[POReview_TimeStamp]\n" +
                    ",[QuickRelease_Engineering_Status]\n" +
                    ",[QuickRelease_Engineering_UserName]\n" +
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


                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                try
                {
                    if (reader.Read())
                    {
                        // double check that type matches current type
                        // find index of type
                        int type_index = reader.GetOrdinal("Type");

                        // update layout first
                        if (!reader.IsDBNull(type_index))
                        {
                            if (reader.GetString(type_index).Equals("Contract Review"))
                            {
                                type = Status_Type.ContractReview;
                            }
                            else if (reader.GetString(type_index).Equals("Quick Release"))
                            {
                                this.type = Status_Type.QuickRelease;
                            }
                            else if (reader.GetString(type_index).Equals("None"))
                            {
                                this.type = Status_Type.None;
                            }
                            UpdateLayout();
                        }

                        // first fill in PO which all will have
                        this.step1UserName.Text = reader.IsDBNull(reader.GetOrdinal("POReview_UserName")) ? "Username" : reader.GetString(reader.GetOrdinal("POReview_UserName"));
                        this.step1TimeStamp.Text = reader.IsDBNull(reader.GetOrdinal("POReview_TimeStamp")) ? "TimeStamp" : reader.GetString(reader.GetOrdinal("POReview_TimeStamp"));
                        this.step1Status.Text = reader.IsDBNull(reader.GetOrdinal("POReview_Status")) ? "Status" : reader.GetString(reader.GetOrdinal("POReview_Status"));

                        // load info accordingly based on type
                        switch (this.type)
                        {
                            case Status_Type.ContractReview:
                                // step 2
                                this.step2UserName.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_ME_Status")) ? "Username" : reader.GetString(reader.GetOrdinal("ContractReview_ME_UserName"));
                                this.step2TimeStamp.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_ME_TimeStamp")) ? "TimeStamp" : reader.GetString(reader.GetOrdinal("ContractReview_ME_TimeStamp"));
                                this.step2Status.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_ME_Status")) ? "Status" : reader.GetString(reader.GetOrdinal("ContractReview_ME_Status"));
                                // step 3
                                this.step3UserName.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_QA_UserName")) ? "Username" : reader.GetString(reader.GetOrdinal("ContractReview_QA_UserName"));
                                this.step3TimeStamp.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_QA_TimeStamp")) ? "TimeStamp" : reader.GetString(reader.GetOrdinal("ContractReview_QA_TimeStamp"));
                                this.step3Status.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_QA_Status")) ? "Status" : reader.GetString(reader.GetOrdinal("ContractReview_ME_Status"));
                                // step 4
                                this.step4UserName.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_QE_UserName")) ? "Username" : reader.GetString(reader.GetOrdinal("ContractReview_QE_UserName"));
                                this.step4TimeStamp.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_QE_TimeStamp")) ? "TimeStamp" : reader.GetString(reader.GetOrdinal("ContractReview_QE_TimeStamp"));
                                this.step4Status.Text = reader.IsDBNull(reader.GetOrdinal("ContractReview_QE_Status")) ? "Status" : reader.GetString(reader.GetOrdinal("ContractReview_QE_Status"));
                                break;
                            case Status_Type.QuickRelease:
                                // step 2
                                this.step2UserName.Text = reader.IsDBNull(reader.GetOrdinal("QuickRelease_Engineering_UserName")) ? "Username" : reader.GetString(reader.GetOrdinal("QuickRelease_Engineering_UserName"));
                                this.step2TimeStamp.Text = reader.IsDBNull(reader.GetOrdinal("QuickRelease_Engineering_TimeStamp")) ? "TimeStamp" : reader.GetString(reader.GetOrdinal("QuickRelease_Engineering_TimeStamp"));
                                this.step2Status.Text = reader.IsDBNull(reader.GetOrdinal("QuickRelease_Engineering_Status")) ? "Status" : reader.GetString(reader.GetOrdinal("QuickRelease_Engineering_Status"));
                                // step 3
                                this.step3UserName.Text = reader.IsDBNull(reader.GetOrdinal("QuickRelease_Quality_UserName")) ? "Username" : reader.GetString(reader.GetOrdinal("QuickRelease_Quality_UserName"));
                                this.step3TimeStamp.Text = reader.IsDBNull(reader.GetOrdinal("QuickRelease_Quality_TimeStamp")) ? "TimeStamp" : reader.GetString(reader.GetOrdinal("QuickRelease_Quality_TimeStamp"));
                                this.step3Status.Text = reader.IsDBNull(reader.GetOrdinal("QuickRelease_Quality_Status")) ? "Status" : reader.GetString(reader.GetOrdinal("QuickRelease_Quality_Status"));
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error updating layout. Please contact IT support.");
                    }
                }
                catch (IndexOutOfRangeException)
                {
                    MessageBox.Show("Error getting type data from DB Server. Please contact IT suport.");
                }
                catch (OdbcException)
                {
                    MessageBox.Show("Error connecting to database. Please contact IT support.");
                }
            }
        }

        private bool CompareDBAndCurrentType(string dbType)
        {
            switch (this.type)
            {
                case Status_Type.ContractReview:
                    return dbType.Equals("Contract Review");
                case Status_Type.QuickRelease:
                    return dbType.Equals("Quick Release"); ;
                case Status_Type.None:
                    return dbType.Equals("None");
                default:
                    return false;
            }
        }

        private void step1_DoubleClick(object sender, EventArgs e)
        {
            if (customer.Equals("HONDA AERO"))
            {
                Form hondaPo = new HondaPOReview(jobNo, true, int.Parse(workflowListBox.SelectedItem.ToString()));
                hondaPo.ShowDialog();
            }
            else if (customer.Equals("ROLLS"))
            {
                Form rollsPO = new RollsRoycePOReview(jobNo, true);
                rollsPO.ShowDialog();
            }
        }

        private void step2_DoubleClick(object sender, EventArgs e)
        {
            // TO_DO open form to assign tasks
        }

        private void step3_DoubleClick(object sender, EventArgs e)
        {
            bool updated = false;

            if (type == Status_Type.ContractReview)
            {
                ContractReviewCheckList_ME contractReviewME = new ContractReviewCheckList_ME(jobNo, int.Parse(workflowListBox.SelectedItem.ToString()));
                contractReviewME.ShowDialog();
                updated = contractReviewME.been_updated;
            }
            else if (type == Status_Type.QuickRelease)
            {
                QuickReleaseForm_Engineering quickReleaseForm = new QuickReleaseForm_Engineering(jobNo, partNo, int.Parse(workflowListBox.SelectedItem.ToString()));
                quickReleaseForm.ShowDialog();
                updated = quickReleaseForm.been_updated;
            }

            if (updated)
            {
                using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
                {
                    conn.Open();

                    // update query
                    string query = string.Empty;

                    if (type == Status_Type.ContractReview)
                        query =
                            "UPDATE [ATI_Workflow].[dbo].[StatusData]\n" +
                            "SET[LastUpdated] = '" + DateTime.Now.ToString() + "'\n" +
                            ",[ContractReview_ME_Status] = 'Complete'\n" +
                            ",[ContractReview_ME_UserName] = '" + Globals.userName + "'\n" +
                            ",[ContractReview_ME_TimeStamp] = '" + DateTime.Now.ToString() + "'\n" +
                            "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + int.Parse(workflowListBox.SelectedItem.ToString()) + "';";
                    else
                        query =
                            "UPDATE [ATI_Workflow].[dbo].[StatusData]\n" +
                            "SET[LastUpdated] = '" + DateTime.Now.ToString() + "'\n" +
                            ",[QuickRelease_Engineering_Status] = 'Complete'\n" +
                            ",[QuickRelease_Engineering_UserName] = '" + Globals.userName + "'\n" +
                            ",[QuickRelease_Engineering_TimeStamp] = '" + DateTime.Now.ToString() + "'\n" +
                            "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + int.Parse(workflowListBox.SelectedItem.ToString()) + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    int rows = com.ExecuteNonQuery();

                    if (rows != 1)
                        MessageBox.Show(Globals.generic_IT_error);
                }

                UpdateFromDB(int.Parse(workflowListBox.SelectedItem.ToString()));
            }
        }
        
        private void step4_DoubleClick(object sender, EventArgs e)
        {
            bool updated = false;

            if (type == Status_Type.ContractReview)
            {
                ContractReviewCheckList_QA contractReviewQA = new ContractReviewCheckList_QA(jobNo, int.Parse(workflowListBox.SelectedItem.ToString()));
                contractReviewQA.ShowDialog();
                updated = contractReviewQA.been_updated;
            }
            else if (type == Status_Type.QuickRelease)
            {
                QuickReleaseForm_Quality quickReleaseForm = new QuickReleaseForm_Quality(jobNo, partNo, int.Parse(workflowListBox.SelectedItem.ToString()));
                quickReleaseForm.ShowDialog();
                updated = quickReleaseForm.been_updated;
            }

            if (updated)
            {
                using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
                {
                    conn.Open();

                    // update query
                    string query = string.Empty;

                    if (type == Status_Type.ContractReview)
                        query =
                            "UPDATE [ATI_Workflow].[dbo].[StatusData]\n" +
                            "SET[LastUpdated] = '" + DateTime.Now.ToString() + "'\n" +
                            ",[ContractReview_QA_Status] = 'Complete'\n" +
                            ",[ContractReview_QA_UserName] = '" + Globals.userName + "'\n" +
                            ",[ContractReview_QA_TimeStamp] = '" + DateTime.Now.ToString() + "'\n" +
                            "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + int.Parse(workflowListBox.SelectedItem.ToString()) + "';";
                    else
                        query =
                            "UPDATE [ATI_Workflow].[dbo].[StatusData]\n" +
                            "SET[LastUpdated] = '" + DateTime.Now.ToString() + "'\n" +
                            ",[QuickRelease_Quality_Status] = 'Complete'\n" +
                            ",[QuickRelease_Quality_UserName] = '" + Globals.userName + "'\n" +
                            ",[QuickRelease_Quality_TimeStamp] = '" + DateTime.Now.ToString() + "'\n" +
                            "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + int.Parse(workflowListBox.SelectedItem.ToString()) + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    int rows = com.ExecuteNonQuery();

                    if (rows != 1)
                        MessageBox.Show(Globals.generic_IT_error);
                }
                UpdateFromDB(int.Parse(workflowListBox.SelectedItem.ToString()));
            }
        }
        
        private void step5_DoubleClick(object sender, EventArgs e)
        {
            bool updated = false;
            if (type == Status_Type.ContractReview)
            {
                ContractReviewCheckList_QE contractReviewME = new ContractReviewCheckList_QE(jobNo, int.Parse(workflowListBox.SelectedItem.ToString()));
                contractReviewME.ShowDialog();
                updated = contractReviewME.been_updated;
            }
            if (updated)
            {
                using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
                {
                    conn.Open();

                    // update query
                    string query =
                            "UPDATE [ATI_Workflow].[dbo].[StatusData]\n" +
                            "SET[LastUpdated] = '" + DateTime.Now.ToString() + "'\n" +
                            ",[ContractReview_QE_Status] = 'Complete'\n" +
                            ",[ContractReview_QE_UserName] = '" + Globals.userName + "'\n" +
                            ",[ContractReview_QE_TimeStamp] = '" + DateTime.Now.ToString() + "'\n" +
                            "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + int.Parse(workflowListBox.SelectedItem.ToString()) + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    int rows = com.ExecuteNonQuery();

                    if (rows != 1)
                        MessageBox.Show(Globals.generic_IT_error);
                }
                UpdateFromDB(int.Parse(workflowListBox.SelectedItem.ToString()));
            }
        }

        // submits a new workflow to the db with no
        private void createWorkflowButton_Click(object sender, EventArgs e)
        {
            string type = string.Empty;
            if (customer.Equals("HONDA AERO"))
            {
                int next_ID = 0;
                using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
                {
                    conn.Open();

                    // first get next Worflow ID
                    string query =
                        "SELECT MAX(Workflow_ID)\n" +
                        "FROM ATI_Workflow.dbo.StatusData\n" +
                        "WHERE Job = '" + jobNo + "';";

                    OdbcCommand comm = new OdbcCommand(query, conn);
                    OdbcDataReader reader = comm.ExecuteReader();

                    // check if you can load one row
                    if (reader.Read() && !reader.IsDBNull(0))
                    {
                        // increase the workflow ID by 1
                        next_ID = reader.GetInt32(0) + 1;
                    }
                }
                HondaPOReview poReview = new HondaPOReview(jobNo, false, next_ID);
                poReview.ShowDialog();
                type = poReview.type;
            }
            else if (customer.Equals("ROLLS"))
            {
                RollsRoycePOReview poReview = new RollsRoycePOReview(jobNo, false);
                poReview.ShowDialog();
                type = poReview.type;
            }

            // in case form was closed prematurely
            if (type.Equals("Invalid"))
                return;

            // submit an insert query
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                // first get next Worflow ID
                string query =
                    "SELECT MAX(Workflow_ID)\n" +
                    "FROM ATI_Workflow.dbo.StatusData\n" +
                    "WHERE Job = '" + jobNo + "';";

                OdbcCommand comm = new OdbcCommand(query, conn);
                OdbcDataReader reader = comm.ExecuteReader();

                // check if you can load one row
                if (reader.Read() && !reader.IsDBNull(0))
                {
                    // increase the workflow ID by 1
                    int next_ID = reader.GetInt32(0) + 1;

                    query =
                        "INSERT INTO [ATI_Workflow].[dbo].[StatusData]\n" +
                        "([Job]\n" +
                        ",[Workflow_ID]\n" +
                        ",[Type]\n" +
                        ",[LastUpdated]\n" +
                        ",[POReview_Status]\n" +
                        ",[POReview_UserName]\n" +
                        ",[POReview_TimeStamp])\n" +
                        "VALUES\n" +
                        "('" + jobNo + "',\n" +
                        next_ID + ",\n" +
                        "'" + type + "',\n" +
                        "'" + DateTime.Now + "',\n" +
                        "'Complete',\n" +
                        "'" + Globals.userName + "',\n" +
                        "'" + DateTime.Now + "');";

                    comm = new OdbcCommand(query, conn);
                    int rows = comm.ExecuteNonQuery();

                    // check data was submitted succesfully
                    if (rows != 1)
                    {
                        MessageBox.Show("Data submitted was invaldi");
                        return;
                    }

                    // add new workflow to list and select
                    workflowListBox.Items.Add(next_ID);
                    workflowListBox.SelectedIndex = workflowListBox.FindString(next_ID.ToString());
                }
                else
                {
                    MessageBox.Show(Globals.generic_IT_error);
                }
            }
        }

        private void workflowList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (workflowListBox.SelectedItem != null)
                UpdateFromDB(int.Parse(workflowListBox.SelectedItem.ToString()));
        }


    }
}
