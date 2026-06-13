using Estacionamento.Data;
using Microsoft.Data.SqlClient;

namespace Estacionamento.Repositories
{
    public class VeiculoRepository
    {
        Conexao conexao = new Conexao();

        public void Inserir(
            string placa,
            string modelo,
            string cor,
            string tipo)
        {
            using SqlConnection conn =
                conexao.ObterConexao();

            string sql =
            @"INSERT INTO Veiculos
            (Placa,Modelo,Cor,TipoVeiculo)
            VALUES
            (@Placa,@Modelo,@Cor,@Tipo)";

            conn.Open();

            SqlCommand cmd =
                new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@Placa", placa);
            cmd.Parameters.AddWithValue("@Modelo", modelo);
            cmd.Parameters.AddWithValue("@Cor", cor);
            cmd.Parameters.AddWithValue("@Tipo", tipo);

            cmd.ExecuteNonQuery();
        }
    }
}