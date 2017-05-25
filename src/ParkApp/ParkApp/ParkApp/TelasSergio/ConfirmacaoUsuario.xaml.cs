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
    public partial class ConfirmacaoUsuario : ContentPage
    {
        public ConfirmacaoUsuario(Models.Usuario usuario)
        {
            InitializeComponent();
            this.BindingContext = usuario;
        }
    }
}