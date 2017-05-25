using ParkApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaDeVagas : ContentPage
    {
        ObservableCollection<Vaga> vagas;
        public ListaDeVagas()
        {
            InitializeComponent();

            vagas = new ObservableCollection<Vaga>()
            {
                new Model.Vaga { Endereco = "Av. dos Ministerios" ,Latitude ="465461238788", Longitude="45656"},
                new Model.Vaga { Endereco = "Rua Fora Temer" ,Latitude ="465461238788",Longitude="4646465" } 

            };

            VagasView.ItemsSource = vagas;



        }
    }
}