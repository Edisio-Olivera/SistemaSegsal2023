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
    internal class CartaoBancoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        CartaoBancoTipoDTO tipDto = new CartaoBancoTipoDTO();
        CartaoBancoTipoBLL tipBll = new CartaoBancoTipoBLL();





        public List<CartaoBancoDTO> SelecionarCartaoBanco(CartaoBancoDTO c)
        {
            cmd.CommandText = "SELECT " +
                "tb_cartao.id, " +
                "tb_cartao.dataRegistro, " +
                "tb_cartao_tipo.tipo, " +
                "tb_banco.nome, " +
                "tb_cartao.apelido, " +
                "tb_cartao.numero, " +
                "tb_cartao_bandeira.bandeira, " +
                "tb_cartao.diaVencimento, " +
                "tb_cartao.melhorDia, " +
                "tb_cartao.limite, " +
                "tb_cartao.limiteUtilizado, " +
                "tb_cartao.limiteDisponivel, " +
                "tb_cartao.imagem " +
                "FROM (((tb_cartao " +
                "INNER JOIN tb_cartao_tipo ON tb_cartao.idTipoCartao = tb_cartao_tipo.id) " +
                "INNER JOIN tb_banco ON tb_cartao.idBanco = tb_banco.id) " +
                "INNER JOIN tb_cartao_bandeira ON tb_cartao.idBandeiraCartao = tb_cartao_bandeira.id) " +
                "WHERE tb_cartao.apelido = '" + c.Apelido + "'";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<CartaoBancoDTO> cartao = new List<CartaoBancoDTO>(13);

            leitor.Read();

            cartao.Add(new CartaoBancoDTO());

            cartao[0].Id = leitor.GetInt32(0);
            cartao[0].DataRegistro = leitor.GetDateTime(1);
            cartao[0].TipoCartao = leitor.GetString(2);
            cartao[0].Banco = leitor.GetString(3);
            cartao[0].Apelido = leitor.GetString(4);
            cartao[0].Numero = leitor.GetString(5);
            cartao[0].Bandeira = leitor.GetString(6);
            cartao[0].DiaVencimento = leitor.GetInt32(7);
            cartao[0].MelhorDia = leitor.GetInt32(8);
            cartao[0].Limite = leitor.GetInt32(9);
            cartao[0].LimiteUtilizado = leitor.GetInt32(10);
            cartao[0].LimiteDisponivel = leitor.GetInt32(11);
            cartao[0].Imagem = leitor.GetString(12);

            conexao.desconectar();
            cmd.Dispose();

            return cartao;
        }

        public List<CartaoBancoDTO> PopularComboboxCartaoTipo(CartaoBancoDTO c)
        {
            tipDto.Tipo = c.TipoCartao;
            tipBll.SelecionarIdCartaoTipo(tipDto);

            cmd.CommandText = "SELECT apelido FROM tb_cartao " +
                "WHERE idTipoCartao = " + tipDto.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<CartaoBancoDTO> cartao = new List<CartaoBancoDTO>();

            while (leitor.Read())
            {
                CartaoBancoDTO crt = new CartaoBancoDTO();
                crt.Apelido = leitor.GetString(0);
                cartao.Add(crt);
            }

            conexao.desconectar();
            cmd.Dispose();

            return cartao;
        }

        public Int32 SelecionarIdCartao(CartaoBancoDTO c)
        {
            cmd.CommandText = "SELECT id FROM tb_cartao " +
                "WHERE apelido = '" + c.Apelido + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                c.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return c.Id;
        }
    }
}
