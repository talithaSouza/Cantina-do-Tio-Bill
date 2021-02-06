using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cantina_do_Tio_Bill.Class
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }

        CONEXAO conexao = new CONEXAO();

        public bool inserirUsuario(string nome, string sobrenome, string user, string senha)
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

        //Função para retornar a lista de usuarios cadastrados
        public DataTable getUsuarios()
        {
            MySqlCommand comando = new MySqlCommand("SELECT id, nome, sobrenome, user FROM `usuarios` LIMIT 0, 25", conexao.getConexao());
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;
        }

        //Editar Usuário
        public bool editarUsuario(int id, string nome, string sobrenome, string user)
        {
            MySqlCommand comando = new MySqlCommand();
            string editQuery = "UPDATE `usuarios` SET `nome`=@nome,`sobrenome`=@sbnome,`user`=@user WHERE `id`=@uid";
            comando.CommandText = editQuery;
            comando.Connection = conexao.getConexao();

            //,,@=
            comando.Parameters.Add("@uid", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sbnome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@user", MySqlDbType.VarChar).Value = user;
            //comando.Parameters.Add("@senha", MySqlDbType.VarChar).Value = senha;

            conexao.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
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

        //FUNÇÃO PARA DELETAR UM USUARIO
        public bool removerUsuario(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            string removeQuery = "DELETE FROM `usuarios` WHERE `id` = @uid";
            comando.CommandText = removeQuery;
            comando.Connection = conexao.getConexao();

            comando.Parameters.Add("@uid", MySqlDbType.Int32).Value = id;

            conexao.abrirConexao();

            if (comando.ExecuteNonQuery() == 1)
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
