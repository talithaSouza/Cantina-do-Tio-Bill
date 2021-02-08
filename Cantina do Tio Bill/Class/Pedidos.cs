using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Cantina_do_Tio_Bill.Class
{
    public class Pedidos
    {
        public int id_Cliente { get; set; }
        public int id_Quentinha { get; set; }        
        public double valorTotal { get; set; }
        public DateTime dataPedido { get; set; }

        List<Quentinha> listaQuentinha = new List<Quentinha>();

        CONEXAO conexao = new CONEXAO();

        public DataTable QuentinhasList()
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `quentinhas` ", conexao.getConexao());
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;
        }


        public DataTable retornaIngredientes(string nome)
        {
            MySqlCommand comando = new MySqlCommand();
            string selectQuery = "SELECT `id`, `opCarne`, `ingrediente1`, `ingrediente2`, `ingrediente3`, `Ingrediente4`, `Ingrediente5`, `valor` FROM `quentinhas` WHERE `nome`=@nome";
            comando.CommandText = selectQuery;
            comando.Connection = conexao.getConexao();

            //,,@=
            comando.Parameters.Add("@nome", MySqlDbType.VarChar).Value = nome;

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;

        }

        public void addPedidoList(Quentinha q)
        {
            listaQuentinha.Add(q);
        }

        //cadastrar pedido
        public bool inserirPedido(int id_cliente, int id_Quentinha, int qtd, double valorTotal)
        {
            MySqlCommand command = new MySqlCommand();
            string InsertQuery = "INSERT INTO `pedidos`(`id_cliente`, `id_quentinha`, `valor_pedido`, `data_criacao`) VALUES (@idc,@idq,@valorP,@data)";
            command.CommandText = InsertQuery;
            command.Connection = conexao.getConexao();

            if(listaQuentinha.Count > 0)
            {
                foreach (Quentinha qe in listaQuentinha)
                {
                    //@,@,@,@,@
                    command.Parameters.Add("@idc", MySqlDbType.VarChar).Value = id_Cliente;
                    command.Parameters.Add("@idq", MySqlDbType.VarChar).Value = qe.id;                    
                    command.Parameters.Add("@valorP", MySqlDbType.Decimal).Value = qe.valor;
                    command.Parameters.Add("@data", MySqlDbType.DateTime).Value = DateTime.Now;
                }
            }


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
