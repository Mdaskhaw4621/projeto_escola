namespace prj_escola
{
    partial class frmConsAnalit_Aluno
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
            this.dgv_aluno = new System.Windows.Forms.DataGridView();
            this.lbl_matricula_view = new System.Windows.Forms.Label();
            this.cb_nome_aluno = new System.Windows.Forms.ComboBox();
            this.lblAluno = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_aluno
            // 
            this.dgv_aluno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_aluno.Location = new System.Drawing.Point(26, 77);
            this.dgv_aluno.Name = "dgv_aluno";
            this.dgv_aluno.Size = new System.Drawing.Size(587, 130);
            this.dgv_aluno.TabIndex = 7;
            // 
            // lbl_matricula_view
            // 
            this.lbl_matricula_view.AutoSize = true;
            this.lbl_matricula_view.Location = new System.Drawing.Point(309, 20);
            this.lbl_matricula_view.Name = "lbl_matricula_view";
            this.lbl_matricula_view.Size = new System.Drawing.Size(0, 13);
            this.lbl_matricula_view.TabIndex = 6;
            // 
            // cb_nome_aluno
            // 
            this.cb_nome_aluno.FormattingEnabled = true;
            this.cb_nome_aluno.Location = new System.Drawing.Point(104, 17);
            this.cb_nome_aluno.Name = "cb_nome_aluno";
            this.cb_nome_aluno.Size = new System.Drawing.Size(189, 21);
            this.cb_nome_aluno.TabIndex = 5;
            this.cb_nome_aluno.SelectedIndexChanged += new System.EventHandler(this.cb_nome_aluno_SelectedIndexChanged);
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(58, 20);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(43, 13);
            this.lblAluno.TabIndex = 4;
            this.lblAluno.Text = "Aluno:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lbl_matricula_view);
            this.panel1.Controls.Add(this.cb_nome_aluno);
            this.panel1.Controls.Add(this.lblAluno);
            this.panel1.Location = new System.Drawing.Point(26, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(587, 55);
            this.panel1.TabIndex = 8;
            // 
            // frmConsAnalit_Aluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(637, 226);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_aluno);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmConsAnalit_Aluno";
            this.ShowIcon = false;
            this.Text = "Consulta por Aluno";
            this.Load += new System.EventHandler(this.frmConsAnalit_Aluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_aluno)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_aluno;
        private System.Windows.Forms.Label lbl_matricula_view;
        private System.Windows.Forms.ComboBox cb_nome_aluno;
        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Panel panel1;
    }
}