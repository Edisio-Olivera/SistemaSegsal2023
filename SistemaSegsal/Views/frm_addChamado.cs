using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.BLL;
using SistemaSegsal.DTO;
using SistemaSegsal.Views;

namespace SistemaSegsal.Views
{
    public partial class frm_addChamado : Form
    {
        ChamadoDTO dto = new ChamadoDTO();
        ChamadoBLL bll = new ChamadoBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        ClienteContatoDTO cntDto = new ClienteContatoDTO();
        ClienteContatoBLL cntBll = new ClienteContatoBLL();

        ChamadoAssuntoDTO assDto = new ChamadoAssuntoDTO();
        ChamadoAssuntoBLL assBll = new ChamadoAssuntoBLL();

        ChamadoSituacaoDTO sitDto = new ChamadoSituacaoDTO();
        ChamadoSituacaoBLL sitBll = new ChamadoSituacaoBLL();

        ChamadoUrgenciaDTO urgDto = new ChamadoUrgenciaDTO();
        ChamadoUrgenciaBLL urgBll = new ChamadoUrgenciaBLL();

        ChamadoStatusDTO staDto = new ChamadoStatusDTO();
        ChamadoStatusBLL staBll = new ChamadoStatusBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();

        Thread t1;

        string statusChamado = "Aberto";

        public static frm_addChamado calendInstancia;

        private void abrirFormListaChamado(object obj)
        {
            Application.Run(new frm_listaChamado(statusChamado));
        }

        private void SalvarChamado()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;
            dto.DataChamado = this.dtp_dataChamado.Value;            

            if (this.cmb_cliente.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cliente.Focus();
                return;
            }
            else
            {
                dto.Cliente = this.cmb_cliente.Text;
            }

            if (this.cmb_baseCliente.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_baseCliente.Focus();
                return;
            }
            else
            {
                dto.BaseCliente = this.cmb_baseCliente.Text;
            }

            if (this.cmb_solicitante.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Solicitante do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_solicitante.Focus();
                return;
            }
            else
            {
                dto.ContatoCliente = this.cmb_solicitante.Text;
            }

            if (this.txt_localSetor.Text == "")
            {
                MessageBox.Show("Por favor, digite o Local e o Setor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_localSetor.Focus();
                return;
            }
            else
            {
                dto.LocalSetor = this.txt_localSetor.Text;
            }

            if (this.txt_equipamento.Text == "")
            {
                MessageBox.Show("Por favor, Digite um Equipamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_equipamento.Focus();
                return;
            }
            else
            {
                dto.Equipamento = this.txt_equipamento.Text;
            }

            if (this.cmb_assunto.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Assunto!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_assunto.Focus();
                return;
            }
            else
            {
                dto.Assunto = this.cmb_assunto.Text;
            }

            if (this.cmb_situacao.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Situação!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_situacao.Focus();
                return;
            }
            else
            {
                dto.Situacao = this.cmb_situacao.Text;
            }

            if (this.cmb_urgencia.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Urgência!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_urgencia.Focus();
                return;
            }
            else
            {
                dto.Urgencia = this.cmb_urgencia.Text;
            }

            if (this.txt_informacao.Text == "")
            {
                dto.InformacaoCliente = "-";
            }
            else
            {
                dto.InformacaoCliente = this.txt_informacao.Text;
            }

            if (this.txt_diagnostico.Text == "")
            {
                dto.Diagnostico = "-";
            }
            else
            {
                dto.Diagnostico = this.txt_diagnostico.Text;
            }

            if (this.txt_solucao.Text == "")
            {
                dto.Solucao = "-";
            }
            else
            {
                dto.Solucao = this.txt_solucao.Text;
            }

            DateTime dataFinal = new DateTime(1901, 1, 1);
            dto.DataFinal = dataFinal;
            dto.Proposta = "-";
            dto.ValorTotal = 0;
            dto.Status = "Aberto";

            bll.SalvarChamado(dto);

            MessageBox.Show("Chamado Cadastrado com sucesso!", "Cadastrar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormListaChamado);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void EditarChamado()
        {
            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_chamadoCliente.Enabled = true;
            this.txt_dataChamado.Enabled = true;
            this.cmb_cliente.Enabled = true;
            this.cmb_baseCliente.Enabled = true;
            this.cmb_solicitante.Enabled = true;
            this.txt_localSetor.Enabled = true;
            this.txt_equipamento.Enabled = true;
            this.cmb_assunto.Enabled = true;
            this.cmb_situacao.Enabled = true;
            this.cmb_urgencia.Enabled = true;
            this.txt_informacao.Enabled = true;
            this.txt_diagnostico.Enabled = true;
            this.txt_solucao.Enabled = true;

            this.txt_valor.Enabled = true;
            this.txt_dataFinal.Enabled = true;
            this.txt_status.Enabled = false;

            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_atualizar.Visible = true;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_atualizar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
        }
        
        private void AtualizarChamado()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;
            dto.DataChamado = this.dtp_dataChamado.Value;            

            if (this.cmb_cliente.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cliente.Focus();
                return;
            }
            else
            {
                dto.Cliente = this.cmb_cliente.Text;
            }

            if (this.cmb_baseCliente.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_baseCliente.Focus();
                return;
            }
            else
            {
                dto.BaseCliente = this.cmb_baseCliente.Text;
            }

            if (this.cmb_solicitante.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Solicitante do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_solicitante.Focus();
                return;
            }
            else
            {
                dto.ContatoCliente = this.cmb_solicitante.Text;
            }

            if (this.txt_localSetor.Text == "")
            {
                MessageBox.Show("Por favor, digite o Local e o Setor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_localSetor.Focus();
                return;
            }
            else
            {
                dto.LocalSetor = this.txt_localSetor.Text;
            }

            if (this.cmb_assunto.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Assunto!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_assunto.Focus();
                return;
            }
            else
            {
                dto.Assunto = this.cmb_assunto.Text;
            }

            if (this.cmb_urgencia.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Urgência!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_urgencia.Focus();
                return;
            }
            else
            {
                dto.Urgencia = this.cmb_urgencia.Text;
            }

            if (this.txt_informacao.Text == "")
            {
                dto.InformacaoCliente = "-";
            }
            else
            {
                dto.InformacaoCliente = this.txt_informacao.Text;
            }

            if (this.txt_diagnostico.Text == "")
            {
                dto.Diagnostico = "-";
            }
            else
            {
                dto.Diagnostico = this.txt_diagnostico.Text;
            }

            if (this.txt_solucao.Text == "")
            {
                dto.Solucao = "-";
            }
            else
            {
                dto.Solucao = this.txt_solucao.Text;
            }

            dto.ValorTotal = 0;

            bll.EditarChamado(dto);

            MessageBox.Show("Chamado Atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormListaChamado);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void PopularComboboxCliente()
        {
            List<ClienteDTO> cliente = cliBll.PopularComboboxCliente();

            this.cmb_cliente.DataSource = cliente;
            this.cmb_cliente.DisplayMember = "nomeFantasia";

            this.cmb_cliente.SelectedIndex = -1;
        }

        private void PopularComboboxBaseCliente(string cliente)
        {
            basDto.Cliente = cliente;

            List<BaseClienteDTO> baseCli = basBll.PopularComboboxBaseCliente(basDto);

            this.cmb_baseCliente.Enabled = true;
            //this.btn_addBaseCliente.Enabled = true;
            this.cmb_baseCliente.DataSource = baseCli;
            this.cmb_baseCliente.DisplayMember = "nomeBase";

            this.cmb_baseCliente.SelectedIndex = -1;
        }

        private void PopularComboboxContatoCliente(string cliente)
        {
            cntDto.Cliente = cliente;

            List<ClienteContatoDTO> contato = cntBll.PopularComboboxContatoCliente(cntDto);

            this.cmb_solicitante.Enabled = true;
            this.cmb_solicitante.DataSource = contato;
            this.cmb_solicitante.DisplayMember = "nome";

            this.cmb_solicitante.SelectedIndex = -1;
        }

        private void PopularComboboxAssunto()
        {
            List<ChamadoAssuntoDTO> assunto = assBll.PopularComboboxAssunto();

            this.cmb_assunto.DataSource = assunto;
            this.cmb_assunto.DisplayMember = "assunto";

            this.cmb_assunto.SelectedIndex = -1;
        }

        private void PopularComboboxSituacao()
        {
            List<ChamadoSituacaoDTO> situacao = sitBll.PopularComboboxSituacao();

            this.cmb_situacao.DataSource = situacao;
            this.cmb_situacao.DisplayMember = "situacao";

            this.cmb_situacao.SelectedIndex = -1;
        }

        private void PopularComboboxUrgencia()
        {
            List<ChamadoUrgenciaDTO> urgencia = urgBll.PopularComboboxUrgencia();

            this.cmb_urgencia.DataSource = urgencia;
            this.cmb_urgencia.DisplayMember = "urgencia";

            this.cmb_urgencia.SelectedIndex = -1;
        }
                
        public void CaptarDataChamado(string dataChamado)
        {
            this.txt_dataChamado.Text = dataChamado;
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                t1 = new Thread(abrirFormListaChamado);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        public frm_addChamado()
        {
            InitializeComponent();

            calendInstancia = this;
        }

        //Criar Chamado
        public frm_addChamado(Int32 id, string codigo)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_dataChamado.Enabled = true;
            this.cmb_cliente.Enabled = true;
            this.cmb_baseCliente.Enabled = false;
            this.cmb_solicitante.Enabled = false;
            this.txt_localSetor.Enabled = true;
            this.txt_equipamento.Enabled = true;
            this.cmb_assunto.Enabled = true;
            this.cmb_situacao.Enabled = true;
            this.cmb_urgencia.Enabled = true;
            this.txt_informacao.Enabled = true;

            this.txt_diagnostico.Enabled = false;
            this.txt_solucao.Enabled = false;

            this.txt_valor.Enabled = false;
            this.txt_dataFinal.Enabled = false;
            this.txt_status.Enabled = false;

            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_sair.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_editar.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.PopularComboboxCliente();
            this.PopularComboboxAssunto();
            this.PopularComboboxSituacao();
            this.PopularComboboxUrgencia();
        }

        //Editar Chamado
        public frm_addChamado(string codigo)
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<ChamadoDTO> chm =  bll.SelecionarChamado(dto);

            this.txt_id.Text = chm[0].Id.ToString();
            this.txt_codigo.Text = chm[0].Codigo;
            this.txt_dataChamado.Text = chm[0].DataChamado.ToString();
            this.PopularComboboxCliente();
            this.cmb_cliente.Text = chm[0].Cliente;
            this.cmb_baseCliente.Text = chm[0].BaseCliente;
            this.cmb_solicitante.Text = chm[0].ContatoCliente;
            this.txt_localSetor.Text = chm[0].LocalSetor;
            this.txt_equipamento.Text = chm[0].Equipamento;
            this.PopularComboboxAssunto();
            this.cmb_assunto.Text = chm[0].Assunto;
            this.PopularComboboxSituacao();
            this.cmb_situacao.Text = chm[0].Situacao;
            this.PopularComboboxUrgencia();
            this.cmb_urgencia.Text = chm[0].Urgencia;
            this.txt_informacao.Text = chm[0].InformacaoCliente;
            this.txt_diagnostico.Text = chm[0].Diagnostico;
            this.txt_solucao.Text = chm[0].Solucao;
            this.txt_valor.Text = chm[0].ValorTotal.ToString("#,##0.00");
            this.txt_status.Text = chm[0].Status;

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_chamadoCliente.Enabled = false;
            this.txt_dataChamado.Enabled = false;
            this.cmb_cliente.Enabled = false;
            this.cmb_baseCliente.Enabled = false;
            this.cmb_solicitante.Enabled = false;
            this.txt_localSetor.Enabled = false;
            this.txt_equipamento.Enabled = false;
            this.cmb_assunto.Enabled = false;
            this.cmb_situacao.Enabled = false;
            this.cmb_urgencia.Enabled = false;
            this.txt_informacao.Enabled = false;
            this.txt_diagnostico.Enabled = false;
            this.txt_solucao.Enabled = false;

            this.txt_valor.Enabled = false;
            this.txt_dataFinal.Enabled = false;
            this.txt_status.Enabled = false;

            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_atualizar.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
        }

        //Iniciar Chamado
        public frm_addChamado(string codigo, Int32 id)
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<ChamadoDTO> chm = bll.SelecionarChamado(dto);

            this.txt_id.Text = chm[0].Id.ToString();
            this.txt_codigo.Text = chm[0].Codigo;
            this.txt_dataChamado.Text = chm[0].DataChamado.ToString();
            this.PopularComboboxCliente();
            this.cmb_cliente.Text = chm[0].Cliente;
            this.cmb_baseCliente.Text = chm[0].BaseCliente;
            this.cmb_solicitante.Text = chm[0].ContatoCliente;
            this.txt_localSetor.Text = chm[0].LocalSetor;
            this.txt_equipamento.Text = chm[0].Equipamento;
            this.PopularComboboxAssunto();
            this.cmb_assunto.Text = chm[0].Assunto;
            this.PopularComboboxSituacao();
            this.cmb_situacao.Text = chm[0].Situacao;
            this.PopularComboboxUrgencia();
            this.cmb_urgencia.Text = chm[0].Urgencia;
            this.txt_informacao.Text = chm[0].InformacaoCliente;

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_chamadoCliente.Enabled = false;
            this.txt_dataChamado.Enabled = false;
            this.cmb_cliente.Enabled = false;
            this.cmb_baseCliente.Enabled = false;
            this.cmb_solicitante.Enabled = false;
            this.txt_localSetor.Enabled = false;
            this.txt_equipamento.Enabled = false;
            this.cmb_assunto.Enabled = false;
            this.cmb_situacao.Enabled = false;
            this.cmb_urgencia.Enabled = false;
            this.txt_informacao.Enabled = false;
            this.txt_diagnostico.Enabled = true;
            this.txt_solucao.Enabled = true;

            this.txt_valor.Enabled = false;
            this.txt_dataFinal.Enabled = false;
            this.txt_status.Enabled = false;

            this.btn_editar.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_sair.Visible = false;
            this.btn_atualizar.Visible = true;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
        }

        private void frm_addChamado_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calendarioChamadoInicio dataChamado = new calendarioChamadoInicio();
            dataChamado.Visible = true;
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_cliente.Text == "SistemaSegsal.DTO.ClienteDTO")
            {
                return;
            }
            else
            {
                if(this.cmb_cliente.SelectedIndex == -1)
                {
                    return;                    
                }
                else
                {
                    string cliente = this.cmb_cliente.Text;

                    this.PopularComboboxBaseCliente(cliente);
                    this.PopularComboboxContatoCliente(cliente);
                    this.cmb_baseCliente.Focus();
                }             
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarChamado();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarChamado();
        }

        private void btn_salvarFormProposta_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarChamado();
        }
    }
}
