using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;
using iText.StyledXmlParser.Jsoup.Select;
using System.Reflection;

namespace SistemaSegsal.BLL
{
    class ChamadoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        ClienteContatoDTO cntDto = new ClienteContatoDTO();
        ClienteContatoBLL cntBll = new ClienteContatoBLL();

        ChamadoAssuntoDTO assDto = new ChamadoAssuntoDTO();
        ChamadoAssuntoBLL assBll = new ChamadoAssuntoBLL();

        ChamadoSituacaoDTO sitDto = new ChamadoSituacaoDTO();
        ChamadoSituacaoBLL sitBll = new ChamadoSituacaoBLL();

        ChamadoUrgenciaDTO urgDto = new ChamadoUrgenciaDTO();
        ChamadoUrgenciaBLL urgBll = new ChamadoUrgenciaBLL();

        ChamadoStatusDTO staDto = new ChamadoStatusDTO();
        ChamadoStatusBLL staBll = new ChamadoStatusBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();

        Int32 qtdIdChamado;
        Int32 qtdIdChamadoStatus;

        string tabela = "tb_chamado";

        public void CriarNovoChamado(ChamadoDTO c)
        {
            this.ContarIdChamado();

            if (qtdIdChamado == 0)
            {
                c.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM " + tabela;

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    c.Id = leitor.GetInt32(0) + 1;

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarIdChamado()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_chamado";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdChamado = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdChamado;
        }

        public void SalvarChamado(ChamadoDTO c)
        {
            basDto.Cliente = c.Cliente;
            basDto.NomeBase = c.BaseCliente;
            basBll.SelecionarCodigoBaseCliente(basDto);

            cntDto.Nome = c.ContatoCliente;
            cntBll.SelecionarIdContatoCliente(cntDto);

            assDto.Assunto = c.Assunto;
            assBll.SelecionarIdAssunto(assDto);

            sitDto.Situacao = c.Situacao;
            sitBll.SelecionarIdSituacao(sitDto);

            urgDto.Urgencia = c.Urgencia;
            urgBll.SelecionarIdUrgencia(urgDto);

            staDto.Status = c.Status;
            staBll.SelecionarIdChamadoStatus(staDto);

            cmd.CommandText = "INSERT INTO " + tabela + " (" +
                "id, " +
                "codigo, " +
                "dataChamado, " +
                "codBaseCliente, " +
                "localSetor, " +
                "equipamento, " +
                "idContato, " +                
                "idAssunto, " +
                "idSituacao, " +
                "idUrgencia, " +
                "informacaoCliente, " +
                "diagnostico, " +
                "valorTotal, " +
                "idStatus) " +
                "VALUES (" +
                c.Id + ", '" +
                c.Codigo + "', '" +
                c.DataChamado + "', '" +
                basDto.Codigo + "', '" +
                c.LocalSetor + "', '" +
                c.Equipamento + "', " +
                cntDto.Id + ", " +
                assDto.Id + ", " +
                sitDto.Id + ", " +
                urgDto.Id + ", '" +
                c.InformacaoCliente + "', '" +
                c.Diagnostico + "', " +
                c.ValorTotal + ", " +
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

        public void FinalizarChamado(ChamadoDTO c)
        {
            staDto.Status = c.Status;
            staBll.SelecionarIdChamadoStatus(staDto);

            cmd.CommandText = "UPDATE tb_chamado SET " +
                "dataFinal = '" + c.DataFinal + "', " +
                "idStatusChamado = " + staDto.Id + " " +
                "WHERE codigo = '" + c.Codigo + "'";

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

        public void EditarChamado(ChamadoDTO c)
        {
            basDto.NomeBase = c.BaseCliente;
            basBll.SelecionarCodigoBaseCliente(basDto);

            cntDto.Nome = c.ContatoCliente;
            cntBll.SelecionarIdContatoCliente(cntDto);

            assDto.Assunto = c.Assunto;
            assBll.SelecionarIdAssunto(assDto);

            urgDto.Urgencia = c.Urgencia;
            urgBll.SelecionarIdUrgencia(urgDto);

            staDto.Status = c.Status;
            staBll.SelecionarIdChamadoStatus(staDto);

            cmd.CommandText = "UPDATE tb_chamado SET " +
                "dataChamado = '" + c.DataChamado + "', " +
                "codBase = '" + basDto.Codigo + "', " +
                "idContato = " + cntDto.Id + ", " +
                "idAssunto = " + assDto.Id + ", " +
                "idUrgencia = " + urgDto.Id + ", " +
                "informacaoCliente = '" + c.InformacaoCliente + "', " +
                "diagnostico = '" + c.Diagnostico + "', " +
                "solucao = '" + c.Solucao + "' " +
                "WHERE codigo = '" + c.Codigo + "'";

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

        public void DeletarChamado(ChamadoDTO c)
        {
            cmd.CommandText = "DELETE FROM tb_chamado WHERE codigo = '" + c.Codigo + "'";

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

        public List<ChamadoDTO> ListarChamado()
        {
            //cmd.CommandText = "SELECT " +
            //    tabela + ".id, " +
            //    tabela + ".codigo, " +
            //    tabela + ".dataChamado, " +
            //    "tb_cliente_contato.nome, " +
            //    "tb_cliente.nomeFantasia, " +
            //    "tb_cliente_base.nomeBase, " +
            //    tabela + ".localSetor, " +
            //    tabela + ".equipamento, " +
            //    tabela + ".informacaoCliente, " +
            //    tabela + ".diagnostico, " +
            //    "tb_chamado_assunto.assunto, " +
            //    "tb_chamado_urgencia.urgencia, " +
            //    "tb_chamado_situacao.situacao, " +
            //    "tb_tecnico.nomeUsual, " +
            //    tabela + ".dataFechamento, " +
            //    tabela + ".valorTotal, " +
            //    "tb_chamado_status.status " +
            //    "FROM((((((((" + tabela + " " +
            //    "INNER JOIN tb_cliente_contato ON " + tabela + ".idContato = tb_cliente_contato.id) " +
            //    "INNER JOIN tb_cliente_base ON " + tabela + ".codBaseCliente = tb_cliente_base.codigo) " +
            //    "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
            //    "INNER JOIN tb_chamado_assunto ON " + tabela + ".idAssunto = tb_chamado_assunto.id) " +
            //    "INNER JOIN tb_chamado_urgencia ON " + tabela + ".idUrgencia = tb_chamado_urgencia.id) " +
            //    "INNER JOIN tb_chamado_situacao ON " + tabela + ".idSituacao = tb_chamado_situacao.id) " +
            //    "INNER JOIN tb_tecnico ON " + tabela + ".codTecnico = tb_tecnico.codigo) " +
            //    "INNER JOIN tb_chamado_status ON " + tabela + ".idStatus = tb_chamado_status.id) " +
            //    "ORDER BY " + tabela + ".codigo DESC";

            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".dataChamado, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                tabela + ".equipamento, " +
                "tb_chamado_assunto.assunto, " +
                "tb_chamado_urgencia.urgencia, " +
                "tb_chamado_situacao.situacao, " +
                tabela + ".valorTotal, " +
                "tb_chamado_status.status " +
                "FROM ((((((" + tabela + " " +
                "INNER JOIN tb_cliente_base ON " + tabela + ".codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_chamado_assunto ON " + tabela + ".idAssunto = tb_chamado_assunto.id) " +
                "INNER JOIN tb_chamado_urgencia ON " + tabela + ".idUrgencia = tb_chamado_urgencia.id) " +
                "INNER JOIN tb_chamado_situacao ON " + tabela + ".idSituacao = tb_chamado_situacao.id) " +
                "INNER JOIN tb_chamado_status ON " + tabela + ".idStatus = tb_chamado_status.id) " +
                "ORDER BY " + tabela + ".codigo DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoDTO> chamado = new List<ChamadoDTO>(11);

            while (leitor.Read())
            {
                ChamadoDTO chm = new ChamadoDTO();

                chm.Id = leitor.GetInt32(0);
                chm.Codigo = leitor.GetString(1);
                chm.DataChamado = leitor.GetDateTime(2);
                chm.Cliente = leitor.GetString(3);
                chm.BaseCliente = leitor.GetString(4);
                chm.Equipamento = leitor.GetString(5);
                chm.Assunto = leitor.GetString(6);
                chm.Urgencia = leitor.GetString(7);
                chm.Situacao = leitor.GetString(8);

                if (leitor.GetInt32(9) == 0)
                {
                    chm.ValorTotal = 0;
                }
                else
                {
                    chm.ValorTotal = leitor.GetInt32(9) / 100;
                }

                chm.Status = leitor.GetString(10);

                chamado.Add(chm);
            }

            conexao.desconectar();
            cmd.Dispose();

            return chamado;
        }

        public List<ChamadoDTO> ListarChamadoStatus(ChamadoDTO c)
        {
            staDto.Status = c.Status;
            staBll.SelecionarIdChamadoStatus(staDto);

            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".dataChamado, " +
                "tb_cliente_contato.nome, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                tabela + ".localSetor, " +
                tabela + ".equipamento, " +
                tabela + ".informacaoCliente, " +
                tabela + ".diagnostico, " +
                "tb_chamado_assunto.assunto, " +
                "tb_chamado_urgencia.urgencia, " +
                "tb_chamado_situacao.situacao, " +
                "tb_tecnico.nomeUsual, " +
                tabela + ".dataFechamento, " +
                tabela + ".valorTotal, " +
                "tb_chamado_status.status " +
                "FROM ((((((((tb_chamado " +
                "INNER JOIN tb_cliente_contato ON " + tabela + ".idContato = tb_cliente_contato.id) " +
                "INNER JOIN tb_cliente_base ON " + tabela + ".codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_chamado_assunto ON " + tabela + ".idAssunto = tb_chamado_assunto.id) " +
                "INNER JOIN tb_chamado_urgencia ON " + tabela + ".idUrgencia = tb_chamado_urgencia.id) " +
                "INNER JOIN tb_chamado_situacao ON " + tabela + ".idSituacao = tb_chamado_situacao.id) " +
                "INNER JOIN tb_tecnico ON " + tabela + ".codTecnico = tb_tecnico.codigo) " +
                "INNER JOIN tb_chamado_status ON " + tabela + ".idStatus = tb_chamado_status.id) " +
                "WHERE " + tabela + ".idStatus = " + staDto.Id + " " +
                "ORDER BY " + tabela + ".codigo DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoDTO> chamado = new List<ChamadoDTO>(17);

            while (leitor.Read())
            {
                ChamadoDTO chm = new ChamadoDTO();

                chm.Id = leitor.GetInt32(0);
                chm.Codigo = leitor.GetString(1);
                chm.DataChamado = leitor.GetDateTime(2);
                chm.ContatoCliente = leitor.GetString(3);
                chm.Cliente = leitor.GetString(4);
                chm.BaseCliente = leitor.GetString(5);
                chm.LocalSetor = leitor.GetString(6);
                chm.Equipamento = leitor.GetString(7);
                chm.InformacaoCliente = leitor.GetString(8);
                chm.Diagnostico = leitor.GetString(9);
                chm.Assunto = leitor.GetString(10);
                chm.Urgencia = leitor.GetString(11);
                chm.Situacao = leitor.GetString(12);
                chm.Tecnico = leitor.GetString(13);
                chm.DataFinal = leitor.GetDateTime(14);                
                
                if(leitor.GetInt32(15) == 0)
                {
                    chm.ValorTotal = 0;
                }
                else
                {
                    chm.ValorTotal = leitor.GetInt32(15) / 100;
                }
                
                chm.Status = leitor.GetString(16);

                chamado.Add(chm);
            }

            conexao.desconectar();
            cmd.Dispose();

            return chamado;
        }

        public List<ChamadoDTO> SelecionarChamado (ChamadoDTO c)
        {
            cmd.CommandText = "SELECT " +
                tabela + ".id, " +
                tabela + ".codigo, " +
                tabela + ".dataChamado, " +
                "tb_cliente_contato.nome, " +
                "tb_cliente.nomeFantasia, " +
                "tb_cliente_base.nomeBase, " +
                tabela + ".localSetor, " +
                tabela + ".equipamento, " +
                tabela + ".informacaoCliente, " +
                tabela + ".diagnostico, " +
                "tb_chamado_assunto.assunto, " +
                "tb_chamado_urgencia.urgencia, " +
                "tb_chamado_situacao.situacao, " +
                "tb_tecnico.nomeUsual, " +
                tabela + ".dataFechamento, " +
                tabela + ".valorTotal, " +
                "tb_chamado_status.status " +
                "FROM ((((((((tb_chamado " +
                "INNER JOIN tb_cliente_contato ON " + tabela + ".idContato = tb_cliente_contato.id) " +
                "INNER JOIN tb_cliente_base ON " + tabela + ".codBaseCliente = tb_cliente_base.codigo) " +
                "INNER JOIN tb_cliente ON tb_cliente_base.codCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_chamado_assunto ON " + tabela + ".idAssunto = tb_chamado_assunto.id) " +
                "INNER JOIN tb_chamado_urgencia ON " + tabela + ".idUrgencia = tb_chamado_urgencia.id) " +
                "INNER JOIN tb_chamado_situacao ON " + tabela + ".idSituacao = tb_chamado_situacao.id) " +
                "INNER JOIN tb_tecnico ON " + tabela + ".codTecnico = tb_tecnico.codigo) " +
                "INNER JOIN tb_chamado_status ON " + tabela + ".idStatus = tb_chamado_status.id) " +
                "WHERE " + tabela + ".codigo = '" + c.Codigo + "'";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoDTO> chamado = new List<ChamadoDTO>(17);

            leitor.Read();

            chamado.Add(new ChamadoDTO());

            chamado[0].Id = leitor.GetInt32(0);
            chamado[0].Codigo = leitor.GetString(1);
            chamado[0].DataChamado = leitor.GetDateTime(2);
            chamado[0].ContatoCliente = leitor.GetString(3);
            chamado[0].Cliente = leitor.GetString(4);
            chamado[0].BaseCliente = leitor.GetString(5);
            chamado[0].LocalSetor = leitor.GetString(6);
            chamado[0].Equipamento = leitor.GetString(7);
            chamado[0].InformacaoCliente = leitor.GetString(8);
            chamado[0].Diagnostico = leitor.GetString(9);
            chamado[0].Assunto = leitor.GetString(10);
            chamado[0].Urgencia = leitor.GetString(11);
            chamado[0].Situacao = leitor.GetString(12);
            chamado[0].Tecnico = leitor.GetString(13);
            chamado[0].DataFinal = leitor.GetDateTime(14);

            if (leitor.GetInt32(15) == 0)
            {
                chamado[0].ValorTotal = 0;
            }
            else
            {
                chamado[0].ValorTotal = leitor.GetInt32(15) / 100;
            }

            chamado[0].Status = leitor.GetString(16);

            conexao.desconectar();
            cmd.Dispose();

            return chamado;
        }

        public void AtualizarStatus (ChamadoDTO c)
        {
            staDto.Status = c.Status;
            staBll.SelecionarIdChamadoStatus(staDto);

            cmd.CommandText = "UPDATE tb_chamado SET " +
                "idStatusChamado = " + staDto.Id + " " +
                "WHERE codigo = '" + c.Codigo + "'";

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

        public void AtualizarValorChamado(ChamadoDTO c)
        {
            cmd.CommandText = "UPDATE tb_chamado SET " +
                "valorTotal = valorTotal + (" + c.ValorTotal * 100 + ") " +
                "WHERE codigo = '" + c.Codigo + "'";

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

        public void AtualizarPropostaChamado(ChamadoDTO c)
        {
            cmd.CommandText = "UPDATE tb_chamado SET " +
                "codPropostaComercial = '" + c.Proposta + "' " +
                "WHERE codigo = '" + c.Codigo + "'";

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

        public List<ChamadoDTO> PopularComboboxChamado()
        {
            cmd.CommandText = "SELECT " +
                "codigo, " +
                "dataChamado, " +
                "localSetor, " +
                "equipamento " +
                "FROM tb_chamado " +
                "WHERE codPropostaComercial = '-' " +
                "AND idStatusChamado = 2";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<ChamadoDTO> chamado = new List<ChamadoDTO>();

            while (leitor.Read())
            {
                ChamadoDTO chm = new ChamadoDTO();
                string codigo = leitor.GetString(0);
                DateTime dataCha = DateTime.Parse(leitor.GetString(1));
                string dataChamado = dataCha.ToString("dd/MM/yyyy");
                string localSetor = leitor.GetString(2);
                string equipamento = leitor.GetString(3);

                chm.Codigo = codigo + " - " + dataChamado + " - " + localSetor + " - " + equipamento; 
                chamado.Add(chm);
            }

            conexao.desconectar();
            cmd.Dispose();

            return chamado;
        }

        public Int32 ContarChamadoStatus(ChamadoDTO c)
        {
            staDto.Status = c.Status;
            staBll.SelecionarIdChamadoStatus(staDto);

            cmd.CommandText = "SELECT COUNT(id) FROM " + tabela + " " +
                "WHERE idStatus = " + staDto.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdChamadoStatus = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdChamadoStatus;
        }
    }
}
