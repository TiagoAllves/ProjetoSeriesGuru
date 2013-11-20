using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Repositorio
{
    public class Grupamentos : RepositorioBase
    {
        public void Salvar(Grupamento grupamento)
        {
            base.Save(grupamento);
        }
        public void Apagar(Grupamento grupamento)
        {
            base.Delete(grupamento);
        }
        public IList<Grupamentos>Todas()
        {
            return base.All<Grupamentos>();
        }
        public Grupamento Obter(int id)
        {
            return base.Get<Grupamento>(id);         
        }
        public IList<Grupamento> ObterPor(string nome)
        {
            var criterio = Session.CreateCriteria<Grupamento>();
            criterio.Add(Restrictions.Like("Nome", nome));
            return criterio.List<Grupamento>();
        }
    }
}
