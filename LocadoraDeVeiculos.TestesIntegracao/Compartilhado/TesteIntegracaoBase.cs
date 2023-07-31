

using FizzWare.NBuilder;
using LocadoraDeVeiculos.Dominio.ModuloParceiro;
using LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.Compartilhado;
using LocadoraDeVeiculos.Infra.Orm._4._1_Acesso_a_Dados.ModuloParceiro;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace LocadoraDeVeiculos.TestesIntegracao.Compartilhado {
    public class TesteIntegracaoBase {

        protected IRepositorioParceiro repositorioParceiro;

        public TesteIntegracaoBase() {

            //LimparTabelas();

            string connectionString = ObterConnectionString();
            var optionsBuilder = new DbContextOptionsBuilder<LocadoraDeVeiculosDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            var dbContext = new LocadoraDeVeiculosDbContext(optionsBuilder.Options);

            repositorioParceiro = new RepositorioParceiroOrm(dbContext);
            

            BuilderSetup.SetCreatePersistenceMethod<Parceiro>(repositorioParceiro.Inserir);
            
        }

        protected static void LimparTabelas() {
            string? connectionString = ObterConnectionString();

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string sqlLimpezaTabela =
                @"
                DELETE FROM [DBO].[TBPARCEIRO]
                DBCC CHECKIDENT ('[TBPARCEIRO]', RESEED, 0);";

            SqlCommand comando = new SqlCommand(sqlLimpezaTabela, sqlConnection);

            sqlConnection.Open();

            comando.ExecuteNonQuery();

            sqlConnection.Close();
        }

        protected static string ObterConnectionString() {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            return configuracao.GetConnectionString("SqlServer");

 
        }
    }
}
