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
    public partial class frmRegMencao : Form
    {

        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();

        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();

        OleDbDataReader dr_menc;
        BindingSource bs_menc = new BindingSource();

        OleDbDataReader dr_reg_notas;
        BindingSource bs_re_notas = new BindingSource();

        String _query;


        private void carregar_aluno()
        {
            _query = "SELECT * from Alunos order by Nome";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_alu = _dataCommand.ExecuteReader();

            if (dr_alu.HasRows == true)
            {
                bs_alu.DataSource = dr_alu;
                cbAluno.DataSource = bs_alu;
                cbAluno.DisplayMember = "nome";
                cbAluno.ValueMember = "matricula";
                lblMatricula_view.Text = cbAluno.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!","Atenção", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }
        }

        private void carregar_disciplina()
        {
            _query = "SELECT * from Disciplinas order by sigla";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                cbDisciplina.DataSource = bs_disc;
                cbDisciplina.DisplayMember = "sigla";
                cbDisciplina.ValueMember = "cod_disciplina";
                lblDisc_view.Text = cbDisciplina.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Não temos disciplinas cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void carregar_mencao()
        {
            _query = "SELECT * from Mencao order by Mencao";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_menc = _dataCommand.ExecuteReader();

            if (dr_menc.HasRows == true)
            {
                bs_menc.DataSource = dr_menc;
                cbMencao.DataSource = bs_menc;
                cbMencao.DisplayMember = "Mencao";
        
            }
        }

        private void carregar_grid()
        {

            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
            _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina";


            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_reg_notas = _dataCommand.ExecuteReader();

            if (dr_reg_notas.HasRows == true)
            {
                bs_re_notas.DataSource = dr_reg_notas;
                dgvReg_Mencao.DataSource = bs_re_notas;
            }
        }

        public frmRegMencao()
        {
            InitializeComponent();
        }

        private bool validar()
        {
            bool erro = true;
            if (cbAluno.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbAluno.Focus();
            }

            else if (cbDisciplina.Text == "")
            {
                MessageBox.Show("Sexo inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbDisciplina.Focus();
            }
            else if (cbMencao.Text == "")
            {
                MessageBox.Show("RG inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbMencao.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
             
	      bool teste;
            teste = validar();
            if (teste == false)
            {
                _query = "Insert into Registro_Mencoes (matricula,cod_disciplina,mencao) Values ";
                _query += "('" + lblMatricula_view.Text + "','" + lblDisc_view.Text + "','" + cbMencao.Text + "')";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Cadastrado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com o cadastros!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        
        }

        private void frmRegMencao_Load(object sender, EventArgs e)
        {
            carregar_aluno();
            carregar_disciplina();
            carregar_grid();
            carregar_mencao();
        }

        private void cbAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMatricula_view.Text = cbAluno.SelectedValue.ToString();
        }

        private void cbDisciplina_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisc_view.Text = cbDisciplina.SelectedValue.ToString();
        }

    

    }
}
