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
    class ChamadoStatusBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<ChamadoStatusDTO> PopularComboboxChamadoStatus()
		{
			cmd.CommandText = "SELECT statusChamado FROM tb_chamado_status";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
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
			cmd.CommandText = "SELECT id FROM tb_chamado_status " +
				"WHERE statusChamado = '" + s.Status + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				s.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return s.Id;
		}
	}
}
