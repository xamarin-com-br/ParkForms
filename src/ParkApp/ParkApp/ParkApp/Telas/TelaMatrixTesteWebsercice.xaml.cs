using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TelaMatrixTesteWebsercice : ContentPage
    {
        IWebServicesMatrix servico;

        public TelaMatrixTesteWebsercice()
        {
            InitializeComponent();
        }

        async void btnTexto_Clicked(object sender, EventArgs e)
        {
            servico = DependencyService.Get<IWebServicesMatrix>();
            lbTexto.Text = servico.getMensagem();

        }

        HttpClient cliente;

        private void btnLista_Clicked(object sender, EventArgs e)
        {
            cliente = new HttpClient();
            cliente.BaseAddress = new Uri("http://192.168.20.172:8086");
            var temp = GetTodosProfessores();

            lbTexto.Text = temp[0].nome;




        }

        public List<Model.ProfessorModelo> GetTodosProfessores()
        {
            Task<string> dados = cliente.GetStringAsync("/professor/ListaProfessoresStatic");
            List<Model.ProfessorModelo> listinha = new List<Model.ProfessorModelo>();
            string temp = dados.Result;
            listinha = JsonConvert.DeserializeObject<List<Model.ProfessorModelo>>(temp);
            return listinha;
        }

    }
}