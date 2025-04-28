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
    class PropostaComercialBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

		ClienteDTO cliDto = new ClienteDTO();
		ClienteBLL cliBll = new ClienteBLL();

		BaseClienteDTO bcDto = new BaseClienteDTO();
		BaseClienteBLL bcBll = new BaseClienteBLL();

		FormaPgtoDTO fpDto = new FormaPgtoDTO();
		FormaPgtoBLL fpBll = new FormaPgtoBLL();

		PropostaComercialStatusDTO staDto = new PropostaComercialStatusDTO();
		PropostaComercialStatusBLL staBll = new PropostaComercialStatusBLL();
		
		Int32 qtdIdPropostaComercial;
		Int32 qtdPropostaComercialCliente;

		string tabela = "tb_proposta_comercial";

        public void CriarNovoPropostaComercial(PropostaComercialDTO pc)
		{
			this.ContarPropostasComerciais();

			if(qtdIdPropostaComercial == 0)
            {
				pc.Id = 1;
            }
            else
            {
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM " + tabela + " ";

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					pc.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarPropostasComerciais()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_proposta_comercial";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();
				
				leitor.Read();
				qtdIdPropostaComercial = leitor.GetInt32(0);
				
				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdPropostaComercial;
		}

		public void SalvarPropostaComercial(PropostaComercialDTO pc)
		{
			bcDto.Cliente = pc.Cliente;
			bcDto.NomeBase = pc.BaseCliente;
			bcBll.SelecionarCodigoBaseCliente(bcDto);

			fpDto.CondicaoPgto = pc.CondicaoPgto;
			fpDto.FormaPgto = pc.FormaPgto;
			fpBll.SelecionarIdFormaPgto(fpDto);

			staDto.Status = pc.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_proposta_comercial (" +
				"id, " +
				"codigo, " +
				"dataProposta, " +
				"titulo, " +
				"descricao, " +
				"observacao, " +
				"codBaseCliente, " +
				"idFormaPgto, " +
				"valorTotal, " +
				"notaFiscal, " +
				"idStatus) " +
				"VALUES (" +
				pc.Id + ", '" +
				pc.Codigo + "', '" +
				pc.DataProposta + "', '" +
				pc.Titulo + "', '" +
				pc.Descricao + "', '" +
				pc.Observacao + "', '" +
				bcDto.Codigo + "', " +
				fpDto.Id + ", " +
				pc.Valor * 100 + ", '" +
				pc.NotaFiscal + "', " +
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

		public void EditarPropostaComercial(PropostaComercialDTO pc)
		{
			bcDto.NomeBase = pc.BaseCliente;
			bcDto.Cliente = pc.Cliente;
			bcBll.SelecionarCodigoBaseCliente(bcDto);

			fpDto.FormaPgto = pc.FormaPgto;
			fpDto.CondicaoPgto = pc.CondicaoPgto;
			fpBll.SelecionarIdFormaPgto(fpDto);

			cmd.CommandText = "UPDATE tb_proposta_comercial SET " +
				"dataProposta = '" + pc.DataProposta + "', " +
				"titulo = '" + pc.Titulo + "', " +
				"descricao = '" + pc.Descricao + "', " +
				"observacao = '" + pc.Observacao + "', " +
				"codBaseCliente = '" + bcDto.Codigo + "', " +
				"idFormaPgto = " + fpDto.Id + " " +
				"WHERE codigo = '" + pc.Codigo + "'";

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

		public void ExcluirPropostaComercial(PropostaComercialDTO pc)
		{
			cmd.CommandText = "DELETE FROM tb_proposta_comercial WHERE codigo = '" + pc.Codigo + "'";

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

		public List<PropostaComercialDTO> SelecionarPropostaComercial(PropostaComercialDTO pc)
		{
			cmd.CommandText = "SELECT " +
                "tb_proposta_comercial.id, " +
                "tb_proposta_comercial.codigo, " +
                "tb_proposta_comercial.dataProposta, " +
                "tb_proposta_comercial.titulo, " +
                "tb_proposta_comercial.descricao, " +
                "tb_proposta_comercial.observacao, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_proposta_comercial.valorTotal, " +
                "tb_condicao_pgto.condicao, " +
                "tb_forma_pgto.forma, " +
                "tb_proposta_comercial.notaFiscal, " +
                "tb_proposta_comercial_status.status " +
				"FROM (((((tb_proposta_comercial " +
                "INNER JOIN tb_cliente_base ON tb_proposta_comercial.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_forma_pgto ON tb_proposta_comercial.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_proposta_comercial_status ON tb_proposta_comercial.idStatus = tb_proposta_comercial_status.id) " +
                "WHERE tb_proposta_comercial.codigo = '" + pc.Codigo + "'";
			
			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>(13);

			leitor.Read();

			proposta.Add(new PropostaComercialDTO());

			proposta[0].Id = leitor.GetInt32(0);
			proposta[0].Codigo = leitor.GetString(1);
			proposta[0].DataProposta = leitor.GetDateTime(2);
			proposta[0].Titulo = leitor.GetString(3);
			proposta[0].Descricao = leitor.GetString(4);
			proposta[0].Observacao = leitor.GetString(5);
			proposta[0].Cliente = leitor.GetString(6);
			proposta[0].BaseCliente = leitor.GetString(7);
			proposta[0].Valor = leitor.GetInt32(8) / 100;
			proposta[0].CondicaoPgto = leitor.GetString(9);
			proposta[0].FormaPgto = leitor.GetString(10);
			proposta[0].NotaFiscal = leitor.GetString(11);
			proposta[0].Status = leitor.GetString(12);						

			conexao.desconectar();
			cmd.Dispose();			

			return proposta;
		}

		public List<PropostaComercialDTO> PopularComboboxPropostaComercial()
		{
			cmd.CommandText = "SELECT codigo FROM " + tabela + " ";

            cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>();

			while (leitor.Read())
			{
				PropostaComercialDTO pro = new PropostaComercialDTO();
				pro.Codigo = leitor.GetString(0);
				proposta.Add(pro);
			}

			conexao.desconectar();
			cmd.Dispose();

			return proposta;
		}

        public List<PropostaComercialDTO> PopularComboboxPropostaComercialStatus()
        {
			cmd.CommandText = "SELECT codigo FROM " + tabela + " " +
				"WHERE idStatus = 4 OR idStatus = 5";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>();

            while (leitor.Read())
            {
                PropostaComercialDTO pro = new PropostaComercialDTO();
                pro.Codigo = leitor.GetString(0);
                proposta.Add(pro);
            }

            conexao.desconectar();
            cmd.Dispose();

            return proposta;
        }

        public List<PropostaComercialDTO> ListarPropostaComercialStatus(PropostaComercialDTO pc)
		{
			staDto.Status = pc.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "SELECT " +
                "tb_proposta_comercial.id, " +
                "tb_proposta_comercial.codigo, " +
                "tb_proposta_comercial.dataProposta, " +
                "tb_proposta_comercial.titulo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_proposta_comercial.valorTotal, " +
                "tb_proposta_comercial.notaFiscal, " +
                "tb_proposta_comercial_status.status " +
				"FROM (((tb_proposta_comercial " +
                "INNER JOIN tb_cliente_base ON tb_proposta_comercial.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_proposta_comercial_status ON tb_proposta_comercial.idStatus = tb_proposta_comercial_status.id) " +
                "WHERE tb_proposta_comercial.idStatus = " + staDto.Id + " " +
                "ORDER BY tb_proposta_comercial.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>(9);

			while (leitor.Read())
			{
				PropostaComercialDTO pro = new PropostaComercialDTO();

				pro.Id = leitor.GetInt32(0);
				pro.Codigo = leitor.GetString(1);
				pro.DataProposta = leitor.GetDateTime(2);
				pro.Titulo = leitor.GetString(3);
				pro.Cliente = leitor.GetString(4);
				pro.BaseCliente = leitor.GetString(5);
				pro.Valor = leitor.GetInt32(6) / 100;
				pro.NotaFiscal = leitor.GetString(7);
				pro.Status = leitor.GetString(8);

				proposta.Add(pro);
			}

			conexao.desconectar();
			cmd.Dispose();

			return proposta;
		}

		public List<PropostaComercialDTO> ListarPropostaComercial()
		{
			cmd.CommandText = "SELECT " +
                "tb_proposta_comercial.id, " +
                "tb_proposta_comercial.codigo, " +
                "tb_proposta_comercial.dataProposta, " +
                "tb_proposta_comercial.titulo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_proposta_comercial.valorTotal, " +
                "tb_proposta_comercial.notaFiscal, " +
                "tb_proposta_comercial_status.status " +
                "FROM (((tb_proposta_comercial " +
                "INNER JOIN tb_cliente_base ON tb_proposta_comercial.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_proposta_comercial_status ON tb_proposta_comercial.idStatus = tb_proposta_comercial_status.id) " +
                "ORDER BY tb_proposta_comercial.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>(9);

			while (leitor.Read())
			{
				PropostaComercialDTO pro = new PropostaComercialDTO();

				pro.Id = leitor.GetInt32(0);
				pro.Codigo = leitor.GetString(1);
				pro.DataProposta = leitor.GetDateTime(2);
				pro.Titulo = leitor.GetString(3);
				pro.Cliente = leitor.GetString(4);
				pro.BaseCliente = leitor.GetString(5);
				pro.Valor = leitor.GetInt32(6) / 100;
				pro.NotaFiscal = leitor.GetString(7);
				pro.Status = leitor.GetString(8);

				proposta.Add(pro);
			}

			conexao.desconectar();
			cmd.Dispose();

			return proposta;
		}

		public void ModificarStatusPropostaComercial(PropostaComercialDTO pc)
		{
			staDto.Status = pc.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "UPDATE tb_proposta_comercial SET " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + pc.Codigo + "')";

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

		public void AtualizarValorPropostaComercial(PropostaComercialDTO pc)
		{
			cmd.CommandText = "UPDATE tb_proposta_comercial SET " +
				"valorTotal = valorTotal + (" + pc.Valor + " * 100) " +
				"WHERE codigo = '" + pc.Codigo + "'";

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

		public Int32 ContarPropostasComerciaisCliente(PropostaComercialDTO p)
		{
			cliDto.NomeFantasia = p.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT COUNT(id) FROM tb_proposta_comercial " +
				"WHERE codCliente = '" + p.Cliente + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdPropostaComercialCliente = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdPropostaComercialCliente;
		}

		public void CriarOrdemServicoPropostaComercial(PropostaComercialDTO pc)
		{
			cmd.CommandText = "UPDATE tb_proposta_comercial SET " +
				"codOrdemServico = '" + pc.OrdemServico + "' " +
				"WHERE codigo = '" + pc.Codigo + "'";

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

		public void AtualizarStatusProposta(PropostaComercialDTO pc)
        {
			staDto.Status = pc.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "UPDATE " + tabela + " SET " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + pc.Codigo + "'";

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

        public void VincularNotaFiscalProposta(PropostaComercialDTO pc)
        {
            staDto.Status = pc.Status;
            staBll.SelecionarIdStatus(staDto);

            cmd.CommandText = "UPDATE " + tabela + " SET " +
                "idStatus = " + staDto.Id + " " +
                "WHERE codigo = '" + pc.Codigo + "'";

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
