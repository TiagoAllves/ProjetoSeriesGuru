using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Mapeamento
{
    public class LinkMap:ClassMap<Link>
    {
        LinkMap()
        {
            Id(l => l.Id);
            Map(l => l.Titulo);
            Map(l => l.Url);
        }
    }
}
