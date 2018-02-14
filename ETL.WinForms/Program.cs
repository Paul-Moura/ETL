using System;
using System.Windows.Forms;
using ETL.Controllers;

namespace ETL
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
            using (var controller = new MainController())
            {
                controller.ShowDialog();
            }
        }
    }
}