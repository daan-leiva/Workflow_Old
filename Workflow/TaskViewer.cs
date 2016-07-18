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
    public partial class TaskViewer : Form
    {
        public TaskViewer()
        {
            InitializeComponent();
        }

        private void TaskViewer_Load(object sender, EventArgs e)
        {
            // load info into labels
            using (OdbcConnection conn = new OdbcConnection(Globals.odbc_connection_string))
            {
                conn.Open();

                string query =
                    "SELECT\n" +
                    "[firstName]\n" +
                    ",[lastName]\n" +
                    "FROM[ATI_Workflow].[dbo].[UserData]\n" +
                    "WHERE userName = '" + Globals.userName + "';";

                OdbcCommand com = new OdbcCommand(query, conn);
                OdbcDataReader reader = com.ExecuteReader();

                if(reader.Read())
                {
                    firstNameLabel.Text = reader.GetString(0);
                    lastNameLabel.Text = reader.GetString(1);
                    userNameLabel.Text = Globals.userName;
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
