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
    class OrdemServicoBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

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
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					o.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (OleDbException ex)
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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdOrdemServico = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
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
				"progresso, " +
				"idStatus) " +
				"VALUES (" +
				o.Id + ", '" +
				o.Codigo + "', '" +
				o.DataRegistro + "', '" +
				basDto.Codigo + "', '" +
				o.Titulo + "', '" +
				o.Descricao + "', '" +
				o.Obsevacao + "', '" +
				o.Proposta + "', " +
				o.Progresso + ", " +
				staDto.Id + ")";

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

		public void EditarOrdemServico(OrdemServicoDTO o)
		{
			staDto.Status = o.Status;
			staBll.SelecionarIdOrdemServicoStatus(staDto);

			cmd.CommandText = "UPDATE tb_ordem_servico SET " +
				"titulo = '" + o.Titulo + "', " +
				"descricao = '" + o.Descricao + "', " +
				"observacao = '" + o.Obsevacao + "', " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + o.Codigo + "'";

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
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<OrdemServicoDTO> SelecionarOrdemServico(OrdemServicoDTO o)
		{
			cmd.CommandText = "SELECT " +
                "tb_ordem_servico.id, " +
                "tb_ordem_servico.codigo, " +
                "tb_ordem_servico.dataRegistro, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_ordem_servico.titulo, " +
                "tb_ordem_servico.descricao, " +
                "tb_ordem_servico.observacao, " +
                "tb_ordem_servico.codProposta, " +
                "tb_ordem_servico.progresso, " +
                "tb_ordem_servico_status.status " +
				"FROM tb_ordem_servico " +
                "INNER JOIN tb_cliente_base ON tb_ordem_servico.codBaseCliente = tb_cliente_base.codigo " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo " +
                "INNER JOIN tb_ordem_servico_status s ON tb_ordem_servico.idStatus = tb_ordem_servico_status.id " +
                "WHERE tb_ordem_servico.codigo = '" + o.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>(11);

			leitor.Read();

			ordem.Add(new OrdemServicoDTO());

			ordem[0].Id = leitor.GetInt32(0);
			ordem[0].Codigo = leitor.GetString(1);
			ordem[0].DataRegistro = leitor.GetDateTime(2);
			ordem[0].Cliente = leitor.GetString(3);
			ordem[0].BaseCliente = leitor.GetString(4);
			ordem[0].Titulo = leitor.GetString(5);
			ordem[0].Descricao = leitor.GetString(6);
			ordem[0].Obsevacao = leitor.GetString(7);
			ordem[0].Proposta = leitor.GetString(8);
            ordem[0].Progresso = leitor.GetInt32(9);
            ordem[0].Status = leitor.GetString(10);

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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				o.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return o.Codigo;
		}

		public List<OrdemServicoDTO> PopularComboboxOrdemServico()
		{
			cmd.CommandText = "SELECT titulo FROM tb_ordem_servico";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
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
                "tb_ordem_servico.id, " +
                "tb_ordem_servico.codigo, " +
                "tb_ordem_servico.dataRegistro, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_ordem_servico.titulo, " +                
                "tb_ordem_servico.codProposta, " +
                "tb_ordem_servico.progresso, " +
                "tb_ordem_servico_status.status " +
                "FROM (((tb_ordem_servico " +
                "INNER JOIN	tb_cliente_base ON tb_ordem_servico.codBaseCliente = tb_cliente_base.codigo)" +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_ordem_servico_status ON tb_ordem_servico.idStatus = tb_ordem_servico_status.id) " +
                "WHERE tb_ordem_servico.status = " + staDto.Id + " " +
                "ORDER BY tb_ordem_servico.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>();

			while (leitor.Read())
			{
				OrdemServicoDTO ord = new OrdemServicoDTO();

				ord.Id = leitor.GetInt32(0);
				ord.Codigo = leitor.GetString(1);
				ord.DataRegistro = leitor.GetDateTime(2);
				ord.Cliente = leitor.GetString(3);
				ord.BaseCliente = leitor.GetString(4);
				ord.Titulo = leitor.GetString(5);
				ord.Descricao = leitor.GetString(6);
				ord.Obsevacao = leitor.GetString(7);
				ord.Proposta = leitor.GetString(8);
				ord.Progresso = leitor.GetInt32(9);
				ord.Status = leitor.GetString(10);

				ordem.Add(ord);
			}

			conexao.desconectar();
			cmd.Dispose();

			return ordem;
		}

		public List<OrdemServicoDTO> ListarOrdemServico()
		{
			cmd.CommandText = "SELECT " +
				"tb_ordem_servico.id, " +
                "tb_ordem_servico.codigo, " +
                "tb_ordem_servico.dataRegistro, " +
				"tb_cliente.nomeFantasia, " +
				"tb_cliente_base.nomeBase, " +
                "tb_ordem_servico.titulo, " +
                "tb_ordem_servico.descricao, " +
                "tb_ordem_servico.observacao, " +
                "tb_ordem_servico.progresso, " +
                "tb_ordem_servico.codProposta, " +
				"tb_ordem_servico_status.status " +
				"FROM (((tb_ordem_servico " +
				"INNER JOIN	tb_cliente_base ON tb_ordem_servico.codBaseCliente = tb_cliente_base.codigo)" +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_ordem_servico_status ON tb_ordem_servico.idStatus = tb_ordem_servico_status.id) " +
                "ORDER BY tb_ordem_servico.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<OrdemServicoDTO> ordem = new List<OrdemServicoDTO>();

			while (leitor.Read())
			{
				OrdemServicoDTO ord = new OrdemServicoDTO();

				ord.Id = leitor.GetInt32(0);
				ord.Codigo = leitor.GetString(1);
				ord.DataRegistro = leitor.GetDateTime(2);
				ord.Cliente = leitor.GetString(3);
				ord.BaseCliente = leitor.GetString(4);
				ord.Titulo = leitor.GetString(5);
				ord.Descricao = leitor.GetString(6);
				ord.Obsevacao = leitor.GetString(7);
				ord.Progresso = leitor.GetInt32(8);
				ord.Proposta = leitor.GetString(9);
				ord.Status = leitor.GetString(10);

				ordem.Add(ord);
			}

			conexao.desconectar();
			cmd.Dispose();

			return ordem;
		}

        public void AtualizarProgressoOrdemServico(OrdemServicoDTO o)
        {
            cmd.CommandText = "UPDATE tb_ordem_servico SET " +
                "progresso = " + o.Progresso + " " +
                "WHERE codigo = '" + o.Codigo + "'";

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
    }
}
