using SoldMachine.Services;
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
    public partial class GetAssetTypes : ContentPage
    {
        IMachineDetailRepository repo = new MachineDetailRepository();
     
        public GetAssetTypes(string machineName)
        {
            InitializeComponent();
            AssetList.ItemsSource = repo.GetAssetForMachineType(machineName); 
        }
    }
}