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
    class ClienteBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		ClienteTipoDTO tipDto = new ClienteTipoDTO();
		ClienteTipoBLL tipBll = new ClienteTipoBLL();

		ClienteStatusDTO staDto = new ClienteStatusDTO();
		ClienteStatusBLL staBll = new ClienteStatusBLL();

		Int32 qtdIdCliente;

		string tabela = "tb_cliente";

		public void CriarNovoCliente(ClienteDTO c)
		{
			this.ContarClientes();

			if (qtdIdCliente == 0)
			{
				c.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_cliente";

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					c.Id = leitor.GetInt32(0) + 1;

					conexao.desconectar();
				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarClientes()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdCliente = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdCliente;
		}

		public void SalvarCliente(ClienteDTO c)
		{
			tipDto.TipoCliente = c.TipoCliente;
			tipBll.SelecionarIdTipoCliente(tipDto);

			staDto.Status = c.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_cliente (" +
				"id, " +
				"codigo, " +
				"idTipoCliente, " +
				"dataRegistro, " +
				"razaoSocial, " +
				"nomeFantasia, " +
				"logomarca, " +
				"idStatus) " +
				"VALUES (" +
				c.Id + ", '" +
				c.Codigo + "', " +
				tipDto.Id + ", '" +
				c.DataRegistro + "', '" +
				c.RazaoSocial + "', '" +
				c.NomeFantasia + "', '" +
				c.Logomarca + "', " +
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

		public void EditarCliente(ClienteDTO c)
		{
			tipDto.TipoCliente = c.TipoCliente;
			tipBll.SelecionarIdTipoCliente(tipDto);

			staDto.Status = c.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "UPDATE tb_cliente SET " +
				"idTipoCliente = " + tipDto.Id + ", " +
				"razaoSocial = '" + c.RazaoSocial + "', " +
				"nomeFantasia = '" + c.NomeFantasia + "', " +
				"idStatus = " + staDto.Id + " " +
				"WHERE codigo = '" + c.Codigo + "'";

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

		public void ExcluirCliente(ClienteDTO c)
		{
			cmd.CommandText = "DELETE FROM tb_cliente " +
				"WHERE codigo = '" + c.Codigo + "'";

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

		public List<ClienteDTO> SelecionarCliente(ClienteDTO c)
		{
			cmd.CommandText = "SELECT " +
                "tb_cliente.id, " +
                "tb_cliente.codigo, " +
                "tb_cliente_tipo.tipoCliente, " +
                "tb_cliente.dataRegistro, " +
                "tb_cliente.razaoSocial, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente.logomarca, " +
                "tb_cliente_status.status " +
				"FROM ((tb_cliente " +
                "INNER JOIN tb_cliente_tipo ON tb_cliente.idTipoCliente = tb_cliente_tipo.id) " +
                "INNER JOIN tb_cliente_status ON tb_cliente.idStatus = tb_cliente_status.id) " +
                "WHERE tb_cliente.codigo = '" + c.Codigo + "'";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<ClienteDTO> cliente = new List<ClienteDTO>(8);

			leitor.Read();

			cliente.Add(new ClienteDTO());

			cliente[0].Id = leitor.GetInt32(0);
			cliente[0].Codigo = leitor.GetString(1);
			cliente[0].TipoCliente = leitor.GetString(2);
            DateTime dataCadastro = leitor.GetDateTime(3);
            cliente[0].DataRegistro = dataCadastro.ToString("dd/MM/yyyy");
			cliente[0].RazaoSocial = leitor.GetString(4);
			cliente[0].NomeFantasia = leitor.GetString(5);
			cliente[0].Logomarca = leitor.GetString(6);
			cliente[0].Status = leitor.GetString(7);
			
			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public string SelecionarCodigoCliente(ClienteDTO c)
		{
			cmd.CommandText = "SELECT codigo FROM " + tabela + " " +
				"WHERE nomeFantasia = '" + c.NomeFantasia + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				c.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return c.Codigo;
		}

		public List<ClienteDTO> PopularComboboxCliente()
		{
			cmd.CommandText = "SELECT nomeFantasia FROM " + tabela + " " +
				"WHERE idStatus = 1";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<ClienteDTO> cliente = new List<ClienteDTO>();

			while (leitor.Read())
			{
				ClienteDTO cli = new ClienteDTO();
				cli.NomeFantasia = leitor.GetString(0);
				cliente.Add(cli);
			}

			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public List<ClienteDTO> ListarClientes()
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
				"ORDER BY c.codigo ASC; ";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<ClienteDTO> cliente = new List<ClienteDTO>();

            while (leitor.Read())
            {
				ClienteDTO cli = new ClienteDTO();

				cli.Id = leitor.GetInt32(0);
				cli.Codigo = leitor.GetString(1);
				cli.TipoCliente = leitor.GetString(2);
				cli.DataRegistro = leitor.GetString(3);
				cli.RazaoSocial = leitor.GetString(4);
				cli.NomeFantasia = leitor.GetString(5);
				cli.Logomarca = leitor.GetString(6);
				cli.Status = leitor.GetString(7);

				cliente.Add(cli);
			}

			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public List<ClienteDTO> ListarClientesStatus(ClienteDTO c)
		{
			staDto.Status = c.Status;
			staBll.SelecionarIdStatus(staDto);

			cmd.CommandText = "SELECT " +
                "tb_cliente.id, " +
                "tb_cliente.codigo, " +
                "tb_cliente_tipo.tipoCliente, " +
                "tb_cliente.dataRegistro, " +
                "tb_cliente.razaoSocial, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente.logomarca, " +
                "tb_cliente_status.status " +
                "FROM ((tb_cliente " +
                "INNER JOIN tb_cliente_tipo ON tb_cliente.idTipoCliente = tb_cliente_tipo.id) " +
                "INNER JOIN tb_cliente_status ON tb_cliente.idStatus = tb_cliente_status.id) " +
                "WHERE tb_cliente.idStatus = " + staDto.Id + " " +
                "ORDER BY tb_cliente.codigo ASC";

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();

			List<ClienteDTO> cliente = new List<ClienteDTO>();

			while (leitor.Read())
			{
				ClienteDTO cli = new ClienteDTO();

				cli.Id = leitor.GetInt32(0);
				cli.Codigo = leitor.GetString(1);
				cli.TipoCliente = leitor.GetString(2);
				DateTime dataCadastro = leitor.GetDateTime(3);
				cli.DataRegistro = dataCadastro.ToString("dd/MM/yyyy");
				cli.RazaoSocial = leitor.GetString(4);
				cli.NomeFantasia = leitor.GetString(5);
				cli.Logomarca = leitor.GetString(6);
				cli.Status = leitor.GetString(7);

				cliente.Add(cli);
			}

			conexao.desconectar();
			cmd.Dispose();

			return cliente;
		}

		public void SalvarLogomarcaCliente(ClienteDTO c)
		{

			cmd.CommandText = "UPDATE tb_cliente SET " +
				"logomarca =	" + c.Logomarca+ " " +
				"WHERE codigo = '" + c.Codigo + "'";

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
