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

namespace lab8
{
    public partial class MainWindow : Window
    {
        // 0: . - пустое пространство
        // 1: # - стена
        // 2: a - препятствие
        // 3: i - предмет
        // 4: m - монстр

        uint[,] maze = new uint[10, 10]
        {
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1},
        {1, 0, 1, 3, 1, 3, 0, 1, 4, 1},
        {1, 0, 1, 0, 1, 1, 0, 1, 0, 1},
        {1, 0, 0, 0, 0, 1, 0, 0, 0, 1},
        {1, 1, 1, 1, 0, 1, 1, 1, 0, 1},
        {1, 0, 0, 0, 0, 0, 0, 0, 0, 1},
        {1, 4, 1, 0, 1, 1, 1, 1, 0, 1},
        {1, 4, 1, 0, 1, 2, 1, 4, 0, 1},
        {1, 4, 1, 0, 1, 0, 0, 0, 0, 1},
        {1, 1, 1, 1, 1, 1, 1, 1, 1, 1}
        };

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Generate(object sender, RoutedEventArgs e)
        {
            output.Text = "";

            for (int i = 0; i < maze.Length; i++)
            {
                for (int j = 0; i < maze.Length; j++)
                {
                    output.Text += maze[i, j];
                }
                output.Text += "\n";
            }
        }
    }
}
