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
    class ChamadoMaterialBLL
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        public void CriarNovoMaterialChamado(ChamadoMaterialDTO m)
        {

        }

        //public Int32 ContarIdMaterialChamado()
        //{

        //}

        public void SalvarNovoMaterialChamado(ChamadoMaterialDTO m)
        {

        }

        public void EditarMaterialChamado(ChamadoMaterialDTO m)
        {

        }

        public void DeletarMaterialChamado(ChamadoMaterialDTO m)
        {

        }

        //public List<ChamadoMaterialDTO> ListarMaterialChamado(ChamadoMaterialDTO m)
        //{

        //}

        //public List<ChamadoMaterialDTO> SelecionarMaterialChamado(ChamadoMaterialDTO m)
        //{

        //}

    }
}
