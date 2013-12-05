using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ProjetoSeriesGuru.Entidades;
using ProjetoSeriesGuru.Repositorio;

namespace ProjetoSeriesGuru.Test
{
    [TestFixture]
    public class ClienteTest
    {
        [Test]
        public void Inserir_Um_Exercicio()
        {
            for (int i = 0; i < 5; i++)
            {
                var link = new Link
                {
                    Titulo = "Tricipes destro" + i,
                    Url = "www.musculaçaodoida.com"
                };
                var grupamento = new Grupamento
                {
                    Nome = "Braço" + i,
                };
                var exercicio = new Exercicio
                {
                    Nome = "Squat" + i,
                    Link = link
                };
                var repositorio = new Exercicios();
                repositorio.Salvar(exercicio);

            }
        }
    }
}