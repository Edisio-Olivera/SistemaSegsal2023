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
    class TecnicoStatusBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();


		public List<TecnicoStatusDTO> PopularComboboxTecnicoStatus()
		{
			cmd.CommandText = "SELECT statusTecnico FROM tb_tecnico_status";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<TecnicoStatusDTO> statusT = new List<TecnicoStatusDTO>();

			while (leitor.Read())
			{
				TecnicoStatusDTO st = new TecnicoStatusDTO();
				st.Status = leitor.GetString(0);
				statusT.Add(st);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusT;
		}

		public Int32 SelecionarIdTecnicoStatus(TecnicoStatusDTO st)
		{
			cmd.CommandText = "SELECT id FROM tb_tecnico_status " +
				"WHERE statusTecnico = '" + st.Status + "'";

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
