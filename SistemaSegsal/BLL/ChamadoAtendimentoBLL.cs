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
    class ChamadoAtendimentoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        ChamadoDTO chmDto = new ChamadoDTO();
        ChamadoBLL chmBll = new ChamadoBLL();

        ChamadoAtendimentoTipoDTO tipDto = new ChamadoAtendimentoTipoDTO();
        ChamadoAtendimentoTipoBLL tipBll = new ChamadoAtendimentoTipoBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();

        Int32 qtdIdAtendimento;

        public void CriarNovoAtendimentoChamado(ChamadoAtendimentoDTO a) { 
            this.ContarIdAtendimentoChamado();

            if (qtdIdAtendimento == 0)
            {
                a.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_chamado_atendimento";

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    a.Id = leitor.GetInt32(0);

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarIdAtendimentoChamado()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_chamado_atendimento";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdAtendimento = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdAtendimento;
        }

        public void SalvarAtendimentoChamado(ChamadoAtendimentoDTO s)
        {
            tipDto.Tipo = s.Tipo;
            tipBll.SelecionarIdTipoAtendimento(tipDto);

            tecDto.NomeUsual = s.Tecnico;
            tecBll.SelecionarCodigoTecnico(tecDto);

            cmd.CommandText = "INSERT INTO tb_chamado_atendimento (" +
                "id, " +
                "codChamado, " +
                "idTipoAtendimento, " +
                "codTecnico, " +
                "dataInicio, " +
                "horaInicio, " +
                "atividadeRealizada, " +
                "dataFinal, " +
                "horaFinal, " +
                "valor)" +
                "VALUES (" +
                s.Id + ", '" +
                s.Chamado + "', " +
                tipDto.Id + ", '" +
                tecDto.Codigo + "', '" +
                s.DataInicio + "', '" +
                s.HoraInicio + "', '" +
                s.AtividadeRealizada + "', '" +
                s.DataFinal + "', '" +
                s.HoraFinal + "', " +
                s.Valor * 100 + ")";

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

        public void EditarAtendimentoChamado(ChamadoAtendimentoDTO s)
        {
            tipDto.Tipo = s.Tipo;
            tipBll.SelecionarIdTipoAtendimento(tipDto);

            tecDto.Nome = s.Tecnico;
            tecBll.SelecionarCodigoTecnico(tecDto);

            cmd.CommandText = "UPDATE tb_chamado_atendimento SET " +
                "codChamado = '" + s.Chamado + "', " +
                "codTecnico = '" + tecDto.Codigo + "', " +
                "idTipoAtendimento = " + tipDto.Id + ", " +
                "dataInicio = '" + s.DataInicio + "', " +
                "horaInicio = '" + s.HoraInicio + "', " +
                "atividadeRealizada = '" + s.AtividadeRealizada + "', " +
                "dataFinal = '" + s.DataFinal + "', " +
                "horaFinal = '" + s.HoraFinal + "', " +
                "valor = " + s.Valor * 100 + " " +
                "WHERE id = " + s.Id;

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

        public void DeletarAtendimentoChamado(ChamadoAtendimentoDTO s)
        {
            cmd.CommandText = "DELETE FROM tb_chamado_atendimento WHERE id = " + s.Id;

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

        public List<ChamadoAtendimentoDTO> ListarAtendimentoChamado(ChamadoAtendimentoDTO s)
        {
            cmd.CommandText = "SELECT " +
                "s.id, " +
                "s.codChamado, " +
                "p.tipo, " +
                "t.nomeCurto, " +
                "s.dataInicio, " +
                "s.horaInicio, " +
                "s.atividadeRealizada, " +
                "s.dataFinal, " +
                "s.horaFinal, " +
                "s.valor " +
                "FROM tb_chamado_atendimento s " +
                "INNER JOIN tb_tecnico t ON s.codTecnico = t.codigo " +
                "INNER JOIN tb_chamado_atendimento_tipo p ON s.idTipoAtendimento = p.id " +
                "WHERE s.codChamado = '" + s.Chamado + "' " +
                "ORDER BY s.id DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoAtendimentoDTO> atendimento = new List<ChamadoAtendimentoDTO>();

            while (leitor.Read())
            {
                ChamadoAtendimentoDTO atd = new ChamadoAtendimentoDTO();

                atd.Id = leitor.GetInt32(0);
                atd.Chamado = leitor.GetString(1);
                atd.Tipo = leitor.GetString(2);
                atd.Tecnico = leitor.GetString(3);
                DateTime dataInicio = DateTime.Parse(leitor.GetString(4));
                atd.DataInicio = dataInicio.ToString("dd/MM/yyyy");
                DateTime horaInicio = DateTime.Parse(leitor.GetString(5));
                atd.HoraInicio = horaInicio.ToString("HH:mm:ss");
                atd.AtividadeRealizada = leitor.GetString(6);
                DateTime dataFinal = DateTime.Parse(leitor.GetString(7));
                atd.DataFinal = dataFinal.ToString("dd/MM/yyyy");
                DateTime horaFinal = DateTime.Parse(leitor.GetString(8));
                atd.HoraFinal = horaFinal.ToString("HH:mm:ss");
                atd.Valor = leitor.GetInt32(9) / 100;

                atendimento.Add(atd);
            }

            conexao.desconectar();
            cmd.Dispose();

            return atendimento;
        }

        public List<ChamadoAtendimentoDTO> SelecionarAtendimentoChamado(ChamadoAtendimentoDTO s)
        {
            cmd.CommandText = "SELECT " +
                "s.id, " +
                "s.codChamado, " +
                "p.tipo, " +
                "t.nomeCurto, " +
                "s.dataInicio, " +
                "s.horaInicio, " +
                "s.atividadeRealizada, " +
                "s.dataFinal, " +
                "s.horaFinal, " +
                "s.valor " +
                "FROM tb_chamado_atendimento s " +
                "INNER JOIN tb_tecnico t ON s.codTecnico = t.codigo " +
                "INNER JOIN tb_chamado_atendimento_tipo p ON s.idTipoAtendimento = p.id " +
                "WHERE s.id = " + s.Id;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoAtendimentoDTO> atendimento = new List<ChamadoAtendimentoDTO>();

            leitor.Read();

            atendimento.Add(new ChamadoAtendimentoDTO());

            atendimento[0].Id = leitor.GetInt32(0);
            atendimento[0].Chamado = leitor.GetString(1);
            atendimento[0].Tipo = leitor.GetString(2);
            atendimento[0].Tecnico = leitor.GetString(3);
            DateTime dataInicio = DateTime.Parse(leitor.GetString(4));
            atendimento[0].DataInicio = dataInicio.ToString("dd/MM/yyyy");
            DateTime horaInicio = DateTime.Parse(leitor.GetString(5));
            atendimento[0].HoraInicio = horaInicio.ToString("HH:mm:ss");
            atendimento[0].AtividadeRealizada = leitor.GetString(6);
            DateTime dataFinal = DateTime.Parse(leitor.GetString(7));
            atendimento[0].DataFinal = dataFinal.ToString("dd/MM/yyyy");
            DateTime horaFinal = DateTime.Parse(leitor.GetString(8));
            atendimento[0].HoraFinal = horaFinal.ToString("HH:mm:ss");
            atendimento[0].Valor = leitor.GetInt32(9) / 100;

            conexao.desconectar();
            cmd.Dispose();

            return atendimento;
        }
    }
}
