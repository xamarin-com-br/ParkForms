using System;

using Xamarin.Forms;

namespace ParkApp.Autetication
{
    public class RememberPassword : ContentPage
    {
        public RememberPassword()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Esqueci minha Senha" },
                    new Entry { Placeholder =" Digite seu login"},
                    new Button { Text = "Enviar lembre de senha"}

                }
            };
        }
    }
}

