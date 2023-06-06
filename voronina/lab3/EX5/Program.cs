using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5
{
    internal static class Program
    {
        public static int InputValue { get; set; }

        [STAThread]
        static void Main()
        {
            InputValue = -1;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
