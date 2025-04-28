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
    class ChamadoServicoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        ChamadoDTO chmDto = new ChamadoDTO();
        ChamadoBLL chmBll = new ChamadoBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();

        Int32 qtdIdServicoChamado;

        public void CriarNovoServicoChamado(ChamadoServicoDTO s)
        {
            this.ContarIdServicoChamado();

            if (qtdIdServicoChamado == 0)
            {
                s.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_chamado_servico";

                try
                {
                    cmd.Connection = conexao.conectar();
                    OleDbDataReader leitor = cmd.ExecuteReader();

                    leitor.Read();
                    s.Id = leitor.GetInt32(0);

                    conexao.desconectar();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public Int32 ContarIdServicoChamado()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_chamado_servico";

            try
            {
                cmd.Connection = conexao.conectar();
                OleDbDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdServicoChamado = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (OleDbException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdServicoChamado;
        }

        public void SalvarNovoServicoChamado(ChamadoServicoDTO s)
        {
            tecDto.Nome = s.Tecnico;
            tecBll.SelecionarCodigoTecnico(tecDto);

            cmd.CommandText = "INSERT INTO tb_chamado_servico (" +
                "id, " +
                "codChamado, " +
                "codTecnico, " +
                "dataInicio, " +
                "horaInicio, " +
                "atividadeRealizada, " +
                "dataFinal, " +
                "horaFinal, " +
                "valor) " +
                "VALUES (" +
                s.Id + ", '" +
                s.Chamado + "', '" +
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

        public void EditarServicoChamado(ChamadoServicoDTO s)
        {
            tecDto.Nome = s.Tecnico;
            tecBll.SelecionarCodigoTecnico(tecDto);

            cmd.CommandText = "UPDATE tb_chamado_servico SET " +
                "codChamado = '" + s.Chamado + "', " +
                "codTecnico = '" + tecDto.Codigo + "', " +
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

        public void DeletarServicoChamado(ChamadoServicoDTO s)
        {
            cmd.CommandText = "DELETE FROM tb_chamado_servico WHERE id = " + s.Id;

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

        public List<ChamadoServicoDTO> ListarServicoChamado(ChamadoServicoDTO s)
        {
            cmd.CommandText = "SELECT " +
                "s.id, " +
                "s.codChamado, " +
                "t.nomeCurto, " +
                "s.dataInicio, " +
                "s.horaInicio, " +
                "s.atividadeRealizada, " +
                "s.dataFinal, " +
                "s.horaFinal, " +
                "s.valor " +
                "FROM tb_chamado_servico s " +
                "INNER JOIN tb_tecnico t ON s.codTecnico = t.codigo " +
                "WHERE s.codChamado = '" + s.Chamado + "' " +
                "ORDER BY s.id DESC";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoServicoDTO> servico = new List<ChamadoServicoDTO>();

            while (leitor.Read())
            {
                ChamadoServicoDTO serv = new ChamadoServicoDTO();

                serv.Id = leitor.GetInt32(0);
                serv.Chamado = leitor.GetString(1);
                serv.Tecnico = leitor.GetString(2);
                DateTime dataInicio = DateTime.Parse(leitor.GetString(3));
                serv.DataInicio = dataInicio.ToString("dd/MM/yyyy");
                DateTime horaInicio = DateTime.Parse(leitor.GetString(4));
                serv.HoraInicio = horaInicio.ToString("HH:mm:ss");
                serv.AtividadeRealizada = leitor.GetString(5);
                DateTime dataFinal = DateTime.Parse(leitor.GetString(6));
                serv.DataFinal = dataFinal.ToString("dd/MM/yyyy");
                DateTime horaFinal = DateTime.Parse(leitor.GetString(7));
                serv.HoraFinal = horaFinal.ToString("HH:mm:ss");
                serv.Valor = leitor.GetInt32(8) / 100;

                servico.Add(serv);
            }

            conexao.desconectar();
            cmd.Dispose();

            return servico;
        }

        public List<ChamadoServicoDTO> SelecionarServicoChamado(ChamadoServicoDTO s)
        {
            cmd.CommandText = "SELECT " +
                "s.id, " +
                "s.codChamado, " +
                "t.nomeCurto, " +
                "s.dataInicio, " +
                "s.horaInicio, " +
                "s.atividadeRealizada, " +
                "s.dataFinal, " +
                "s.horaFinal, " +
                "s.valor " +
                "FROM tb_chamado_servico s " +
                "INNER JOIN tb_tecnico t ON s.codTecnico = t.codigo " +
                "WHERE s.codChamado = '" + s.Chamado + "'";

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();

            List<ChamadoServicoDTO> servico = new List<ChamadoServicoDTO>();

            leitor.Read();

            servico.Add(new ChamadoServicoDTO());

            servico[0].Id = leitor.GetInt32(0);
            servico[0].Chamado = leitor.GetString(1);
            servico[0].Tecnico = leitor.GetString(2);
            DateTime dataInicio = DateTime.Parse(leitor.GetString(3));
            servico[0].DataInicio = dataInicio.ToString("dd/MM/yyyy");
            DateTime horaInicio = DateTime.Parse(leitor.GetString(4));
            servico[0].HoraInicio = horaInicio.ToString("HH:mm:ss");
            servico[0].AtividadeRealizada = leitor.GetString(5);
            DateTime dataFinal = DateTime.Parse(leitor.GetString(6));
            servico[0].DataFinal = dataFinal.ToString("dd/MM/yyyy");
            DateTime horaFinal = DateTime.Parse(leitor.GetString(7));
            servico[0].HoraFinal = horaFinal.ToString("HH:mm:ss");
            servico[0].Valor = leitor.GetInt32(8) / 100;

            conexao.desconectar();
            cmd.Dispose();

            return servico;
        }

    }
}
