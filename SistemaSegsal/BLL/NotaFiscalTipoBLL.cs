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
    class NotaFiscalTipoBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<NotaFiscalTipoDTO> PopularComboboxNotaFiscalTipo()
		{
			cmd.CommandText = "SELECT tipoNotaFiscal FROM tb_nota_fiscal_tipo";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<NotaFiscalTipoDTO> tipo = new List<NotaFiscalTipoDTO>();

			while (leitor.Read())
			{
				NotaFiscalTipoDTO tp = new NotaFiscalTipoDTO();
				tp.TipoNotaFiscal = leitor.GetString(0);
				tipo.Add(tp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tipo;
		}

		public Int32 SelecionarIdNotaFiscalTipo(NotaFiscalTipoDTO tp)
		{
			cmd.CommandText = "SELECT id FROM tb_nota_fiscal_tipo " +
				"WHERE tipoNotaFiscal = '" + tp.TipoNotaFiscal + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				tp.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return tp.Id;
		}
	}
}
