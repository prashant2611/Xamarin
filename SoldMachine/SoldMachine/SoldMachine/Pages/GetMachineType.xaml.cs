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
    public partial class GetMachineType : ContentPage
    {
        IMachineDetailRepository repo = new MachineDetailRepository();
      
        public GetMachineType(string assetname)
        {
            InitializeComponent();
            repo.GetMachineTypeForAsset(assetname);
            MachineList.ItemsSource = repo.GetMachineTypeForAsset(assetname);
        }
    }
}