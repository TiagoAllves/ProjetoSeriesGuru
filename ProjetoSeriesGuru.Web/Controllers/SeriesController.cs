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
            var filtroDeSeries = new FiltrarSeriesModel();

            PreencherExercicio(filtroDeSeries);
            PreencherTipo(filtroDeSeries);

            return View("Index", filtroDeSeries);
        }

        public void PreencherExercicio(FiltrarSeriesModel filtroDeSeries)
        {
            var repositorio = new Exercicios();
            var todos = repositorio.Todas();
            filtroDeSeries.TodosExercicios = new List<ExercicioModel>();

            foreach (var exercicio in todos)
            {
                filtroDeSeries.TodosExercicios.Add(new ExercicioModel()
                                               {
                                                   Id = exercicio.Id,
                                                   Nome = exercicio.Nome
                                               }
                    );
            }
        }
        public void PreencherTipo(FiltrarSeriesModel filtroDeSeries)
        {
            var repositorio = new Tipos();
            var todos = repositorio.Todas();
            filtroDeSeries.TodosTipos = new List<TipoModel>();

            foreach (var tipo in todos)
            {
                filtroDeSeries.TodosTipos.Add(new TipoModel()
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
            var repositorioTipo = new Tipos();
            var repositorio = new Series();

            serie.ListaExercicio = new List<Exercicio>(); 

            serie.Tipo = repositorioTipo.Obter(int.Parse(serieModel.Tipo));
            serie.Nome = serieModel.Nome;
            serie.Objetivo = serieModel.Objetivo;
            repositorio.Salvar(serie);

            return View("Index");
        }
    }
}
