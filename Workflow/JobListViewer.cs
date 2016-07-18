using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Workflow
{
    public partial class JobListViewer : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public JobListViewer()
        {
            InitializeComponent();
        }

        private void JobListViewer_Load(object sender, EventArgs e)
        {
            // set date time picker range to between a year from now and today
            startDateTimePicker.Value = DateTime.Now.AddYears(-1);
            endDateTimePicker.Value = DateTime.Now;

            // add event handlers for updating the datagridview
            startDateTimePicker.ValueChanged += updateDataGridView;
            endDateTimePicker.ValueChanged += updateDataGridView;
            customerTextBox.TextChanged += updateDataGridView;
            partNoTextBox.TextChanged += updateDataGridView;
            jobTextBox.TextChanged += updateDataGridView;

            // set up datagridview
            dataGridView.DataSource = bindingSource;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = true;

            updateDataGridView(new object(), new EventArgs());
        }

        private void updateDataGridView(object sender, EventArgs e)
        {
            string query =
                "SELECT uT.Job, uT.Customer, uT.Part_Number, workflowT.Workflow_ID\n" +
                "FROM\n" +
                "\t(SELECT Job, Customer, Part_Number\n" +
                "\tFROM PRODUCTION.dbo.Job\n" +
                "\tUNION\n" +
                "\tSELECT wJ.Job, wJ.Customer, wJ.Part_Number\n" +
                "\tFROM ATI_Workflow.dbo.Job AS wJ\n" +
                ") AS uT\n" +
                "LEFT JOIN ATI_Workflow.dbo.StatusData AS workflowT\n" +
                "ON workflowT.Job = uT.Job\n" +
                "WHERE uT.Job LIKE '%" + jobTextBox.Text.Trim() + "%' AND uT.Part_Number LIKE '%" + partNoTextBox.Text.Trim() + "%' AND uT.Customer LIKE '%" + customerTextBox.Text.Trim() + "%';";

            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, Globals.binding_connection_string);

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            bindingSource.DataSource = dt;

            // update Rows label
            rowsLabel.Text = "Rows: " + dt.Rows.Count;
        }

        private void createJobButton_Click(object sender, EventArgs e)
        {
            // launch dialog to ask for the type of job to be created
            this.Hide();
            Form poType = new POTypeForm();
            poType.FormClosed += (s, args) => this.Close();
            poType.Show();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // check that the cell is valid
            if (e == null)
                return;
            if (dataGridView.Rows[e.RowIndex].Cells[0].Value == null || dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Trim().Length == 0)
                return;

            // launch status page and pass job, partno and customer as arguments
            this.Hide();
            Form statusPage = new StatusPage(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString(),
                                                dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString(),
                                                dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString(),
                                                "Contract Review");
            statusPage.FormClosed += (s, args) => this.Close();
            statusPage.Show();
        }

        private void tastkListButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form jobList = new TaskViewer();
            jobList.FormClosed += (s, args) =>  this.Close();
            jobList.Show();
        }
    }
}
