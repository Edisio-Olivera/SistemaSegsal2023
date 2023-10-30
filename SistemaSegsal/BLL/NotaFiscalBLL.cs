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
    class NotaFiscalBLL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

		NotaFiscalTipoDTO tipDto = new NotaFiscalTipoDTO();
		NotaFiscalTipoBLL tipBll = new NotaFiscalTipoBLL();

		NotaFiscalStatusDTO staDto = new NotaFiscalStatusDTO();
		NotaFiscalStatusBLL staBll = new NotaFiscalStatusBLL();

		BaseClienteDTO basDto = new BaseClienteDTO();
		BaseClienteBLL basBll = new BaseClienteBLL();

		Int32 qtdIdNotaFiscal;
		Int32 valorTotalStatus;
		Int32 valorTotalStatusAno;
		Int32 ultimoIdNotaFiscal;
		Int32 valorTotalStatusMesAno;

		public void CriarNovoNotaFiscal(NotaFiscalDTO n)
		{
			this.ContarNotasFiscais();

			if (qtdIdNotaFiscal == 0)
			{
				n.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) FROM tb_nota_fiscal";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					n.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarNotasFiscais()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_nota_fiscal";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdNotaFiscal = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdNotaFiscal;
		}

		public Int32 SelecionarUltimoIdNotaFiscal()
        {
			cmd.CommandText = "SELECT MAX(id) FROM tb_nota_fiscal";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				ultimoIdNotaFiscal = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return ultimoIdNotaFiscal;
		}

		public void SalvarNotaFiscal(NotaFiscalDTO n)
		{
			tipDto.TipoNotaFiscal = n.TipoNotaFiscal;
			tipBll.SelecionarIdNotaFiscalTipo(tipDto);

			staDto.Status = n.Status;
			staBll.SelecionarIdNotaFiscalStatus(staDto);

			basDto.NomeBase = n.BaseCliente;
			basBll.SelecionarCodigoBaseCliente(basDto);

			cmd.CommandText = "INSERT INTO tb_nota_fiscal (" +
				"id, " +	
				"codigo, " +
				"dataEmissao, " +
				"dataRecebimento, " +
				"idTipoNotaFiscal, " +
				"codBaseCliente, " +
				"codigoVerificacao, " +
				"competencia, " +
				"numeroPedido, " +
				"servico, " +
				"valor, " +
				"idStatus) " +
				"VALUES (" +
				n.Id + ", '" +
				n.Codigo + "', '" +
				n.DataEmissao + "', '" +
				n.DataRecebimento + "', " +
				tipDto.Id + ", '" +
				basDto.Codigo + "', '" +
				n.CodigoVerificacao + "', '" +
				n.Competencia + "', '" +
				n.NumeroPedido + "', '" +
				n.Servico + "', " +
				n.Valor * 100 + ", " +
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

		public void EditarNotaFiscal(NotaFiscalDTO n)
		{
			tipDto.TipoNotaFiscal = n.TipoNotaFiscal;
			tipBll.SelecionarIdNotaFiscalTipo(tipDto);

			staDto.Status = n.Status;
			staBll.SelecionarIdNotaFiscalStatus(staDto);

			cmd.CommandText = "UPDATE tb_nota_fiscal SET " +
				"dataEmissao = " + n.DataEmissao + ", " +
				"dataRecebimento = '" + n.DataRecebimento + "', " +
				"idTipoNotaFiscal = " + tipDto.Id + ", " +
				"codigoVerificacao = '" + n.CodigoVerificacao + "', " +
				"competencia = '" + n.Competencia + "', " +
				"numeroPedido = '" + n.NumeroPedido + "', " +
				"servico = '" + n.Servico + "', " +
				"valor = " + n.Valor * 100 + ", " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + n.Codigo + "'";

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

		public void ExcluirNotaFiscal(NotaFiscalDTO n)
		{
			cmd.CommandText = "DELETE FROM tb_nota_fiscal " +
				"WHERE codigo = '" + n.Codigo + "'";

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

		public List<NotaFiscalDTO> SelecionarNotaFiscal(NotaFiscalDTO n)
		{
			cmd.CommandText = "SELECT " +
				"n.id, " +
				"n.codigo, " +
				"n.dataEmissao, " +
				"n.dataRecebimento, " +
				"t.tipoNotaFiscal, " +
				"c.nomeFantasia, " +
				"b.nomeBase, " +
				"n.codigoVerificacao, " +
				"n.competencia, " +
				"n.numeroPedido, " +
				"n.servico, " +
				"n.valor, " +
				"s.statusNotaFiscal " +
				"FROM tb_nota_fiscal n " +
				"INNER JOIN tb_nota_fiscal_tipo t ON n.idTipoNotaFiscal = t.id " +
				"INNER JOIN tb_cliente_base b ON n.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"INNER JOIN tb_nota_fiscal_status s ON n.idStatus = s.id " +
				"WHERE n.codigo = '" + n.Codigo + "'";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>(13);

			leitor.Read();

			nota.Add(new NotaFiscalDTO());

			nota[0].Id = leitor.GetInt32(0);
			nota[0].Codigo = leitor.GetString(1);
			DateTime dataEmissao = DateTime.Parse(leitor.GetString(2));
			nota[0].DataEmissao = dataEmissao.ToString("dd/MM/yyyy");
			DateTime dataRecebimento = DateTime.Parse(leitor.GetString(3));
			nota[0].DataRecebimento = dataRecebimento.ToString("dd/MM/yyyy");
			nota[0].TipoNotaFiscal = leitor.GetString(4);
			nota[0].Cliente = leitor.GetString(5);
			nota[0].BaseCliente = leitor.GetString(6);
			nota[0].CodigoVerificacao = leitor.GetString(7);
			nota[0].Competencia = leitor.GetString(8);
			nota[0].NumeroPedido = leitor.GetString(9);
			nota[0].Servico = leitor.GetString(10);
			nota[0].Valor = leitor.GetInt32(11) / 100;
			nota[0].Status = leitor.GetString(12);

			conexao.desconectar();
			cmd.Dispose();

			return nota;
		}

		public List<NotaFiscalDTO> ListarNotasFiscais()
		{
			cmd.CommandText = "SELECT " +
				"n.id, " +
				"n.codigo, " +
				"n.dataEmissao, " +
				"n.dataRecebimento, " +
				"t.tipoNotaFiscal, " +
				"c.nomeFantasia, " +
				"b.nomeBase, " +
				"n.servico, " +
				"n.valor, " +
				"s.statusNotaFiscal " +
				"FROM tb_nota_fiscal n " +
				"INNER JOIN tb_nota_fiscal_tipo t ON n.idTipoNotaFiscal = t.id " +
				"INNER JOIN tb_nota_fiscal_status s ON n.idStatus = s.id " +
				"INNER JOIN  tb_cliente_base b ON n.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"ORDER BY n.codigo DESC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

				nt.Id = leitor.GetInt32(0);
				nt.Codigo = leitor.GetString(1);
				DateTime dataEmissao = DateTime.Parse(leitor.GetString(2));
				nt.DataEmissao = dataEmissao.ToString("dd/MM/yyyy");
				DateTime dataRecebimento = DateTime.Parse(leitor.GetString(3));
				nt.DataRecebimento = dataRecebimento.ToString("dd/MM/yyyy");
				nt.TipoNotaFiscal = leitor.GetString(4);
				nt.Cliente = leitor.GetString(5);
				nt.BaseCliente = leitor.GetString(6);
				nt.Servico = leitor.GetString(7);
				nt.Valor = leitor.GetInt32(8) / 100;
				nt.Status = leitor.GetString(9);

				nota.Add(nt);
			}

			conexao.desconectar();
			cmd.Dispose();

			return nota;
		}

		public List<NotaFiscalDTO> ListarNotasFiscaisStatus(NotaFiscalDTO n)
		{
			staDto.Status = n.Status;
			staBll.SelecionarIdNotaFiscalStatus(staDto);

			cmd.CommandText = "SELECT " +
				"n.id, " + 
				"n.codigo, " + 
				"n.dataEmissao, " + 
				"n.dataRecebimento, " + 
				"t.tipoNotaFiscal, " +	 
				"c.nomeFantasia, " + 
				"b.nomeBase, " + 
				"n.servico, " + 
				"n.valor, " + 
				"s.statusNotaFiscal " + 
				"FROM tb_nota_fiscal n " + 
				"INNER JOIN tb_nota_fiscal_tipo t ON n.idTipoNotaFiscal = t.id " +
				"INNER JOIN tb_nota_fiscal_status s ON n.idStatus = s.id " +
				"INNER JOIN  tb_cliente_base b ON n.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"WHERE n.idStatus = " + staDto.Id + " " +
				"ORDER BY n.codigo DESC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

				nt.Id = leitor.GetInt32(0);
				nt.Codigo = leitor.GetString(1);
				DateTime dataEmissao = DateTime.Parse(leitor.GetString(2));
				nt.DataEmissao = dataEmissao.ToString("dd/MM/yyyy");
				DateTime dataRecebimento = DateTime.Parse(leitor.GetString(3));
				nt.DataRecebimento = dataRecebimento.ToString("dd/MM/yyyy");
				nt.TipoNotaFiscal = leitor.GetString(4);
				nt.Cliente = leitor.GetString(5);
				nt.BaseCliente = leitor.GetString(6);
				nt.Servico = leitor.GetString(7);
				nt.Valor = leitor.GetInt32(8) / 100;
				nt.Status = leitor.GetString(9);

				nota.Add(nt);
			}

			conexao.desconectar();
			cmd.Dispose();

			return nota;
		}

		public List<NotaFiscalDTO> ListarNotasFiscaisAno(NotaFiscalDTO n)
		{
			cmd.CommandText = "SELECT " +
				"n.id, " +
				"n.codigo, " +
				"n.dataEmissao, " +
				"n.dataRecebimento, " +
				"t.tipoNotaFiscal, " +
				"c.nomeFantasia, " +
				"b.nomeBase, " +
				"n.servico, " +
				"n.valor, " +
				"s.statusNotaFiscal " +
				"FROM tb_nota_fiscal n " +
				"INNER JOIN tb_nota_fiscal_tipo t ON n.idTipoNotaFiscal = t.id " +
				"INNER JOIN tb_nota_fiscal_status s ON n.idStatus = s.id " +
				"INNER JOIN  tb_cliente_base b ON n.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"WHERE YEAR(dataEmissao) = " + n.Ano + " " +
				"ORDER BY n.codigo DESC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

				nt.Id = leitor.GetInt32(0);
				nt.Codigo = leitor.GetString(1);
				DateTime dataEmissao = DateTime.Parse(leitor.GetString(2));
				nt.DataEmissao = dataEmissao.ToString("dd/MM/yyyy");
				DateTime dataRecebimento = DateTime.Parse(leitor.GetString(3));
				nt.DataRecebimento = dataRecebimento.ToString("dd/MM/yyyy");
				nt.TipoNotaFiscal = leitor.GetString(4);
				nt.Cliente = leitor.GetString(5);
				nt.BaseCliente = leitor.GetString(6);
				nt.Servico = leitor.GetString(7);
				nt.Valor = leitor.GetInt32(8) / 100;
				nt.Status = leitor.GetString(9);

				nota.Add(nt);
			}

			conexao.desconectar();
			cmd.Dispose();

			return nota;
		}

		public List<NotaFiscalDTO> ListarNotasFiscaisAnoStatus(NotaFiscalDTO n)
		{
			staDto.Status = n.Status;
			staBll.SelecionarIdNotaFiscalStatus(staDto);

			cmd.CommandText = "SELECT " +
				"n.id, " +
				"n.codigo, " +
				"n.dataEmissao, " +
				"n.dataRecebimento, " +
				"t.tipoNotaFiscal, " +
				"c.nomeFantasia, " +
				"b.nomeBase, " +
				"n.servico, " +
				"n.valor, " +
				"s.statusNotaFiscal " +
				"FROM tb_nota_fiscal n " +
				"INNER JOIN tb_nota_fiscal_tipo t ON n.idTipoNotaFiscal = t.id " +
				"INNER JOIN tb_nota_fiscal_status s ON n.idStatus = s.id " +
				"INNER JOIN  tb_cliente_base b ON n.codBaseCliente = b.codigo " +
				"INNER JOIN tb_cliente c ON b.codCliente = c.codigo " +
				"WHERE YEAR(dataEmissao) = " + n.Ano + " " + 
				"AND n.idStatus = " + staDto.Id + " " +
				"ORDER BY n.codigo DESC";

			cmd.Connection = conexao.conectar();
			MySqlDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

				nt.Id = leitor.GetInt32(0);
				nt.Codigo = leitor.GetString(1);
				DateTime dataEmissao = DateTime.Parse(leitor.GetString(2));
				nt.DataEmissao = dataEmissao.ToString("dd/MM/yyyy");
				DateTime dataRecebimento = DateTime.Parse(leitor.GetString(3));
				nt.DataRecebimento = dataRecebimento.ToString("dd/MM/yyyy");
				nt.TipoNotaFiscal = leitor.GetString(4);
				nt.Cliente = leitor.GetString(5);
				nt.BaseCliente = leitor.GetString(6);
				nt.Servico = leitor.GetString(7);
				nt.Valor = leitor.GetInt32(8) / 100;
				nt.Status = leitor.GetString(9);

				nota.Add(nt);
			}

			conexao.desconectar();
			cmd.Dispose();

			return nota;
		}

		public Int32 SomarNotasFiscaisStatus(NotaFiscalDTO n)
		{
			staDto.Status = n.Status;
			staBll.SelecionarIdNotaFiscalStatus(staDto);

			cmd.CommandText = "SELECT SUM(valor) FROM tb_nota_fiscal " +
				"WHERE idStatus = " + staDto.Id;

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				valorTotalStatus = leitor.GetInt32(0) / 100;

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return valorTotalStatus;
		}

		public Int32 SomarNotasFiscaisAnoStatus(NotaFiscalDTO n)
		{
			cmd.CommandText = "SELECT SUM(valor) FROM tb_nota_fiscal " +
				"WHERE YEAR(dataEmissao) = " + n.Ano + " " +
				"AND emissao = 1";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				valorTotalStatusAno = leitor.GetInt32(0) / 100;

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return valorTotalStatusAno;
		}

		public Int32 SomarNotasFiscaisMesAno(NotaFiscalDTO n)
		{
			cmd.CommandText = "SELECT SUM(valor) FROM tb_nota_fiscal " +
				"WHERE YEAR(dataEmissao) = " + n.Ano + " " + 
				"AND MONTH(dataEmissao) = " + n.Mes + " " +
				"AND emissao = 1";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();

				Int32 valor = leitor.IsDBNull(0) ? 0 : leitor.GetInt32(0);

				if (valor == null)
                {
					valorTotalStatusMesAno = 0;
				}
                else
                {
					valorTotalStatusMesAno = valor / 100;
				}				

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return valorTotalStatusMesAno;
		}

		public void ReceberNotaFiscal(NotaFiscalDTO n)
		{
			staDto.Status = n.Status;
			staBll.SelecionarIdNotaFiscalStatus(staDto);

			cmd.CommandText = "UPDATE tb_nota_fiscal SET " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + n.Codigo + "'";

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
