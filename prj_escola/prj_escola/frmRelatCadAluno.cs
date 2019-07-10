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
    public partial class frmRelatCadAluno : Form
    {
        public frmRelatCadAluno()
        {
            InitializeComponent();
            printDocument_Relat_Cad_Alu.DefaultPageSettings.Landscape = true;
        }

        OleDbConnection conn = Conexao.obterConexao();
        OleDbDataReader dr_relat_cad_alu;
        BindingSource bs_relat_cad_alu = new BindingSource();
        String _query;

        private void fmRelatCadAluno_Load(object sender, EventArgs e)
        {
            carregar_grid();
            fim = bs_relat_cad_alu.Count;
        }

        private void carregar_grid()
        {
            _query = "Select * from Alunos";

            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_relat_cad_alu = _dataCommand.ExecuteReader();

            if (dr_relat_cad_alu.HasRows == true)
            {
                bs_relat_cad_alu.DataSource = dr_relat_cad_alu;
                dgv_RelatCadAluno.DataSource = bs_relat_cad_alu;

            }
            else
            {
                MessageBox.Show("Não temos alunos cadastrados!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public int pag = 1; // variável para controlar o salto de página
        int registro, linha = 0, coluna = 0; //variável contadora de registros e linhas impressas, 
        int fim = 0; //variável que controla o fim da impressão

        private void printDocument_Relat_Cad_Alu_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DataGridViewRow reg_grid;
            reg_grid = dgv_RelatCadAluno.CurrentRow;

            e.Graphics.DrawImage(Image.FromFile("logo1.PNG"), 50, -25);
            // texto = objimpressao.DrawString(string,fonte,cor,coluna,linha)
            e.Graphics.DrawString("RELATÓRIO GERAL DE ALUNOS", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 400, 75);
            //linha – cor, espessura, posição x – ponto inicial(coluna e linha), posição y – ponto final (coluna e linha)

            linha = 150;
            

            // cabeçalho de colunas
            e.Graphics.DrawString("Matrícula   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 50, linha);
            e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 140, linha);
            e.Graphics.DrawString("Dt. Nasc.   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 275, linha);
            e.Graphics.DrawString("Endereço ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 370, linha);
            e.Graphics.DrawString("Numero   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 555, linha);
            e.Graphics.DrawString("Bairro   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 625, linha);
            e.Graphics.DrawString("Cidade   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 715, linha);
            e.Graphics.DrawString("CEP   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 803, linha);
            e.Graphics.DrawString("RG   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 898, linha);
           // e.Graphics.DrawString("Tel.   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 475, linha);
           // e.Graphics.DrawString("Cidade   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 525, linha);
           // e.Graphics.DrawString(   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 575, linha);
            e.Graphics.DrawString("Sexo   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 1008, linha);

            linha = 200;
           

            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 2), 50, 130, 1120, 130);

            while ((linha < 715) & (registro != fim))
            {
                
                e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 75, linha);
                
                e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 140, linha);

                e.Graphics.DrawString(String.Format("{0:dd/MM/yyyy}", reg_grid.Cells["Nasc"].Value), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 275, linha);

                e.Graphics.DrawString(reg_grid.Cells["Endereco"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 365, linha);

                e.Graphics.DrawString(reg_grid.Cells["numero"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 555, linha);

                e.Graphics.DrawString(reg_grid.Cells["bairro"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 625, linha);

                e.Graphics.DrawString(reg_grid.Cells["cidade"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 715, linha);

                e.Graphics.DrawString(reg_grid.Cells["cep"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 803, linha);

                e.Graphics.DrawString(reg_grid.Cells["RG"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 898, linha);

                e.Graphics.DrawString(reg_grid.Cells["sexo"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 1008, linha);
                
               
                
                bs_relat_cad_alu.MoveNext(); // movendo para o próximo registro

                reg_grid = dgv_RelatCadAluno.CurrentRow;  // atualizando a linha da grid para impressão


                registro += 1;   // incrementando a variável contadora de registros

                linha += 20; // incrementando a variável para pular linha
                
                
            }

            //***************************** 
            //imprime o rodapé do relatório 
            //***************************** 
            e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 925, 755);
            e.Graphics.DrawLine(new Pen(Color.DarkBlue, 1), 50, 780, 1120, 780);
            e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 85, 800);
            e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Blue, 925, 800);

            pag += 1;  // reajustando contadores de pag

            // trocando de página
            if ((pag > 1) & (registro < fim))
            {
                e.HasMorePages = true;

            }
            else
            {
                e.HasMorePages = false;
                registro = 0;
                pag = 1;
                bs_relat_cad_alu.MoveFirst();
            }
            // Enquanto e.HasMorePages==true toda programação dentro do “PrintDocument” será reiniciada. 
            // Quando e.HasMorePages==false a programação do “PrintDocument” será encerrada.  
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDialog_Relat_Cad_Alu.ShowDialog();
            printDocument_Relat_Cad_Alu.Print();
           
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            printPreviewDialog_Relat_Cad_Alu.Text = " Visualizando a impressão";   // título da janela
            printPreviewDialog_Relat_Cad_Alu.WindowState = FormWindowState.Maximized;  // status da janela do preview
            printPreviewDialog_Relat_Cad_Alu.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            printPreviewDialog_Relat_Cad_Alu.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            printPreviewDialog_Relat_Cad_Alu.ShowDialog();
        }
    }
}
