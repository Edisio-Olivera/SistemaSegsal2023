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
using iText.StyledXmlParser.Jsoup.Select;
using System.Reflection;

namespace SistemaSegsal.BLL
{
    class NotaFiscalBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		NotaFiscalTipoDTO tipDto = new NotaFiscalTipoDTO();
		NotaFiscalTipoBLL tipBll = new NotaFiscalTipoBLL();

		NotaFiscalStatusDTO staDto = new NotaFiscalStatusDTO();
		NotaFiscalStatusBLL staBll = new NotaFiscalStatusBLL();

		BaseClienteDTO basDto = new BaseClienteDTO();
		BaseClienteBLL basBll = new BaseClienteBLL();

		CondicaoPgtoDTO cndDto = new CondicaoPgtoDTO();
		CondicaoPgtoBLL cndBll = new CondicaoPgtoBLL();

		FormaPgtoDTO frmDto = new FormaPgtoDTO();
		FormaPgtoBLL frmBll = new FormaPgtoBLL();

		Int32 qtdIdNotaFiscal;
		Int32 valorTotalStatus;
		Int32 valorTotalStatusAno;
		Int32 ultimoIdNotaFiscal;
		Int32 valorTotalStatusMesAno;
		Int32 qtdNotasMesAno;
        Int32 qtdNotasAno;

		string tabela = "tb_nota_fiscal";

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
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					n.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (OleDbException ex)
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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdNotaFiscal = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				ultimoIdNotaFiscal = leitor.GetInt32(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
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

			basDto.Cliente = n.Cliente;
			basDto.NomeBase = n.BaseCliente;
			basBll.SelecionarCodigoBaseCliente(basDto);

			frmDto.CondicaoPgto = n.CondPgto;
			frmDto.FormaPgto = n.FormaPgto;
			frmBll.SelecionarIdFormaPgto(frmDto);

			cmd.CommandText = "INSERT INTO " + tabela + " (" +
				"id, " +	
				"codigo, " +
				"dataEmissao, " +
				"dataRecebimento, " +
				"idTipoNotaFiscal, " +
                "competencia, " +
                "codigoVerificacao, " +
                "codBaseCliente, " +
                "servico, " +
                "numeroPedido, " +
				"idFormaPgto, " +				
				"valor, " +
				"arquivo, " +
				"idStatus) " +
				"VALUES (" +
				n.Id + ", '" +
				n.Codigo + "', '" +
				n.DataEmissao + "', '" +
				n.DataRecebimento + "', " +
				tipDto.Id + ", '" +
                n.Competencia + "', '" +                
				n.CodigoVerificacao + "', '" +
                basDto.Codigo + "', '" +                
				n.Servico + "', '" +
                n.NumeroPedido + "', " +
				frmDto.Id + ", " +
                n.Valor * 100 + ", '" +
                n.Arquivo + "', " +                
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
			catch (OleDbException ex)
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
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		public List<NotaFiscalDTO> SelecionarNotaFiscal(NotaFiscalDTO n)
		{
			cmd.CommandText = "SELECT " +
                "tb_nota_fiscal.id, " +
                "tb_nota_fiscal.codigo, " +
                "tb_nota_fiscal.dataEmissao, " +
                "tb_nota_fiscal.dataRecebimento, " +
                "tb_nota_fiscal_tipo.tipo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_nota_fiscal.codigoVerificacao, " +
                "tb_nota_fiscal.competencia, " +
                "tb_nota_fiscal.numeroPedido, " +
                "tb_nota_fiscal.servico, " +
                "tb_nota_fiscal.valor, " +
                "tb_nota_fiscal_status.status " +
				"FROM ((((tb_nota_fiscal " +
                "INNER JOIN tb_nota_fiscal_tipo ON tb_nota_fiscal.idTipoNotaFiscal = tb_nota_fiscal_tipo.id) " +
                "INNER JOIN tb_cliente_base ON tb_nota_fiscal.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_nota_fiscal_status ON tb_nota_fiscal.idStatus = tb_nota_fiscal_status.id) " +
                "WHERE tb_nota_fiscal.codigo = '" + n.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>(13);

			leitor.Read();

			nota.Add(new NotaFiscalDTO());

			nota[0].Id = leitor.GetInt32(0);
			nota[0].Codigo = leitor.GetString(1);
			nota[0].DataEmissao = leitor.GetDateTime(2);
			nota[0].DataRecebimento = leitor.GetDateTime(3);
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
                "tb_nota_fiscal.id, " +
                "tb_nota_fiscal.codigo, " +
                "tb_nota_fiscal.dataEmissao, " +
                "tb_nota_fiscal.dataRecebimento, " +
                "tb_nota_fiscal_tipo.tipo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_nota_fiscal.servico, " +
                "tb_nota_fiscal.valor, " +
                "tb_nota_fiscal_status.status " +
                "FROM ((((tb_nota_fiscal " +
                "INNER JOIN tb_nota_fiscal_tipo ON tb_nota_fiscal.idTipoNotaFiscal = tb_nota_fiscal_tipo.id) " +
                "INNER JOIN tb_nota_fiscal_status ON tb_nota_fiscal.idStatus = tb_nota_fiscal_status.id) " +
                "INNER JOIN tb_cliente_base ON tb_nota_fiscal.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "ORDER BY tb_nota_fiscal.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

                nt.Id = leitor.GetInt32(0);
                nt.Codigo = leitor.GetString(1);
                nt.DataEmissao = leitor.GetDateTime(2);
                nt.DataRecebimento = leitor.GetDateTime(3);
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
                "tb_nota_fiscal.id, " +
                "tb_nota_fiscal.codigo, " +
                "tb_nota_fiscal.dataEmissao, " +
                "tb_nota_fiscal.dataRecebimento, " +
                "tb_nota_fiscal_tipo.tipo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_nota_fiscal.servico, " +
                "tb_nota_fiscal.valor, " +
                "tb_nota_fiscal_status.status " +
                "FROM ((((tb_nota_fiscal " +
                "INNER JOIN tb_nota_fiscal_tipo ON tb_nota_fiscal.idTipoNotaFiscal = tb_nota_fiscal_tipo.id) " +
                "INNER JOIN tb_nota_fiscal_status ON tb_nota_fiscal.idStatus = tb_nota_fiscal_status.id) " +
                "INNER JOIN tb_cliente_base ON tb_nota_fiscal.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "WHERE tb_nota_fiscal.idStatus = " + staDto.Id + " " +
                "ORDER BY tb_nota_fiscal.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

                nt.Id = leitor.GetInt32(0);
                nt.Codigo = leitor.GetString(1);
                nt.DataEmissao = leitor.GetDateTime(2);
                nt.DataRecebimento = leitor.GetDateTime(3);
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
				"tb_nota_fiscal.id, " + 
				"tb_nota_fiscal.codigo, " +
				"tb_nota_fiscal.dataEmissao, " +
                "tb_nota_fiscal.dataRecebimento, " +
                "tb_nota_fiscal_tipo.tipo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_nota_fiscal.servico, " +
                "tb_nota_fiscal.valor, " +
                "tb_nota_fiscal_status.status " +
                "FROM ((((tb_nota_fiscal " +
                "INNER JOIN tb_nota_fiscal_tipo ON tb_nota_fiscal.idTipoNotaFiscal = tb_nota_fiscal_tipo.id) " +
                "INNER JOIN tb_nota_fiscal_status ON tb_nota_fiscal.idStatus = tb_nota_fiscal_status.id) " + 
                "INNER JOIN tb_cliente_base ON tb_nota_fiscal.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "WHERE YEAR(dataEmissao) = '" + n.Ano + "' " +
                "ORDER BY tb_nota_fiscal.codigo DESC;";

            cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

				nt.Id = leitor.GetInt32(0);
				nt.Codigo = leitor.GetString(1);
				nt.DataEmissao = leitor.GetDateTime(2);
				nt.DataRecebimento = leitor.GetDateTime(3);
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
                "tb_nota_fiscal.id, " +
                "tb_nota_fiscal.codigo, " +
                "tb_nota_fiscal.dataEmissao, " +
                "tb_nota_fiscal.dataRecebimento, " +
                "tb_nota_fiscal_tipo.tipo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_nota_fiscal.servico, " +
                "tb_nota_fiscal.valor, " +
                "tb_nota_fiscal_status.status " +
                "FROM ((((tb_nota_fiscal " +
                "INNER JOIN tb_nota_fiscal_tipo ON tb_nota_fiscal.idTipoNotaFiscal = tb_nota_fiscal_tipo.id) " +
                "INNER JOIN tb_nota_fiscal_status ON tb_nota_fiscal.idStatus = tb_nota_fiscal_status.id) " +
                "INNER JOIN tb_cliente_base ON tb_nota_fiscal.codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "WHERE YEAR(dataEmissao) = " + n.Ano + " " +
                "AND tb_nota_fiscal.idStatus = " + staDto.Id + " " +
                "ORDER BY tb_nota_fiscal.codigo DESC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<NotaFiscalDTO> nota = new List<NotaFiscalDTO>();

			while (leitor.Read())
			{
				NotaFiscalDTO nt = new NotaFiscalDTO();

				nt.Id = leitor.GetInt32(0);
				nt.Codigo = leitor.GetString(1);
				nt.DataEmissao = leitor.GetDateTime(2);
				nt.DataRecebimento = leitor.GetDateTime(3);
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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				valorTotalStatus = leitor.GetInt32(0) / 100;

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
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
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				valorTotalStatusAno = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
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
				"AND idStatus <> 3";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();

                valorTotalStatusMesAno = leitor.GetInt32(0);

				//if(valor == null)
				//{
				//	valorTotalStatusMesAno = 0;
				//}
				//else
				//{
				//	valorTotalStatusMesAno = valor;
    //            }
			
				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return valorTotalStatusMesAno;
		}

        public Int32 SomarNotasFiscaisAno(NotaFiscalDTO n)
        {
            cmd.CommandText = "SELECT SUM(valor) FROM tb_nota_fiscal " +
                "WHERE YEAR(dataEmissao) = " + n.Ano + " " +
                "AND idStatus <> 3";

			MessageBox.Show(cmd.CommandText);

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();

                valorTotalStatusAno = Convert.ToInt32(leitor.GetInt32(0));

                //if (valor == "")
                //{
                //    valorTotalStatusAno = 0;
                //}
                //else
                //{
                //    valorTotalStatusAno = Int32.Parse(valor);
                //}
		
                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return valorTotalStatusAno;
        }

        public Int32 ContarNotasFiscaisMesAno(NotaFiscalDTO n)
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_nota_fiscal " +
                "WHERE YEAR(dataEmissao) = " + n.Ano + " " +
                "AND MONTH(dataEmissao) = " + n.Mes + " " +
                "AND idStatus <> 3";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();

                Int32 qtd = leitor.GetInt32(0);

                qtdNotasMesAno = qtd;

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdNotasMesAno;
        }

        public Int32 ContarNotasFiscaisAno(NotaFiscalDTO n)
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_nota_fiscal " +
                "WHERE YEAR(dataEmissao) = " + n.Ano + " " +
                "AND idStatus <> 3";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();

                Int32 qtd = leitor.GetInt32(0);

                qtdNotasAno = qtd;

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdNotasAno;
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
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
