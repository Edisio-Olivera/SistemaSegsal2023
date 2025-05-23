﻿using System;
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
    class NotaFiscalStatusBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		string tabela = "tb_nota_fiscal_status";

		public List<NotaFiscalStatusDTO> PopularComboboxNotaFiscalStatus()
		{
			cmd.CommandText = "SELECT status FROM " + tabela;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<NotaFiscalStatusDTO> statusN = new List<NotaFiscalStatusDTO>();

			while (leitor.Read())
			{
				NotaFiscalStatusDTO st = new NotaFiscalStatusDTO();
				st.Status = leitor.GetString(0);
				statusN.Add(st);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusN;
		}

		public Int32 SelecionarIdNotaFiscalStatus(NotaFiscalStatusDTO st)
		{
			cmd.CommandText = "SELECT id FROM " + tabela + " " +
				"WHERE status = '" + st.Status + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				st.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return st.Id;
		}
	}
}
