﻿using System;
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
    class ChamadoFotoBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        public void CriarNovoFotoChamado(ChamadoFotoDTO c)
        {

        }

        //public Int32 ContarIdFotoChamado()
        //{

        //}

        public void SalvarNovoFotoChamado(ChamadoFotoDTO c)
        {

        }

        public void EditarFotoChamado(ChamadoFotoDTO c)
        {

        }

        public void DeletarFotoChamado(ChamadoFotoDTO c)
        {

        }

        //public List<ChamadoFotoDTO> ListarFotoChamado(ChamadoFotoDTO c)
        //{

        //}

        //public List<ChamadoFotoDTO> SelecionarFotoChamado(ChamadoFotoDTO c)
        //{

        //}
    }
}
