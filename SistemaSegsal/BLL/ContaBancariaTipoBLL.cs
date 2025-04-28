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
    internal class ContaBancariaTipoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        public List<ContaBancariaTipoDTO> PopularComboboxTipoContaBancaria()
        {
            cmd.CommandText = "SELECT tipo FROM tb_conta_bancaria";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<ContaBancariaTipoDTO> tipo = new List<ContaBancariaTipoDTO>();

            while (leitor.Read())
            {
                ContaBancariaTipoDTO tc = new ContaBancariaTipoDTO();
                tc.Tipo = leitor.GetString(0);
                tipo.Add(tc);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tipo;
        }

        public Int32 SelecionarIdTipoContaBancaria(ContaBancariaTipoDTO t)
        {
            cmd.CommandText = "SELECT id FROM tb_conta_bancaria " +
                "WHERE tipo = '" + t.Tipo + "'";

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
