using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaSegsal.BLL
{
    class BaseClienteStatusBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public Int32 SelecionarIdStatus(BaseClienteStatusDTO s)
		{
			cmd.CommandText = "SELECT id FROM tb_cliente_base_status " +
				"WHERE statusClienteBase = '" + s.Status + "'";

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
