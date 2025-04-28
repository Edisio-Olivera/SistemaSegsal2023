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
    class FornecedorBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

		Int32 qtdIdFornecedor;
		


		public void CriarNovoFornecedor(FornecedorDTO f)
		{
			this.ContarFornecedor();

			if (qtdIdFornecedor == 0)
			{
				f.Id = 1;
			}
			else
			{
				cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_fornecedores";

				try
				{
					cmd.Connection = conexao.conectar();
					OleDbDataReader leitor = cmd.ExecuteReader();

					leitor.Read();
					f.Id = leitor.GetInt32(0);

					conexao.desconectar();

				}
				catch (OleDbException ex)
				{
					MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public Int32 ContarFornecedor()
		{
			cmd.CommandText = "SELECT COUNT(id) FROM tb_fornecedores";

			try
			{
				cmd.Connection = conexao.conectar();
				OleDbDataReader leitor = cmd.ExecuteReader();

				leitor.Read();
				qtdIdFornecedor = leitor.GetInt32(0);

				conexao.desconectar();
				cmd.Dispose();
			}
			catch (OleDbException ex)
			{
				MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			return qtdIdFornecedor;
		}

		public void SalvarFornecedor(FornecedorDTO f)
		{
			//cliDto.NomeFantasia = bc.Cliente;
			//cliBll.SelecionarCodigoCliente(cliDto);

			//cidDto.Cidade = bc.Cidade;
			//cidBll.SelecionarIdCidade(cidDto);

			//staDto.Status = bc.Status;
			//staBll.SelecionarIdStatus(staDto);

			//cmd.CommandText = "INSERT INTO tb_fornecedores (" +
			//	"id, " +
			//	"codigo, " +
			//	"dataRegistro, " +
			//	"codCliente, " +
			//	"nomeBase, " +
			//	"endereco, " +
			//	"complemento, " +
			//	"bairro, " +
			//	"idCidade, " +
			//	"cep, " +
			//	"cnpj, " +
			//	"ie, " +
			//	"idStatus) " +
			//	"VALUES (" +
				//bc.Id + ", '" +
				//bc.Codigo + "', '" +
				//bc.DataRegistro + "', '" +
				//cliDto.Codigo + "', '" +
				//bc.NomeBase + "', '" +
				//bc.Endereco + "', '" +
				//bc.Complemento + "', '" +
				//bc.Bairro + "', " +
				//cidDto.Id + ", '" +
				//bc.Cep + "', '" +
				//bc.Cnpj + "', '" +
				//bc.InscEstadual + "', " +
				//staDto.Id + ")";

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

        public string SelecionarCodigoFornecedor(FornecedorDTO f)
        {
            cmd.CommandText = "SELECT codigo FROM tb_fornecedor " +
                "WHERE nomeFantasia = '" + f.NomeFantasia + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                f.Codigo = leitor.GetString(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return f.Codigo;
        }

        public List<FornecedorDTO> PopularComboboxFornecedor()
        {
            cmd.CommandText = "SELECT nomeFantasia FROM tb_fornecedor " +
				"ORDER BY nomeFantasia ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<FornecedorDTO> fornecedor = new List<FornecedorDTO>();

            while (leitor.Read())
            {
                FornecedorDTO forn = new FornecedorDTO();
                forn.NomeFantasia = leitor.GetString(0);
                fornecedor.Add(forn);
            }

            conexao.desconectar();
            cmd.Dispose();

            return fornecedor;
        }


    }
}
