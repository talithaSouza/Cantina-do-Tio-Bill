using Cantina_do_Tio_Bill.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cantina_do_Tio_Bill
{
    public partial class Form_GerenciarUsuario : Form
    {
        Usuario u = new Usuario();
        public Form_GerenciarUsuario()
        {
            InitializeComponent();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if(tb_UsuarioNome.Text != "" && tb_UsuarioSobrenome.Text != "")
            {
                string v = string.Concat(tb_UsuarioNome.Text,"_",tb_UsuarioSobrenome.Text);
                tb_userAcesso.Text = v;
            }
        }

        private void btn_AddUsuario_Click(object sender, EventArgs e)
        {
      

            string Nome = tb_UsuarioNome.Text;
            string Sobrenome = tb_UsuarioSobrenome.Text;
            string User = tb_userAcesso.Text;
            string Senha = tb_senhaAcesso.Text;


            if (Nome.Trim().Equals("") || Sobrenome.Trim().Equals("") || User.Trim().Equals("") || Senha.Trim().Equals(""))
            {
                MessageBox.Show("Preencha os campos corretamente", "Erro");
            }
            else
            {
                Boolean testeInserir = u.InserirUsuario(Nome, Sobrenome, User, Senha);
                if (testeInserir)
                {
                    dtgv_usuarios.DataSource = u.getUsuarios();
                    MessageBox.Show("Novo usuário inserido com sucesso");
                }
                else
                {
                    MessageBox.Show("Falha na inserção");
                }
            }
        }

        private void Form_GerenciarUsuario_Load(object sender, EventArgs e)
        {
            dtgv_usuarios.DataSource = u.getUsuarios();
        }
    }
}
