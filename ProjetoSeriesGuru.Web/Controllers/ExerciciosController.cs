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
    public class ExerciciosController : Controller
    {
        //
        // GET: /Exercicios/

        public ActionResult Index()
        {
            var filtro = new FiltrarExerciciosModel();

            PreencherGrupamentoCadastro(filtro);

            return View("Index", filtro);
            
        }
        private static void PreencherGrupamentoCadastro(FiltrarExerciciosModel filtro)
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

        public ActionResult Cadastrar(ExercicioModel exercicioModel)
        {
            var controller = new ProjetoSeriesGuru.Controllers.ExercicioController();
            
            var exercicioDomain = new Exercicio();
            var repositorio = new Grupamentos();
            exercicioDomain.Grupamento = repositorio.Obter(int.Parse(exercicioModel.Grupamento));
           
            exercicioDomain.Link = new Link();
            exercicioDomain.Nome = exercicioModel.Nome;
            exercicioDomain.Link.Url = exercicioModel.Url;
            exercicioDomain.Link.Titulo = exercicioModel.Titulo;

            controller.Cadastrar(exercicioDomain);
            return View("Index");
        }

    }
}