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
using lab37dll;

namespace lab37
{
    public partial class MainWindow : Window
    {
        Alien alien1 = new Alien();
        Alien alien2 = new Alien();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Alien1DataClick(object sender, RoutedEventArgs e)
        {
            try
            {
                alien1.AlienName = Alien1Name.Text;
                alien1.AlienPlanet = Alien1Planet.Text;
                alien1.AlienMaxLength = Convert.ToDouble(MaxHeight1.Text);
                alien1.AlienMinLength = Convert.ToDouble(MinHeight1.Text);

                alien1.ChangeLenght(Convert.ToInt32(MinOtkl1.Text), Convert.ToInt32(MaxOtkl1.Text));
            }
            catch
            {

            }
        }

        private void Alien2DataClick(object sender, RoutedEventArgs e)
        {
            try
            {
                alien2.AlienName = Alien2Name.Text;
                alien2.AlienPlanet = Alien2Planet.Text;
                alien2.AlienMaxLength = Convert.ToDouble(MaxHeight2.Text);
                alien2.AlienMinLength = Convert.ToDouble(MinHeight2.Text);

                alien2.ChangeLenght(Convert.ToInt32(MinOtkl2.Text), Convert.ToInt32(MaxOtkl2.Text));
            }
            catch
            {

            }
        }

        private void OtklClick(object sender, RoutedEventArgs e)
        {
            infoTB.Text = "";
            infoTB.Text += alien1.AvgLengthDev().ToString() + "\n";
            infoTB.Text += alien2.AvgLengthDev().ToString() + "\n";
        }
    }
}
