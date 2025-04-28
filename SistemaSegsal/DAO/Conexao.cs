using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;
//using MySql.Data.MySqlClient;

namespace SistemaSegsal.DAO
{
    class Conexao
    {
        OleDbConnection conn = new OleDbConnection();

        //static public string servidor = "localhost";
        //static public string bancoDados = "db_gestaosegsal";
        //static public string usuario = "root";
        //static public string senha = "190112";

        //static public string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\Banco de Dados\db_gestao_segsal.accdb;Persist Security Info=False";

        static public string strConn = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\seris\OneDrive\= DESENVOLVIMENTO =\= SISTEMA SEGSAL =\SistemaSegsal\SistemaSegsal\db_gestao_segsal.accdb";

        //C:\Users\seris\OneDrive\= DESENVOLVIMENTO =\= SISTEMA SEGSAL =\SistemaSegsal\SistemaSegsal\db_gestao_segsal.accdb

        public Conexao()
        {
            conn.ConnectionString = strConn;
        }

        public OleDbConnection conectar()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            return conn;
        }

        public void desconectar()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
