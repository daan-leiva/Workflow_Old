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
    public partial class StatusPage : Form
    {
        public StatusPage()
        {
            InitializeComponent();
        }

        private void StatusPage_Load(object sender, EventArgs e)
        {
            // load dummy objects into workflow list
            workflowList.Items.Add("0001");
            workflowList.Items.Add("0002");
            workflowList.Items.Add("0003");
        }
    }
}
