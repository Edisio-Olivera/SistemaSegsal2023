using System;
using System.Collections.Generic;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    internal class DocumentoStatusBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();        

        string tabela = "tb_documento_status";

        public Int32 SelecionarIdDocumentoStatus(DocumentoStatusDTO ds)
        {
            cmd.CommandText = "SELECT id FROM " + tabela + " " +
                "WHERE status = '" + ds.Status + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                ds.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return ds.Id;
        }
    }
}
