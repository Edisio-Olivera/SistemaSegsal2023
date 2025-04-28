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
    class TecnicoStatusBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

        string tabela = "tb_tecnico_status";

        public List<TecnicoStatusDTO> PopularComboboxTecnicoStatus()
		{
			cmd.CommandText = "SELECT statusTecnico FROM " + tabela;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
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
			cmd.CommandText = "SELECT id FROM " + tabela + " " +
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
