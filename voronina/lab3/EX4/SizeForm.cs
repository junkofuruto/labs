﻿using System;
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
    public partial class SizeForm : Form
    {
        public SizeForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.RectangleWidth = Convert.ToInt32(numericUpDown1.Value);
            Program.RectangleHeigth = Convert.ToInt32(numericUpDown2.Value);
        }
    }
}
