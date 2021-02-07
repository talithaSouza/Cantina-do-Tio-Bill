
namespace Cantina_do_Tio_Bill
{
    partial class Form_FazerPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_CadatrarPedido = new System.Windows.Forms.Button();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbx_TiposQuentinhas = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewListaIngredientes = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaIngredientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(941, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quentinhas do Tio Bill";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.CadetBlue;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(941, 68);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cantina_do_Tio_Bill.Properties.Resources.comida;
            this.pictureBox1.Location = new System.Drawing.Point(685, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Codigo Cliente:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(143, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(77, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Edwardian Script ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(264, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 76);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cadastre o pedido";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.btn_CadatrarPedido);
            this.panel1.Controls.Add(this.tb_quantidade);
            this.panel1.Controls.Add(this.tb_Total);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbbx_TiposQuentinhas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(388, 318);
            this.panel1.TabIndex = 5;
            // 
            // btn_CadatrarPedido
            // 
            this.btn_CadatrarPedido.Location = new System.Drawing.Point(20, 256);
            this.btn_CadatrarPedido.Name = "btn_CadatrarPedido";
            this.btn_CadatrarPedido.Size = new System.Drawing.Size(149, 23);
            this.btn_CadatrarPedido.TabIndex = 11;
            this.btn_CadatrarPedido.Text = "Cadastrar Novo Pedido";
            this.btn_CadatrarPedido.UseVisualStyleBackColor = true;
            this.btn_CadatrarPedido.Click += new System.EventHandler(this.btn_CadatrarPedido_Click);
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.Location = new System.Drawing.Point(143, 133);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(60, 20);
            this.tb_quantidade.TabIndex = 10;
            this.tb_quantidade.Text = "1";
            this.tb_quantidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(143, 176);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.ReadOnly = true;
            this.tb_Total.Size = new System.Drawing.Size(77, 20);
            this.tb_Total.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(62, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Total R$:";
            // 
            // cbbx_TiposQuentinhas
            // 
            this.cbbx_TiposQuentinhas.FormattingEnabled = true;
            this.cbbx_TiposQuentinhas.Location = new System.Drawing.Point(143, 95);
            this.cbbx_TiposQuentinhas.Name = "cbbx_TiposQuentinhas";
            this.cbbx_TiposQuentinhas.Size = new System.Drawing.Size(143, 21);
            this.cbbx_TiposQuentinhas.TabIndex = 7;
            this.cbbx_TiposQuentinhas.Text = "-----";
            this.cbbx_TiposQuentinhas.SelectedIndexChanged += new System.EventHandler(this.cbbx_TiposQuentinhas_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Quentinha:";
            // 
            // dataGridViewListaIngredientes
            // 
            this.dataGridViewListaIngredientes.AllowUserToAddRows = false;
            this.dataGridViewListaIngredientes.AllowUserToDeleteRows = false;
            this.dataGridViewListaIngredientes.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewListaIngredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListaIngredientes.GridColor = System.Drawing.Color.Black;
            this.dataGridViewListaIngredientes.Location = new System.Drawing.Point(430, 148);
            this.dataGridViewListaIngredientes.Name = "dataGridViewListaIngredientes";
            this.dataGridViewListaIngredientes.ReadOnly = true;
            this.dataGridViewListaIngredientes.Size = new System.Drawing.Size(499, 315);
            this.dataGridViewListaIngredientes.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Ir para tela de pedidos >>>>";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Finalizar Pedido";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form_FazerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::Cantina_do_Tio_Bill.Properties.Resources.pratoCoração;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(941, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewListaIngredientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "Form_FazerPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_FazerPedidos";
            this.Load += new System.EventHandler(this.Form_FazerPedidos_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListaIngredientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbbx_TiposQuentinhas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_CadatrarPedido;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.DataGridView dataGridViewListaIngredientes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}