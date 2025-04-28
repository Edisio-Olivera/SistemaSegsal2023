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
using SistemaSegsal.View;
using System.Threading;

namespace SistemaSegsal.Views
{
    public partial class frm_addPropostaComercial : Form
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

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        public static frm_addPropostaComercial clientePropostaInstancia;

        Thread t1;

        private void abrirFormListaProposta(object obj)
        {
            Application.Run(new frm_listaPropostaComercial());
        }        

        private void SalvarProposta()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;

            if (this.dtp_dataProposta.Text == "")
            {
                MessageBox.Show("Por favor, Digite a Data da Proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtp_dataProposta.Focus();
                return;
            }
            else
            {
                dto.DataProposta = DateTime.Parse(this.dtp_dataProposta.Text);
            }

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

            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                dto.BaseCliente = this.cmb_base.Text;
            }

            if (this.txt_titulo.Text == "")
            {
                MessageBox.Show("Por favor, Digite um Título para a Proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_titulo.Focus();
                return;
            }
            else
            {
                dto.Titulo = this.txt_titulo.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                dto.Descricao = "-";
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }

            if (this.txt_observacao.Text == "")
            {
                dto.Observacao = "-";
            }
            else
            {
                dto.Observacao = this.txt_observacao.Text;
            }

            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Condição de Pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                dto.CondicaoPgto = this.cmb_condPgto.Text;
            }

            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Forma de Pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                dto.FormaPgto = this.cmb_formaPgto.Text;
            }

            dto.NotaFiscal = "-";
            dto.Valor = 0;
            dto.Status = "Criada";

            bll.SalvarPropostaComercial(dto);

            MessageBox.Show("Proposta Comercial Cadastrada com com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormListaProposta);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void EditarProposta()
        {
            //this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_atualizar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.dtp_dataProposta.Enabled = true;
            this.cmb_cliente.Enabled = true;
            this.btn_addCliente.Enabled = true;
            this.cmb_base.Enabled = true;
            this.btn_addBase.Enabled = true;
            this.txt_titulo.Enabled = true;
            this.txt_descricao.Enabled = true;
            this.txt_observacao.Enabled = true;
            this.cmb_condPgto.Enabled = true;
            this.cmb_formaPgto.Enabled = true;
            this.txt_valor.Enabled = false;
            this.txt_status.Enabled = false;

            this.cmb_cliente.Focus();

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.dtp_dataProposta.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_cliente.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_base.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_titulo.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_descricao.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_observacao.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_condPgto.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_formaPgto.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_valor.BackColor = Color.FromArgb(224, 224, 224);
            this.txt_status.BackColor = Color.FromArgb(224, 224, 224);
        }

        private void AtualizarProposta()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;

            if (this.dtp_dataProposta.Text == "")
            {
                MessageBox.Show("Por favor, Digite a Data da Proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.dtp_dataProposta.Focus();
                return;
            }
            else
            {
                dto.DataProposta = DateTime.Parse(this.dtp_dataProposta.Text);
            }

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

            if (this.cmb_base.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_base.Focus();
                return;
            }
            else
            {
                dto.BaseCliente = this.cmb_base.Text;
            }

            if (this.txt_titulo.Text == "")
            {
                MessageBox.Show("Por favor, Digite um Título para a proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_titulo.Focus();
                return;
            }
            else
            {
                dto.Titulo = this.txt_titulo.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                dto.Descricao = "-";
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }

            if (this.txt_observacao.Text == "")
            {
                dto.Observacao = "-";
            }
            else
            {
                dto.Observacao = this.txt_observacao.Text;
            }

            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Condição de Pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                dto.CondicaoPgto = this.cmb_condPgto.Text;
            }

            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, Selecione uma Forma de Pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                dto.FormaPgto = this.cmb_formaPgto.Text;
            }

            bll.EditarPropostaComercial(dto);

            MessageBox.Show("Proposta Comercial Atualizada com com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            this.Close();
            t1 = new Thread(abrirFormListaProposta);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void PopularComboboxCliente()
        {
            List<ClienteDTO> cliente = cliBll.PopularComboboxCliente();

            this.cmb_cliente.DataSource = cliente;
            this.cmb_cliente.DisplayMember = "nomeFantasia";
            this.cmb_cliente.ValueMember = "codigo";
            this.cmb_cliente.Text = "";
        }

        public void PopularComboboxBaseCliente(string cliente)
        {
            basDto.Cliente = cliente;

            List<BaseClienteDTO> baseCli = basBll.PopularComboboxBaseCliente(basDto);

            this.cmb_base.Enabled = true;
            this.cmb_base.DataSource = baseCli;
            this.cmb_base.DisplayMember = "nomeBase";
            this.cmb_base.Text = "";
        }

        private void PopularComboboxCondicaoPgto()
        {
            List<CondicaoPgtoDTO> condicao = cpBll.PopularComboboxCondicaoPgto();

            this.cmb_condPgto.DataSource = condicao;
            this.cmb_condPgto.DisplayMember = "condicaoPgto";
            this.cmb_condPgto.ValueMember = "id";
            this.cmb_condPgto.Text = "";
        }

        private void PopularComboboxFormaPgto(string condicao)
        {
            fpDto.CondicaoPgto = condicao;

            List<FormaPgtoDTO> forma = fpBll.PopularComboboxFormaPgto(fpDto);

            this.cmb_formaPgto.Enabled = true;
            this.cmb_formaPgto.DataSource = forma;
            this.cmb_formaPgto.DisplayMember = "formaPgto";

            this.cmb_formaPgto.Text = "";
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                t1 = new Thread(abrirFormListaProposta);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        private void SairFormulario()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                t1 = new Thread(abrirFormListaProposta);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }         

        private void CriarNovoCliente()
        {
            cliBll.CriarNovoCliente(cliDto);

            Int32 id = cliDto.Id + 1;
            string codigo = "CLI-" + id.ToString("000#");
            DateTime dataRegistro = DateTime.Now;

            frm_addCliente cli = new frm_addCliente(codigo, id, dataRegistro);
            cli.Visible = true;
        }

        public void CarregarDadosEmpresa()
        {
            List<EmpresaDTO> emp = empBll.SelecionarEmpresa();

            string logoEmpresa = emp[0].Logo;
            string nomeFantasia = emp[0].NomeFantasia;

            this.img_logoEmpresa.Image = Image.FromFile(Application.StartupPath + logoEmpresa);
            this.img_logoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Text = "Sistema de Gestão - " + nomeFantasia + " - v 1.0";
        }

        //==========================================================================================================================

        public frm_addPropostaComercial()
        {
            InitializeComponent();

            clientePropostaInstancia = this;
        }

        //Criar nova Proposta
        public frm_addPropostaComercial(Int32 id)
        {
            InitializeComponent();

            dto.Id = id;
            string codigo = id.ToString("0000#") + "-" + DateTime.Now.ToString("yyyy");
            string dataProposta = DateTime.Now.ToString("dd/MM/yyyy");

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            this.dtp_dataProposta.Text = dataProposta;

            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_salvar.Visible = true;
            this.btn_sair.Visible = false;            

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.dtp_dataProposta.Enabled = false;

            this.PopularComboboxCliente();
            this.cmb_cliente.SelectedIndex = -1;

            this.cmb_cliente.Enabled = true;
            this.cmb_base.Enabled = false;
            this.txt_titulo.Enabled = true;
            this.txt_descricao.Enabled = true;
            this.txt_observacao.Enabled = true;

            this.PopularComboboxCondicaoPgto();
            this.cmb_condPgto.SelectedIndex = -1;

            this.cmb_condPgto.Enabled = true;
            this.cmb_formaPgto.Enabled = false;
            this.txt_valor.Enabled = false;
            this.txt_status.Enabled = false;

            this.cmb_cliente.Focus();

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.dtp_dataProposta.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_cliente.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_base.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_titulo.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_descricao.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_observacao.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_condPgto.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_formaPgto.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_valor.BackColor = Color.FromArgb(224, 224, 224);
            this.txt_status.BackColor = Color.FromArgb(224, 224, 224);
        }

        //Editar Proposta
        public frm_addPropostaComercial(string codigo)
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<PropostaComercialDTO> prop = bll.SelecionarPropostaComercial(dto);

            //this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.txt_id.Text = prop[0].Id.ToString();
            this.txt_codigo.Text = codigo;
            this.dtp_dataProposta.Text = prop[0].DataProposta.ToString("dd/MM/yyyy");

            this.PopularComboboxCliente();

            this.cmb_cliente.Text = prop[0].Cliente;
            this.btn_addCliente.Enabled = false;
            this.cmb_base.Text = prop[0].BaseCliente;
            this.btn_addBase.Enabled = false;
            this.txt_titulo.Text = prop[0].Titulo;
            this.txt_descricao.Text = prop[0].Descricao;
            this.txt_observacao.Text = prop[0].Observacao;

            this.PopularComboboxCondicaoPgto();

            this.cmb_condPgto.Text = prop[0].CondicaoPgto;
            this.cmb_formaPgto.Text = prop[0].FormaPgto;
            this.txt_valor.Text = prop[0].Valor.ToString();
            this.txt_status.Text = prop[0].Status;
           
            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.dtp_dataProposta.Enabled = false;
            this.cmb_cliente.Enabled = false;
            this.cmb_base.Enabled = false;
            this.txt_titulo.Enabled = false;
            this.txt_descricao.Enabled = false;
            this.txt_observacao.Enabled = false;
            this.cmb_condPgto.Enabled = false;
            this.cmb_formaPgto.Enabled = false;
            this.txt_valor.Enabled = false;
            this.txt_status.Enabled = false;

            this.Text = "Editar Proposta Comercial";
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void frm_addPropostaComercial_Load(object sender, EventArgs e)
        {
            //this.cmb_cliente.Text = "";
            //this.cmb_condPgto.Text = "";
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
                    this.btn_addBase.Enabled = true;
                    this.cmb_base.Enabled = true;
                    this.cmb_base.Focus();
                }                
            }
        }

        private void cmb_condPgto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_condPgto.Text == "SistemaSegsal.DTO.CondicaoPgtoDTO")
            {
                return;
            }
            else
            {
                if(this.cmb_condPgto.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    string condicao = this.cmb_condPgto.Text;

                    this.PopularComboboxFormaPgto(condicao);

                    this.cmb_condPgto.Enabled = true;
                    this.cmb_condPgto.Focus();
                }                
            }
        }

        private void btn_cabcelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            //this.CriarNovaProposta();
        }

        private void btn_dataProposta_Click(object sender, EventArgs e)
        {
            this.dtp_dataProposta.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarProposta();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarProposta();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarProposta();
        }

        private void btn_addCliente_Click(object sender, EventArgs e)
        {
            //this.CriarNovoCliente();
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
