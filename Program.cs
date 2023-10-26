using JOB_FINDER.Company_Forms.View_Applications;
using JOB_FINDER.Employee_Forms;
using JOB_FINDER.Employee_Forms.Career_Guidance;
using JOB_FINDER.Login_Forms;
using JOB_FINDER.Login_Forms.Company_Sign_Up;
using JOB_FINDER.Login_Forms.Sign_In_Form;
using JOB_FINDER.Login_Forms.Sign_Up_Form;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JOB_FINDER
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Sign_In());
        }
    }
}
