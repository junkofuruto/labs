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

namespace EX2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Room room = new Room(
                    Convert.ToDouble(WidthTextBox.Text),
                    Convert.ToDouble(HeigthTextBox.Text),
                    Convert.ToDouble(LengthTextBox.Text),
                    Convert.ToInt32(WindowsTextBox.Text));

                MessageBox.Show($"Площадь комнаты: {room.Area()}");
                MessageBox.Show($"Объем комнаты: {room.Volume()}");
                MessageBox.Show($"Параметры комнаты: {room.Length}x{room.Heigth}x{room.Width}\nКоличество окон: {room.WindowsCount}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
