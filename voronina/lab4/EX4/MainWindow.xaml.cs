using System;
using System.Linq;
using System.Windows;

namespace EX4
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
            double[] values1 = FirstDataTextBox.Text.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();
            double[] values2 = SecondDataTextBox.Text.Split(' ').Select(x => Convert.ToDouble(x)).ToArray();

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
