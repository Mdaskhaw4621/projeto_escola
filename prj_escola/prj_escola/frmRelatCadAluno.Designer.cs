namespace prj_escola
{
    partial class frmRelatCadAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatCadAluno));
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgv_RelatCadAluno = new System.Windows.Forms.DataGridView();
            this.printDocument_Relat_Cad_Alu = new System.Drawing.Printing.PrintDocument();
            this.printDialog_Relat_Cad_Alu = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog_Relat_Cad_Alu = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RelatCadAluno)).BeginInit();
            this.SuspendLayout();
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gold;
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(341, 326);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(257, 65);
            this.btnView.TabIndex = 11;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gold;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(77, 326);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(257, 65);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgv_RelatCadAluno
            // 
            this.dgv_RelatCadAluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RelatCadAluno.Location = new System.Drawing.Point(44, 37);
            this.dgv_RelatCadAluno.Name = "dgv_RelatCadAluno";
            this.dgv_RelatCadAluno.Size = new System.Drawing.Size(588, 248);
            this.dgv_RelatCadAluno.TabIndex = 9;
            // 
            // printDocument_Relat_Cad_Alu
            // 
            this.printDocument_Relat_Cad_Alu.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Relat_Cad_Alu_PrintPage);
            // 
            // printDialog_Relat_Cad_Alu
            // 
            this.printDialog_Relat_Cad_Alu.UseEXDialog = true;
            // 
            // printPreviewDialog_Relat_Cad_Alu
            // 
            this.printPreviewDialog_Relat_Cad_Alu.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_Relat_Cad_Alu.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_Relat_Cad_Alu.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_Relat_Cad_Alu.Document = this.printDocument_Relat_Cad_Alu;
            this.printPreviewDialog_Relat_Cad_Alu.Enabled = true;
            this.printPreviewDialog_Relat_Cad_Alu.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_Relat_Cad_Alu.Icon")));
            this.printPreviewDialog_Relat_Cad_Alu.Name = "printPreviewDialog_Relat_Cad_Alu";
            this.printPreviewDialog_Relat_Cad_Alu.Visible = false;
            // 
            // frmRelatCadAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(678, 428);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgv_RelatCadAluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatCadAluno";
            this.ShowIcon = false;
            this.Text = "Relatório de Cadastro dos Alunos";
            this.Load += new System.EventHandler(this.fmRelatCadAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RelatCadAluno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridView dgv_RelatCadAluno;
        private System.Drawing.Printing.PrintDocument printDocument_Relat_Cad_Alu;
        private System.Windows.Forms.PrintDialog printDialog_Relat_Cad_Alu;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_Relat_Cad_Alu;
    }
}