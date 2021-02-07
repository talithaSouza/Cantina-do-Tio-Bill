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
    public partial class Form_FazerPedidos : Form
    {
        private int id_quentinha;

        public Form_FazerPedidos()
        {
            InitializeComponent();
        }
        Pedidos p = new Pedidos();
        private void Form_FazerPedidos_Load(object sender, EventArgs e)
        {
            cbbx_TiposQuentinhas.DataSource = p.QuentinhasList();
            cbbx_TiposQuentinhas.DisplayMember = "nome";
            cbbx_TiposQuentinhas.ValueMember = "id";
        }




        private void cbbx_TiposQuentinhas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = (int)cbbx_TiposQuentinhas.SelectedIndex;
            id_quentinha = id;
            id++;
            dataGridViewListaIngredientes.DataSource = p.retornaIngredientes(id);
            tb_Total.Text = id.ToString();
        }

        private void btn_CadatrarPedido_Click(object sender, EventArgs e)
        {
            int quantidade;

            if (!int.TryParse(tb_quantidade.Text, out quantidade))
            {
                MessageBox.Show("Digite apenas numero", "Erro na quantidade");
                return;
            }

            if (quantidade <= 0)
            {
                MessageBox.Show("Quantidade invalida", "Erro na quantidade");
                return;
            }

            p.addPedidoList(id_quentinha);

        }
    }
}
