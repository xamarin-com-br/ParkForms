using ParkApp.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace ParkApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new ParkApp.MainPage();

            //MainPage = new ParkApp.Autentication.RememberSenha();
            //MainPage = new ParkApp.Telas.MenuInicial();
            //MainPage = new NavigationPage(new MenuInicial());
            MainPage = new MasterMenu();

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
