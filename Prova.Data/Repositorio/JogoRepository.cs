using Microsoft.Extensions.Configuration;
using Prova2Bim.Dominio.Entidades;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using Prova2Bim.Domain.Entities;
using Prova2Bim.Domain.Interfaces;
using System.Collections.Generic;
using Prova2Bim.Dominio.Interfaces;
using System.Data.SqlClient;

namespace Prova2Bim.Data.Repositorio
{
    public class JogoRepository : IJogoRepository
    {
        private readonly string _connectionString;

        public JogoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("DefaultConnection");
        }

        public void RegistrarJogo(Jogo jogo)
        {
            var sql = @"INSERT INTO Jogo
                        (Valor1, Valor2, Valor3, Valor4, Valor5, Valor6, DataJogo)
                        VALUES (@Valor1, @Valor2, @Valor3, @Valor4, @Valor5, @Valor6, GETDATE())";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Valor1", jogo.Valor1);
                cmd.Parameters.AddWithValue("@Valor2", jogo.Valor2);
                cmd.Parameters.AddWithValue("@Valor3", jogo.Valor3);
                cmd.Parameters.AddWithValue("@Valor4", jogo.Valor4);
                cmd.Parameters.AddWithValue("@Valor5", jogo.Valor5);
                cmd.Parameters.AddWithValue("@Valor6", jogo.Valor6);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public IEnumerable<Jogo> ListarTodosJogos()
        {
            var lista = new List<Jogo>();

            var sql = "SELECT * FROM Jogo";

            using (var conn = new SqlConnection(_connectionString))
            using (var cmd = new SqlCommand(sql, conn))
            {
                conn.Open();

                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        lista.Add(item: new Jogo
                        {
                            idJogo = reader.GetInt32(reader.GetOrdinal("IdJogo")),
                            Valor1 = reader.GetInt32(reader.GetOrdinal("Valor1")),
                            Valor2 = reader.GetInt32(reader.GetOrdinal("Valor2")),
                            Valor3 = reader.GetInt32(reader.GetOrdinal("Valor3")),
                            Valor4 = reader.GetInt32(reader.GetOrdinal("Valor4")),
                            Valor5 = reader.GetInt32(reader.GetOrdinal("Valor5")),
                            Valor6 = reader.GetInt32(reader.GetOrdinal("Valor6")),
                            DataJogo = reader.GetDateTime(reader.GetOrdinal("DataJogo"))
                        });
                    }
                }
            }

            return lista;
        }
    }
}
