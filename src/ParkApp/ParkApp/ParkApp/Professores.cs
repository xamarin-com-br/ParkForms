
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ParkApp;
using System.Threading.Tasks;
using System.Net.Http;


namespace ParkApp.Droid
{
    public class Professores : ParkApp.IProfessores
    {
        HttpClient cliente;
        
        public Professores()
        {
            cliente = new HttpClient();

            cliente.BaseAddress = new Uri("http://192.168.20.172:8086");

        }

        public List<Model.ProfessorModelo> GetTodosProfessores()
        {
           Task<string> dados = cliente.GetStringAsync("/professor/ListaProfessoresStatic");


            List<Model.ProfessorModelo> listinha = new List<Model.ProfessorModelo>();



            if (dados.IsCompleted)
            {
                string temp = dados.Result;

               // listinha = jsonToObject(temp) as List<Model.ProfessorModelo>;
            }

            

            return listinha;
            

        }

        //private object jsonToObject(string json)
        //{
        //    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        //    object obj = jsSerializer.DeserializeObject(json);
        //    return obj;
        //}

        //private string objectToJson(object obj)
        //{
        //    StringBuilder sb = new StringBuilder();
        //    JavaScriptSerializer jsSerializer = new JavaScriptSerializer();
        //    jsSerializer.Serialize(obj, sb);
        //    return sb.ToString();
        //}


    }
}