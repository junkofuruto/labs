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

namespace lab47_4
{
    public partial class MainWindow : Window
    {
        List<Recipe> recipes = new List<Recipe>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void OutputInfo(object sender, RoutedEventArgs e)
        {
            infoTB.Text = "";

            foreach (Recipe recipe in recipes)
            {
                infoTB.Text += recipe.GetRecipeInfo();
            }
        }
        private void RecipeAdd(object sender, RoutedEventArgs e)
        {
            Recipe recipe = new Recipe();
            try
            {
                recipe.Weight[0] = Convert.ToDouble(recipeWeight1.Text);
                recipe.Weight[1] = Convert.ToDouble(recipeWeight2.Text);
                recipe.Weight[2] = Convert.ToDouble(recipeWeight3.Text);
                recipe.Names[0] = recipeName1.Text;
                recipe.Names[1] = recipeName2.Text;
                recipe.Names[2] = recipeName3.Text;
                recipe.TimeToCook = Convert.ToDouble(recipeCookTime.Text);

                recipes.Add(recipe);
            }
            catch (Exception ex)
            {
                infoTB.Text = ex.Message;
            }
        }
        private void BakeryAdd(object sender, RoutedEventArgs e)
        {
            BakeryRecipe recipe = new BakeryRecipe();
            try
            {
                recipe.Weight[0] = Convert.ToDouble(bakeryWeight1.Text);
                recipe.Weight[1] = Convert.ToDouble(bakeryWeight2.Text);
                recipe.Weight[2] = Convert.ToDouble(bakeryWeight3.Text);
                recipe.Names[0] = bakeryName1.Text;
                recipe.Names[1] = bakeryName2.Text;
                recipe.Names[2] = bakeryName3.Text;
                recipe.TempToCook = Convert.ToDouble(bakeryCookTime.Text);

                recipes.Add(recipe);
            }
            catch (Exception ex)
            {
                infoTB.Text = ex.Message;
            }
        }
        private void JamAdd(object sender, RoutedEventArgs e)
        {
            JamRecipe recipe = new JamRecipe();
            try
            {
                recipe.Weight[0] = Convert.ToDouble(jamWeight1.Text);
                recipe.Weight[1] = Convert.ToDouble(jamWeight2.Text);
                recipe.Weight[2] = Convert.ToDouble(jamWeight3.Text);
                recipe.Names[0] = jamName1.Text;
                recipe.Names[1] = jamName2.Text;
                recipe.Names[2] = jamName3.Text;
                recipe.TimeToBoil = Convert.ToDouble(jamBoilTime.Text);

                recipes.Add(recipe);
            }
            catch (Exception ex)
            {
                infoTB.Text = ex.Message;
            }
        }
    }
}
