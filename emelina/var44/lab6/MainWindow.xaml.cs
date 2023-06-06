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

namespace lab6
{
    public partial class MainWindow : Window
    {
        MessageClass msg = new MessageClass();
        WordClass word = new WordClass();
        SecretClass sec = new SecretClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetData(object sender, RoutedEventArgs e)
        {
            switch (typeCB.SelectedIndex)
            {
                case 0:
                    msg.Message = messageTB.Text;
                    msg.Importance = impCB.SelectedIndex;

                    MessageBox.Show(msg.GetInfo(), "MESSAGE INFO");
                    break;

                case 1:
                    word.Message = wordTB.Text;
                    word.Synonym = synonymTB.Text;
                    word.Importance = impCB.SelectedIndex;

                    MessageBox.Show(word.GetInfo(), "WORD INFO");
                    break;

                case 2:
                    sec.Message = secretTB.Text;
                    sec.Importance = impCB.SelectedIndex;

                    MessageBox.Show(sec.GetInfo(), "SECRET MESSAGE INFO");
                    break;
            }
        }

        private void ThemeChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (themeCB.SelectedIndex)
            {
                case 0: bg.Background = new SolidColorBrush(Color.FromRgb(255, 255, 255)); break;
                case 1: bg.Background = new SolidColorBrush(Color.FromRgb(123, 123, 123)); break;
                case 2: bg.Background = new SolidColorBrush(Color.FromRgb(0, 0, 0)); break;
            }
        }

        private void TypeChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (typeCB.SelectedIndex)
            {
                case 0: 
                    messageTB.Visibility = Visibility.Visible;

                    wordTB.Visibility = Visibility.Hidden;
                    synonymTB.Visibility = Visibility.Hidden;

                    secretTB.Visibility = Visibility.Hidden;
                    addSecretLevelButton.Visibility = Visibility.Hidden;
                    minSecretLevelButton.Visibility = Visibility.Hidden;
                    secretLevelTB.Visibility = Visibility.Hidden;
                    break;

                case 1:
                    messageTB.Visibility = Visibility.Hidden;

                    wordTB.Visibility = Visibility.Visible;
                    synonymTB.Visibility = Visibility.Visible;

                    secretTB.Visibility = Visibility.Hidden;
                    addSecretLevelButton.Visibility = Visibility.Hidden;
                    minSecretLevelButton.Visibility = Visibility.Hidden;
                    secretLevelTB.Visibility = Visibility.Hidden;
                    break;

                case 2:
                    messageTB.Visibility = Visibility.Hidden;

                    wordTB.Visibility = Visibility.Hidden;
                    synonymTB.Visibility = Visibility.Hidden;

                    secretTB.Visibility = Visibility.Visible;
                    addSecretLevelButton.Visibility = Visibility.Visible;
                    minSecretLevelButton.Visibility = Visibility.Visible;
                    secretLevelTB.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void AddSecretLevel(object sender, RoutedEventArgs e)
        {
            sec.SecretLevel += 1;
            secretLevelTB.Text = sec.SecretLevel.ToString();
        }

        private void MinSecretLevel(object sender, RoutedEventArgs e)
        {
            sec.SecretLevel -= 1;
            secretLevelTB.Text = sec.SecretLevel.ToString();
        }
    }
}
