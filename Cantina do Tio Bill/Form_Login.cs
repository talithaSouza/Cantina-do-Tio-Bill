using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cantina_do_Tio_Bill.Class;
using MySql.Data.MySqlClient;

namespace Cantina_do_Tio_Bill
{
    public partial class Form_Login : Form
    {
        private object Conexao;

        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            CONEXAO conect = new CONEXAO();
            DataTable tabela = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand();
            string query = "SELECT * FROM `usuarios` WHERE `user` =@usn AND`senha`=@pass";

            command.CommandText = query;
            command.Connection = conect.getConexao();


            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = tb_usuario.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = tb_senha.Text;

            adapter.SelectCommand = command;
            adapter.Fill(tabela);

            //usuario e senha corretos
            if(tabela.Rows.Count > 0)
            {
                
                this.Hide();
                Form_Menu form_Menu = new Form_Menu();
                form_Menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("usuário ou senha incorretos");
            }

        }
    }
}
