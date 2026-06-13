using Microsoft.Data.SqlClient;

namespace Estacionamento.Data
{
    public class Conexao
    {
        private string connectionString =
        @"Server=localhost;
          Database=EstacionamentoDB;
          Trusted_Connection=True;
          TrustServerCertificate=True;";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(connectionString);
        }
    }
}