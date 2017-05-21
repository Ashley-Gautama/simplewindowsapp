using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace jwcalculater
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        int determineMultiplier;
        double multiplier;

        private void button_Click(System.Object sender, RoutedEventArgs e)
        {
            
            CalculateDamage();
        }

        private void CalculateDamage()
        {
            int turn = 1;
            String results = "Results:\n";

            if (determineMultiplier == 2)
            {
                multiplier = 1.5;
            }

            else if (determineMultiplier == 3)
            {
                multiplier = 0.5;
            }

            else
            {
                multiplier = 1;
            }

            while (turn < 9)
            {
                int damage;
                string userInput = texbox.Text;
                if (!int.TryParse(texbox.Text, out damage))
                {
                    instructions.Text = "invalid input, must input a number";
                    break;
                }

                double damage2 = Convert.ToDouble(damage);
                damage2 = (multiplier * (damage * turn) * (1 + ((turn - 1) * 0.2)));
                damage2 = Math.Round(damage2, MidpointRounding.AwayFromZero);
                string text = string.Format("Total damage turn {0} is {1}!\n", turn, damage2);
                results += text;
                result.Text = results;
                turn++;
            }
        }

       

        private void TextBox_TextChanged(System.Object sender, TextChangedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(System.Object sender, RoutedEventArgs e)
        {
            determineMultiplier = 2;
        }

       

        private void RadioButton_Checked_2(System.Object sender, RoutedEventArgs e)
        {
            determineMultiplier = 1;
        }

       

        private void RadioButton_Checked_3(System.Object sender, RoutedEventArgs e)
        {
            determineMultiplier = 3;
        }

        private void result_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }
    }
}
