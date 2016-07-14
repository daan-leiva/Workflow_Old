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
    public partial class ContractReviewCheckList_ME : Form
    {
        string jobNo;
        int workflow_ID;
        public bool been_updated { get; set; }

        public ContractReviewCheckList_ME(string jobNo, int workflow_ID)
        {
            InitializeComponent();

            this.jobNo = jobNo;
            this.workflow_ID = workflow_ID;
            this.been_updated = false;
        }

        //Button events that open and close a textbox for comments
        #region buttonclicks
        private void button1_Click(object sender, EventArgs e)
        {
            question1TextBox.Visible = !question1TextBox.Visible;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            question2TextBox.Visible = !question2TextBox.Visible;

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            question3TextBox.Visible = !question3TextBox.Visible;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            question4TextBox.Visible = !question4TextBox.Visible;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            question5TextBox.Visible = !question5TextBox.Visible;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            question6TextBox.Visible = !question6TextBox.Visible;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            question7TextBox.Visible = !question7TextBox.Visible;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            question8TextBox.Visible = !question8TextBox.Visible;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            question9TextBox.Visible = !question9TextBox.Visible;

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            question10TextBox.Visible = !question10TextBox.Visible;
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            question11TextBox.Visible = !question11TextBox.Visible;
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            question12TextBox.Visible = !question12TextBox.Visible;
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            question13TextBox.Visible = !question13TextBox.Visible;
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            question14TextBox.Visible = !question14TextBox.Visible;
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            question15TextBox.Visible = !question15TextBox.Visible;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            question16TextBox.Visible = !question16TextBox.Visible;
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            question17TextBox.Visible = !question17TextBox.Visible;
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            question18TextBox.Visible = !question18TextBox.Visible;
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            question19TextBox.Visible = !question19TextBox.Visible;
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            question20TextBox.Visible = !question20TextBox.Visible;
        }

        private void button21_Click_1(object sender, EventArgs e)
        {
            question21TextBox.Visible = !question21TextBox.Visible;
        }

        private void button22_Click_1(object sender, EventArgs e)
        {
            question22TextBox.Visible = !question22TextBox.Visible;
        }

        private void button23_Click_1(object sender, EventArgs e)
        {
            question23TextBox.Visible = !question23TextBox.Visible;
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            question24TextBox.Visible = !question24TextBox.Visible;
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            question25TextBox.Visible = !question25TextBox.Visible;
        }

        private void button26_Click_1(object sender, EventArgs e)
        {
            question26TextBox.Visible = !question26TextBox.Visible;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            question27TextBox.Visible = !question27TextBox.Visible;
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            question28TextBox.Visible = !question28TextBox.Visible;
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
            question29TextBox.Visible = !question29TextBox.Visible;
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
            question30TextBox.Visible = !question30TextBox.Visible;
        }

        private void button31_Click_1(object sender, EventArgs e)
        {
            question31TextBox.Visible = !question31TextBox.Visible;
        }

        private void button32_Click_1(object sender, EventArgs e)
        {
            question32TextBox.Visible = !question32TextBox.Visible;
        }

        private void button33_Click_1(object sender, EventArgs e)
        {
            question33TextBox.Visible = !question33TextBox.Visible;
        }

        private void button34_Click_1(object sender, EventArgs e)
        {
            question34TextBox.Visible = !question34TextBox.Visible;
        }

        private void button35_Click_1(object sender, EventArgs e)
        {
            question35TextBox.Visible = !question35TextBox.Visible;
        }

        private void button36_Click_1(object sender, EventArgs e)
        {
            textBox43.Visible = !textBox43.Visible;
        }

        private void button37_Click_1(object sender, EventArgs e)
        {
            question37TextBox.Visible = !question37TextBox.Visible;
        }

        private void button38_Click_1(object sender, EventArgs e)
        {
            question38TextBox.Visible = !question38TextBox.Visible;

        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            question39TextBox.Visible = !question39TextBox.Visible;

        }
        #endregion


        //Initializes all rows to 0 to hide and space closer
        private void ContractReviewCheckList_ME_Load(object sender, EventArgs e)
        {
            for (int i = 1; i < 79; i += 2)
            {
                tableLayoutPanel1.RowStyles[i].Height = 0;
            }

            // initialize some textboxes
            jobNoTextBox.Text = jobNo;
            jobNoTextBox.Enabled = false;
            meApprovalTextBox.Text = Globals.userName;
            meApprovalTextBox.Enabled = false;

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
                    ",[Question7_Response]\n" +
                    ",[Question8_Response]\n" +
                    ",[Question9_Response]\n" +
                    ",[Question10_Response]\n" +
                    ",[Question11_Response]\n" +
                    ",[Question12_Response]\n" +
                    ",[Question13_Response]\n" +
                    ",[Question14_Response]\n" +
                    ",[Question15_Response]\n" +
                    ",[Question16_Response]\n" +
                    ",[Question17_Response]\n" +
                    ",[Question18_Response]\n" +
                    ",[Question19_Response]\n" +
                    ",[Question20_Response]\n" +
                    ",[Question21_Response]\n" +
                    ",[Question22_Response]\n" +
                    ",[Question23_Response]\n" +
                    ",[Question24_Response]\n" +
                    ",[Question25_Response]\n" +
                    ",[Question26_Response]\n" +
                    ",[Question27_Response]\n" +
                    ",[Question28_Response]\n" +
                    ",[Question29_Response]\n" +
                    ",[Question30_Response]\n" +
                    ",[Question31_Response]\n" +
                    ",[Question32_Response]\n" +
                    ",[Question33_Response]\n" +
                    ",[Question34_Response]\n" +
                    ",[Question35_Response]\n" +
                    ",[Question36_Response]\n" +
                    ",[Question37_Response]\n" +
                    ",[Question38_Response]\n" +
                    ",[Question39_Response]\n" +
                    ",[Question1_Comments]\n" +
                    ",[Question2_Comments]\n" +
                    ",[Question3_Comments]\n" +
                    ",[Question4_Comments]\n" +
                    ",[Question5_Comments]\n" +
                    ",[Question6_Comments]\n" +
                    ",[Question7_Comments]\n" +
                    ",[Question8_Comments]\n" +
                    ",[Question9_Comments]\n" +
                    ",[Question10_Comments]\n" +
                    ",[Question11_Comments]\n" +
                    ",[Question12_Comments]\n" +
                    ",[Question13_Comments]\n" +
                    ",[Question14_Comments]\n" +
                    ",[Question15_Comments]\n" +
                    ",[Question16_Comments]\n" +
                    ",[Question17_Comments]\n" +
                    ",[Question18_Comments]\n" +
                    ",[Question19_Comments]\n" +
                    ",[Question20_Comments]\n" +
                    ",[Question21_Comments]\n" +
                    ",[Question22_Comments]\n" +
                    ",[Question23_Comments]\n" +
                    ",[Question24_Comments]\n" +
                    ",[Question25_Comments]\n" +
                    ",[Question26_Comments]\n" +
                    ",[Question27_Comments]\n" +
                    ",[Question28_Comments]\n" +
                    ",[Question29_Comments]\n" +
                    ",[Question30_Comments]\n" +
                    ",[Question31_Comments]\n" +
                    ",[Question32_Comments]\n" +
                    ",[Question33_Comments]\n" +
                    ",[Question34_Comments]\n" +
                    ",[Question35_Comments]\n" +
                    ",[Question36_Comments]\n" +
                    ",[Question37_Comments]\n" +
                    ",[Question38_Comments]\n" +
                    ",[Question39_Comments]\n" +
                    "FROM[ATI_Workflow].[dbo].[ContractReview_ME_QE]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "' AND ContractReview_Type = 'ME';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if (reader.Read())
                {
                    poNoTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    descriptionOfChangeTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    initialTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                    dateTextBox.Text = reader.IsDBNull(3) ? "" : reader.GetString(3);
                    planningTextBox.Text = reader.IsDBNull(4) ? "" : reader.GetString(4);

                    question1CheckBox.Checked = reader.IsDBNull(5) ? false : reader.GetBoolean(5);
                    question2CheckBox.Checked = reader.IsDBNull(6) ? false : reader.GetBoolean(6);
                    question3CheckBox.Checked = reader.IsDBNull(7) ? false : reader.GetBoolean(7);
                    question4CheckBox.Checked = reader.IsDBNull(8) ? false : reader.GetBoolean(8);
                    question5CheckBox.Checked = reader.IsDBNull(9) ? false : reader.GetBoolean(9);
                    question6CheckBox.Checked = reader.IsDBNull(10) ? false : reader.GetBoolean(10);
                    question7CheckBox.Checked = reader.IsDBNull(11) ? false : reader.GetBoolean(11);
                    question8CheckBox.Checked = reader.IsDBNull(12) ? false : reader.GetBoolean(12);
                    question9CheckBox.Checked = reader.IsDBNull(13) ? false : reader.GetBoolean(13);
                    question10CheckBox.Checked = reader.IsDBNull(14) ? false : reader.GetBoolean(14);
                    question11CheckBox.Checked = reader.IsDBNull(15) ? false : reader.GetBoolean(15);
                    question12CheckBox.Checked = reader.IsDBNull(16) ? false : reader.GetBoolean(16);
                    question13CheckBox.Checked = reader.IsDBNull(17) ? false : reader.GetBoolean(17);
                    question14CheckBox.Checked = reader.IsDBNull(18) ? false : reader.GetBoolean(18);
                    question15CheckBox.Checked = reader.IsDBNull(19) ? false : reader.GetBoolean(19);
                    question16CheckBox.Checked = reader.IsDBNull(20) ? false : reader.GetBoolean(20);
                    question17CheckBox.Checked = reader.IsDBNull(21) ? false : reader.GetBoolean(21);
                    question18CheckBox.Checked = reader.IsDBNull(22) ? false : reader.GetBoolean(22);
                    question19CheckBox.Checked = reader.IsDBNull(23) ? false : reader.GetBoolean(23);
                    question20CheckBox.Checked = reader.IsDBNull(24) ? false : reader.GetBoolean(24);
                    question21CheckBox.Checked = reader.IsDBNull(25) ? false : reader.GetBoolean(25);
                    question22CheckBox.Checked = reader.IsDBNull(26) ? false : reader.GetBoolean(26);
                    question23CheckBox.Checked = reader.IsDBNull(27) ? false : reader.GetBoolean(27);
                    question24CheckBox.Checked = reader.IsDBNull(28) ? false : reader.GetBoolean(28);
                    question25CheckBox.Checked = reader.IsDBNull(29) ? false : reader.GetBoolean(29);
                    question26CheckBox.Checked = reader.IsDBNull(30) ? false : reader.GetBoolean(30);
                    question27CheckBox.Checked = reader.IsDBNull(31) ? false : reader.GetBoolean(31);
                    question28CheckBox.Checked = reader.IsDBNull(32) ? false : reader.GetBoolean(32);
                    question29CheckBox.Checked = reader.IsDBNull(33) ? false : reader.GetBoolean(33);
                    question30CheckBox.Checked = reader.IsDBNull(34) ? false : reader.GetBoolean(34);
                    question31CheckBox.Checked = reader.IsDBNull(35) ? false : reader.GetBoolean(35);
                    question32CheckBox.Checked = reader.IsDBNull(36) ? false : reader.GetBoolean(36);
                    question33CheckBox.Checked = reader.IsDBNull(37) ? false : reader.GetBoolean(37);
                    question34CheckBox.Checked = reader.IsDBNull(38) ? false : reader.GetBoolean(38);
                    question35CheckBox.Checked = reader.IsDBNull(39) ? false : reader.GetBoolean(39);
                    question36CheckBox.Checked = reader.IsDBNull(40) ? false : reader.GetBoolean(40);
                    question37CheckBox.Checked = reader.IsDBNull(41) ? false : reader.GetBoolean(41);
                    question38CheckBox.Checked = reader.IsDBNull(42) ? false : reader.GetBoolean(42);
                    question39CheckBox.Checked = reader.IsDBNull(43) ? false : reader.GetBoolean(43);

                    question1TextBox.Text = reader.IsDBNull(44) ? "" : reader.GetString(44);
                    question2TextBox.Text = reader.IsDBNull(45) ? "" : reader.GetString(45);
                    question3TextBox.Text = reader.IsDBNull(46) ? "" : reader.GetString(46);
                    question4TextBox.Text = reader.IsDBNull(47) ? "" : reader.GetString(47);
                    question5TextBox.Text = reader.IsDBNull(48) ? "" : reader.GetString(48);
                    question6TextBox.Text = reader.IsDBNull(49) ? "" : reader.GetString(49);
                    question7TextBox.Text = reader.IsDBNull(50) ? "" : reader.GetString(50);
                    question8TextBox.Text = reader.IsDBNull(51) ? "" : reader.GetString(51);
                    question9TextBox.Text = reader.IsDBNull(52) ? "" : reader.GetString(52);
                    question10TextBox.Text = reader.IsDBNull(53) ? "" : reader.GetString(53);
                    question11TextBox.Text = reader.IsDBNull(54) ? "" : reader.GetString(54);
                    question12TextBox.Text = reader.IsDBNull(55) ? "" : reader.GetString(55);
                    question13TextBox.Text = reader.IsDBNull(56) ? "" : reader.GetString(56);
                    question14TextBox.Text = reader.IsDBNull(57) ? "" : reader.GetString(57);
                    question15TextBox.Text = reader.IsDBNull(58) ? "" : reader.GetString(58);
                    question16TextBox.Text = reader.IsDBNull(59) ? "" : reader.GetString(59);
                    question17TextBox.Text = reader.IsDBNull(60) ? "" : reader.GetString(60);
                    question18TextBox.Text = reader.IsDBNull(61) ? "" : reader.GetString(61);
                    question19TextBox.Text = reader.IsDBNull(62) ? "" : reader.GetString(62);
                    question20TextBox.Text = reader.IsDBNull(63) ? "" : reader.GetString(63);
                    question21TextBox.Text = reader.IsDBNull(64) ? "" : reader.GetString(64);
                    question22TextBox.Text = reader.IsDBNull(65) ? "" : reader.GetString(65);
                    question23TextBox.Text = reader.IsDBNull(66) ? "" : reader.GetString(66);
                    question24TextBox.Text = reader.IsDBNull(67) ? "" : reader.GetString(67);
                    question25TextBox.Text = reader.IsDBNull(68) ? "" : reader.GetString(68);
                    question26TextBox.Text = reader.IsDBNull(69) ? "" : reader.GetString(69);
                    question27TextBox.Text = reader.IsDBNull(70) ? "" : reader.GetString(70);
                    question28TextBox.Text = reader.IsDBNull(71) ? "" : reader.GetString(71);
                    question29TextBox.Text = reader.IsDBNull(72) ? "" : reader.GetString(72);
                    question30TextBox.Text = reader.IsDBNull(73) ? "" : reader.GetString(73);
                    question31TextBox.Text = reader.IsDBNull(74) ? "" : reader.GetString(74);
                    question32TextBox.Text = reader.IsDBNull(75) ? "" : reader.GetString(75);
                    question33TextBox.Text = reader.IsDBNull(76) ? "" : reader.GetString(76);
                    question34TextBox.Text = reader.IsDBNull(77) ? "" : reader.GetString(77);
                    question35TextBox.Text = reader.IsDBNull(78) ? "" : reader.GetString(78);
                    question36TextBox.Text = reader.IsDBNull(79) ? "" : reader.GetString(79);
                    question37TextBox.Text = reader.IsDBNull(80) ? "" : reader.GetString(80);
                    question38TextBox.Text = reader.IsDBNull(81) ? "" : reader.GetString(81);
                    question39TextBox.Text = reader.IsDBNull(82) ? "" : reader.GetString(82);

                }
            }

            // fix page to left half
            this.Left = 0;
            this.Top = 0;
            this.Height = System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Height;
        }

        //textBox events that change button text
        //If there is text Button will show 'View/Edit'
        //Else Button will show 'Create Notes'
        #region textChange
        private void textBox8_TextChanged_1(object sender, EventArgs e)
        {
            if (question1TextBox.Text == "")
            {
                button1.Text = "Create Note";

            }
            else
                button1.Text = "View/Edit";
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            if (question2TextBox.Text == "")
            {
                button2.Text = "Create Note";

            }
            else
                button2.Text = "View/Edit";
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (question3TextBox.Text == "")
            {
                button3.Text = "Create Note";

            }
            else
                button3.Text = "View/Edit";
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            if (question4TextBox.Text == "")
            {
                button4.Text = "Create Note";

            }
            else
                button4.Text = "View/Edit";
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            if (question5TextBox.Text == "")
            {
                button5.Text = "Create Note";

            }
            else
                button5.Text = "View/Edit";
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            if (question6TextBox.Text == "")
            {
                button6.Text = "Create Note";

            }
            else
                button6.Text = "View/Edit";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            if (question7TextBox.Text == "")
            {
                button7.Text = "Create Note";

            }
            else
                button7.Text = "View/Edit";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            if (question8TextBox.Text == "")
            {
                button8.Text = "Create Note";

            }
            else
                button8.Text = "View/Edit";
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {
            if (question9TextBox.Text == "")
            {
                button9.Text = "Create Note";

            }
            else
                button9.Text = "View/Edit";
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            if (question10TextBox.Text == "")
            {
                button10.Text = "Create Note";

            }
            else
                button10.Text = "View/Edit";
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            if (question11TextBox.Text == "")
            {
                button11.Text = "Create Note";

            }
            else
                button11.Text = "View/Edit";
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            if (question12TextBox.Text == "")
            {
                button12.Text = "Create Note";

            }
            else
                button12.Text = "View/Edit";
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            if (question13TextBox.Text == "")
            {
                button13.Text = "Create Note";

            }
            else
                button13.Text = "View/Edit";
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            if (question14TextBox.Text == "")
            {
                button14.Text = "Create Note";

            }
            else
                button14.Text = "View/Edit";
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            if (question15TextBox.Text == "")
            {
                button15.Text = "Create Note";

            }
            else
                button15.Text = "View/Edit";
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {
            if (question16TextBox.Text == "")
            {
                button16.Text = "Create Note";

            }
            else
                button16.Text = "View/Edit";
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            if (question17TextBox.Text == "")
            {
                button17.Text = "Create Note";

            }
            else
                button17.Text = "View/Edit";
        }

        private void textBox25_TextChanged(object sender, EventArgs e)
        {
            if (question18TextBox.Text == "")
            {
                button18.Text = "Create Note";

            }
            else
                button18.Text = "View/Edit";
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            if (question19TextBox.Text == "")
            {
                button19.Text = "Create Note";

            }
            else
                button19.Text = "View/Edit";
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            if (question20TextBox.Text == "")
            {
                button20.Text = "Create Note";

            }
            else
                button20.Text = "View/Edit";
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            if (question21TextBox.Text == "")
            {
                button21.Text = "Create Note";

            }
            else
                button21.Text = "View/Edit";
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            if (question22TextBox.Text == "")
            {
                button22.Text = "Create Note";

            }
            else
                button22.Text = "View/Edit";
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            if (question23TextBox.Text == "")
            {
                button23.Text = "Create Note";

            }
            else
                button23.Text = "View/Edit";
        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {
            if (question24TextBox.Text == "")
            {
                button24.Text = "Create Note";

            }
            else
                button24.Text = "View/Edit";
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            if (question25TextBox.Text == "")
            {
                button25.Text = "Create Note";

            }
            else
                button25.Text = "View/Edit";
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            if (question26TextBox.Text == "")
            {
                button26.Text = "Create Note";

            }
            else
                button26.Text = "View/Edit";
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            if (question27TextBox.Text == "")
            {
                button27.Text = "Create Note";

            }
            else
                button27.Text = "View/Edit";
        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {
            if (question28TextBox.Text == "")
            {
                button28.Text = "Create Note";

            }
            else
                button28.Text = "View/Edit";
        }

        private void textBox36_TextChanged(object sender, EventArgs e)
        {
            if (question29TextBox.Text == "")
            {
                button29.Text = "Create Note";

            }
            else
                button29.Text = "View/Edit";
        }

        private void textBox37_TextChanged(object sender, EventArgs e)
        {
            if (question30TextBox.Text == "")
            {
                button30.Text = "Create Note";

            }
            else
                button30.Text = "View/Edit";
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            if (question31TextBox.Text == "")
            {
                button31.Text = "Create Note";

            }
            else
                button31.Text = "View/Edit";
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            if (question32TextBox.Text == "")
            {
                button32.Text = "Create Note";

            }
            else
                button32.Text = "View/Edit";
        }

        private void textBox40_TextChanged(object sender, EventArgs e)
        {
            if (question33TextBox.Text == "")
            {
                button33.Text = "Create Note";

            }
            else
                button33.Text = "View/Edit";
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            if (question34TextBox.Text == "")
            {
                button34.Text = "Create Note";

            }
            else
                button34.Text = "View/Edit";
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            if (question35TextBox.Text == "")
            {
                button35.Text = "Create Note";

            }
            else
                button35.Text = "View/Edit";
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            if (textBox43.Text == "")
            {
                button36.Text = "Create Note";

            }
            else
                button36.Text = "View/Edit";
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            if (question37TextBox.Text == "")
            {
                button37.Text = "Create Note";

            }
            else
                button37.Text = "View/Edit";
        }

        private void textBox45_TextChanged(object sender, EventArgs e)
        {
            if (question38TextBox.Text == "")
            {
                button38.Text = "Create Note";

            }
            else
                button38.Text = "View/Edit";
        }

        private void textBox46_TextChanged(object sender, EventArgs e)
        {
            if (question39TextBox.Text == "")
            {
                button39.Text = "Create Note";

            }
            else
                button39.Text = "View/Edit";
        }
        #endregion

        private void submitButton_Click(object sender, EventArgs e)
        {
            bool exists = false;
            // submit to db
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT *\n" +
                    "FROM [ATI_Workflow].[dbo].[ContractReview_ME_QE]\n" +
                    "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "' AND ContractReview_Type = 'ME';";

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
                        "UPDATE [ATI_Workflow].[dbo].[ContractReview_ME_QE]\n" +
                        "SET\n" +
                        "[PO_Number] = '" + poNoTextBox.Text + "'\n" +
                        ",[Description_Of_Change] = '" + descriptionOfChangeTextBox.Text + "'\n" +
                        ",[Initial] = '" + initialTextBox.Text + "'\n" +
                        ",[PO_Date] = '" + dateTextBox.Text + "'\n" +
                        ",[Planning] = '" + planningTextBox.Text + "'\n" +
                        ",[Approval] = '" + meApprovalTextBox.Text + "'\n" +
                        ",[Question1_Response] = '" + (question1CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question2_Response] = '" + (question2CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question3_Response] = '" + (question3CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question4_Response] = '" + (question4CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question5_Response] = '" + (question5CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question6_Response] = '" + (question6CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question7_Response] = '" + (question7CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question8_Response] = '" + (question8CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question9_Response] = '" + (question9CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question10_Response] = '" + (question10CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question11_Response] = '" + (question11CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question12_Response] = '" + (question12CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question13_Response] = '" + (question13CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question14_Response] = '" + (question14CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question15_Response] = '" + (question15CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question16_Response] = '" + (question16CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question17_Response] = '" + (question17CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question18_Response] = '" + (question18CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question19_Response] = '" + (question19CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question20_Response] = '" + (question20CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question21_Response] = '" + (question21CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question22_Response] = '" + (question22CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question23_Response] = '" + (question23CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question24_Response] = '" + (question24CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question25_Response] = '" + (question25CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question26_Response] = '" + (question26CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question27_Response] = '" + (question27CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question28_Response] = '" + (question28CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question29_Response] = '" + (question29CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question30_Response] = '" + (question30CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question31_Response] = '" + (question31CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question32_Response] = '" + (question32CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question33_Response] = '" + (question33CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question34_Response] = '" + (question34CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question35_Response] = '" + (question35CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question36_Response] = '" + (question36CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question37_Response] = '" + (question37CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question38_Response] = '" + (question38CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question39_Response] = '" + (question39CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",[Question1_Comments] = '" + question1TextBox.Text + "'\n" +
                        ",[Question2_Comments] = '" + question2TextBox.Text + "'\n" +
                        ",[Question3_Comments] = '" + question3TextBox.Text + "'\n" +
                        ",[Question4_Comments] = '" + question4TextBox.Text + "'\n" +
                        ",[Question5_Comments] = '" + question5TextBox.Text + "'\n" +
                        ",[Question6_Comments] = '" + question6TextBox.Text + "'\n" +
                        ",[Question7_Comments] = '" + question7TextBox.Text + "'\n" +
                        ",[Question8_Comments] = '" + question8TextBox.Text + "'\n" +
                        ",[Question9_Comments] = '" + question9TextBox.Text + "'\n" +
                        ",[Question10_Comments] = '" + question10TextBox.Text + "'\n" +
                        ",[Question11_Comments] = '" + question11TextBox.Text + "'\n" +
                        ",[Question12_Comments] = '" + question12TextBox.Text + "'\n" +
                        ",[Question13_Comments] = '" + question13TextBox.Text + "'\n" +
                        ",[Question14_Comments] = '" + question14TextBox.Text + "'\n" +
                        ",[Question15_Comments] = '" + question15TextBox.Text + "'\n" +
                        ",[Question16_Comments] = '" + question16TextBox.Text + "'\n" +
                        ",[Question17_Comments] = '" + question17TextBox.Text + "'\n" +
                        ",[Question18_Comments] = '" + question8TextBox.Text + "'\n" +
                        ",[Question19_Comments] = '" + question19TextBox.Text + "'\n" +
                        ",[Question20_Comments] = '" + question20TextBox.Text + "'\n" +
                        ",[Question21_Comments] = '" + question21TextBox.Text + "'\n" +
                        ",[Question22_Comments] = '" + question22TextBox.Text + "'\n" +
                        ",[Question23_Comments] = '" + question23TextBox.Text + "'\n" +
                        ",[Question24_Comments] = '" + question24TextBox.Text + "'\n" +
                        ",[Question25_Comments] = '" + question25TextBox.Text + "'\n" +
                        ",[Question26_Comments] = '" + question26TextBox.Text + "'\n" +
                        ",[Question27_Comments] = '" + question27TextBox.Text + "'\n" +
                        ",[Question28_Comments] = '" + question28TextBox.Text + "'\n" +
                        ",[Question29_Comments] = '" + question29TextBox.Text + "'\n" +
                        ",[Question30_Comments] = '" + question30TextBox.Text + "'\n" +
                        ",[Question31_Comments] = '" + question31TextBox.Text + "'\n" +
                        ",[Question32_Comments] = '" + question32TextBox.Text + "'\n" +
                        ",[Question33_Comments] = '" + question33TextBox.Text + "'\n" +
                        ",[Question34_Comments] = '" + question34TextBox.Text + "'\n" +
                        ",[Question35_Comments] = '" + question35TextBox.Text + "'\n" +
                        ",[Question36_Comments] = '" + question36TextBox.Text + "'\n" +
                        ",[Question37_Comments] = '" + question37TextBox.Text + "'\n" +
                        ",[Question38_Comments] = '" + question38TextBox.Text + "'\n" +
                        ",[Question39_Comments] = '" + question39TextBox.Text + "'\n" +
                        "WHERE Job = '" + jobNo + "' AND Workflow_ID = '" + workflow_ID + "' AND ContractReview_Type = 'ME';";

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
                        "INSERT INTO [ATI_Workflow].[dbo].[ContractReview_ME_QE]\n" +
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
                        ",[Question7_Response]\n" +
                        ",[Question8_Response]\n" +
                        ",[Question9_Response]\n" +
                        ",[Question10_Response]\n" +
                        ",[Question11_Response]\n" +
                        ",[Question12_Response]\n" +
                        ",[Question13_Response]\n" +
                        ",[Question14_Response]\n" +
                        ",[Question15_Response]\n" +
                        ",[Question16_Response]\n" +
                        ",[Question17_Response]\n" +
                        ",[Question18_Response]\n" +
                        ",[Question19_Response]\n" +
                        ",[Question20_Response]\n" +
                        ",[Question21_Response]\n" +
                        ",[Question22_Response]\n" +
                        ",[Question23_Response]\n" +
                        ",[Question24_Response]\n" +
                        ",[Question25_Response]\n" +
                        ",[Question26_Response]\n" +
                        ",[Question27_Response]\n" +
                        ",[Question28_Response]\n" +
                        ",[Question29_Response]\n" +
                        ",[Question30_Response]\n" +
                        ",[Question31_Response]\n" +
                        ",[Question32_Response]\n" +
                        ",[Question33_Response]\n" +
                        ",[Question34_Response]\n" +
                        ",[Question35_Response]\n" +
                        ",[Question36_Response]\n" +
                        ",[Question37_Response]\n" +
                        ",[Question38_Response]\n" +
                        ",[Question39_Response]\n" +
                        ",[Question1_Comments]\n" +
                        ",[Question2_Comments]\n" +
                        ",[Question3_Comments]\n" +
                        ",[Question4_Comments]\n" +
                        ",[Question5_Comments]\n" +
                        ",[Question6_Comments]\n" +
                        ",[Question7_Comments]\n" +
                        ",[Question8_Comments]\n" +
                        ",[Question9_Comments]\n" +
                        ",[Question10_Comments]\n" +
                        ",[Question11_Comments]\n" +
                        ",[Question12_Comments]\n" +
                        ",[Question13_Comments]\n" +
                        ",[Question14_Comments]\n" +
                        ",[Question15_Comments]\n" +
                        ",[Question16_Comments]\n" +
                        ",[Question17_Comments]\n" +
                        ",[Question18_Comments]\n" +
                        ",[Question19_Comments]\n" +
                        ",[Question20_Comments]\n" +
                        ",[Question21_Comments]\n" +
                        ",[Question22_Comments]\n" +
                        ",[Question23_Comments]\n" +
                        ",[Question24_Comments]\n" +
                        ",[Question25_Comments]\n" +
                        ",[Question26_Comments]\n" +
                        ",[Question27_Comments]\n" +
                        ",[Question28_Comments]\n" +
                        ",[Question29_Comments]\n" +
                        ",[Question30_Comments]\n" +
                        ",[Question31_Comments]\n" +
                        ",[Question32_Comments]\n" +
                        ",[Question33_Comments]\n" +
                        ",[Question34_Comments]\n" +
                        ",[Question35_Comments]\n" +
                        ",[Question36_Comments]\n" +
                        ",[Question37_Comments]\n" +
                        ",[Question38_Comments]\n" +
                        ",[Question39_Comments])\n" +
                        "VALUES\n" +
                        "('" + jobNo + "'\n" +
                        ",'" + workflow_ID + "'\n" +
                        ",'ME'\n" +
                        ",'" + poNoTextBox.Text + "'\n" +
                        ",'" + descriptionOfChangeTextBox.Text + "'\n" +
                        ",'" + initialTextBox.Text + "'\n" +
                        ",'" + dateTextBox.Text + "'\n" +
                        ",'" + planningTextBox.Text + "'\n" +
                        ",'" + meApprovalTextBox.Text + "'\n" +
                        ",'" + (question1CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question2CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question3CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question4CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question5CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question6CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question7CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question8CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question9CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question10CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question11CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question12CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question13CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question14CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question15CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question16CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question17CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question18CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question19CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question20CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question21CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question22CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question23CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question24CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question25CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question26CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question27CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question28CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question29CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question30CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question31CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question32CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question33CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question34CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question35CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question36CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question37CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question38CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + (question39CheckBox.Checked ? 1 : 0) + "'\n" +
                        ",'" + question1TextBox.Text + "'\n" +
                        ",'" + question2TextBox.Text + "'\n" +
                        ",'" + question3TextBox.Text + "'\n" +
                        ",'" + question4TextBox.Text + "'\n" +
                        ",'" + question5TextBox.Text + "'\n" +
                        ",'" + question6TextBox.Text + "'\n" +
                        ",'" + question7TextBox.Text + "'\n" +
                        ",'" + question8TextBox.Text + "'\n" +
                        ",'" + question9TextBox.Text + "'\n" +
                        ",'" + question10TextBox.Text + "'\n" +
                        ",'" + question11TextBox.Text + "'\n" +
                        ",'" + question12TextBox.Text + "'\n" +
                        ",'" + question13TextBox.Text + "'\n" +
                        ",'" + question14TextBox.Text + "'\n" +
                        ",'" + question15TextBox.Text + "'\n" +
                        ",'" + question16TextBox.Text + "'\n" +
                        ",'" + question17TextBox.Text + "'\n" +
                        ",'" + question18TextBox.Text + "'\n" +
                        ",'" + question19TextBox.Text + "'\n" +
                        ",'" + question20TextBox.Text + "'\n" +
                        ",'" + question21TextBox.Text + "'\n" +
                        ",'" + question22TextBox.Text + "'\n" +
                        ",'" + question23TextBox.Text + "'\n" +
                        ",'" + question24TextBox.Text + "'\n" +
                        ",'" + question25TextBox.Text + "'\n" +
                        ",'" + question26TextBox.Text + "'\n" +
                        ",'" + question27TextBox.Text + "'\n" +
                        ",'" + question28TextBox.Text + "'\n" +
                        ",'" + question29TextBox.Text + "'\n" +
                        ",'" + question30TextBox.Text + "'\n" +
                        ",'" + question31TextBox.Text + "'\n" +
                        ",'" + question32TextBox.Text + "'\n" +
                        ",'" + question33TextBox.Text + "'\n" +
                        ",'" + question34TextBox.Text + "'\n" +
                        ",'" + question35TextBox.Text + "'\n" +
                        ",'" + question36TextBox.Text + "'\n" +
                        ",'" + question37TextBox.Text + "'\n" +
                        ",'" + question38TextBox.Text + "'\n" +
                        ",'" + question39TextBox.Text + "')\n;";

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
    }
}
