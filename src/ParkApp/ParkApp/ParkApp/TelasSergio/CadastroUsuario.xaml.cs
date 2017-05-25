using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.TelasSergio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CadastroUsuario : ContentPage
    {
        public static Models.Usuario usuario;

        public CadastroUsuario()
        {
            InitializeComponent();
            usuario = new Models.Usuario();
            this.BindingContext = usuario;
            Button btCadastrar = this.FindByName<Button>("btCadastrar");
            btCadastrar.Clicked += new EventHandler(btCadastrar_Click);
        }

        async void btCadastrar_Click(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new TelasSergio.ConfirmacaoUsuario());
        }
    }
}