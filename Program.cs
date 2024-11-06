using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpsonsDepartmentStore
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
            SetupDataDirectoryPath();
            Application.Run(new StartPage());
        }

        private static void SetupDataDirectoryPath()
        {
            string debugPath = System.IO.Path.GetDirectoryName(Environment.CurrentDirectory);
            string dataDirectoryPath = System.IO.Path.GetDirectoryName(debugPath);
            AppDomain.CurrentDomain.SetData("DataDirectory", dataDirectoryPath);
        }
    }
}
