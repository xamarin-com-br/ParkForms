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
    public partial class TermoDeAdesao : ContentPage
    {
        public TermoDeAdesao()
        {
            InitializeComponent();

            conteudo.Text = GerenciarTxt.getTextfile();
        }
    }
}