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
using lab47dll;

namespace lab47_6
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
                case 0: background.Background = new SolidColorBrush(Color.FromRgb(50, 100, 50)); break;
                case 1: background.Background = new SolidColorBrush(Color.FromRgb(100, 50, 50)); break;
                case 2: background.Background = new SolidColorBrush(Color.FromRgb(50, 50, 100)); break;
            }
        }

        private void RecipeInfo(object sender, RoutedEventArgs e)
        {
            Recipe recipe = new Recipe();
            recipe.Weight[0] = Convert.ToDouble(recipeWeight1.Text);
            recipe.Weight[1] = Convert.ToDouble(recipeWeight2.Text);
            recipe.Weight[2] = Convert.ToDouble(recipeWeight3.Text);
            recipe.Names[0] = recipeName1.Text;
            recipe.Names[1] = recipeName2.Text;
            recipe.Names[2] = recipeName3.Text;
            recipe.KitchenType = impCB.Text;
            recipe.TimeToCook = Convert.ToDouble(recipeCookTime.Text);
            MessageBox.Show($"{recipe.KitchenType}\n" + recipe.GetRecipeInfo(), "Информация");
        }

        private void BakeryInfo(object sender, RoutedEventArgs e)
        {
            BakeryRecipe recipe = new BakeryRecipe();
            recipe.Weight[0] = Convert.ToDouble(bakeryWeight1.Text);
            recipe.Weight[1] = Convert.ToDouble(bakeryWeight2.Text);
            recipe.Weight[2] = Convert.ToDouble(bakeryWeight3.Text);
            recipe.KitchenType = impCB.Text;
            recipe.TempToCook = Convert.ToDouble(bakeryCookTime.Text);
            MessageBox.Show($"{recipe.KitchenType}\n" + recipe.GetRecipeInfo(), "Информация");
        }

        private void JamInfo(object sender, RoutedEventArgs e)
        {
            JamRecipe recipe = new JamRecipe();
            recipe.Weight[0] = Convert.ToDouble(jamWeight1.Text);
            recipe.Weight[1] = Convert.ToDouble(jamWeight2.Text);
            recipe.Weight[2] = Convert.ToDouble(jamWeight3.Text);
            recipe.KitchenType = impCB.Text;
            recipe.TimeToBoil = Convert.ToDouble(jamBoilTime.Text);
            MessageBox.Show($"{recipe.KitchenType}\n" + recipe.GetRecipeInfo(), "Информация");
        }
    }
}
