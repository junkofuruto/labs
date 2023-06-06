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

namespace City5
{
    public partial class MainWindow : Window
    {
        List<City> cities = new List<City>();

        byte level = 0;

        public MainWindow()
        {
            InitializeComponent();
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

        private void AddCityToList(object sender, RoutedEventArgs e)
        {
            try
            {
                City city = new City();

                city.CityName = cityNameTB.Text;
                city.Square = Convert.ToDouble(citySquareTB.Text);
                city.LivingCost = Convert.ToDouble(cityLivingCostTB.Text);
                city.Population = Convert.ToInt32(cityPopulationTB.Text);
                city.AttrCount = Convert.ToInt32(cityAttrCountTB.Text);

                cities.Add(city);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddCapitalToList(object sender, RoutedEventArgs e)
        {
            try
            {
                Capital capital = new Capital();

                capital.CityName = cityNameTB.Text;
                capital.Square = Convert.ToDouble(citySquareTB.Text);
                capital.LivingCost = Convert.ToDouble(cityLivingCostTB.Text);
                capital.Population = Convert.ToInt32(cityPopulationTB.Text);
                capital.AttrCount = Convert.ToInt32(cityAttrCountTB.Text);
                capital.MainSquare = capitalMainSquare.Text;

                cities.Add(capital);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddUndergroundToList(object sender, RoutedEventArgs e)
        {
            try
            {
                Underground underground = new Underground();

                underground.CityName = cityNameTB.Text;
                underground.Square = Convert.ToDouble(citySquareTB.Text);
                underground.LivingCost = Convert.ToDouble(cityLivingCostTB.Text);
                underground.Population = Convert.ToInt32(cityPopulationTB.Text);
                underground.AttrCount = Convert.ToInt32(cityAttrCountTB.Text);
                underground.LevelsCount = level;

                cities.Add(underground);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            string info = "";

            foreach (City city in cities)
            {
                info += city.GetInfo() + "------------------------------------------\n";
            }

            MessageBox.Show(info, "ИНФОРМАЦИЯ");
        }
    }
}
