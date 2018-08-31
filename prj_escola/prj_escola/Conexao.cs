using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;


namespace prj_escola
{
    class Conexao
    {

        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0; Data Source=Bd_Escola.accdb";

        private static OleDbConnection conn = null;

        public static OleDbConnection obterConexao() {
            conn = new OleDbConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                conn = null;
                System.Windows.Forms.MessageBox.Show("Conexão não pode ser estabelecida!");
            }

            return conn;
        }

        public static void fecharConexao()
        {
            if (conn != null)
            {
                conn.Close();
            }
        }

    }
}
