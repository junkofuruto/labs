using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EX6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedTask(object sender, RoutedEventArgs e)
        {
            Former former = new Former(DataTextBox.Text.Split('\n').Select(x => x.Split(' ').Select(y => Convert.ToInt32(y)).ToArray()).ToArray());
            StringBuilder result = new StringBuilder();
            bool[,] bitArray = former.FormLogicMatrix();
            for (int i = 0; i < bitArray.GetLength(0); i++)
            {
                for (int j = 0; j < bitArray.GetLength(1); j++)
                {
                    result.Append(bitArray[i, j] ? "1 " : "0 ");
                }
                result.Append("\n");
            }
            MessageBox.Show(result.ToString());
        }

        private void PressEnter(object sender, RoutedEventArgs e)
        {
            DataTextBox.Text = string.Concat(DataTextBox.Text, "\n");
        }
    }
}
