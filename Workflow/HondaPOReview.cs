﻿using System;
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
    public partial class HondaPOReview : Form
    {
        private string jobNo;
        private bool readOnly;
        private int workflow_id;
        public string type { get; set; }
        public string partNo;

        public HondaPOReview(string jobNo, bool readOnly, int workflow_id)
        {
            InitializeComponent();
            this.jobNo = jobNo;
            this.readOnly = readOnly;
            this.workflow_id = workflow_id;
            this.type = "Invalid";
        }

        private void HondaPOReview_Load(object sender, EventArgs e)
        {
            // load label values
            jobLabel.Text = jobNo;
            jobLabel.Enabled = false;
            initiatedByTextBox.Text = Globals.userName;
            initiatedByTextBox.Enabled = false;

            // query for part number and load
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT Part_Number, Rev\n" +
                    "FROM Production.dbo.Job\n" +
                    "WHERE Job = '" + jobNo + "';\n";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    partNoLabel.Text = reader.GetString(0);
                    partNoLabel.Enabled = false;

                    revTextBox.Text = reader.GetString(1);
                    revTextBox.Enabled = false;
                }
            }

            // disable form if it is readonly
            if (readOnly)
                submitButton.Hide();

            PopulateDataFromDB();

            // fix page to left half
            this.Left = 0;
            this.Top = 0;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
        }

        private void PopulateDataFromDB()
        {
            // check if this contract review exists on DB
            // load if so
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT [Job]\n" +
                    ",[Workflow_ID]\n" +
                    ",[Initiated_By]\n" +
                    ",[Date]\n" +
                    ",[PO_No]\n" +
                    ",[PO_Qty]\n" +
                    ",[PO_Rev]\n" +
                    ",[PO_Rev_Date]\n" +
                    ",[Description_Of_Change]\n" +
                    ",[Question1_Response]\n" +
                    ",[Question2_Response]\n" +
                    ",[Question3_Response]\n" +
                    ",[Question4_Response]\n" +
                    ",[Question5_Response]\n" +
                    ",[Question6_Response]\n" +
                    ",[Question7_Response]\n" +
                    ",[Question8_Response]\n" +
                    ",[Part_Number]\n" +
                    ",[Drawing_Rev]\n" +
                    ",[Applicable_CID_Numbers]\n" +
                    "FROM[ATI_Workflow].[dbo].[Honda_PO_Review]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_id + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                // if row exists populate DB
                if (reader.Read())
                {
                    initiatedByTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    dateTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    poNoTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);
                    poQtyTextBox.Text = reader.IsDBNull(5) ? "" : reader.GetString(5);
                    revTextBox.Text = reader.IsDBNull(6) ? "" : reader.GetString(6);
                    revDateTextBox.Text = reader.IsDBNull(7) ? "" : reader.GetString(7);
                    descriptionOfChangeTextBox.Text = reader.IsDBNull(8) ? "" : reader.GetString(8);

                    if (!reader.IsDBNull(9))
                    {
                        if (reader.GetString(9).Equals("New"))
                        {
                            question1NewRadioButton.Checked = true;
                            question1ActiveRadioButton.Checked = false;
                            question1CompleteRadioButton.Checked = false;
                        }
                        else if (reader.GetString(9).Equals("Active"))
                        {
                            question1NewRadioButton.Checked = false;
                            question1ActiveRadioButton.Checked = true;
                            question1CompleteRadioButton.Checked = false;
                        }
                        else
                        {
                            question1NewRadioButton.Checked = false;
                            question1ActiveRadioButton.Checked = false;
                            question1CompleteRadioButton.Checked = true;
                        }
                    }

                    if (!reader.IsDBNull(10))
                    {
                        if (reader.GetBoolean(10))
                        {
                            question2YesRadioButton.Checked = true;
                            question2NoRadioButton.Checked = false;
                        }
                        else
                        {
                            question2YesRadioButton.Checked = false;
                            question2NoRadioButton.Checked = true;
                        }
                    }

                    if (!reader.IsDBNull(11))
                    {
                        if (reader.GetString(11).Equals("Yes"))
                        {
                            question3YesRadioButton.Checked = true;
                            question3NoRadioButton.Checked = false;
                            question3NARadioButton.Checked = false;
                        }
                        else if (reader.GetString(11).Equals("No"))
                        {
                            question3YesRadioButton.Checked = false;
                            question3NoRadioButton.Checked = true;
                            question3NARadioButton.Checked = false;
                        }
                        else
                        {
                            question3YesRadioButton.Checked = false;
                            question3NoRadioButton.Checked = false;
                            question3NARadioButton.Checked = true;
                        }
                    }

                    if (!reader.IsDBNull(12))
                    {
                        if (reader.GetBoolean(12))
                        {
                            question4YesRadioButton.Checked = true;
                            question4NoRadioButton.Checked = false;
                        }
                        else
                        {
                            question4YesRadioButton.Checked = false;
                            question4NoRadioButton.Checked = true;
                        }
                    }

                    if (!reader.IsDBNull(13))
                    {
                        if (reader.GetBoolean(13))
                        {
                            question5YesRadioButton.Checked = true;
                            question5NoRadioButton.Checked = false;
                        }
                        else
                        {
                            question5YesRadioButton.Checked = false;
                            question5NoRadioButton.Checked = true;
                        }
                    }


                    if (!reader.IsDBNull(14))
                    {
                        if (reader.GetBoolean(14))
                        {
                            question6YesRadioButton.Checked = true;
                            question6NoRadioButton.Checked = false;
                        }
                        else
                        {
                            question6YesRadioButton.Checked = false;
                            question6NoRadioButton.Checked = true;
                        }
                    }

                    if (!reader.IsDBNull(15))
                    {
                        if (reader.GetString(15).Equals("Yes"))
                        {
                            question7YesRadioButton.Checked = true;
                            question7NoRadioButton.Checked = false;
                            question7NARadioButton.Checked = false;
                        }
                        else if (reader.GetString(15).Equals("No"))
                        {
                            question7YesRadioButton.Checked = false;
                            question7NoRadioButton.Checked = true;
                            question7NARadioButton.Checked = false;
                        }
                        else
                        {
                            question7YesRadioButton.Checked = false;
                            question7NoRadioButton.Checked = false;
                            question7NARadioButton.Checked = true;
                        }
                    }


                    if (!reader.IsDBNull(15))

                        if (reader.GetBoolean(15))
                        {
                            question8YesRadioButton.Checked = true;
                            question8NoRadioButton.Checked = false;
                        }
                        else
                        {
                            question8YesRadioButton.Checked = false;
                            question8NoRadioButton.Checked = true;
                        }

                    partNoLabel.Text = reader.IsDBNull(16) ? "" : reader.GetString(16);
                    drawingRevTextBox.Text = reader.IsDBNull(17) ? "" : reader.GetString(17);
                    applicableCIDNosTextBox.Text = reader.IsDBNull(18) ? "" : reader.GetString(18);
                }
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            // go to status page with job, partNo and customer
            if (partNoLabel.Text.Trim().Length == 0)
                return;
            // calculate the type of form to create after
            if (question3YesRadioButton.Checked || question4YesRadioButton.Checked
                || question5YesRadioButton.Checked || question6YesRadioButton.Checked
                || question7YesRadioButton.Checked)
                type = "Contract Review";
            else
            {
                if (question1NewRadioButton.Checked)
                    type = "Quick Release";
                else if (question1ActiveRadioButton.Checked || question1CompleteRadioButton.Checked)
                    type = "Nothing";
            }

            if (this.Modal)
            {
                // TO_DO: Submit query info
                using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
                {
                    conn.Open();

                    string query =
                        "INSERT INTO [ATI_Workflow].[dbo].[Honda_PO_Review]\n" +
                        "([Job]\n" +
                        ",[Workflow_ID]\n" +
                        ",[Initiated_By]\n" +
                        ",[Date]\n" +
                        ",[PO_No]\n" +
                        ",[PO_Qty]\n" +
                        ",[PO_Rev]\n" +
                        ",[PO_Rev_Date]\n" +
                        ",[Description_Of_Change]\n" +
                        ",[Question1_Response]\n" +
                        ",[Question2_Response]\n" +
                        ",[Question3_Response]\n" +
                        ",[Question4_Response]\n" +
                        ",[Question5_Response]\n" +
                        ",[Question6_Response]\n" +
                        ",[Question7_Response]\n" +
                        ",[Question8_Response]\n" +
                        ",[Part_Number]\n" +
                        ",[Drawing_Rev]\n" +
                        ",[Applicable_CID_Numbers])\n" +
                        "VALUES\n" +
                        "('" + jobNo + "',\n" +
                        "'" + workflow_id + "',\n" +
                        "'" + Globals.userName + "',\n" +
                        "'" + dateTextBox.Text + "',\n" +
                        "'" + poNoTextBox.Text + "',\n" +
                        "'" + poQtyTextBox.Text + "',\n" +
                        "'" + revTextBox.Text + "',\n" +
                        "'" + revDateTextBox.Text + "',\n" +
                        "'" + descriptionOfChangeTextBox.Text + "',\n" +
                        (question1NewRadioButton.Checked ? "'New'" : (question1ActiveRadioButton.Checked ? "'Active'" : (question1CompleteRadioButton.Checked ? "'Complete'" : "NULL"))) + ",\n" +
                        (question2YesRadioButton.Checked ? "1" : (question2NoRadioButton.Checked ? "0" : "NULL")) + ",\n" +
                        (question3YesRadioButton.Checked ? "'Yes'" : (question3NoRadioButton.Checked ? "'No'" : (question3NARadioButton.Checked ? "'N/A'" : "NULL"))) + ",\n" +
                        (question4YesRadioButton.Checked ? "1" : (question4NoRadioButton.Checked ? "0" : "NULL")) + ",\n" +
                        (question5YesRadioButton.Checked ? "1" : (question5NoRadioButton.Checked ? "0" : "NULL")) + ",\n" +
                        (question6YesRadioButton.Checked ? "1" : (question6NoRadioButton.Checked ? "0" : "NULL")) + ",\n" +
                        (question7YesRadioButton.Checked ? "'Yes'" : (question7NoRadioButton.Checked ? "'No'" : (question7NARadioButton.Checked ? "'N/A'" : "NULL"))) + ",\n" +
                        (question8YesRadioButton.Checked ? "1" : (question8NoRadioButton.Checked ? "0" : "NULL")) + ",\n" +
                        "'" + partNoLabel.Text + "',\n" +
                        "'" + drawingRevTextBox.TextAlign + "',\n" +
                        "'" + applicableCIDNosTextBox.Text + "');";

                    OdbcCommand com = new OdbcCommand(query, conn);
                    int rows = com.ExecuteNonQuery();
                }

                this.Close();
            }
            else
            {
                // load status page
                this.Hide();
                Form statusForm = new StatusPage(jobNo, partNoLabel.Text.Trim(), "HONDA AERO", type);
                statusForm.FormClosed += (s, args) => this.Close();
                statusForm.Show();
            }
        }
    }
}
