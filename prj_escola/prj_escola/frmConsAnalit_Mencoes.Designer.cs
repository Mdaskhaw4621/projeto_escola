namespace prj_escola
{
    partial class frmCons_Analit_Mencoes
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
            this.dgv_mencoes = new System.Windows.Forms.DataGridView();
            this.cb_mencoes = new System.Windows.Forms.ComboBox();
            this.lblMencoes = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mencoes)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_mencoes
            // 
            this.dgv_mencoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_mencoes.Location = new System.Drawing.Point(33, 89);
            this.dgv_mencoes.Name = "dgv_mencoes";
            this.dgv_mencoes.Size = new System.Drawing.Size(594, 266);
            this.dgv_mencoes.TabIndex = 11;
            // 
            // cb_mencoes
            // 
            this.cb_mencoes.FormattingEnabled = true;
            this.cb_mencoes.Location = new System.Drawing.Point(244, 20);
            this.cb_mencoes.Name = "cb_mencoes";
            this.cb_mencoes.Size = new System.Drawing.Size(180, 21);
            this.cb_mencoes.TabIndex = 9;
            this.cb_mencoes.SelectedIndexChanged += new System.EventHandler(this.cb_menções_SelectedIndexChanged);
            // 
            // lblMencoes
            // 
            this.lblMencoes.AutoSize = true;
            this.lblMencoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMencoes.Location = new System.Drawing.Point(177, 23);
            this.lblMencoes.Name = "lblMencoes";
            this.lblMencoes.Size = new System.Drawing.Size(58, 13);
            this.lblMencoes.TabIndex = 8;
            this.lblMencoes.Text = "Menções";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblMencoes);
            this.panel1.Controls.Add(this.cb_mencoes);
            this.panel1.Location = new System.Drawing.Point(33, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 55);
            this.panel1.TabIndex = 12;
            // 
            // frmCons_Analit_Mencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(659, 377);
            this.Controls.Add(this.dgv_mencoes);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCons_Analit_Mencoes";
            this.ShowIcon = false;
            this.Text = "Consulta Menções";
            this.Load += new System.EventHandler(this.frmCad_Analit_Mencoes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_mencoes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_mencoes;
        private System.Windows.Forms.ComboBox cb_mencoes;
        private System.Windows.Forms.Label lblMencoes;
        private System.Windows.Forms.Panel panel1;
    }
}