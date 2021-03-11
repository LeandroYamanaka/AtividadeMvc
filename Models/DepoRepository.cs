using System.Collections.Generic;
using MySqlConnector;
using System;
namespace ProjetoMVC.Models
{
    public class DepoRepository
    {
        /*********Conexão BD************/

        private const string _strConexao = "Database=paraty; Data Source=localhost; User Id=root; Allow User Variables=True;";

        public Depoimento BuscarId(int IdDepoimento)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string Query = "SELECT * FROM depoimento WHERE IdDepoimento=@IdDepoimento";
            MySqlCommand comando = new MySqlCommand(Query, conexao);
            comando.Parameters.AddWithValue("@IdDepoimento", IdDepoimento);
            MySqlDataReader reader = comando.ExecuteReader();

            Depoimento depoimento = new Depoimento();
            if (reader.Read())
            {
                depoimento.IdDepoimento = reader.GetInt32("IdDepoimento");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    depoimento.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Data")))
                    depoimento.Data = reader.GetString("Data");
                if (!reader.IsDBNull(reader.GetOrdinal("Mensagem")))
                    depoimento.Mensagem = reader.GetString("Mensagem");

            }
            conexao.Close();
            return depoimento;
        }

        public List<Depoimento> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "SELECT * FROM depoimento ORDER by Data_Depoimento";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            MySqlDataReader reader = comando.ExecuteReader();

            List<Depoimento> listDepo = new List<Depoimento>();

            while (reader.Read())
            {
                Depoimento DepoimentoEncontrado = new Depoimento();

                DepoimentoEncontrado.IdDepoimento = reader.GetInt32("IdDepoimento");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    DepoimentoEncontrado.Nome = reader.GetString("Nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Data_Depoimento")))
                {
                    DepoimentoEncontrado.Data = reader.GetString("Data_Depoimento");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Mensagem")))
                {
                    DepoimentoEncontrado.Mensagem = reader.GetString("Mensagem");
                }
                listDepo.Add(DepoimentoEncontrado);

            }
            conexao.Close();

            return listDepo;
        }

        public void Insert(Depoimento d)
        {

            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "INSERT INTO depoimento (Nome, Data_Depoimento, Mensagem)";
            Query = Query + "VALUES (@Nome, @Data, @Mensagem)";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@Nome", d.Nome);
            comando.Parameters.AddWithValue("@Data", d.Data);
            comando.Parameters.AddWithValue("@Mensagem", d.Mensagem);

            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }
}