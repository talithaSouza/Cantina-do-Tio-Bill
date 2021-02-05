
namespace Cantina_do_Tio_Bill
{
    partial class Form_GerenciarCliente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_RemoverCliente = new System.Windows.Forms.Button();
            this.btn_LimparCamposCliente = new System.Windows.Forms.Button();
            this.btn_EditarCliente = new System.Windows.Forms.Button();
            this.btn_AdcCliente = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tb_ClienteNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_ClienteSobrenome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_ClienteTelefone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_IdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_RefeEndeco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_NumEndereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Rua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Bairro = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btn_RemoverCliente);
            this.panel1.Controls.Add(this.btn_LimparCamposCliente);
            this.panel1.Controls.Add(this.btn_EditarCliente);
            this.panel1.Controls.Add(this.btn_AdcCliente);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.tb_ClienteNome);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.tb_ClienteSobrenome);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.tb_ClienteTelefone);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.tb_IdCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(864, 560);
            this.panel1.TabIndex = 0;
            // 
            // btn_RemoverCliente
            // 
            this.btn_RemoverCliente.Location = new System.Drawing.Point(269, 329);
            this.btn_RemoverCliente.Name = "btn_RemoverCliente";
            this.btn_RemoverCliente.Size = new System.Drawing.Size(75, 32);
            this.btn_RemoverCliente.TabIndex = 20;
            this.btn_RemoverCliente.Text = "Remover";
            this.btn_RemoverCliente.UseVisualStyleBackColor = true;
            // 
            // btn_LimparCamposCliente
            // 
            this.btn_LimparCamposCliente.Location = new System.Drawing.Point(12, 394);
            this.btn_LimparCamposCliente.Name = "btn_LimparCamposCliente";
            this.btn_LimparCamposCliente.Size = new System.Drawing.Size(333, 23);
            this.btn_LimparCamposCliente.TabIndex = 19;
            this.btn_LimparCamposCliente.Text = "Limpar Campos";
            this.btn_LimparCamposCliente.UseVisualStyleBackColor = true;
            this.btn_LimparCamposCliente.Click += new System.EventHandler(this.btn_LimparCamposCliente_Click);
            // 
            // btn_EditarCliente
            // 
            this.btn_EditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarCliente.Location = new System.Drawing.Point(170, 329);
            this.btn_EditarCliente.Name = "btn_EditarCliente";
            this.btn_EditarCliente.Size = new System.Drawing.Size(75, 32);
            this.btn_EditarCliente.TabIndex = 18;
            this.btn_EditarCliente.Text = "Editar";
            this.btn_EditarCliente.UseVisualStyleBackColor = true;
            // 
            // btn_AdcCliente
            // 
            this.btn_AdcCliente.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_AdcCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AdcCliente.Location = new System.Drawing.Point(12, 329);
            this.btn_AdcCliente.Name = "btn_AdcCliente";
            this.btn_AdcCliente.Size = new System.Drawing.Size(134, 32);
            this.btn_AdcCliente.TabIndex = 17;
            this.btn_AdcCliente.Text = "Adicionar Cliente";
            this.btn_AdcCliente.UseVisualStyleBackColor = true;
            this.btn_AdcCliente.Click += new System.EventHandler(this.btn_AdcCliente_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(437, 329);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(391, 219);
            this.dataGridView1.TabIndex = 16;
            // 
            // tb_ClienteNome
            // 
            this.tb_ClienteNome.Location = new System.Drawing.Point(150, 148);
            this.tb_ClienteNome.Name = "tb_ClienteNome";
            this.tb_ClienteNome.Size = new System.Drawing.Size(179, 20);
            this.tb_ClienteNome.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome:";
            // 
            // tb_ClienteSobrenome
            // 
            this.tb_ClienteSobrenome.Location = new System.Drawing.Point(150, 190);
            this.tb_ClienteSobrenome.Name = "tb_ClienteSobrenome";
            this.tb_ClienteSobrenome.Size = new System.Drawing.Size(179, 20);
            this.tb_ClienteSobrenome.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sobrenome:";
            // 
            // tb_ClienteTelefone
            // 
            this.tb_ClienteTelefone.Location = new System.Drawing.Point(150, 237);
            this.tb_ClienteTelefone.Name = "tb_ClienteTelefone";
            this.tb_ClienteTelefone.Size = new System.Drawing.Size(179, 20);
            this.tb_ClienteTelefone.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(44, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefone:";
            // 
            // tb_IdCliente
            // 
            this.tb_IdCliente.Enabled = false;
            this.tb_IdCliente.Location = new System.Drawing.Point(150, 109);
            this.tb_IdCliente.Name = "tb_IdCliente";
            this.tb_IdCliente.Size = new System.Drawing.Size(54, 20);
            this.tb_IdCliente.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(861, 68);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(861, 68);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciar Clientes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(10, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 230);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tb_RefeEndeco);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tb_NumEndereco);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tb_Rua);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tb_Bairro);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(437, 84);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(391, 230);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço do cliente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 9;
            this.label9.Text = "Referencia:";
            // 
            // tb_RefeEndeco
            // 
            this.tb_RefeEndeco.Location = new System.Drawing.Point(140, 126);
            this.tb_RefeEndeco.Name = "tb_RefeEndeco";
            this.tb_RefeEndeco.Size = new System.Drawing.Size(215, 26);
            this.tb_RefeEndeco.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(264, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nº:";
            // 
            // tb_NumEndereco
            // 
            this.tb_NumEndereco.Location = new System.Drawing.Point(311, 79);
            this.tb_NumEndereco.Name = "tb_NumEndereco";
            this.tb_NumEndereco.Size = new System.Drawing.Size(59, 26);
            this.tb_NumEndereco.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Rua:";
            // 
            // tb_Rua
            // 
            this.tb_Rua.Location = new System.Drawing.Point(83, 78);
            this.tb_Rua.Name = "tb_Rua";
            this.tb_Rua.Size = new System.Drawing.Size(175, 26);
            this.tb_Rua.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bairro:";
            // 
            // tb_Bairro
            // 
            this.tb_Bairro.Location = new System.Drawing.Point(83, 40);
            this.tb_Bairro.Name = "tb_Bairro";
            this.tb_Bairro.Size = new System.Drawing.Size(215, 26);
            this.tb_Bairro.TabIndex = 4;
            // 
            // Form_GerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 560);
            this.Controls.Add(this.panel1);
            this.Name = "Form_GerenciarCliente";
            this.Text = "Form_GerenciarCliente";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tb_ClienteNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_ClienteSobrenome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_ClienteTelefone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_IdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_RefeEndeco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_NumEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Rua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Bairro;
        private System.Windows.Forms.Button btn_RemoverCliente;
        private System.Windows.Forms.Button btn_LimparCamposCliente;
        private System.Windows.Forms.Button btn_EditarCliente;
        private System.Windows.Forms.Button btn_AdcCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}