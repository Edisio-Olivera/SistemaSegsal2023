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
    class PropostaComercialBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

		ClienteDTO cliDto = new ClienteDTO();
		ClienteBLL cliBll = new ClienteBLL();

		BaseClienteDTO bcDto = new BaseClienteDTO();
		BaseClienteBLL bcBll = new BaseClienteBLL();

		FormaPgtoDTO fpDto = new FormaPgtoDTO();
		FormaPgtoBLL fpBll = new FormaPgtoBLL();

		PropostaComercialStatusDTO staDto = new PropostaComercialStatusDTO();
		PropostaComercialStatusBLL staBll = new PropostaComercialStatusBLL();
		
		Int32 qtdIdPropostaComercial;

		public void CriarNovoPropostaComercial(PropostaComercialDTO pc)
		{
			this.ContarPropostasComerciais();

			if(qtdIdPropostaComercial == 0)
            {
				pc.Id = 1;
            }
            else
            {
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_proposta_comercial";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					pc.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
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
				MySqlDataReader leitor = cmd.ExecuteReader();
				
				leitor.Read();
				qtdIdPropostaComercial = leitor.GetInt32(0);
				
				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdPropostaComercial;
		}

		public void SalvarPropostaComercial(PropostaComercialDTO pc)
		{
			bcDto.NomeBase = pc.BaseCliente;
			bcBll.SelecionarCodigoBaseCliente(bcDto);

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
				pc.Valor + ", '" +
				pc.NotaFiscal + "', " +
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

		public void EditarPropostaComercial(PropostaComercialDTO pc)
		{
			bcDto.NomeBase = pc.BaseCliente;
			bcBll.SelecionarCodigoBaseCliente(bcDto);

			fpDto.FormaPgto = pc.FormaPgto;
			fpBll.SelecionarIdFormaPgto(fpDto);

			//staDto.Status = pc.Status;
			//staBll.SelecionarIdStatus(staDto);

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
			catch (MySqlException ex)
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
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<PropostaComercialDTO> SelecionarPropostaComercial(PropostaComercialDTO pc)
		{
			cmd.CommandText = "SELECT " +
				"pc.id, " +
				"pc.codigo, " +
				"pc.dataProposta, " +
				"pc.titulo, " +
				"pc.descricao, " +
				"pc.observacao, " +
				"cl.nomeFantasia, " +
				"bc.nomeBase, " +
				"pc.valorTotal, " +
				"cp.condicao, " +
				"fp.forma, " +
				"pc.notaFiscal, " +
				"st.statusProposta " +
				"FROM tb_proposta_comercial pc " +
				"INNER JOIN tb_cliente_base bc ON pc.codBaseCliente = bc.codigo " +
				"INNER JOIN tb_cliente cl ON bc.codCliente = cl.codigo " +
				"INNER JOIN tb_forma_pgto fp ON pc.idFormaPgto = fp.id " +
				"INNER JOIN tb_condicao_pgto cp ON fp.idCondicao = cp.id " +
				"INNER JOIN tb_proposta_comercial_status st ON pc.idStatus = st.id " +
				"WHERE pc.codigo = '" + pc.Codigo + "'";
			
			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>(13);

			leitor.Read();

			proposta.Add(new PropostaComercialDTO());

			proposta[0].Id = leitor.GetInt32(0);
			proposta[0].Codigo = leitor.GetString(1);
			proposta[0].DataProposta = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
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
			cmd.CommandText = "SELECT codigo FROM tb_proposta_comercial";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();
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
				"pc.id, " +
				"pc.codigo, " +
				"pc.dataProposta, " +
				"pc.titulo, " +
				"cl.nomeFantasia, " +
				"cb.nomeBase, " +
				"pc.valorTotal, " +
				"pc.notaFiscal, " +
				"st.statusProposta " +
				"FROM tb_proposta_comercial pc " +
				"INNER JOIN tb_cliente_base cb ON pc.codBaseCliente = cb.codigo " +
				"INNER JOIN tb_cliente cl ON cb.codCliente = cl.codigo " +
				"INNER JOIN tb_proposta_comercial_status st ON pc.idStatus = st.id " +
				"WHERE pc.idStatus = " + staDto.Id + " " +
				"ORDER BY pc.codigo DESC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>(9);

			while (leitor.Read())
			{
				PropostaComercialDTO pro = new PropostaComercialDTO();

				pro.Id = leitor.GetInt32(0);
				pro.Codigo = leitor.GetString(1);
				pro.DataProposta = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
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
				"pc.id, " +
				"pc.codigo, " +
				"pc.dataProposta, " +
				"pc.titulo, " +
				"cl.nomeFantasia, " +
				"cb.nomeBase, " +
				"pc.valorTotal, " +
				"pc.notaFiscal, " +
				"st.statusProposta " +
				"FROM tb_proposta_comercial pc " +
				"INNER JOIN tb_cliente_base cb ON pc.codBaseCliente = cb.codigo " +
				"INNER JOIN tb_cliente cl ON cb.codCliente = cl.codigo " +
				"INNER JOIN tb_proposta_comercial_status st ON pc.idStatus = st.id " +
				"ORDER BY pc.codigo DESC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<PropostaComercialDTO> proposta = new List<PropostaComercialDTO>(9);

			while (leitor.Read())
			{
				PropostaComercialDTO pro = new PropostaComercialDTO();

				pro.Id = leitor.GetInt32(0);
				pro.Codigo = leitor.GetString(1);
				pro.DataProposta = leitor.GetDateTime(2).ToString("dd/MM/yyyy");
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
			catch (MySqlException ex)
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
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
