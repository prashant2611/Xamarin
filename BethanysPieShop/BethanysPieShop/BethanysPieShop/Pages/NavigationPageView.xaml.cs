using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationPageView : ContentPage
    {
        public NavigationPageView()
        {
            InitializeComponent();
        }

        private async void HomePageButton_Clicked(object sender,EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.HomePageView());
        }

        private async void PieOverViewButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.PieOverView());
        }

        private async void BasketButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.BasketView());
        }

        private async void ContactUsButton_OnClicked(object sender, EventArgs e)
        {
            await this.Navigation.PushAsync(new Helpers.ContactusView());
        }
    }
}