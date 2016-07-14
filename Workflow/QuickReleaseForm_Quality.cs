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
    public partial class QuickReleaseForm_Quality : Form
    {
        string jobNo;
        string partNo;
        int workflow_ID;
        public bool been_updated { get; set; }

        public QuickReleaseForm_Quality(string jobNo, string partNo, int workflow_ID)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.partNo = partNo;
            this.workflow_ID = workflow_ID;
            been_updated = false;
        }

        private void QuickReleaseForm_Load(object sender, EventArgs e)
        {
            // add set up for all combo boxes
            SetUpDropdown(question6ComboBox);
            SetUpDropdown(question5ComboBox);
            SetUpDropdown(question4ComboBox);
            SetUpDropdown(question3ComboBox);
            SetUpDropdown(question2ComboBox);
            SetUpDropdown(question1ComboBox);

            // initialize texboxes
            jobTextBox.Text = jobNo;
            jobTextBox.Enabled = false;
            partNumberTextBox.Text = partNo;
            partNumberTextBox.Enabled = false;
            personTextBox.Text = Globals.userName;
            personTextBox.Enabled = false;

            // check if it exists in DB and load data
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT [Job]\n" +
                    ",[Workflow_ID]\n" +
                    ",[Person]\n" +
                    ",[Question1_Response]\n" +
                    ",[Question2_Response]\n" +
                    ",[Question3_Response]\n" +
                    ",[Question4_Response]\n" +
                    ",[Question5_Response]\n" +
                    ",[Question6_Response]\n" +
                    ",[Comments]\n" +
                    "FROM[ATI_Workflow].[dbo].[QuickRelease_Quality]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "'; ";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    question1ComboBox.SelectedItem = reader.IsDBNull(3) ? null : reader.GetString(3);
                    question2ComboBox.SelectedItem = reader.IsDBNull(4) ? null : reader.GetString(4);
                    question3ComboBox.SelectedItem = reader.IsDBNull(5) ? null : reader.GetString(5);
                    question4ComboBox.SelectedItem = reader.IsDBNull(6) ? null : reader.GetString(6);
                    question5ComboBox.SelectedItem = reader.IsDBNull(7) ? null : reader.GetString(7);
                    question6ComboBox.SelectedItem = reader.IsDBNull(8) ? null : reader.GetString(8);

                    remarksTextBox.Text = reader.IsDBNull(9) ? "" : reader.GetString(9);
                }
            }

            // fix page to left half
            this.Left = 0;
            this.Top = 0;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
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

        private void submitButton_Click(object sender, EventArgs e)
        {

            bool exists = false;
            // submit to db
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT *\n" +
                    "FROM[ATI_Workflow].[dbo].[QuickRelease_Quality]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "'; ";

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
                        "UPDATE [ATI_Workflow].[dbo].[QuickRelease_Quality]\n" +
                        "SET\n" +
                        "[Person] = '" + personTextBox.Text + "'\n" +
                        ",[Question1_Response] = '" + question1ComboBox.SelectedItem.ToString() + "'\n" +
                        ",[Question2_Response] = '" + question2ComboBox.SelectedItem.ToString() + "'\n" +
                        ",[Question3_Response] = '" + question3ComboBox.SelectedItem.ToString() + "'\n" +
                        ",[Question4_Response] = '" + question4ComboBox.SelectedItem.ToString() + "'\n" +
                        ",[Question5_Response] = '" + question5ComboBox.SelectedItem.ToString() + "'\n" +
                        ",[Question6_Response] = '" + question6ComboBox.SelectedItem.ToString() + "'\n" +
                        ",[Comments] = '" + remarksTextBox.Text + "'\n" +
                        "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "'; ";

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
                        "INSERT INTO [ATI_Workflow].[dbo].[QuickRelease_Quality]\n" +
                        "([Job]\n" +
                        ",[Workflow_ID]\n" +
                        ",[Person]\n" +
                        ",[Question1_Response]\n" +
                        ",[Question2_Response]\n" +
                        ",[Question3_Response]\n" +
                        ",[Question4_Response]\n" +
                        ",[Question5_Response]\n" +
                        ",[Question6_Response]\n" +
                        ",[Comments])\n" +
                        "VALUES\n" +
                        "('" + jobNo + "'\n" +
                        ",'" + workflow_ID + "'\n" +
                        ",'" + personTextBox.Text + "'\n" +
                        ",'" + question1ComboBox.SelectedItem.ToString() + "'\n" +
                        ",'" + question2ComboBox.SelectedItem.ToString() + "'\n" +
                        ",'" + question3ComboBox.SelectedItem.ToString() + "'\n" +
                        ",'" + question4ComboBox.SelectedItem.ToString() + "'\n" +
                        ",'" + question5ComboBox.SelectedItem.ToString() + "'\n" +
                        ",'" + question6ComboBox.SelectedItem.ToString() + "'\n" +
                        ",'" + remarksTextBox.Text + "')";

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

        private void timeStampButton_Click(object sender, EventArgs e)
        {
            remarksTextBox.Text += remarksTextBox.Text + " " + DateTime.Now.ToShortDateString() + DateTime.Now.ToShortTimeString();
        }
    }
}
