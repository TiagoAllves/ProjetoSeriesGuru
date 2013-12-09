using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
