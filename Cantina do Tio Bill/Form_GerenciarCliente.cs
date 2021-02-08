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
    public partial class Form_GerenciarCliente : Form
    {
        Cliente cliente = new Cliente();
        public Form_GerenciarCliente()
        {
            InitializeComponent();
        }
        //Carregar informações da tabela
        private void Form_GerenciarCliente_Load(object sender, EventArgs e)
        {
            dataGridViewClientes.DataSource = cliente.getClientes();
        }

        private void btn_LimparCamposCliente_Click(object sender, EventArgs e)
        {
            tb_ClienteNome.Text = "";
            tb_ClienteSobrenome.Text = "";
            tb_ClienteTelefone.Text = "";
            tb_Bairro.Text = "";
            tb_Rua.Text = "";
            tb_NumEndereco.Text = "";
            
        }

        private void btn_AdcCliente_Click(object sender, EventArgs e)
        {
            string nome = tb_ClienteNome.Text;
            string sobrenome = tb_ClienteSobrenome.Text;
            string telefone = tb_ClienteTelefone.Text;
            string bairro = tb_Bairro.Text;
            string rua = tb_Rua.Text;
            int num = int.Parse(tb_NumEndereco.Text);

            Boolean TesteInserirCliente = cliente.InserirCliente(nome, sobrenome, telefone,bairro,rua,num);

            if (TesteInserirCliente)
            {
                dataGridViewClientes.DataSource = cliente.getClientes();
                MessageBox.Show("Cliente Adicionado com sucesso");
                btn_LimparCamposCliente.PerformClick();
            }

        }

        //Selecionar um campo da tabela
        private void dataGridViewClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tb_IdCliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
            tb_ClienteNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            tb_ClienteSobrenome.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            tb_ClienteTelefone.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
            tb_Bairro.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();
            tb_Rua.Text = dataGridViewClientes.CurrentRow.Cells[5].Value.ToString();
            tb_NumEndereco.Text = dataGridViewClientes.CurrentRow.Cells[6].Value.ToString();
        }

        private void btn_EditarCliente_Click_1(object sender, EventArgs e)
        {
            int id;
            string Nome = tb_ClienteNome.Text;
            string Sobrenome = tb_ClienteSobrenome.Text;
            string Telefone = tb_ClienteTelefone.Text;
            string Bairro = tb_Bairro.Text;
            string rua = tb_Rua.Text;
            int num = int.Parse(tb_NumEndereco.Text);

            try
            {
                id = Convert.ToInt32(tb_IdCliente.Text);

                if (Nome.Trim().Equals("") || Sobrenome.Trim().Equals(""))
                {
                    MessageBox.Show("Preencha os campos corretamente", "ERRO");
                }
                else
                {
                    Boolean testeEditar = cliente.editarCliente(id, Nome, Sobrenome, Telefone, Bairro, rua, num);
                    if (testeEditar)
                    {
                        dataGridViewClientes.DataSource = cliente.getClientes();
                        MessageBox.Show("Cliente editado com sucesso");
                        btn_LimparCamposCliente.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Falha na edição");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de Identificação");
            }

        }

        private void btn_RemoverCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_IdCliente.Text);

                if (cliente.removerCliente(id))
                {
                    dataGridViewClientes.DataSource = cliente.getClientes();
                    MessageBox.Show("Cliente foi removido com sucesso");

                    btn_LimparCamposCliente.PerformClick();
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir o cliente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro de Identificação");
            }
        }
    }
}
