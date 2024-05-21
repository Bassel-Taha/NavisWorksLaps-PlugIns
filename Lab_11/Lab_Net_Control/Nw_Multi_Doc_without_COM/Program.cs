using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using Autodesk.Navisworks.Api.Controls;
namespace Nw_Multi_Doc_without_COM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationControl.ApplicationType = ApplicationType.MultipleDocument ;
            Autodesk.Navisworks.Api.Controls.ApplicationControl.Initialize();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ApplicationControl.Terminate();
        }
    }
}
