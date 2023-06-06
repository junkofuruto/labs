using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();

            SizeForm sizeForm = new SizeForm();
            sizeForm.Show();
        }

        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.RectangleWidth == -1 || Program.RectangleHeigth == -1)
                return;

            Refresh();

            Rectangle rectangle = new Rectangle(Width / 2 - Program.RectangleWidth / 2, Height / 2 - Program.RectangleHeigth / 2 - 24,
                Program.RectangleWidth, Program.RectangleHeigth);
            SolidBrush rectangleColor = new SolidBrush(Color.Red);
            Graphics formGraphics = CreateGraphics();
            formGraphics.FillRectangle(rectangleColor, rectangle);
            rectangleColor.Dispose();
            formGraphics.Dispose();
        }
    }
}
