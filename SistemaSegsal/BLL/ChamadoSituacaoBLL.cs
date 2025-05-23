﻿using System;
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
    class ChamadoSituacaoBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		public List<ChamadoSituacaoDTO> PopularComboboxSituacao()
		{
			cmd.CommandText = "SELECT situacao FROM tb_chamado_situacao";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<ChamadoSituacaoDTO> situacao = new List<ChamadoSituacaoDTO>();

			while (leitor.Read())
			{
				ChamadoSituacaoDTO s = new ChamadoSituacaoDTO();
				s.Situacao = leitor.GetString(0);
				situacao.Add(s);
			}

			conexao.desconectar();
			cmd.Dispose();

			return situacao;
		}

		public Int32 SelecionarIdSituacao(ChamadoSituacaoDTO s)
		{
			cmd.CommandText = "SELECT id FROM tb_chamado_situacao " +
				"WHERE situacao = '" + s.Situacao + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				s.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return s.Id;
		}
	}
}
