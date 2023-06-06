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

namespace lab6
{
    public partial class MainWindow : Window
    {
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
                case 2: bg.Background = new SolidColorBrush(Color.FromRgb(100, 0, 0)); break;
            }
        }

        private void TypeChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (countryCB.SelectedIndex)
            {
                case 0: 
                    country.Visibility = Visibility.Visible;
                    kingdom.Visibility = Visibility.Hidden;
                    republic.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    country.Visibility = Visibility.Hidden;
                    kingdom.Visibility = Visibility.Visible;
                    republic.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    country.Visibility = Visibility.Hidden;
                    kingdom.Visibility = Visibility.Hidden;
                    republic.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void GetInfo(object sender, RoutedEventArgs e)
        {
            switch (countryCB.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Country country = new Country();
                        country.CountryName = countryName.Text;
                        country.Square = Convert.ToDouble(countrySquare.Text);
                        country.Population = Convert.ToDouble(countryPopulation.Text);
                        country.YearBudget = Convert.ToDouble(countryYearImpact.Text);
                        country.Relief = reliefCB.Text;

                        MessageBox.Show($"Тип: {country.GetInfo()}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка заполнения данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 1:
                    try
                    {
                        Monarchy country = new Monarchy();
                        country.CountryName = countryName.Text;
                        country.KingName = kingName.Text;
                        country.FromWharYear = Convert.ToInt32(fromWharYear.Text);
                        country.Square = Convert.ToDouble(countrySquare.Text);
                        country.Population = Convert.ToDouble(countryPopulation.Text);
                        country.YearBudget = Convert.ToDouble(countryYearImpact.Text);
                        country.Relief = reliefCB.Text;

                        MessageBox.Show($"Тип: {country.GetInfo()}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка заполнения данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 2:
                    try
                    {
                        Republic country = new Republic();
                        country.CountryName = countryName.Text;
                        country.PresidentName = presidentName.Text;
                        country.Square = Convert.ToDouble(countrySquare.Text);
                        country.Population = Convert.ToDouble(countryPopulation.Text);
                        country.YearBudget = Convert.ToDouble(countryYearImpact.Text);
                        country.Relief = reliefCB.Text;

                        MessageBox.Show($"Тип: {country.GetInfo()}", "Info", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка заполнения данных", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
            }
        }
    }
}
