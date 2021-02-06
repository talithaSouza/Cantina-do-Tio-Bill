using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_do_Tio_Bill.Class
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }

        CONEXAO conexao = new CONEXAO();

        public bool InserirUsuario(string nome, string sobrenome, string user, string senha)
        {
            MySqlCommand command = new MySqlCommand();
            string InsertQuery = "INSERT INTO `usuarios`(`nome`, `sobrenome`, `user`, `senha`) VALUES (@nome,@sbnome,@user, @senha)";
            command.CommandText = InsertQuery;
            command.Connection = conexao.getConexao();

            //,,@
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@sbnome", MySqlDbType.VarChar).Value = sobrenome;
            command.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            command.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senha;

            conexao.abrirConexao();

            if (command.ExecuteNonQuery() == 1)
            {
                conexao.fecharConexao();
                return true;
            }
            else
            {
                conexao.fecharConexao();
                return false;
            }


        }

    }
}
