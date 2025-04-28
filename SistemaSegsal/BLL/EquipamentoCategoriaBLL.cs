using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    class EquipamentoCategoriaBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		public List<EquipamentoCategoriaDTO> PopularComboboxEquipamentoCategoria()
		{
			cmd.CommandText = "SELECT categoria FROM tb_equipamento_categoria";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<EquipamentoCategoriaDTO> categoria = new List<EquipamentoCategoriaDTO>();

			while (leitor.Read())
			{
				EquipamentoCategoriaDTO cat = new EquipamentoCategoriaDTO();
				cat.Categoria = leitor.GetString(0);
				categoria.Add(cat);
			}

			conexao.desconectar();
			cmd.Dispose();

			return categoria;
		}

		public Int32 SelecionarIdEquipamentoCategoria(EquipamentoCategoriaDTO c)
		{
			cmd.CommandText = "SELECT id FROM tb_equipamento_categoria " +
				"WHERE categoria = '" + c.Categoria + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				c.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return c.Id;
		}
	}
}

