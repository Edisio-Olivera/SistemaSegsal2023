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
    class CidadeBLL
    {
        Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		UfDTO ufDto = new UfDTO();
		UfBLL ufBll = new UfBLL();

		public List<CidadeDTO> PopularComboboxCidade(CidadeDTO c)
		{
			ufDto.Sigla = c.Uf;
			ufBll.SelecionarIdUf(ufDto);

			cmd.CommandText = "SELECT cidade FROM tb_cidade " +
				"WHERE idUf = " + ufDto.Id;

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<CidadeDTO> cidade = new List<CidadeDTO>();

			while (leitor.Read())
			{
				CidadeDTO cid = new CidadeDTO();
				cid.Cidade = leitor.GetString(0);
				cidade.Add(cid);
			}

			conexao.desconectar();
			cmd.Dispose();

			return cidade;
		}

		public Int32 SelecionarIdCidade(CidadeDTO c)
		{
			cmd.CommandText = "SELECT id FROM tb_cidade " +
				"WHERE cidade = '" + c.Cidade + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				c.Id = leitor.GetInt32(0);

				conexao.desconectar();

			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return c.Id;
		}
	}
}
