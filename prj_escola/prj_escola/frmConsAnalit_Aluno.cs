using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace prj_escola
{
    public partial class frmConsAnalit_Aluno : Form
    {
        public frmConsAnalit_Aluno()
        {
            InitializeComponent();
        }


        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_alu;
        BindingSource bs_alu = new BindingSource();

        OleDbDataReader dr_alu_cons;
        BindingSource bs_alu_cons = new BindingSource();

        String _query;

        int a = 0;

        private void carregar_alunos()
        {
            _query = "SELECT * from Alunos order by Nome";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_alu = _dataCommand.ExecuteReader();

            if (dr_alu.HasRows == true)
            {
                bs_alu.DataSource = dr_alu;
                cb_nome_aluno.DataSource = bs_alu;
                cb_nome_aluno.DisplayMember = "Nome";
                cb_nome_aluno.ValueMember = "Matricula";
                lbl_matricula_view.Text = cb_nome_aluno.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void carregar_grid()
        {

            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
            _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_alu_cons = _dataCommand.ExecuteReader();

            if (dr_alu.HasRows == true)
            {
                bs_alu_cons.DataSource = dr_alu_cons;
                dgv_aluno.DataSource = bs_alu_cons;
            }

        }
              

        private void frmConsAnalit_Aluno_Load(object sender, EventArgs e)
        {
            carregar_alunos();
            carregar_grid();
            a = 1;
        }

        private void cb_nome_aluno_SelectedIndexChanged(object sender, EventArgs e)
        {
               if (a == 1)
            {

                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
                _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina where Alunos.Nome like '" + cb_nome_aluno.Text + "%'";

                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_alu_cons = _dataCommand.ExecuteReader();

                if (dr_alu_cons.HasRows == true)
                {
                    bs_alu_cons.DataSource = dr_alu_cons;
                }
                else
                {
                    MessageBox.Show("Não temos nenhum aluno cadastrado com este nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cb_nome_aluno.Text = "";
                }
            }
        }
    }
}

