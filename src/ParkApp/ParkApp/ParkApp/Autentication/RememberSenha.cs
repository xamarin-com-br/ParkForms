using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ParkApp.Autentication
{
    public class RememberSenha : ContentPage
    {
        Button button01;
        public RememberSenha()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Esqueci minha senah!" },
                    new Entry {Placeholder = "Digite seu login" },
                   new  Button {Text = "Enviar dica de senha" }
                    
                }
            };

            button01 = new Button();
            button01.Clicked += onclickTexto;
        }

        private void onclickTexto(object sender, EventArgs e)
        {
            
        }
    }
}