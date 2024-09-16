using Microsoft.Maui.Controls;
using System;

namespace DiceRollkc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnRollDiceClicked(object sender, EventArgs e)
        {
            var random = new Random();
            int result = random.Next(1, 7); // K6
            resultLabel.Text = result.ToString();
        }
    }
}

