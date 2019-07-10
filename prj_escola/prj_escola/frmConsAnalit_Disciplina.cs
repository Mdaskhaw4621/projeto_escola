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
    public partial class frmConsAnalit_Disciplina : Form
    {
        public frmConsAnalit_Disciplina()
        {
            InitializeComponent();
        }

        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_disc;
        BindingSource bs_disc = new BindingSource();

        OleDbDataReader dr_disc_cons;
        BindingSource bs_disc_cons = new BindingSource();

        String _query;

        int a = 0;

        private void carregar_disciplina()
        {
            _query = "SELECT * from Disciplinas order by sigla";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_disc = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc.DataSource = dr_disc;
                cb_sigla_disc.DataSource = bs_disc;
                cb_sigla_disc.DisplayMember = "sigla";
                cb_sigla_disc.ValueMember = "cod_disciplina";
                lbl_descri_view.Text = cb_sigla_disc.SelectedValue.ToString();
            }
            else
            {
                MessageBox.Show("Não temos disciplinas cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        private void carregar_grid()
        {

            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
            _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_disc_cons = _dataCommand.ExecuteReader();

            if (dr_disc.HasRows == true)
            {
                bs_disc_cons.DataSource = dr_disc_cons;
                dgv_disc.DataSource = bs_disc_cons;
            }

        }

        private void frmConsAnalit_Disciplina_Load(object sender, EventArgs e)
        {
           
            carregar_disciplina();
            carregar_grid();

            a = 1;
        }

        private void cb_sigla_disc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {

                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
                _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina where Disciplinas.sigla like '" + cb_sigla_disc.Text + "%'";

                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_disc_cons = _dataCommand.ExecuteReader();

                if (dr_disc_cons.HasRows == true)
                {
                    bs_disc_cons.DataSource = dr_disc_cons;
                }
                else
                {
                    MessageBox.Show("Não temos nenhuma disciplina cadastrada com esta sigla!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    cb_sigla_disc.Text = "";
                }
            }
        }
    }
}

