using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSeriesGuru.Entidades;
using ProjetoSeriesGuru.Repositorio;

namespace ProjetoSeriesGuru.Controllers
{
    public class GrupamentoController
    {
        public  void Cadastrar (Grupamento grupamento)
        {
            var grupamentorepositorio = new Grupamentos();
            grupamentorepositorio.Salvar(grupamento);
        }
    }
}
