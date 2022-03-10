using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using System;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiBugRepro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            CreateMainPage();
        }



        void CreateMainPage()
        {
            var page = new ContentPage
            {
                Content = new Button
                {
                    Text = "Navigate To NextPage",
                    Command = new Command(() => Application.Current.MainPage.Navigation.PushAsync(new MainPage())),
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalOptions = LayoutOptions.Center,
                }
            };

            page.Appearing += (s, e) =>
            {
                GC.Collect();
                GC.Collect();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.Collect();
                GC.Collect();
            };

            MainPage = new NavigationPage(page);
        }
    }
}
