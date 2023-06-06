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

namespace lab47
{
    public partial class MainWindow : Window
    {
        Recipe recipe = new Recipe();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetData(object sender, RoutedEventArgs e)
        {
            try
            {
                recipe.Weight[0] = Convert.ToDouble(setWeightTB1.Text);
                recipe.Weight[1] = Convert.ToDouble(setWeightTB2.Text);
                recipe.Weight[2] = Convert.ToDouble(setWeightTB3.Text);

                firstB.IsEnabled = true;
                secondB.IsEnabled = true;
                thirdB.IsEnabled = true;
                fullWeghtButton.IsEnabled = true;

                infoLabel.Text = "Данные успешно присвоены";
            }
            catch
            {
                infoLabel.Text = "Ошибка заполнения данных";
            }
        }

        private void ChangeFirst(object sender, RoutedEventArgs e)
        {
            try
            {
                recipe.ChangeWeight1(Convert.ToDouble(ingrDataTB.Text));

                infoLabel.Text = $"УСТ. ВЕС ПЕРВОГО: {Math.Round(recipe.Weight[0], 2)}\nУСТ. ВЕС ВТОРОГО: {Math.Round(recipe.Weight[1], 2)}\nУСТ. ВЕС ТРЕТЬЕГО: {Math.Round(recipe.Weight[2], 2)}\n";
            }
            catch
            {
                infoLabel.Text = "Ошибка заполнения данных";
            }
        }
        private void ChangeSecond(object sender, RoutedEventArgs e)
        {
            try
            {
                recipe.ChangeWeight2(Convert.ToDouble(ingrDataTB.Text));

                infoLabel.Text = $"УСТ. ВЕС ПЕРВОГО: {Math.Round(recipe.Weight[0], 2)}\nУСТ. ВЕС ВТОРОГО: {Math.Round(recipe.Weight[1], 2)}\nУСТ. ВЕС ТРЕТЬЕГО: {Math.Round(recipe.Weight[2], 2)}\n";
            }
            catch
            {
                infoLabel.Text = "Ошибка заполнения данных";
            }
        }
        private void ChangeThird(object sender, RoutedEventArgs e)
        {
            try
            {
                recipe.ChangeWeight3(Convert.ToDouble(ingrDataTB.Text));

                infoLabel.Text = $"УСТ. ВЕС ПЕРВОГО: {Math.Round(recipe.Weight[0], 2)}\nУСТ. ВЕС ВТОРОГО: {Math.Round(recipe.Weight[1], 2)}\nУСТ. ВЕС ТРЕТЬЕГО: {Math.Round(recipe.Weight[2], 2)}\n";
            }
            catch
            {
                infoLabel.Text = "Ошибка заполнения данных";
            }
        }

        private void FullWeight(object sender, RoutedEventArgs e)
        {
            infoLabel.Text = recipe.FullWeigth().ToString();
        }
    }
}
