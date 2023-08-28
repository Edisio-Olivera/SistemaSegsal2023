using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.OleDb;
using MySql.Data.MySqlClient;

namespace SistemaSegsal.DAO
{
    class Conexao
    {
        MySqlConnection conn = new MySqlConnection();

        static public string servidor = "localhost";
        static public string bancoDados = "db_gestaosegsal";
        static public string usuario = "root";
        static public string senha = "190112";

        //static public string strConn = "Provider=Microsoft.ACE.OLEDB.12.0;" + Application.StartupPath + @"\Banco de Dados\db_gestao_segsal.accdb;";

        static public string strConn = $"server={servidor};User Id={usuario};database={bancoDados};password={senha}";
        //static public string strConn = $"server=localhost;User Id=db_gestaosegsal;database=root;password=190112";

        public Conexao()
        {
            conn.ConnectionString = strConn;
        }

        public MySqlConnection conectar()
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
