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
    public partial class Viewer : Form
    {
        public Viewer()
        {
            InitializeComponent();
        }

        private void viewContractReviewButton_Click(object sender, EventArgs e)
        {
            Form contractReviewForm = new ContractReviewCheckList();
            contractReviewForm.Show();
        }

        private void viewQuickReleaseButton_Click(object sender, EventArgs e)
        {
            Form quickReleaseForm = new QuickReleaseForm();
            quickReleaseForm.Show();
        }

        private void viewRollsFormButton_Click(object sender, EventArgs e)
        {
            Form rollsRoycePOReview = new RollsRoycePOReview();
            rollsRoycePOReview.Show();
        }

        private void viewHondaPOFormButton_Click(object sender, EventArgs e)
        {
            Form hondaPOReview = new HondaPOReview();
            hondaPOReview.Show();
        }
    }
}
