using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class BeginForm : Form
    {
        public BeginForm()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            try
            {
                Program.Result = new List<string>()
                {
                    ValueTextBox1.Text, ValueTextBox2.Text,
                    ValueTextBox3.Text, ValueTextBox4.Text,
                    ValueTextBox5.Text, ValueTextBox6.Text,
                    ValueTextBox7.Text, ValueTextBox8.Text,
                    ValueTextBox9.Text, ValueTextBox10.Text,
                }.Select(x => Convert.ToInt32(x)).ToArray();
                Program.IsSum = SumRadioButton.Checked;
            }
            catch
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
