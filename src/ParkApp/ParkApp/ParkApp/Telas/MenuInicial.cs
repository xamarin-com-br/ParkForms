using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp.Telas
{
    public class MenuInicial : ContentPage
    {
        Button TelaLogin, TelaUsuario, TelaCadastroVagas;


        public MenuInicial()
        {
            TelaLogin = new Button {
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
            TelaLogin.Clicked += async (sender, args) => await Navigation.PushAsync(new Login());
            //TelaUsuario.Clicked += abrirCadastroUsuario;
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

        //void abrirLogin(object sender, EventArgs e)
        //{
        //  await Navigation.PushAsync(new Login());
            
        //}
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