using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrainingTicket
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }


        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //mylistView.ItemsSource = await App.Database.GetItemsAsync();

        }

        private void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            if (args != null)
            {
                Navigation.PushAsync(new CadastroAtividadePage()
                {
                    BindingContext = args.SelectedItem as Atividade
                });

            }
        }

        private void OnClicked(Object sender, EventArgs args)
        {
            Navigation.PushAsync(new NavigationPage(new CadastroAtividadePage())
            {
                BindingContext = new Atividade()
            });
        }



    }
}
