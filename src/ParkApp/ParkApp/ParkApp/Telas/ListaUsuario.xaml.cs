using ParkApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ParkApp.Telas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaUsuario : ContentPage
    {
        
         ObservableCollection<Usuario> users;

        public ListaUsuario()
        {
            InitializeComponent();

            users = new ObservableCollection<Usuario>()
            {
                new Model.Usuario { Nome = "Reginaldo" ,Login ="Regymatrix"},
                new Model.Usuario {Nome = "Sergio", Login="alves" }

            };

            EmployeeView.ItemsSource = users;
        }



        async void addUser(object sender, EventArgs e)
        {
            Usuario user = new Usuario();
            user.Nome = txtNome.Text;
            user.Login = txtLogin.Text;

            users.Add(user);

            txtNome.Text = "";
            txtLogin.Text = "";
        }

        private void EmployeeView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Usuario user = (Usuario)e.SelectedItem;
            this.BindingContext = user;
        }

        private void txtNome_TextChanged(object sender, TextChangedEventArgs e)
        {
            EmployeeView.ItemsSource = null;
            EmployeeView.ItemsSource = users;
        }
    }
}