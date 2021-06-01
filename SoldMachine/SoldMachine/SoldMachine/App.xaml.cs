using SoldMachine.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoldMachine
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            
            MainPage = new HomeMasterDetailPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
