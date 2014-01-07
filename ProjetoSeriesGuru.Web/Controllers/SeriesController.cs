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

            return View("Index", filtro);
        }

        public void PreencherExercicio(FiltrarSeriesModel filtro)
        {
            var repositorio = new Series();
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
          public ActionResult Cadastrar(SerieModel serieModel)
          {
              var serie = new Serie();
              var repositorio = new Series();

              serie.Exercicio = new Exercicio();
              serie.Nome = serieModel.Nome;
              serie.Objetivo = serieModel.Objetivo;
              serie.Tipo = serieModel.Tipo;
              serie.Exercicio.Nome = serieModel.Nome;
              repositorio.Salvar(serie);

              return View("Index");
          }
    }
}
