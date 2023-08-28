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
    class ChamadoUrgenciaBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<ChamadoUrgenciaDTO> PopularComboboxUrgencia()
		{
			cmd.CommandText = "SELECT urgencia FROM tb_chamado_urgencia";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ChamadoUrgenciaDTO> urgencia = new List<ChamadoUrgenciaDTO>();

			while (leitor.Read())
			{
				ChamadoUrgenciaDTO u = new ChamadoUrgenciaDTO();
				u.Urgencia = leitor.GetString(0);
				urgencia.Add(u);
			}

			conexao.desconectar();
			cmd.Dispose();

			return urgencia;
		}

		public Int32 SelecionarIdUrgencia(ChamadoUrgenciaDTO u)
		{
			cmd.CommandText = "SELECT id FROM tb_chamado_urgencia " +
				"WHERE urgencia = '" + u.Urgencia + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				u.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return u.Id;
		}
	}
}
