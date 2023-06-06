using System;
using System.Drawing;
using System.Windows.Forms;

namespace EX3
{
    internal enum FormFillMode
    {
        Full, 
        Top,
        Bottom
    }
    internal static class FormFillModeConvert
    {
        public static FormFillMode ToFillMode(bool fullMode, bool topMode, bool bottomMode)
        {
            FormFillMode mode;
            if (fullMode) mode = FormFillMode.Full;
            else if (topMode) mode = FormFillMode.Top;
            else if (bottomMode) mode = FormFillMode.Bottom;
            else mode = FormFillMode.Full;
            return mode;
        }
    }
    internal static class Program
    {
        public static Color SelectedColor { get; set; }
        public static FormFillMode FillMode { get; set; }

        [STAThread]
        static void Main()
        {
            SelectedColor = Color.White;
            FillMode = FormFillMode.Full;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
