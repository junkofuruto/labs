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

namespace lab6_4
{
    public partial class MainWindow : Window
    {
        List<Artifact> artifacts = new List<Artifact>();
        

        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddArtefactToList(object sender, RoutedEventArgs e)
        {
            try
            {
                Artifact artifact = new Artifact();

                artifact.ArtifactName = artifactNameTB.Text;
                artifact.ArtifactPrice = Convert.ToDouble(artifactPriceTB.Text);
                artifact.DamageIncrease = Convert.ToDouble(artifactDamageIncreaseTB.Text);
                artifact.HealthIncrease = Convert.ToDouble(artifactHealthIncreaseTB.Text);
                artifact.DefenceIncrease = Convert.ToDouble(artifactDefenceIncreaseTB.Text);
                artifact.Discount = Convert.ToDouble(artifactDiscountTB.Text);

                artifacts.Add(artifact);
            }
            catch
            {
                infoTB.Text = "Ошибка заполнения данных";
            }
        }
        private void AddRingToList(object sender, RoutedEventArgs e)
        {
            try
            {
                Ring ring = new Ring();

                ring.ArtifactName = ringNameTB.Text;
                ring.ArtifactPrice = Convert.ToDouble(ringPriceTB.Text);
                ring.DamageIncrease = Convert.ToDouble(ringDamageIncreaseTB.Text);
                ring.HealthIncrease = Convert.ToDouble(ringHealthIncreaseTB.Text);
                ring.DefenceIncrease = Convert.ToDouble(ringDefenceIncreaseTB.Text);
                ring.Discount = Convert.ToDouble(ringDiscountTB.Text);
                ring.RingMaterial = ringMaterialTB.Text;

                artifacts.Add(ring);
            }
            catch
            {
                infoTB.Text = "Ошибка заполнения данных";
            }
        }
        private void AddSwordToList(object sender, RoutedEventArgs e)
        {
            try
            {
                Sword sword = new Sword();

                sword.ArtifactName = swordNameTB.Text;
                sword.ArtifactPrice = Convert.ToDouble(swordPriceTB.Text);
                sword.DamageIncrease = Convert.ToDouble(swordDamageIncreaseTB.Text);
                sword.HealthIncrease = Convert.ToDouble(swordHealthIncreaseTB.Text);
                sword.DefenceIncrease = Convert.ToDouble(swordDefenceIncreaseTB.Text);
                sword.Discount = Convert.ToDouble(swordDiscountTB.Text);
                sword.SwordName = swordNameTB1.Text;

                artifacts.Add(sword);
            }
            catch
            {
                infoTB.Text = "Ошибка заполнения данных";
            }
        }
        private void GetInfo(object sender, RoutedEventArgs e)
        {
            string info = "";
            double money = 0;

            foreach (Artifact artifact in artifacts)
            {
                info += artifact.GetInfo();
                money += artifact.GetPriceWithDiscount(artifact.Discount);
            }

            infoTB.Text = $"Всего денег потрачено: {money}\n" + info;
        }
    }
}
