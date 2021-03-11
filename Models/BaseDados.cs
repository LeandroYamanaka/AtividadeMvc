using System.Collections.Generic;
using MySqlConnector;
using System;

namespace ProjetoMVC.Models
{

    public class BaseDados
    {
        /*********Conexão BD************/

        private const string _strConexao = "Database=paraty; Data Source=localhost; User Id=root; Allow User Variables=True;";

        public Usuario BuscarId(int IdUsuario)
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();
            string Query = "SELECT * FROM usuario WHERE IdUsuario=@IdUsuario";
            MySqlCommand comando = new MySqlCommand(Query, conexao);
            comando.Parameters.AddWithValue("@IdUsuario", IdUsuario);
            MySqlDataReader reader = comando.ExecuteReader();

            Usuario usuario = new Usuario();
            if (reader.Read())
            {
                usuario.IdUsuario = reader.GetInt32("IdUsuario");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                    usuario.Nome = reader.GetString("Nome");
                if (!reader.IsDBNull(reader.GetOrdinal("Data")))
                    usuario.Data = reader.GetString("Data");
                if (!reader.IsDBNull(reader.GetOrdinal("Horario")))
                    usuario.Horario = reader.GetString("Horario");
                if (!reader.IsDBNull(reader.GetOrdinal("Pessoas")))
                    usuario.Pessoas = reader.GetInt32("Pessoas");
                if (!reader.IsDBNull(reader.GetOrdinal("Telefone")))
                    usuario.Telefone = reader.GetString("Telefone");
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                    usuario.Email = reader.GetString("Email");
                if (!reader.IsDBNull(reader.GetOrdinal("Texto_descricao")))
                    usuario.Texto_descricao = reader.GetString("Texto_descricao");

            }
            conexao.Close();
            return usuario;
        }

        public List<Usuario> Listar()
        {
            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "SELECT * FROM agendamento ORDER by Data_Agendamento";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            MySqlDataReader reader = comando.ExecuteReader();

            List<Usuario> list = new List<Usuario>();

            while (reader.Read())
            {
                Usuario UsuarioEncontrado = new Usuario();

                UsuarioEncontrado.IdUsuario = reader.GetInt32("IdUsuario");

                if (!reader.IsDBNull(reader.GetOrdinal("Nome")))
                {
                    UsuarioEncontrado.Nome = reader.GetString("Nome");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Data_Agendamento")))
                {
                    UsuarioEncontrado.Data = reader.GetString("Data_Agendamento");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Horario")))
                {
                    UsuarioEncontrado.Horario = reader.GetString("Horario");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Pessoas")))
                {
                    UsuarioEncontrado.Pessoas = reader.GetInt32("Pessoas");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Telefone")))
                {
                    UsuarioEncontrado.Telefone = reader.GetString("Telefone");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Email")))
                {
                    UsuarioEncontrado.Email = reader.GetString("Email");
                }
                if (!reader.IsDBNull(reader.GetOrdinal("Texto_descricao")))
                {
                    UsuarioEncontrado.Texto_descricao = reader.GetString("Texto_descricao");
                }
                list.Add(UsuarioEncontrado);

            }
            conexao.Close();

            return list;
        }

        public void Insert(Usuario u)
        {

            MySqlConnection conexao = new MySqlConnection(_strConexao);
            conexao.Open();

            string Query = "INSERT INTO agendamento (Nome, Data_Agendamento, Horario, Pessoas, Telefone, Email, Texto_Descricao)";
            Query = Query + "VALUES (@Nome, @Data, @Horario, @Pessoas, @Telefone, @Email, @Texto_descricao)";

            MySqlCommand comando = new MySqlCommand(Query, conexao);

            comando.Parameters.AddWithValue("@Nome", u.Nome);
            comando.Parameters.AddWithValue("@Data", u.Data);
            comando.Parameters.AddWithValue("@Horario", u.Horario);
            comando.Parameters.AddWithValue("@Pessoas", u.Pessoas);
            comando.Parameters.AddWithValue("@Telefone", u.Telefone);
            comando.Parameters.AddWithValue("@Email", u.Email);
            comando.Parameters.AddWithValue("@Texto_descricao", u.Texto_descricao);


            comando.ExecuteNonQuery();

            conexao.Close();
        }
    }

}