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
    class FormaPgtoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		CondicaoPgtoDTO cpDto = new CondicaoPgtoDTO();
		CondicaoPgtoBLL cpBll = new CondicaoPgtoBLL();

		string tabela = "tb_forma_pgto";

		public List<FormaPgtoDTO> PopularComboboxFormaPgto(FormaPgtoDTO fp)
		{
			cpDto.CondicaoPgto = fp.CondicaoPgto;
			cpBll.SelecionarIdCondicaoPgto(cpDto);

			cmd.CommandText = "SELECT forma FROM " + tabela + " " +
				"WHERE idCondicao = " + cpDto.Id;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<FormaPgtoDTO> forma = new List<FormaPgtoDTO>();

			while (leitor.Read())
			{
				FormaPgtoDTO pgto = new FormaPgtoDTO();
				pgto.FormaPgto = leitor.GetString(0);
				forma.Add(pgto);
			}

			conexao.desconectar();
			cmd.Dispose();

			return forma;
		}

		public Int32 SelecionarIdFormaPgto(FormaPgtoDTO fp)
		{
			cpDto.CondicaoPgto = fp.CondicaoPgto;
			cpBll.SelecionarIdCondicaoPgto(cpDto);

			cmd.CommandText = "SELECT id FROM " + tabela + " " +
				"WHERE forma = '" + fp.FormaPgto + "' " +
				"AND idCondicao = " + cpDto.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				fp.Id = leitor.GetInt32(0);

				conexao.desconectar();

			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return fp.Id;
		}
	}
}
