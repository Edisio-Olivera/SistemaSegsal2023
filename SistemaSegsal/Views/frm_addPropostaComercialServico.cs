using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.BLL;
using SistemaSegsal.DTO;

namespace SistemaSegsal.Views
{
    public partial class frm_addPropostaComercialServico : Form
    {
        ChamadoDTO chmDto = new ChamadoDTO();
        ChamadoBLL chmBll = new ChamadoBLL();

        PropostaComercialServicoDTO dto = new PropostaComercialServicoDTO();
        PropostaComercialServicoBLL bll = new PropostaComercialServicoBLL();

        PropostaComercialServicoTipoDTO tipDto = new PropostaComercialServicoTipoDTO();
        PropostaComercialServicoTipoBLL tipBll = new PropostaComercialServicoTipoBLL();


        private void PopularComboboxTipoServico()
        {
            List<PropostaComercialServicoTipoDTO> tip = tipBll.PopularComboboxPropostaComercialServicoTipo();

            this.cmb_tipoServico.DataSource = tip;
            this.cmb_tipoServico.DisplayMember = "tipoServico";
            this.cmb_tipoServico.Text = "";
        }

        private void PopularComboboxChamado()
        {
            List<ChamadoDTO> chm = chmBll.PopularComboboxChamado();

            this.cmb_chamado.DataSource = chm;
            this.cmb_chamado.DisplayMember = "codigo";
            this.cmb_chamado.Text = "";
        }







        public frm_addPropostaComercialServico()
        {
            InitializeComponent();
        }

        public frm_addPropostaComercialServico(Int32 id)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();

            this.PopularComboboxTipoServico();
        }

        private void frm_addPropostaComercialServico_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_tipoServico_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoServico.Text == "SistemaSegsal.DTO.PropostaComercialServicoTipoDTO")
            {
                return;
            }

            else
            {
                string tipoServico = this.cmb_tipoServico.Text;

                if (tipoServico == "Chamados")
                {
                    this.cmb_chamado.Visible = true;
                    this.txt_chamadoCliente.Visible = true;
                    this.lbl_chamadoCliente.Visible = true;
                    this.lbl_descricao.Text = "Chamados";
                    this.PopularComboboxChamado();
                    chmDto.Codigo = this.cmb_chamado.Text;
                    string codigo = this.cmb_chamado.Text;
                    //MessageBox.Show(codigo);
                    
                    //Verificar se já está em alguma proposta

                    //Selecionar chamado
                    //this.SelecionarChamado(codigo);
                    //Verificar se chamado tem chamadoCliente
                }
            }
        }

        private void cmb_chamado_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_chamado.Text == "SistemaSegsal.DTO.ChamadoDTO")
            {
                return;
            }

            else
            {
                chmDto.Codigo = this.cmb_chamado.Text;
                List<ChamadoDTO> chm = chmBll.SelecionarChamado(chmDto);


                this.txt_valorTotal.Text = chm[0].ValorTotal.ToString();

                string tipoServico = this.cmb_tipoServico.Text;

                
                
            }
        }
    }
}
