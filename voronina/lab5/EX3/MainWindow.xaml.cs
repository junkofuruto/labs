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

namespace EX3
{
    public partial class MainWindow : Window
    {
        private Time _time;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveTime(object sender, RoutedEventArgs e)
        {
            try
            {
                int[] timeData = TimeTextBox.Text.Split(':').Select(x => Convert.ToInt32(x)).ToArray();
                _time = new Time(timeData[0], timeData[1], timeData[2]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AddTime(object sender, RoutedEventArgs e)
        {
            try
            {
                _time.Change(
                    Convert.ToInt32(ChangeHourTextBox.Text),
                    Convert.ToInt32(ChangeMinuteTextBox.Text),
                    Convert.ToInt32(ChangeSecondTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            TimeTextBox.Text = $"{_time.Hour}:{_time.Minute}:{_time.Second}";
        }
    }
}
