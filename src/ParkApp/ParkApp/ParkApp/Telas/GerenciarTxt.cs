using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkApp.Telas
{
    public class GerenciarTxt
    {


        static public string getTextfile()
        {
            var assembly = typeof(Loadtxt).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("ParkApp.listaRuas.txt");

            string text = "";
            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }


            return text;

        
        }

    }
}
