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
    class EmpresaBLL
    {
		Conexao conexao = new Conexao();
		OleDbCommand cmd = new OleDbCommand();

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
            catch (OleDbException ex)
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
            catch (OleDbException ex)
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
            catch (OleDbException ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados! - " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<EmpresaDTO> SelecionarEmpresa()
		{
            cmd.CommandText = "SELECT " +
                "tb_empresa.id, " +
                "tb_empresa.razaoSocial, " +
                "tb_empresa.nomeFantasia, " +
                "tb_empresa.porte, " +
                "tb_empresa.dataAbertura, " +
                "tb_empresa.cnpj, " +
                "tb_empresa.inscricaoEstadual, " +
                "tb_empresa.naturezaJuridica, " +
                "tb_empresa.endereco, " +
                "tb_empresa.complemento, " +
                "tb_empresa.bairro, " +
                "tb_cidade.cidade, " +
                "tb_uf.sigla, " +
                "tb_empresa.cep, " +
                "tb_empresa.email, " +
                "tb_empresa.senhaEmail, " +
                "tb_empresa.telefone, " +
                "tb_empresa.celular, " +
                "tb_empresa.atividade, " +
                "tb_empresa.site, " +
                "tb_empresa.instagram, " +
                "tb_empresa.facebook, " +
                "tb_empresa.youtube, " +
                "tb_empresa.logo, " +
                "tb_empresa.logoImpressao " +
                "FROM ((tb_empresa " +
                "INNER JOIN tb_cidade ON tb_empresa.idCidade = tb_cidade.id) " +
                "INNER JOIN tb_uf ON tb_cidade.idUf = tb_uf.id) " +
                "WHERE tb_empresa.id = 1";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<EmpresaDTO> empresa = new List<EmpresaDTO>();

            leitor.Read();
            
            empresa.Add(new EmpresaDTO());

            empresa[0].Id = leitor.GetInt32(0);
            empresa[0].RazaoSocial = leitor.GetString(1);
            empresa[0].NomeFantasia = leitor.GetString(2);
            empresa[0].Porte = leitor.GetString(3);
            empresa[0].DataAbertura = leitor.GetDateTime(4);
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
