using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ParkApp.Droid;

[assembly: Xamarin.Forms.Dependency(typeof(ParkApp.Droid.webServiceImplementacao))]

namespace ParkApp.Droid
{
    
   public class webServiceImplementacao : ParkApp.IWebServicesMatrix
    {
        WebReference01Teste.Service servico;
        public webServiceImplementacao()
        {
            servico = new WebReference01Teste.Service();
        }

        string IWebServicesMatrix.getMensagem()
        {
          return servico.HelloWorld();
        }
    }
}