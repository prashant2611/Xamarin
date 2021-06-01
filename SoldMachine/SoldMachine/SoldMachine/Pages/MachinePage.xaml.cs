using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SoldMachine.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MachinePage : ContentPage
    {
        public MachinePage()
        {
            InitializeComponent();
        }
        private void Get_MachineType(object sender, EventArgs e)
        {
            //this.Frame.Navigate(new GetMachineType(asset_name.Text));
            Navigation.PushAsync(new GetMachineType(asset_name.Text));
        }

        private void Get_MachineUseLetestAsset(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MachineUsesLetestSeries());
        }
    }
}