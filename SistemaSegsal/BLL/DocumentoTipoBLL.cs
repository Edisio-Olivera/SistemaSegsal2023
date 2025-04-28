using System;
using System.Collections.Generic;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    internal class DocumentoTipoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        string tabela = "tb_documento_tipo";

        public List<DocumentoTipoDTO> PopularComboboxDocumentoTipo()
        {
            cmd.CommandText = "SELECT tipo FROM " + tabela;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<DocumentoTipoDTO> tipo = new List<DocumentoTipoDTO>();

            while (leitor.Read())
            {
                DocumentoTipoDTO tp = new DocumentoTipoDTO();
                tp.Tipo = leitor.GetString(0);
                tipo.Add(tp);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tipo;
        }

        public Int32 SelecionarIdDocumentoTipo(DocumentoTipoDTO dt)
        {
            cmd.CommandText = "SELECT id FROM " + tabela + " " +
                "WHERE tipo = '" + dt.Tipo + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                dt.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return dt.Id;
        }
    }
}
