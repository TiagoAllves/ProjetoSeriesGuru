using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSeriesGuru.Entidades;
using ProjetoSeriesGuru.Repositorio;

namespace ProjetoSeriesGuru.Controllers
{
   public class ExercicioController
    {
       public void Cadastrar(Exercicio exercicio)
       {
           var repositorio = new Exercicios();
           repositorio.Salvar(exercicio);
       }
       //public void Buscar(Grupamento grupamento)
       //{
       //    var repositorio = new Grupamentos();
       //    repositorio.Obter(grupamento);
       //}          
    }
}
