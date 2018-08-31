namespace prj_escola
{
    partial class frmCadDisciplina
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
            this.dgvDisciplina = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSerie = new System.Windows.Forms.TextBox();
            this.lblCod_Disciplina = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEnderec = new System.Windows.Forms.Label();
            this.txbSigla = new System.Windows.Forms.TextBox();
            this.txbDescri = new System.Windows.Forms.TextBox();
            this.lblCod_Disciplina_view = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.txbPesq_Sigla = new System.Windows.Forms.TextBox();
            this.lblPesq_Sigla = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisciplina.Location = new System.Drawing.Point(30, 295);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.Size = new System.Drawing.Size(650, 150);
            this.dgvDisciplina.TabIndex = 56;
            this.dgvDisciplina.Click += new System.EventHandler(this.dgvDisciplina_Click);
            this.dgvDisciplina.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvDisciplina_KeyDown);
            this.dgvDisciplina.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvDisciplina_KeyUp);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = global::prj_escola.Properties.Resources.rubbish_bin;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(496, 207);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.btnExcluir.Size = new System.Drawing.Size(130, 82);
            this.btnExcluir.TabIndex = 55;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = global::prj_escola.Properties.Resources.clean_code;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(360, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.btnLimpar.Size = new System.Drawing.Size(130, 82);
            this.btnLimpar.TabIndex = 54;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txbSerie);
            this.groupBox1.Controls.Add(this.lblCod_Disciplina);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblEnderec);
            this.groupBox1.Controls.Add(this.txbSigla);
            this.groupBox1.Controls.Add(this.txbDescri);
            this.groupBox1.Controls.Add(this.lblCod_Disciplina_view);
            this.groupBox1.Location = new System.Drawing.Point(30, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 164);
            this.groupBox1.TabIndex = 57;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Disciplina";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Série:";
            // 
            // txbSerie
            // 
            this.txbSerie.Location = new System.Drawing.Point(101, 107);
            this.txbSerie.Name = "txbSerie";
            this.txbSerie.Size = new System.Drawing.Size(166, 20);
            this.txbSerie.TabIndex = 45;
            // 
            // lblCod_Disciplina
            // 
            this.lblCod_Disciplina.AutoSize = true;
            this.lblCod_Disciplina.Location = new System.Drawing.Point(39, 41);
            this.lblCod_Disciplina.Name = "lblCod_Disciplina";
            this.lblCod_Disciplina.Size = new System.Drawing.Size(106, 13);
            this.lblCod_Disciplina.TabIndex = 27;
            this.lblCod_Disciplina.Text = "Código da Disciplina:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(37, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(58, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Descrição:";
            // 
            // lblEnderec
            // 
            this.lblEnderec.AutoSize = true;
            this.lblEnderec.Location = new System.Drawing.Point(234, 41);
            this.lblEnderec.Name = "lblEnderec";
            this.lblEnderec.Size = new System.Drawing.Size(33, 13);
            this.lblEnderec.TabIndex = 29;
            this.lblEnderec.Text = "Sigla:";
            // 
            // txbSigla
            // 
            this.txbSigla.Location = new System.Drawing.Point(273, 38);
            this.txbSigla.Name = "txbSigla";
            this.txbSigla.Size = new System.Drawing.Size(94, 20);
            this.txbSigla.TabIndex = 43;
            // 
            // txbDescri
            // 
            this.txbDescri.Location = new System.Drawing.Point(101, 72);
            this.txbDescri.Name = "txbDescri";
            this.txbDescri.Size = new System.Drawing.Size(266, 20);
            this.txbDescri.TabIndex = 40;
            // 
            // lblCod_Disciplina_view
            // 
            this.lblCod_Disciplina_view.AutoSize = true;
            this.lblCod_Disciplina_view.Location = new System.Drawing.Point(151, 41);
            this.lblCod_Disciplina_view.Name = "lblCod_Disciplina_view";
            this.lblCod_Disciplina_view.Size = new System.Drawing.Size(0, 13);
            this.lblCod_Disciplina_view.TabIndex = 39;
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(51, 451);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(149, 61);
            this.btnAnterior.TabIndex = 58;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(361, 451);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(149, 61);
            this.btnUltimo.TabIndex = 59;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(206, 451);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(149, 61);
            this.btnPrimeiro.TabIndex = 60;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(516, 451);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(149, 61);
            this.btnProximo.TabIndex = 61;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Image = global::prj_escola.Properties.Resources.refresh__1_;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(224, 207);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Padding = new System.Windows.Forms.Padding(23, 0, 22, 0);
            this.btnAlterar.Size = new System.Drawing.Size(130, 82);
            this.btnAlterar.TabIndex = 62;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // txbPesq_Sigla
            // 
            this.txbPesq_Sigla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesq_Sigla.Location = new System.Drawing.Point(294, 541);
            this.txbPesq_Sigla.Name = "txbPesq_Sigla";
            this.txbPesq_Sigla.Size = new System.Drawing.Size(271, 20);
            this.txbPesq_Sigla.TabIndex = 66;
            this.txbPesq_Sigla.TextChanged += new System.EventHandler(this.txbPesq_Sigla_TextChanged);
            // 
            // lblPesq_Sigla
            // 
            this.lblPesq_Sigla.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesq_Sigla.AutoSize = true;
            this.lblPesq_Sigla.Location = new System.Drawing.Point(191, 544);
            this.lblPesq_Sigla.Name = "lblPesq_Sigla";
            this.lblPesq_Sigla.Size = new System.Drawing.Size(97, 13);
            this.lblPesq_Sigla.TabIndex = 65;
            this.lblPesq_Sigla.Text = "Pesquisa por Sigla:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Image = global::prj_escola.Properties.Resources.add_circular_outlined_button;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(88, 207);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(18, 0, 14, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(130, 82);
            this.btnCadastrar.TabIndex = 53;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCadDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 577);
            this.Controls.Add(this.txbPesq_Sigla);
            this.Controls.Add(this.lblPesq_Sigla);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dgvDisciplina);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadDisciplina";
            this.ShowIcon = false;
            this.Text = "Cadastrar Disciplina";
            this.Load += new System.EventHandler(this.frmCadDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDisciplina;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCod_Disciplina;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEnderec;
        private System.Windows.Forms.TextBox txbSigla;
        private System.Windows.Forms.TextBox txbDescri;
        private System.Windows.Forms.Label lblCod_Disciplina_view;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSerie;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txbPesq_Sigla;
        private System.Windows.Forms.Label lblPesq_Sigla;

    }
}