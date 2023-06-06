using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using dll22;

namespace lab22_4
{
    public partial class MainWindow : Window
    {
        List<Tree> trees = new List<Tree>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddTree(object sender, RoutedEventArgs e)
        {
            Tree tree = new Tree();
            try
            {
                tree.Name = treeName.Text;
                tree.HitsToChop = Convert.ToInt32(treeChopCount.Text);
                tree.ApplesCount = Convert.ToInt32(treeApplesCount.Text);

                trees.Add(tree);
            }
            catch
            {
                info.Text = "Ошибка заполения данных";
            }
        }
        private void AddExotic(object sender, RoutedEventArgs e)
        {
            Exotic tree = new Exotic();
            try
            {
                tree.Name = exoticName.Text;
                tree.HitsToChop = Convert.ToInt32(exoticChopCount.Text);
                tree.ApplesCount = Convert.ToInt32(exoticApplesCount.Text);
                tree.Country = exoticCountry.Text;

                trees.Add(tree);
            }
            catch
            {
                info.Text = "Ошибка заполения данных";
            }
        }
        private void AddEnchanted(object sender, RoutedEventArgs e)
        {
            Enchanted tree = new Enchanted();
            try
            {
                tree.Name = enchantedName.Text;
                tree.HitsToChop = Convert.ToInt32(enchantedChopCount.Text);
                tree.ApplesCount = Convert.ToInt32(enchantedApplesCount.Text);
                tree.EnchantDays = Convert.ToInt32(enchantedDays.Text);

                trees.Add(tree);
            }
            catch
            {
                info.Text = "Ошибка заполения данных";
            }
        }

        private void HealList(object sender, RoutedEventArgs e)
        {
            foreach (Tree tree in trees)
            {
                tree.Heal();
            }
        }

        private void Data(object sender, RoutedEventArgs e)
        {
            info.Text = "";
            foreach (Tree tree in trees)
            {
                info.Text += tree.Info();
            }
        }
    }
}
