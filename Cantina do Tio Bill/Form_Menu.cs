﻿using System;
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
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void gerenciarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_GerenciarCliente form_GerenciarCliente = new Form_GerenciarCliente();
            form_GerenciarCliente.ShowDialog();
        }
    }
}
