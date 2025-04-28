using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Data.OleDb;
using System.Windows.Forms;

namespace SistemaSegsal.BLL
{
    class AtividadePrincipalBLL
    {
		Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

		public List<AtividadePrincipalDTO> PopularComboboxAtividade()
		{
            cmd.CommandText = "SELECT atividade FROM tb_atividade";

            
            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<AtividadePrincipalDTO> atividade = new List<AtividadePrincipalDTO>();

            while (leitor.Read())
            {
                AtividadePrincipalDTO atv = new AtividadePrincipalDTO();
                atv.Atividade = leitor.GetString(0);
                atividade.Add(atv);
            }           

            conexao.desconectar();
            cmd.Dispose();                 
            return atividade;
        }

		public Int32 SelecionarIdAtividade(AtividadePrincipalDTO a)
		{
            cmd.CommandText = "SELECT id FROM tb_atividades " +
                "WHERE atividade = '" + a.Atividade + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();

                a.Id = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();

            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Não foi possível se conectar ao banco de dados! - " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return a.Id;
        }
	}
}
