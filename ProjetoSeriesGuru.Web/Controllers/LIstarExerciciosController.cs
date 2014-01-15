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
        // GET: /LIstarExercicios/

        public ActionResult Index()
        {
            var filtro = new FiltrarExerciciosModel();                             

            PreencherGrupamento(filtro);

            return View("Index", filtro);
        }

        private static void PreencherGrupamento(FiltrarExerciciosModel filtro)
        {
            var repositorioGrupamento = new Grupamentos();
            var todos = repositorioGrupamento.Todas();

            filtro.TodosGrupamentos = new List<GrupamentoModel>();

            foreach (var grupamento in todos)
            {
               filtro.TodosGrupamentos.Add(new GrupamentoModel()
                                                {
                                                   Id = grupamento.Id,
                                                   Nome = grupamento.Nome
                                                }
                  );
            }
        }

        public ActionResult Buscar(ExercicioModell exercicioModell)
        {
            var repositorioo = new Grupamentos();

            var repositorioExercicios = new Exercicios();

            var grupamento = repositorioo.Obter(exercicioModell.IdGrupamento);

            List<Exercicio> exercicios = repositorioExercicios.ObterPor(grupamento);

            var filtro = new FiltrarExerciciosModel();//instanciei a model

            PreencherGrupamento(filtro);

            filtro.Exercicios = new List<ExercicioModel>();//instanciei a lista de exerciciosmodel da Model filtrar

            foreach (var exercicio in exercicios)//varrendo a lista de exercicios de dominio
            {
                filtro.Exercicios.Add(new ExercicioModel()
                                          {
                                              Grupamento = exercicio.Grupamento.Nome,
                                              Nome = exercicio.Nome,
                                              Url = exercicio.Link.Url,
                                              Titulo = exercicio.Link.Titulo
                                          });
            }

            return PartialView("_Exercicios", filtro);
        }
    }
}