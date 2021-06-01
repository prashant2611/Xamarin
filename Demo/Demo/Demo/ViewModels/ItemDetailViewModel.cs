using Demo.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo.ViewModels
{
    //[QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        public IList<String> CourseList { get; set; }
        public Note Note { get; set; }


        public String NoteHeading
        {
            get { return Note.Heading; }
            set
            {
                Note.Heading = value;
                OnPropertyChanged();
            }
        }



        public ItemDetailViewModel(Item item=null)
        {
            Title = item?.Text;
            InitializeData();

            Note = new Note
            {
                Heading = "Test note",
                Text = "Text for note in ViewModel",
                Course = CourseList[0]
            };
        }

        async void InitializeData()
        {
            CourseList = await PluralsightDataStore.GetCoursesAsync();
        }


        /*private string itemId;
        private string text;
        private string description;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Description
        {
            get => description;
            set => SetProperty(ref description, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Description = item.Description;
            }
            catch (Exception)
            {
                Debug.WriteLine("Failed to Load Item");
            }
        }*/
    }
}
