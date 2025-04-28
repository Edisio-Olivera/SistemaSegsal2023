using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    class ChamadoStatusBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

        string tabela = "tb_chamado_status";

        public List<ChamadoStatusDTO> PopularComboboxChamadoStatus()
		{
			cmd.CommandText = "SELECT status FROM " + tabela;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<ChamadoStatusDTO> statusChamado = new List<ChamadoStatusDTO>();

			while (leitor.Read())
			{
				ChamadoStatusDTO sta = new ChamadoStatusDTO();
				sta.Status = leitor.GetString(0);
				statusChamado.Add(sta);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusChamado;
		}

		public Int32 SelecionarIdChamadoStatus(ChamadoStatusDTO s)
		{
			cmd.CommandText = "SELECT id FROM " + tabela + " " +
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
