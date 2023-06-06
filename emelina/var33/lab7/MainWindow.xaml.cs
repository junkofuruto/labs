﻿using System;
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
                info.Text += country.GetInfo();
            }
        }

        private void SaveCountry(object sender, RoutedEventArgs e)
        {
            try
            {
                Country country = new Country();
                country.CountryName = countryName.Text;
                country.Square = Convert.ToDouble(countrySquare.Text);
                country.Population = Convert.ToDouble(countryPopulation.Text);
                countries.Add(country);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void SaveKingdom(object sender, RoutedEventArgs e)
        {
            try
            {
                Monarchy country = new Monarchy();
                country.CountryName = countryName.Text;
                country.Square = Convert.ToDouble(countrySquare.Text);
                country.Population = Convert.ToDouble(countryPopulation.Text);
                country.KingName = kingName.Text;
                country.FromWharYear = Convert.ToInt32(fromWharYear.Text);
                countries.Add(country);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        private void SaveRepublic(object sender, RoutedEventArgs e)
        {
            try
            {
                Republic country = new Republic();
                country.CountryName = countryName.Text;
                country.Square = Convert.ToDouble(countrySquare.Text);
                country.Population = Convert.ToDouble(countryPopulation.Text);
                country.PresidentName = presidentName.Text;
                countries.Add(country);
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }
    }
}
