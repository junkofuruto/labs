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

namespace EX5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedTask(object sender, RoutedEventArgs e)
        {
            int[] values1 = FirstDataTextBox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] values2 = SecondDataTextBox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            if (values1.Length != values2.Length)
            {
                MessageBox.Show("Массивы разной длины");
                return;
            }

            MessageBox.Show(string.Join("; ", Task.FirstExercise(values1, values2)));
        }

        private void ProceedTask1(object sender, RoutedEventArgs e)
        {
            int[] values1 = FirstDataTextBox1.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] values2 = SecondDataTextBox1.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            if (values1.Length != values2.Length)
            {
                MessageBox.Show("Массивы разной длинны");
                return;
            }

            MessageBox.Show(string.Join("; ", Task.SecondExercise(values1, values2)));
        }
    }
}
