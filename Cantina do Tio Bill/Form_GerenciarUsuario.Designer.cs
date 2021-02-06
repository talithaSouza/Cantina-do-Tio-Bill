
namespace Cantina_do_Tio_Bill
{
    partial class Form_GerenciarUsuario
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
            this.btn_RemoverUsuario = new System.Windows.Forms.Button();
            this.btn_LimparCamposCliente = new System.Windows.Forms.Button();
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.btn_AddUsuario = new System.Windows.Forms.Button();
            this.dtgv_usuarios = new System.Windows.Forms.DataGridView();
            this.tb_UsuarioNome = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_UsuarioSobrenome = new System.Windows.Forms.TextBox();
            this.tb_ClienteTelefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_senhaAcesso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_userAcesso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_usuarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_RemoverUsuario
            // 
            this.btn_RemoverUsuario.Location = new System.Drawing.Point(269, 419);
            this.btn_RemoverUsuario.Name = "btn_RemoverUsuario";
            this.btn_RemoverUsuario.Size = new System.Drawing.Size(75, 44);
            this.btn_RemoverUsuario.TabIndex = 20;
            this.btn_RemoverUsuario.Text = "Remover";
            this.btn_RemoverUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_LimparCamposCliente
            // 
            this.btn_LimparCamposCliente.Location = new System.Drawing.Point(12, 484);
            this.btn_LimparCamposCliente.Name = "btn_LimparCamposCliente";
            this.btn_LimparCamposCliente.Size = new System.Drawing.Size(333, 23);
            this.btn_LimparCamposCliente.TabIndex = 19;
            this.btn_LimparCamposCliente.Text = "Limpar Campos";
            this.btn_LimparCamposCliente.UseVisualStyleBackColor = true;
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditarUsuario.Location = new System.Drawing.Point(170, 419);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(75, 44);
            this.btn_EditarUsuario.TabIndex = 18;
            this.btn_EditarUsuario.Text = "Editar";
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            // 
            // btn_AddUsuario
            // 
            this.btn_AddUsuario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_AddUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddUsuario.Location = new System.Drawing.Point(12, 419);
            this.btn_AddUsuario.Name = "btn_AddUsuario";
            this.btn_AddUsuario.Size = new System.Drawing.Size(134, 44);
            this.btn_AddUsuario.TabIndex = 17;
            this.btn_AddUsuario.Text = "Adicionar novo usuário";
            this.btn_AddUsuario.UseVisualStyleBackColor = true;
            this.btn_AddUsuario.Click += new System.EventHandler(this.btn_AddUsuario_Click);
            // 
            // dtgv_usuarios
            // 
            this.dtgv_usuarios.AllowUserToAddRows = false;
            this.dtgv_usuarios.AllowUserToDeleteRows = false;
            this.dtgv_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_usuarios.Location = new System.Drawing.Point(439, 95);
            this.dtgv_usuarios.Name = "dtgv_usuarios";
            this.dtgv_usuarios.ReadOnly = true;
            this.dtgv_usuarios.Size = new System.Drawing.Size(420, 368);
            this.dtgv_usuarios.TabIndex = 16;
            // 
            // tb_UsuarioNome
            // 
            this.tb_UsuarioNome.Location = new System.Drawing.Point(133, 60);
            this.tb_UsuarioNome.Name = "tb_UsuarioNome";
            this.tb_UsuarioNome.Size = new System.Drawing.Size(179, 20);
            this.tb_UsuarioNome.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nome:";
            // 
            // tb_UsuarioSobrenome
            // 
            this.tb_UsuarioSobrenome.Location = new System.Drawing.Point(133, 102);
            this.tb_UsuarioSobrenome.Name = "tb_UsuarioSobrenome";
            this.tb_UsuarioSobrenome.Size = new System.Drawing.Size(179, 20);
            this.tb_UsuarioSobrenome.TabIndex = 2;
            // 
            // tb_ClienteTelefone
            // 
            this.tb_ClienteTelefone.Location = new System.Drawing.Point(133, 136);
            this.tb_ClienteTelefone.Name = "tb_ClienteTelefone";
            this.tb_ClienteTelefone.Size = new System.Drawing.Size(179, 20);
            this.tb_ClienteTelefone.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Sobrenome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Telefone:";
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
            this.label1.Text = "Gerenciar Usuário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.panel1.Controls.Add(this.btn_RemoverUsuario);
            this.panel1.Controls.Add(this.btn_LimparCamposCliente);
            this.panel1.Controls.Add(this.btn_EditarUsuario);
            this.panel1.Controls.Add(this.btn_AddUsuario);
            this.panel1.Controls.Add(this.dtgv_usuarios);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(862, 583);
            this.panel1.TabIndex = 1;
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
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.tb_senhaAcesso);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.tb_userAcesso);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_ClienteTelefone);
            this.panel3.Controls.Add(this.tb_UsuarioNome);
            this.panel3.Controls.Add(this.tb_UsuarioSobrenome);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(12, 84);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 306);
            this.panel3.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(347, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "--";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 25);
            this.label4.TabIndex = 15;
            this.label4.Text = "Senha:";
            // 
            // tb_senhaAcesso
            // 
            this.tb_senhaAcesso.Location = new System.Drawing.Point(133, 213);
            this.tb_senhaAcesso.Name = "tb_senhaAcesso";
            this.tb_senhaAcesso.Size = new System.Drawing.Size(179, 20);
            this.tb_senhaAcesso.TabIndex = 6;
            this.tb_senhaAcesso.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Usuario:";
            // 
            // tb_userAcesso
            // 
            this.tb_userAcesso.Location = new System.Drawing.Point(133, 173);
            this.tb_userAcesso.Name = "tb_userAcesso";
            this.tb_userAcesso.Size = new System.Drawing.Size(179, 20);
            this.tb_userAcesso.TabIndex = 5;
            this.tb_userAcesso.Click += new System.EventHandler(this.textBox1_Click);
            // 
            // Form_GerenciarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 583);
            this.Controls.Add(this.panel1);
            this.Name = "Form_GerenciarUsuario";
            this.Text = "Form_GerenciarUsuario";
            this.Load += new System.EventHandler(this.Form_GerenciarUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_usuarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_RemoverUsuario;
        private System.Windows.Forms.Button btn_LimparCamposCliente;
        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.Button btn_AddUsuario;
        private System.Windows.Forms.DataGridView dtgv_usuarios;
        private System.Windows.Forms.TextBox tb_UsuarioNome;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_UsuarioSobrenome;
        private System.Windows.Forms.TextBox tb_ClienteTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_senhaAcesso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_userAcesso;
        private System.Windows.Forms.Label label8;
    }
}