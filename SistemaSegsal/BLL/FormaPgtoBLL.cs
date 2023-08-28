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
    class FormaPgtoBLL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

		CondicaoPgtoDTO cpDto = new CondicaoPgtoDTO();
		CondicaoPgtoBLL cpBll = new CondicaoPgtoBLL();

		public List<FormaPgtoDTO> PopularComboboxFormaPgto(FormaPgtoDTO fp)
		{
			cpDto.CondicaoPgto = fp.CondicaoPgto;
			cpBll.SelecionarIdCondicaoPgto(cpDto);

			cmd.CommandText = "SELECT forma FROM tb_forma_pgto " +
				"WHERE idCondicao = " + cpDto.Id;

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
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
			cmd.CommandText = "SELECT id FROM tb_forma_pgto " +
				"WHERE forma = '" + fp.FormaPgto + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				fp.Id = leitor.GetInt32(0);

				conexao.desconectar();

			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return fp.Id;
		}
	}
}
