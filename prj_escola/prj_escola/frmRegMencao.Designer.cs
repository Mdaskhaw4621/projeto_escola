namespace prj_escola
{
    partial class frmRegMencao
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
            this.lblAluno = new System.Windows.Forms.Label();
            this.lblDisc = new System.Windows.Forms.Label();
            this.lblMencao = new System.Windows.Forms.Label();
            this.cbMencao = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvReg_Mencao = new System.Windows.Forms.DataGridView();
            this.cbAluno = new System.Windows.Forms.ComboBox();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.lblMatricula_view = new System.Windows.Forms.Label();
            this.lblDisc_view = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg_Mencao)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAluno
            // 
            this.lblAluno.AutoSize = true;
            this.lblAluno.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAluno.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAluno.Location = new System.Drawing.Point(70, 56);
            this.lblAluno.Name = "lblAluno";
            this.lblAluno.Size = new System.Drawing.Size(43, 13);
            this.lblAluno.TabIndex = 0;
            this.lblAluno.Text = "Aluno:";
            // 
            // lblDisc
            // 
            this.lblDisc.AutoSize = true;
            this.lblDisc.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblDisc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisc.Location = new System.Drawing.Point(12, 64);
            this.lblDisc.Name = "lblDisc";
            this.lblDisc.Size = new System.Drawing.Size(66, 13);
            this.lblDisc.TabIndex = 1;
            this.lblDisc.Text = "Disciplina:";
            // 
            // lblMencao
            // 
            this.lblMencao.AutoSize = true;
            this.lblMencao.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblMencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMencao.Location = new System.Drawing.Point(70, 133);
            this.lblMencao.Name = "lblMencao";
            this.lblMencao.Size = new System.Drawing.Size(56, 13);
            this.lblMencao.TabIndex = 2;
            this.lblMencao.Text = "Menção:";
            // 
            // cbMencao
            // 
            this.cbMencao.FormattingEnabled = true;
            this.cbMencao.Location = new System.Drawing.Point(134, 130);
            this.cbMencao.Name = "cbMencao";
            this.cbMencao.Size = new System.Drawing.Size(110, 21);
            this.cbMencao.TabIndex = 5;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.Gold;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Image = global::prj_escola.Properties.Resources.add_circular_outlined_button;
            this.btnRegistrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegistrar.Location = new System.Drawing.Point(554, 133);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Padding = new System.Windows.Forms.Padding(17, 0, 17, 0);
            this.btnRegistrar.Size = new System.Drawing.Size(157, 59);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registar";
            this.btnRegistrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvReg_Mencao
            // 
            this.dgvReg_Mencao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReg_Mencao.Location = new System.Drawing.Point(47, 198);
            this.dgvReg_Mencao.Name = "dgvReg_Mencao";
            this.dgvReg_Mencao.Size = new System.Drawing.Size(664, 231);
            this.dgvReg_Mencao.TabIndex = 7;
            // 
            // cbAluno
            // 
            this.cbAluno.FormattingEnabled = true;
            this.cbAluno.Location = new System.Drawing.Point(120, 53);
            this.cbAluno.Name = "cbAluno";
            this.cbAluno.Size = new System.Drawing.Size(313, 21);
            this.cbAluno.TabIndex = 8;
            this.cbAluno.SelectedIndexChanged += new System.EventHandler(this.cbAluno_SelectedIndexChanged);
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(134, 92);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(299, 21);
            this.cbDisciplina.TabIndex = 9;
            this.cbDisciplina.SelectedIndexChanged += new System.EventHandler(this.cbDisciplina_SelectedIndexChanged);
            // 
            // lblMatricula_view
            // 
            this.lblMatricula_view.AutoSize = true;
            this.lblMatricula_view.Location = new System.Drawing.Point(465, 53);
            this.lblMatricula_view.Name = "lblMatricula_view";
            this.lblMatricula_view.Size = new System.Drawing.Size(0, 13);
            this.lblMatricula_view.TabIndex = 10;
            // 
            // lblDisc_view
            // 
            this.lblDisc_view.AutoSize = true;
            this.lblDisc_view.Location = new System.Drawing.Point(465, 95);
            this.lblDisc_view.Name = "lblDisc_view";
            this.lblDisc_view.Size = new System.Drawing.Size(0, 13);
            this.lblDisc_view.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel1.Controls.Add(this.lblDisc);
            this.panel1.Location = new System.Drawing.Point(47, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(458, 145);
            this.panel1.TabIndex = 12;
            // 
            // frmRegMencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(768, 466);
            this.Controls.Add(this.lblDisc_view);
            this.Controls.Add(this.lblMatricula_view);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.cbAluno);
            this.Controls.Add(this.dgvReg_Mencao);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cbMencao);
            this.Controls.Add(this.lblMencao);
            this.Controls.Add(this.lblAluno);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRegMencao";
            this.ShowIcon = false;
            this.Text = "Registrar Menção";
            this.Load += new System.EventHandler(this.frmRegMencao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReg_Mencao)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAluno;
        private System.Windows.Forms.Label lblDisc;
        private System.Windows.Forms.Label lblMencao;
        private System.Windows.Forms.ComboBox cbMencao;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvReg_Mencao;
        private System.Windows.Forms.ComboBox cbAluno;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label lblMatricula_view;
        private System.Windows.Forms.Label lblDisc_view;
        private System.Windows.Forms.Panel panel1;
    }
}