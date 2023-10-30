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
    class OrdemServicoBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		OrdemServicoStatusDTO staDto = new OrdemServicoStatusDTO();
		OrdemServicoStatusBLL staBll = new OrdemServicoStatusBLL();

		ClienteDTO cliDto = new ClienteDTO();
		ClienteBLL cliBll = new ClienteBLL();

		BaseClienteDTO basDto = new BaseClienteDTO();
		BaseClienteBLL basBll = new BaseClienteBLL();

		Int32 qtdIdOrdemServico;

		public void CriarNovoOrdemServico(OrdemServicoDTO o)
		{
			this.ContarOrdemServico();

			if (qtdIdOrdemServico == 0)
			{
				o.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_ordem_servico";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					o.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarOrdemServico()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_ordem_servico";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdOrdemServico = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdOrdemServico;
		}

		public void SalvarOrdemServico(OrdemServicoDTO o)
		{
			cliDto.NomeFantasia = o.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			basDto.NomeBase = o.BaseCliente;
			basBll.SelecionarCodigoBaseCliente(basDto);

			staDto.Status = o.Status;
			staBll.SelecionarIdOrdemServicoStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_ordem_servico (" +
				"id, " +
				"codigo, " +
				"dataRegistro, " +
				"codBaseCliente, " +
				"titulo, " +
				"descricao, " +
				"observacao, " +
				"codProposta, " +
				"idStatusOS) " +
				"VALUES (" +
				o.Id + ", '" +
				o.Codigo + "', '" +
				o.DataRegistro + "', '" +
				basDto.Codigo + "', '" +
				o.Titulo + "', '" +
				o.Descricao + "', '" +
				o.Obsevacao + "', '" +
				o.Proposta + "', " +
				staDto.Id + ")";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void EditarOrdemServico(OrdemServicoDTO o)
		{
			cliDto.NomeFantasia = o.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			basDto.NomeBase = o.BaseCliente;
			basBll.SelecionarCodigoBaseCliente(basDto);

			staDto.Status = o.Status;
			staBll.SelecionarIdOrdemServicoStatus(staDto);

			cmd.CommandText = "UPDATE tb_ordem_servico SET " +
				"titulo = '" + o.Titulo + "', " +
				"descricao = '" + o.Descricao + "', " +
				"observacao = '" + o.Obsevacao + "', " +
				"idStatusOS = " + staDto.Id + " " +
				"WHERE codigo = '" + o.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public void ExcluirOrdemServico(OrdemServicoDTO o)
		{
			cmd.CommandText = "DELETE FROM tb_ordem_servico " +
				"WHERE codigo = '" + o.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				cmd.ExecuteNonQuery();

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<OrdemServicoDTO> SelecionarOrdemServico(OrdemServicoDTO o)
		{
			cmd.CommandText = "SELECT " +
				"o.id, " +
				"o.codigo, " +
				"o.dataRegistro, " +
				"c.nomeFantasia, " +
				"b.nomeBase, " +
				"o.titulo, " +
				"o.descricao, " +
				"o.observacao, " +
				"o.codProposta, " +
				"s.statusOS " +
				"FROM tb_ordem_servico o " +
				"INNER JOIN tb_cliente_base b ON o.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"INNER JOIN tb_ordem_servico_status s ON o.idStatusOS = s.id " +
				"WHERE o.codigo = '" + o.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>(10);

			leitor.Read();

			ordem.Add(new OrdemServicoDTO());

			ordem[0].Id = leitor.GetInt32(0);
			ordem[0].Codigo = leitor.GetString(1);
			ordem[0].DataRegistro = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
			ordem[0].Cliente = leitor.GetString(3);
			ordem[0].BaseCliente = leitor.GetString(4);
			ordem[0].Titulo = leitor.GetString(5);
			ordem[0].Descricao = leitor.GetString(6);
			ordem[0].Obsevacao = leitor.GetString(7);
			ordem[0].Proposta = leitor.GetString(8);
			ordem[0].Status = leitor.GetString(9);

			conexao.desconectar();
			cmd.Dispose();

			return ordem;
		}

		public string SelecionarCodigoOrdemServico(OrdemServicoDTO o)
		{
			cmd.CommandText = "SELECT codigo FROM tb_ordem_servico " +
				"WHERE titulo = '" + o.Titulo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				o.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return o.Codigo;
		}

		public List<OrdemServicoDTO> PopularComboboxOrdemServico()
		{
			cmd.CommandText = "SELECT titulo FROM tb_ordem_servico";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>();

			while (leitor.Read())
			{
				OrdemServicoDTO ord = new OrdemServicoDTO();
				ord.Titulo = leitor.GetString(0);
				ordem.Add(ord);
			}

			conexao.desconectar();
			cmd.Dispose();

			return ordem;
		}

		public List<OrdemServicoDTO> ListarOrdemServicoStatus(OrdemServicoDTO o)
		{
			staDto.Status = o.Status;
			staBll.SelecionarIdOrdemServicoStatus(staDto);

			cmd.CommandText = "SELECT " +
				"o.id, " +
				"o.codigo, " +
				"o.dataRegistro, " +
				"c.nomeFantasia, " +
				"b.nomeBase, " +
				"o.titulo, " +
				"o.descricao, " +
				"o.observacao, " +
				"o.codProposta, " +
				"s.statusOS " +
				"FROM tb_ordem_servico o " +
				"INNER JOIN tb_cliente_base b ON o.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"INNER JOIN tb_ordem_servico_status s ON o.idStatusOS = s.id " +
				"WHERE s.statusOS = " + staDto.Id + " " +
				"ORDER BY o.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>();

			while (leitor.Read())
			{
				OrdemServicoDTO ord = new OrdemServicoDTO();

				ord.Id = leitor.GetInt32(0);
				ord.Codigo = leitor.GetString(1);
				ord.DataRegistro = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
				ord.Cliente = leitor.GetString(3);
				ord.BaseCliente = leitor.GetString(4);
				ord.Titulo = leitor.GetString(5);
				ord.Descricao = leitor.GetString(6);
				ord.Obsevacao = leitor.GetString(7);
				ord.Proposta = leitor.GetString(8);
				ord.Status = leitor.GetString(9);

				ordem.Add(ord);
			}

			conexao.desconectar();
			cmd.Dispose();

			return ordem;
		}

		public List<OrdemServicoDTO> ListarOrdemServico()
		{
			cmd.CommandText = "SELECT " +
				"c.id, " +
				"c.codigo, " +
				"t.tipoCliente, " +
				"c.dataRegistro, " +
				"c.razaoSocial, " +
				"c.nomeFantasia, " +
				"c.logomarca, " +
				"s.statusCliente " +
				"FROM tb_cliente c " +
				"INNER JOIN tb_cliente_tipo t ON c.idTipoCliente = t.id " +
				"INNER JOIN tb_cliente_status s ON c.idStatus = s.id " +
				"ORDER BY c.codigo ASC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>();

			while (leitor.Read())
			{
				OrdemServicoDTO ord = new OrdemServicoDTO();

				ord.Id = leitor.GetInt32(0);
				ord.Codigo = leitor.GetString(1);
				ord.DataRegistro = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
				ord.Cliente = leitor.GetString(3);
				ord.BaseCliente = leitor.GetString(4);
				ord.Titulo = leitor.GetString(5);
				ord.Descricao = leitor.GetString(6);
				ord.Obsevacao = leitor.GetString(7);
				ord.Proposta = leitor.GetString(8);
				ord.Status = leitor.GetString(9);

				ordem.Add(ord);
			}

			conexao.desconectar();
			cmd.Dispose();

			return ordem;
		}
	}
}
