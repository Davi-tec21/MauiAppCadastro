using MauiAppCadastro.Models;

namespace MauiAppCadastro.Views
{
    public partial class Cadastro : ContentPage
    {
        Evento evento = new Evento();

        public Cadastro()
        {
            InitializeComponent();
            BindingContext = evento;
        }

        private async void OnCadastrarClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Evento_resumo(evento));
        }
    }
}