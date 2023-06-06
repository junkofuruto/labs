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

namespace EX1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ProceedTask1(object sender, RoutedEventArgs e)
        {
            string result = Task.GetFirstNegative(DataTextBox1.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray()).ToString();
            MessageBox.Show(result);
        }
        private void ProceedTask2(object sender, RoutedEventArgs e)
        {
            string result = Task.GetLastEven(DataTextBox2.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray()).ToString();
            MessageBox.Show(result);
        }
        private void ProceedTask3(object sender, RoutedEventArgs e)
        {
            Int32[] result = Task.GetValusWithTarget(DataTextBox3.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray(), Convert.ToInt32(TargetTextBox3.Text));
            MessageBox.Show($"{string.Join("; ", result)}");
        }
    }
}
