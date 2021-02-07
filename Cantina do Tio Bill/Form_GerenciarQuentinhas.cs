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
    public partial class Form_GerenciarQuentinhas : Form
    {
        Quentinha q = new Quentinha();
        public Form_GerenciarQuentinhas()
        {
            InitializeComponent();
        }

        private void btn_LimparCamposUsuario_Click(object sender, EventArgs e)
        {
            tb_QuentinhaNome.Text = "";
            tb_QuentinhaOpCarne.Text = "";
            tb_QuentinhaIngrediente1.Text = "";
            tb_QuentinhaIngrediente2.Text = "";
            tb_QuentinhaIngrediente3.Text = "";
            tb_QuentinhaIngrediente4.Text = "";
            tb_QuentinhaIngrediente5.Text = "";
            tb_ValorQuentinha.Text = "";

        }

        private void Form_GerenciarQuentinhas_Load(object sender, EventArgs e)
        {
            dataGridVQuentinha.DataSource = q.getQuentinhas();
        }


        private void btn_AddQuentinha_Click_1(object sender, EventArgs e)
        {
            string nome = tb_QuentinhaNome.Text;
            string opcarne = tb_QuentinhaOpCarne.Text;
            string ingr1 = tb_QuentinhaIngrediente1.Text;
            string ingr2 = tb_QuentinhaIngrediente2.Text;
            string ingr3 = tb_QuentinhaIngrediente3.Text;
            string ingr4 = tb_QuentinhaIngrediente4.Text;
            string ingr5 = tb_QuentinhaIngrediente5.Text;
            double valor = double.Parse(tb_ValorQuentinha.Text);

            Boolean TesteInserirNovaQuentinha = q.InserirNovaQuentinha(nome, opcarne, ingr1, ingr2, ingr3, ingr4, ingr5, valor);

            if (TesteInserirNovaQuentinha)
            {
                dataGridVQuentinha.DataSource = q.getQuentinhas();
                MessageBox.Show("Nova opção de quentinha foi adicionado com sucesso");
                btn_LimparCamposQuentinha.PerformClick();

            }
        }

        private void btn_EditarQuentinha_Click(object sender, EventArgs e)
        {
            int id;
            string nome = tb_QuentinhaNome.Text;
            string opcarne = tb_QuentinhaOpCarne.Text;
            string ingr1 = tb_QuentinhaIngrediente1.Text;
            string ingr2 = tb_QuentinhaIngrediente2.Text;
            string ingr3 = tb_QuentinhaIngrediente3.Text;
            string ingr4 = tb_QuentinhaIngrediente4.Text;
            string ingr5 = tb_QuentinhaIngrediente5.Text;
            double valor = double.Parse(tb_ValorQuentinha.Text);
           /*
            try
            {
                valor = double.Parse(tb_ValorQuentinha.Text);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Errro");
            }
           */
            

            try
            {
                id = Convert.ToInt32(tb_idQuentinha.Text);

                if (nome.Trim().Equals("") || opcarne.Trim().Equals("") || ingr1.Trim().Equals("") || ingr2.Trim().Equals("") || ingr3.Trim().Equals("")
                    || ingr4.Trim().Equals("") || ingr5.Trim().Equals("")  || valor == 0)
                {
                    MessageBox.Show("Preencha os campos corretamente", "ERRO");
                }
                else
                {
                    Boolean testeEditar = q.editarQuentinha(id,nome, opcarne, ingr1, ingr2, ingr3, ingr4, ingr5, valor);
                    if (testeEditar)
                    {
                        dataGridVQuentinha.DataSource = q.getQuentinhas();
                        MessageBox.Show("Quentinha editada com sucesso");
                        btn_LimparCamposQuentinha.PerformClick();
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

        private void dataGridVQuentinha_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            /*
             * tb_IdCliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
            tb_ClienteNome.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            tb_ClienteSobrenome.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            tb_ClienteTelefone.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
             */
            tb_idQuentinha.Text = dataGridVQuentinha.CurrentRow.Cells[0].Value.ToString();
            tb_QuentinhaNome.Text = dataGridVQuentinha.CurrentRow.Cells[1].Value.ToString();
            tb_QuentinhaOpCarne.Text = dataGridVQuentinha.CurrentRow.Cells[2].Value.ToString();
            tb_QuentinhaIngrediente1.Text = dataGridVQuentinha.CurrentRow.Cells[3].Value.ToString();
            tb_QuentinhaIngrediente2.Text = dataGridVQuentinha.CurrentRow.Cells[4].Value.ToString();
            tb_QuentinhaIngrediente3.Text = dataGridVQuentinha.CurrentRow.Cells[5].Value.ToString();
            tb_QuentinhaIngrediente4.Text = dataGridVQuentinha.CurrentRow.Cells[6].Value.ToString();
            tb_QuentinhaIngrediente5.Text = dataGridVQuentinha.CurrentRow.Cells[7].Value.ToString();
            tb_ValorQuentinha.Text = dataGridVQuentinha.CurrentRow.Cells[8].Value.ToString();
            //tb_ValorQuentinha.Text = dataGridVQuentinha.CurrentRow.Cells[8].Value.ToString();

        }

        private void btn_RemoverQuentinha_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tb_idQuentinha.Text);

                if (q.removerQuentinha(id))
                {
                    dataGridVQuentinha.DataSource = q.getQuentinhas();
                    MessageBox.Show("Cliente foi removido com sucesso");

                    btn_LimparCamposQuentinha.PerformClick();
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
