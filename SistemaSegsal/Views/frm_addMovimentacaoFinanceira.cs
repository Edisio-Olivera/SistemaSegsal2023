using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.Views;

namespace SistemaSegsal.Views
{
    public partial class frm_addMovimentacaoFinanceira : Form
    {
        PropostaComercialDTO dto = new PropostaComercialDTO();
        PropostaComercialBLL bll = new PropostaComercialBLL();

        PropostaComercialServicoDTO serDto = new PropostaComercialServicoDTO();
        PropostaComercialServicoBLL serBll = new PropostaComercialServicoBLL();

        PropostaComercialStatusDTO stDto = new PropostaComercialStatusDTO();
        PropostaComercialStatusBLL stBll = new PropostaComercialStatusBLL();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        CondicaoPgtoDTO cpDto = new CondicaoPgtoDTO();
        CondicaoPgtoBLL cpBll = new CondicaoPgtoBLL();

        FormaPgtoDTO fpDto = new FormaPgtoDTO();
        FormaPgtoBLL fpBll = new FormaPgtoBLL();

        public frm_addMovimentacaoFinanceira()
        {
            InitializeComponent();
        }        

        private void btn_aumentar_Click(object sender, EventArgs e)
        {
            Int32 qtdParcela = Int32.Parse(this.txt_qtdParcela.Text);

            this.txt_qtdParcela.Text = (qtdParcela + 1).ToString();
        }

        private void btn_diminuir_Click(object sender, EventArgs e)
        {
            Int32 qtdParcela = Int32.Parse(this.txt_qtdParcela.Text);

            if(qtdParcela <= 2)
            {
                return;
            }
            else
            {
                this.txt_qtdParcela.Text = (qtdParcela - 1).ToString();
            }            
        }

        private void frm_addMovimentacaoFinanceira_Load(object sender, EventArgs e)
        {
            this.txt_qtdParcela.Text = "2";
        }
    }
}
