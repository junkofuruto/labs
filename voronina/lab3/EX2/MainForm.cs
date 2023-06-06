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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void beginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            BeginForm beginForm = new BeginForm();
            beginForm.Show();
        }
        private void workToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            WorkForm workForm = new WorkForm();
            workForm.Show();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GC.Collect();
            AboutForm aboutForm = new AboutForm();
            aboutForm.Show();
        }
    }
}
