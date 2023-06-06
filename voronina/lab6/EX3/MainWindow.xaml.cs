using Microsoft.Win32;
using System;
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

namespace EX3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод нажатия на кнопку генерации случайных чисел
        /// </summary>
        private void GenerateRandomNumbersAction(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            NumbersTextBox.Text = string.Join(" ", Enumerable.Repeat(0, 10).Select(i => random.Next(-10, 10)));
        }

        /// <summary>
        /// Метод нажатия на кнопку сохранения чисел в файл
        /// </summary>
        private void SaveDataToFileAction(object sender, RoutedEventArgs e)
        {
            // Открываю файл диалог, если файл выбирается, то записываю в него данные

            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                File.WriteAllText(openFileDialog.FileName, NumbersTextBox.Text);
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку выбора пути файла отрицательных чисел
        /// </summary>
        private void SelectNegativeFileAction(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                NegativePathTextBox.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку выбора пути файла четных чисел
        /// </summary>
        private void SelectEvenFileAction(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                EvenPathTextBox.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Метод нажатия на кнопку выбора пути файла входных чисел
        /// </summary>
        private void SelectInputFileAction(object sender, RoutedEventArgs e)
        {
            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };
            if (openFileDialog.ShowDialog() == true)
            {
                InputFilePathTextBox.Text = openFileDialog.FileName;
            }
        }

        /// <summary>
        /// Метод разделения чисел на группы и добавление их в соответсвующие файлы
        /// </summary>
        private void SplitToFilesAction(object sender, RoutedEventArgs e)
        {
            // Считываю с файла данные, циклом прохожусь по ним и записываю результаты в файлы

            int[] data;
            try
            {
                data = File.ReadAllText(InputFilePathTextBox.Text).Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            }
            catch
            {
                MessageBox.Show("Возникла ошибка чтения файла");
                return;
            }

            StringBuilder evenStringBuilder = new StringBuilder();
            StringBuilder negStringBuilder = new StringBuilder();

            foreach (int el in data)
            {
                if (el < 0)
                {
                    negStringBuilder.Append($"{el} ");
                }
                if (el % 2 == 0)
                {
                    evenStringBuilder.Append($"{el} ");
                }
            }
            File.WriteAllText(EvenPathTextBox.Text, evenStringBuilder.ToString());
            File.WriteAllText(NegativePathTextBox.Text, negStringBuilder.ToString());
        }
    }
}
