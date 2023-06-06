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
    public partial class WorkForm : Form
    {
        public WorkForm()
        {
            InitializeComponent();

            if (Program.IsSum == null || Program.Result == null)
                label1.Text = $"Результата нет";
            else if (Program.IsSum == true)
                label1.Text = $"{Program.Result.Sum()}";
            else
                label1.Text = string.Join("\n", Program.Result.Select(x => Math.Abs(x)));
        }
    }
}
