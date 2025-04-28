using System;
using System.Collections.Generic;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    class TecnicoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		CidadeDTO cidDto = new CidadeDTO();
		CidadeBLL cidBll = new CidadeBLL();

		SexoDTO sexDto = new SexoDTO();
		SexoBLL SexBll = new SexoBLL();

		FuncaoDTO fncDto = new FuncaoDTO();
		FuncaoBLL fncBll = new FuncaoBLL();

		UfDTO ufDto = new UfDTO();
		UfBLL ufBll = new UfBLL();

		TecnicoStatusDTO staDto = new TecnicoStatusDTO();
		TecnicoStatusBLL staBll = new TecnicoStatusBLL();

		Int32 qtdIdTecnico;

		string tabela = "tb_tecnico";

		public void CriarNovoTecnico(TecnicoDTO t)
		{
			this.ContarIdTecnico();

			if (qtdIdTecnico == 0)
			{
				t.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM " + tabela;

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					t.Id = leitor.GetInt32(0);

					conexao.desconectar();
				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarIdTecnico()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM " + tabela;

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdTecnico = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdTecnico;
		}

		public void SalvarTecnico(TecnicoDTO t)
		{
			sexDto.Sexo = t.Sexo;
			SexBll.SelecionarIdSexo(sexDto);

			fncDto.Funcao = t.Funcao;
			fncBll.SelecionarIdFuncao(fncDto);

			cidDto.Cidade = t.Cidade;
			cidDto.Uf = t.Uf;
			cidBll.SelecionarIdCidade(cidDto);

			staDto.Status = t.Status;
			staBll.SelecionarIdTecnicoStatus(staDto);

			cmd.CommandText = "INSERT INTO " + tabela +" (" +
				"id, " +
				"codigo, " +
				"dataRegistro, " +
				"nome, " +
				"dataNasc, " +
				"idSexo, " +
				"endereco, " +
				"bairro, " +
				"idCidade, " +
				"cep, " +
				"telefone, " +
				"email, " +
				"rg, " +
				"cpf, " +
				"foto, " +
				"idStatus, " +
				"classificacao, " +
				"nomeUsual, " +
				"idFuncao, " +
				"assinatura, " +
				"pasta, " +
				"dataAdmissao) " +
				"VALUES (" +
				t.Id + ", '" +
				t.Codigo + "', '" +
				t.DataCadastro + "', '" +
				t.Nome + "', '" +
				t.DataNascimento + "', " +
				sexDto.Id + ", '" +
				t.Endereco + "', '" +
				t.Bairro + "', " +
				cidDto.Id + ", '" +
				t.Cep + "', '" +
				t.Telefone + "', '" +
				t.Email + "', '" +
				t.Rg + "', '" +
				t.Cpf + "', '" +
				t.Foto + "', " +
				staDto.Id + ", " +
				t.Classificacao + ", '" +
				t.NomeUsual + "', " +
				fncDto.Id + ", '" +
				t.Assinatura + "', '" +
				t.Pasta + "', '" +
				t.DataAdmissao + "')";

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

		public void EditarTecnico(TecnicoDTO t)
		{
			cidDto.Cidade = t.Cidade;
			cidBll.SelecionarIdCidade(cidDto);

			staDto.Status = t.Status;
			staBll.SelecionarIdTecnicoStatus(staDto);

			//cmd.CommandText = "UPDATE tb_tecnico SET " +
			//	"dataCadastro = '" + t.DataCadastro + "', " +
			//	"nome = '" + t.Nome + "', " +
			//	"rg = '" + t.Rg + "', " +
			//	"cpf = '" + t.Cpf + "', " +
			//	"dataNascimento = '" + t.DataNascimento + "', " +
			//	"endereco = '" + t.Endereco + ", " +
			//	"complemento = '" + t.Complemento + "', " +
			//	"bairro = '" + t.Bairro + "', " +
			//	"idCidade = '" + cidDto.Id + ", " +
			//	"cep = '" + t.Cep + "', " +
			//	"telefone = '" + t.Telefone + "', " +
			//	"celular = '" + t.Celular + "', " +
			//	"email = '" + t.Email + "' " +
			//	"WHERE codigo = '" + t.Codigo + "'";

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

		public void ExcluirTecnico(TecnicoDTO t)
		{
			cmd.CommandText = "DELETE FROM " + tabela + " WHERE codigo = '" + t.Codigo + "'";

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


		public List<TecnicoDTO> SelecionarTecnico(TecnicoDTO t)
		{
			cmd.CommandText = "SELECT " +
				tabela + ".id, " +
				tabela + ".codigo, " +
				tabela + ".dataRegistro, " +
				tabela + ".nome, " +
				tabela + ".dataNasc, " +
				"tb_sexo.sexo, " +
				tabela + ".endereco, " +
				tabela + ".bairro, " +
				"tb_uf.sigla, " +
				"tb_cidade.cidade, " +
				tabela + ".cep, " +
				tabela + ".telefone, " +
				tabela + ".email, " +
				tabela + ".rg, " +
				tabela + ".cpf, " +
				tabela + ".foto, " +
				"tb_tecnico_status.status, " +
				tabela + ".classificacao, " +
				tabela + ".nomeUsual, " +
				"tb_tecnico_funcao.funcao, " +
				tabela + ".assinatura, " +
				tabela + ".pasta, " +
				tabela + ".dataAdmissao " +
				"FROM (((((" + tabela + " " +
				"INNER JOIN tb_sexo ON " + tabela + ".idSexo = tb_sexo.id) " +
				"INNER JOIN tb_cidade ON " + tabela + ".idCidade = tb_cidade.id) " +
				"INNER JOIN tb_uf ON tb_cidade.idUf = tb_uf.id) " +
				"INNER JOIN tb_tecnico_status ON " + tabela + ".idStatus = tb_tecnico_status.id) " +
				"INNER JOIN tb_tecnico_funcao ON " + tabela + ".idFuncao = tb_tecnico_funcao.id) " +
				"WHERE " + tabela + ".codigo = '" + t.Codigo + "'";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<TecnicoDTO> tecnico = new List<TecnicoDTO>(23);

            leitor.Read();

            tecnico.Add(new TecnicoDTO());

            tecnico[0].Id = leitor.GetInt32(0);
            tecnico[0].Codigo = leitor.GetString(1);
            tecnico[0].DataCadastro = leitor.GetDateTime(2);
            tecnico[0].Nome = leitor.GetString(3);
            tecnico[0].DataNascimento = leitor.GetDateTime(4);
            tecnico[0].Sexo = leitor.GetString(5);
            tecnico[0].Endereco = leitor.GetString(6);
            tecnico[0].Bairro = leitor.GetString(7);
            tecnico[0].Uf = leitor.GetString(8);
            tecnico[0].Cidade = leitor.GetString(9);
            tecnico[0].Cep = leitor.GetString(10);
            tecnico[0].Telefone = leitor.GetString(11);
            tecnico[0].Email = leitor.GetString(12);
            tecnico[0].Rg = leitor.GetString(13);
            tecnico[0].Cpf = leitor.GetString(14);
            tecnico[0].Foto = leitor.GetString(15);
            tecnico[0].Status = leitor.GetString(16);
            //tecnico[0].Classificacao = leitor.GetInt32(17);
            tecnico[0].NomeUsual = leitor.GetString(18);
            tecnico[0].Funcao = leitor.GetString(19);
            tecnico[0].Assinatura = leitor.GetString(20);
            tecnico[0].Pasta = leitor.GetString(21);
            tecnico[0].DataAdmissao = leitor.GetDateTime(22);

            conexao.desconectar();
            cmd.Dispose();

            return tecnico;
        }

		public string SelecionarCodigoTecnico(TecnicoDTO t)
        {
			cmd.CommandText = "SELECT codigo FROM " + tabela + " " +
				"WHERE nome = '" + t.Nome + "'";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				t.Codigo = leitor.GetString(0);

				conexao.desconectar();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return t.Codigo;
		}

        public List<TecnicoDTO> PopularComboboxTecnico()
        {
			cmd.CommandText = "SELECT nomeCurto FROM " + tabela;

			cmd.Connection = conexao.conectar();
			OleDbDataReader leitor = cmd.ExecuteReader();
			List<TecnicoDTO> tecnico = new List<TecnicoDTO>();

			while (leitor.Read())
			{
				TecnicoDTO t = new TecnicoDTO();
				t.NomeUsual = leitor.GetString(0);
				tecnico.Add(t);
			}

			conexao.desconectar();
			cmd.Dispose();

			return tecnico;
		}

		public List<TecnicoDTO> ListarTecnico()
		{
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".nome, " +
                tabela + ".dataNasc, " +
                tabela + ".cpf, " +
                tabela + ".telefone, " +
                "tb_tecnico_status.status " +
                "FROM " + tabela + " " +
                "INNER JOIN tb_tecnico_status ON " + tabela + ".idStatus = tb_tecnico_status.id " +
                "ORDER BY " + tabela + ".codigo ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<TecnicoDTO> tecnico = new List<TecnicoDTO>(7);

            while (leitor.Read())
            {
                TecnicoDTO tec = new TecnicoDTO();

                tec.Id = leitor.GetInt32(0);
                tec.Codigo = leitor.GetString(1);
                tec.Nome = leitor.GetString(2);
                tec.DataNascimento = leitor.GetDateTime(3);
                tec.Cpf = leitor.GetString(4);
                tec.Telefone = leitor.GetString(5);
                tec.Status = leitor.GetString(6);

                tecnico.Add(tec);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tecnico;
        }

        public List<TecnicoDTO> ListarTecnicoAtivo()
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".nome, " +
                tabela + ".dataNasc, " +
                tabela + ".cpf, " +
                tabela + ".telefone, " +
                "tb_tecnico_status.status " +
                "FROM " + tabela + " " +
                "INNER JOIN tb_tecnico_status ON " + tabela + ".idStatus = tb_tecnico_status.id " +
				"WHERE " + tabela + ".idStatus = 1 " +
                "ORDER BY " + tabela + ".codigo ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<TecnicoDTO> tecnico = new List<TecnicoDTO>(7);

            while (leitor.Read())
            {
                TecnicoDTO tec = new TecnicoDTO();

                tec.Id = leitor.GetInt32(0);
                tec.Codigo = leitor.GetString(1);
                tec.Nome = leitor.GetString(2);
                tec.DataNascimento = leitor.GetDateTime(3);
                tec.Cpf = leitor.GetString(4);
                tec.Telefone = leitor.GetString(5);
                tec.Status = leitor.GetString(6);

                tecnico.Add(tec);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tecnico;
        }

        public List<TecnicoDTO> ListarTecnicoInativo()
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".nome, " +
                tabela + ".dataNasc, " +
                tabela + ".cpf, " +
                tabela + ".telefone, " +
                "tb_tecnico_status.status " +
                "FROM " + tabela + " " +
                "INNER JOIN tb_tecnico_status ON " + tabela + ".idStatus = tb_tecnico_status.id " +
                "WHERE " + tabela + ".idStatus = 2 " +
                "ORDER BY " + tabela + ".codigo ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<TecnicoDTO> tecnico = new List<TecnicoDTO>(7);

            while (leitor.Read())
            {
                TecnicoDTO tec = new TecnicoDTO();

                tec.Id = leitor.GetInt32(0);
                tec.Codigo = leitor.GetString(1);
                tec.Nome = leitor.GetString(2);
                tec.DataNascimento = leitor.GetDateTime(3);
                tec.Cpf = leitor.GetString(4);
                tec.Telefone = leitor.GetString(5);
                tec.Status = leitor.GetString(6);

                tecnico.Add(tec);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tecnico;
        }

    }
}
