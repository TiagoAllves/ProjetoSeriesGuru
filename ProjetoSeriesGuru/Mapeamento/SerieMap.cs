using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using ProjetoSeriesGuru.Entidades;

namespace ProjetoSeriesGuru.Mapeamento
{
    public class SerieMap : ClassMap<Serie>
    {
         SerieMap()
         {
             Id(s => s.Id);
             Map(s => s.Nome);
             Map(s => s.Objetivo);
            
             HasMany(s => s.ListaExercicio).Cascade.All();
         }
    }
}
