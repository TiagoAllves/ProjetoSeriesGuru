using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoSeriesGuru.Repositorio;

namespace ProjetoSeriesGuru.Web.Controllers
{
    public class ExerciciosController : Controller
    {
        //
        // GET: /Exercicios/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar(string nome,string titulo,string url)
        {
            return View();
        }
    }
}
