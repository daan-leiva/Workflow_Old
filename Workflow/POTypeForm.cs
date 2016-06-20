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
    public partial class POTypeForm : Form
    {
        public POTypeForm()
        {
            InitializeComponent();
        }

        private void hondaButton_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            // launch honda PO
            this.Hide();
            Form hondaPOForm = new HondaPOReview(r.Next(30001,39999).ToString(), false);
            hondaPOForm.FormClosed += (s, args) => this.Close();
            hondaPOForm.Show();
        }

        private void rollsRoyceButton_Click(object sender, EventArgs e)
        {
            // launch rolls royce PO
            Random r = new Random();
            this.Hide();
            Form rollsRoycePOForm = new RollsRoycePOReview(r.Next(30001, 39999).ToString(), false);
            rollsRoycePOForm.FormClosed += (s, args) => this.Close();
            rollsRoycePOForm.Show();
        }
    }
}
