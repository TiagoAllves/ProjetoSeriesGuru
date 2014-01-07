using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Mapeamento
{
    public class TipoMap : ClassMap<Tipo>
    {
        TipoMap()
        {
            Id(t => t.Id);
            Map(t => t.Nome);
        }
    }
}
