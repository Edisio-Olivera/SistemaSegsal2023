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
    class UnidadeBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		public List<UnidadeDTO> PopularComboboxUnidade()
		{
			cmd.CommandText = "SELECT unidade FROM tb_unidade";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<UnidadeDTO> unidade = new List<UnidadeDTO>();

			while (leitor.Read())
			{
				UnidadeDTO un = new UnidadeDTO();
				un.Unidade = leitor.GetString(0);
				unidade.Add(un);
			}

			conexao.desconectar();
			cmd.Dispose();

			return unidade;
		}

		public Int32 SelecionarIdUnidade(UnidadeDTO u)
		{
			cmd.CommandText = "SELECT id FROM tb_unidade " +
				"WHERE unidade = '" + u.Unidade + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				u.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return u.Id;
		}
	}
}

