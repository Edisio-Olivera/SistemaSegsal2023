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
    class ChamadoAssuntoBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		public List<ChamadoAssuntoDTO> PopularComboboxAssunto()
		{
			cmd.CommandText = "SELECT assunto FROM tb_chamado_assunto";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<ChamadoAssuntoDTO> assunto = new List<ChamadoAssuntoDTO>();

			while (leitor.Read())
			{
				ChamadoAssuntoDTO a = new ChamadoAssuntoDTO();
				a.Assunto = leitor.GetString(0);
				assunto.Add(a);
			}

			conexao.desconectar();
			cmd.Dispose();

			return assunto;
		}

		public Int32 SelecionarIdAssunto(ChamadoAssuntoDTO a)
		{
			cmd.CommandText = "SELECT id FROM tb_chamado_assunto " +
				"WHERE assunto = '" + a.Assunto + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				a.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return a.Id;
		}
	}
}
