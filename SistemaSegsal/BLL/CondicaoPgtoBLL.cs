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
    class CondicaoPgtoBLL
    {
        Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		string tabela = "tb_condicao_pgto";

        public List<CondicaoPgtoDTO> PopularComboboxCondicaoPgto()
		{
			cmd.CommandText = "SELECT condicao FROM " + tabela + " ";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
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
			cmd.CommandText = "SELECT id FROM " + tabela + " " +
				"WHERE condicao = '" + cp.CondicaoPgto + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				cp.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return cp.Id;
		}
	}
}
