using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_do_Tio_Bill.Class
{
    public class Quentinha
    {
        public int id { get; set; }
        public string Nome { get; set; }
        public string OpCarne { get; set; }
        public string ingre1 { get; set; }
        public string ingre2 { get; set; }
        public string ingre3 { get; set; }
        public string ingre4 { get; set; }
        public string ingre5 { get; set; }
        public decimal valor { get; set; }

        CONEXAO conexao = new CONEXAO();

        public DataTable getQuentinhas()
        {
            MySqlCommand comando = new MySqlCommand("SELECT `id`, `nome`, `opCarne`, `ingrediente1`, `ingrediente2`, `ingrediente3`, `Ingrediente4`, `Ingrediente5`, `valor` FROM `quentinhas` LIMIT 0, 25", conexao.getConexao());
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);
            /*
            List<Quentinha> quentinhas = new List<Quentinha>();

            foreach (var linha in tabela.AsEnumerable())
            {
                Quentinha q = new Quentinha();
                q.id = int.Parse(linha[0].ToString());
                q.Nome = linha[1].ToString();
                q.OpCarne = linha[2].ToString();
                q.ingre1 = linha[3].ToString();
                q.ingre2 = linha[4].ToString();
                q.ingre3 = linha[5].ToString();
                q.ingre4 = linha[6].ToString();
                q.ingre5 = linha[7].ToString();
                q.valor = decimal.Parse(linha[8].ToString());

                quentinhas.Add(q);
            }*/

            return tabela;
        }

        //inserir novo sabor de quentinha
        public bool inserirNovaQuentinha(string nome, string opcarne, string ingr1, string ingr2, string ingr3, string ingr4, string ingr5, double valor)
        {
            MySqlCommand command = new MySqlCommand();
            string InsertQuery = "INSERT INTO `quentinhas`(`nome`, `opCarne`, `ingrediente1`, `ingrediente2`, `ingrediente3`, `Ingrediente4`, `Ingrediente5`, `valor`) VALUES (@nome, @opcarne, @ingr1, @ingr2, @ingr3, @ingr4, @ingr5, @valor)";
            command.CommandText = InsertQuery;
            command.Connection = conexao.getConexao();

            //@, @, @, @, @, @, @
            command.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            command.Parameters.Add("@opcarne", MySqlDbType.VarChar).Value = opcarne;
            command.Parameters.Add("@ingr1", MySqlDbType.VarChar).Value = ingr1;
            command.Parameters.Add("@ingr2", MySqlDbType.VarChar).Value = ingr2;
            command.Parameters.Add("@ingr3", MySqlDbType.VarChar).Value = ingr3;
            command.Parameters.Add("@ingr4", MySqlDbType.VarChar).Value = ingr4;
            command.Parameters.Add("@ingr5", MySqlDbType.VarChar).Value = ingr5;
            command.Parameters.Add("@valor", MySqlDbType.Decimal).Value = valor;

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
        //Editar Quentinha
        public bool editarQuentinha(int id, string nome, string opcarne, string ingr1, string ingr2, string ingr3, string ingr4, string ingr5, double valor)
        {
            MySqlCommand comando = new MySqlCommand();
            string editQuery = "UPDATE `quentinhas` SET `nome`=@nome,`opCarne`=@opcarne,`ingrediente1`=@ingr1,`ingrediente2`=@ingr2,`ingrediente3`=@ingr3,`Ingrediente4`=@ingr4,`Ingrediente5`=@ingr5,`valor`=@valor WHERE `id` = @qid";
            comando.CommandText = editQuery;
            comando.Connection = conexao.getConexao();

            //,,@=
            comando.Parameters.Add("@qid", MySqlDbType.Int32).Value = id;
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;
            comando.Parameters.Add("@opcarne", MySqlDbType.VarChar).Value = opcarne;
            comando.Parameters.Add("@ingr1", MySqlDbType.VarChar).Value = ingr1;
            comando.Parameters.Add("@ingr2", MySqlDbType.VarChar).Value = ingr2;
            comando.Parameters.Add("@ingr3", MySqlDbType.VarChar).Value = ingr3;
            comando.Parameters.Add("@ingr4", MySqlDbType.VarChar).Value = ingr4;
            comando.Parameters.Add("@ingr5", MySqlDbType.VarChar).Value = ingr5;
            comando.Parameters.Add("@valor", MySqlDbType.VarChar).Value = valor;

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

        public bool removerQuentinha(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            string removeQuery = "DELETE FROM `quentinhas` WHERE `id` = @qid";
            comando.CommandText = removeQuery;
            comando.Connection = conexao.getConexao();

            comando.Parameters.Add("@qid", MySqlDbType.Int32).Value = id;

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
