using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaSegsal.BLL
{
    class PropostaComercialServicoBLL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        PropostaComercialServicoTipoDTO tipDto = new PropostaComercialServicoTipoDTO();
        PropostaComercialServicoTipoBLL tipBll = new PropostaComercialServicoTipoBLL();

        PropostaComercialServicoStatusDTO staDto = new PropostaComercialServicoStatusDTO();
        PropostaComercialServicoStatusBLL staBll = new PropostaComercialServicoStatusBLL();

        Int32 qtdIdPropostaComercialServico;

        public void CriarNovoServicoProposta(PropostaComercialServicoDTO p)
        {
            this.ContarIdServicoProposta();

            if (qtdIdPropostaComercialServico == 0)
            {
                p.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_proposta_comercial_servico";

                try
                {
                    cmd.Connection = conexao.conectar();
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    p.Id = leitor.GetInt32(0);

                    conexao.desconectar();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarIdServicoProposta()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_proposta_comercial_servico";

            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdPropostaComercialServico = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdPropostaComercialServico;
        }

        public void SalvarServicoProposta(PropostaComercialServicoDTO p)
        {
            tipDto.TipoServico = p.TipoServico;
            tipBll.SelecionarIdPropostaComercialServicoTipo(tipDto);

            cmd.CommandText = "INSERT INTO tb_proposta_comercial_servico (" +
                "id, " +
                "codProposta, " +
                "idTipoServico, " +
                "qtd, " +
                "descricao, " +
                "valorUnitario, " +
                "valorTotal) " +
                "VALUES (" +
                p.Id + ", '" +
                p.Proposta + "', " +
                tipDto.Id + ", " +
                p.Qtd + ", '" +
                p.Descricao + "', " +
                p.ValorUnitario * 100 + ", " +
                p.ValorTotal * 100 + ")";

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EditarServicoProposta(PropostaComercialServicoDTO p)
        {
            tipDto.TipoServico = p.TipoServico;
            tipBll.SelecionarIdPropostaComercialServicoTipo(tipDto);

            cmd.CommandText = "UPDATE tb_proposta_comercial_servico SET " +
                "idTipoServico = " + tipDto.Id + ", " +
                "qtd = " + p.Qtd + ", " +
                "descricao = '" + p.Descricao + "', " +
                "valorUnitario = " + p.ValorUnitario * 100 + ", " +
                "valorTotal = " + p.ValorTotal * 100 + ", " +
                "WHERE id = " + p.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ExcluirServicoProposta(PropostaComercialServicoDTO p)
        {
            cmd.CommandText = "DELETE FROM tb_proposta_comercial_servico WHERE id = " + p.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<PropostaComercialServicoDTO> ListaServicoProposta(PropostaComercialServicoDTO p)
        {
            cmd.CommandText = "SELECT " +
                "p.id, " +
                "p.codProposta, " +
                "t.sigla, " +
                "p.qtd, " +
                "p.descricao, " +
                "p.valorUnitario, " +
                "p.valorTotal " +
                "FROM tb_proposta_comercial_servico p " +
                "INNER JOIN tb_proposta_comercial_servico_tipo t ON p.idTipoServico = t.id " +
                "WHERE p.codProposta = '" + p.Proposta + "' " +
                "ORDER BY p.id ASC";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<PropostaComercialServicoDTO> servico = new List<PropostaComercialServicoDTO>();

            while (leitor.Read())
            {
                PropostaComercialServicoDTO serv = new PropostaComercialServicoDTO();

                serv.Id = leitor.GetInt32(0);
                serv.Proposta = leitor.GetString(1);
                serv.TipoServico = leitor.GetString(2);
                serv.Qtd = leitor.GetInt32(3);
                serv.Descricao = leitor.GetString(4);
                serv.ValorUnitario = leitor.GetInt32(5) / 100;
                serv.ValorTotal = leitor.GetInt32(6) / 100;

                servico.Add(serv);
            }            

            conexao.desconectar();
            cmd.Dispose();

            return servico;
        }
    
        public List<PropostaComercialServicoDTO> SelecionarServicoProposta(PropostaComercialServicoDTO p)
        {
            cmd.CommandText = "SELECT " +
                "p.id, " +
                "p.codProposta, " +
                "t.tipoServico, " +
                "p.qtd, " +
                "p.descricao, " +
                "p.valorUnitario, " +
                "p.valorTotal " +
                "FROM tb_proposta_comercial_servico p " +
                "INNER JOIN tb_proposta_comercial_servico_tipo t ON p.idTipoServico = t.id " +
                "WHERE p.id = " + p.Id;

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<PropostaComercialServicoDTO> servico = new List<PropostaComercialServicoDTO>(7);

            leitor.Read();

            servico.Add(new PropostaComercialServicoDTO());

            servico[0].Id = leitor.GetInt32(0);
            servico[0].Proposta = leitor.GetString(1);
            servico[0].TipoServico = leitor.GetString(2);
            servico[0].Qtd = leitor.GetInt32(3);
            servico[0].Descricao = leitor.GetString(4);
            servico[0].ValorUnitario = leitor.GetInt32(5) / 100;
            servico[0].ValorTotal = leitor.GetInt32(6) / 100;

            conexao.desconectar();
            cmd.Dispose();

            return servico;
        }

        public void EditarValorServicoProposta(PropostaComercialServicoDTO p)
        {
            tipDto.TipoServico = p.TipoServico;
            tipBll.SelecionarIdPropostaComercialServicoTipo(tipDto);

            cmd.CommandText = "UPDATE tb_proposta_comercial_servico SET " +
                "idTipoServico = " + tipDto.Id + ", " +
                "qtd = " + p.Qtd + ", " +
                "descricao = '" + p.Descricao + "', " +
                "valorUnitario = " + p.ValorUnitario * 100 + ", " +
                "valorTotal = " + p.ValorTotal * 100 + ", " +
                "WHERE id = " + p.Id;

            try
            {
                cmd.Connection = conexao.conectar();
                cmd.ExecuteNonQuery();

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }    
}
