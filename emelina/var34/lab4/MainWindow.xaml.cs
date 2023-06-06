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

namespace City4
{
    
    public partial class MainWindow : Window
    {
        List<City> cities = new List<City>();
        int undergroundLevel = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UndergroundAddLevel(object sender, RoutedEventArgs e)
        {
            undergroundLevel += 1;
        }

        private void CityAdd(object sender, RoutedEventArgs e)
        {
            City city = new City();

            try
            {
                city.CityName = CityName.Text;
                city.Square = Convert.ToDouble(CitySquare.Text);
                city.LivingCost = Convert.ToDouble(CityLivingCost.Text);
                city.Population = Convert.ToInt32(CityPopulation.Text);
                city.AttrCount = Convert.ToInt32(CityAttrCount.Text);

                cities.Add(city);
            }
            catch
            {
                infoTB.Text = "Ошибка при заполнении данных обычного города";
            }
        }

        private void CapitalAdd(object sender, RoutedEventArgs e)
        {
            Capital capital = new Capital();

            try
            {
                capital.CityName = CapitalName.Text;
                capital.Square = Convert.ToDouble(CapitalSquare.Text);
                capital.LivingCost = Convert.ToDouble(CapitalLivingCost.Text);
                capital.Population = Convert.ToInt32(CapitalPopulation.Text);
                capital.AttrCount = Convert.ToInt32(CapitalAttrCount.Text);
                capital.MainSquare = CapitalMainSquare.Text;

                cities.Add(capital);
            }
            catch
            {
                infoTB.Text = "Ошибка при заполнении данных столицы";
            }
        }

        private void UndergroundAdd(object sender, RoutedEventArgs e)
        {
            Underground undergnd = new Underground();

            try
            {
                undergnd.CityName = UndergroundName.Text;
                undergnd.Square = Convert.ToDouble(UndergroundSquare.Text);
                undergnd.LivingCost = Convert.ToDouble(UndergroundLivingCost.Text);
                undergnd.Population = Convert.ToInt32(UndergroundPopulation.Text);
                undergnd.AttrCount = Convert.ToInt32(UndergroundAttrCount.Text);
                undergnd.LevelsCount = undergroundLevel;

                cities.Add(undergnd);
            }
            catch
            {
                infoTB.Text = "Ошибка при заполнении данных подземного города";
            }

            undergroundLevel = 0;
        }

        private void InfoGen(object sender, RoutedEventArgs e)
        {
            string generatedInfo = "";

            foreach (City city in cities)
            {
                generatedInfo += city.GetInfo() + "\n--------------------------------------------------\n";
            }

            infoTB.Text = generatedInfo;
        }
    }
}
