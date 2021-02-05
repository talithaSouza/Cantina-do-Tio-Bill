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
    }
}
