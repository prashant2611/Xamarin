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
    public partial class MachineUsesLetestSeries : ContentPage
    {
        
        IMachineDetailRepository repo=new MachineDetailRepository();
        List<string> LetestList { get; set; }
         
      
        public MachineUsesLetestSeries()
        {
            InitializeComponent();
            LetestList = repo.GetMachineTypeUseLetestAsset();
            demolist.ItemsSource = LetestList;
        }
    }
}