using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.TelasSergio
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhasVagasGrid : ContentPage
    {
        ObservableCollection<Models.MinhaVaga> minhasVagas;

        public MinhasVagasGrid()
        {
            InitializeComponent();

            minhasVagas = new ObservableCollection<Models.MinhaVaga>()
            {
                new Models.MinhaVaga() {Nome = "Rua Rochosa", Endereco = "N° 369, bairro das rochas.", Status = "Livre", Foto = "icon.png" },
                new Models.MinhaVaga() {Nome = "Rua da Pedra", Endereco = "N° 369, bairro dos canaviais.", Status = "Ocupada", Foto = "icon.png" }
            };

            listView.ItemsSource = minhasVagas;
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        private void btCadastrar_Clicked(object sender, EventArgs e)
        {
            minhasVagas.Add(new Models.MinhaVaga() { Nome = "Rua dos amores", Endereco = "N° 478, Centro.", Status = "Livre", Foto = "icon.png" });
        }
    }
}