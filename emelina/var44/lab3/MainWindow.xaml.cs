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

namespace lab3
{
    public partial class MainWindow : Window
    {
        public MessageLab message1 = new MessageLab();
        public MessageLab message2 = new MessageLab();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void FirstMessageWeight(object sender, RoutedEventArgs e)
        {
            message1.Message = tb1.Text;
            message_label.Content = message1.MessageInfo();
        }

        private void SecondMessageWeight(object sender, RoutedEventArgs e)
        {
            message2.Message = tb2.Text;
            message_label.Content = message2.MessageInfo();
        }

        private void HeaviestMessage(object sender, RoutedEventArgs e)
        {
            message_label.Content = (0 * Convert.ToInt32(message1.BytesInMessage() == message2.BytesInMessage())) + 
                                    (2 * Convert.ToInt32(message1.BytesInMessage() < message2.BytesInMessage())) + 
                                    (1 * Convert.ToInt32(message1.BytesInMessage() > message2.BytesInMessage()));
        }
    }
}