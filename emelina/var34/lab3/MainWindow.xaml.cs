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

// -------------------------------------//
//                                      //
//          Чулюканова Ангелина         //
//                20ИС2-1               //
//                                      //
// -------------------------------------//

namespace CityApp
{
    
    public partial class MainWindow : Window
    {
        City city = new City();

        protected double NowMoney;
        protected double SttMoney;
        protected double StatMoney;
        protected int attrPerDay;

        public MainWindow()
        {
            InitializeComponent();

            visitButton.IsEnabled = false;
            statButton.IsEnabled = false;
        }

        private void CityButton(object sender, RoutedEventArgs e)
        {
            // ПРОВЕРКА ВВЕДЁННЫХ ДАННЫХ 
            try
            {
                city.CityName = cityNameTB.Text;
                city.Population = Convert.ToInt32(populationTB.Text);
                city.Square = Convert.ToDouble(squareTB.Text);
                city.AttrCount = Convert.ToInt32(attrCountTB.Text);
                city.LivingCost = Convert.ToDouble(livingCountTB.Text);
                NowMoney = Convert.ToDouble(travellerMoney.Text);
                attrPerDay = Convert.ToInt32(travellerAttrPerDay.Text);
                

                SttMoney = (Convert.ToDouble(Convert.ToBoolean(city.AttrCount - attrPerDay)) * city.LivingCost) + (city.VisitLenght(attrPerDay) * city.LivingCost);
                statButton.IsEnabled = true;
                visitButton.IsEnabled = (NowMoney - SttMoney + 1) > 0;
                infoLabel.Content = "";
            }
            catch
            {
                visitButton.IsEnabled = false;
                statButton.IsEnabled = false;
                infoLabel.Content = "Ошибка при вводе данных города, попробуйте ещё раз.";
            }
        }


        private void VisitButton(object sender, RoutedEventArgs e)
        {
            try
            {
                SttMoney = (Convert.ToDouble(Convert.ToBoolean(city.AttrCount - attrPerDay)) * city.LivingCost) + (city.VisitLenght(attrPerDay) * city.LivingCost);
                
                NowMoney -= SttMoney;
                StatMoney += SttMoney;
                visitButton.IsEnabled = (NowMoney - SttMoney + 1) >= 0;
                travellerMoney.Text = NowMoney.ToString();
            }
            catch
            {
                infoLabel.Content = "Ошибка при вводе данных города, попробуйте ещё раз.";
            }
        }

        private void StatButton(object sender, RoutedEventArgs e)
        {
            infoLabel.Content = StatMoney + "\n";
        }
    }
}
