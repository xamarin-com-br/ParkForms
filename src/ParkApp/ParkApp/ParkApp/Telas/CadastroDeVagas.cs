using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp.Telas
{
    public class CadastroDeVagas : ContentPage
    {
        public CadastroDeVagas()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Endereço" },
                    new Entry {Placeholder ="digite o endereço" },
                    new Label { Text = "Fotos" },
                    new Entry { Placeholder ="inclua a foto"},
                    new Label { Text = "Foto do comprovante de residência" },
                    new Entry {Placeholder ="inclua o comprovante" },
                    new Label {Text ="O comprovante de residência deve estar no nome do usuário cadastrado no e-app" },

                    new Button { Text ="Avançar"}
                }
            };
        }
    }
}