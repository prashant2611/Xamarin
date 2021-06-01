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
    public partial class AssetPage : ContentPage
    {
        public AssetPage()
        {
            InitializeComponent();
        }

        private void Get_Assets(object sender, EventArgs e)
        {
            
            Navigation.PushAsync(new GetAssetTypes(machine_name.Text));
        }
    }
}