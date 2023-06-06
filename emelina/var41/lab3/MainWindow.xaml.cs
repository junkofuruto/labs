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
using org_dll;

namespace lab3
{
    public partial class MainWindow : Window
    {
        OrganismClass organism = new OrganismClass();
        double totalWeight;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RenameClick(object sender, RoutedEventArgs e)
        {
            organism.Name = nameTB.Text;
        }
        private void ReweightClick(object sender, RoutedEventArgs e)
        {
            try
            {
                totalWeight += Math.Abs(organism.Weight - Convert.ToDouble(weightTB.Text));
                organism.Weight = Convert.ToDouble(weightTB.Text);
            }
            catch (Exception ex)
            {
                infoTB.Text = ex.Message;
            }
        }
        private void SetData(object sender, RoutedEventArgs e)
        {
            try
            {
                organism.Name = nameTB.Text;
                organism.Weight = Convert.ToDouble(weightTB.Text);
                organism.Volume = Convert.ToDouble(volumeTB.Text);

                nameButton.IsEnabled = true;
                infoButton.IsEnabled = true;
                weightButton.IsEnabled = true;
            }
            catch (Exception ex)
            {
                infoTB.Text = ex.Message;
            }
        }
        private void GetInfo(object sender, RoutedEventArgs e)
        {
            infoTB.Text = $"{organism.Name} изменил вес на {totalWeight}";
            totalWeight = 0;
        }

        private void a_Click(object sender, RoutedEventArgs e)
        {
            organism.SetWeightByPercent(10);
            totalWeight += Math.Abs(organism.Weight - Convert.ToDouble(weightTB.Text));
            weightTB.Text = organism.Weight.ToString();
        }

        private void b_Click(object sender, RoutedEventArgs e)
        {
            organism.SetWeightByPercent(-20);
            totalWeight += Math.Abs(organism.Weight - Convert.ToDouble(weightTB.Text));
            weightTB.Text = organism.Weight.ToString();
        }

        private void d_Click(object sender, RoutedEventArgs e)
        {
            dens.Text = organism.GetDensity().ToString();
        }
    }
}
