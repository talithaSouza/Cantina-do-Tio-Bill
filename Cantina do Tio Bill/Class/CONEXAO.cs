using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Cantina_do_Tio_Bill.Class
{
   public class CONEXAO
    {
        private MySqlConnection conexao = new MySqlConnection("datasource=localhost;port=3306;username=root;password=;database=Cantina");
        
        public MySqlConnection getConexao()
        {
            return conexao;
        }

        //Função para abrir a conexão com o BD
        public void abrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        //Funnção para fechar a conexao com o BD
        public void fecharConexao()
        {
            if (conexao.State == ConnectionState.Open)
            {
                conexao.Close();
            }
        }

    }
}
