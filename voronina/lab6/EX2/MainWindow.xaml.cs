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

namespace EX2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод действия нажатия на кнопку сохранения
        /// </summary>
        private void SelectAndChangeAction(object sender, RoutedEventArgs e)
        {
            // Читаю данные из файла, перевожу считанную строку в формат чисел
            // потом в массиве беру число с последним индексом и изменяю его
            // ну и записываю данные

            int[] fileData;
            int changeValue;

            try
            {
                changeValue = Convert.ToInt32(ChangeValueTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Не удается получить значение, на которое нужно изменить число");
                return;
            }
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
                    fileData = sr.ReadToEnd().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
                }
                fileData[fileData.Length - 1] = fileData[fileData.Length - 1] + changeValue; 
                File.WriteAllText(openFileDialog.FileName, string.Join(" ", fileData));
            }
        }
    }
}
