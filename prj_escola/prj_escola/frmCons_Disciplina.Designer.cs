namespace prj_escola
{
    partial class frmCons_Disciplina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCons_Disciplina));
            this.lblCampo_Pesq = new System.Windows.Forms.Label();
            this.cbEscolha = new System.Windows.Forms.ComboBox();
            this.txb_pesq = new System.Windows.Forms.TextBox();
            this.dgvCons_Disc = new System.Windows.Forms.DataGridView();
            this.btnQtdSelec = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.pDi_Disciplina = new System.Windows.Forms.PrintDialog();
            this.pD_Disciplina = new System.Drawing.Printing.PrintDocument();
            this.pPDi_Disciplina = new System.Windows.Forms.PrintPreviewDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons_Disc)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCampo_Pesq
            // 
            this.lblCampo_Pesq.AutoSize = true;
            this.lblCampo_Pesq.Location = new System.Drawing.Point(9, 9);
            this.lblCampo_Pesq.Name = "lblCampo_Pesq";
            this.lblCampo_Pesq.Size = new System.Drawing.Size(208, 13);
            this.lblCampo_Pesq.TabIndex = 0;
            this.lblCampo_Pesq.Text = "Escolha o campo a ser pesquisado:";
            // 
            // cbEscolha
            // 
            this.cbEscolha.FormattingEnabled = true;
            this.cbEscolha.Items.AddRange(new object[] {
            "Código da Disciplina",
            "Descrição",
            "Sigla",
            "Série"});
            this.cbEscolha.Location = new System.Drawing.Point(71, 40);
            this.cbEscolha.Name = "cbEscolha";
            this.cbEscolha.Size = new System.Drawing.Size(227, 21);
            this.cbEscolha.TabIndex = 1;
            this.cbEscolha.Text = "Selecione...";
            // 
            // txb_pesq
            // 
            this.txb_pesq.Location = new System.Drawing.Point(306, 41);
            this.txb_pesq.Name = "txb_pesq";
            this.txb_pesq.Size = new System.Drawing.Size(219, 20);
            this.txb_pesq.TabIndex = 2;
            this.txb_pesq.TextChanged += new System.EventHandler(this.txb_pesq_TextChanged);
            // 
            // dgvCons_Disc
            // 
            this.dgvCons_Disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCons_Disc.Location = new System.Drawing.Point(40, 113);
            this.dgvCons_Disc.Name = "dgvCons_Disc";
            this.dgvCons_Disc.Size = new System.Drawing.Size(596, 150);
            this.dgvCons_Disc.TabIndex = 3;
            // 
            // btnQtdSelec
            // 
            this.btnQtdSelec.BackColor = System.Drawing.Color.Gold;
            this.btnQtdSelec.Location = new System.Drawing.Point(446, 284);
            this.btnQtdSelec.Name = "btnQtdSelec";
            this.btnQtdSelec.Size = new System.Drawing.Size(175, 55);
            this.btnQtdSelec.TabIndex = 4;
            this.btnQtdSelec.Text = "Quantidade de Selecionados";
            this.btnQtdSelec.UseVisualStyleBackColor = false;
            this.btnQtdSelec.Click += new System.EventHandler(this.btnQtdSelec_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gold;
            this.btnPrint.Location = new System.Drawing.Point(52, 300);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(87, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gold;
            this.btnView.Location = new System.Drawing.Point(147, 300);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(87, 23);
            this.btnView.TabIndex = 6;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // pDi_Disciplina
            // 
            this.pDi_Disciplina.UseEXDialog = true;
            // 
            // pD_Disciplina
            // 
            this.pD_Disciplina.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pD_Disciplina_PrintPage);
            // 
            // pPDi_Disciplina
            // 
            this.pPDi_Disciplina.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.pPDi_Disciplina.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.pPDi_Disciplina.ClientSize = new System.Drawing.Size(400, 300);
            this.pPDi_Disciplina.Document = this.pD_Disciplina;
            this.pPDi_Disciplina.Enabled = true;
            this.pPDi_Disciplina.Icon = ((System.Drawing.Icon)(resources.GetObject("pPDi_Disciplina.Icon")));
            this.pPDi_Disciplina.Name = "pPDi_Disciplina";
            this.pPDi_Disciplina.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.txb_pesq);
            this.panel1.Controls.Add(this.cbEscolha);
            this.panel1.Controls.Add(this.lblCampo_Pesq);
            this.panel1.Location = new System.Drawing.Point(40, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(596, 76);
            this.panel1.TabIndex = 7;
            // 
            // frmCons_Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(671, 360);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnQtdSelec);
            this.Controls.Add(this.dgvCons_Disc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCons_Disciplina";
            this.ShowIcon = false;
            this.Text = "Consulta Cadastral Disciplinas";
            this.Load += new System.EventHandler(this.frmCons_Disciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCons_Disc)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCampo_Pesq;
        private System.Windows.Forms.ComboBox cbEscolha;
        private System.Windows.Forms.TextBox txb_pesq;
        private System.Windows.Forms.DataGridView dgvCons_Disc;
        private System.Windows.Forms.Button btnQtdSelec;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.PrintDialog pDi_Disciplina;
        private System.Drawing.Printing.PrintDocument pD_Disciplina;
        private System.Windows.Forms.PrintPreviewDialog pPDi_Disciplina;
        private System.Windows.Forms.Panel panel1;
    }
}