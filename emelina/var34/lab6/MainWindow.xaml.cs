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
using CityLib;

namespace City6
{
    public partial class MainWindow : Window
    {
        byte level = 0;
        City city1 = new City();
        Capital city2 = new Capital();
        Underground city3 = new Underground();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ThemeChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (themeCB.SelectedIndex)
            {
                case 0: bg.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255)); break;
                case 1: bg.Background = new SolidColorBrush(Color.FromRgb(123, 123, 123)); break;
                case 2: bg.Background = new SolidColorBrush(Color.FromRgb(0, 255, 0)); break;
            }
        }
        private void TypeChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (typeCB.SelectedIndex)
            {
                case 0:
                    capitalMainSquare.Visibility = Visibility.Hidden;
                    mainSquareLabel.Visibility = Visibility.Hidden;
                    levelCountLabel.Visibility = Visibility.Hidden;
                    undergroundLevelsCountTB.Visibility = Visibility.Hidden;
                    undergroundLevelsCountAddButton.Visibility = Visibility.Hidden;
                    undergroundLevelsCountMinButton.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    capitalMainSquare.Visibility = Visibility.Visible;
                    mainSquareLabel.Visibility = Visibility.Visible;
                    levelCountLabel.Visibility = Visibility.Hidden;
                    undergroundLevelsCountTB.Visibility = Visibility.Hidden;
                    undergroundLevelsCountAddButton.Visibility = Visibility.Hidden;
                    undergroundLevelsCountMinButton.Visibility = Visibility.Hidden; 
                    break;
                case 2:
                    capitalMainSquare.Visibility = Visibility.Hidden;
                    mainSquareLabel.Visibility = Visibility.Hidden;
                    levelCountLabel.Visibility = Visibility.Visible;
                    undergroundLevelsCountTB.Visibility = Visibility.Visible;
                    undergroundLevelsCountAddButton.Visibility = Visibility.Visible;
                    undergroundLevelsCountMinButton.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void AddLevelsCount(object sender, RoutedEventArgs e)
        {
            level += 1;
            undergroundLevelsCountTB.Text = level.ToString();
        }
        private void MinLevelsCount(object sender, RoutedEventArgs e)
        {
            level -= 1;
            undergroundLevelsCountTB.Text = level.ToString();
        }
        private void GetData(object sender, RoutedEventArgs e)
        {
            switch (typeCB.SelectedIndex)
            {
                case 0:
                    city1.CityName = cityNameTB.Text;
                    city1.Square = Convert.ToDouble(citySquareTB.Text);
                    city1.LivingCost = Convert.ToDouble(cityLivingCostTB.Text);
                    city1.Population = Convert.ToInt32(cityPopulationTB.Text);
                    city1.AttrCount = Convert.ToInt32(cityAttrCountTB.Text);

                    MessageBox.Show(city1.GetInfo(), "CITY INFO");
                    break;

                case 1:
                    city2.CityName = cityNameTB.Text;
                    city2.Square = Convert.ToDouble(citySquareTB.Text);
                    city2.LivingCost = Convert.ToDouble(cityLivingCostTB.Text);
                    city2.Population = Convert.ToInt32(cityPopulationTB.Text);
                    city2.AttrCount = Convert.ToInt32(cityAttrCountTB.Text);
                    city2.MainSquare = capitalMainSquare.Text;

                    MessageBox.Show(city2.GetInfo(), "CAPITAL INFO");
                    break;

                case 2:
                    city3.CityName = cityNameTB.Text;
                    city3.Square = Convert.ToDouble(citySquareTB.Text);
                    city3.LivingCost = Convert.ToDouble(cityLivingCostTB.Text);
                    city3.Population = Convert.ToInt32(cityPopulationTB.Text);
                    city3.AttrCount = Convert.ToInt32(cityAttrCountTB.Text);
                    city3.LevelsCount = level;

                    MessageBox.Show(city3.GetInfo(), "UNDERGROUND CITY INFO");
                    break;
            }
        }
    }
}
