using Microsoft.Maui.Controls;
using System;

namespace MauiBugRepro
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        int count = 0;
        private async void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";
            await Navigation.PushAsync(new TemplatedPage());
        }
    }
}
