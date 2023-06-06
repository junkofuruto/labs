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
using CastleLib;

namespace Castle
{
    public partial class MainWindow : Window
    {
        CastleClass castle1 = new CastleClass();
        CastleClass castle2 = new CastleClass();

        double castle1money = 0;
        double castle2money = 0;

        Random rnd = new Random();

        double randomGold;

        public void NextStepTest()
        {
            next_step_button.IsEnabled = !attack1.IsEnabled & !attack2.IsEnabled & castle1.CastleMoney > 0 & castle2.CastleMoney > 0;
        }

        public MainWindow()
        {
            InitializeComponent();
            NextStepTest();
        }

        private void Remember1(object sender, RoutedEventArgs e)
        {
            try
            {
                castle1.CastleName = castle_name1.Text;
                castle2.CastleName = castle_name2.Text;
                castle1.CastleMoney = Convert.ToDouble(castle_money1.Text);
                castle2.CastleMoney = Convert.ToDouble(castle_money2.Text);

                castle_name1.Visibility = Visibility.Collapsed;
                castle_name2.Visibility = Visibility.Collapsed;
                castle_money1.Visibility = Visibility.Collapsed;
                castle_money2.Visibility = Visibility.Collapsed;
                remember.Visibility = Visibility.Collapsed;

                next_step_button.Visibility = Visibility.Visible;
                castle_img1.Visibility = Visibility.Visible;
                castle_img2.Visibility = Visibility.Visible;
                attack1.Visibility = Visibility.Visible;
                attack2.Visibility = Visibility.Visible;
                log.Visibility = Visibility.Visible;
            }
            catch { }
        }

        private void NextStep(object sender, RoutedEventArgs e)
        {
            attack1.IsEnabled = true;
            attack2.IsEnabled = true;

            castle1.NextDay();
            castle2.NextDay();

            NextStepTest();

            log.Text = "";
        }

        private void Attack1(object sender, RoutedEventArgs e)
        {
            attack1.IsEnabled = false;
            randomGold = rnd.Next(0, Convert.ToInt32(castle2.CastleMoney) / 2);
            castle1money += randomGold;
            castle1.RobCastle(randomGold);
            castle2.GetRobbed(randomGold);

            log.Text += $"Замок {castle2.CastleName} ограблен на {randomGold}\n";
            log.Text += $"Деньги {castle1.CastleName}: {castle1.CastleMoney}\n\n";
            NextStepTest();
        }

        private void Attack2(object sender, RoutedEventArgs e)
        {
            attack2.IsEnabled = false;
            randomGold = rnd.Next(0, Convert.ToInt32(castle1.CastleMoney) / 2);
            castle2money += randomGold;
            castle2.RobCastle(randomGold);
            castle1.GetRobbed(randomGold);

            log.Text += $"Замок {castle1.CastleName} ограблен на {randomGold}\n";
            log.Text += $"Деньги {castle2.CastleName}: {castle2.CastleMoney}\n\n";
            NextStepTest();
        }

        private void OtchetClick(object sender, RoutedEventArgs e)
        {
            log.Text = $"{castle1.CastleName}: {castle1money}\n{castle1.CastleName}: {castle2money}";

            castle1money = 0;
            castle2money = 0;
        }
    }
}