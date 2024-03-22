using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleClicks
{
    [QueryProperty(nameof(Parameter), "Parameter")]
    public partial class CollectionViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<ObservableObject> _items;

        public string Parameter { get; set; }

        public CollectionViewModel()
        {
        }

        public void OnAppearing()
        {
            if (Parameter == null)
            {
                //initially on appearing we set up an empty collection view.
                Items = new ObservableCollection<ObservableObject>();
                return;
            }

            //When we get a parameter means we are coming back to the page
            for (int i = 0; i < 26; i++)
            {
                Items.Add(new EmptyItem { Width = 50 });
            }

            Items.RemoveAt(0);
            Items.RemoveAt(0);

            Items.Insert(0, new RealItem { Width = 100 });
        }

        [RelayCommand]
        public async Task GoToSelect()
        {
            await Shell.Current.GoToAsync(nameof(SelectPage));
        }
    }


    public partial class EmptyItem : ObservableObject
    {
        [ObservableProperty]
        private int _width;
    }

    public partial class RealItem : ObservableObject
    {
        [ObservableProperty]
        private int _width;
    }
}
