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
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        CONEXAO conexao = new CONEXAO();

        //inserir clientes
        public bool InserirCliente(string nome, string sbnome, string telefone)
        {
            MySqlCommand command = new MySqlCommand();
            string InsertQuery = "INSERT INTO `clientes`(`Nome`, `Sobrenome`, `Telefone`) VALUES (@nome,@sbnome,@tlfone)";
            command.CommandText = InsertQuery;
            command.Connection = conexao.getConexao();

            //,,@
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@sbnome", MySqlDbType.VarChar).Value = sbnome;
            command.Parameters.Add("@tlfone", MySqlDbType.VarChar).Value = telefone;

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
        public DataTable getClientes()
        {
            MySqlCommand comando = new MySqlCommand("SELECT id, nome, sobrenome, telefone FROM `clientes` LIMIT 0, 25", conexao.getConexao());
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;
        }

        //Editar Usuário
        public bool editarCliente(int id, string nome, string sobrenome, string telefone)
        {
            MySqlCommand comando = new MySqlCommand();
            string editQuery = "UPDATE `clientes` SET `Nome`=@nome,`Sobrenome`=@sbnome,`Telefone`=@phone WHERE `id`=@cid";
            comando.CommandText = editQuery;
            comando.Connection = conexao.getConexao();

            //,,@=
            comando.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@sbnome", MySqlDbType.VarChar).Value = sobrenome;
            comando.Parameters.Add("@phone", MySqlDbType.VarChar).Value = telefone;
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

        //FUNÇÃO PARA DELETAR UM Cliente
        public bool removerCliente(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            string removeQuery = "DELETE FROM `clientes` WHERE `id` = @cid";
            comando.CommandText = removeQuery;
            comando.Connection = conexao.getConexao();

            comando.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

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
