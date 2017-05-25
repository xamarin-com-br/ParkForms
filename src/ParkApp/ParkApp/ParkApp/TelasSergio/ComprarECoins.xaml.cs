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
    public partial class ComprarECoins : ContentPage
    {
        public ComprarECoins()
        {
            InitializeComponent();
        }

        private void btComprar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "You bought " + txtValor.Text + " e-coins", "OK");
        }

        private void txtValor_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                int qtd = Convert.ToInt32(e.NewTextValue);
                double total = (qtd * 0.41);
                lbValorTotal.Text = total.ToString("#.##");
            }
            catch
            {
                lbValorTotal.Text = 0.ToString("#. ##");
            }
        }
    }
}