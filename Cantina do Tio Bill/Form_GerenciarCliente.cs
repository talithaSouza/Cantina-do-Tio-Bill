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

        private void btn_LimparCamposCliente_Click(object sender, EventArgs e)
        {
                 tb_ClienteNome.Text = "";
            tb_ClienteSobrenome.Text = "";
             tb_ClienteTelefone.Text = "";
                      tb_Bairro.Text = "";
                         tb_Rua.Text = "";
                 tb_NumEndereco.Text = "";
                  tb_RefeEndeco.Text = "";
        }

        private void btn_AdcCliente_Click(object sender, EventArgs e)
        {
                 string nome = tb_ClienteNome.Text;
            string sobrenome = tb_ClienteSobrenome.Text;
             string telefone = tb_ClienteTelefone.Text;

            Boolean TesteInserirCliente = cliente.InserirCliente(nome,sobrenome,telefone);

            if (TesteInserirCliente)
            {
                MessageBox.Show("Cliente Adicionado com sucesso");
            }

        }

        private void Form_GerenciarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
