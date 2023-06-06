using System;
using System.Windows;
using var43dll;

namespace var43
{
    public partial class MainWindow : Window
    {
        Star star = new Star();

        
        int tb1_num = 0;
        int tb2_num = 0;
        double speed = 0;
        double full_dist = 0.0f;
        string str_num;

        private void CountButtonTest()
        {
            // МЕТОД, ОБРАБАТЫВАЮЩИЙ ВКЛЮЧЕНИЕ/ВЫКЛЮЧЕНИЕ КНОПОК + И -
            // ЕСЛИ ЧИСЛО ОСТАНОВОК МЕНЬШЕ НУЛЯ, ТО УМЕНЬШЕНИЕ НЕ РАБОТАЕТ
            // ЕСЛИ ЧИСЛО ОСТАНОВОК РАВНО ЧИСЛУ НАС. ПЛАНЕТ, ТО УМЕНЬШЕНИЕ НЕ РАБОТАЕТ
            // ЕСЛИ ЧИСЛО НАС. ПЛАНЕТ РАВНО ЧИСЛУ ОСТАНОВОК, ТО УВЕЛ. НЕ РАБОТАЕТ

            min1.IsEnabled = tb1_num > 0 && (tb1_num - tb2_num != 0);
            min2.IsEnabled = tb2_num > 0;
            pl2.IsEnabled = tb2_num < tb1_num;

            
        }
        private void DistButtonTest()
        {
            
            str_num = string.Format("{0:0.00}", full_dist);                 // ПОЛУЧЕНИЕ ДРОБНОЙ ЧАСТИ РАССТОЯНИЯ В СТРИНОГОВОЙ ФОРМЕ
            tb3_1.Text = Math.Truncate(full_dist).ToString();               // ПОЛУЧЕНИЕ ЦЕЛОЙ ЧАСТИ РАССТОЯНИЯ
            tb3_2.Text = str_num.Substring(str_num.Length - 2);             // ПОЛУЧЕНИЕ 2-х ПОСЛЕДНИХ ЦИФР ДРОБНОЙ ЧАСТИ РАССТОЯНИЯ

            min3_1.IsEnabled = Math.Truncate(full_dist) > 0 & full_dist > 0;
            min3_2.IsEnabled = full_dist > 0;
        }
        private void SpeedButtonTest()
        {
            min4.IsEnabled = speed > 0;
        }

        public MainWindow()
        {
            InitializeComponent();

            CountButtonTest();
            DistButtonTest();
            SpeedButtonTest();
        }

        private void StopsCountAdd(object sender, RoutedEventArgs e)
        {
            tb1_num += 1;
            tb1.Text = Convert.ToString(tb1_num);

            CountButtonTest();
        }
        private void StopsCountMin(object sender, RoutedEventArgs e)
        {
            tb1_num -= 1;
            tb1.Text = Convert.ToString(tb1_num);

            CountButtonTest();
        }
        private void StopsCountFix(object sender, RoutedEventArgs e)
        {
            min1.IsEnabled = pl1.IsEnabled = min2.IsEnabled = pl2.IsEnabled = false;
            pos.IsEnabled = true;

            star.StopsCount = tb1_num;
            star.LifeCount = tb2_num;
        }
        private void LiveCountAdd(object sender, RoutedEventArgs e)
        {
            tb2_num += 1;
            tb2.Text = Convert.ToString(tb2_num);

            CountButtonTest();
        }
        private void LiveCountMin(object sender, RoutedEventArgs e)
        {
            tb2_num -= 1;
            tb2.Text = Convert.ToString(tb2_num);

            CountButtonTest();
        }
        private void DistFullPartAdd(object sender, RoutedEventArgs e)
        {
            full_dist += 1;

            DistButtonTest();
        }
        private void DistFullPartMin(object sender, RoutedEventArgs e)
        {
            full_dist -= 1;

            DistButtonTest();
        }
        private void DistDrPartAdd(object sender, RoutedEventArgs e)
        {
            full_dist += 0.01;

            DistButtonTest();
        }
        private void DistDrPartMin(object sender, RoutedEventArgs e)
        {
            full_dist -= 0.01;

            DistButtonTest();
        }
        private void PosButton(object sender, RoutedEventArgs e)
        {
            star.StopsDist = full_dist;

            output.Content = $"Процент обитаемых планет: {star.GetLiveProcent()}%";
            output.Content += $"\nВремя на путешествие: {star.GetTime(speed)}";
        }

        private void SpeedAdd(object sender, RoutedEventArgs e)
        {
            speed += 1;
            tb4.Text = speed.ToString();

            SpeedButtonTest();
        }

        private void SpeedMin(object sender, RoutedEventArgs e)
        {
            speed -= 1;
            tb4.Text = speed.ToString();

            SpeedButtonTest();
        }
    }
}