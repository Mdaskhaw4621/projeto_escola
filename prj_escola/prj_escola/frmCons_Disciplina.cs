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
    public partial class frmCons_Disciplina : Form
    {
        public frmCons_Disciplina()
        {
            InitializeComponent();
        }

        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_consul_disc;
        BindingSource bs_consul_disc = new BindingSource();
        String _query;

        private void frmCons_Disciplina_Load(object sender, EventArgs e)
        {
            carregar_grid();
        }

        private void carregar_grid()
        {

            _query = "Select * from Disciplinas";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_consul_disc = _dataCommand.ExecuteReader();

            if (dr_consul_disc.HasRows == true)
            {
                bs_consul_disc.DataSource = dr_consul_disc;
                dgvCons_Disc.DataSource = bs_consul_disc;
              
            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        
           
        private void txb_pesq_TextChanged(object sender, EventArgs e)
        {
            if (cbEscolha.Text == "Código da Disciplina")
            {
                _query = "Select * from Disciplinas where cod_disciplina like '" + txb_pesq.Text + "%'";
            } 
            else if (cbEscolha.Text == "Sigla")
            {
                _query = "Select * from Disciplinas where sigla like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Descrição")
            {
                _query = "Select * from Disciplinas where descricao like '" + txb_pesq.Text + "%'";
            }
            else if (cbEscolha.Text == "Série")
            {
                _query = "Select * from Disciplinas where série like '" + txb_pesq.Text + "%'";
            }
            else
            { 
                MessageBox.Show("Escolha um campo para pesquisar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cbEscolha.Focus();
    
            }
            txb_pesq.Focus();
            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);
            dr_consul_disc = _dataCommand.ExecuteReader();

            if (dr_consul_disc.HasRows == true)
            {
                bs_consul_disc.DataSource = dr_consul_disc;
            }
            else
            {
                MessageBox.Show("Não temos nenhuma disciplina cadastrada com este parâmetro!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txb_pesq.Clear();
            }
        }

        private void btnQtdSelec_Click(object sender, EventArgs e)
        {
            int a = bs_consul_disc.Count;
            MessageBox.Show("Quantidade: " + a, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void pD_Disciplina_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow linha;
            linha = dgvCons_Disc.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("logo1.PNG"), 50, -25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("FICHA INDIVIDUAL DA DISCIPLINA", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 100);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 160, 800, 160);

            // Matrícula
            e.Graphics.DrawString("CÓDIGO DA DISCIPLINA:  " + linha.Cells["cod_disciplina"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 200);
            // Nome
            e.Graphics.DrawString("SIGLA:   " + linha.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 220);
            // RG
            e.Graphics.DrawString("SÉRIE: " + linha.Cells["série"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 240);
            //CPF
            e.Graphics.DrawString("DESCRIÇÃO: " + linha.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, 260);
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            pDi_Disciplina.ShowDialog();
            pD_Disciplina.Print();     
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            pPDi_Disciplina.Text = " Visualizando a impressão";   // título da janela
            pPDi_Disciplina.WindowState = FormWindowState.Maximized;  // status da janela do preview
            pPDi_Disciplina.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            pPDi_Disciplina.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            pPDi_Disciplina.ShowDialog();
        }
    }
}
