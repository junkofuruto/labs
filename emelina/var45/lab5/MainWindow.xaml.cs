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
using lib;

namespace lab4
{
    public partial class MainWindow : Window
    {
        List<NormalGame> games = new List<NormalGame>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddGame(object sender, RoutedEventArgs e)
        {
            NormalGame game = new NormalGame();
            try
            {
                game.LettersCount = Convert.ToUInt32(gameLettersCount.Text);
                game.LettersGuessed = Convert.ToUInt32(gameLettersGuessed.Text);
                game.TotalMistakes = Convert.ToUInt32(gameTotalMistakes.Text);
                game.TakenMistakes = Convert.ToUInt32(gameTakenMistakes.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddHard(object sender, RoutedEventArgs e)
        {
            HardGame game = new HardGame();
            try
            {
                game.LettersCount = Convert.ToUInt32(hardLettersCount.Text);
                game.LettersGuessed = Convert.ToUInt32(hardLettersGuessed.Text);
                game.TotalMistakes = Convert.ToUInt32(hardTotalMistakes.Text);
                game.TakenMistakes = Convert.ToUInt32(hardTakenMistakes.Text);
                game.IsSkiped = hardIsSkiped.IsEnabled;
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddEasy(object sender, RoutedEventArgs e)
        {
            EasyGame game = new EasyGame();
            try
            {
                game.LettersCount = Convert.ToUInt32(easyLettersCount.Text);
                game.LettersGuessed = Convert.ToUInt32(easyLettersGuessed.Text);
                game.TotalMistakes = Convert.ToUInt32(easyTotalMistakes.Text);
                game.TakenMistakes = Convert.ToUInt32(easyTakenMistakes.Text);
                game.AttempCount = Convert.ToUInt32(easyAttackCount.Text);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void GetInfo(object sender, RoutedEventArgs e)
        {
            Info.Text = "";
            foreach (NormalGame game in games)
            {
                Info.Text += game.Inf() + "\n";
            }
        }
    }
}
