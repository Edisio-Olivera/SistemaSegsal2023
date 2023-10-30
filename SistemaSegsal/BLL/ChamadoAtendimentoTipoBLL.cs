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
    class ChamadoAtendimentoTipoBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<ChamadoAtendimentoTipoDTO> PopularComboboxTipoAtendimento()
		{
			cmd.CommandText = "SELECT tipo FROM tb_chamado_atendimento_tipo";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ChamadoAtendimentoTipoDTO> tipo = new List<ChamadoAtendimentoTipoDTO>();

			while (leitor.Read())
			{
				ChamadoAtendimentoTipoDTO tc = new ChamadoAtendimentoTipoDTO();
				tc.Tipo = leitor.GetString(0);
				tipo.Add(tc);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdTipoAtendimento(ChamadoAtendimentoTipoDTO t)
		{
			cmd.CommandText = "SELECT id FROM tb_chamado_atendimentotipo " +
				"WHERE tipo = '" + t.Tipo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				t.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return t.Id;
		}
	}
}
