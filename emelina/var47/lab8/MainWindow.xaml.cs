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

namespace lab47_8
{
    public partial class MainWindow : Window
    {
        Recipe recipe = new Recipe();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddIngridient(object sender, RoutedEventArgs e)
        {
            try
            {
                recipe.AddIngridient(ingrName.Text, Convert.ToDouble(ingrWeight.Text));
            }
            catch
            {
                infoTB.Text = "Ошибка ввода данных";
            }
        }
        private void NewRecipe(object sender, RoutedEventArgs e)
        {
            recipe = new Recipe();
            infoTB.Text = "Создан новый рецепт";
        }
        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            infoTB.Text = recipe.GetRecipeInfo();
        }
        private void ChangeIngridient(object sender, RoutedEventArgs e)
        {
            try
            {
                recipe.ChangeIngridient(Convert.ToInt32(ingrNum.Text), Convert.ToDouble(ingrWeightToChange.Text));
            }
            catch
            {
                infoTB.Text = "Ошибка ввода данных";
            }
        }
    }
}
