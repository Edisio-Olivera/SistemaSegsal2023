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
    class PropostaComercialStatusBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		public Int32 SelecionarIdStatus(PropostaComercialStatusDTO s)
		{
			cmd.CommandText = "SELECT id FROM tb_proposta_comercial_status " +
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

		public List<PropostaComercialStatusDTO> PopularComboboxPropostaComercialStatus()
		{
			cmd.CommandText = "SELECT status FROM tb_proposta_comercial_status";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<PropostaComercialStatusDTO> statusProposta = new List<PropostaComercialStatusDTO>();

			while (leitor.Read())
			{
				PropostaComercialStatusDTO staPro = new PropostaComercialStatusDTO();
				staPro.Status = leitor.GetString(0);
				statusProposta.Add(staPro);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusProposta;
		}
	}
}
