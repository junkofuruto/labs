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

namespace lab5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Info1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Maze maze = new Maze();
                maze.BasicScore = Convert.ToUInt32(BaseScore1.Text);
                maze.LevelsCount = Convert.ToUInt32(LevelsCount1.Text);
                maze.AddedObstacles = Convert.ToUInt32(AddedObstacles1.Text);

                MessageBox.Show($"Базовый счет: {maze.BasicScore}\n" +
                                $"Кол-во уровней: {maze.LevelsCount}\n" +
                                $"Препятсвия: {maze.AddedObstacles}\n" +
                                $"Общее кол-во препятсвий: {maze.GetLevelObstacles()}\n" +
                                $"Общий счёт: {maze.GetLevelScore()}\n" +
                                $"Сложность: {maze.GetDifficulty()}\n", "Инфо");
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка");
            }
        }

        private void Info2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ItemMaze maze = new ItemMaze();
                maze.BasicScore = Convert.ToUInt32(BaseScore1.Text);
                maze.LevelsCount = Convert.ToUInt32(LevelsCount1.Text);
                maze.AddedObstacles = Convert.ToUInt32(AddedObstacles1.Text);
                maze.AddedObstacles = Convert.ToUInt32(AddedItems2.Text);

                MessageBox.Show($"Базовый счет: {maze.BasicScore}\n" +
                                $"Кол-во уровней: {maze.LevelsCount}\n" +
                                $"Препятсвия: {maze.AddedObstacles}\n" +
                                $"Общее кол-во препятсвий: {maze.GetLevelObstacles()}\n" +
                                $"Общий счёт: {maze.GetLevelScore()}\n" +
                                $"Сложность: {maze.GetDifficulty()}\n", "Инфо");
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка");
            }
        }

        private void Info3_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MonsterMaze maze = new MonsterMaze();
                maze.BasicScore = Convert.ToUInt32(BaseScore1.Text);
                maze.LevelsCount = Convert.ToUInt32(LevelsCount1.Text);
                maze.AddedObstacles = Convert.ToUInt32(AddedObstacles1.Text);
                maze.AddedMonsters = Convert.ToUInt32(AddedMonsters3.Text);

                MessageBox.Show($"Базовый счет: {maze.BasicScore}\n" +
                                $"Кол-во уровней: {maze.LevelsCount}\n" +
                                $"Препятсвия: {maze.AddedObstacles}\n" +
                                $"Общее кол-во препятсвий: {maze.GetLevelObstacles()}\n" +
                                $"Общий счёт: {maze.GetLevelScore()}\n" +
                                $"Сложность: {maze.GetDifficulty()}\n", "Инфо");
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка");
            }
        }
    }
}
