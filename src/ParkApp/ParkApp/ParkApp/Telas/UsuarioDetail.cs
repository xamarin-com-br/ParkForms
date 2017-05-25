using ParkApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp.Telas
{

    public class UsuarioDetail : ContentPage
    {
        Entry  nome, email, senha;
        Button voltar;
        
     
        public UsuarioDetail(Usuario use)
        {
            nome = new Entry();
            email = new Entry();
            senha = new Entry();
            

            this.BindingContext = use;
            nome.SetBinding(Entry.TextProperty, "nome");
            email.SetBinding(Entry.TextProperty, "email");
            senha.SetBinding(Entry.TextProperty, "senha");

            

            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Usuário!" },
                    nome,
                    email,
                    senha


                }
            };


        }
     
    }
}