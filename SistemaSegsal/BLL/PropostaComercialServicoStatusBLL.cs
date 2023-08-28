using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaSegsal.BLL
{
    class PropostaComercialServicoStatusBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<PropostaComercialServicoStatusDTO> PopularComboboxPropostaComercialServicoStatus()
		{
			cmd.CommandText = "SELECT statusServico FROM tb_proposta_comercial_servico_status";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<PropostaComercialServicoStatusDTO> statusServico = new List<PropostaComercialServicoStatusDTO>();

			while (leitor.Read())
			{
				PropostaComercialServicoStatusDTO st = new PropostaComercialServicoStatusDTO();
				st.Status = leitor.GetString(0);
				statusServico.Add(st);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusServico;
		}

		public Int32 SelecionarIdPropostaComercialServicoStatus(PropostaComercialServicoStatusDTO st)
		{
			cmd.CommandText = "SELECT id FROM tb_proposta_comercial_servico_status " +
				"WHERE statusServico = '" + st.Status + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				st.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return st.Id;
		}
	}
}
