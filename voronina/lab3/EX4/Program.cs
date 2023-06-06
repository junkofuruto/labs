using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4
{
    internal static class Program
    {
        public static MainForm MainWindow { get; set; }
        public static int RectangleWidth { get; set; }
        public static int RectangleHeigth { get; set; }

        [STAThread]
        static void Main()
        {
            RectangleWidth = -1;
            RectangleHeigth = -1;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
