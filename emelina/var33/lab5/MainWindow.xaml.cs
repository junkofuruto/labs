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
        List<Country> countries = new List<Country>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetInfo(object sender, RoutedEventArgs e)
        {
            info.Text = "";
            foreach (Country country in countries)
            {
                info.Text += $"Тип страны: {country.CountryType()}\n" + country.GetInfo();
            }
        }

        private void SaveCountry(object sender, RoutedEventArgs e)
        {
            Country country = new Country();
            country.CountryName = countryName.Text;
            country.Square = Convert.ToDouble(countrySquare.Text);
            country.Population = Convert.ToDouble(countryPopulation.Text);
            country.YearBudget = Convert.ToDouble(countryYearImpact.Text);
            countries.Add(country);
        }

        private void SaveKingdom(object sender, RoutedEventArgs e)
        {
            Monarchy country = new Monarchy();
            country.CountryName = countryName.Text;
            country.Square = Convert.ToDouble(countrySquare.Text);
            country.Population = Convert.ToDouble(countryPopulation.Text);
            country.KingName = kingName.Text;
            country.FromWharYear = Convert.ToInt32(fromWharYear.Text);
            country.YearBudget = Convert.ToDouble(kingdomYearImpact.Text);
            countries.Add(country);
        }

        private void SaveRepublic(object sender, RoutedEventArgs e)
        {
            Republic country = new Republic();
            country.CountryName = countryName.Text;
            country.Square = Convert.ToDouble(countrySquare.Text);
            country.Population = Convert.ToDouble(countryPopulation.Text);
            country.PresidentName = presidentName.Text;
            country.YearBudget = Convert.ToDouble(republicYearImpact.Text);
            countries.Add(country);
        }
    }
}
