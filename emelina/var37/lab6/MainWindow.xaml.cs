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

namespace lab37_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void themeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (themeCB.SelectedIndex)
            {
                case 0: bg.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255)); break;
                case 1: bg.Background = new SolidColorBrush(Color.FromRgb(143, 143, 143)); break;
                case 2: bg.Background = new SolidColorBrush(Color.FromRgb(0, 181, 42)); break;
            }
        }

        private void typeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (classCB.SelectedIndex)
            {
                case 0:
                    alienForm.Visibility = Visibility.Visible;
                    humanoidForm.Visibility = Visibility.Hidden;
                    reptiloidForm.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    alienForm.Visibility = Visibility.Hidden;
                    humanoidForm.Visibility = Visibility.Visible;
                    reptiloidForm.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    alienForm.Visibility = Visibility.Hidden;
                    humanoidForm.Visibility = Visibility.Hidden;
                    reptiloidForm.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void AlienInfo(object sender, RoutedEventArgs e)
        {
            try
            {
                Alien alien = new Alien();
                alien.Name = alienName.Text;
                alien.Planet = alienPlanet.Text;
                alien.MinHeight = Convert.ToDouble(alienMinHeight.Text);
                alien.MaxHeight = Convert.ToDouble(alienMaxHeight.Text);
                alien.NowHeight = Convert.ToDouble(alienNowHeight.Text);

                MessageBox.Show(alien.Info(), "Инфа");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void HumanoidInfo(object sender, RoutedEventArgs e)
        {
            try
            {
                Humanoid alien = new Humanoid();
                alien.Name = humanoidName.Text;
                alien.Planet = humanoidPlanet.Text;
                alien.MinHeight = Convert.ToDouble(humanoidMinHeight.Text);
                alien.MaxHeight = Convert.ToDouble(humanoidMaxHeight.Text);
                alien.NowHeight = Convert.ToDouble(humanoidNowHeight.Text);
                alien.Weight = Convert.ToDouble(humanoidWeight.Text);

                MessageBox.Show(alien.Info(), "Инфа");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ReptiloidInfo(object sender, RoutedEventArgs e)
        {
            try
            {
                Reptiloid alien = new Reptiloid();
                alien.Name = reptiloidName.Text;
                alien.Planet = reptiloidPlanet.Text;
                alien.MinHeight = Convert.ToDouble(reptiloidMinHeight.Text);
                alien.MaxHeight = Convert.ToDouble(reptiloidMaxHeight.Text);
                alien.NowHeight = Convert.ToDouble(reptiloidNowHeight.Text);
                alien.TailCount = Convert.ToInt32(reptiloidTailCount.Text);

                MessageBox.Show(alien.Info(), "Инфа");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
