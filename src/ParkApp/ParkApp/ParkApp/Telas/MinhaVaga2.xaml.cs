using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhaVaga2 : ContentPage
    {
        public MinhaVaga2()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //  DisplayAlert("Central", "Bom demais!", "OK");

            var action=      DisplayActionSheet("ActionSheet: SavePhoto?", "Cancel", "Delete", "Photo Roll", "Email");
            Debug.WriteLine("Action: " + action);
        }
    }
}