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
    class UfBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		public List<UfDTO> PopularComboboxUf()
		{
			cmd.CommandText = "SELECT sigla FROM tb_uf";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<UfDTO> sigla = new List<UfDTO>();

			while (leitor.Read())
			{
				UfDTO uf = new UfDTO();
				uf.Sigla = leitor.GetString(0);
				sigla.Add(uf);
			}

			conexao.desconectar();
			cmd.Dispose();

			return sigla;
		}

		public Int32 SelecionarIdUf(UfDTO u)
		{
			cmd.CommandText = "SELECT id FROM tb_uf " +
				"WHERE sigla = '" + u.Sigla + "'";

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
