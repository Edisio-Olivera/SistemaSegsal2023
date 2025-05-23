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
    class OrdemServicoStatusBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		public List<OrdemServicoStatusDTO> PopularComboboxOrdemServicoStatus()
		{
			cmd.CommandText = "SELECT statusOS FROM tb_ordem_servico_status";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<OrdemServicoStatusDTO> statusOS = new List<OrdemServicoStatusDTO>();

			while (leitor.Read())
			{
				OrdemServicoStatusDTO st = new OrdemServicoStatusDTO();
				st.Status = leitor.GetString(0);
				statusOS.Add(st);
			}

			conexao.desconectar();
			cmd.Dispose();

			return statusOS;
		}

		public Int32 SelecionarIdOrdemServicoStatus(OrdemServicoStatusDTO st)
		{
			cmd.CommandText = "SELECT id FROM tb_ordem_servico_status " +
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
