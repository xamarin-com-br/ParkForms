using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp.Telas
{
    public class CadastroUsuario : ContentPage
    {
        public CadastroUsuario()
        {
            Content = new StackLayout
            {
                Children = {
                    new Button { Text = "Cadastro de Usuário" },
                    new Label { Text = "Nome" },
                    new Entry { },
                    new Label { Text = "E-mail" },
                    new Entry { },
                    new Label { Text = "Senha" },
                    new Entry { },
                    new Switch { },
                    new Label { Text = "Li e aceito os termos de uso"}
                   
                  

                }
            };
        }
    }
}