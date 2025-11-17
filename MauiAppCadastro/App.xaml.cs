using MauiAppCadastro.Views;
namespace MauiAppCadastro
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Cadastro());
        }
    }
}
