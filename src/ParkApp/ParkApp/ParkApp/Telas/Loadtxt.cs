using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.IO;

using Xamarin.Forms;

namespace ParkApp.Telas
{
    public class Loadtxt : ContentPage
    {
        public Loadtxt()
        {
            var assembly = typeof(Loadtxt).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("ParkApp.listaRuas.txt");

            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }


            Label conteudo = new Label();
            conteudo.Text = text;


            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin Forms!" },
                    conteudo
                }
            };
        }
    }
}