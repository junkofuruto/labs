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
using lab6dll;

namespace lab6_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BuyArtifact(object sender, RoutedEventArgs e)
        {
            Artifact artifact = new Artifact();
            try
            {
                artifact.ArtifactName = artName.Text;
                artifact.ArtifactPrice = Convert.ToDouble(artPrice.Text);
                artifact.DamageIncrease = Convert.ToDouble(artDamageInc.Text);
                artifact.HealthIncrease = Convert.ToDouble(artHealthInc.Text);
                artifact.DefenceIncrease = Convert.ToDouble(artDefenceInc.Text);
                artifact.Discount = Convert.ToDouble(artDiscount.Text);

                MessageBox.Show(artifact.GetInfo(), "");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "");
            }
            

            
        }

        private void BuySword(object sender, RoutedEventArgs e)
        {
            Sword artifact = new Sword();
            try
            {
                artifact.ArtifactName = swordName.Text;
                artifact.ArtifactPrice = Convert.ToDouble(swordPrice.Text);
                artifact.DamageIncrease = Convert.ToDouble(swordDamageInc.Text);
                artifact.HealthIncrease = Convert.ToDouble(swordHealthInc.Text);
                artifact.DefenceIncrease = Convert.ToDouble(swordDefenceInc.Text);
                artifact.Discount = Convert.ToDouble(swordDiscount.Text);
                artifact.SwordName = swordName1.Text;
                MessageBox.Show(artifact.GetInfo(), "");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "");
            }

        }

        private void BuyRing(object sender, RoutedEventArgs e)
        {
            Ring artifact = new Ring();
            try
            {
                artifact.ArtifactName = artName.Text;
                artifact.ArtifactPrice = Convert.ToDouble(ringPrice.Text);
                artifact.DamageIncrease = Convert.ToDouble(ringDamageInc.Text);
                artifact.HealthIncrease = Convert.ToDouble(ringHealthInc.Text);
                artifact.DefenceIncrease = Convert.ToDouble(ringDefenceInc.Text);
                artifact.Discount = Convert.ToDouble(ringDiscount.Text);
                artifact.RingMaterial = ringMaterial.Text;
		MessageBox.Show(artifact.GetInfo(), "");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных", "");
            }


                
        }
    }
}
