﻿using System;
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

namespace lab6_3
{
    public partial class MainWindow : Window
    {
        double[] heroProperties = new double[4] {0, 0, 0, 0};                // ЗДОРОВЬЕ, АТАКА, ЗАЩИТА, ДЕНЬГИ
        double[] firstArtifactProperties = new double[3] {0, 0, 0};         // УРОН, ЗДОРОВЬЕ, ЗАЩИТА
        double[] secondArtifactProperties = new double[3] {0, 0, 0};        // УРОН, ЗДОРОВЬЕ, ЗАЩИТА

        Artifact FirstArtifact = new Artifact();
        Artifact SecondArtifact = new Artifact();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateFirstData()
        {
            firstArtifactDmgIncrease.Text = firstArtifactProperties[0].ToString();
            firstArtifactHpIncrease.Text = firstArtifactProperties[1].ToString();
            firstArtifactDefIncrease.Text = firstArtifactProperties[2].ToString();
        }
        private void UpdateSecondData()
        {
            secondArtifactDmgIncrease.Text = secondArtifactProperties[0].ToString();
            secondArtifactHpIncrease.Text = secondArtifactProperties[1].ToString();
            secondArtifactDefIncrease.Text = secondArtifactProperties[2].ToString();
        }
        private void UpdateHero()
        {
            heroHealth.Text = heroProperties[0].ToString();
            heroDamage.Text = heroProperties[1].ToString();
            heroDefence.Text = heroProperties[2].ToString();
            heroMoney.Text = heroProperties[3].ToString();
        }
        private void TestHeroSetData()
        {
            heroSetData.IsEnabled = !fixFirstArtifactNameButton.IsEnabled &&
                                    !fixFirstArtifactCostButton.IsEnabled &&
                                    !firstArtifactFixDamageButton.IsEnabled &&
                                    !firstArtifactFixHealthButton.IsEnabled &&
                                    !firstArtifactFixDefenceButton.IsEnabled &&
                                    !fixSecondArtifactNameButton.IsEnabled &&
                                    !fixSecondArtifactCostButton.IsEnabled &&
                                    !secondArtifactFixDamageButton.IsEnabled &&
                                    !secondArtifactFixHealthButton.IsEnabled &&
                                    !secondArtifactFixDefenceButton.IsEnabled;

            // с днем запрета if else
        }

        private void FixFirstName(object sender, RoutedEventArgs e)
        {
            FirstArtifact.ArtifactName = firstArtifactName.Text;
            fixFirstArtifactNameButton.IsEnabled = false;
            
        }
        private void FixFirstCost(object sender, RoutedEventArgs e)
        {
            try
            {
                FirstArtifact.ArtifactPrice = Convert.ToDouble(firstArtifactPrice.Text);
                fixFirstArtifactCostButton.IsEnabled = false;

                TestHeroSetData();

                infoLabel.Text = "";
            }        
            catch
            {
                infoLabel.Text = "Ошибка заполнения данных";
            }
        }
        private void FixFirstDamage(object sender, RoutedEventArgs e)
        {
            FirstArtifact.DamageIncrease = firstArtifactProperties[0];
            firstArtifactAddDamageButton.IsEnabled = false;
            firstArtifactMinDamageButton.IsEnabled = false;
            firstArtifactFixDamageButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void FixFirstHealth(object sender, RoutedEventArgs e)
        {
            FirstArtifact.HealthIncrease = firstArtifactProperties[1];
            firstArtifactAddHealthButton.IsEnabled = false;
            firstArtifactMinHealthButton.IsEnabled = false;
            firstArtifactFixHealthButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void FixFirstDefence(object sender, RoutedEventArgs e)
        {
            FirstArtifact.DefenceIncrease = firstArtifactProperties[2];
            firstArtifactAddDefenceButton.IsEnabled = false;
            firstArtifactMinDefenceButton.IsEnabled = false;
            firstArtifactFixDefenceButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void AddFirstDamage(object sender, RoutedEventArgs e)
        {
            firstArtifactProperties[0] += 1;

            UpdateFirstData();
        }
        private void AddFirstHealth(object sender, RoutedEventArgs e)
        {
            firstArtifactProperties[1] += 1;

            UpdateFirstData();
        }
        private void AddFirstDefence(object sender, RoutedEventArgs e)
        {
            firstArtifactProperties[2] += 1;

            UpdateFirstData();
        }
        private void MinFirstDamage(object sender, RoutedEventArgs e)
        {
            firstArtifactProperties[0] -= 1;

            UpdateFirstData();
        }
        private void MinFirstHealth(object sender, RoutedEventArgs e)
        {
            firstArtifactProperties[1] -= 1;

            UpdateFirstData();
        }
        private void MinFirstDefence(object sender, RoutedEventArgs e)
        {
            firstArtifactProperties[2] -= 1;

            UpdateFirstData();
        }
        private void BuyFirst(object sender, RoutedEventArgs e)
        {
            try
            {
                firstArtifactBuy.IsEnabled = false;

                heroProperties[0] = FirstArtifact.GetIncreasedHealth(heroProperties[0]);
                heroProperties[1] = FirstArtifact.GetIncreasedDamage(heroProperties[1]);
                heroProperties[2] = FirstArtifact.GetIncreasedDefence(heroProperties[2]);
                heroProperties[3] -= SecondArtifact.ArtifactPrice;

                UpdateHero();
            }
            catch (Exception ex)
            {
                infoLabel.Text = ex.Message;
            }
        }


        private void FixSecondName(object sender, RoutedEventArgs e)
        {
            SecondArtifact.ArtifactName = secondArtifactName.Text;
            fixSecondArtifactNameButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void FixSecondCost(object sender, RoutedEventArgs e)
        {
            try
            {
                SecondArtifact.ArtifactPrice = Convert.ToDouble(secondArtifactPrice.Text);
                fixSecondArtifactCostButton.IsEnabled = false;

                TestHeroSetData();

                infoLabel.Text = "";
            }
            catch
            {
                infoLabel.Text = "Ошибка заполнения данных";
            }
        }
        private void FixSecondDamage(object sender, RoutedEventArgs e)
        {
            SecondArtifact.DamageIncrease = secondArtifactProperties[0];
            secondArtifactAddDamageButton.IsEnabled = false;
            secondArtifactMinDamageButton.IsEnabled = false;
            secondArtifactFixDamageButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void FixSecondHealth(object sender, RoutedEventArgs e)
        {
            SecondArtifact.HealthIncrease = secondArtifactProperties[1];
            secondArtifactAddHealthButton.IsEnabled = false;
            secondArtifactMinHealthButton.IsEnabled = false;
            secondArtifactFixHealthButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void FixSecondDefence(object sender, RoutedEventArgs e)
        {
            SecondArtifact.DefenceIncrease = secondArtifactProperties[2];
            secondArtifactAddDefenceButton.IsEnabled = false;
            secondArtifactMinDefenceButton.IsEnabled = false;
            secondArtifactFixDefenceButton.IsEnabled = false;

            TestHeroSetData();
        }
        private void AddSecondDamage(object sender, RoutedEventArgs e)
        {
            secondArtifactProperties[0] += 1;

            UpdateSecondData();
        }
        private void AddSecondHealth(object sender, RoutedEventArgs e)
        {
            secondArtifactProperties[1] += 1;

            UpdateSecondData();
        }
        private void AddSecondDefence(object sender, RoutedEventArgs e)
        {
            secondArtifactProperties[2] += 1;

            UpdateSecondData();
        }
        private void MinSecondDamage(object sender, RoutedEventArgs e)
        {
            secondArtifactProperties[0] -= 1;

            UpdateSecondData();
        }
        private void MinSecondHealth(object sender, RoutedEventArgs e)
        {
            secondArtifactProperties[1] -= 1;

            UpdateSecondData();
        }
        private void MinSecondDefence(object sender, RoutedEventArgs e)
        {
            secondArtifactProperties[2] -= 1;

            UpdateSecondData();
        }
        private void BuySecond(object sender, RoutedEventArgs e)
        {
            try
            {
                secondArtifactBuy.IsEnabled = false;

                heroProperties[0] = SecondArtifact.GetIncreasedHealth(heroProperties[0]);
                heroProperties[1] = SecondArtifact.GetIncreasedDamage(heroProperties[1]);
                heroProperties[2] = SecondArtifact.GetIncreasedDefence(heroProperties[2]);
                heroProperties[3] -= SecondArtifact.ArtifactPrice;

                UpdateHero();
            }
            catch (Exception ex)
            {
                infoLabel.Text = ex.Message;
            }
        }

        private void SetHeroData(object sender, RoutedEventArgs e)
        {
            try
            {
                heroProperties[0] = Convert.ToDouble(heroHealth.Text);
                heroProperties[1] = Convert.ToDouble(heroDamage.Text);
                heroProperties[2] = Convert.ToDouble(heroDefence.Text);
                heroProperties[3] = Convert.ToDouble(heroMoney.Text);

                firstArtifactBuy.IsEnabled = FirstArtifact.ArtifactPrice <= heroProperties[3];
                secondArtifactBuy.IsEnabled = SecondArtifact.ArtifactPrice <= heroProperties[3];
                infoLabel.Text = "";
            }
            catch
            {
                infoLabel.Text = "Ошибка при заполнении данных персонажа";
            }
        }
        private void ClearData(object sender, RoutedEventArgs e)
        {
            try
            {
                heroProperties = new double[4] { 0, 0, 0, 0 };
                firstArtifactProperties = new double[3] {0, 0, 0};
                secondArtifactProperties = new double[3] {0, 0, 0};

                UpdateFirstData();
                UpdateSecondData();
                UpdateHero();

                FirstArtifact = new Artifact();
                SecondArtifact = new Artifact();

                fixFirstArtifactNameButton.IsEnabled = true;
                fixFirstArtifactCostButton.IsEnabled = true;
                firstArtifactAddDamageButton.IsEnabled = true;
                firstArtifactMinDamageButton.IsEnabled = true;
                firstArtifactFixDamageButton.IsEnabled = true;
                firstArtifactAddHealthButton.IsEnabled = true;
                firstArtifactMinHealthButton.IsEnabled = true;
                firstArtifactFixHealthButton.IsEnabled = true;
                firstArtifactAddDefenceButton.IsEnabled = true;
                firstArtifactMinDefenceButton.IsEnabled = true;
                firstArtifactFixDefenceButton.IsEnabled = true;
                firstArtifactBuy.IsEnabled = false;

                fixSecondArtifactNameButton.IsEnabled = true;
                fixSecondArtifactCostButton.IsEnabled = true;
                secondArtifactAddDamageButton.IsEnabled = true;
                secondArtifactMinDamageButton.IsEnabled = true;
                secondArtifactFixDamageButton.IsEnabled = true;
                secondArtifactAddHealthButton.IsEnabled = true;
                secondArtifactMinHealthButton.IsEnabled = true;
                secondArtifactFixHealthButton.IsEnabled = true;
                secondArtifactAddDefenceButton.IsEnabled = true;
                secondArtifactMinDefenceButton.IsEnabled = true;
                secondArtifactFixDefenceButton.IsEnabled = true;
                secondArtifactBuy.IsEnabled = false;
            }
            catch
            {
                infoLabel.Text = "Ошибка при очистке данных";
            }
        }
    }
}
