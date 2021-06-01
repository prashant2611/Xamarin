using Demo.Models;
using Demo.Services;
using Demo.ViewModels;
using NoteKeeper.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        private ItemDetailViewModel viewModel;

        

        public ItemDetailPage()
        {
            InitializeComponent();            
            //BindingContext = new ItemDetailViewModel();
            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;
            
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();          
            this.viewModel = viewModel;
            BindingContext = this.viewModel; 
        }

      

        public void Cancel_Clicked(object sender, EventArgs eventArgs)
        {
            viewModel.NoteHeading = "XXXXX";
            DisplayAlert("Cancel option",
                "Heading value is " +viewModel.Note.Heading,
                "Button 2","Button 1");
        }

        public void Save_Clicked(object sender, EventArgs eventArgs) 
        {
            DisplayAlert("Save option", "Save was selected", "Button 2", "Button 1");
        }
    }
}