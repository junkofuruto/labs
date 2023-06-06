using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace EX5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция действия нажатия на кнопку выбора файла
        /// </summary>
        private void SelectFileAction(object sender, RoutedEventArgs e)
        {
            // Создаем объект окна выбора текстового файла, если файл выбран
            // то данные считываются, сплитятся, циклом прогонятся и подсчитывается
            // количество символов в каждой строке, в противном случае ничего не просходит

            StringBuilder sb = new StringBuilder();

            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string[] lines = sr.ReadToEnd().Split('\n');

                    foreach (var line in lines)
                    {
                        sb.Append($"[{line.Length.ToString().PadLeft(3, '0')}] {line}");
                    }
                }

                TextLinesTextBox.Text = sb.ToString();
            }
        }
    }
}
