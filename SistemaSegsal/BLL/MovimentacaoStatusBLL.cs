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
    internal class MovimentacaoStatusBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        public List<MovimentacaoStatusDTO> PopularComboboxMovimentacaoStatus()
        {
            cmd.CommandText = "SELECT status FROM tb_movimentacao_status";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<MovimentacaoStatusDTO> status = new List<MovimentacaoStatusDTO>();

            while (leitor.Read())
            {
                MovimentacaoStatusDTO st = new MovimentacaoStatusDTO();
                st.Status = leitor.GetString(0);
                status.Add(st);
            }

            conexao.desconectar();
            cmd.Dispose();

            return status;
        }

        public Int32 SelecionarIdMovimentacaoStatus(MovimentacaoStatusDTO st)
        {
            cmd.CommandText = "SELECT id FROM tb_movimentacao_status " +
                "WHERE status = '" + st.Status + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                st.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return st.Id;
        }
    }
}
