using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractClass {
    static class Program {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            //Console.WriteLine(Application.ProductName);
            //Rectangle rectangle = new Rectangle(0.0f, 0.0f, 10.0f, 10.0f);
            //Console.WriteLine("Perimetr " + rectangle.Perimetr().ToString());
            //Console.WriteLine("Area " + rectangle.Area().ToString());
        }
    }
}
