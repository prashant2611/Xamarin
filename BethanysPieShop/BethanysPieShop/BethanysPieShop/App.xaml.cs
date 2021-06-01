
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BethanysPieShop.Layouts;
using BethanysPieShop.View;


namespace BethanysPieShop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ContentPageView();
            //MainPage = new NavigationPage(new NavigationPageView());
            //MainPage = new TabbedPageView();
            MainPage = new MasterDetailPageView();
            //MainPage = new CarouseIPageView();
            //MainPage = new StackLayoutPage();
            //MainPage = new LoginWithStackLayout();
            //MainPage = new GridPage();
            //MainPage = new GridLayoutPage();
            //MainPage = new RelativeLayoutPage();
            //MainPage = new AbsoluteLayoutPage();
            //MainPage = new ScrollViewPage();
            //MainPage = new FlexLayoutPage();
          
           
            
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
