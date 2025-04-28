using SistemaSegsal.DAO;
using SistemaSegsal.DTO;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSegsal.BLL
{
    internal class MovimentacaoTipoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        public List<MovimentacaoTipoDTO> PopularComboboxMovimentacaoTipo()
        {
            cmd.CommandText = "SELECT tipo FROM tb_movimentacao_tipo";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<MovimentacaoTipoDTO> tipo = new List<MovimentacaoTipoDTO>();

            while (leitor.Read())
            {
                MovimentacaoTipoDTO tp = new MovimentacaoTipoDTO();
                tp.Tipo = leitor.GetString(0);
                tipo.Add(tp);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tipo;
        }

        public Int32 SelecionarIdMovimentacaoTipo(MovimentacaoTipoDTO mt)
        {
            cmd.CommandText = "SELECT id FROM tb_movimentacao_tipo " +
                "WHERE tipo = '" + mt.Tipo + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                mt.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return mt.Id;
        }
    }
}
