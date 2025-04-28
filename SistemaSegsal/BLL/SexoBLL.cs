using System;
using System.Collections.Generic;
using SistemaSegsal.DTO;
using SistemaSegsal.DAO;
using System.Windows.Forms;
using System.Data.OleDb;

namespace SistemaSegsal.BLL
{
    internal class SexoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        string tabela = "tb_sexo";

        public List<SexoDTO> PopularComboboxSexo()
        {
            cmd.CommandText = "SELECT sexo FROM " + tabela;

            cmd.Connection = conexao.conectar();
            OleDbDataReader leitor = cmd.ExecuteReader();
            List<SexoDTO> sexo = new List<SexoDTO>();

            while (leitor.Read())
            {
                SexoDTO sx = new SexoDTO();
                sx.Sexo = leitor.GetString(0);
                sexo.Add(sx);
            }

            conexao.desconectar();
            cmd.Dispose();

            return sexo;
        }

        public Int32 SelecionarIdSexo(SexoDTO s)
        {
            cmd.CommandText = "SELECT id FROM " + tabela +
                "WHERE sexo = '" + s.Sexo + "'";

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

            return s.Id;
        }
    }
}
