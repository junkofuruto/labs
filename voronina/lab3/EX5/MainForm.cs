using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX5
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void drawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Refresh();

            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics graphics = CreateGraphics();
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.FillEllipse(sb, new Rectangle(Width / 2 - Program.InputValue / 2, Height / 2 - Program.InputValue / 2 - 24, Program.InputValue, Program.InputValue));
            sb.Dispose();
            graphics.Dispose();
        }
        private void calcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Program.InputValue == -1 ? "Значение не установлено" : $"{Program.InputValue}");
        }
        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();

            InputForm inputForm = new InputForm();
            inputForm.Show();
        }
    }
}
