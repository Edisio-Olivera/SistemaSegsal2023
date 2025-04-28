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
    internal class ContaPagarBLL
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

        FornecedorDTO forDto = new FornecedorDTO();
        FornecedorBLL forBll = new FornecedorBLL();

        ContaBancariaDTO cntDto = new ContaBancariaDTO();
        ContaBancariaBLL cntBll = new ContaBancariaBLL();

        Int32 qtdIdMovimentacao;
        Int32 valorMesAno;
        Int32 valorAno;

        public void CriarNovoContaPagar(ContaPagarDTO cp)
        {
            this.ContarMovimentacao();

            if (qtdIdMovimentacao == 0)
            {
                cp.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) FROM tb_movimentacao";

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    cp.Id = leitor.GetInt32(0);

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

        public void SalvarContaPagar(ContaPagarDTO cp)
        {
            cntDto.Nome = cp.Conta;
            cntBll.SelecionarIdContaBancaria(cntDto);

            forDto.NomeFantasia = cp.Fornecedor;
            forBll.SelecionarCodigoFornecedor(forDto);

            tipDto.Tipo = cp.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            frmDto.FormaPgto = cp.FormaPgto;
            frmDto.CondicaoPgto = cp.CondPgto;
            frmBll.SelecionarIdFormaPgto(frmDto);

            staDto.Status = cp.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "INSERT INTO tb_movimentacao (" +
                "id, " +
                "dataRegistro, " +
                "idConta, " +
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
                cp.Id + ", '" +
                cp.DataRegistro + "', " +
                cntDto.Id + ", '" +
                forDto.Codigo + "', " +
                tipDto.Id + ", '" +
                cp.DataTransacao + "', '" +
                cp.Descricao + "', " +
                frmDto.Id + ", " +
                cp.ValorTransacao + ", " +
                cp.QtdParcela + ", '" +
                cp.Parcela + "', " +
                cp.ValorParcela + ", '" +
                cp.DataVencimento + "', '" +
                cp.DataPgtoReceb + "', " +
                cp.DescJuros + ", " +
                cp.ValorTotal + ", " +
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

        public void EditarContaPagar(ContaPagarDTO cp)
        {
            forDto.NomeFantasia = cp.Fornecedor;
            forBll.SelecionarCodigoFornecedor(forDto);

            tipDto.Tipo = cp.TipoMovimentacao;
            tipBll.SelecionarIdMovimentacaoTipo(tipDto);

            frmDto.FormaPgto = cp.FormaPgto;
            frmDto.CondicaoPgto = cndDto.CondicaoPgto;
            frmBll.SelecionarIdFormaPgto(frmDto);

            staDto.Status = cp.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "UPDATE tb_movimentacao SET " +
                "codFornecedorCliente = '" + forDto.Codigo + "', " +
                "idTipo = " + tipDto.Id + "', " +
                "dataTransicao = '" + cp.DataTransacao + "', " +
                "descricao = '" + cp.Descricao + "', " +
                "idFormaPgto = " + frmDto.Id + ", " +
                "valorTransacao = " + cp.ValorTransacao * 100 + ", " +
                "qtdParcela = " + cp.QtdParcela + ", " +
                "parcela = '" + cp.Parcela + "', " +
                "valorParcela = " + cp.ValorParcela * 100 + ", " +
                "dataVencimento = '" + cp.DataVencimento + "', " +
                "dataPgtoReceb = '" + cp.DataPgtoReceb + "', " +
                "descJuros = " + cp.DescJuros * 100 + ", " +
                "valorTotal = " + cp.ValorTotal * 100 + ", " +
                "idStatus = " + staDto.Id + " " +
                "WHERE id = " + cp.Id;

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

        public void ExcluirContaPagar(ContaPagarDTO cp)
        {
            cmd.CommandText = "DELETE FROM tb_movimentacao " +
                "WHERE id = " + cp.Id;

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

        public List<ContaPagarDTO> SelecionarContasPagar(ContaPagarDTO cp)
        {
            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_movimentacao.dataTransicao, " +
                "tb_fornecedor.nomeFantasia, " +
                "tb_movimentacao_tipo.tipo, " +                
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
                "INNER JOIN tb_fornecedor ON tb_movimentacao.codFornecedorCliente = tb_fornecedor.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.id = " + cp.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaPagarDTO> pagar = new List<ContaPagarDTO>(16);

            leitor.Read();

            pagar.Add(new ContaPagarDTO());

            pagar[0].Id = leitor.GetInt32(0);
            pagar[0].DataTransacao = leitor.GetDateTime(1);
            pagar[0].Fornecedor = leitor.GetString(2);
            pagar[0].TipoMovimentacao = leitor.GetString(3);            
            pagar[0].Descricao = leitor.GetString(4);
            pagar[0].CondPgto = leitor.GetString(5);
            pagar[0].FormaPgto = leitor.GetString(6);
            pagar[0].ValorTransacao = leitor.GetInt32(7) / 100;
            pagar[0].QtdParcela = leitor.GetInt32(8);
            pagar[0].Parcela = leitor.GetString(9);
            pagar[0].ValorParcela = leitor.GetInt32(10) / 100;
            pagar[0].DataVencimento = leitor.GetDateTime(11);
            pagar[0].DataRegistro = leitor.GetDateTime(12);
            pagar[0].DescJuros = leitor.GetInt32(13) / 100;
            pagar[0].ValorTotal = leitor.GetInt32(14) / 100;
            pagar[0].Status = leitor.GetString(15);

            conexao.desconectar();
            cmd.Dispose();

            return pagar;
        }

        public List<ContaPagarDTO> ListarContaPagar()
        {
            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_movimentacao.dataRegistro, " +
                "tb_movimentacao.idConta, " +
                "tb_fornecedor.nomeFantasia, " +
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
                "INNER JOIN tb_fornecedor ON tb_movimentacao.codFornecedorCliente = tb_fornecedor.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.idTipo = 2 " +
                "ORDER BY tb_movimentacao.dataVencimento ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaPagarDTO> pagar = new List<ContaPagarDTO>(18);

            while (leitor.Read())
            {
                ContaPagarDTO pg = new ContaPagarDTO();

                pg.Id = leitor.GetInt32(0);
                pg.DataRegistro = leitor.GetDateTime(1);
                pg.Conta = leitor.GetString(2);
                pg.Fornecedor = leitor.GetString(3);
                pg.TipoMovimentacao = leitor.GetString(4);
                pg.DataTransacao = leitor.GetDateTime(5);
                pg.Descricao = leitor.GetString(6);
                pg.CondPgto = leitor.GetString(7);
                pg.FormaPgto = leitor.GetString(8);
                pg.ValorTransacao = leitor.GetInt32(9);
                pg.QtdParcela = leitor.GetInt32(10);
                pg.Parcela = leitor.GetString(11);
                pg.ValorParcela = leitor.GetInt32(12);
                pg.DataVencimento = leitor.GetDateTime(13);
                pg.DataPgtoReceb = leitor.GetDateTime(14);                
                pg.DescJuros = leitor.GetInt32(15);
                pg.ValorTotal = leitor.GetInt32(16);
                pg.Status = leitor.GetString(17);

                pagar.Add(pg);
            }

            conexao.desconectar();
            cmd.Dispose();

            return pagar;
        }

        public List<ContaPagarDTO> ListarContaPagarStatus(ContaPagarDTO cp)
        {
            staDto.Status = cp.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_fornecedor.nomeFantasia, " +
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
                "INNER JOIN tb_fornecedor ON tb_movimentacao.codFornecedorCliente = tb_fornecedor.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.idTipo = 2 " +
                "AND tb_movimentacao.idStatus = " + staDto.Id + " " +
                "ORDER BY tb_movimentacao.id ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaPagarDTO> pagar = new List<ContaPagarDTO>(16);

            while (leitor.Read())
            {
                ContaPagarDTO pg = new ContaPagarDTO();

                pg.Id = leitor.GetInt32(0);
                pg.Fornecedor = leitor.GetString(1);
                pg.TipoMovimentacao = leitor.GetString(2);
                pg.DataTransacao = leitor.GetDateTime(3);
                pg.Descricao = leitor.GetString(4);
                pg.CondPgto = leitor.GetString(5);
                pg.FormaPgto = leitor.GetString(6);
                pg.ValorTransacao = leitor.GetInt32(7) / 100;
                pg.QtdParcela = leitor.GetInt32(8);
                pg.Parcela = leitor.GetString(9);
                pg.ValorParcela = leitor.GetInt32(10) / 100;
                pg.DataVencimento = leitor.GetDateTime(11);
                pg.DataRegistro = leitor.GetDateTime(12);
                pg.DescJuros = leitor.GetInt32(13) / 100;
                pg.ValorTotal = leitor.GetInt32(14) / 100;
                pg.Status = leitor.GetString(15);

                pagar.Add(pg);
            }            

            conexao.desconectar();
            cmd.Dispose();

            return pagar;
        }

        public List<ContaPagarDTO> ListarContaPagarFornecedor(ContaPagarDTO cp)   
        {
            forDto.NomeFantasia = cp.Fornecedor;
            forBll.SelecionarCodigoFornecedor(forDto);

            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_fornecedor.nomeFantasia, " +
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
                "INNER JOIN tb_fornecedor ON tb_movimentacao.codFornecedorCliente = tb_fornecedor.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.idTipo = 2 " +
                "AND tb_movimentacao.codFornecedorCliente = '" + forDto.Codigo + "' " +
                "ORDER BY tb_movimentacao.id ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaPagarDTO> pagar = new List<ContaPagarDTO>(16);

            while (leitor.Read())
            {
                ContaPagarDTO pg = new ContaPagarDTO();

                pg.Id = leitor.GetInt32(0);
                pg.Fornecedor = leitor.GetString(1);
                pg.TipoMovimentacao = leitor.GetString(2);
                pg.DataTransacao = leitor.GetDateTime(3);
                pg.Descricao = leitor.GetString(4);
                pg.CondPgto = leitor.GetString(5);
                pg.FormaPgto = leitor.GetString(6);
                pg.ValorTransacao = leitor.GetInt32(7) / 100;
                pg.QtdParcela = leitor.GetInt32(8);
                pg.Parcela = leitor.GetString(9);
                pg.ValorParcela = leitor.GetInt32(10) / 100;
                pg.DataVencimento = leitor.GetDateTime(11);
                pg.DataRegistro = leitor.GetDateTime(12);
                pg.DescJuros = leitor.GetInt32(13) / 100;
                pg.ValorTotal = leitor.GetInt32(14) / 100;
                pg.Status = leitor.GetString(15);

                pagar.Add(pg);
            }

            conexao.desconectar();
            cmd.Dispose();

            return pagar;
        }

        public List<ContaPagarDTO> ListarContaPagarMes(ContaPagarDTO cp)
        {
            cmd.CommandText = "SELECT " +
                "tb_movimentacao.id, " +
                "tb_movimentacao.dataRegistro, " +
                "tb_conta_bancaria.nome, " +
                "tb_fornecedor.nomeFantasia, " +
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
                "FROM ((((((tb_movimentacao " +
                "INNER JOIN tb_conta_bancaria ON tb_movimentacao.idConta = tb_conta_bancaria.id) " +
                "INNER JOIN tb_fornecedor ON tb_movimentacao.codFornecedorCliente = tb_fornecedor.codigo) " +
                "INNER JOIN tb_movimentacao_tipo ON tb_movimentacao.idTipo = tb_movimentacao_tipo.id) " +
                "INNER JOIN tb_forma_pgto ON tb_movimentacao.idFormaPgto = tb_forma_pgto.id) " +
                "INNER JOIN tb_condicao_pgto ON tb_forma_pgto.idCondicao = tb_condicao_pgto.id) " +
                "INNER JOIN tb_movimentacao_status ON tb_movimentacao.idStatus = tb_movimentacao_status.id) " +
                "WHERE tb_movimentacao.idTipo = 2 " +
                "AND MONTH(tb_movimentacao.dataVencimento) = " + cp.Mes + " " +
                "AND YEAR(tb_movimentacao.dataVencimento) = " + cp.Ano + " " +
                "ORDER BY tb_movimentacao.dataVencimento DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaPagarDTO> pagar = new List<ContaPagarDTO>(18);

            while (leitor.Read())
            {
                ContaPagarDTO pg = new ContaPagarDTO();

                pg.Id = leitor.GetInt32(0);
                pg.DataRegistro = leitor.GetDateTime(1);
                pg.Conta = leitor.GetString(2);
                pg.Fornecedor = leitor.GetString(3);
                pg.TipoMovimentacao = leitor.GetString(4);
                pg.DataTransacao = leitor.GetDateTime(5);
                pg.Descricao = leitor.GetString(6);
                pg.CondPgto = leitor.GetString(7);
                pg.FormaPgto = leitor.GetString(8);
                pg.ValorTransacao = leitor.GetInt32(9);
                pg.QtdParcela = leitor.GetInt32(10);
                pg.Parcela = leitor.GetString(11);
                pg.ValorParcela = leitor.GetInt32(12);
                pg.DataVencimento = leitor.GetDateTime(13);
                pg.DataPgtoReceb = leitor.GetDateTime(14);
                pg.DescJuros = leitor.GetInt32(15);
                pg.ValorTotal = leitor.GetInt32(16);
                pg.Status = leitor.GetString(17);

                pagar.Add(pg);
            }

            conexao.desconectar();
            cmd.Dispose();

            return pagar;
        }

        public void PagarContaPagar(ContaPagarDTO cp)
        {            
            staDto.Status = cp.Status;
            staBll.SelecionarIdMovimentacaoStatus(staDto);

            cmd.CommandText = "UPDATE tb_movimentacao SET " +
                "idStatus = " + staDto.Id + " " +
                "WHERE id = " + cp.Id;

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
                
        public long SomarValorContasPagarAno(ContaPagarDTO cp)
        {
            DateTime dataAtual = DateTime.Now;
            Int32 ano = dataAtual.Year;

            cmd.CommandText = "SELECT valorParcela " +
                "FROM tb_movimentacao " +
                "WHERE id = " + cp.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                cp.ValorParcela = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cp.ValorParcela;
        }

        public Int32 SelecionarContaPagar(ContaPagarDTO cp)
        {
            cmd.CommandText = "SELECT valorParcela " +
                "FROM tb_movimentacao " +
                "WHERE id = " + cp.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                cp.ValorParcela = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cp.ValorParcela;
        }
    }



    
}
