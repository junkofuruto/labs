using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void FillForm()
        {
            GC.Collect();
            Refresh();
            Rectangle rectangle = new Rectangle(0, 24, 0, 0);
            switch (Program.FillMode)
            {
                case FormFillMode.Full:
                    rectangle.Width = this.Width;
                    rectangle.Height = this.Height;
                    break;
                case FormFillMode.Top:
                    rectangle.Width = this.Width;
                    rectangle.Height = this.Height / 2 - 24;
                    break;
                case FormFillMode.Bottom:
                    rectangle.Y = this.Height / 2 - 24;
                    rectangle.Width = this.Width;
                    rectangle.Height = this.Height / 2;
                    break;
            }
            SolidBrush rectangleColor = new SolidBrush(Program.SelectedColor);
            Graphics formGraphics = CreateGraphics();
            formGraphics.FillRectangle(rectangleColor, rectangle);
            rectangleColor.Dispose();
            formGraphics.Dispose();
        }
        private void inputColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            ColorForm colorForm = new ColorForm();
            colorForm.Show();
        }
        private void changeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FillForm();
        }
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.Control;
        }
    }
}
