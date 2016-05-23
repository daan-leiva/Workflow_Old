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
    public partial class CreateWorkflow : Form
    {
        private const string connection_string = "DSN=jobboss32;UID=jbread;PWD=Cloudy2Day";

        public CreateWorkflow()
        {
            InitializeComponent();
        }

        private void CreateWorkflow_Load(object sender, EventArgs e)
        {

        }

        private void jobTextBox_TextChanged(object sender, EventArgs e)
        {
             TextBox textBox = (TextBox)sender;

            if (textBox.Text.Length < 3)
            {
                customerTextBox.Text = "";
                partTextBox.Text = "";
                revTextBox.Text = "";
                return;
            }

            using (OdbcConnection conn = new OdbcConnection(connection_string))
            {
                conn.Open();

                string query = "SELECT Customer, Part_Number, Rev\n" +
                                "FROM Production.dbo.Job\n" +
                                "WHERE Job = '" + textBox.Text + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if(reader.Read())
                {
                    customerTextBox.Text = reader.IsDBNull(0) ? "" : reader.GetString(0);
                    partTextBox.Text = reader.IsDBNull(1) ? "" : reader.GetString(1);
                    revTextBox.Text = reader.IsDBNull(2) ? "" : reader.GetString(2);
                }
                else
                {
                    customerTextBox.Text ="" ;
                    partTextBox.Text = "" ;
                    revTextBox.Text = "";
                }
            }
        }
    }
}
