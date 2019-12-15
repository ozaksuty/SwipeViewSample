using SwipeViewSample.Models;
using SwipeViewSample.ServiceManager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SwipeViewSample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PersonListPage : ContentPage
    {
        public IList<Result> List = new ObservableCollection<Result>();
        Provider provider = new Provider();
        public PersonListPage()
        {
            InitializeComponent();
            this.BindingContext = List;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            List.Clear();
            var result = await provider.GetPersons();
            foreach (var item in result.results)
            {
                List.Add(item);
            }
        }

        private void SwipeItem_Invoked(object sender, EventArgs e)
        {
            var item = (SwipeItem)sender;
            var param = (Result)item.CommandParameter;
            List.Remove(param);
        }
    }
}