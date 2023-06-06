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
    public partial class ColorForm : Form
    {
        public ColorForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.SelectedColor = Color.FromArgb(255, 
                Convert.ToInt32(RedNumbericUpDown.Value),
                Convert.ToInt32(GreenRedNumbericUpDown.Value),
                Convert.ToInt32(BlueNumbericUpDown.Value));
            Program.FillMode = FormFillModeConvert.ToFillMode(FullFormVideoModeRadioButton.Checked,
                TopFormVideoModeRadioButton.Checked,
                BottomFormVideoModeRadioButton.Checked);
        }
    }
}
