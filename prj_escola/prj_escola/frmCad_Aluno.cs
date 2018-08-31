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
    public partial class frmCad_Aluno : Form
    {
        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_alunos;
        BindingSource bs_alunos = new BindingSource();
        String _query;

        private void carregar_grid()
        {
            
            _query = "Select * from Alunos";
            
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            
            dr_alunos = _dataCommand.ExecuteReader();
           
            if (dr_alunos.HasRows == true)
            {
                bs_alunos.DataSource = dr_alunos;
                dgvAluno.DataSource = bs_alunos;
                igualar_text();
            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

       private void igualar_text()
        {
            lblMatricula_view.DataBindings.Add("Text", bs_alunos, "Matricula");
            lblMatricula_view.DataBindings.Clear();
            txbNome.DataBindings.Add("Text", bs_alunos, "Nome");
            txbNome.DataBindings.Clear();
            dtpData_Nasc.DataBindings.Add("Text", bs_alunos, "Nasc");
            dtpData_Nasc.DataBindings.Clear();
            txbEnderec.DataBindings.Add("Text", bs_alunos, "Endereco");
            txbEnderec.DataBindings.Clear();
            txbNumero.DataBindings.Add("Text", bs_alunos, "numero");
            txbNumero.DataBindings.Clear();
            txbBairro.DataBindings.Add("Text", bs_alunos, "bairro");
            txbBairro.DataBindings.Clear();
            txbCidade.DataBindings.Add("Text", bs_alunos, "cidade");
            txbCidade.DataBindings.Clear();
            masktxbCEP.DataBindings.Add("Text", bs_alunos, "cep");
            masktxbCEP.DataBindings.Clear();
            masktxbRG.DataBindings.Add("Text", bs_alunos, "RG");
            masktxbRG.DataBindings.Clear();
            masktxbTelef.DataBindings.Add("Text", bs_alunos, "telefone");
            masktxbTelef.DataBindings.Clear();
            masktxbCPF.DataBindings.Add("Text", bs_alunos, "cpf");
            masktxbCPF.DataBindings.Clear();
            cbSexo.DataBindings.Add("Text", bs_alunos, "sexo");
            cbSexo.DataBindings.Clear();
        }

      
        public frmCad_Aluno()
        {
            InitializeComponent();
        }

        private void frmCad_Aluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
            igualar_text();
        }

        private void dgvAluno_Click(object sender, EventArgs e)
        {
            igualar_text();
        }

        private void limpar()
        {
            lblMatricula_view.Text = "";
            txbNome.Clear();
            masktxbRG.Clear();
            masktxbCPF.Clear();
            masktxbCEP.Clear();
            dtpData_Nasc.Text = DateTime.Now.ToString("dd/MM/yyyy");
            masktxbTelef.Clear();
            txbEnderec.Clear();
            txbCidade.Clear();
            txbNumero.Clear();
            cbSexo.ResetText();
            txbBairro.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpar();
            txbNome.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _query = "delete from Alunos where Matricula like '" + lblMatricula_view.Text + "'";
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
            _query = "Insert into Alunos (Nome,Nasc,Endereco,numero,bairro,cidade,cep,RG,telefone,cpf,sexo) Values ";
            _query += "('" + txbNome.Text + "','" + dtpData_Nasc.Text + "','" + txbEnderec.Text + "','" + txbNumero.Text + "','" + txbBairro.Text + "','" + txbCidade.Text + "','" + masktxbCEP.Text + "','" + masktxbRG.Text + "','" + masktxbTelef.Text + "','" + masktxbCPF.Text + "','" + cbSexo.Text + "')";
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
            if (txbNome.Text == "")
            {
                MessageBox.Show("Nome inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNome.Focus();
            }

            else if (cbSexo.Text == "")
            {
                MessageBox.Show("Sexo inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbSexo.Focus();
            }
            else if (masktxbRG.MaskFull == false)
            {
                MessageBox.Show("RG inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                masktxbRG.Focus();
            }

            else if (masktxbCPF.MaskFull == false)
            {
                MessageBox.Show("CPF inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                masktxbCPF.Focus();
            }
            else if (masktxbTelef.Text == "")
            {
                MessageBox.Show("Telefone inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                masktxbTelef.Focus();
            }
            else if (txbEnderec.Text == "")
            {
                MessageBox.Show("Endereço inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbEnderec.Focus();
            }
            else if (masktxbCEP.Text == "")
            {
                MessageBox.Show("CEP inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                masktxbCEP.Focus();
            }
            else if (txbBairro.Text == "")
            {
                MessageBox.Show("Bairro inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbBairro.Focus();
            }
            else if (txbCidade.Text == "")
            {
                MessageBox.Show("Cidade inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbCidade.Focus();
            }
            else if (txbNumero.Text == "")
            {
                MessageBox.Show("Número inválido. Redigite !!", "Atenção!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbNumero.Focus();
            }
            else
            {
                erro = false;
            }
            return erro;
        }

        private void dgvAluno_KeyUp(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void dgvAluno_KeyDown(object sender, KeyEventArgs e)
        {
            igualar_text();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool teste;
            teste = valida();
            if (teste == false)
            {
                _query = "Update Alunos set Nome ='" + txbNome.Text + "',";
                _query += "Nasc = '" + dtpData_Nasc.Text + "',";
                _query += "Endereco = '" + txbEnderec.Text + "',";
                _query += "numero = '" + txbNumero.Text + "',";
                _query += "bairro = '" + txbBairro.Text + "',";
                _query += "cidade = '" + txbCidade.Text + "',";
                _query += "cep = '" + masktxbCEP.Text + "',";
                _query += "RG = '" + masktxbRG.Text + "',";
                _query += "telefone = '" + masktxbTelef.Text + "',";
                _query += "cpf = '" + masktxbCPF.Text + "',";
                _query += "sexo = '" + cbSexo.Text + "'";
                _query += "where Matricula like '" + lblMatricula_view.Text + "'";
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
    
        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            if (bs_alunos.Position == 0)
                MessageBox.Show("Inicio de arquivo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_alunos.MovePrevious();
            igualar_text();
        }

        private void btnUltimo_Click_1(object sender, EventArgs e)
        {
            bs_alunos.MoveLast();
            igualar_text();
        }

        private void btnPrimeiro_Click_1(object sender, EventArgs e)
        {
            bs_alunos.MoveFirst();
            igualar_text();

        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (bs_alunos.Count == bs_alunos.Position + 1)
                MessageBox.Show("Fim de arquivo encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                bs_alunos.MoveNext();
            igualar_text();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txbPesq_Nome_TextChanged(object sender, EventArgs e)
        {
            _query = "Select * from Alunos where Nome like '" + txbPesq_Nome.Text + "%'";
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_alunos = _dataCommand.ExecuteReader();

            if (dr_alunos.HasRows == true)
            {
                bs_alunos.DataSource = dr_alunos;
            }
            else
            {
                MessageBox.Show("Não temos nenhum aluno cadastrado com este nome!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txbPesq_Nome.Text = "";
            }
        }
    }
}
