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

namespace EX3
{
    public partial class MainWindow : Window
    {
        private Vector vector1;
        private Vector vector2;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveVectors(object sender, RoutedEventArgs e)
        {
            int[] values1 = FirstDataTextBox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int[] values2 = SecondDataTextBox.Text.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            vector1 = new Vector(values1.Length);
            vector2 = new Vector(values2.Length);

            try
            {
                for (int i = 0; i < values1.Length; i++)
                {
                    vector1[i] = values1[i];
                }
                for (int i = 0; i < values2.Length; i++)
                {
                    vector2[i] = values2[i];
                }
            }
            catch (VectorOutOfRangeException)
            {
                MessageBox.Show("Ошибка длины вектора");
                vector1 = null;
                vector2 = null;
            }
        }
        private void DelVectors(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(string.Join("\n", (vector1 / Convert.ToInt32(SecondDataTextBox.Text)).ToString()));
            }
            catch (VectorNotSimilarLengthException)
            {
                MessageBox.Show("Вектора разных длинн");
            }
            catch (VectorOutOfRangeException)
            {
                MessageBox.Show("Ошибка длины вектора");
            }
        }
        private void MulVectors(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(string.Join("\n", (vector1 * Convert.ToInt32(SecondDataTextBox.Text)).ToString()));
            }
            catch (VectorNotSimilarLengthException)
            {
                MessageBox.Show("Вектора разных длинн");
            }
            catch (VectorOutOfRangeException)
            {
                MessageBox.Show("Ошибка длины вектора");
            }
        }
        private void MinVectors(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(string.Join("\n", (vector1 - vector2).ToString()));
            }
            catch (VectorNotSimilarLengthException)
            {
                MessageBox.Show("Вектора разных длинн");
            }
            catch (VectorOutOfRangeException)
            {
                MessageBox.Show("Ошибка длины вектора");
            }
        }
        private void SumVectors(object sender, RoutedEventArgs e)
        {
            try
            {
                MessageBox.Show(string.Join("\n", (vector1 + vector2).ToString()));
            }
            catch (VectorNotSimilarLengthException)
            {
                MessageBox.Show("Вектора разных длинн");
            }
            catch (VectorOutOfRangeException)
            {
                MessageBox.Show("Ошибка длины вектора");
            }
        }
    }
}
