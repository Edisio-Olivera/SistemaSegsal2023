using SistemaSegsal.BLL;
using SistemaSegsal.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSegsal.Views
{
    public partial class frm_listaContasReceber : Form
    {
        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBLL = new EmpresaBLL();   

        MovimentacaoDTO dto = new MovimentacaoDTO();
        MovimentacaoBLL bll = new MovimentacaoBLL();

        string nomeEmpresa;

        private string dadosEmpresa()
        {
            List<EmpresaDTO> emp = empBLL.SelecionarEmpresa();

            nomeEmpresa = emp[0].NomeFantasia;

            return nomeEmpresa;
        }





        public frm_listaContasReceber()
        {
            InitializeComponent();
        }

        private void frm_listaContasReceber_Load(object sender, EventArgs e)
        {
            this.dadosEmpresa();
            this.Text = "Gestão Empresa V. 1.0 - " + nomeEmpresa + " - Financeiro: Contas a Receber"; 




            this.lvw_listaContasReceber.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaContasReceber.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaContasReceber.Columns.Add("Data Registro", 100).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaContasReceber.Columns.Add("Tipo", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaContasReceber.Columns.Add("Fornecedor", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContasReceber.Columns.Add("Equipamento", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContasReceber.Columns.Add("Assunto", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContasReceber.Columns.Add("Situação-Urgência", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContasReceber.Columns.Add("Valor Total", 120).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaContasReceber.Columns.Add("Status", 80).TextAlign = HorizontalAlignment.Left;

        }
    }
}
