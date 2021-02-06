﻿using MySql.Data.MySqlClient;
using MySql.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantina_do_Tio_Bill.Class
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }

        CONEXAO conexao = new CONEXAO();

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
    }
}
