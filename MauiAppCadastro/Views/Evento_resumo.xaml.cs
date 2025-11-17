using MauiAppCadastro.Models;

namespace MauiAppCadastro.Views
{
    public partial class Evento_resumo : ContentPage
    {
        public Evento_resumo(Evento evento)
        {
            InitializeComponent();
            BindingContext = evento;
        }
    }
}