using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSeriesGuru.Entidades
{
   public class Link
    {
       public virtual int Id { get; set; }
       public virtual string Titulo { get; set; }
       public virtual string Url { get; set; }

       public Link(string urlInseridaPeloUsuario, string tituloInseridoPeloUsuario)
       {
           this.Url = urlInseridaPeloUsuario;
           this.Titulo = tituloInseridoPeloUsuario;
       }
       public Link()
       {          
       }
    }
}