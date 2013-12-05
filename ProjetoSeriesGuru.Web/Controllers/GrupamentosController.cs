using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjetoSeriesGuru.Entidades;
using ProjetoSeriesGuru.Repositorio;
using ProjetoSeriesGuru.Web.Models;

namespace ProjetoSeriesGuru.Web.Controllers
{
    public class GrupamentosController : Controller
    {

        // GET: /Grupamento/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Cadastrar(GrupamentoModel grupamentoModel)
        {
            var grupamentoDomain = new Grupamento();
            var grupamentoRepositorio = new Grupamentos();

            grupamentoDomain.Nome = grupamentoModel.Nome;

            grupamentoRepositorio.Salvar(grupamentoDomain);

            return View("Index");
        }
    }
}
