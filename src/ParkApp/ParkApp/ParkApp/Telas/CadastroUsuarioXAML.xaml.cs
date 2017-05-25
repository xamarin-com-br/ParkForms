using ParkApp.Model;
using ParkApp.Telas;
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
    public partial class CadastroUsuarioXAML : ContentPage
    {
        Usuario use;
        public CadastroUsuarioXAML()
        {
        
            InitializeComponent();
            use = new Usuario();
            this.BindingContext = use;
        }

        async void usuarioSave(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new ExibirUsuario(this.BindingContext as Usuario));
        }
    }
}