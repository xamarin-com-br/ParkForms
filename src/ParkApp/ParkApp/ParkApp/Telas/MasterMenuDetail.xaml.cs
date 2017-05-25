using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterMenuDetail : ContentPage
    {
        Button TelaLogin, TelaUsuario, TelaCadastroVagas;
        public MasterMenuDetail()
        {
            InitializeComponent();

            TelaLogin = new Button
            {
                Text = "Login"

            };
            TelaUsuario = new Button
            {
                Text = "Usuário"

            };
            TelaCadastroVagas = new Button
            {
                Text = "Vagas +"

            };

            TelaLogin.Clicked += abrirLogin;
            TelaUsuario.Clicked += async (sender, args) => await Navigation.PushAsync(new CadastroUsuario());
            TelaCadastroVagas.Clicked += async (sender, args) => await Navigation.PushAsync(new CadastroDeVagas());

            Content = new StackLayout
            {
                Children = {
                    TelaLogin,
                    TelaUsuario,
                    TelaCadastroVagas
                }
            };
        }

        async void abrirLogin(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Login());
        }
        void abrirCadastroUsuario(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroUsuario());
        }
        void abrirCadstroVagas(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroDeVagas());

        }
    }
}