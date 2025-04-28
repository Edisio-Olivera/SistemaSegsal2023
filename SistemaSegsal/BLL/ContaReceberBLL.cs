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
    internal class ContaReceberBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        MovimentacaoTipoDTO tipDto = new MovimentacaoTipoDTO();
        MovimentacaoTipoBLL tipBll = new MovimentacaoTipoBLL();

        MovimentacaoStatusDTO staDto = new MovimentacaoStatusDTO();
        MovimentacaoStatusBLL staBll = new MovimentacaoStatusBLL();

        CondicaoPgtoDTO cndDto = new CondicaoPgtoDTO();
        CondicaoPgtoBLL cndBll = new CondicaoPgtoBLL();

        FormaPgtoDTO frmDto = new FormaPgtoDTO();
        FormaPgtoBLL frmBll = new FormaPgtoBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        Int32 qtdIdMovimentacao;

        public void CriarNovoContaReceber(MovimentacaoDTO m)
        {
            this.ContarMovimentacao();

            if (qtdIdMovimentacao == 0)
            {
                m.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) FROM tb_movimentacao";

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    m.Id = leitor.GetInt32(0);

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarMovimentacao()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_movimentacao";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdMovimentacao = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdMovimentacao;
        }

        public void SalvarContaReceber(MovimentacaoDTO m)
        {
            cliDto.NomeFantasia = m.FornecedorCliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            tipDto.Tipo = m.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            frmDto.FormaPgto = m.FormaPgto;
            frmDto.CondicaoPgto = cndDto.CondicaoPgto;
            frmBll.SelecionarIdFormaPgto(frmDto);

            staDto.Status = m.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "INSERT INTO tb_movimentacao (" +
                "id, " +
                "dataRegistro, " +
                "codFornecedorCliente, " +
                "idTipo, " +
                "dataTransicao, " +
                "descricao, " +
                "idFormaPgto, " +
                "valorTransacao, " +
                "qtdParcela, " +
                "parcela, " +
                "valorParcela, " +
                "dataVencimento, " +
                "dataPgtoReceb, " +
                "descJuros, " +
                "valorTotal, " +
                "idStatus) " +
                "VALUES (" +
                m.Id + ", '" +
                m.DataRegistro + "', '" +
                cliDto.Codigo + "', " +
                tipDto.Id + ", '" +
                m.DataTransacao + "', '" +
                m.Descricao + "', " +
                frmDto.Id + ", " +
                m.ValorTransacao * 100 + ", " +
                m.QtdParcela + ", '" +
                m.Parcela + "', " +
                m.ValorParcela * 100 + ", '" +
                m.DataVencimento + "', '" +
                m.DataPgtoReceb + "', " +
                m.DescJuros * 100 + ", " +
                m.ValorTotal * 100 + ", " +
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

        public void EditarContaReceber(MovimentacaoDTO m)
        {
            cliDto.NomeFantasia = m.FornecedorCliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            tipDto.Tipo = m.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            frmDto.FormaPgto = m.FormaPgto;
            frmDto.CondicaoPgto = cndDto.CondicaoPgto;
            frmBll.SelecionarIdFormaPgto(frmDto);

            staDto.Status = m.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "UPDATE tb_movimentacao SET " +
                "codFornecedorCliente = '" + cliDto.Codigo + "', " +
                "idTipo = " + tipDto.Id + "', " +
                "dataTransicao = '" + m.DataTransacao + "', " +
                "descricao = '" + m.Descricao + "', " +
                "idFormaPgto = " + frmDto.Id + ", " +
                "valorTransacao = " + m.ValorTransacao * 100 + ", " +
                "qtdParcela = " + m.QtdParcela + ", " +
                "parcela = '" + m.Parcela + "', " +
                "valorParcela = " + m.ValorParcela * 100 + ", " +
                "dataVencimento = '" + m.DataVencimento + "', " +
                "dataPgtoReceb = '" + m.DataPgtoReceb + "', " +
                "descJuros = " + m.DescJuros * 100 + ", " +
                "valorTotal = " + m.ValorTotal * 100 + ", " +
                "idStatus = " + staDto.Id + " " +
                "WHERE id = " + m.Id;

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

        public void ExcluirContaReceber(MovimentacaoDTO m)
        {
            cmd.CommandText = "DELETE FROM tb_movimentacao " +
                "WHERE id = " + m.Id;

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

        public List<MovimentacaoDTO> SelecionarContaReceber(MovimentacaoDTO m)
        {
            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_cliente.nomeFantasia, " +
                "tb_movimentacao_tipo.tipo, " +
                "tb_movimentacao.dataTransicao, " +
                "tb_movimentacao.descricao, " +
                "tb_condicao_pgto.condicao, " +
                "tb_forma_pgto.forma, " +
                "tb_movimentacao.valorTransacao, " +
                "tb_movimentacao.qtdParcela, " +
                "tb_movimentacao.parcela, " +
                "tb_movimentacao.valorParcela, " +
                "tb_movimentacao.dataVencimento, " +
                "tb_movimentacao.dataPgtoReceb, " +
                "tb_movimentacao.descJuros, " +
                "tb_movimentacao.valorTotal, " +
                "tb_movimentacao_status.status " +
                "FROM (((((tb_movimentacao " +
                "INNER JOIN tb_cliente ON tb_movimentacao.codFornecedorCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +                
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.id = " + m.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<MovimentacaoDTO> receber = new List<MovimentacaoDTO>(16);

            leitor.Read();

            receber.Add(new MovimentacaoDTO());

            receber[0].Id = leitor.GetInt32(0);
            receber[0].FornecedorCliente = leitor.GetString(1);
            receber[0].TipoMovimentacao = leitor.GetString(2);
            receber[0].DataTransacao = leitor.GetDateTime(3);
            receber[0].Descricao = leitor.GetString(4);
            receber[0].CondPgto = leitor.GetString(5);
            receber[0].FormaPgto = leitor.GetString(6);
            receber[0].ValorTransacao = leitor.GetInt32(7) / 100;
            receber[0].QtdParcela = leitor.GetInt32(8);
            receber[0].Parcela = leitor.GetString(9);
            receber[0].ValorParcela = leitor.GetInt32(10) / 100;
            receber[0].DataVencimento = leitor.GetDateTime(11);
            receber[0].DataRegistro = leitor.GetDateTime(12);
            receber[0].DescJuros = leitor.GetInt32(13) / 100;
            receber[0].ValorTotal = leitor.GetInt32(14) / 100;
            receber[0].Status = leitor.GetString(15);

            conexao.desconectar();
            cmd.Dispose();

            return receber;
        }

        public List<MovimentacaoDTO> ListaContaReceberStatus(MovimentacaoDTO m)
        {
            tipDto.Tipo = m.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            staDto.Status = m.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_cliente.nomeFantasia, " +
                "tb_movimentacao_tipo.tipo, " +
                "tb_movimentacao.dataTransicao, " +
                "tb_movimentacao.descricao, " +
                "tb_condicao_pgto.condicao, " +
                "tb_forma_pgto.forma, " +
                "tb_movimentacao.valorTransacao, " +
                "tb_movimentacao.qtdParcela, " +
                "tb_movimentacao.parcela, " +
                "tb_movimentacao.valorParcela, " +
                "tb_movimentacao.dataVencimento, " +
                "tb_movimentacao.dataPgtoReceb, " +
                "tb_movimentacao.descJuros, " +
                "tb_movimentacao.valorTotal, " +
                "tb_movimentacao_status.status " +
                "FROM (((((tb_movimentacao " +
                "INNER JOIN tb_cliente ON tb_movimentacao.codFornecedorCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.idTipo = " + tipDto.Id + " " +
                "AND tb_movimentacao.idStatus = " + staDto.Id + " " +
                "ORDER BY tb_movimentacao.id DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<MovimentacaoDTO> receber = new List<MovimentacaoDTO>(16);

            while (leitor.Read())
            {
                MovimentacaoDTO rc = new MovimentacaoDTO();

                rc.Id = leitor.GetInt32(0);
                rc.FornecedorCliente = leitor.GetString(1);
                rc.TipoMovimentacao = leitor.GetString(2);
                rc.DataTransacao = leitor.GetDateTime(3);
                rc.Descricao = leitor.GetString(4);
                rc.CondPgto = leitor.GetString(5);
                rc.FormaPgto = leitor.GetString(6);
                rc.ValorTransacao = leitor.GetInt32(7) / 100;
                rc.QtdParcela = leitor.GetInt32(8);
                rc.Parcela = leitor.GetString(9);
                rc.ValorParcela = leitor.GetInt32(10) / 100;
                rc.DataVencimento = leitor.GetDateTime(11);
                rc.DataRegistro = leitor.GetDateTime(12);
                rc.DescJuros = leitor.GetInt32(13) / 100;
                rc.ValorTotal = leitor.GetInt32(14) / 100;
                rc.Status = leitor.GetString(15);

                receber.Add(rc);
            }

            conexao.desconectar();
            cmd.Dispose();

            return receber;
        }

        public List<MovimentacaoDTO> ListaContaReceberCliente(MovimentacaoDTO m)
        {
            tipDto.Tipo = m.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            cliDto.NomeFantasia = m.FornecedorCliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_cliente.nomeFantasia, " +
                "tb_movimentacao_tipo.tipo, " +
                "tb_movimentacao.dataTransicao, " +
                "tb_movimentacao.descricao, " +
                "tb_condicao_pgto.condicao, " +
                "tb_forma_pgto.forma, " +
                "tb_movimentacao.valorTransacao, " +
                "tb_movimentacao.qtdParcela, " +
                "tb_movimentacao.parcela, " +
                "tb_movimentacao.valorParcela, " +
                "tb_movimentacao.dataVencimento, " +
                "tb_movimentacao.dataPgtoReceb, " +
                "tb_movimentacao.descJuros, " +
                "tb_movimentacao.valorTotal, " +
                "tb_movimentacao_status.status " +
                "FROM (((((tb_movimentacao " +
                "INNER JOIN tb_cliente ON tb_movimentacao.codFornecedorCliente = tb_cliente.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.idTipo = " + tipDto.Id + " " +
                "AND tb_movimentacao.codFornecedorCliente = '" + cliDto.Codigo + "' " +
                "ORDER BY tb_movimentacao.id DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<MovimentacaoDTO> receber = new List<MovimentacaoDTO>(16);

            while (leitor.Read())
            {
                MovimentacaoDTO rc = new MovimentacaoDTO();

                rc.Id = leitor.GetInt32(0);
                rc.FornecedorCliente = leitor.GetString(1);
                rc.TipoMovimentacao = leitor.GetString(2);
                rc.DataTransacao = leitor.GetDateTime(3);
                rc.Descricao = leitor.GetString(4);
                rc.CondPgto = leitor.GetString(5);
                rc.FormaPgto = leitor.GetString(6);
                rc.ValorTransacao = leitor.GetInt32(7) / 100;
                rc.QtdParcela = leitor.GetInt32(8);
                rc.Parcela = leitor.GetString(9);
                rc.ValorParcela = leitor.GetInt32(10) / 100;
                rc.DataVencimento = leitor.GetDateTime(11);
                rc.DataRegistro = leitor.GetDateTime(12);
                rc.DescJuros = leitor.GetInt32(13) / 100;
                rc.ValorTotal = leitor.GetInt32(14) / 100;
                rc.Status = leitor.GetString(15);

                receber.Add(rc);
            }

            conexao.desconectar();
            cmd.Dispose();

            return receber;
        }

        public void ReceberContaReceber(MovimentacaoDTO m)
        {
            staDto.Status = m.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "UPDATE tb_movimentacao SET " +
                "idStatus = " + staDto.Id + " " +
                "WHERE id = " + m.Id;

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
    }
}
