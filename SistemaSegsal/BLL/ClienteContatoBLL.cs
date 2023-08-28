using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaSegsal.BLL
{
    class ClienteContatoBLL
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        DepartamentoDTO depDto = new DepartamentoDTO();
        DepartamentoBLL depBll = new DepartamentoBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        ClienteContatoStatusDTO ccsDto = new ClienteContatoStatusDTO();
        ClienteContatoStatusBLL ccsBll = new ClienteContatoStatusBLL();

        Int32 qtdIdContatoCliente;

        public void CriarNovoContato(ClienteContatoDTO c)
        {
            this.ContarIdContatoCliente();

            if (qtdIdContatoCliente == 0)
            {
                c.Id = 1;
            }
            else
            {
                cmd.CommandText = "SELECT MAX(id) AS MAIOR FROM tb_cliente_contato";

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

        public Int32 ContarIdContatoCliente()
        {
            cmd.CommandText = "SELECT COUNT(id) FROM tb_cliente_contato";

            try
            {
                cmd.Connection = conexao.conectar();
                MySqlDataReader leitor = cmd.ExecuteReader();

                leitor.Read();
                qtdIdContatoCliente = leitor.GetInt32(0);

                conexao.desconectar();
                cmd.Dispose();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro ao conectar ao banco de Dados! " + ex, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return qtdIdContatoCliente;
        }

        public void SalvarContatoCliente(ClienteContatoDTO c)
        {            
            cliDto.NomeFantasia = c.Cliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            depDto.Departamento = c.Departamento;
            depBll.SelecionarIdDepartamento(depDto);

            ccsDto.Status = c.Status;
            ccsBll.SelecionarIdStatusContato(ccsDto);

            cmd.CommandText = "INSERT INTO tb_cliente_contato (" +
                "id, " +
                "codCliente, " +
                "nome, " +
                "telefone, " +
                "email, " +
                "idDepartamento, " +
                "idStatusContato) " +
                "VALUES (" +
                c.Id + ", '" +
                cliDto.Codigo + "', '" +
                c.Nome + "', '" +
                c.Telefone + "', '" +
                c.Email + "', " +
                depDto.Id + ", " +
                ccsDto.Id + ")";

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

        public void EditarContatoCliente(ClienteContatoDTO c)
        {
            cliDto.NomeFantasia = c.Cliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            depDto.Departamento = c.Departamento;
            depBll.SelecionarIdDepartamento(depDto);

            ccsDto.Status = c.Status;
            ccsBll.SelecionarIdStatusContato(ccsDto);

            cmd.CommandText = "UPDATE tb_cliente_contato SET " +
                "codCliente = '" + cliDto.Codigo + "', " +
                "nome = '" + c.Nome + "', " +
                "telefone = '" + c.Telefone + "', " +
                "email = '" + c.Email + "', " +
                "idDepartamento = " + depDto.Id + ", " +
                "idStatusContato = " + ccsDto.Id + " " +
                "WHERE id = " + c.Id;

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

        public void ExcluirContatoCliente(ClienteContatoDTO c)
        {
            cmd.CommandText = "DELETE FROM tb_cliente_contato " +
                "WHERE id = " + c.Id;

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

        public List<ClienteContatoDTO> ListarContatoCliente(ClienteContatoDTO c)
        {
            cliDto.NomeFantasia = c.Cliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            cmd.CommandText = "SELECT " +
                "cc.id, " +
                "cl.nomeFantasia, " +
                "cc.nome, " +
                "cc.telefone, " +
                "cc.email, " +
                "dp.departamento, " +
                "st.statusContato " +
                "FROM tb_cliente_contato cc " +
                "INNER JOIN tb_cliente cl ON cc.codCliente = cl.codigo " +
                "INNER JOIN tb_cliente_contato_departamento dp ON cc.idDepartamento = dp.id " +
                "INNER JOIN tb_cliente_contato_status st ON cc.idStatusContato = st.id " +
                "WHERE cc.codCliente = '" + cliDto.Codigo + "' " +
                "ORDER BY cc.id ASC";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<ClienteContatoDTO> contato = new List<ClienteContatoDTO>(7);

            while (leitor.Read())
            {
                ClienteContatoDTO cont = new ClienteContatoDTO();

                cont.Id = leitor.GetInt32(0);
                cont.Cliente = leitor.GetString(1);
                cont.Nome = leitor.GetString(2);
                cont.Telefone = leitor.GetString(3);
                cont.Email = leitor.GetString(4);
                cont.Departamento = leitor.GetString(5);
                cont.Status = leitor.GetString(6);

                contato.Add(cont);
            }

            conexao.desconectar();
            cmd.Dispose();

            return contato;
        }

        public List<ClienteContatoDTO> SelecionarContatoCliente(ClienteContatoDTO c)
        {
            cmd.CommandText = "SELECT " +
                "cc.id, " +
                "cl.nomeFantasia, " +
                "cc.nome, " +
                "cc.telefone, " +
                "cc.email, " +
                "dp.departamento, " +
                "st.statusContato " +
                "FROM tb_cliente_contato cc " +
                "INNER JOIN tb_cliente cl ON cc.codCliente = cl.codigo " +
                "INNER JOIN tb_cliente_contato_departamento dp ON cc.idDepartamento = dp.id " +
                "INNER JOIN tb_cliente_contato_status st ON cc.idStatusContato = st.id " +
                "WHERE cc.id = " + c.Id;

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();

            List<ClienteContatoDTO> contato = new List<ClienteContatoDTO>(7);

            leitor.Read();

            contato.Add(new ClienteContatoDTO());

            contato[0].Id = leitor.GetInt32(0);
            contato[0].Cliente = leitor.GetString(1);
            contato[0].Nome = leitor.GetString(2);
            contato[0].Telefone = leitor.GetString(3);
            contato[0].Email = leitor.GetString(4);
            contato[0].Departamento = leitor.GetString(5);
            contato[0].Status = leitor.GetString(6);

            conexao.desconectar();
            cmd.Dispose();

            return contato;
        }

        public Int32 SelecionarIdContatoCliente(ClienteContatoDTO c)
        {
            cmd.CommandText = "SELECT id FROM tb_cliente_contato " +
                "WHERE nome = '" + c.Nome + "'";

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

            return c.Id;
        }

        public List<ClienteContatoDTO> PopularComboboxContatoCliente(ClienteContatoDTO c)
        {
            cliDto.NomeFantasia = c.Cliente;
            cliBll.SelecionarCodigoCliente(cliDto);

            cmd.CommandText = "SELECT nome FROM tb_cliente_contato " +
                "WHERE codCliente = '" + cliDto.Codigo + "'";

            cmd.Connection = conexao.conectar();
            MySqlDataReader leitor = cmd.ExecuteReader();
            List<ClienteContatoDTO> contato = new List<ClienteContatoDTO>();

            while (leitor.Read())
            {
                ClienteContatoDTO cl = new ClienteContatoDTO();
                cl.Nome = leitor.GetString(0);
                contato.Add(cl);
            }

            conexao.desconectar();
            cmd.Dispose();

            return contato;
        }
    }
}
