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
    class DepartamentoBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		//DepartamentoDTO dDto = new DepartamentoDTO();
		//DepartamentoBLL dBll = new DepartamentoBLL();


		public List<DepartamentoDTO> PopularComboboxDepartamento()
        {
			cmd.CommandText = "SELECT departamento FROM tb_cliente_contato_departamento";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<DepartamentoDTO> depart = new List<DepartamentoDTO>();

			while (leitor.Read())
			{
				DepartamentoDTO de = new DepartamentoDTO();
				de.Departamento = leitor.GetString(0);
				depart.Add(de);
			}

			conexao.desconectar();
			cmd.Dispose();

			return depart;
		}

        public Int32 SelecionarIdDepartamento(DepartamentoDTO d)
        {
			cmd.CommandText = "SELECT id FROM tb_cliente_contato_departamento " +
				"WHERE departamento = '" + d.Departamento + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				d.Id = leitor.GetInt32(0);

				conexao.desconectar();

			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return d.Id;
		}
    }
}
