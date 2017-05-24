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


            Content = new StackLayout
            {
                Children = {
                    TelaLogin,
                    TelaUsuario,
                    TelaCadastroVagas
                }
            };


			TelaLogin.Clicked += async (sender, args) => await Navigation.PushAsync(new Login());
			TelaUsuario.Clicked += async (sender, args) => await Navigation.PushAsync(new CadastroUsuario());
			TelaCadastroVagas.Clicked += async (sender, args) => await Navigation.PushAsync(new CadastroDeVagas());

		}


    }
}