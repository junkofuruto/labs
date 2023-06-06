using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;

namespace EX1
{
    public partial class MainWindow : Window
    {
        private string _fileData;

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
            // то данные считываются в `_fileData` и кнопка вывода активируется
            // в обратном случае ничего не происходит

            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                PathTextBox.Text = openFileDialog.FileName;
                PrintDataButton.IsEnabled = true;

                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    _fileData = sr.ReadToEnd();
                }
            }
        }

        /// <summary>
        /// Функция действия нажатия на кнопку вывода данных
        /// </summary>
        private void PrintDataAction(object sender, RoutedEventArgs e)
        {
            // Инициализируем переменные, которые будут хранить вывод,
            // далее циклом проходимся по считанным данным и выводим их текстбоксом

            StringBuilder sb = new StringBuilder();
            int[] data = _fileData.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();

            foreach (var num in data)
            {
                if (num > 0)
                {
                    sb.Append($"{num}; ");
                }
            }

            MessageBox.Show(sb.ToString(), "", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
