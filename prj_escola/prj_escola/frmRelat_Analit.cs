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
    public partial class frmRelat_Analit : Form
    {
        public frmRelat_Analit()
        {
            InitializeComponent();

        }

        OleDbConnection conn = Conexao.obterConexao();

        OleDbDataReader dr_relat_analit_menc;
        BindingSource bs_relat_analit_menc = new BindingSource();

        OleDbDataReader dr_relat_analit_menc_view;
        BindingSource bs_relat_analit_menc_view = new BindingSource();

        String _query, ment_atual, ment_antiga, discip_atual, discip_antiga,
            nome_atual, nome_antigo;

        int i = 1;

        private void carregar_grid()
        {
            _query = "SELECT Registro_Mencoes.mencao, Alunos.Nome, Alunos.Matricula, Disciplinas.sigla, Disciplinas.descricao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina";


            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_relat_analit_menc_view = _dataCommand.ExecuteReader();

            if (dr_relat_analit_menc_view.HasRows == true)
            {
                bs_relat_analit_menc_view.DataSource = dr_relat_analit_menc_view;
                dgv_relatAnalit.DataSource = bs_relat_analit_menc_view;
            }


        }

        private void frmRelat_Analit_Load(object sender, EventArgs e)
        {
            carregar_grid();
            fim = bs_relat_analit_menc_view.Count;
        }

        private void cb_opcoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_opcoes.Text == "Agrupado por Disciplina")
            {
                _query = "SELECT Disciplinas.sigla, Disciplinas.descricao, Alunos.Nome, Alunos.Matricula, Registro_Mencoes.mencao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Disciplinas.sigla";
            }
            else if (cb_opcoes.Text == "Agrupado por Menção")
            {

                _query = "SELECT Registro_Mencoes.mencao, Alunos.Nome, Alunos.Matricula, Disciplinas.sigla, Disciplinas.descricao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Registro_Mencoes.mencao";
            }
            else if (cb_opcoes.Text == "Boletim")
            {

                _query = "SELECT Registro_Mencoes.mencao, Alunos.Nome, Alunos.Matricula, Disciplinas.sigla, Disciplinas.descricao FROM Disciplinas INNER JOIN (Alunos INNER JOIN Registro_Mencoes ON Alunos.Matricula = Registro_Mencoes.matricula) ON Disciplinas.cod_disciplina = Registro_Mencoes.cod_disciplina ORDER BY Alunos.Nome";
            }


            OleDbCommand _dataCommand = new OleDbCommand(_query, conn);

            dr_relat_analit_menc_view = _dataCommand.ExecuteReader();

            if (dr_relat_analit_menc_view.HasRows == true)
            {
                bs_relat_analit_menc_view.DataSource = dr_relat_analit_menc_view;
                dgv_relatAnalit.DataSource = bs_relat_analit_menc_view;
            }
        }

        public int pag = 1;
        int linha = 0, registro, fim = 0;

        private void printDocument_RelatAnalit_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            DataGridViewRow reg_grid;
            reg_grid = dgv_relatAnalit.CurrentRow;

            if (cb_opcoes.Text == "Agrupado por Menção")
            {
                e.Graphics.DrawImage(Image.FromFile("logo1.PNG"), 50, -25);

                e.Graphics.DrawString("RELATÓRIO AGRUPADO POR MENÇÂO", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 325, 75);



                linha = 163;
                int j = 0, k = 0;
                while ((linha < 950) & (registro != fim))
                {

                    ment_atual = reg_grid.Cells["mencao"].Value.ToString();

                    if (ment_atual != ment_antiga || j == 0)
                    {
                        if (j == 0 && ment_atual != ment_antiga || pag > 1)
                        {
                            if (pag > 1 && ment_atual != ment_antiga)
                            {
                                linha += 15;
                                e.Graphics.DrawString("Total de Menções " + ment_antiga + ": " + k.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha);
                                linha += 15;
                                i = 0;
                            }

                            linha += 25;
                            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 780, linha);
                            linha += 6;
                            e.Graphics.DrawString("Menção: " + ment_atual, new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 75, linha);

                            linha += 29;
                            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 780, linha);
                            linha += 17;

                            e.Graphics.DrawString("Mat  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 75, linha);
                            e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 150, linha);
                            e.Graphics.DrawString("Sigla  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 275, linha);
                            e.Graphics.DrawString("Descrição   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 350, linha);


                            linha += 25;

                            ment_antiga = ment_atual;

                            j++;


                        }


                        else if (ment_atual != ment_antiga)
                        {

                            e.Graphics.DrawString("Total de Menções " + ment_antiga + ": " + i.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha + 20);
                            j = 0;
                            i = 0;
                        }





                    }


                    e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 75, linha);
                    e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 150, linha);
                    e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 275, linha);
                    e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 350, linha);

                    if (ment_atual == ment_antiga)
                    {
                        k++;
                    }



                    bs_relat_analit_menc_view.MoveNext();

                    reg_grid = dgv_relatAnalit.CurrentRow;

                    registro += 1;

                    linha += 20;

                    if (linha < 950)
                    {
                        i++;

                    }


                }

                if (pag == 1 || pag > 1)
                {
                    e.Graphics.DrawString("Total de Menções " + ment_antiga + ": " + i.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha + 8);
                }
                else if (registro == fim)
                {
                    e.Graphics.DrawString("Total de Menções " + ment_antiga + ": " + (i).ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha + 8);
                }

                e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 625, 1095);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 50, 1120);
                e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 625, 1120);

                pag += 1;

                // reajustando contadores de pag

                // trocando de página
                if ((pag > 1) & (registro < fim))
                {

                    i = 0;
                    e.HasMorePages = true;

                }
                else
                {
                    e.HasMorePages = false;
                    registro = 0;
                    pag = 1;
                    bs_relat_analit_menc_view.MoveFirst();
                }
            }

            else if (cb_opcoes.Text == "Agrupado por Disciplina")
            {
                e.Graphics.DrawImage(Image.FromFile("logo1.PNG"), 50, -25);

                e.Graphics.DrawString("RELATÓRIO AGRUPADO POR DISCIPLINA", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 325, 75);



                linha = 163;
                int j = 0, k = 0;
                while ((linha < 967) & (registro != fim))
                {

                    discip_atual = reg_grid.Cells["sigla"].Value.ToString();

                    if (discip_atual != discip_antiga || j == 0)
                    {
                        if (j == 0 && discip_atual != discip_antiga || pag > 1)
                        {
                            if (pag > 1 && discip_atual != discip_antiga)
                            {
                                linha += 15;
                                e.Graphics.DrawString("Total de Disciplina " + discip_antiga + ": " + k.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha);
                                linha += 15;
                                i = 0;
                                k = 0;
                            }

                            linha += 25;
                            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 780, linha);
                            linha += 6;
                            e.Graphics.DrawString("Sigla: " + discip_atual, new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 75, linha);
                            e.Graphics.DrawString("Descrição: " + reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 350, linha);

                            linha += 29;
                            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 780, linha);
                            linha += 17;

                            e.Graphics.DrawString("Mat  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 75, linha);
                            e.Graphics.DrawString("Nome   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 150, linha);
                            e.Graphics.DrawString("Menção   ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 450, linha);


                            linha += 25;

                            discip_antiga = discip_atual;

                            j++;


                        }


                        else if (discip_atual != discip_antiga)
                        {

                            e.Graphics.DrawString("Total de Disciplina " + discip_antiga + ": " + i.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha + 20);
                            j = 0;
                            i = 0;
                        }





                    }


                    e.Graphics.DrawString(reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 75, linha);
                    e.Graphics.DrawString(reg_grid.Cells["Nome"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 150, linha);
                    e.Graphics.DrawString(reg_grid.Cells["mencao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, linha);

                    if (discip_atual == discip_antiga)
                    {
                        k++;
                    }



                    bs_relat_analit_menc_view.MoveNext();

                    reg_grid = dgv_relatAnalit.CurrentRow;

                    registro += 1;

                    linha += 20;

                    if (linha < 980)
                    {
                        i++;
                    }



                }

                if (pag == 1 || pag > 1)
                {
                    e.Graphics.DrawString("Total de Disciplina " + discip_antiga + ": " + i.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha + 8);
                }
                else if (registro == fim)
                {
                    e.Graphics.DrawString("Total de Disciplina " + discip_antiga + ": " + (i).ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Red, 600, linha + 8);
                }

                e.Graphics.DrawString("Total de Registros: " + registro.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 625, 1095);
                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 50, 1120);
                e.Graphics.DrawString("Pág: " + pag.ToString(), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 625, 1120);

                pag += 1;

                // reajustando contadores de pag

                // trocando de página
                if ((pag > 1) & (registro < fim))
                {

                    i = 0;
                    e.HasMorePages = true;

                }
                else
                {
                    e.HasMorePages = false;
                    registro = 0;
                    pag = 1;
                    bs_relat_analit_menc_view.MoveFirst();
                }
            }
            else if (cb_opcoes.Text == "Boletim")
            {
                e.Graphics.DrawImage(Image.FromFile("logo1.PNG"), 50, -25);

                e.Graphics.DrawString("BOLETIM DO ALUNO", new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 325, 75);



                linha = 163;
                int j = 0, k = 0;
                while ((linha < 967) & (registro != fim))
                {

                    nome_atual = reg_grid.Cells["Nome"].Value.ToString();

                    if (nome_atual != nome_antigo || j == 0)
                    {

                        if (j == 0 && nome_atual != nome_antigo)
                        {
                           

                            linha += 25;
                            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 780, linha);
                            linha += 6;
                            e.Graphics.DrawString("Nome: " + nome_atual, new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 75, linha);
                            e.Graphics.DrawString("Matrícula: " + reg_grid.Cells["Matricula"].Value.ToString(), new System.Drawing.Font("Times new roman", 14, FontStyle.Bold), Brushes.Black, 450, linha);

                            linha += 29;
                            e.Graphics.DrawLine(new Pen(Color.Black, 2), 50, linha, 780, linha);
                            linha += 17;

                            e.Graphics.DrawString("Sigla  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 75, linha);
                            e.Graphics.DrawString("Descrição  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 160, linha);
                            e.Graphics.DrawString("Menção  ", new System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, 450, linha);
                                                       


                            linha += 25;

                            nome_antigo = nome_atual;

                            j++;




                        }

                        else if (nome_atual != nome_antigo)
                        {
                            
                            j = 0;
                            
                        }
                    }

                    e.Graphics.DrawString(reg_grid.Cells["sigla"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 75, linha);
                    e.Graphics.DrawString(reg_grid.Cells["descricao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 160, linha);
                    e.Graphics.DrawString(reg_grid.Cells["mencao"].Value.ToString(), new System.Drawing.Font("Arial", 10, FontStyle.Regular), Brushes.Black, 450, linha);


                    bs_relat_analit_menc_view.MoveNext();

                    reg_grid = dgv_relatAnalit.CurrentRow;

                    registro += 1;

                    linha += 20;

                    if (nome_atual != nome_antigo)
                    {
                        linha = 968;
                        

                    }
                    

                }




                e.Graphics.DrawLine(new Pen(Color.Black, 1), 50, 1115, 800, 1115);
                e.Graphics.DrawString("Data: " + System.DateTime.Now.ToString("dd/MM/yyyy"), new System.Drawing.Font("Arial", 9, FontStyle.Bold), Brushes.Black, 380, 1120);
               


                pag += 1;
                // reajustando contadores de pag

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
                    bs_relat_analit_menc_view.MoveFirst();
                }
            }

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            printPreviewDialog_RelatAnalit.Text = " Visualizando a impressão";   // título da janela
            printPreviewDialog_RelatAnalit.WindowState = FormWindowState.Maximized;  // status da janela do preview
            printPreviewDialog_RelatAnalit.PrintPreviewControl.Columns = 2;   //  quantas páginas serão mostradas na tela
            printPreviewDialog_RelatAnalit.PrintPreviewControl.Zoom = 0.6;   //  zoom inicial do preview
            printPreviewDialog_RelatAnalit.ShowDialog();
        }
    }

}