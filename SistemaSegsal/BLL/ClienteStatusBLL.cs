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
    class ClienteStatusBLL
    {
        Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();		

		public Int32 SelecionarIdStatus(ClienteStatusDTO s)
		{
			cmd.CommandText = "SELECT id FROM tb_cliente_status " +
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

		public List<ClienteStatusDTO> PopularComboboxCliente()
		{
			cmd.CommandText = "SELECT status FROM tb_cliente_status";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<ClienteStatusDTO> statusCli = new List<ClienteStatusDTO>();

			while (leitor.Read())
			{
				ClienteStatusDTO sta = new ClienteStatusDTO();
				sta.Status = leitor.GetString(0);
				statusCli.Add(sta);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusCli;
		}
	}	
}
