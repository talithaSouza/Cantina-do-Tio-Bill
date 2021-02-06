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
                Boolean testeInserir = u.inserirUsuario(Nome, Sobrenome, User, Senha);
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

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {
            int id;
            string Nome = tb_UsuarioNome.Text;
            string Sobrenome = tb_UsuarioSobrenome.Text;
            string User = tb_userAcesso.Text;
            string Senha = tb_senhaAcesso.Text;

            try
            {
                id = Convert.ToInt32(tb_idUsuario.Text);

                if (Nome.Trim().Equals("") || Sobrenome.Trim().Equals("") || User.Trim().Equals(""))
                {
                    MessageBox.Show("Preencha os campos corretamente", "ERRO");
                }
                else
                {
                    Boolean testeEditar = u.editarUsuario(id, Nome, Sobrenome, User);
                    if (testeEditar)
                    {
                        dtgv_usuarios.DataSource = u.getUsuarios();
                        MessageBox.Show("Usuário editado com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Falha na edição");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de Identificação");
            }

        }

        //Função de seleção dos dados da tabela para as caixas de texto
        private void dtgv_usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tb_idUsuario.Text = dtgv_usuarios.CurrentRow.Cells[0].Value.ToString();
            tb_UsuarioNome.Text = dtgv_usuarios.CurrentRow.Cells[1].Value.ToString();
            tb_UsuarioSobrenome.Text = dtgv_usuarios.CurrentRow.Cells[2].Value.ToString();
            tb_userAcesso.Text = dtgv_usuarios.CurrentRow.Cells[3].Value.ToString();
          //  tb_senhaAcesso.Text = dtgv_usuarios.CurrentRow.Cells[4].Value.ToString();
        }

        private void btn_RemoverUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_idUsuario.Text);

                if (u.removerUsuario(id))
                {
                    dtgv_usuarios.DataSource = u.getUsuarios();
                    MessageBox.Show("Usuário foi removido com sucesso");

                    //btn.PerformClick();
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir o usuário");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de Identificação");
            }
        }

        private void btn_LimparCamposUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
