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
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (SquareRadioButton.Checked)
                Program.InputValue = 2 * Convert.ToInt32(Math.Sqrt(Convert.ToDouble(ValueNumericUpDown.Value) / Math.PI));
            else
                Program.InputValue = Convert.ToInt32(Convert.ToDouble(ValueNumericUpDown.Value) / Math.PI);
        }
    }
}
