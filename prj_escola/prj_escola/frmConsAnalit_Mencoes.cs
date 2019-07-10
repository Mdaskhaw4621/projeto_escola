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
    public partial class frmCons_Analit_Mencoes : Form
    {
        public frmCons_Analit_Mencoes()
        {
            InitializeComponent();
        }

        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_menc;
        BindingSource bs_menc = new BindingSource();

        OleDbDataReader dr_menc_cons;
        BindingSource bs_menc_cons = new BindingSource();

        String _query;

        int a;

        private void carregar_Mencoes()
        {
            _query = "SELECT * from Mencao";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_menc = _dataCommand.ExecuteReader();

            if (dr_menc.HasRows == true)
            {
                bs_menc.DataSource = dr_menc;
                cb_mencoes.DataSource = bs_menc;
                cb_mencoes.DisplayMember = "Mencao";
            }
        }
            
             private void carregar_grid()
        {

            _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
            _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_menc_cons = _dataCommand.ExecuteReader();

            if (dr_menc.HasRows == true)
            {
                bs_menc_cons.DataSource = dr_menc_cons;
                dgv_mencoes.DataSource = bs_menc_cons;
            }
        }


        private void cb_menções_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a == 1)
            {

                _query = "SELECT Alunos.Nome, Disciplinas.sigla, Disciplinas.descricao, Registro_Mencoes.mencao";
                _query += " FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina where Registro_Mencoes.mencao like '" + cb_mencoes.Text + "%'";

                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                dr_menc_cons = _dataCommand.ExecuteReader();

                if (dr_menc_cons.HasRows == true)
                {
                    bs_menc_cons.DataSource = dr_menc_cons;
                }
            }
        }

        private void frmCad_Analit_Mencoes_Load(object sender, EventArgs e)
        {
            carregar_Mencoes();
            carregar_grid();
            a = 1; 
        }
    }
}
