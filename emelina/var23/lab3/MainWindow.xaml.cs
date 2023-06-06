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
using maze;

namespace third_lab
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        Maze maze1;
        Maze maze2;

        private void FieldTextChanged(object sender, TextChangedEventArgs e)
        {
            ADD_BUTTON.IsEnabled = BASIC_SCORE_1.Text != "" & LEVELS_COUNT_1.Text != "" & ADDED_OBSTACLES_1.Text != "" &
                                   BASIC_SCORE_2.Text != "" & LEVELS_COUNT_2.Text != "" & ADDED_OBSTACLES_2.Text != "";
        }

        private void ADD_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            maze1 = new Maze();
            maze1.BasicScore = Convert.ToUInt32(BASIC_SCORE_1.Text);
            maze1.LevelsCount = Convert.ToUInt32(BASIC_SCORE_1.Text);
            maze1.AddedObstacles = Convert.ToUInt32(BASIC_SCORE_1.Text);

            maze2 = new Maze();
            maze2.BasicScore = Convert.ToUInt32(BASIC_SCORE_2.Text);
            maze2.LevelsCount = Convert.ToUInt32(BASIC_SCORE_2.Text);
            maze2.AddedObstacles = Convert.ToUInt32(BASIC_SCORE_2.Text);

            INFO_BUTTON.IsEnabled = true;
            OUT_BUTTON.IsEnabled = true;
        }

        private void INFO_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            INFO.Text = "";
            INFO.Text += "1 - Счет на текущем уровне: " + maze1.GetLevelScore() + "; ";
            INFO.Text += "Число препядствий на тек. ур.: " + maze1.GetLevelObstacles() + "\n";
            INFO.Text += "2 - Счет на текущем уровне: " + maze2.GetLevelScore() + "; ";
            INFO.Text += "Число препядствий на тек. ур.: " + maze2.GetLevelObstacles() + "\n";
        }

        private void OUT_BUTTON_Click(object sender, RoutedEventArgs e)
        {
            INFO.Text = maze1.GetLevelScore() > maze2.GetLevelScore() ? "1" : "2";
        }
    }
}
