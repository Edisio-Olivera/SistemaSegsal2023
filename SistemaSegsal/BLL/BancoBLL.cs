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
    internal class BancoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        public List<BancoDTO> PopularComboboxBanco()
        {
            cmd.CommandText = "SELECT nome FROM tb_banco";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<BancoDTO> banco = new List<BancoDTO>();

            while (leitor.Read())
            {
                BancoDTO bc = new BancoDTO();
                bc.Nome = leitor.GetString(0);
                banco.Add(bc);
            }

            conexao.desconectar();
            cmd.Dispose();

            return banco;
        }

        public Int32 SelecionarIdBanco(BancoDTO b)
        {
            cmd.CommandText = "SELECT id FROM tb_banco " +
                "WHERE nome = '" + b.Nome + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                b.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return b.Id;
        }







    }
}
