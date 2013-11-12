using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Mapeamento
{
    public class GrupamentoMap:ClassMap<Grupamento>
    {
        GrupamentoMap()
        {
            Id(a => a.Id);
            Map(a => a.Nome);
        }
    }
}
