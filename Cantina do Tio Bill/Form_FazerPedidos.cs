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
        private int cont = 0;
        private ItensDoPedido i = new ItensDoPedido();

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
            string n = cbbx_TiposQuentinhas.Text;
            // id_quentinha = id;
            //id++;
            tabela_ver_quentinha.DataSource = p.retornaIngredientes(n);
            // tb_Total.Text = id.ToString();
        }

        decimal CalculaPedido(List<Quentinha> listaQuentinha)
        {
            decimal valor = 0;

            foreach (var quentinha in listaQuentinha)
                valor += quentinha.valor;

            if (listaQuentinha.Count > 4)
                valor += (2.5m * valor / 100);

            return valor;
        }

        private void btn_AdicionarQuentinha_Click(object sender, EventArgs e)
        {
            i.IdClient = int.Parse(tb_CodCliente.Text);
            Quentinha qtnha = new Quentinha();
            qtnha.id = int.Parse(tabela_pedido.CurrentRow.Cells[0].Value.ToString());
            qtnha.Nome = cbbx_TiposQuentinhas.Text;
            qtnha.OpCarne = tabela_pedido.CurrentRow.Cells[1].Value.ToString();
            qtnha.ingre1 = tabela_pedido.CurrentRow.Cells[2].Value.ToString();
            qtnha.ingre2 = tabela_pedido.CurrentRow.Cells[3].Value.ToString();
            qtnha.ingre3 = tabela_pedido.CurrentRow.Cells[4].Value.ToString();
            qtnha.ingre4 = tabela_pedido.CurrentRow.Cells[5].Value.ToString();
            qtnha.ingre5 = tabela_pedido.CurrentRow.Cells[6].Value.ToString();
            qtnha.valor = decimal.Parse(tabela_pedido.CurrentRow.Cells[7].Value.ToString());

            i.addQuentinhaList(qtnha);
        }
    }
}
