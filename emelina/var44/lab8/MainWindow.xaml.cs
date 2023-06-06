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

namespace lab8
{
    public partial class MainWindow : Window
    {
        static int Minimum(int a, int b, int c) => (a = a < b ? a : b) < c ? a : c;
        static int LevDist(string firstWord, string secondWord)
        {
            int n = firstWord.Length + 1;
            int m = secondWord.Length + 1;
            int[,] matrixD = new int[n, m];

            const int deletionCost = 1;
            const int insertionCost = 1;

            for (var i = 0; i < n; i++)
            {
                matrixD[i, 0] = i;
            }

            for (var j = 0; j < m; j++)
            {
                matrixD[0, j] = j;
            }

            for (var i = 1; i < n; i++)
            {
                for (var j = 1; j < m; j++)
                {
                    var substitutionCost = firstWord[i - 1] == secondWord[j - 1] ? 0 : 1;

                    matrixD[i, j] = Minimum(matrixD[i - 1, j] + deletionCost,
                                            matrixD[i, j - 1] + insertionCost,
                                            matrixD[i - 1, j - 1] + substitutionCost);
                }
            }

            return matrixD[n - 1, m - 1];
        }


        MessageClass message = new MessageClass();
        SecretClass secret = new SecretClass();
        WordClass word = new WordClass();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcLevDist(object sender, RoutedEventArgs e)
        {
            switch (msgCB1.SelectedIndex)
            {
                case 0: MessageClass msg= new MessageClass(); break;
                case 1: SecretClass sec = new SecretClass(); break;
                case 2: WordClass wrd = new WordClass(); break;
            }

            switch (msgCB2.SelectedIndex)
            {
                case 0: MessageClass msg = new MessageClass(); break;
                case 1: SecretClass sec = new SecretClass(); break;
                case 2: WordClass wrd = new WordClass(); break;
            }

            //MessageBox.Show($"Расстояние Левенштейна для этих сообщений равно: {LevDist(messageTB1.Text, messageTB2.Text)}", "Расстояние Левенштейна", MessageBoxButton.OK, MessageBoxImage.None);
        }

        private void msgCB1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (msgCB1.SelectedIndex)
            {
                case 0:
                    messageTB1.Visibility = Visibility.Visible;
                    wordTB1.Visibility = Visibility.Hidden;
                    synonymTB1.Visibility = Visibility.Hidden;
                    secretTB1.Visibility = Visibility.Hidden;
                    secretLevelLabel1.Visibility = Visibility.Hidden;
                    secretLevelMin1.Visibility = Visibility.Hidden;
                    secretLevelAdd1.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    messageTB1.Visibility = Visibility.Hidden;
                    wordTB1.Visibility = Visibility.Visible;
                    synonymTB1.Visibility = Visibility.Visible;
                    secretTB1.Visibility = Visibility.Hidden;
                    secretLevelLabel1.Visibility = Visibility.Hidden;
                    secretLevelMin1.Visibility = Visibility.Hidden;
                    secretLevelAdd1.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    messageTB1.Visibility = Visibility.Hidden;
                    wordTB1.Visibility = Visibility.Hidden;
                    synonymTB1.Visibility = Visibility.Hidden;
                    secretTB1.Visibility = Visibility.Visible;
                    secretLevelLabel1.Visibility = Visibility.Visible;
                    secretLevelMin1.Visibility = Visibility.Visible;
                    secretLevelAdd1.Visibility = Visibility.Visible;
                    break;
            }
        }
        private void msgCB2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (msgCB2.SelectedIndex)
            {
                case 0:
                    messageTB2.Visibility = Visibility.Visible;
                    wordTB2.Visibility = Visibility.Hidden;
                    synonymTB2.Visibility = Visibility.Hidden;
                    secretTB2.Visibility = Visibility.Hidden;
                    secretLevelLabel2.Visibility = Visibility.Hidden;
                    secretLevelMin2.Visibility = Visibility.Hidden;
                    secretLevelAdd2.Visibility = Visibility.Hidden;
                    break;
                case 1:
                    messageTB2.Visibility = Visibility.Hidden;
                    wordTB2.Visibility = Visibility.Visible;
                    synonymTB2.Visibility = Visibility.Visible;
                    secretTB2.Visibility = Visibility.Hidden;
                    secretLevelLabel2.Visibility = Visibility.Hidden;
                    secretLevelMin2.Visibility = Visibility.Hidden;
                    secretLevelAdd2.Visibility = Visibility.Hidden;
                    break;
                case 2:
                    messageTB2.Visibility = Visibility.Hidden;
                    wordTB2.Visibility = Visibility.Hidden;
                    synonymTB2.Visibility = Visibility.Hidden;
                    secretTB2.Visibility = Visibility.Visible;
                    secretLevelLabel2.Visibility = Visibility.Visible;
                    secretLevelMin2.Visibility = Visibility.Visible;
                    secretLevelAdd2.Visibility = Visibility.Visible;
                    break;
            }
        }
    }
}
