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
    class ChamadoBLL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        ClienteContatoDTO cntDto = new ClienteContatoDTO();
        ClienteContatoBLL cntBll = new ClienteContatoBLL();

        ChamadoAssuntoDTO assDto = new ChamadoAssuntoDTO();
        ChamadoAssuntoBLL assBll = new ChamadoAssuntoBLL();

        ChamadoUrgenciaDTO urgDto = new ChamadoUrgenciaDTO();
        ChamadoUrgenciaBLL urgBll = new ChamadoUrgenciaBLL();

        ChamadoStatusDTO staDto = new ChamadoStatusDTO();
        ChamadoStatusBLL staBll = new ChamadoStatusBLL();

        Int32 qtdIdChamado;

        public void CriarNovoChamado(ChamadoDTO c)
        {
            this.ContarIdChamado();

            if (qtdIdChamado == 0)
            {
                c.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_chamado";

                try
                {
                    cmd.Connection = conexao.conectar();
                    MySqlDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    c.Id = leitor.GetInt32(0);

                    conexao.desconectar();
                }
                catch (MySqlException ex)
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
                MySqlDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdChamado = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdChamado;
        }

        public void SalvarNovoChamado(ChamadoDTO c)
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

            cmd.CommandText = "INSERT INTO tb_chamado (" +
                "id, " +
                "codigo, " +
                "dataChamado, " +
                "codBase, " +
                "localSetor, " +
                "idContato, " +
                "idAssunto, " +
                "idUrgencia, " +
                "informacaoCliente, " +
                "diagnostico, " +
                "solucao, " +
                "valorTotal, " +
                "idStatusChamado) " +
                "VALUES (" +
                c.Id + ", '" +
                c.Codigo + "', '" +
                c.DataChamado + "', '" +
                basDto.Codigo + "', '" +
                c.LocalSetor + "', " +
                cntDto.Id + ", " +
                assDto.Id + ", " +
                urgDto.Id + ", '" +
                c.InformacaoCliente + "', '" +
                c.Diagnostico + "', '" +
                c.Solucao + "', " +
                c.ValorTotal + ", " +
                staDto.Id + ")";

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
            catch (MySqlException ex)
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
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<ChamadoDTO> ListarChamado()
        {
            cmd.CommandText = "SELECT " +
                "c.id, " +
                "c.codigo, " +
                "c.dataChamado, " +
                "cl.nomeFantasia, " +
                "bc.nomeBase, " +
                "c.localSetor, " +
                "ct.nome, " +
                "a.assunto, " +
                "u.urgencia, " +
                "c.informacaoCliente, " +
                "c.diagnostico, " +
                "c.solucao, " +
                "c.valorTotal, " +
                "st.statusChamado " +
                "FROM tb_chamado c " +
                "INNER JOIN tb_cliente_base bc ON c.codBase = bc.codigo " +
                "INNER JOIN tb_cliente cl ON bc.codCliente = cl.codigo " +
                "INNER JOIN tb_cliente_contato ct ON c.idContato = ct.id " +
                "INNER JOIN tb_chamado_assunto a ON c.idAssunto = a.id " +
                "INNER JOIN tb_chamado_urgencia u ON c.idUrgencia = u.id " +
                "INNER JOIN tb_chamado_status st ON c.idStatusChamado = st.id " +
                "ORDER BY c.codigo DESC";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<ChamadoDTO> chamado = new List<ChamadoDTO>();

            while (leitor.Read())
            {
                ChamadoDTO chm = new ChamadoDTO();

                chm.Id = leitor.GetInt32(0);
                chm.Codigo = leitor.GetString(1);
                DateTime dataChamado = DateTime.Parse(leitor.GetString(2));
                chm.DataChamado = dataChamado.ToString("dd/MM/yyyy");
                chm.Cliente = leitor.GetString(3);
                chm.BaseCliente = leitor.GetString(4);
                chm.LocalSetor = leitor.GetString(5);
                chm.ContatoCliente = leitor.GetString(6);
                chm.Assunto = leitor.GetString(7);
                chm.Urgencia = leitor.GetString(8);
                chm.InformacaoCliente = leitor.GetString(9);
                chm.Diagnostico = leitor.GetString(10);
                chm.Solucao = leitor.GetString(11);       
                chm.ValorTotal = leitor.GetInt32(12) / 100;
                chm.Status = leitor.GetString(13);

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
                "c.id, " +
                "c.codigo, " +
                "c.dataChamado, " +
                "cl.nomeFantasia, " +
                "bc.nomeBase, " +
                "c.localSetor, " +
                "ct.nome, " +
                "a.assunto, " +
                "u.urgencia, " +
                "c.informacaoCliente, " +
                "c.diagnostico, " +
                "c.solucao, " +
                "c.valorTotal, " +
                "st.statusChamado " +
                "FROM tb_chamado c " +
                "INNER JOIN tb_cliente_base bc ON c.codBase = bc.codigo " +
                "INNER JOIN tb_cliente cl ON bc.codCliente = cl.codigo " +
                "INNER JOIN tb_cliente_contato ct ON c.idContato = ct.id " +
                "INNER JOIN tb_chamado_assunto a ON c.idAssunto = a.id " +
                "INNER JOIN tb_chamado_urgencia u ON c.idUrgencia = u.id " +
                "INNER JOIN tb_chamado_status st ON c.idStatusChamado = st.id " +
                "WHERE c.idStatusChamado = " + staDto.Id + " " +
                "ORDER BY c.codigo DESC";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<ChamadoDTO> chamado = new List<ChamadoDTO>();

            while (leitor.Read())
            {
                ChamadoDTO chm = new ChamadoDTO();

                chm.Id = leitor.GetInt32(0);
                chm.Codigo = leitor.GetString(1);
                DateTime dataChamado = DateTime.Parse(leitor.GetString(2));
                chm.DataChamado = dataChamado.ToString("dd/MM/yyyy");
                chm.Cliente = leitor.GetString(3);
                chm.BaseCliente = leitor.GetString(4);
                chm.LocalSetor = leitor.GetString(5);
                chm.ContatoCliente = leitor.GetString(6);
                chm.Assunto = leitor.GetString(7);
                chm.Urgencia = leitor.GetString(8);
                chm.InformacaoCliente = leitor.GetString(9);
                chm.Diagnostico = leitor.GetString(10);
                chm.Solucao = leitor.GetString(11);
                chm.ValorTotal = leitor.GetInt32(12) / 100;
                chm.Status = leitor.GetString(13);

                chamado.Add(chm);
            }

            conexao.desconectar();
            cmd.Dispose();

            return chamado;
        }

        public List<ChamadoDTO> SelecionarChamado (ChamadoDTO c)
        {
            cmd.CommandText = "SELECT " +
                "c.id, " +
                "c.codigo, " +
                "c.dataChamado, " +
                "cl.nomeFantasia, " +
                "bc.nomeBase, " +
                "c.localSetor, " +
                "ct.nome, " +
                "a.assunto, " +
                "u.urgencia, " +
                "c.informacaoCliente, " +
                "c.diagnostico, " +
                "c.solucao, " +
                "c.valorTotal, " +
                "st.statusChamado " +
                "FROM tb_chamado c " +
                "INNER JOIN tb_cliente_base bc ON c.codBase = bc.codigo " +
                "INNER JOIN tb_cliente cl ON bc.codCliente = cl.codigo " +
                "INNER JOIN tb_cliente_contato ct ON c.idContato = ct.id " +
                "INNER JOIN tb_chamado_assunto a ON c.idAssunto = a.id " +
                "INNER JOIN tb_chamado_urgencia u ON c.idUrgencia = u.id " +
                "INNER JOIN tb_chamado_status st ON c.idStatusChamado = st.id " +
                "WHERE c.codigo = '" + c.Codigo + "'";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<ChamadoDTO> chamado = new List<ChamadoDTO>();

            leitor.Read();

            chamado.Add(new ChamadoDTO());

            chamado[0].Id = leitor.GetInt32(0);
            chamado[0].Codigo = leitor.GetString(1);
            DateTime dataChamado = DateTime.Parse(leitor.GetString(2));
            chamado[0].DataChamado = dataChamado.ToString("dd/MM/yyyy");
            chamado[0].Cliente = leitor.GetString(3);
            chamado[0].BaseCliente = leitor.GetString(4);
            chamado[0].LocalSetor = leitor.GetString(5);
            chamado[0].ContatoCliente = leitor.GetString(6);
            chamado[0].Assunto = leitor.GetString(7);
            chamado[0].Urgencia = leitor.GetString(8);
            chamado[0].InformacaoCliente = leitor.GetString(9);
            chamado[0].Diagnostico = leitor.GetString(10);
            chamado[0].Solucao = leitor.GetString(11);
            chamado[0].ValorTotal = leitor.GetInt32(12) / 100;
            chamado[0].Status = leitor.GetString(13);

            conexao.desconectar();
            cmd.Dispose();

            return chamado;
        }

        public void AtualizarStatus (ChamadoDTO c)
        {
            cmd.CommandText = "UPDATE tb_chamado SET " +
                "dataFinal = '" + c.DataFinal + "', " +
                "valorTotal = " + c.ValorTotal * 100 + " " +
                "WHERE codigo = '" + c.Codigo + "'";

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

        //public string SelecionarCodigoChamado(ChamadoDTO c)
        //{

        //}

        //public List<ChamadoDTO> PopularComboboxChamado()
        //{

        //}
    }
}
