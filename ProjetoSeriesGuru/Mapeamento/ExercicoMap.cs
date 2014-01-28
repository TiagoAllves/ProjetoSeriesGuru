using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Mapeamento
{
    public class ExercicioMap : ClassMap<Exercicio>
    {
         ExercicioMap()
        {
            Id(e => e.Id);
            Map(e => e.Nome);
            References(e => e.Link).Cascade.All();
            References(e => e.Grupamento);
        }
    }
}