using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjetoSeriesGuru.Entidades;
using ProjetoSeriesGuru.Repositorio;

namespace ProjetoSeriesGuru.Web.Models
{
    public class ExercicioModell
    {
        public int IdGrupamento { get; set; }
        public string Nome { get; set; }
        public int Titulo { get; set; }
        public string Url { get; set; }
    }

    public class FiltrarExerciciosModel
    {
        public IList<ExercicioModel> Exercicios { get; set; }

        public IList<GrupamentoModel> TodosGrupamentos { get; set; }


    }
}