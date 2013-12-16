using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSeriesGuru.Entidades.Interfaces;

namespace ProjetoSeriesGuru.Entidades
{
    public class Usuario: IRaizDeAgregacao<int>
    {
        public virtual int Id { get; set; }
        public virtual string Nome { get; set; }
        public virtual string Sobrenome { get; set; }
        public virtual string Sexo { get; set; }
        public virtual string Senha { get; set; }
        public virtual string Email { get; set; }
    }
}
