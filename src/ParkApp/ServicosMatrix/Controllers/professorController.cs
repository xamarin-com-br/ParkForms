using ServicosMatrix.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ServicosMatrix.Controllers
{
    public class professorController : Controller
    {
       tableProfessorEntities db;

        // GET: professor
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult ListaProfessoresStatic()
        {
            //db = new tableProfessorEntities();
            List<ProfessoresTeste> todos = new List<ProfessoresTeste>();
            ProfessoresTeste professor1 = new ProfessoresTeste();
            professor1.codigo = 1;
            professor1.nome = "Reginaldo";
            professor1.idade = 30;
            todos.Add(professor1);

            ProfessoresTeste professor2 = new ProfessoresTeste();
            professor2.codigo = 2;
            professor2.nome = "Binhara";
            professor2.idade = 65;

            todos.Add(professor2);




            var dados = todos.ToList();

            return Json(dados,JsonRequestBehavior.AllowGet);
        }

        public JsonResult ListaProfessoresDimaci()
        {

            db = new tableProfessorEntities();


            var dados = db.professors.ToList();

            return Json(dados, JsonRequestBehavior.AllowGet);
        }
    }

    public class ProfessoresTeste
    {

        public int codigo { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }

    }


}