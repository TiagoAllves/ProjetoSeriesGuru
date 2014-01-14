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
        public IList<Exercicio> Todas()
        {
            return base.All<Exercicio>();
        }
        public Exercicio Obter (int id)
        {
            return base.Get<Exercicio>(id);
        }
        public IList<Exercicio> ObterPor(string nome)
        {
            var criterio = Session.CreateCriteria<Exercicio>();
            criterio.Add(Restrictions.Like("Nome", nome));
            return criterio.List<Exercicio>();
        }
        public List<Exercicio> ObterPor(Grupamento grupamento)
        {
            var criterio = Session.CreateCriteria<Exercicio>();
            criterio.Add(Restrictions.Eq("Grupamento", grupamento));
            return criterio.List<Exercicio>().ToList();
        }
    }
}