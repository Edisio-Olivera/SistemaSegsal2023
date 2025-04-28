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
    internal class ContaBancariaBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        ContaBancariaTipoDTO tipDto = new ContaBancariaTipoDTO();
        ContaBancariaTipoBLL tipBll = new ContaBancariaTipoBLL();

        BancoDTO bncDto = new BancoDTO();
        BancoBLL bncBll = new BancoBLL();

        Int32 qtdIdContaBancaria;

        string tabela = "tb_conta_bancaria";

        public void CriarNovoContaBancaria(ContaBancariaDTO cb)
        {
            this.ContarIdContaBancaria();

            if (qtdIdContaBancaria == 0)
            {
                cb.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) FROM " +  tabela;

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    cb.Id = leitor.GetInt32(0);

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarIdContaBancaria()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM " + tabela;

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdContaBancaria = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdContaBancaria;
        }

        public void SalvarContaBancaria(ContaBancariaDTO cb)
        {
            tipDto.Tipo = cb.Tipo;
            tipBll.SelecionarIdTipoContaBancaria(tipDto);         

            bncDto.Nome = cb.Banco;
            bncBll.SelecionarIdBanco(bncDto);

            cmd.CommandText = "INSERT INTO tb_conta_bancaria (" +
                "id, " +
                "dataRegistro, " +
                "nome, " +
                "idBanco, " +
                "idTipo, " +
                "agenciaConta, " +
                "numeroConta, " +
                "saldo) " +
                "VALUES (" +
                cb.Id + ", '" +
                cb.DataRegistro + "', '" +
                cb.Nome + "', " +
                bncDto.Id + ", '" +                
                tipDto.Id + ", '" +
                cb.Agencia + "', '" +
                cb.Numero + "', '" +
                cb.Saldo + ")";

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

        public void EditarContaBancaria(ContaBancariaDTO cb)
        {
            tipDto.Tipo = cb.Tipo;
            tipBll.SelecionarIdTipoContaBancaria(tipDto);

            bncDto.Nome = cb.Banco;
            bncBll.SelecionarIdBanco(bncDto);

            cmd.CommandText = "INSERT INTO tb_conta_bancaria (" +
                "nome = '" + cb.Nome + "', " +
                "idBanco = " + bncDto.Id + ", " +
                "idTipo = " + tipDto.Id + ", " +
                "agenciaConta = '" + cb.Agencia + "', " +
                "numeroConta = '" + cb.Numero + "' " +
                "WHERE id = " + cb.Id;

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

        public List<ContaBancariaDTO> SelecionarContaBancaria(ContaBancariaDTO cb)
        {
            cmd.CommandText = "SELECT " +
                "tb_conta_bancaria.id, " +
                "tb_conta_bancaria.nome, " +
                "tb_conta_bancaria_tipo.tipo, " +
                "tb_banco.nome, " +
                "tb_conta_bancaria.agenciaConta, " +
                "tb_conta_bancaria.numeroConta, " +
                "tb_conta_bancaria.saldo " +
                "FROM ((tb_conta_bancaria " +
                "INNER JOIN tb_conta_bancaria_tipo ON tb_conta_bancaria.idTipo = tb_conta_bancaria_tipo.id) " +
                "INNER JOIN tb_banco ON tb_conta_bancaria.idBanco = tb_banco.id) " +
                "WHERE tb_conta_bancaria.id = " + cb.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaBancariaDTO> conta = new List<ContaBancariaDTO>(7);

            leitor.Read();

            conta.Add(new ContaBancariaDTO());

            conta[0].Id = leitor.GetInt32(0);
            conta[0].DataRegistro = leitor.GetDateTime(1);
            conta[0].Tipo = leitor.GetString(2);
            conta[0].Banco = leitor.GetString(3);
            conta[0].Agencia = leitor.GetString(4);
            conta[0].Numero = leitor.GetString(5);
            conta[0].Saldo = leitor.GetInt32(6) / 100;
            
            conexao.desconectar();
            cmd.Dispose();

            return conta;
        }

        public List<ContaBancariaDTO> ListarContaBancaria(ContaBancariaDTO cb)
        {
            cmd.CommandText = "SELECT " +
                "tb_conta_bancaria.id, " +
                "tb_conta_bancaria.nome, " +
                "tb_conta_bancaria_tipo.tipo, " +
                "tb_banco.nome, " +
                "tb_conta_bancaria.agenciaConta, " +
                "tb_conta_bancaria.numeroConta, " +
                "tb_conta_bancaria.saldo " +
                "FROM ((tb_conta_bancaria " +
                "INNER JOIN tb_conta_bancaria_tipo ON tb_conta_bancaria.idTipo = tb_conta_bancaria_tipo.id) " +
                "INNER JOIN tb_banco ON tb_conta_bancaria.idBanco = tb_banco.id) " +
                "ORDER BY tb_conta_bancaria.id ASC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ContaBancariaDTO> conta = new List<ContaBancariaDTO>(7);

            while (leitor.Read())
            {
                ContaBancariaDTO c = new ContaBancariaDTO();

                c.Id = leitor.GetInt32(0);
                c.DataRegistro = leitor.GetDateTime(1);
                c.Tipo = leitor.GetString(2);
                c.Banco = leitor.GetString(3);
                c.Agencia = leitor.GetString(4);
                c.Numero = leitor.GetString(5);
                c.Saldo = leitor.GetInt32(6) / 100;

                conta.Add(c);
            }            

            conexao.desconectar();
            cmd.Dispose();

            return conta;
        }

        public List<ContaBancariaDTO> PopularComboboxContaBancaria()
        {
            cmd.CommandText = "SELECT nome FROM " + tabela;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<ContaBancariaDTO> conta = new List<ContaBancariaDTO>();

            while (leitor.Read())
            {
                ContaBancariaDTO cb = new ContaBancariaDTO();
                cb.Nome = leitor.GetString(0);
                conta.Add(cb);
            }

            conexao.desconectar();
            cmd.Dispose();

            return conta;
        }

        public Int32 SelecionarIdContaBancaria(ContaBancariaDTO cb)
        {
            cmd.CommandText = "SELECT id FROM " + tabela + " " +
                "WHERE nome = '" + cb.Nome + "'";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                cb.Id = leitor.GetInt32(0);

                conexao.desconectar();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return cb.Id;
        }
    }
}
