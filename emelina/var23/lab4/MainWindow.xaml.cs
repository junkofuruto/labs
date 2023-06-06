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

namespace fourth_lab
{
    public partial class MainWindow : Window
    {
        List<Maze> mazes = new List<Maze>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddMaze(object sender, RoutedEventArgs e)
        {
            Maze maze = new Maze();
            maze.BasicScore = Convert.ToUInt32(BasicScore1.Text);
            maze.LevelsCount = Convert.ToUInt32(LevelsCount1.Text);
            maze.AddedObstacles = Convert.ToUInt32(Added1.Text);
            mazes.Add(maze);
        }

        private void AddItemedMaze(object sender, RoutedEventArgs e)
        {
            ItemMaze maze = new ItemMaze();
            maze.BasicScore = Convert.ToUInt32(BasicScore2.Text);
            maze.LevelsCount = Convert.ToUInt32(LevelsCount2.Text);
            maze.AddedObstacles = Convert.ToUInt32(Added2.Text);
            maze.AddedItems = Convert.ToUInt32(Items2.Text);
            mazes.Add(maze);
        }

        private void AddMonsteredItems(object sender, RoutedEventArgs e)
        {
            MonsterMaze maze = new MonsterMaze();
            maze.BasicScore = Convert.ToUInt32(BasicScore3.Text);
            maze.LevelsCount = Convert.ToUInt32(LevelsCount3.Text);
            maze.AddedObstacles = Convert.ToUInt32(Added3.Text);
            maze.AddedMonsters = Convert.ToUInt32(Monsters3.Text);
            mazes.Add(maze);
        }

        private void Output(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            foreach (Maze maze in mazes)
            {
                Info.Text += maze.GetLevelScore() + "\n";
            }
        }
    }
}
