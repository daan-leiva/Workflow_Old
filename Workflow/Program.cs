using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Workflow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Viewer());
            //Application.Run(new ContractReviewCheckList());
            Application.Run(new ContractReviewCheckList_ME());
            Application.Run(new ContractReviewCheckList_QA());
            Application.Run(new ContractReviewCheckList_QE());
        }
    }
}
