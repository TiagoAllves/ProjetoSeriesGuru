using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Repositorio
{
   public class Tipos : RepositorioBase
    {
       public void Salvar(Tipo tipo)
       {
           base.Save(tipo);
       }
       public void Apagar(Tipo tipo)
       {
           base.Delete(tipo);
       }

       public IList<Tipo> Todas()
       {
           return base.All<Tipo>();
       }
    public Tipo Obter(int id)
    {
        return base.Get<Tipo>(id);
    }
    public IList<Tipo> ObterPor(string nome)
    {
        var criterio = Session.CreateCriteria<Tipo>();
        criterio.Add(Restrictions.Like("Nome", nome));
        return criterio.List<Tipo>();
    }

    }
}
