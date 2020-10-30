using System;
using System.Collections.Generic;
using TrainingTicket;
using Xamarin.Forms;

namespace TrainingTicket
{
    public partial class CadastroAtividadePage : ContentPage
    {
        public CadastroAtividadePage()
        {
            InitializeComponent();
        }

        static String[] grupo = { "Natação", "Academia", "Zumba"};

        private void onSaveAtividade(object sender, EventArgs args)
        {
            Atividade p = BindingContext as Atividade;

            if (String.IsNullOrEmpty(p.Nome))
            {
                DisplayAlert("Atenção", "O nome não pode ser vázio", "ok");
            }
            else
            {
                App.Database.SaveItemAsync(p);
                Navigation.PopAsync();

            }

        }
    }
}
