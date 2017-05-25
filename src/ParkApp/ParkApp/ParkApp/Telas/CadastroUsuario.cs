using ParkApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp.Telas
{
    public class CadastroUsuario : ContentPage
    {

        Button btnSalvar;
        Entry nome, email, senha;
        Usuario usuario;
        
        public CadastroUsuario()
        {
            btnSalvar = new Button {
                Text = "Salvar"

            };

            btnSalvar.Clicked += usuarioSave;
            nome = new Entry();
            email = new Entry();
            senha = new Entry();

            usuario = new Usuario();

            this.BindingContext = usuario;
            nome.SetBinding(Entry.TextProperty, "nome");
            email.SetBinding(Entry.TextProperty, "email");
            senha.SetBinding(Entry.TextProperty, "senha");

            Content = new StackLayout
            {
                Children = {
                    new Button { Text = "Cadastro de Usuário" },
                    new Label { Text = "Nome" },
                    nome,
                    new Label { Text = "E-mail" },
                    email,
                    new Label { Text = "Senha" },
                    senha,
                    new Switch { },
                    new Label { Text = "Li e aceito os termos de uso"},
                    btnSalvar
                   
                  

                }
            };
        }

        async void usuarioSave(object sender, EventArgs e)
        {

            await Navigation.PushAsync(new UsuarioDetail(this.BindingContext as Usuario));
        }
    }
}