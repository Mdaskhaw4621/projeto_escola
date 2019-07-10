using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_escola
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            tsslHora.Text = "Hora: " + DateTime.Now.ToString("HH:mm");
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCad_Aluno frmC_aluno = new frmCad_Aluno();
            frmC_aluno.MdiParent = this;
            frmC_aluno.Show();
        }

        private void disciplinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadDisciplina frmC_disc = new frmCadDisciplina();
            frmC_disc.MdiParent = this;
            frmC_disc.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
           
            frmSobre.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmCad_Aluno frmC_aluno = new frmCad_Aluno();
            frmC_aluno.MdiParent = this;
            frmC_aluno.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmCadDisciplina frmC_disc = new frmCadDisciplina();
            frmC_disc.MdiParent = this;
            frmC_disc.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCons_Disciplina frmCons_Disc = new frmCons_Disciplina();
            frmCons_Disc.MdiParent = this;
            frmCons_Disc.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            frmCons_Disciplina frmCons_Disc = new frmCons_Disciplina();
            frmCons_Disc.MdiParent = this;
            frmCons_Disc.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCons_Aluno frmCons_aluno = new frmCons_Aluno();
            frmCons_aluno.MdiParent = this;
            frmCons_aluno.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            frmCons_Aluno frmCons_aluno = new frmCons_Aluno();
            frmCons_aluno.MdiParent = this;
            frmCons_aluno.Show();
        }

        private void registrarMençõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegMencao frmReg_men = new frmRegMencao();
            frmReg_men.MdiParent = this;
            frmReg_men.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsAnalit_Disciplina frmCAnalit_Disc = new frmConsAnalit_Disciplina();
            frmCAnalit_Disc.MdiParent = this;
            frmCAnalit_Disc.Show();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmConsAnalit_Aluno frmCAnalit_Alu = new frmConsAnalit_Aluno();
            frmCAnalit_Alu.MdiParent = this;
            frmCAnalit_Alu.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            frmCons_Analit_Mencoes frmCon_Anali_Men = new frmCons_Analit_Mencoes();
            frmCon_Anali_Men.MdiParent = this;
            frmCon_Anali_Men.Show();

        }

        private void disciplinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatCadDisc frm_relat_disc = new frmRelatCadDisc();
            frm_relat_disc.MdiParent = this ;
            frm_relat_disc.Show();

        }

        private void alunosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmRelatCadAluno frm_relat_aluno = new frmRelatCadAluno();
            frm_relat_aluno.MdiParent = this;
            frm_relat_aluno.Show();
        }

        private void analíticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelat_Analit frm_relat_analit = new frmRelat_Analit();
            frm_relat_analit.MdiParent = this;
            frm_relat_analit.Show();
        }
    }
}
