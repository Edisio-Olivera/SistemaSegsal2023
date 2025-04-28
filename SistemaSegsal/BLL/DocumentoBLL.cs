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
    internal class DocumentoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        DocumentoTipoDTO tipDto = new DocumentoTipoDTO();
        DocumentoTipoBLL tipBll = new DocumentoTipoBLL();

        string tabela = "tb_documento";

        public List<DocumentoDTO> PopularComboboxDocumento(DocumentoDTO d)
        {
            tipDto.Tipo = d.Tipo;
            tipBll.SelecionarIdDocumentoTipo(tipDto);

            cmd.CommandText = "SELECT documento FROM " + tabela + " " +
                "WHERE idTipo = " + tipDto.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<DocumentoDTO> documento = new List<DocumentoDTO>();

            while (leitor.Read())
            {
                DocumentoDTO doc = new DocumentoDTO();
                doc.Documento = leitor.GetString(0);
                documento.Add(doc);
            }

            conexao.desconectar();
            cmd.Dispose();

            return documento;
        }

        public Int32 SelecionarIdDocumento(DocumentoDTO d)
        {
            cmd.CommandText = "SELECT id FROM " + tabela + " " +
                "WHERE documento = '" + d.Documento + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                d.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return d.Id;
        }

        public List<DocumentoDTO> SelecionarDocumento(DocumentoDTO d)
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                "tb_documento_tipo.tipo, " +
                tabela + ".documento, " +
                tabela + ".tempoValidade " +
                "FROM " + tabela + " " +
                "INNER JOIN tb_documento_tipo ON " + tabela + ".idTipo = tb_documento_tipo.id " +
                "WHERE " + tabela + ".documento = '" + d.Documento + "'";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<DocumentoDTO> documento = new List<DocumentoDTO>(4);

            leitor.Read();

            documento.Add(new DocumentoDTO());

            documento[0].Id = leitor.GetInt32(0);
            documento[0].Tipo = leitor.GetString(1);
            documento[0].Documento = leitor.GetString(2);
            documento[0].Validade = leitor.GetInt32(3);

            conexao.desconectar();
            cmd.Dispose();

            return documento;
        }




    }
}
