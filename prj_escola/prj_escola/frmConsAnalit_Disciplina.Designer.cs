namespace prj_escola
{
    partial class frmConsAnalit_Disciplina
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
            this.lblSigla = new System.Windows.Forms.Label();
            this.cb_sigla_disc = new System.Windows.Forms.ComboBox();
            this.lbl_descri_view = new System.Windows.Forms.Label();
            this.dgv_disc = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSigla
            // 
            this.lblSigla.AutoSize = true;
            this.lblSigla.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblSigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSigla.Location = new System.Drawing.Point(82, 44);
            this.lblSigla.Name = "lblSigla";
            this.lblSigla.Size = new System.Drawing.Size(39, 13);
            this.lblSigla.TabIndex = 0;
            this.lblSigla.Text = "Sigla:";
            // 
            // cb_sigla_disc
            // 
            this.cb_sigla_disc.FormattingEnabled = true;
            this.cb_sigla_disc.Location = new System.Drawing.Point(127, 41);
            this.cb_sigla_disc.Name = "cb_sigla_disc";
            this.cb_sigla_disc.Size = new System.Drawing.Size(286, 21);
            this.cb_sigla_disc.TabIndex = 1;
            this.cb_sigla_disc.SelectedIndexChanged += new System.EventHandler(this.cb_sigla_disc_SelectedIndexChanged);
            // 
            // lbl_descri_view
            // 
            this.lbl_descri_view.AutoSize = true;
            this.lbl_descri_view.Location = new System.Drawing.Point(332, 44);
            this.lbl_descri_view.Name = "lbl_descri_view";
            this.lbl_descri_view.Size = new System.Drawing.Size(0, 13);
            this.lbl_descri_view.TabIndex = 2;
            // 
            // dgv_disc
            // 
            this.dgv_disc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disc.Location = new System.Drawing.Point(28, 84);
            this.dgv_disc.Name = "dgv_disc";
            this.dgv_disc.Size = new System.Drawing.Size(587, 148);
            this.dgv_disc.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Location = new System.Drawing.Point(28, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 55);
            this.panel1.TabIndex = 9;
            // 
            // frmConsAnalit_Disciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(643, 253);
            this.Controls.Add(this.dgv_disc);
            this.Controls.Add(this.lbl_descri_view);
            this.Controls.Add(this.cb_sigla_disc);
            this.Controls.Add(this.lblSigla);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsAnalit_Disciplina";
            this.ShowIcon = false;
            this.Text = "Consulta por Disciplina";
            this.Load += new System.EventHandler(this.frmConsAnalit_Disciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSigla;
        private System.Windows.Forms.ComboBox cb_sigla_disc;
        private System.Windows.Forms.Label lbl_descri_view;
        private System.Windows.Forms.DataGridView dgv_disc;
        private System.Windows.Forms.Panel panel1;
    }
}