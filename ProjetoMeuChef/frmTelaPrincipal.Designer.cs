namespace ProjetoMeuChef
{
    partial class frmTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTelaPrincipal));
            this.tlpGeral = new System.Windows.Forms.TableLayoutPanel();
            this.gbDadosGerais = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesoFinal = new System.Windows.Forms.TextBox();
            this.lblPesoFinal = new System.Windows.Forms.Label();
            this.txtObservacoes = new System.Windows.Forms.TextBox();
            this.lblObservacoes = new System.Windows.Forms.Label();
            this.txtModoPreparo = new System.Windows.Forms.TextBox();
            this.lblModoPreparo = new System.Windows.Forms.Label();
            this.txtIngredientes = new System.Windows.Forms.TextBox();
            this.lblIngredientes = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.gbBuscar = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.rbObservacao = new System.Windows.Forms.RadioButton();
            this.rbNome = new System.Windows.Forms.RadioButton();
            this.gbGradeDados = new System.Windows.Forms.GroupBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.lblGradeReceitas = new System.Windows.Forms.Label();
            this.dgvReceitas = new System.Windows.Forms.DataGridView();
            this.btnLimpaBusca = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.tlpGeral.SuspendLayout();
            this.gbDadosGerais.SuspendLayout();
            this.gbBuscar.SuspendLayout();
            this.gbGradeDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpGeral
            // 
            this.tlpGeral.ColumnCount = 2;
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeral.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeral.Controls.Add(this.gbDadosGerais, 0, 0);
            this.tlpGeral.Controls.Add(this.gbGradeDados, 1, 0);
            this.tlpGeral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpGeral.Location = new System.Drawing.Point(0, 0);
            this.tlpGeral.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tlpGeral.Name = "tlpGeral";
            this.tlpGeral.RowCount = 1;
            this.tlpGeral.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGeral.Size = new System.Drawing.Size(1200, 692);
            this.tlpGeral.TabIndex = 0;
            // 
            // gbDadosGerais
            // 
            this.gbDadosGerais.Controls.Add(this.label1);
            this.gbDadosGerais.Controls.Add(this.txtPesoFinal);
            this.gbDadosGerais.Controls.Add(this.lblPesoFinal);
            this.gbDadosGerais.Controls.Add(this.txtObservacoes);
            this.gbDadosGerais.Controls.Add(this.lblObservacoes);
            this.gbDadosGerais.Controls.Add(this.txtModoPreparo);
            this.gbDadosGerais.Controls.Add(this.lblModoPreparo);
            this.gbDadosGerais.Controls.Add(this.txtIngredientes);
            this.gbDadosGerais.Controls.Add(this.lblIngredientes);
            this.gbDadosGerais.Controls.Add(this.txtDescricao);
            this.gbDadosGerais.Controls.Add(this.lblDescricao);
            this.gbDadosGerais.Controls.Add(this.txtNome);
            this.gbDadosGerais.Controls.Add(this.lblNome);
            this.gbDadosGerais.Controls.Add(this.lblBuscar);
            this.gbDadosGerais.Controls.Add(this.gbBuscar);
            this.gbDadosGerais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDadosGerais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDadosGerais.Location = new System.Drawing.Point(4, 5);
            this.gbDadosGerais.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDadosGerais.Name = "gbDadosGerais";
            this.gbDadosGerais.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbDadosGerais.Size = new System.Drawing.Size(592, 682);
            this.gbDadosGerais.TabIndex = 0;
            this.gbDadosGerais.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 620);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "*Preenchimento obrigatório!";
            // 
            // txtPesoFinal
            // 
            this.txtPesoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesoFinal.Location = new System.Drawing.Point(384, 575);
            this.txtPesoFinal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesoFinal.Name = "txtPesoFinal";
            this.txtPesoFinal.Size = new System.Drawing.Size(193, 35);
            this.txtPesoFinal.TabIndex = 14;
            // 
            // lblPesoFinal
            // 
            this.lblPesoFinal.AutoSize = true;
            this.lblPesoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoFinal.ForeColor = System.Drawing.Color.White;
            this.lblPesoFinal.Location = new System.Drawing.Point(378, 540);
            this.lblPesoFinal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPesoFinal.Name = "lblPesoFinal";
            this.lblPesoFinal.Size = new System.Drawing.Size(187, 29);
            this.lblPesoFinal.TabIndex = 13;
            this.lblPesoFinal.Text = "Peso final (Kg):*";
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.Location = new System.Drawing.Point(10, 575);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Size = new System.Drawing.Size(368, 35);
            this.txtObservacoes.TabIndex = 12;
            // 
            // lblObservacoes
            // 
            this.lblObservacoes.AutoSize = true;
            this.lblObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblObservacoes.ForeColor = System.Drawing.Color.White;
            this.lblObservacoes.Location = new System.Drawing.Point(6, 540);
            this.lblObservacoes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblObservacoes.Name = "lblObservacoes";
            this.lblObservacoes.Size = new System.Drawing.Size(162, 29);
            this.lblObservacoes.TabIndex = 11;
            this.lblObservacoes.Text = "Observações:";
            // 
            // txtModoPreparo
            // 
            this.txtModoPreparo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModoPreparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModoPreparo.Location = new System.Drawing.Point(10, 495);
            this.txtModoPreparo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModoPreparo.Name = "txtModoPreparo";
            this.txtModoPreparo.Size = new System.Drawing.Size(567, 35);
            this.txtModoPreparo.TabIndex = 10;
            // 
            // lblModoPreparo
            // 
            this.lblModoPreparo.AutoSize = true;
            this.lblModoPreparo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModoPreparo.ForeColor = System.Drawing.Color.White;
            this.lblModoPreparo.Location = new System.Drawing.Point(6, 460);
            this.lblModoPreparo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModoPreparo.Name = "lblModoPreparo";
            this.lblModoPreparo.Size = new System.Drawing.Size(216, 29);
            this.lblModoPreparo.TabIndex = 9;
            this.lblModoPreparo.Text = "Modo de preparo:*";
            // 
            // txtIngredientes
            // 
            this.txtIngredientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngredientes.Location = new System.Drawing.Point(10, 415);
            this.txtIngredientes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIngredientes.Name = "txtIngredientes";
            this.txtIngredientes.Size = new System.Drawing.Size(567, 35);
            this.txtIngredientes.TabIndex = 8;
            // 
            // lblIngredientes
            // 
            this.lblIngredientes.AutoSize = true;
            this.lblIngredientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngredientes.ForeColor = System.Drawing.Color.White;
            this.lblIngredientes.Location = new System.Drawing.Point(6, 380);
            this.lblIngredientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIngredientes.Name = "lblIngredientes";
            this.lblIngredientes.Size = new System.Drawing.Size(163, 29);
            this.lblIngredientes.TabIndex = 7;
            this.lblIngredientes.Text = "Ingredientes:*";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(10, 335);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(567, 35);
            this.txtDescricao.TabIndex = 6;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.ForeColor = System.Drawing.Color.White;
            this.lblDescricao.Location = new System.Drawing.Point(6, 300);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(249, 29);
            this.lblDescricao.TabIndex = 5;
            this.lblDescricao.Text = "Descrição da receita:*";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(10, 255);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(567, 35);
            this.txtNome.TabIndex = 4;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(6, 220);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(207, 29);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome da receita:*";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.ForeColor = System.Drawing.Color.White;
            this.lblBuscar.Location = new System.Drawing.Point(8, 25);
            this.lblBuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(135, 29);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por:";
            // 
            // gbBuscar
            // 
            this.gbBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscar.Controls.Add(this.btnLimpaBusca);
            this.gbBuscar.Controls.Add(this.txtBuscar);
            this.gbBuscar.Controls.Add(this.btnBuscar);
            this.gbBuscar.Controls.Add(this.rbObservacao);
            this.gbBuscar.Controls.Add(this.rbNome);
            this.gbBuscar.Location = new System.Drawing.Point(12, 63);
            this.gbBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBuscar.Name = "gbBuscar";
            this.gbBuscar.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBuscar.Size = new System.Drawing.Size(569, 128);
            this.gbBuscar.TabIndex = 0;
            this.gbBuscar.TabStop = false;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(9, 75);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(346, 35);
            this.txtBuscar.TabIndex = 5;
            // 
            // rbObservacao
            // 
            this.rbObservacao.AutoSize = true;
            this.rbObservacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbObservacao.ForeColor = System.Drawing.Color.White;
            this.rbObservacao.Location = new System.Drawing.Point(189, 29);
            this.rbObservacao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbObservacao.Name = "rbObservacao";
            this.rbObservacao.Size = new System.Drawing.Size(168, 33);
            this.rbObservacao.TabIndex = 3;
            this.rbObservacao.TabStop = true;
            this.rbObservacao.Text = "Observação";
            this.rbObservacao.UseVisualStyleBackColor = true;
            // 
            // rbNome
            // 
            this.rbNome.AutoSize = true;
            this.rbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNome.ForeColor = System.Drawing.Color.White;
            this.rbNome.Location = new System.Drawing.Point(9, 29);
            this.rbNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbNome.Name = "rbNome";
            this.rbNome.Size = new System.Drawing.Size(104, 33);
            this.rbNome.TabIndex = 0;
            this.rbNome.TabStop = true;
            this.rbNome.Text = "Nome";
            this.rbNome.UseVisualStyleBackColor = true;
            // 
            // gbGradeDados
            // 
            this.gbGradeDados.Controls.Add(this.btnExcluir);
            this.gbGradeDados.Controls.Add(this.btnEditar);
            this.gbGradeDados.Controls.Add(this.btnAdicionar);
            this.gbGradeDados.Controls.Add(this.lblGradeReceitas);
            this.gbGradeDados.Controls.Add(this.dgvReceitas);
            this.gbGradeDados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbGradeDados.Location = new System.Drawing.Point(604, 5);
            this.gbGradeDados.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGradeDados.Name = "gbGradeDados";
            this.gbGradeDados.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbGradeDados.Size = new System.Drawing.Size(592, 682);
            this.gbGradeDados.TabIndex = 1;
            this.gbGradeDados.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(416, 585);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(166, 55);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(138)))), ((int)(((byte)(218)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(213, 585);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(166, 55);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(165)))), ((int)(((byte)(106)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.Color.White;
            this.btnAdicionar.Location = new System.Drawing.Point(9, 585);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(166, 55);
            this.btnAdicionar.TabIndex = 2;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            // 
            // lblGradeReceitas
            // 
            this.lblGradeReceitas.AutoSize = true;
            this.lblGradeReceitas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGradeReceitas.ForeColor = System.Drawing.Color.White;
            this.lblGradeReceitas.Location = new System.Drawing.Point(3, 25);
            this.lblGradeReceitas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGradeReceitas.Name = "lblGradeReceitas";
            this.lblGradeReceitas.Size = new System.Drawing.Size(211, 29);
            this.lblGradeReceitas.TabIndex = 1;
            this.lblGradeReceitas.Text = "Grade de receitas:";
            // 
            // dgvReceitas
            // 
            this.dgvReceitas.AllowUserToAddRows = false;
            this.dgvReceitas.AllowUserToDeleteRows = false;
            this.dgvReceitas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReceitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceitas.Location = new System.Drawing.Point(9, 69);
            this.dgvReceitas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvReceitas.Name = "dgvReceitas";
            this.dgvReceitas.ReadOnly = true;
            this.dgvReceitas.RowHeadersWidth = 62;
            this.dgvReceitas.Size = new System.Drawing.Size(574, 502);
            this.dgvReceitas.TabIndex = 0;
            // 
            // btnLimpaBusca
            // 
            this.btnLimpaBusca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.btnLimpaBusca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpaBusca.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(158)))), ((int)(((byte)(60)))));
            this.btnLimpaBusca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpaBusca.Image = global::ProjetoMeuChef.Properties.Resources.limpa;
            this.btnLimpaBusca.Location = new System.Drawing.Point(488, 17);
            this.btnLimpaBusca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpaBusca.Name = "btnLimpaBusca";
            this.btnLimpaBusca.Size = new System.Drawing.Size(72, 98);
            this.btnLimpaBusca.TabIndex = 6;
            this.btnLimpaBusca.UseVisualStyleBackColor = false;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(100)))), ((int)(((byte)(60)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::ProjetoMeuChef.Properties.Resources.buscarMedio;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.Location = new System.Drawing.Point(366, 17);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(111, 98);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // frmTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.tlpGeral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meu Chef - Gerenciador de Receitas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTelaPrincipal_FormClosed);
            this.tlpGeral.ResumeLayout(false);
            this.gbDadosGerais.ResumeLayout(false);
            this.gbDadosGerais.PerformLayout();
            this.gbBuscar.ResumeLayout(false);
            this.gbBuscar.PerformLayout();
            this.gbGradeDados.ResumeLayout(false);
            this.gbGradeDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceitas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpGeral;
        private System.Windows.Forms.GroupBox gbDadosGerais;
        private System.Windows.Forms.GroupBox gbGradeDados;
        private System.Windows.Forms.DataGridView dgvReceitas;
        private System.Windows.Forms.Label lblGradeReceitas;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.GroupBox gbBuscar;
        private System.Windows.Forms.RadioButton rbObservacao;
        private System.Windows.Forms.RadioButton rbNome;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtPesoFinal;
        private System.Windows.Forms.Label lblPesoFinal;
        private System.Windows.Forms.TextBox txtObservacoes;
        private System.Windows.Forms.Label lblObservacoes;
        private System.Windows.Forms.TextBox txtModoPreparo;
        private System.Windows.Forms.Label lblModoPreparo;
        private System.Windows.Forms.TextBox txtIngredientes;
        private System.Windows.Forms.Label lblIngredientes;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnLimpaBusca;
    }
}