namespace prj_escola
{
    partial class frmCad_Aluno
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
            this.masktxbTelef = new System.Windows.Forms.MaskedTextBox();
            this.txbBairro = new System.Windows.Forms.TextBox();
            this.txbNumero = new System.Windows.Forms.TextBox();
            this.dtpData_Nasc = new System.Windows.Forms.DateTimePicker();
            this.masktxbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txbEnderec = new System.Windows.Forms.TextBox();
            this.masktxbRG = new System.Windows.Forms.MaskedTextBox();
            this.masktxbCPF = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.lblMatricula_view = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNum_Cas = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblDt_Nasc = new System.Windows.Forms.Label();
            this.lblEnderec = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblMatricula = new System.Windows.Forms.Label();
            this.dgvAluno = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.txbPesq_Nome = new System.Windows.Forms.TextBox();
            this.lblPesq_Nome = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // masktxbTelef
            // 
            this.masktxbTelef.Location = new System.Drawing.Point(394, 183);
            this.masktxbTelef.Mask = "(99)0000-0000";
            this.masktxbTelef.Name = "masktxbTelef";
            this.masktxbTelef.Size = new System.Drawing.Size(202, 20);
            this.masktxbTelef.TabIndex = 50;
            // 
            // txbBairro
            // 
            this.txbBairro.Location = new System.Drawing.Point(365, 261);
            this.txbBairro.Name = "txbBairro";
            this.txbBairro.Size = new System.Drawing.Size(229, 20);
            this.txbBairro.TabIndex = 47;
            // 
            // txbNumero
            // 
            this.txbNumero.Location = new System.Drawing.Point(377, 298);
            this.txbNumero.Name = "txbNumero";
            this.txbNumero.Size = new System.Drawing.Size(118, 20);
            this.txbNumero.TabIndex = 46;
            // 
            // dtpData_Nasc
            // 
            this.dtpData_Nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpData_Nasc.Location = new System.Drawing.Point(175, 183);
            this.dtpData_Nasc.Name = "dtpData_Nasc";
            this.dtpData_Nasc.Size = new System.Drawing.Size(128, 20);
            this.dtpData_Nasc.TabIndex = 45;
            // 
            // masktxbCEP
            // 
            this.masktxbCEP.Location = new System.Drawing.Point(86, 261);
            this.masktxbCEP.Mask = "00000-999";
            this.masktxbCEP.Name = "masktxbCEP";
            this.masktxbCEP.Size = new System.Drawing.Size(202, 20);
            this.masktxbCEP.TabIndex = 44;
            // 
            // txbEnderec
            // 
            this.txbEnderec.Location = new System.Drawing.Point(115, 221);
            this.txbEnderec.Name = "txbEnderec";
            this.txbEnderec.Size = new System.Drawing.Size(479, 20);
            this.txbEnderec.TabIndex = 43;
            // 
            // masktxbRG
            // 
            this.masktxbRG.Location = new System.Drawing.Point(84, 109);
            this.masktxbRG.Mask = "00.000.000-9";
            this.masktxbRG.Name = "masktxbRG";
            this.masktxbRG.Size = new System.Drawing.Size(205, 20);
            this.masktxbRG.TabIndex = 42;
            // 
            // masktxbCPF
            // 
            this.masktxbCPF.Location = new System.Drawing.Point(85, 145);
            this.masktxbCPF.Mask = "000.000.000-99";
            this.masktxbCPF.Name = "masktxbCPF";
            this.masktxbCPF.Size = new System.Drawing.Size(203, 20);
            this.masktxbCPF.TabIndex = 41;
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(94, 72);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(333, 20);
            this.txbNome.TabIndex = 40;
            // 
            // lblMatricula_view
            // 
            this.lblMatricula_view.AutoSize = true;
            this.lblMatricula_view.Location = new System.Drawing.Point(114, 41);
            this.lblMatricula_view.Name = "lblMatricula_view";
            this.lblMatricula_view.Size = new System.Drawing.Size(0, 13);
            this.lblMatricula_view.TabIndex = 39;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCidade.Location = new System.Drawing.Point(43, 301);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(50, 13);
            this.lblCidade.TabIndex = 38;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCEP.Location = new System.Drawing.Point(43, 264);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(35, 13);
            this.lblCEP.TabIndex = 37;
            this.lblCEP.Text = "CEP:";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRG.Location = new System.Drawing.Point(43, 112);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(29, 13);
            this.lblRG.TabIndex = 36;
            this.lblRG.Text = "RG:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.Location = new System.Drawing.Point(327, 186);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(61, 13);
            this.lblTelef.TabIndex = 35;
            this.lblTelef.Text = "Telefone:";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPF.Location = new System.Drawing.Point(44, 148);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 13);
            this.lblCPF.TabIndex = 34;
            this.lblCPF.Text = "CPF:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(456, 75);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(39, 13);
            this.lblSexo.TabIndex = 33;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNum_Cas
            // 
            this.lblNum_Cas.AutoSize = true;
            this.lblNum_Cas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum_Cas.Location = new System.Drawing.Point(315, 301);
            this.lblNum_Cas.Name = "lblNum_Cas";
            this.lblNum_Cas.Size = new System.Drawing.Size(54, 13);
            this.lblNum_Cas.TabIndex = 32;
            this.lblNum_Cas.Text = "Número:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBairro.Location = new System.Drawing.Point(315, 264);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(44, 13);
            this.lblBairro.TabIndex = 31;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblDt_Nasc
            // 
            this.lblDt_Nasc.AutoSize = true;
            this.lblDt_Nasc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDt_Nasc.Location = new System.Drawing.Point(43, 186);
            this.lblDt_Nasc.Name = "lblDt_Nasc";
            this.lblDt_Nasc.Size = new System.Drawing.Size(126, 13);
            this.lblDt_Nasc.TabIndex = 30;
            this.lblDt_Nasc.Text = "Data de Nascimento:";
            // 
            // lblEnderec
            // 
            this.lblEnderec.AutoSize = true;
            this.lblEnderec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnderec.Location = new System.Drawing.Point(43, 224);
            this.lblEnderec.Name = "lblEnderec";
            this.lblEnderec.Size = new System.Drawing.Size(65, 13);
            this.lblEnderec.TabIndex = 29;
            this.lblEnderec.Text = "Endereço:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(43, 75);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 13);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome:";
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatricula.Location = new System.Drawing.Point(43, 41);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(65, 13);
            this.lblMatricula.TabIndex = 27;
            this.lblMatricula.Text = "Matrícula:";
            // 
            // dgvAluno
            // 
            this.dgvAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAluno.Location = new System.Drawing.Point(79, 389);
            this.dgvAluno.Name = "dgvAluno";
            this.dgvAluno.Size = new System.Drawing.Size(875, 150);
            this.dgvAluno.TabIndex = 51;
            this.dgvAluno.Click += new System.EventHandler(this.dgvAluno_Click);
            this.dgvAluno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvAluno_KeyDown);
            this.dgvAluno.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvAluno_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupBox1.Controls.Add(this.txbCidade);
            this.groupBox1.Controls.Add(this.lblMatricula);
            this.groupBox1.Controls.Add(this.masktxbTelef);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.cbSexo);
            this.groupBox1.Controls.Add(this.lblEnderec);
            this.groupBox1.Controls.Add(this.lblDt_Nasc);
            this.groupBox1.Controls.Add(this.txbBairro);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.txbNumero);
            this.groupBox1.Controls.Add(this.lblNum_Cas);
            this.groupBox1.Controls.Add(this.dtpData_Nasc);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.masktxbCEP);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.txbEnderec);
            this.groupBox1.Controls.Add(this.lblTelef);
            this.groupBox1.Controls.Add(this.masktxbRG);
            this.groupBox1.Controls.Add(this.lblRG);
            this.groupBox1.Controls.Add(this.masktxbCPF);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Controls.Add(this.txbNome);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblMatricula_view);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(31, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 341);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Aluno";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txbCidade
            // 
            this.txbCidade.Location = new System.Drawing.Point(100, 298);
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(188, 20);
            this.txbCidade.TabIndex = 51;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(503, 72);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(140, 21);
            this.cbSexo.TabIndex = 49;
            this.cbSexo.Text = "Selecione";
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(698, 545);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(174, 61);
            this.btnProximo.TabIndex = 65;
            this.btnProximo.Text = "Próximo";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(517, 545);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(174, 61);
            this.btnPrimeiro.TabIndex = 64;
            this.btnPrimeiro.Text = "Primeiro";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click_1);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(336, 545);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(174, 61);
            this.btnUltimo.TabIndex = 63;
            this.btnUltimo.Text = "Último";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click_1);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(155, 545);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(174, 61);
            this.btnAnterior.TabIndex = 62;
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click_1);
            // 
            // txbPesq_Nome
            // 
            this.txbPesq_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txbPesq_Nome.Location = new System.Drawing.Point(460, 637);
            this.txbPesq_Nome.Name = "txbPesq_Nome";
            this.txbPesq_Nome.Size = new System.Drawing.Size(315, 20);
            this.txbPesq_Nome.TabIndex = 68;
            this.txbPesq_Nome.TextChanged += new System.EventHandler(this.txbPesq_Nome_TextChanged);
            // 
            // lblPesq_Nome
            // 
            this.lblPesq_Nome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPesq_Nome.AutoSize = true;
            this.lblPesq_Nome.Location = new System.Drawing.Point(339, 640);
            this.lblPesq_Nome.Name = "lblPesq_Nome";
            this.lblPesq_Nome.Size = new System.Drawing.Size(120, 13);
            this.lblPesq_Nome.TabIndex = 67;
            this.lblPesq_Nome.Text = "Pesquisa por Nome:";
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackColor = System.Drawing.Color.Gold;
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterar.Image = global::prj_escola.Properties.Resources.refresh__1_;
            this.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlterar.Location = new System.Drawing.Point(771, 137);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnAlterar.Size = new System.Drawing.Size(216, 51);
            this.btnAlterar.TabIndex = 66;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = false;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Gold;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Image = global::prj_escola.Properties.Resources.rubbish_bin;
            this.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExcluir.Location = new System.Drawing.Point(771, 251);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnExcluir.Size = new System.Drawing.Size(216, 51);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.Gold;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Image = global::prj_escola.Properties.Resources.clean_code;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(771, 194);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnLimpar.Size = new System.Drawing.Size(216, 51);
            this.btnLimpar.TabIndex = 25;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Gold;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCadastrar.Image = global::prj_escola.Properties.Resources.add_user__1_;
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(771, 82);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Padding = new System.Windows.Forms.Padding(52, 0, 0, 0);
            this.btnCadastrar.Size = new System.Drawing.Size(216, 49);
            this.btnCadastrar.TabIndex = 24;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // frmCad_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(1030, 685);
            this.Controls.Add(this.txbPesq_Nome);
            this.Controls.Add(this.lblPesq_Nome);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.dgvAluno);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCad_Aluno";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastrar Aluno";
            this.Load += new System.EventHandler(this.frmCad_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAluno)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.MaskedTextBox masktxbTelef;
        private System.Windows.Forms.TextBox txbBairro;
        private System.Windows.Forms.TextBox txbNumero;
        private System.Windows.Forms.DateTimePicker dtpData_Nasc;
        private System.Windows.Forms.MaskedTextBox masktxbCEP;
        private System.Windows.Forms.TextBox txbEnderec;
        private System.Windows.Forms.MaskedTextBox masktxbRG;
        private System.Windows.Forms.MaskedTextBox masktxbCPF;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.Label lblMatricula_view;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNum_Cas;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblDt_Nasc;
        private System.Windows.Forms.Label lblEnderec;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.DataGridView dgvAluno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbCidade;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.TextBox txbPesq_Nome;
        private System.Windows.Forms.Label lblPesq_Nome;
    }
}