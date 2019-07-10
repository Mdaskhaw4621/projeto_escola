namespace prj_escola
{
    partial class frmRelatCadDisc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRelatCadDisc));
            this.dgv_RelatCadDisc = new System.Windows.Forms.DataGridView();
            this.btnView = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.printDocument_Relat_Cad_Disc = new System.Drawing.Printing.PrintDocument();
            this.printDialog_Relat_Cad_Disc = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog_Relat_Cad_Disc = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RelatCadDisc)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_RelatCadDisc
            // 
            this.dgv_RelatCadDisc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RelatCadDisc.Location = new System.Drawing.Point(45, 36);
            this.dgv_RelatCadDisc.Name = "dgv_RelatCadDisc";
            this.dgv_RelatCadDisc.Size = new System.Drawing.Size(588, 248);
            this.dgv_RelatCadDisc.TabIndex = 0;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Gold;
            this.btnView.Location = new System.Drawing.Point(342, 325);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(257, 65);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "Visualizar";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Gold;
            this.btnPrint.Location = new System.Drawing.Point(78, 325);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(257, 65);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // printDocument_Relat_Cad_Disc
            // 
            this.printDocument_Relat_Cad_Disc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument_Relat_Cad_Disc_PrintPage);
            // 
            // printDialog_Relat_Cad_Disc
            // 
            this.printDialog_Relat_Cad_Disc.UseEXDialog = true;
            // 
            // printPreviewDialog_Relat_Cad_Disc
            // 
            this.printPreviewDialog_Relat_Cad_Disc.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_Relat_Cad_Disc.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog_Relat_Cad_Disc.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog_Relat_Cad_Disc.Document = this.printDocument_Relat_Cad_Disc;
            this.printPreviewDialog_Relat_Cad_Disc.Enabled = true;
            this.printPreviewDialog_Relat_Cad_Disc.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog_Relat_Cad_Disc.Icon")));
            this.printPreviewDialog_Relat_Cad_Disc.Name = "printPreviewDialog_Relat_Cad_Disc";
            this.printPreviewDialog_Relat_Cad_Disc.Visible = false;
            // 
            // frmRelatCadDisc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(678, 428);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgv_RelatCadDisc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRelatCadDisc";
            this.ShowIcon = false;
            this.Text = "Relatório de Cadastro das Disciplinas";
            this.Load += new System.EventHandler(this.RelatCadDisc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RelatCadDisc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_RelatCadDisc;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnPrint;
        private System.Drawing.Printing.PrintDocument printDocument_Relat_Cad_Disc;
        private System.Windows.Forms.PrintDialog printDialog_Relat_Cad_Disc;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog_Relat_Cad_Disc;
    }
}