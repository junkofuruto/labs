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

namespace lab1
{
    public partial class MainWindow : Window
    {
        Dish dish = new Dish();

        double TotalMoney = 0;
        double Workout;
        double Weight;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataClick(object sender, RoutedEventArgs e)
        {
            try
            {
                dish.DishName = dishNameTB.Text;
                dish.DishWeight = Convert.ToDouble(dishWeightTB.Text);
                dish.DishCalory = Convert.ToDouble(dishCaloryTB.Text);
                dish.DishPrice = Convert.ToDouble(dishPriceTB.Text);
                Workout = Convert.ToDouble(workoutTB.Text);

                workoutButton.IsEnabled = true;
                eatButton.IsEnabled = true;
                totalMoneyButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void WorkoutClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Weight = Convert.ToDouble(humanWeightTB.Text);

                Weight -= Workout;

                humanWeightTB.Text = Weight.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void EatClick(object sender, RoutedEventArgs e)
        {
            try
            {
                Weight = Convert.ToDouble(humanWeightTB.Text);

                Weight += dish.ReturnedWeight(dish.DishWeight);
                TotalMoney += dish.DishPrice;

                humanWeightTB.Text = Weight.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка заполнения данных", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MoneyClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(TotalMoney.ToString(), "Ошибка заполнения данных", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
