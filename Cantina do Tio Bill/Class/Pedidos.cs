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
        public int FK_IdCliente { get; set; }
        public int FK_IdQuentinha { get; set; }
        public int Quantidade { get; set; }
        CONEXAO conexao = new CONEXAO();
        List<int> listaPedidos = new List<int>();
        public DataTable QuentinhasList()
        {
            MySqlCommand comando = new MySqlCommand("SELECT * FROM `quentinhas` ", conexao.getConexao());
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;
        }

       /*
         public DataTable getIngredientes(int id)
        {
            MySqlCommand comando = new MySqlCommand("SELECT `ingrediente1`, `ingrediente2`, `ingrediente3`, `Ingrediente4`, `Ingrediente5` FROM `quentinhas` WHERE `id`=@id", conexao.getConexao());
            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;
        }
       */

        public DataTable retornaIngredientes(int id)
        {
            MySqlCommand comando = new MySqlCommand();
            string selectQuery = "SELECT `opCarne`, `ingrediente1`, `ingrediente2`, `ingrediente3`, `Ingrediente4`, `Ingrediente5` FROM `quentinhas` WHERE `id`=@id";
            comando.CommandText = selectQuery;
            comando.Connection = conexao.getConexao();

            //,,@=
            comando.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

            MySqlDataAdapter adaptar = new MySqlDataAdapter();
            DataTable tabela = new DataTable();

            adaptar.SelectCommand = comando;
            adaptar.Fill(tabela);

            return tabela;

        }

        public void addPedidoList(int id)
        {
            listaPedidos.Add(id);
        }


    }
}
