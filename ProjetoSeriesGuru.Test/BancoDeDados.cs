using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using ProjetoSeriesGuru.Mapeamento;

namespace ProjetoSeriesGuru.Test
{
    [TestFixture]
    [Ignore]
    public class BancoDeDados
    {
        private void BuildScherma(Configuration config)
        {
            new SchemaExport(config).Drop(true, true);

            new SchemaExport(config)
                .Create(true, true);
        }
        [Test]
        public void Criar_banco_de_dados_pelo_modelo()
        {
            try
            {
                Fluently.Configure().Database(MsSqlConfiguration.MsSql2008.ConnectionString(
                    c => c.FromAppSetting("connection")).ShowSql()).Mappings(m => m.FluentMappings.AddFromAssemblyOf<ExercicioMap>()).
                    Mappings(m => m.MergeMappings()).ExposeConfiguration(BuildScherma).BuildSessionFactory();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
