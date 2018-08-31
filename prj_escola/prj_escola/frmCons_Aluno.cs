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
    public partial class frmCons_Aluno : Form
    {
        public frmCons_Aluno()
        {
            InitializeComponent();
        }

        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_consul_aluno;
        BindingSource bs_consul_aluno = new BindingSource();
        String _query;

        private void frmCons_Aluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void carregar_grid()
        {

            _query = "Select * from Alunos";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_consul_aluno = _dataCommand.ExecuteReader();

            if (dr_consul_aluno.HasRows == true)
            {
                bs_consul_aluno.DataSource = dr_consul_aluno;
                dgvCons_Aluno.DataSource = bs_consul_aluno;

            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnQtdSelec_Click(object sender, EventArgs e)
        {
            int a = bs_consul_aluno.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        
        private void txb_pesq_TextChanged(object sender, EventArgs e)
        {
            if (cbEscolha.Text == "Nome")
            {
                _query = "Select * from Alunos where Nome like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Matrícula")
            {
                _query = "Select * from Alunos where Matricula like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "RG")
            {
                _query = "Select * from Alunos where RG like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "CPF")
            {
                _query = "Select * from Alunos where cpf like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Data de Nascimento")
            {
                _query = "Select * from Alunos where Nasc like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Endereço")
            {
                _query = "Select * from Alunos where Endereco like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "CEP")
            {
                _query = "Select * from Alunos where cep like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Cidade")
            {
                _query = "Select * from Alunos where cidade like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Sexo")
            {
                _query = "Select * from Alunos where sexo like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Telefone")
            {
                _query = "Select * from Alunos where telefone like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Bairro")
            {
                _query = "Select * from Alunos where bairro like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Número")
            {
                _query = "Select * from Alunos where numero like '" + txb_pesq.Text + "%'";
            }
            else
            {
                MessageBox.Show("Escolha um campo para pesquisar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbEscolha.Focus();

            }
            txb_pesq.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_consul_aluno = _dataCommand.ExecuteReader();

            if (dr_consul_aluno.HasRows == true)
            {
                bs_consul_aluno.DataSource = dr_consul_aluno;
            }
            else
            {
                MessageBox.Show("Não temos nenhuma disciplina cadastrada com este parâmetro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_pesq.Clear();
            }
        }

        private void pD_Aluno_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvCons_Aluno.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("logo1.PNG"), 50, -25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DO ALUNO", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 100);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 160, 800, 160);

            // Matrícula
            e.Graphics.DrawString("MATRÍCULA:  " + linha.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 200);
            // Nome
            e.Graphics.DrawString("NOME:   " + linha.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 220);
            // RG
            e.Graphics.DrawString("RG: " + linha.Cells["RG"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 240);
            //CPF
            e.Graphics.DrawString("CPF: " + linha.Cells["cpf"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 260);
            //Data de Nascimento
            e.Graphics.DrawString("DATA DE NASCIMENTO: " + linha.Cells["Nasc"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 280);
            //Endereco
            e.Graphics.DrawString("ENDEREÇO: " + linha.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 300);
            //CEP
            e.Graphics.DrawString("CEP: " + linha.Cells["cep"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 320);
            //Cidade
            e.Graphics.DrawString("CIDADE: " + linha.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 340);
            //Sexo
            e.Graphics.DrawString("SEXO: " + linha.Cells["sexo"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 360);
            //Telefone
            e.Graphics.DrawString("TELEFONE: " + linha.Cells["telefone"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 380);
            //Bairro
            e.Graphics.DrawString("BAIRRO: " + linha.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 400);
            //Número
            e.Graphics.DrawString("NÚMERO: " + linha.Cells["numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 420);

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 1100, 800, 1100);

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pDi_Aluno.ShowDialog();
            pD_Aluno.Print();                             

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pPDi_Aluno.Text = " Visualizando a impressão";   // título da janela
            pPDi_Aluno.WindowState = FormWindowState.Maximized;  // status da janela do preview
            pPDi_Aluno.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            pPDi_Aluno.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            pPDi_Aluno.ShowDialog();

        }
    }
}
