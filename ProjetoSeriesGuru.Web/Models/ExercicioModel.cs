using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeriesGuru.Web.Models
{
    public class ExercicioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Url { get; set; }
        public string Titulo { get; set; }
        public string Grupamento { get; set; }
    }
}
