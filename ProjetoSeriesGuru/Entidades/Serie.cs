using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSeriesGuru.Entidades.Interfaces;

namespace ProjetoSeriesGuru.Entidades
{
    public class Serie : IRaizDeAgregacao<int>
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Objetivo { get; set; }
        public virtual string Tipo { get; set; }
        public virtual Exercicio Exercicio { get; set; }
    }
} 
