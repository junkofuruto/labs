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

namespace EX9
{
    public partial class MainWindow : Window
    {
        private List<Worker> _workers;

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
            // то данные считываются, разделяется на строки, добавляется в лист рабочих
            // сортируется, а затем выводится в текстбокс

            StringBuilder sb = new StringBuilder();

            var openFileDialog = new OpenFileDialog()
            {
                FileName = "Select a text file",
                Filter = "Text files (*.txt)|*.txt",
                Title = "Open text file"
            };

            if (openFileDialog.ShowDialog() == true)
            {
                _workers = new List<Worker>();
                using (StreamReader sr = new StreamReader(openFileDialog.FileName))
                {
                    string[] lines = sr.ReadToEnd().Split('\n');
                    foreach (var line in lines)
                    {
                        string[] data = line.Split(' ');
                        double[] salary = new string[] {
                            data[2], data[3], data[4], data[5], data[6], data[7],
                            data[8], data[9], data[10], data[11], data[12], data[13]
                        }.Select(x => Convert.ToDouble(x)).ToArray();
                        Worker worker = new Worker(data[0], salary, Convert.ToInt32(data[1]), data[14]);
                        _workers.Add(worker);
                    }

                    sb.Append("+--------------------+-------------+\n");
                    sb.Append("| ФАМИЛИЯ            | З/П         |\n");
                    sb.Append("+--------------------+-------------+\n");
                    foreach (Worker worker in _workers.OrderBy(x => x.FamilyName))
                    {
                        sb.Append($"| {worker.FamilyName.PadRight(19)}| {worker.GetAverageYearSalary().ToString().PadRight(12)}|\n");
                    }
                    sb.Append("+--------------------+-------------+\n");

                    WorkersDataTextBox.Text = sb.ToString();
                }
            }
        }
    }
}