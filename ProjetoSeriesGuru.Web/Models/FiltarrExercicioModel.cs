using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeriesGuru.Web.Models
{
    public class Merda
    {
        public int IdGrupamento { get; set; }
        public string Nome { get; set; }
        public int Grupamento { get; set; }
        public string Url { get; set; }
    }

    public  class FiltrarExerciciosModel
    {
        public List<ExercicioModel> Exercicios { get; set; } 
    }
}