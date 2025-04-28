using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    internal class AprStatusBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        string tabela = "tb_apr";


        public Int32 SelecionarIdStatus(AprStatusDTO s)
        {
            cmd.CommandText = "SELECT id FROM " + tabela +
                "WHERE status = '" + s.Status + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                s.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return s.Id;
        }
    }
}
