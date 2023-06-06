
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

namespace lab4
{
    public partial class MainWindow : Window
    {
        
        List<Word> wordMessage = new List<Word>();
        List<Secret> secretMessage = new List<Secret>();
        List<MessageLab> messageList = new List<MessageLab>();

        int secretLevel = 0;
        string messageInfo;

        public MainWindow()
        {
            InitializeComponent();

            secretLevelTB.Text = secretLevel.ToString();

            minSecretLevel.IsEnabled = secretLevel > 0;
            addSecretLevel.IsEnabled = secretLevel < int.MaxValue;
            addSecretMessageToList.IsEnabled = secretMessageTB.Text != "";
            addSynonymToList.IsEnabled = wordTB.Text != "" & synonymTB.Text != "";
        }

        private void AddSecretMessageToList(object sender, RoutedEventArgs e)
        {
            Secret secret = new Secret();
            secret.Message = secretMessageTB.Text;
            secret.SecretLevel = secretLevel;

            messageList.Add(secret);
        }

        private void AddSynonymToList(object sender, RoutedEventArgs e)
        {
            Word word = new Word();
            word.Message = wordTB.Text;
            word.Synonym = synonymTB.Text;

            messageList.Add(word);
        }

        private void AddNormalMessageToList(object sender, RoutedEventArgs e)
        {
            MessageLab message = new MessageLab();
            message.Message = normalMessageTB.Text;

            messageList.Add(message);
        }

        private void MinSecretLevel(object sender, RoutedEventArgs e)
        {
            secretLevel -= 1;
            secretLevelTB.Text = secretLevel.ToString();

            minSecretLevel.IsEnabled = secretLevel > 0;
            addSecretLevel.IsEnabled = secretLevel < int.MaxValue;
        }

        private void AddSecretLevel(object sender, RoutedEventArgs e)
        {
            secretLevel += 1;
            secretLevelTB.Text = secretLevel.ToString();

            minSecretLevel.IsEnabled = secretLevel > 0;
            addSecretLevel.IsEnabled = secretLevel < int.MaxValue;
        }

        private void secretMessageTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            addSecretMessageToList.IsEnabled = secretMessageTB.Text != "";
        }

        private void wordTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            addSynonymToList.IsEnabled = wordTB.Text != "" & synonymTB.Text != "";
        }

        private void synonymTB_TextChanged(object sender, TextChangedEventArgs e)
        {
            addSynonymToList.IsEnabled = wordTB.Text != "" & synonymTB.Text != "";
        }

        private void InfoClick(object sender, RoutedEventArgs e)
        {
            for (int c = 0; c < messageList.Count; c++)
            {
                messageInfo += messageList[c].GetInfo();
            }

            infoTB1.Text = messageInfo;
            messageInfo = "";
        }
    }
}
