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
            try
            {
                Maze maze = new Maze();
                maze.BasicScore = Convert.ToUInt32(BasicScore1.Text);
                maze.LevelsCount = Convert.ToUInt32(LevelsCount1.Text);
                maze.AddedObstacles = Convert.ToUInt32(Added1.Text);

                MessageBox.Show($"Базовый счет: {maze.BasicScore}\n" +
                                $"Кол-во уровней: {maze.LevelsCount}\n" +
                                $"Препятсвия: {maze.AddedObstacles}\n" +
                                $"Общее кол-во препятсвий: {maze.GetLevelObstacles()}\n" +
                                $"Общий счёт: {maze.GetLevelScore()}\n" +
                                $"Сложность: {maze.GetDifficulty()}\n" +
                                $"Цвет стен: {WallColor.SelectedValue}", "Инфо");
            }
            catch
            {
                MessageBox.Show("Ошибка заполения данных", "Ошибка");
            }
        }

        private void AddItemedMaze(object sender, RoutedEventArgs e)
        {
            try
            {
                ItemMaze maze = new ItemMaze();
                maze.BasicScore = Convert.ToUInt32(BasicScore2.Text);
                maze.LevelsCount = Convert.ToUInt32(LevelsCount2.Text);
                maze.AddedObstacles = Convert.ToUInt32(Added2.Text);
                maze.AddedItems = Convert.ToUInt32(Items2.Text);

                MessageBox.Show($"Базовый счет: {maze.BasicScore}\n" +
                                $"Кол-во уровней: {maze.LevelsCount}\n" +
                                $"Препятсвия: {maze.AddedObstacles}\n" +
                                $"Общее кол-во препятсвий: {maze.GetLevelObstacles()}\n" +
                                $"Общий счёт: {maze.GetLevelScore()}\n" +
                                $"Сложность: {maze.GetDifficulty()}\n" +
                                $"Цвет стен: {WallColor.SelectedValue}", "Инфо");
            }
            catch
            {
                MessageBox.Show("Ошибка заполения данных", "Ошибка");
            }

        }

        private void AddMonsteredItems(object sender, RoutedEventArgs e)
        {
            try
            {
                MonsterMaze maze = new MonsterMaze();
                maze.BasicScore = Convert.ToUInt32(BasicScore3.Text);
                maze.LevelsCount = Convert.ToUInt32(LevelsCount3.Text);
                maze.AddedObstacles = Convert.ToUInt32(Added3.Text);
                maze.AddedMonsters = Convert.ToUInt32(Monsters3.Text);

                MessageBox.Show($"Базовый счет: {maze.BasicScore}\n" +
                                $"Кол-во уровней: {maze.LevelsCount}\n" +
                                $"Препятсвия: {maze.AddedObstacles}\n" +
                                $"Общее кол-во препятсвий: {maze.GetLevelObstacles()}\n" +
                                $"Общий счёт: {maze.GetLevelScore()}\n" +
                                $"Сложность: {maze.GetDifficulty()}\n" +
                                $"Цвет стен: {WallColor.SelectedValue}", "Инфо");
            }
            catch
            {
                MessageBox.Show("Ошибка заполения данных", "Ошибка");
            }

        }

        private void MazeClass_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (MazeClass.SelectedIndex)
            {
                case 0:
                    MazeGrid.Visibility = Visibility.Visible;
                    ItemMazeGrid.Visibility = Visibility.Hidden;
                    MonsterMazeGrid.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    MazeGrid.Visibility = Visibility.Hidden;
                    ItemMazeGrid.Visibility = Visibility.Visible;
                    MonsterMazeGrid.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    MazeGrid.Visibility = Visibility.Hidden;
                    ItemMazeGrid.Visibility = Visibility.Hidden;
                    MonsterMazeGrid.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void Theme_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (Theme.SelectedIndex)
            {
                case 0: bg.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255)); break;
                case 1: bg.Background = new SolidColorBrush(Color.FromRgb(123, 123, 123)); break;
                case 2: bg.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0)); ; break;
            }
        }
    }
}
