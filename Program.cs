using System;
using System.Windows.Forms;
using OOP_FINAL_PROJECT;

namespace OOP_FINAL_PROJECT
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Launch the home/welcome screen first
            Application.Run(new HomeForm());
        }
    }
}
