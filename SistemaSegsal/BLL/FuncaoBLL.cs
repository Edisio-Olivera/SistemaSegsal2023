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
    internal class FuncaoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        string tabela = "tb_tecnico_funcao";

        public List<FuncaoDTO> PopularComboboxFuncao()
        {
            cmd.CommandText = "SELECT funcao FROM " + tabela;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<FuncaoDTO> funcao = new List<FuncaoDTO>();

            while (leitor.Read())
            {
                FuncaoDTO fc = new FuncaoDTO();
                fc.Funcao = leitor.GetString(0);
                funcao.Add(fc);
            }

            conexao.desconectar();
            cmd.Dispose();

            return funcao;
        }

        public Int32 SelecionarIdFuncao(FuncaoDTO f)
        {
            cmd.CommandText = "SELECT id FROM " + tabela + " " +
                "WHERE funcao = '" + f.Funcao + "'";

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

            return f.Id;
        }
    }
}
