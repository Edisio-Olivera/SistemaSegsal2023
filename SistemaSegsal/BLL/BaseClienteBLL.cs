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
    class BaseClienteBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		ClienteDTO cliDto = new ClienteDTO();
		ClienteBLL cliBll = new ClienteBLL();

		CidadeDTO cidDto = new CidadeDTO();
		CidadeBLL cidBll = new CidadeBLL();

		BaseClienteStatusDTO staDto = new BaseClienteStatusDTO();
		BaseClienteStatusBLL staBll = new BaseClienteStatusBLL();		

		Int32 qtdIdBaseCliente;
		Int32 qtdIdBasesPorCliente;
		Int32 qtdBaseClienteCodigo;

		string tabela = "tb_cliente_base";

        public void CriarNovoBaseCliente(BaseClienteDTO bc)
		{
			this.ContarBasesCliente();

			if (qtdIdBaseCliente == 0)
			{
				bc.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_cliente_base";

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					bc.Id = leitor.GetInt32(0);

					conexao.desconectar();

				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarBasesCliente()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdBaseCliente = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdBaseCliente;
		}

		public void SalvarBaseCliente(BaseClienteDTO bc)
		{
			cliDto.NomeFantasia = bc.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cidDto.Cidade = bc.Cidade;
			cidBll.SelecionarIdCidade(cidDto);

			staDto.Status = bc.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_cliente_base (" +
				"id, " +
				"codigo, " +
				"dataRegistro, " +
				"codCliente, " +
				"nomeBase, " +
				"endereco, " +
				"complemento, " +
				"bairro, " +
				"idCidade, " +
				"cep, " +
				"cnpj, " +
				"ie, " +
				"idStatus) " +
				"VALUES (" +
				bc.Id + ", '" +
				bc.Codigo + "', '" +
				bc.DataRegistro + "', '" +
				cliDto.Codigo + "', '" +
				bc.NomeBase + "', '" +
				bc.Endereco + "', '" +
				bc.Complemento + "', '" +
				bc.Bairro + "', " +
				cidDto.Id + ", '" +
				bc.Cep + "', '" +
				bc.Cnpj + "', '" +
				bc.InscEstadual + "', " +
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

		public void EditarBaseCliente(BaseClienteDTO bc)
		{
			cliDto.NomeFantasia = bc.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cidDto.Cidade = bc.Cidade;
			cidBll.SelecionarIdCidade(cidDto);

			staDto.Status = bc.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "UPDATE tb_cliente_base SET " +
				"nomeBase = '" + bc.NomeBase + "', " +
				"endereco = '" + bc.Endereco + "', " +
				"complemento = '" + bc.Complemento + "', " +
				"bairro = '" + bc.Bairro + "', " +
				"idCidade = " + cidDto.Id + ", " +
				"cep = '" + bc.Cep + "', " +
				"cnpj = '" + bc.Cnpj + "', " +
				"ie = '" + bc.InscEstadual + "', " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + bc.Codigo + "'";				

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

		public void ExcluirBaseCliente(BaseClienteDTO bc)
		{
			cmd.CommandText = "DELETE FROM tb_cliente_base " +
				"WHERE codigo = '" + bc.Codigo + "'";

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

		public List<BaseClienteDTO> SelecionarBaseCliente(BaseClienteDTO bc)
		{
			cmd.CommandText = "SELECT " +
                "tb_cliente_base.id, " +
                "tb_cliente_base.codigo, " +
                "tb_cliente_base.dataRegistro, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_cliente_base.endereco, " +
                "tb_cliente_base.complemento, " +
                "tb_cliente_base.bairro, " +
                "tb_cidade.cidade, " +
                "tb_uf.sigla, " +
                "tb_cliente_base.cep, " +
                "tb_cliente_base.cnpj, " +
                "tb_cliente_base.ie, " +
                "tb_cliente_base_status.status " +
				"FROM ((((tb_cliente_base " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_cidade ON tb_cliente_base.idCidade = tb_cidade.id) " +
                "INNER JOIN tb_uf ON tb_cidade.idUf = tb_uf.id) " +
                "INNER JOIN tb_cliente_base_status ON tb_cliente_base.idStatus = tb_cliente_base_status.id) " +
                "WHERE tb_cliente_base.codigo = '" + bc.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<BaseClienteDTO> baseCli = new List<BaseClienteDTO>();

			leitor.Read();
			
			baseCli.Add(new BaseClienteDTO());

			baseCli[0].Id = leitor.GetInt32(0);
			baseCli[0].Codigo = leitor.GetString(1);
			baseCli[0].DataRegistro = leitor.GetDateTime(2);
			baseCli[0].Cliente = leitor.GetString(3);
			baseCli[0].NomeBase = leitor.GetString(4);
			baseCli[0].Endereco = leitor.GetString(5);
			baseCli[0].Complemento = leitor.GetString(6);
			baseCli[0].Bairro = leitor.GetString(7);
			baseCli[0].Cidade = leitor.GetString(8);
			baseCli[0].Uf = leitor.GetString(9);
			baseCli[0].Cep = leitor.GetString(10);
			baseCli[0].Cnpj = leitor.GetString(11);
			baseCli[0].InscEstadual = leitor.GetString(12);
			baseCli[0].Status = leitor.GetString(13);			

			conexao.desconectar();
			cmd.Dispose();

			return baseCli;
		}

		public string SelecionarCodigoBaseCliente(BaseClienteDTO bc)
		{
			cliDto.NomeFantasia = bc.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT codigo FROM " + tabela + " " +
				"WHERE nomeBase = '" + bc.NomeBase + "' " +
				"AND codCliente = '" + cliDto.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				bc.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return bc.Codigo;
		}

		public List<BaseClienteDTO> PopularComboboxBaseCliente(BaseClienteDTO bc)
		{
			cliDto.NomeFantasia = bc.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT nomeBase FROM tb_cliente_base " +
				"WHERE codCliente = '" + cliDto.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<BaseClienteDTO> baseCli = new List<BaseClienteDTO>();

			while (leitor.Read())
			{
				BaseClienteDTO bas = new BaseClienteDTO();
				bas.NomeBase = leitor.GetString(0);
				baseCli.Add(bas);
			}

			conexao.desconectar();
			cmd.Dispose();

			return baseCli;
		}

		public List<BaseClienteDTO> ListarBasesClienteCodigo(BaseClienteDTO bc)
		{
			cliDto.NomeFantasia = bc.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT " +
                "tb_cliente_base.id, " +
                "tb_cliente_base.codigo, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_cidade.cidade, " +
                "tb_uf.sigla, " +
                "tb_cliente_base.cnpj, " +
                "tb_cliente_base.ie, " +
                "tb_cliente_base_status.status " +
				"FROM ((((tb_cliente_base " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_cidade ON tb_cliente_base.idCidade = tb_cidade.id) " +
                "INNER JOIN tb_uf ON tb_cidade.idUf = tb_uf.id) " +
                "INNER JOIN tb_cliente_base_status ON tb_cliente_base.idStatus = tb_cliente_base_status.id) " +
                "WHERE tb_cliente_base.codCliente = '" + cliDto.Codigo + "' " +
                "ORDER BY tb_cliente_base.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<BaseClienteDTO> baseCli = new List<BaseClienteDTO>(9);

            while (leitor.Read())
            {
				BaseClienteDTO bas = new BaseClienteDTO();

				bas.Id = leitor.GetInt32(0);
				bas.Codigo = leitor.GetString(1);
				bas.Cliente = leitor.GetString(2);
				bas.NomeBase = leitor.GetString(3);
				bas.Cidade = leitor.GetString(4);
				bas.Uf = leitor.GetString(5);
				bas.Cnpj = leitor.GetString(6);
				bas.InscEstadual = leitor.GetString(7);
				bas.Status = leitor.GetString(8);

				baseCli.Add(bas);
			}		

			conexao.desconectar();
			cmd.Dispose();

			return baseCli;
		}

		public Int32 ContarBasesPorCliente(BaseClienteDTO b)
		{
			cliDto.NomeFantasia = b.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base " +
				"WHERE codCliente = '" + cliDto.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdBasesPorCliente = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdBasesPorCliente;
		}

		public Int32 ContarBasesClienteCodigo(BaseClienteDTO bc)
		{
			cliDto.NomeFantasia = bc.Cliente;
			cliBll.SelecionarCodigoCliente(cliDto);

			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_base " +
				"WHERE codCliente = '" + cliDto.Codigo + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdBaseClienteCodigo = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdBaseClienteCodigo;
		}


		public List<BaseClienteDTO> SelecionarBaseClienteCnpj(BaseClienteDTO bc)
		{
			cmd.CommandText = "SELECT " +
                "tb_cliente_base.id, " +
                "tb_cliente_base.codigo, " +
                "tb_cliente_base.dataRegistro, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                "tb_cliente_base.endereco, " +
                "tb_cliente_base.complemento, " +
                "tb_cliente_base.bairro, " +
                "tb_cidade.cidade, " +
                "tb_uf.sigla, " +
                "tb_cliente_base.cep, " +
                "tb_cliente_base.cnpj, " +
                "tb_cliente_base.ie, " +
                "tb_cliente_base_status.status " +
				"FROM ((((tb_cliente_base " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_cidade ON tb_cliente_base.idCidade = tb_cidade.id) " +
                "INNER JOIN tb_uf ON tb_cliente_base.idUf = tb_uf.id) " +
                "INNER JOIN tb_cliente_base_status ON tb_cliente_base.idStatus = tb_cliente_base_status.id) " +
                "WHERE tb_cliente_base.cnpj = '" + bc.Cnpj + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<BaseClienteDTO> baseCli = new List<BaseClienteDTO>();

			leitor.Read();

			baseCli.Add(new BaseClienteDTO());

			baseCli[0].Id = leitor.GetInt32(0);
			baseCli[0].Codigo = leitor.GetString(1);
			baseCli[0].DataRegistro = leitor.GetDateTime(2);
			baseCli[0].Cliente = leitor.GetString(3);
			baseCli[0].NomeBase = leitor.GetString(4);
			baseCli[0].Endereco = leitor.GetString(5);
			baseCli[0].Complemento = leitor.GetString(6);
			baseCli[0].Bairro = leitor.GetString(7);
			baseCli[0].Cidade = leitor.GetString(8);
			baseCli[0].Uf = leitor.GetString(9);
			baseCli[0].Cep = leitor.GetString(10);
			baseCli[0].Cnpj = leitor.GetString(11);
			baseCli[0].InscEstadual = leitor.GetString(12);
			baseCli[0].Status = leitor.GetString(13);

			conexao.desconectar();
			cmd.Dispose();

			return baseCli;
		}
	}
}
