using System;
using System.Reflection;
using System.Windows.Forms;

namespace SubReal.EasyDuplicateFinder
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FindForm());

        }     

    }
}
