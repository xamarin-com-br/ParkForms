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
    public partial class TermosDeAdesao : ContentPage
    {
        public TermosDeAdesao()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        async void btAceitar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            await Navigation.PushAsync(new MasterDetail.MasterDetailPage1(),true);
            
        }

        async void btRejeitar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TelasSergio.Login(), true);
        }
    }
}