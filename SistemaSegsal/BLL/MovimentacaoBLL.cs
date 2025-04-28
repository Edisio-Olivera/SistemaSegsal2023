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
    class MovimentacaoBLL
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

        FornecedorDTO forDto = new FornecedorDTO();
        FornecedorBLL forBll = new FornecedorBLL();

        ContaBancariaDTO ctaDto = new ContaBancariaDTO();
        ContaBancariaBLL ctaBll = new ContaBancariaBLL();


        Int32 qtdIdMovimentacao;

        string tabela = "tb_movimentacao";

        public void CriarNovoMovimentacao(MovimentacaoDTO m)
        {
            this.ContarMovimentacao();

            if (qtdIdMovimentacao == 0)
            {
                m.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) FROM " + tabela ;

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    m.Id = leitor.GetInt32(0) + 1;

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

        public void SalvarMovimentacaoEntrada(MovimentacaoDTO m)
        {
            cliDto.NomeFantasia = m.FornecedorCliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            tipDto.Tipo = m.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            frmDto.FormaPgto = m.FormaPgto;
            frmDto.CondicaoPgto = m.CondPgto;
            frmBll.SelecionarIdFormaPgto(frmDto);

            staDto.Status = m.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            ctaDto.Nome = m.Conta;
            ctaBll.SelecionarIdContaBancaria(ctaDto);

            cmd.CommandText = "INSERT INTO tb_movimentacao (" +
                "id, " +
                "dataRegistro, " +
                "idConta, " +
                "codFornecedorCliente, " +
                "idTipo, " +
                "dataTransacao, " +
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

        public void SalvarMovimentacaoSaida(MovimentacaoDTO m)
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

            ctaDto.Nome = m.Conta;
            ctaBll.SelecionarIdContaBancaria(ctaDto);

            cmd.CommandText = "INSERT INTO tb_movimentacao (" +
                "id, " +
                "dataRegistro, " +
                "idConta, " +
                "codFornecedorCliente, " +
                "idTipo, " +
                "dataTransacao, " +
                "descricao, " +
                "idFormaPgto, " +
                "idCartao, " +
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
                m.DataRegistro + "', " +
                ctaDto.Id + ", '" +
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

        public void EditarMovimentacaoEntrada(MovimentacaoDTO m)
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

        public void EditarMovimentacaoSaida(MovimentacaoDTO m)
        {
            forDto.NomeFantasia = m.FornecedorCliente;
            forBll.SelecionarCodigoFornecedor(forDto);

            tipDto.Tipo = m.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            frmDto.FormaPgto = m.FormaPgto;
            frmDto.CondicaoPgto = cndDto.CondicaoPgto;
            frmBll.SelecionarIdFormaPgto(frmDto);

            staDto.Status = m.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "UPDATE tb_movimentacao SET " +
                "codFornecedorCliente = '" + forDto.Codigo + "', " +
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

        public void ExcluirMovimentacao(MovimentacaoDTO m)
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

        public List<ClienteDTO> SelecionarMovimentacaoEntrada(MovimentacaoDTO m)
        {
            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_movimentacao.codFornecedorCliente, " +
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
                "FROM tb_movimentacao " +
                "INNER JOIN tb_cliente_tipo t ON c.idTipoCliente = t.id " +
                "INNER JOIN tb_cliente_status s ON c.idStatus = s.id " +
                "WHERE c.codigo = '" + m.Id + "'";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ClienteDTO> cliente = new List<ClienteDTO>(8);

            leitor.Read();

            cliente.Add(new ClienteDTO());

            cliente[0].Id = leitor.GetInt32(0);
            cliente[0].Codigo = leitor.GetString(1);
            cliente[0].TipoCliente = leitor.GetString(2);
            cliente[0].DataRegistro = leitor.GetString(3);
            cliente[0].RazaoSocial = leitor.GetString(4);
            cliente[0].NomeFantasia = leitor.GetString(5);
            cliente[0].Logomarca = leitor.GetString(6);
            cliente[0].Status = leitor.GetString(7);

            conexao.desconectar();
            cmd.Dispose();

            return cliente;
        }





    }
}
