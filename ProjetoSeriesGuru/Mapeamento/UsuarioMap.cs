using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Mapeamento
{
    public class UsuarioMap: ClassMap<Usuario>
    {
        private UsuarioMap()
        {
            Id(u => u.Id);
            Map(u => u.Nome);
            Map(u => u.Sobrenome);
            Map(u => u.Sexo);
            Map(u => u.Senha);
            Map(u => u.Email);
            
        }
    }
}
