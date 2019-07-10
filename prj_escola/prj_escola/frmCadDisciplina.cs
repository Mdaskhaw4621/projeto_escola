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
    public partial class frmCadDisciplina : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_disciplinas;
        BindingSource bs_disciplinas = new BindingSource();
        String _query;

        private void carregar_grid()
        {

            _query = "Select * from Disciplinas";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_disciplinas = _dataCommand.ExecuteReader();

            if (dr_disciplinas.HasRows == true)
            {
                bs_disciplinas.DataSource = dr_disciplinas;
                dgvDisciplina.DataSource = bs_disciplinas;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos disciplinas cadastradas!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void igualar_text()
        {
            lblCod_Disciplina_view.DataBindings.Add("Text", bs_disciplinas, "cod_disciplina");
            lblCod_Disciplina_view.DataBindings.Clear();
            txbDescri.DataBindings.Add("Text", bs_disciplinas, "descricao");
            txbDescri.DataBindings.Clear();
            txbSigla.DataBindings.Add("Text", bs_disciplinas, "sigla");
            txbSigla.DataBindings.Clear();
            txbSerie.DataBindings.Add("Text", bs_disciplinas, "série");
            txbSerie.DataBindings.Clear();
        }

        public frmCadDisciplina()
        {
            InitializeComponent();
        }

        private void frmCadDisciplina_Load(object sender, EventArgs e)
        {
            carregar_grid();
            igualar_text();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            bs_disciplinas.MoveFirst();
            igualar_text();
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            bs_disciplinas.MoveLast();
            igualar_text();
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (bs_disciplinas.Position == 0)
                MessageBox.Show("Inicio de arquivo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_disciplinas.MovePrevious();
            igualar_text();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (bs_disciplinas.Count == bs_disciplinas.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_disciplinas.MoveNext();
            igualar_text();

        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            _query = "delete from Disciplinas where cod_disciplina like '" + lblCod_Disciplina_view.Text + "'";
            try
            {
                OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                _dataCommand.ExecuteNonQuery();
                carregar_grid();
                MessageBox.Show("Excluido com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Problemas com a Exclusão!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Insert into Disciplinas (descricao,sigla,série) Values ";
                _query += "('" + txbDescri.Text + "','" + txbSigla.Text + "','" + txbSerie.Text +"')";
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

        private bool valida()
        {
            bool erro = true;
            if (txbSigla.Text == "")
            {
                MessageBox.Show("Sigla inválida. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbSigla.Focus();
            }

            else if (txbDescri.Text == "")
            {
                MessageBox.Show("Descrição inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbDescri.Focus();
            }
            
            else
            {
                erro = false;
            }
            return erro;
        }

        private void limpar()
        {
            lblCod_Disciplina_view.Text = "";
            txbSigla.Clear();
            txbDescri.Clear();
            txbSerie.Clear();           
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            txbSigla.Focus();
        }

        private void dgvDisciplina_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void dgvDisciplina_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void dgvDisciplina_KeyDown(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool teste; 
            teste = valida();
            if (teste == false)
            {
                _query = "Update Disciplinas set descricao ='" + txbDescri.Text + "',";
                _query += "sigla = '" + txbSigla.Text + "',";
                _query += "série = '" + txbSerie.Text + "'";
                _query += "where cod_disciplina like '" + lblCod_Disciplina_view.Text + "'";
                try
                {
                    OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
                    _dataCommand.ExecuteNonQuery();
                    carregar_grid();
                    MessageBox.Show("Alterado com sucesso!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                catch (Exception)
                {
                    MessageBox.Show("Problemas com a Alteração!", "Alteração", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        /*private void txbPesq_Nome_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Disciplinas where sigla like '" + txbPesq_Sigla.Text + "%'";                     
           OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
           dr_disciplinas = _dataCommand.ExecuteReader();
                       
           if (dr_disciplinas.HasRows == true)
           {               
               bs_disciplinas.DataSource = dr_disciplinas;            
           }
           else
           {
               MessageBox.Show("Não temos disciplina cadastrada com está sigla!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               txbPesq_Sigla.Text = "";
           }
        }
        */
        private void txbPesq_Sigla_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Disciplinas where sigla like '" + txbPesq_Sigla.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_disciplinas = _dataCommand.ExecuteReader();

            if (dr_disciplinas.HasRows == true)
            {
                bs_disciplinas.DataSource = dr_disciplinas;
            }
            else
            {
                MessageBox.Show("Não temos nenhuma disciplina cadastrada com esta sigla!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesq_Sigla.Text = "";
            }
        }
    }
}
