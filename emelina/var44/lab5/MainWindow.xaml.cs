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

using lib3_dll;

namespace lab5
{
    public partial class MainWindow : Window
    {
        MessageClass message1, message2;
        SecretClass secret1, secret2;
        WordClass word1, word2;

        int secretLevel1 = 0, secretLevel2 = 0;

        public MainWindow()
        {
            InitializeComponent();

            firstSecretLevelTB.Text = secretLevel1.ToString();
            secondSecretLevelTB.Text = secretLevel2.ToString();
        }

        private void FirstSecretLevelAdd(object sender, RoutedEventArgs e)
        {
            secretLevel1 += 1;

            firstSecretLevelTB.Text = secretLevel1.ToString();
            secondSecretLevelTB.Text = secretLevel2.ToString();
        }

        private void FirstSecretLevelMin(object sender, RoutedEventArgs e)
        {
            secretLevel1 -= 1;

            firstSecretLevelTB.Text = secretLevel1.ToString();
            secondSecretLevelTB.Text = secretLevel2.ToString();
        }

        private void SecondSecretLevelAdd(object sender, RoutedEventArgs e)
        {
            secretLevel2 += 1;

            firstSecretLevelTB.Text = secretLevel1.ToString();
            secondSecretLevelTB.Text = secretLevel2.ToString();
        }

        private void SecondSecretLevelMin(object sender, RoutedEventArgs e)
        {
            secretLevel2 -= 1;

            firstSecretLevelTB.Text = secretLevel1.ToString();
            secondSecretLevelTB.Text = secretLevel2.ToString();
        }

        private void MessageBytes(object sender, RoutedEventArgs e)
        {
            message1 = new MessageClass();
            message2 = new MessageClass();

            message1.Message = firstMessageTB.Text;
            message2.Message = secondMessageTB.Text;

            try
            {
                MessageBox.Show($"{message1.GetInfo()}\n------------------------------\n{message2.GetInfo()}\n------------------------------\nСТОЛЬКИ БАЙТ "
                            + (message1.BytesInMessage() >= message2.BytesInMessage() ? "ХВАТИТ" : "НЕ ХВАТИТ").ToString(), "ИНФОРМАЦИЯ ПО СООБЩЕНИЮ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void WordBytes(object sender, RoutedEventArgs e)
        {
            word1 = new WordClass();
            word2 = new WordClass();

            word1.Message = firstWordTB.Text;
            word1.Synonym = firstWordSynonymTB.Text;

            word2.Message = secondWordTB.Text;
            word2.Synonym = secondWordSynonymTB.Text;

            try
            {
                MessageBox.Show($"{word1.GetInfo()}\n------------------------------\n{word2.GetInfo()}\n------------------------------\nСТОЛЬКИ БАЙТ "
                            + (word1.BytesInMessage() >= word2.BytesInMessage() ? "ХВАТИТ" : "НЕ ХВАТИТ").ToString(), "ИНФОРМАЦИЯ ПО СООБЩЕНИЮ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

            private void SecretBytes(object sender, RoutedEventArgs e)
        {
            secret1 = new SecretClass();
            secret2 = new SecretClass();

            secret1.Message = firstSecretTB.Text;
            secret1.SecretLevel = secretLevel1;

            secret2.Message = secondSecretTB.Text;
            secret2.SecretLevel = secretLevel2;

            try
            {
                MessageBox.Show($"{secret1.GetInfo()}\n------------------------------\n{secret2.GetInfo()}\n------------------------------\nСТОЛЬКИ БАЙТ "
                            + (secret1.BytesInMessage() >= secret2.BytesInMessage() ? "ХВАТИТ" : "НЕ ХВАТИТ").ToString(), "ИНФОРМАЦИЯ ПО СООБЩЕНИЮ", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch
            {
                MessageBox.Show("Ошибка заполнения данных", "ОШИБКА", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
