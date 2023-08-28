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
    class CondicaoPgtoBLL
    {
        Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<CondicaoPgtoDTO> PopularComboboxCondicaoPgto()
		{
			cmd.CommandText = "SELECT condicao FROM tb_condicao_pgto";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<CondicaoPgtoDTO> condicao = new List<CondicaoPgtoDTO>();

			while (leitor.Read())
			{
				CondicaoPgtoDTO pgto = new CondicaoPgtoDTO();
				pgto.CondicaoPgto = leitor.GetString(0);
				condicao.Add(pgto);
			}

			conexao.desconectar();
			cmd.Dispose();

			return condicao;
		}

		public Int32 SelecionarIdCondicaoPgto(CondicaoPgtoDTO cp)
		{
			cmd.CommandText = "SELECT id FROM tb_condicao_pgto " +
				"WHERE condicao = '" + cp.CondicaoPgto + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				cp.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return cp.Id;
		}
	}
}
