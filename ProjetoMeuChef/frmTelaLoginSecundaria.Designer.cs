namespace ProjetoMeuChef
{
    partial class frmTelaLoginSecundaria
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaLoginSecundaria));
            this.pnlImagemInicial = new System.Windows.Forms.Panel();
            this.pbImagemInicial = new System.Windows.Forms.PictureBox();
            this.btnEntreAqui = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtNomeFuncionario = new System.Windows.Forms.TextBox();
            this.txtSenhaFuncionario = new System.Windows.Forms.TextBox();
            this.cbFuncionarios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlImagemInicial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlImagemInicial
            // 
            this.pnlImagemInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.pnlImagemInicial.Controls.Add(this.pbImagemInicial);
            this.pnlImagemInicial.Location = new System.Drawing.Point(0, 0);
            this.pnlImagemInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlImagemInicial.Name = "pnlImagemInicial";
            this.pnlImagemInicial.Size = new System.Drawing.Size(237, 332);
            this.pnlImagemInicial.TabIndex = 1;
            // 
            // pbImagemInicial
            // 
            this.pbImagemInicial.BackColor = System.Drawing.Color.Transparent;
            this.pbImagemInicial.Image = global::ProjetoMeuChef.Properties.Resources.chef2;
            this.pbImagemInicial.Location = new System.Drawing.Point(-36, 0);
            this.pbImagemInicial.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImagemInicial.Name = "pbImagemInicial";
            this.pbImagemInicial.Size = new System.Drawing.Size(273, 349);
            this.pbImagemInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemInicial.TabIndex = 0;
            this.pbImagemInicial.TabStop = false;
            // 
            // btnEntreAqui
            // 
            this.btnEntreAqui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnEntreAqui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntreAqui.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnEntreAqui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntreAqui.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntreAqui.ForeColor = System.Drawing.Color.White;
            this.btnEntreAqui.Location = new System.Drawing.Point(401, 246);
            this.btnEntreAqui.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEntreAqui.Name = "btnEntreAqui";
            this.btnEntreAqui.Size = new System.Drawing.Size(214, 46);
            this.btnEntreAqui.TabIndex = 4;
            this.btnEntreAqui.Text = "Entre aqui!";
            this.btnEntreAqui.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntreAqui.UseVisualStyleBackColor = false;
            this.btnEntreAqui.Click += new System.EventHandler(this.btnEntreAqui_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(13)))), ((int)(((byte)(13)))));
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.White;
            this.btnSair.Location = new System.Drawing.Point(267, 246);
            this.btnSair.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(126, 46);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtNomeFuncionario
            // 
            this.txtNomeFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeFuncionario.Location = new System.Drawing.Point(267, 39);
            this.txtNomeFuncionario.Name = "txtNomeFuncionario";
            this.txtNomeFuncionario.Size = new System.Drawing.Size(348, 35);
            this.txtNomeFuncionario.TabIndex = 6;
            // 
            // txtSenhaFuncionario
            // 
            this.txtSenhaFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenhaFuncionario.Location = new System.Drawing.Point(267, 117);
            this.txtSenhaFuncionario.Name = "txtSenhaFuncionario";
            this.txtSenhaFuncionario.Size = new System.Drawing.Size(348, 35);
            this.txtSenhaFuncionario.TabIndex = 7;
            // 
            // cbFuncionarios
            // 
            this.cbFuncionarios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFuncionarios.FormattingEnabled = true;
            this.cbFuncionarios.Items.AddRange(new object[] {
            "",
            "Ajudante",
            "Cozinheiro I",
            "Cozinheiro II"});
            this.cbFuncionarios.Location = new System.Drawing.Point(267, 192);
            this.cbFuncionarios.Name = "cbFuncionarios";
            this.cbFuncionarios.Size = new System.Drawing.Size(348, 35);
            this.cbFuncionarios.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(263, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome do funcionario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(263, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Senha do funcionario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(263, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Função:";
            // 
            // frmTelaLoginSecundaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(645, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbFuncionarios);
            this.Controls.Add(this.txtSenhaFuncionario);
            this.Controls.Add(this.txtNomeFuncionario);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntreAqui);
            this.Controls.Add(this.pnlImagemInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTelaLoginSecundaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Chef - Gerenciador de Receitas";
            this.pnlImagemInicial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImagemInicial;
        private System.Windows.Forms.Panel pnlImagemInicial;
        private System.Windows.Forms.Button btnEntreAqui;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtNomeFuncionario;
        private System.Windows.Forms.TextBox txtSenhaFuncionario;
        private System.Windows.Forms.ComboBox cbFuncionarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

