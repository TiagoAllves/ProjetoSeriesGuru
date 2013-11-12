using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSeriesGuru.Entidades.Interfaces;

namespace ProjetoSeriesGuru.Entidades
{
    public class Exercicio : IRaizDeAgregacao<int>
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual Link Link { get; set; }
        public virtual Grupamento Grupamento { get; set; }

        public virtual void CriarLink(string urlInseridaPeloUsuario, string tituloInseridoPeloUsuario)
        {
            Link = new Link(urlInseridaPeloUsuario, tituloInseridoPeloUsuario);
        }
    }
}