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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if(tb_usuario.Text == "bill" && tb_senha.Text == "bill")
            {
                Form_Menu form_Menu = new Form_Menu();
                form_Menu.ShowDialog();
            }
        }
    }
}
