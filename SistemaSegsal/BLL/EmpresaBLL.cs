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
    class EmpresaBLL
    {
		Conexao conexao = new Conexao();
		MySqlCommand cmd = new MySqlCommand();

        CidadeDTO cidDto = new CidadeDTO();
        CidadeBLL cidBll = new CidadeBLL();

		public void EditarEmpresa(EmpresaDTO e)
		{
            cidDto.Cidade = e.Cidade;
            cidBll.SelecionarIdCidade(cidDto);

            cmd.CommandText = "UPDATE tb_empresa SET " +
                "razaoSocial = '" + e.RazaoSocial + "', " +
                "nomeFantasia = '" + e.NomeFantasia + "', " +
                "porte = '" + e.Porte + "', " +
                "dataAbertura = '" + e.DataAbertura + "', " +
                "cnpj = '" + e.Cnpj + "', " +
                "inscricaoEstadual = '" + e.InscricaoEstadual + "', " +
                "naturezaJuridica = '" + e.NaturezaJuridica + "', " +
                "endereco = '" + e.Endereco + "', " +
                "complemento = '" + e.Complemento + "', " +
                "bairro = '" + e.Bairro + "', " +
                "idCidade = " + cidDto.Id + ", " +
                "cep = '" + e.Cep + "', " +
                "email = '" + e.Email + "', " +
                "senhaEmail = '" + e.Senha + "', " +
                "telefone = '" + e.Telefone + "', " +
                "celular = '" + e.Celular + "', " +
                "atividadePrincipal = '" + e.AtividadePrincipal + "', " +
                "site = '" + e.Site + "', " +
                "instagram = '" + e.Instagram + "', " +
                "facebook = '" + e.Facebook + "', " +
                "youtube = '" + e.Youtube + "' " +
                "WHERE id = 1";

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados! - " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarLogomarcaEmpresa(EmpresaDTO e)
        {
            cmd.CommandText = "UPDATE tb_empresa SET " +
                "logomarca = '" + e.Logo + "', " +                
                "WHERE id = 1";

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados! - " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarLogomarcaImpressaoEmpresa(EmpresaDTO e)
        {
            cmd.CommandText = "UPDATE tb_empresa SET " +
                "logoImpressao = '" + e.LogoImpressao + "', " +
                "WHERE id = 1";

            try
            {
                cmd.Connection = conexao.conectar();

                cmd.ExecuteNonQuery();
                conexao.desconectar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados! - " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<EmpresaDTO> SelecionarEmpresa()
		{
            cmd.CommandText = "SELECT " +
                "e.id, " +
                "e.razaoSocial, " +
                "e.nomeFantasia, " +
                "e.porte, " +
                "e.dataAbertura, " +
                "e.cnpj, " +
                "e.inscricaoEstadual, " +
                "e.naturezaJuridica, " +
                "e.endereco, " +
                "e.complemento, " +
                "e.bairro, " +
                "c.cidade, " +
                "u.sigla, " +
                "e.cep, " +
                "e.email, " +
                "e.senhaEmail, " +
                "e.telefone, " +
                "e.celular, " +
                "a.atividade, " +
                "e.site, " +
                "e.instagram, " +
                "e.facebook, " +
                "e.youtube, " +
                "e.logo, " +
                "e.logoImpressao " +
                "FROM tb_empresa e " +
                "INNER JOIN tb_cidade c ON e.idCidade = c.id " +
                "INNER JOIN tb_uf u ON c.idUf = u.id " +
                "INNER JOIN tb_atividade a ON e.idAtividadePrincipal = a.id " +
                "WHERE e.id = 1";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();
            List<EmpresaDTO> empresa = new List<EmpresaDTO>();

            leitor.Read();
            
            empresa.Add(new EmpresaDTO());

            empresa[0].Id = leitor.GetInt32(0);
            empresa[0].RazaoSocial = leitor.GetString(1);
            empresa[0].NomeFantasia = leitor.GetString(2);
            empresa[0].Porte = leitor.GetString(3);
            DateTime dataAbertura = DateTime.Parse(leitor.GetString(4));
            empresa[0].DataAbertura = dataAbertura.ToString("dd/MM/yyyy");
            empresa[0].Cnpj = leitor.GetString(5);
            empresa[0].InscricaoEstadual = leitor.GetString(6);
            empresa[0].NaturezaJuridica = leitor.GetString(7);
            empresa[0].Endereco = leitor.GetString(8);
            empresa[0].Complemento = leitor.GetString(9);
            empresa[0].Bairro = leitor.GetString(10);
            empresa[0].Cidade = leitor.GetString(11);
            empresa[0].Uf = leitor.GetString(12);
            empresa[0].Cep = leitor.GetString(13);
            empresa[0].Email = leitor.GetString(14);
            empresa[0].Senha = leitor.GetString(15);
            empresa[0].Telefone = leitor.GetString(16);
            empresa[0].Celular = leitor.GetString(17);
            empresa[0].AtividadePrincipal = leitor.GetString(18);
            empresa[0].Site = leitor.GetString(19);
            empresa[0].Instagram = leitor.GetString(20);
            empresa[0].Facebook = leitor.GetString(21);
            empresa[0].Youtube = leitor.GetString(22);
            empresa[0].Logo = leitor.GetString(23);
            empresa[0].LogoImpressao = leitor.GetString(24);

            conexao.desconectar();
            cmd.Dispose();

            return empresa;
        }
	}
}
