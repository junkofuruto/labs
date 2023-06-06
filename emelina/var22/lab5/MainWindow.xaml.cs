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
using dll22;

namespace lab22_5
{
    public partial class MainWindow : Window
    {
        Tree tree = new Tree();
        Exotic exotic = new Exotic();
        Enchanted enchanted = new Enchanted();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveTree(object sender, RoutedEventArgs e)
        {
            try
            {
                tree.Name = treeName.Text;
                tree.HitsToChop = Convert.ToInt32(treeChopCount.Text);
                tree.ApplesCount = Convert.ToInt32(treeApplesCount.Text);
                chopTreeButton.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveExotic(object sender, RoutedEventArgs e)
        {
            try
            {
                exotic.Name = exoticName.Text;
                exotic.HitsToChop = Convert.ToInt32(exoticChopCount.Text);
                exotic.ApplesCount = Convert.ToInt32(exoticApplesCount.Text);
                exotic.Country = exoticCountry.Text;
                chopExoticButton.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void SaveEnch(object sender, RoutedEventArgs e)
        {
            try
            {
                enchanted.Name = enchantedName.Text;
                enchanted.HitsToChop = Convert.ToInt32(enchantedChopCount.Text);
                enchanted.ApplesCount = Convert.ToInt32(enchantedApplesCount.Text);
                enchanted.EnchantDays = Convert.ToInt32(enchantedDays.Text);
                chopEnchButton.IsEnabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ChopTree(object sender, RoutedEventArgs e)
        {
            if (!tree.Chop())
            {
                MessageBox.Show($"{tree.Info()}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ChopExotic(object sender, RoutedEventArgs e)
        {
            if (!exotic.Chop())
            {
                MessageBox.Show($"{tree.Info()}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void ChopEnch(object sender, RoutedEventArgs e)
        {
            if (!enchanted.Chop())
            {
                MessageBox.Show($"{tree.Info()}", "Информация", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
    }
}
