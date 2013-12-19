using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Repositorio
{
    public class Series : RepositorioBase
    {
        public void Salvar(Serie serie)
        {
            base.Save(serie);
        }

        public void Apagar(Serie serie)
        {
            base.Delete(serie);
        }

        public IList<Serie> Todas()
        {
            return base.All<Serie>();
        }

        public Serie Obter(int id)
        {
            return base.Get<Serie>(id);
        }

        public IList<Serie> ObterPor(string nome)
        {
            var criterio = Session.CreateCriteria<Serie>();
            criterio.Add(Restrictions.Like("Nome", nome));
            return criterio.List<Serie>();
        }
    }
}