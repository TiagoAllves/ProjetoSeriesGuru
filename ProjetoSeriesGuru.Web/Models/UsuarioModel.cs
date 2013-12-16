using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoSeriesGuru.Web.Models
{
    public class UsuarioModel
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Sexo { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
    }
}