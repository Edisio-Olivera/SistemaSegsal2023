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
    class EquipamentoBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		EquipamentoCategoriaDTO catDto = new EquipamentoCategoriaDTO();
		EquipamentoCategoriaBLL catBll = new EquipamentoCategoriaBLL();

		EquipamentoModeloDTO modDto = new EquipamentoModeloDTO();
		EquipamentoModeloBLL modBll = new EquipamentoModeloBLL();

		EquipamentoFabricanteDTO fabDto = new EquipamentoFabricanteDTO();
		EquipamentoFabricanteBLL fabBll = new EquipamentoFabricanteBLL();

		UnidadeDTO uniDto = new UnidadeDTO();
		UnidadeBLL uniBll = new UnidadeBLL();

		Int32 qtdIdEquipamento;

		public void CriarNovoEquipamento(EquipamentoDTO e)
		{
			this.ContarEquipamento();

			if (qtdIdEquipamento == 0)
			{
				e.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_equipamento";

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					Int32 id = leitor.GetInt32(0);
					e.Id = id + 1;

					conexao.desconectar();
				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarEquipamento()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_equipamento";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdEquipamento = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdEquipamento;
		}

		public void SalvarEquipamento(EquipamentoDTO e)
		{
			modDto.Descritivo = e.Modelo;
			//modBll.SelecionarIdModelo(modDto);

			cmd.CommandText = "INSERT INTO tb_equipamento (" +
				"id, " +
				"idModelo, " +
				"estoque, " +
				"valorCompra * 100, " +
				"valorVenda * 100, " +
				"imagem) " +
				"VALUES (" +
				e.Id + ", " +
				modDto.Id + ", " +
				e.Estoque + ", " +
				e.ValorCompra + ", " +
				e.ValorVenda + ", '" +
				e.Imagem + "')";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void EditarEquipamento(EquipamentoDTO e)
		{
			modDto.Descritivo = e.Modelo;
			//modBll.SelecionarIdModelo(modDto);

			cmd.CommandText = "UPDATE tb_equipamento SET " +
				"idModelo = " + modDto.Id + ", " +
				"estoque = " + e.Estoque + ", " +
				"valorCompra = " + e.ValorCompra + ", " +
				"valorVenda " + e.ValorVenda + ", " +
				"WHERE id = " + e.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ExcluirEquipamento(EquipamentoDTO e)
		{
			cmd.CommandText = "DELETE FROM tb_equipamento " +
				"WHERE id = " + e.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<EquipamentoDTO> SelecionarEquipamento(EquipamentoDTO e)
		{
			cmd.CommandText = "SELECT " +
				"e.id, " +
				"c.categoria, " +
				"f.fabricante, " +
				"m.descritivo, " +
				"u.unidade, " +
				"m.ncm, " +
				"e.estoque, " +
				"e.valorCompra, " +
				"e.valorVenda, " +
				"m.imagem " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_modelo m ON e.idModelo = m.id " +
				"INNER JOIN tb_equipamento_fabricante f ON m.idFabricante = f.id " +
				"INNER JOIN tb_equipamento_categoria c ON m.idCategoria = c.id " +
				"INNER JOIN tb_unidade u ON m.idUnidade = u.id " +
				"WHERE e.Id = " + e.Id; 

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equipamento = new List<EquipamentoDTO>(10);

			leitor.Read();

			equipamento.Add(new EquipamentoDTO());

			equipamento[0].Id = leitor.GetInt32(0);
			equipamento[0].Categoria = leitor.GetString(1);
			equipamento[0].Fabricante = leitor.GetString(2);
			equipamento[0].Modelo = leitor.GetString(3);
			equipamento[0].Unidade = leitor.GetString(4);
			equipamento[0].Ncm = leitor.GetString(5);
			equipamento[0].Estoque = leitor.GetInt32(6);
			equipamento[0].ValorCompra = leitor.GetInt32(7)/ 100;
			equipamento[0].ValorVenda = leitor.GetInt32(8) / 100;
			equipamento[0].Imagem = leitor.GetString(9);

			conexao.desconectar();
			cmd.Dispose();

			return equipamento;
		}

		public Int32 SelecionarIdEquipamento(EquipamentoDTO e)
		{
			modDto.Descritivo = e.Modelo;
			//modBll.SelecionarIdModelo(modDto);

			cmd.CommandText = "SELECT id FROM tb_equipamento " +
				"WHERE idModelo = " + modDto.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				e.Id = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return e.Id;
		}

		public List<EquipamentoDTO> PopularComboboxEquipamento(EquipamentoDTO e)
		{
			catDto.Categoria = e.Categoria;
			catBll.SelecionarIdEquipamentoCategoria(catDto);

			cmd.CommandText = "SELECT descritivo FROM tb_equipamento" +
				"WHERE idCategoria = " + catDto.Id;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<EquipamentoDTO> equipamento = new List<EquipamentoDTO>();

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();
				//eqp.Descritivo = leitor.GetString(0);
				equipamento.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equipamento;
		}

		public List<EquipamentoDTO> ListarEquipamento()
		{
			cmd.CommandText = "SELECT " +
				"e.id, " +
				"c.categoria, " +
				"e.descritivo, " +
				"e.ncm, " +
				"u.unidade, " +
				"e.estoque, " +
				"e.valorCompra, " +
				"e.valorVenda, " +
				"e.imagem " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_categoria c ON e.idCategoria = c.id " +
				"INNER JOIN tb_unidade u ON e.idUnidade = u.id " +
				"ORDER BY e.Id ASC; ";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equipamento = new List<EquipamentoDTO>();

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Categoria = leitor.GetString(1);
				//eqp.Descritivo = leitor.GetString(2);
				eqp.Ncm = leitor.GetString(3);
				eqp.Unidade = leitor.GetString(4);
				eqp.Estoque = leitor.GetInt32(5);
				eqp.ValorCompra = leitor.GetInt32(6) / 100;
				eqp.ValorVenda = leitor.GetInt32(7) / 100;
				eqp.Imagem = leitor.GetString(8);

				equipamento.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equipamento;
		}

		public List<EquipamentoDTO> ListarEquipamentoCategoria(EquipamentoDTO e)
		{
			catDto.Categoria = e.Categoria;
			catBll.SelecionarIdEquipamentoCategoria(catDto);

			cmd.CommandText = "SELECT " +
				"e.id, " +
				"c.categoria, " +
				"e.descritivo, " +
				"e.ncm, " +
				"u.unidade, " +
				"e.estoque, " +
				"e.valorCompra, " +
				"e.valorVenda, " +
				"e.imagem " +
				"FROM tb_equipamento e " +
				"INNER JOIN tb_equipamento_categoria c ON e.idCategoria = c.id " +
				"INNER JOIN tb_unidade u ON e.idUnidade = u.id " +
				"WHERE idCategoria = " + catDto.Id + " " +
				"ORDER BY e.Id ASC; ";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<EquipamentoDTO> equipamento = new List<EquipamentoDTO>();

			while (leitor.Read())
			{
				EquipamentoDTO eqp = new EquipamentoDTO();

				eqp.Id = leitor.GetInt32(0);
				eqp.Categoria = leitor.GetString(1);
				//eqp.Descritivo = leitor.GetString(2);
				eqp.Ncm = leitor.GetString(3);
				eqp.Unidade = leitor.GetString(4);
				eqp.Estoque = leitor.GetInt32(5);
				eqp.ValorCompra = leitor.GetInt32(6) / 100;
				eqp.ValorVenda = leitor.GetInt32(7) / 100;
				eqp.Imagem = leitor.GetString(8);

				equipamento.Add(eqp);
			}

			conexao.desconectar();
			cmd.Dispose();

			return equipamento;
		}



	}
}
