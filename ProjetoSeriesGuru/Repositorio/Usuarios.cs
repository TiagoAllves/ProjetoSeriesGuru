using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Criterion;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Repositorio
{
    public class Usuarios: RepositorioBase
    {

        public void Salvar (Usuario usuario)
        {
            base.Save(usuario);
        }

        public void Deletar (Usuario usuario)
        {
            base.Delete(usuario);
        }

        public  IList<Usuarios> Todas ()
        {
            return base.All<Usuarios>();
        }

        public Usuarios Obter (int id)
        {
            return base.Get<Usuarios>(id);
        }
        public IList<Usuario> ObterPor(string login)
        {
            var criterio = Session.CreateCriteria<Usuario>();
            criterio.Add(Restrictions.Like("Login", login));
            return criterio.List<Usuario>();
        }

        public Usuario ObterPor(string email, string senha)
        {
            var criterio = Session.CreateCriteria<Usuario>();
            criterio.Add(Restrictions.Eq("Email", email));
            criterio.Add(Restrictions.Eq("Senha", senha));
            return criterio.UniqueResult<Usuario>();
        }
    }
}
