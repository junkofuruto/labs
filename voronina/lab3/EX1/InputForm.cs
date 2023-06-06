using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class InputForm : Form
    {
        public InputForm()
        {
            InitializeComponent();
        }

        private double ConvertToCurrency(double value, double multiplyer, bool isLowered)
        {
            double result = value * multiplyer;
            if (result > 1000 && isLowered)
                result -= result * 0.05;

            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                EuroTextBox.Text = ConvertToCurrency(Convert.ToDouble(RubelsTextBox.Text), 0.0128, LoweredCurrentRadioButton.Checked).ToString();
                DollarsTextBox.Text = ConvertToCurrency(Convert.ToDouble(RubelsTextBox.Text), 0.0137, LoweredCurrentRadioButton.Checked).ToString();
            }
            catch
            {
                MessageBox.Show("Ошибка конвертации данных");
            }
        }
    }
}
