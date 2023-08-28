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
    class TecnicoBLL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

		CidadeDTO cidDto = new CidadeDTO();
		CidadeBLL cidBll = new CidadeBLL();

		TecnicoStatusDTO staDto = new TecnicoStatusDTO();
		TecnicoStatusBLL staBll = new TecnicoStatusBLL();

		Int32 qtdIdTecnico;

		public void CriarNovoTecnico(TecnicoDTO t)
		{
			this.ContarIdTecnico();

			if (qtdIdTecnico == 0)
			{
				t.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_tecnico";

				try
				{
					cmd.Connection = conexao.conectar();
					MySqlDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					t.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (MySqlException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdTecnico()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_tecnico";

			try
			{
				cmd.Connection = conexao.conectar();
				MySqlDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdTecnico = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (MySqlException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdTecnico;
		}

		public void SalvarTecnico(TecnicoDTO t)
		{
			cidDto.Cidade = t.Cidade;
			cidBll.SelecionarIdCidade(cidDto);

			staDto.Status = t.Status;
			staBll.SelecionarIdTecnicoStatus(staDto);

			cmd.CommandText = "INSERT INTO tb_tecnico (" +
				"id, " + 
				"codigo, " +
				"dataCadastro, " +
				"nome, " +
				"rg, " +
				"cpf, " + 
				"dataNascimento, " + 
				"endereco, " +
				"complemento, " + 
				"bairro, " + 
				"idCidade, " +
				"cep, " + 
				"telefone, " + 
				"celular, " + 
				"email, " + 
				"foto, " + 
				"idStatusTecnico) " +
				"VALUES (" +
				t.Id + ", '" +
				t.Codigo + "', '" +
				t.DataCadastro + "', '" +
				t.Nome + "', '" +
				t.Rg + "', '" +
				t.Cpf + "', '" +
				t.DataNascimento + "', '" +
				t.Endereco + ", '" +
				t.Complemento + "', '" +
				t.Bairro + "', " +
				cidDto.Id + ", '" +
				t.Cep + "', '" +
				t.Telefone + "', '" +
				t.Celular + "', '" +
				t.Email + "', '" +
				t.Foto + "', " +
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

		public void EditarTecnico(TecnicoDTO t)
		{
			cidDto.Cidade = t.Cidade;
			cidBll.SelecionarIdCidade(cidDto);

			staDto.Status = t.Status;
			staBll.SelecionarIdTecnicoStatus(staDto);

			cmd.CommandText = "UPDATE tb_tecnico SET " +
				"dataCadastro = '" + t.DataCadastro + "', " +
				"nome = '" + t.Nome + "', " +
				"rg = '" + t.Rg + "', " +
				"cpf = '" + t.Cpf + "', " +
				"dataNascimento = '" + t.DataNascimento + "', " +
				"endereco = '" + t.Endereco + ", " +
				"complemento = '" + t.Complemento + "', " +
				"bairro = '" + t.Bairro + "', " +
				"idCidade = '" + cidDto.Id + ", " +
				"cep = '" + t.Cep + "', " +
				"telefone = '" + t.Telefone + "', " +
				"celular = '" + t.Celular + "', " +
				"email = '" + t.Email + "' " +
				"WHERE codigo = '" + t.Codigo + "'";

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

		public void ExcluirTecnico(TecnicoDTO t)
		{
			cmd.CommandText = "DELETE FROM tb_tecnico WHERE codigo = '" + t.Codigo + "'";

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

		/*
		public List<TecnicoDTO> SelecionarTecnico(TecnicoDTO t)
		{
			
		}

		public string SelecionarCodigoTecnico(TecnicoDTO t)
		{
			
		}

		public List<TecnicoDTO> PopularComboboxTecnico()
		{
			
		}

		public List<TecnicoDTO> ListarTecnico()
		{
			
		}
		*/
	}
}
