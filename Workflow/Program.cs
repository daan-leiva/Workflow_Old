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
<<<<<<< HEAD
            Application.Run(new Viewer());
=======
            Application.Run(new ContractReviewCheckList());
            
>>>>>>> 37b04e496485fc81c67e192956bbe5dd0b8f4d9f
        }
    }
}
