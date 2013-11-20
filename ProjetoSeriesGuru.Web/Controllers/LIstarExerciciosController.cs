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
    public class ListarExerciciosController : Controller
    {
        //
        // GET: /LIstarExercicios/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Buscar(Merda merda)
        {
            var controller = new ProjetoSeriesGuru.Controllers.ExercicioController();

            
            var repositorioo = new Grupamentos();
            var repositorioExercicios = new Exercicios();

            Grupamento grupamento = repositorioo.Obter(merda.IdGrupamento);
            List<Exercicio> exercicios = repositorioExercicios.ObterPor(grupamento);

            FiltrarExerciciosModel filtro = new FiltrarExerciciosModel();//instanciei a model
            filtro.Exercicios = new List<ExercicioModel>();//instanciei a lista de exerciciosmodel da Model filtrar

            foreach (var exercicio in exercicios)//varrendo a lista de exercicios de dominio
            {
                filtro.Exercicios.Add(new ExercicioModel()
                                          {
                                              Grupamento = exercicio.Grupamento.Nome,
                                              Nome =  exercicio.Nome,
                                              Url = exercicio.Link.Url,
                                              Titulo = exercicio.Link.Titulo
                                          });
            }

            return View("Index", filtro);
        }
    }
}