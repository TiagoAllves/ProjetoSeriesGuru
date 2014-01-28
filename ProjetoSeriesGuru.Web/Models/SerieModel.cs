using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeriesGuru.Web.Models
{
    [Serializable]
    public class SerieModel
    {
        public int SeriesId { get; set; }
        public string Nome { get; set; }
        public string Objetivo { get; set; }
        public string Tipo { get; set; }
        public virtual List<string> Exercicios { get; set; }
    }
}