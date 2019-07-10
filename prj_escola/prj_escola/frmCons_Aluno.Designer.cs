namespace prj_escola
{
    partial class frmCons_Aluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCons_Aluno));
            this.btnQtdSelec = new System.Windows.Forms.Button();
            this.dgvCons_Aluno = new System.Windows.Forms.DataGridView();
            this.txb_pesq = new System.Windows.Forms.TextBox();
            this.cbEscolha = new System.Windows.Forms.ComboBox();
            this.lblCampo_Pesq = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pDi_Aluno = new System.Windows.Forms.PrintDialog();
            this.pD_Aluno = new System.Drawing.Printing.PrintDocument();
            this.pPDi_Aluno = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons_Aluno)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQtdSelec
            // 
            this.btnQtdSelec.BackColor = System.Drawing.Color.Gold;
            this.btnQtdSelec.Location = new System.Drawing.Point(472, 289);
            this.btnQtdSelec.Name = "btnQtdSelec";
            this.btnQtdSelec.Size = new System.Drawing.Size(175, 55);
            this.btnQtdSelec.TabIndex = 9;
            this.btnQtdSelec.Text = "Quantidade de Selecionados";
            this.btnQtdSelec.UseVisualStyleBackColor = false;
            this.btnQtdSelec.Click += new System.EventHandler(this.btnQtdSelec_Click);
            // 
            // dgvCons_Aluno
            // 
            this.dgvCons_Aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCons_Aluno.Location = new System.Drawing.Point(29, 124);
            this.dgvCons_Aluno.Name = "dgvCons_Aluno";
            this.dgvCons_Aluno.Size = new System.Drawing.Size(652, 150);
            this.dgvCons_Aluno.TabIndex = 8;
            // 
            // txb_pesq
            // 
            this.txb_pesq.Location = new System.Drawing.Point(299, 50);
            this.txb_pesq.Name = "txb_pesq";
            this.txb_pesq.Size = new System.Drawing.Size(219, 20);
            this.txb_pesq.TabIndex = 7;
            this.txb_pesq.TextChanged += new System.EventHandler(this.txb_pesq_TextChanged);
            // 
            // cbEscolha
            // 
            this.cbEscolha.FormattingEnabled = true;
            this.cbEscolha.Items.AddRange(new object[] {
            "Nome",
            "Matrícula",
            "RG",
            "CPF",
            "Data de Nascimento",
            "Endereço",
            "CEP",
            "Cidade",
            "Sexo",
            "Telefone",
            "Bairro",
            "Número"});
            this.cbEscolha.Location = new System.Drawing.Point(64, 49);
            this.cbEscolha.Name = "cbEscolha";
            this.cbEscolha.Size = new System.Drawing.Size(227, 21);
            this.cbEscolha.TabIndex = 6;
            this.cbEscolha.Text = "Selecione...";
            // 
            // lblCampo_Pesq
            // 
            this.lblCampo_Pesq.AutoSize = true;
            this.lblCampo_Pesq.Location = new System.Drawing.Point(29, 18);
            this.lblCampo_Pesq.Name = "lblCampo_Pesq";
            this.lblCampo_Pesq.Size = new System.Drawing.Size(208, 13);
            this.lblCampo_Pesq.TabIndex = 5;
            this.lblCampo_Pesq.Text = "Escolha o campo a ser pesquisado:";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gold;
            this.btnView.Location = new System.Drawing.Point(174, 305);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 23);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gold;
            this.btnPrint.Location = new System.Drawing.Point(79, 305);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pDi_Aluno
            // 
            this.pDi_Aluno.Document = this.pD_Aluno;
            this.pDi_Aluno.UseEXDialog = true;
            // 
            // pD_Aluno
            // 
            this.pD_Aluno.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pD_Aluno_PrintPage);
            // 
            // pPDi_Aluno
            // 
            this.pPDi_Aluno.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pPDi_Aluno.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pPDi_Aluno.ClientSize = new System.Drawing.Size(400, 300);
            this.pPDi_Aluno.Document = this.pD_Aluno;
            this.pPDi_Aluno.Enabled = true;
            this.pPDi_Aluno.Icon = ((System.Drawing.Icon)(resources.GetObject("pPDi_Aluno.Icon")));
            this.pPDi_Aluno.Name = "pPDi_Aluno";
            this.pPDi_Aluno.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.txb_pesq);
            this.panel1.Controls.Add(this.cbEscolha);
            this.panel1.Controls.Add(this.lblCampo_Pesq);
            this.panel1.Location = new System.Drawing.Point(47, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 88);
            this.panel1.TabIndex = 12;
            // 
            // frmCons_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(709, 375);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnQtdSelec);
            this.Controls.Add(this.dgvCons_Aluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCons_Aluno";
            this.ShowIcon = false;
            this.Text = "Consulta Cadastral Alunos";
            this.Load += new System.EventHandler(this.frmCons_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons_Aluno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQtdSelec;
        private System.Windows.Forms.DataGridView dgvCons_Aluno;
        private System.Windows.Forms.TextBox txb_pesq;
        private System.Windows.Forms.ComboBox cbEscolha;
        private System.Windows.Forms.Label lblCampo_Pesq;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.PrintDialog pDi_Aluno;
        private System.Drawing.Printing.PrintDocument pD_Aluno;
        private System.Windows.Forms.PrintPreviewDialog pPDi_Aluno;
        private System.Windows.Forms.Panel panel1;
    }
}