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
    public class SeriesController : Controller
    {
        //
        // GET: /Series/

        public ActionResult Index()
        {
            var filtro = new FiltrarSeriesModel();

            PreencherExercicio(filtro);
            Preencher(filtro);

            return View("Index", filtro);

        }

        public void PreencherExercicio(FiltrarSeriesModel filtro)
        {
            var repositorio = new Exercicios();
            var todos = repositorio.Todas();
            filtro.TodosExercicios = new List<ExercicioModel>();

            foreach (var exercicio in todos)
            {
                filtro.TodosExercicios.Add(new ExercicioModel()
                                               {
                                                   Id = exercicio.Id,
                                                   Nome = exercicio.Nome
                                               }
                    );
            }
        }

        public void Preencher(FiltrarSeriesModel filtro)
        {
            var repositorio = new Tipos();
            var todos = repositorio.Todas();

            filtro.TodosTipos = new List<TipoModel>();

            foreach (var tipo in todos)
            {
                filtro.TodosTipos.Add(new TipoModel()
                {
                    Id = tipo.Id,
                    Nome = tipo.Nome
                }
                   );
            }

        }

        public ActionResult Cadastrar(SerieModel serieModel)
        {
            var serie = new Serie();
            var tipo = new Tipo();
            var repositorio = new Series();

            serie.ListaExercicio = new List<Exercicio>();
            serie.Nome = serieModel.Nome;
            serie.Objetivo = serieModel.Objetivo;
            repositorio.Salvar(serie);

            return View("Index");
        }
    }
}
