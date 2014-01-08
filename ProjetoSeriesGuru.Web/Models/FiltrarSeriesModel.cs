using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeriesGuru.Web.Models
{
    public class FiltrarSeriesModel
    {
        public IList<ExercicioModel> TodosExercicios { get; set; }

        public IList<TipoModel> TodosTipos { get; set; }
    }
}