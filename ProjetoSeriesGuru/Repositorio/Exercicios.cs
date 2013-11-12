using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Repositorio
{
    public class Exercicios : RepositorioBase
    {
        public void Salvar(Exercicio exercicio)
        {
            base.Save(exercicio);
        }
        public void Apagar(Exercicio exercicio)
        {
            base.Delete(exercicio);
        }
        public IList<Exercicios> Todas()
        {
            return base.All<Exercicios>();
        }
        public Exercicios Obter (int id)
        {
            return base.Get<Exercicios>(id);
        }
        public IList<Exercicio> ObterPor(string nome)
        {
            var criterio = Session.CreateCriteria<Exercicio>();
            criterio.Add(Restrictions.Like("Nome", nome));
            return criterio.List<Exercicio>();
        }
    }
}
