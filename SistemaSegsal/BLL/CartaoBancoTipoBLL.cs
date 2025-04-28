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
    internal class CartaoBancoTipoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();


        public List<CartaoBancoTipoDTO> PopularComboboxCartaoTipo(CartaoBancoTipoDTO t)
        {

            cmd.CommandText = "SELECT tipo FROM tb_cartao";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<CartaoBancoTipoDTO> tipo = new List<CartaoBancoTipoDTO>();

            while (leitor.Read())
            {
                CartaoBancoTipoDTO tp = new CartaoBancoTipoDTO();
                tp.Tipo = leitor.GetString(0);
                tipo.Add(tp);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tipo;
        }

        public Int32 SelecionarIdCartaoTipo(CartaoBancoTipoDTO t)
        {
            cmd.CommandText = "SELECT id FROM tb_cartao_tipo " +
                "WHERE tipo  = '" + t.Tipo + "'";

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

            return t.Id;
        }
    }
}
