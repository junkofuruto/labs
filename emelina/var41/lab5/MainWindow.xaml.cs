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

namespace lab4
{
    public partial class MainWindow : Window
    {
        List<OrganismClass> organisms = new List<OrganismClass>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddOrg(object sender, RoutedEventArgs e)
        {
            OrganismClass organism = new OrganismClass();

            try
            {
                organism.Name = OrgName.Text;
                organism.Weight = Convert.ToDouble(OrgWeight.Text);
                organism.Volume = Convert.ToDouble(OrgVolume.Text);

                organisms.Add(organism);
                InfoLabel.Text = "";
            }
            catch (FormatException)
            {
                InfoLabel.Text = "Неверный тип данных входных данных";
            }
            catch (Exception ex)
            {
                InfoLabel.Text = ex.Message;
            }
        }

        private void AddUni(object sender, RoutedEventArgs e)
        {
            UnicellularClass organism = new UnicellularClass();

            try
            {
                organism.Name = UniName.Text;
                organism.Weight = Convert.ToDouble(UniWeight.Text);
                organism.Volume = Convert.ToDouble(UniVolume.Text);
                organism.HasMind = UniMind.IsEnabled;

                organisms.Add(organism);
                InfoLabel.Text = "";
            }
            catch (FormatException)
            {
                InfoLabel.Text = "Неверный тип данных входных данных";
            }
            catch (Exception ex)
            {
                InfoLabel.Text = ex.Message;
            }
        }

        private void AddMulti(object sender, RoutedEventArgs e)
        {
            MulticellularClass organism = new MulticellularClass();

            try
            {
                organism.Name = MultiName.Text;
                organism.Weight = Convert.ToDouble(MultiWeight.Text);
                organism.Volume = Convert.ToDouble(MultiVolume.Text);
                organism.MaxAge = Convert.ToInt32(MultiAge.Text);

                organisms.Add(organism);
                InfoLabel.Text = "";
            }
            catch (FormatException)
            {
                InfoLabel.Text = "Неверный тип данных входных данных";
            }
            catch (Exception ex)
            {
                InfoLabel.Text = ex.Message;
            }
        }

        private void Info(object sender, RoutedEventArgs e)
        {
            InfoLabel.Text = "";

            foreach (OrganismClass organism in organisms)
            {
                InfoLabel.Text += organism.Information();
            }
        }
    }
}
