using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp.Telas
{
    public class Login : ContentPage
    {
        Button buttonMessage;
        Label aviso;
        int clickTotal=1;

        public Login()
        {
            buttonMessage = new Button {
                Text  = "Mensagem"

            };
            buttonMessage.Clicked += OnButtonClicked;

            aviso = new Label
            {
                Text = "Criar conta"
            };

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Nome do usuário!" },
                    new Entry { },
                    new Label {Text = "Senha" },
                    new Entry { },
                    new Button {Text = "Login with E-APP" },
                    new Button { Text = "Login with Facebook" },
                    new Button { Text = "Login with Twitter" },
                     aviso
                }
            };
        }

        void OnButtonClicked(object sender, EventArgs e)
        {
            
            clickTotal += 1;
           aviso.Text = String.Format("click{0}",
                                       clickTotal);
        }
    }
}