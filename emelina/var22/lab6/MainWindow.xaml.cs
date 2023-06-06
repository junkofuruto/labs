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

namespace lab22_6
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void treeTypeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (treeTypeCB.SelectedIndex)
            {
                case 0:
                    treeForm.Visibility = Visibility.Visible;
                    exoticForm.Visibility = Visibility.Hidden;
                    enchForm.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    treeForm.Visibility = Visibility.Hidden;
                    exoticForm.Visibility = Visibility.Visible;
                    enchForm.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    treeForm.Visibility = Visibility.Hidden;
                    exoticForm.Visibility = Visibility.Hidden;
                    enchForm.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void themeCB_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (themeCB.SelectedIndex)
            {
                case 0: window.Background = new SolidColorBrush(Color.FromRgb(200, 0, 0)); break;
                case 1: window.Background = new SolidColorBrush(Color.FromRgb(0, 200, 0)); break;
                case 2: window.Background = new SolidColorBrush(Color.FromRgb(0, 0, 200)); break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (treeTypeCB.SelectedIndex)
            {
                case 0:
                    try
                    {
                        Tree tree = new Tree();

                        tree.Name = treeName.Text;
                        tree.HitsToChop = Convert.ToInt32(treeChopCount.Text);
                        tree.ApplesCount = Convert.ToInt32(treeApplesCount.Text);

                        MessageBox.Show($"Вид дерева: {treeNameCB.Text}\n{tree.Info()}", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка ввода данных", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 1:
                    try
                    {
                        Exotic tree = new Exotic();

                        tree.Name = exoticName.Text;
                        tree.Country = exoticCountry.Text;
                        tree.HitsToChop = Convert.ToInt32(exoticChopCount.Text);
                        tree.ApplesCount = Convert.ToInt32(exoticApplesCount.Text);

                        MessageBox.Show($"Вид дерева: {treeNameCB.Text}\n{tree.Info()}", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка ввода данных", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
                case 2:
                    try
                    {
                        Enchanted tree = new Enchanted();

                        tree.Name = enchantedName.Text;
                        tree.HitsToChop = Convert.ToInt32(enchantedChopCount.Text);
                        tree.ApplesCount = Convert.ToInt32(enchantedApplesCount.Text);
                        tree.EnchantDays = Convert.ToInt32(enchantedDays.Text);

                        MessageBox.Show($"Вид дерева: {treeNameCB.Text}\n{tree.Info()}", "INFO", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка ввода данных", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    break;
            }
        }
    }
}
