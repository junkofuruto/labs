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

namespace lab47_5
{
    public partial class MainWindow : Window
    {
        Recipe recipe;
        JamRecipe jamRecipe;
        BakeryRecipe bakeryRecipe;


        public MainWindow()
        {
            InitializeComponent();
        }

        private void MakeDesigion(object sender, RoutedEventArgs e)
        {
            recipe = new Recipe();
            jamRecipe = new JamRecipe();
            bakeryRecipe = new BakeryRecipe();

            try
            {
                recipe.Weight[0] = Convert.ToDouble(recipeWeight1.Text);
                recipe.Weight[1] = Convert.ToDouble(recipeWeight2.Text);
                recipe.Weight[2] = Convert.ToDouble(recipeWeight3.Text);
                recipe.Names[0] = recipeName1.Text;
                recipe.Names[1] = recipeName2.Text;
                recipe.Names[2] = recipeName3.Text;
                recipe.TimeToCook = Convert.ToDouble(recipeCookTime.Text);

                bakeryRecipe.Weight[0] = Convert.ToDouble(bakeryWeight1.Text);
                bakeryRecipe.Weight[1] = Convert.ToDouble(bakeryWeight2.Text);
                bakeryRecipe.Weight[2] = Convert.ToDouble(bakeryWeight3.Text);
                bakeryRecipe.Names[0] = bakeryName1.Text;
                bakeryRecipe.Names[1] = bakeryName2.Text;
                bakeryRecipe.Names[2] = bakeryName3.Text;
                bakeryRecipe.TempToCook = Convert.ToDouble(bakeryCookTime.Text);

                jamRecipe.Weight[0] = Convert.ToDouble(jamWeight1.Text);
                jamRecipe.Weight[1] = Convert.ToDouble(jamWeight2.Text);
                jamRecipe.Weight[2] = Convert.ToDouble(jamWeight3.Text);
                jamRecipe.Names[0] = jamName1.Text;
                jamRecipe.Names[1] = jamName2.Text;
                jamRecipe.Names[2] = jamName3.Text;
                jamRecipe.TimeToBoil = Convert.ToDouble(jamBoilTime.Text);

                double[] fullWeight = new double[3] { bakeryRecipe.FullWeigth(), recipe.FullWeigth(), jamRecipe.FullWeigth() };
                MessageBox.Show($"{recipe.GetRecipeInfo()}{bakeryRecipe.GetRecipeInfo()}{jamRecipe.GetRecipeInfo()}" + $"Самый большой вес блюда: {fullWeight.Max()}", ":C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ОШИБКА");
            }
        }
    }
}
