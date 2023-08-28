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
    class PropostaComercialServicoTipoBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<PropostaComercialServicoTipoDTO> PopularComboboxPropostaComercialServicoTipo()
		{
			cmd.CommandText = "SELECT tipoServico FROM tb_proposta_comercial_servico_tipo";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<PropostaComercialServicoTipoDTO> tipo = new List<PropostaComercialServicoTipoDTO>();

			while (leitor.Read())
			{
				PropostaComercialServicoTipoDTO tp = new PropostaComercialServicoTipoDTO();
				tp.TipoServico = leitor.GetString(0);
				tipo.Add(tp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdPropostaComercialServicoTipo(PropostaComercialServicoTipoDTO tp)
		{
			cmd.CommandText = "SELECT id FROM tb_proposta_comercial_servico_tipo " +
				"WHERE tipoServico = '" + tp.TipoServico + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				tp.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return tp.Id;
		}
	}
}
