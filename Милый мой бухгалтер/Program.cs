using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1
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
            Application.Run(new MainForm());
         /*   var Vasyan = new Worker(1, "Василий", 32, (Positions)0, 150, 1);
            var Kolyan = new Worker(2, "Николай", 59, (Positions)3, 10, 1);
            var Save = new Control();
            Save.Save(Vasyan);
            Save.Save(Kolyan);
          */


        }
    }
}
