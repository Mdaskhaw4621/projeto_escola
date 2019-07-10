namespace prj_escola
{
    partial class frmRelat_Analit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelat_Analit));
            this.cb_opcoes = new System.Windows.Forms.ComboBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgv_relatAnalit = new System.Windows.Forms.DataGridView();
            this.printDocument_RelatAnalit = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog_RelatAnalit = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatAnalit)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_opcoes
            // 
            this.cb_opcoes.FormattingEnabled = true;
            this.cb_opcoes.Items.AddRange(new object[] {
            "Agrupado por Menção",
            "Agrupado por Disciplina",
            "Boletim"});
            this.cb_opcoes.Location = new System.Drawing.Point(206, 27);
            this.cb_opcoes.Name = "cb_opcoes";
            this.cb_opcoes.Size = new System.Drawing.Size(268, 21);
            this.cb_opcoes.TabIndex = 0;
            this.cb_opcoes.Text = "Selecione: ";
            this.cb_opcoes.SelectedIndexChanged += new System.EventHandler(this.cb_opcoes_SelectedIndexChanged);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gold;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(342, 78);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(257, 65);
            this.btnView.TabIndex = 14;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gold;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(78, 78);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(257, 65);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // dgv_relatAnalit
            // 
            this.dgv_relatAnalit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_relatAnalit.Location = new System.Drawing.Point(43, 170);
            this.dgv_relatAnalit.Name = "dgv_relatAnalit";
            this.dgv_relatAnalit.Size = new System.Drawing.Size(588, 230);
            this.dgv_relatAnalit.TabIndex = 12;
            // 
            // printDocument_RelatAnalit
            // 
            this.printDocument_RelatAnalit.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_RelatAnalit_PrintPage);
            // 
            // printPreviewDialog_RelatAnalit
            // 
            this.printPreviewDialog_RelatAnalit.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_RelatAnalit.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_RelatAnalit.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_RelatAnalit.Document = this.printDocument_RelatAnalit;
            this.printPreviewDialog_RelatAnalit.Enabled = true;
            this.printPreviewDialog_RelatAnalit.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_RelatAnalit.Icon")));
            this.printPreviewDialog_RelatAnalit.Name = "printPreviewDialog_RelatAnalit";
            this.printPreviewDialog_RelatAnalit.Visible = false;
            // 
            // frmRelat_Analit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(678, 428);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgv_relatAnalit);
            this.Controls.Add(this.cb_opcoes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelat_Analit";
            this.ShowIcon = false;
            this.Text = "Relatório Análitico";
            this.Load += new System.EventHandler(this.frmRelat_Analit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_relatAnalit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_opcoes;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgv_relatAnalit;
        private System.Drawing.Printing.PrintDocument printDocument_RelatAnalit;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_RelatAnalit;
    }
}