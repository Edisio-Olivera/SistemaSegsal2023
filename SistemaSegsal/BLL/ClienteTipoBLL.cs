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
    class ClienteTipoBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<ClienteTipoDTO> PopularComboboxTipoCliente()
		{
			cmd.CommandText = "SELECT tipoCliente FROM tb_cliente_tipo";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ClienteTipoDTO> tipo = new List<ClienteTipoDTO>();

			while (leitor.Read())
			{
				ClienteTipoDTO tc = new ClienteTipoDTO();
				tc.TipoCliente = leitor.GetString(0);
				tipo.Add(tc);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdTipoCliente(ClienteTipoDTO t)
		{
			cmd.CommandText = "SELECT id FROM tb_cliente_tipo " +
				"WHERE tipoCliente = '" + t.TipoCliente + "'";

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
