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
    public partial class ContractReviewCheckList_QA : Form
    {
        string jobNo;
        int workflow_ID;
        public bool been_updated { get; set; }
        float[] rowSizes = new float[12];

        public ContractReviewCheckList_QA(string jobNo, int workflow_ID)
        {
            InitializeComponent();

            this.jobNo = jobNo;
            this.workflow_ID = workflow_ID;
            this.been_updated = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            question1TextBox.Visible = !question1TextBox.Visible;
            if (question1TextBox.Visible == false)
            {
                tableLayoutPanel1.RowStyles[1].Height = 0;
            }
            else
                tableLayoutPanel1.RowStyles[1].Height = rowSizes[1];
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            question2TextBox.Visible = !question2TextBox.Visible;
            if (question2TextBox.Visible == false)
            {
                tableLayoutPanel1.RowStyles[3].Height = 0;
            }
            else
                tableLayoutPanel1.RowStyles[3].Height = rowSizes[3];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            question3TextBox.Visible = !question3TextBox.Visible;
            if (question3TextBox.Visible == false)
            {
                tableLayoutPanel1.RowStyles[5].Height = 0;
            }
            else
                tableLayoutPanel1.RowStyles[5].Height = rowSizes[5];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            question4TextBox.Visible = !question4TextBox.Visible;
            if (question4TextBox.Visible == false)
            {
                tableLayoutPanel1.RowStyles[7].Height = 0;
            }
            else
                tableLayoutPanel1.RowStyles[7].Height = rowSizes[7];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            question5TextBox.Visible = !question5TextBox.Visible;
            if (question5TextBox.Visible == false)
            {
                tableLayoutPanel1.RowStyles[9].Height = 0;
            }
            else
                tableLayoutPanel1.RowStyles[9].Height = rowSizes[9];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            question6TextBox.Visible = !question6TextBox.Visible;
            if (question6TextBox.Visible == false)
            {
                tableLayoutPanel1.RowStyles[11].Height = 0;
            }
            else
                tableLayoutPanel1.RowStyles[11].Height = rowSizes[11];
        }

        private void ContractReviewCheckList_QA_Load(object sender, EventArgs e)
        {
            // initialize some textboxes
            jobNoTextBox.Text = jobNo;
            jobNoTextBox.Enabled = false;
            approvalTextBox.Text = Globals.userName;
            approvalTextBox.Enabled = false;
           
            
            
            for (int i = 1; i < 12; i += 2)
            {
                 rowSizes[i] = tableLayoutPanel1.RowStyles[i].Height;
                tableLayoutPanel1.RowStyles[i].Height = 0;
            }
            
            
            // check if it exists in DB and load data
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT\n" +
                    "[PO_Number]\n" +
                    ",[Description_Of_Change]\n" +
                    ",[Initial]\n" +
                    ",[PO_Date]\n" +
                    ",[Planning]\n" +
                    ",[Question1_Response]\n" +
                    ",[Question2_Response]\n" +
                    ",[Question3_Response]\n" +
                    ",[Question4_Response]\n" +
                    ",[Question5_Response]\n" +
                    ",[Question6_Response]\n" +
                    ",[Question1_Comments]\n" +
                    ",[Question2_Comments]\n" +
                    ",[Question3_Comments]\n" +
                    ",[Question4_Comments]\n" +
                    ",[Question5_Comments]\n" +
                    ",[Question6_Comments]\n" +
                    "FROM[ATI_Workflow].[dbo].[ContractReview_QA]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    poNoTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    descriptionOfChangeTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    initialTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    dateTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    qualityTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);

                    question1CheckBox.Checked = reader.IsDBNull(5) ? false : reader.GetBoolean(5);
                    question2CheckBox.Checked = reader.IsDBNull(6) ? false : reader.GetBoolean(6);
                    question3CheckBox.Checked = reader.IsDBNull(7) ? false : reader.GetBoolean(7);
                    question4CheckBox.Checked = reader.IsDBNull(8) ? false : reader.GetBoolean(8);
                    question5CheckBox.Checked = reader.IsDBNull(9) ? false : reader.GetBoolean(9);
                    question6CheckBox.Checked = reader.IsDBNull(10) ? false : reader.GetBoolean(10);

                    question1TextBox.Text = reader.IsDBNull(11) ? "" : reader.GetString(11);
                    question2TextBox.Text = reader.IsDBNull(12) ? "" : reader.GetString(12);
                    question3TextBox.Text = reader.IsDBNull(13) ? "" : reader.GetString(13);
                    question4TextBox.Text = reader.IsDBNull(14) ? "" : reader.GetString(14);
                    question5TextBox.Text = reader.IsDBNull(15) ? "" : reader.GetString(15);
                    question6TextBox.Text = reader.IsDBNull(16) ? "" : reader.GetString(16);
                }
            }

            // fix page to left half
            this.Left = 0;
            this.Top = 0;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool exists = false;
            // submit to db
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT *\n" +
                    "FROM [ATI_Workflow].[dbo].[ContractReview_QA]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                exists = reader.Read();
            }

            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();
                // if it exists then run an update query
                if (exists)
                {
                    string query =
                        "UPDATE [ATI_Workflow].[dbo].[ContractReview_QA]\n" +
                        "SET\n" +
                        "[PO_Number] = '" + poNoTextBox.Text + "'\n" +
                        ",[Description_Of_Change] = '" + descriptionOfChangeTextBox.Text + "'\n" +
                        ",[Initial] = '" + initialTextBox.Text + "'\n" +
                        ",[PO_Date] = '" + dateTextBox.Text + "'\n" +
                        ",[Planning] = '" + qualityTextBox.Text + "'\n" +
                        ",[Approval] = '" + approvalTextBox.Text + "'\n" +
                        ",[Question1_Response] = '" + (question1CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question2_Response] = '" + (question2CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question3_Response] = '" + (question3CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question4_Response] = '" + (question4CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question5_Response] = '" + (question5CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question6_Response] = '" + (question6CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question1_Comments] = '" + question1TextBox.Text + "'\n" +
                        ",[Question2_Comments] = '" + question2TextBox.Text + "'\n" +
                        ",[Question3_Comments] = '" + question3TextBox.Text + "'\n" +
                        ",[Question4_Comments] = '" + question4TextBox.Text + "'\n" +
                        ",[Question5_Comments] = '" + question5TextBox.Text + "'\n" +
                        ",[Question6_Comments] = '" + question6TextBox.Text + "'\n" +
                        "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "';";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    int rows = com.ExecuteNonQuery();

                    if (rows != 1)
                        MessageBox.Show(Globals.generic_IT_error);
                    else
                        been_updated = true;
                }
                else // otehrwise insert a new row
                {
                    string query =
                        "INSERT INTO [ATI_Workflow].[dbo].[ContractReview_QA]\n" +
                        "([Job]\n" +
                        ",[Workflow_ID]\n" +
                        ",[ContractReview_Type]\n" +
                        ",[PO_Number]\n" +
                        ",[Description_Of_Change]\n" +
                        ",[Initial]\n" +
                        ",[PO_Date]\n" +
                        ",[Planning]\n" +
                        ",[Approval]\n" +
                        ",[Question1_Response]\n" +
                        ",[Question2_Response]\n" +
                        ",[Question3_Response]\n" +
                        ",[Question4_Response]\n" +
                        ",[Question5_Response]\n" +
                        ",[Question6_Response]\n" +
                        ",[Question1_Comments]\n" +
                        ",[Question2_Comments]\n" +
                        ",[Question3_Comments]\n" +
                        ",[Question4_Comments]\n" +
                        ",[Question5_Comments]\n" +
                        ",[Question6_Comments])\n" +
                        "VALUES\n" +
                        "('" + jobNo + "'\n" +
                        ",'" + workflow_ID + "'\n" +
                        ",'QE'\n" +
                        ",'" + poNoTextBox.Text + "'\n" +
                        ",'" + descriptionOfChangeTextBox.Text + "'\n" +
                        ",'" + initialTextBox.Text + "'\n" +
                        ",'" + dateTextBox.Text + "'\n" +
                        ",'" + qualityTextBox.Text + "'\n" +
                        ",'" + approvalTextBox.Text + "'\n" +
                        ",'" + (question1CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question2CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question3CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question4CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question5CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question6CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + question1TextBox.Text + "'\n" +
                        ",'" + question2TextBox.Text + "'\n" +
                        ",'" + question3TextBox.Text + "'\n" +
                        ",'" + question4TextBox.Text + "'\n" +
                        ",'" + question5TextBox.Text + "'\n" +
                        ",'" + question6TextBox.Text + "')\n;";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    int rows = com.ExecuteNonQuery();

                    if (rows != 1)
                        MessageBox.Show(Globals.generic_IT_error);
                    else
                        been_updated = true;
                }
            }
            
            this.Close();
        }

        private void question1TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void question2TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void question3TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void question4TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void question5TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void question6TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
