using System;
using System.Collections.Generic;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    internal class TecnicoDocumentoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        DocumentoDTO docDto = new DocumentoDTO();
        DocumentoBLL docBll = new DocumentoBLL();

        DocumentoStatusDTO staDto = new DocumentoStatusDTO();
        DocumentoStatusBLL staBll = new DocumentoStatusBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();

        Int32 qtdIdDocumentoTecnico;

        string tabela = "tb_tecnico_documento";

        public void CriarNovoDocumentoTecnico(TecnicoDocumentoDTO dt)
        {
            this.ContarIdDocumentoTecnico();

            if (qtdIdDocumentoTecnico == 0)
            {
                dt.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM " + tabela;

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    dt.Id = leitor.GetInt32(0) + 1;

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarIdDocumentoTecnico()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM " + tabela;

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdDocumentoTecnico = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdDocumentoTecnico;
        }

        public void SalvarDocumentoTecnico(TecnicoDocumentoDTO dt)
        {
            tecDto.Nome = dt.Tecnico;
            tecBll.SelecionarCodigoTecnico(tecDto);

            docDto.Documento = dt.Documento;
            docBll.SelecionarIdDocumento(docDto);

            staDto.Status = dt.Status;
            staBll.SelecionarIdDocumentoStatus(staDto);

            cmd.CommandText = "INSERT INTO " + tabela + " (" +
                "id, " +
                "codTecnico, " +
                "idDocumento, " +
                "dataRealizado, " +
                "dataVencimento, " +
                "observacao, " +
                "idStatus) " +
                "VALUES (" +
                dt.Id + ", '" +
                tecDto.Codigo + "', " +
                docDto.Id + ", '" +
                dt.DataRealizado + "', '" +
                dt.DataVencimento + "', '" +
                dt.Observacao + "', " +
                staDto.Id + ")";

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarDocumentoTecnico(TecnicoDocumentoDTO dt)
        {
            docDto.Documento = dt.Documento;
            docBll.SelecionarIdDocumento(docDto);

            cmd.CommandText = "UPDATE " + tabela + " SET " +
                "idDocumento = " + docDto.Id + ", " +
                "dataRealizado = '" + dt.DataRealizado + "', " +
                "dataVencimento = '" + dt.DataVencimento + "', " +
                "observacao = '" + dt.Observacao + "' " +                
                "WHERE id = " + dt.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirDocumentoTecnico(TecnicoDocumentoDTO dt)
        {
            cmd.CommandText = "DELETE FROM " + tabela + " WHERE id = " + dt.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<TecnicoDocumentoDTO> SelecionarDocumentoTecnico(TecnicoDocumentoDTO dt)
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                "tb_tecnico.nome, " +
                "tb_documento_tipo.tipo, " +
                "tb_documento.documento, " +
                tabela + ".dataRealizado, " +
                tabela + ".dataVencimento, " +
                tabela + ".observacao, " +
                "tb_documento_status.status " +
                "FROM ((((" + tabela + " " +
                "INNER JOIN tb_tecnico ON " + tabela + ".codTecnico = tb_tecnico.codigo) " +
                "INNER JOIN tb_documento ON " + tabela + ".idDocumento = tb_documento.id) " +
                "INNER JOIN tb_documento_tipo ON tb_documento.idTipo = tb_documento_tipo.id) " +
                "INNER JOIN tb_documento_status ON " + tabela + ".idStatus = tb_documento_status.id) " +
                "WHERE " + tabela + ".id = " + dt.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<TecnicoDocumentoDTO> tecDoc = new List<TecnicoDocumentoDTO>(8);

            leitor.Read();

            tecDoc.Add(new TecnicoDocumentoDTO());

            tecDoc[0].Id = leitor.GetInt32(0);
            tecDoc[0].Tecnico = leitor.GetString(1);
            tecDoc[0].Tipo = leitor.GetString(2);
            tecDoc[0].Documento = leitor.GetString(3);
            tecDoc[0].DataRealizado = leitor.GetDateTime(4);
            tecDoc[0].DataVencimento = leitor.GetDateTime(5);
            tecDoc[0].Observacao = leitor.GetString(6);
            tecDoc[0].Status = leitor.GetString(7);

            conexao.desconectar();
            cmd.Dispose();

            return tecDoc;
        }
                
        public List<TecnicoDocumentoDTO> ListarDocumentoTecnico(TecnicoDocumentoDTO dt)
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                "tb_tecnico.nome, " +
                "tb_documento_tipo.tipo, " +
                "tb_documento.documento, " +
                tabela + ".dataRealizado, " +
                tabela + ".dataVencimento, " +
                tabela + ".observacao, " +
                "tb_documento_status.status " +
                "FROM ((((" + tabela + " " +
                "INNER JOIN tb_tecnico ON " + tabela + ".codTecnico = tb_tecnico.codigo) " +
                "INNER JOIN tb_documento ON " + tabela + ".idDocumento = tb_documento.id) " +
                "INNER JOIN tb_documento_tipo ON tb_documento.idTipo = tb_documento_tipo.id) " +
                "INNER JOIN tb_documento_status ON " + tabela + ".idStatus = tb_documento_status.id) " +
                "WHERE " + tabela + ".codTecnico = '" + dt.Tecnico + "' " +
                "ORDER BY " + tabela + ".id ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<TecnicoDocumentoDTO> tecnico = new List<TecnicoDocumentoDTO>(8);

            while (leitor.Read())
            {
                TecnicoDocumentoDTO tec = new TecnicoDocumentoDTO();

                tec.Id = leitor.GetInt32(0);
                tec.Tecnico = leitor.GetString(1);
                tec.Tipo = leitor.GetString(2);
                tec.Documento = leitor.GetString(3);
                tec.DataRealizado = leitor.GetDateTime(4);
                tec.DataVencimento = leitor.GetDateTime(5);
                tec.Observacao = leitor.GetString(6);
                tec.Status = leitor.GetString(7);

                tecnico.Add(tec);
            }

            conexao.desconectar();
            cmd.Dispose();

            return tecnico;
        }        
    }
}
