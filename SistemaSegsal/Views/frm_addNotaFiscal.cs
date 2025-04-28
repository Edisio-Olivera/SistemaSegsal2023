using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using SistemaSegsal.View;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using System.IO;
using System.Threading;

namespace SistemaSegsal.Views
{
    public partial class frm_addNotaFiscal : Form
    {
        NotaFiscalDTO ntaDto = new NotaFiscalDTO();
        NotaFiscalBLL ntaBll = new NotaFiscalBLL();

        NotaFiscalTipoDTO tipDto = new NotaFiscalTipoDTO();
        NotaFiscalTipoBLL tipBll = new NotaFiscalTipoBLL();

        NotaFiscalStatusDTO staDto = new NotaFiscalStatusDTO();
        NotaFiscalStatusBLL staBll = new NotaFiscalStatusBLL();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        PropostaComercialDTO comDto = new PropostaComercialDTO();
        PropostaComercialBLL comBll = new PropostaComercialBLL();

        MovimentacaoDTO movDto = new MovimentacaoDTO();
        MovimentacaoBLL movBll = new MovimentacaoBLL();

        CondicaoPgtoDTO conDto = new CondicaoPgtoDTO();
        CondicaoPgtoBLL conBll = new CondicaoPgtoBLL();

        FormaPgtoDTO frmDto = new FormaPgtoDTO();
        FormaPgtoBLL frmBll = new FormaPgtoBLL();

        Thread t1;

        Int32 idNotaFiscal;
        string codigoNotaFiscal;
        DateTime dataEmissaoNotaFiscal;
        string tipoNotaFiscal;
        string clienteNotaFiscal;
        string baseClienteNotaFiscal;
        string codigoVerificacaoNotaFiscal;
        string competenciaNotaFiscal;
        string descricaoNotaFiscal;
        string numeroPedidoNotaFiscal;
        string condPgtoNotaFiscal;
        string formaPgtoNotaFiscal;
        Int32 valorNotaFiscal;
        string arquivoNotaFiscal = @"\Documentos\NotaFiscal\";
        string statusNotaFiscal;


        private void abrirFormListaNotaFiscal(object obj)
        {
            Application.Run(new frm_listaNotaFiscal());
        }

        private void SalvarNotaFiscal()
        {
            ntaDto.Id = Int32.Parse(this.txt_id.Text);
            ntaDto.Codigo = this.txt_codigo.Text;
            ntaDto.DataEmissao = this.dtp_dataEmissao.Value;
            
            if (this.txt_diasReceber.Text == "")
            {
                ntaDto.DataRecebimento = ntaDto.DataEmissao.AddDays(30);
                //MessageBox.Show("Por favor, digite o número de Dias a Receber!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //this.txt_diasReceber.Focus();
                //return;
            }
            else
            {
                ntaDto.DataRecebimento = ntaDto.DataEmissao.AddDays(30);
                //Int32 diasPgto = Int32.Parse(this.txt_diasReceber.Text);
                //DateTime dataEmissaoForm = DateTime.Parse(dataEmissao);
                //DateTime dataRecebimento = dataEmissaoForm.AddDays(diasPgto);
                //ntaDto.DataRecebimento = dataRecebimento;
            }

            if (this.cmb_tipoNotaFiscal.Text == "")
            {
                MessageBox.Show("Por favor, selecione um Tipo de Nota Fiscal!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoNotaFiscal.Focus();
                return;
            }
            else
            {
                ntaDto.TipoNotaFiscal = this.cmb_tipoNotaFiscal.Text;
            }

            if (this.cmb_cliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione um Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cliente.Focus();
                return;
            }
            else
            {
                ntaDto.Cliente = this.cmb_cliente.Text;
            }

            if (this.cmb_baseCliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma Base para o Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_baseCliente.Focus();
                return;
            }
            else
            {
                ntaDto.BaseCliente = this.cmb_baseCliente.Text;
            }

            if (this.txt_verificacao.Text == "")
            {
                ntaDto.CodigoVerificacao = "-";
            }
            else
            {
                ntaDto.CodigoVerificacao = this.txt_verificacao.Text;
            }

            string competencia = this.dtp_dataEmissao.Text;
            string[] comp = competencia.Split('/');
            ntaDto.Competencia = comp[1] + "/" + comp[2];

            if (this.txt_pedido.Text == "")
            {
                ntaDto.NumeroPedido = "-";
            }
            else
            {
                ntaDto.NumeroPedido = this.txt_pedido.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Por favor, digite uma Descrição do Serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                ntaDto.Servico = this.txt_descricao.Text;
            }

            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma condição de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                ntaDto.CondPgto = this.cmb_condPgto.Text;
            }

            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                ntaDto.FormaPgto = this.cmb_formaPgto.Text;
            }

            if (this.txt_valor.Text == "")
            {
                MessageBox.Show("Por favor, digite o Valor da Nota Fiscal!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valor.Focus();
                return;
            }
            else
            {
                ntaDto.Valor = Int32.Parse(this.txt_valor.Text);
            }

            ntaDto.Status = "A Receber";
            ntaDto.Arquivo = @"\Documentos\NotaFiscal\" + ntaDto.Codigo + ".pdf";

            //Salvar Nota Fiscal
            ntaBll.SalvarNotaFiscal(ntaDto);

            //Vincular Nota Fiscal à Proposta Comercial
            this.VincularNotaPropsta(ntaDto.Codigo);

            //Salvar Contas a Receber
            this.SalvarEntradaMovimentacao(ntaDto.DataEmissao, ntaDto.Cliente, ntaDto.Codigo, ntaDto.CondPgto, ntaDto.FormaPgto, ntaDto.DataRecebimento, ntaDto.Valor);

            MessageBox.Show("Nota fiscal fadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormListaNotaFiscal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void VincularNotaPropsta(string codigoProposta)
        {
            comDto.Codigo = codigoProposta;
            comDto.Status = "A Receber";

            comBll.VincularNotaFiscalProposta(comDto);
        }

        private void SalvarEntradaMovimentacao(DateTime dataEmissao, string cliente, string descricao, string condPgto, string formaPgto, DateTime vencimento, Int32 valor)
        {
            movBll.CriarNovoMovimentacao(movDto);

            movDto.Id = movDto.Id;
            movDto.DataRegistro = DateTime.Now;
            movDto.Conta = "Emp. Inter";
            movDto.FornecedorCliente = cliente;
            movDto.TipoMovimentacao = "E";
            movDto.DataTransacao = dataEmissao;
            movDto.Descricao = descricao;
            movDto.CondPgto = condPgto;
            movDto.FormaPgto = formaPgto;
            movDto.ValorTransacao = valor;
            movDto.QtdParcela = 1;
            movDto.Parcela = "1 de 1";
            movDto.ValorParcela = valor;
            movDto.DataVencimento = vencimento;
            DateTime dataPgto = new DateTime(2000, 1, 1);
            movDto.DataPgtoReceb = dataPgto;
            movDto.DescJuros = 0;
            movDto.ValorTotal = valor;
            movDto.Status = "A Receber";

            movBll.SalvarMovimentacaoEntrada(movDto);
        }

        private void PopularComboboxTipoNotaFiscal()
        {
            List<NotaFiscalTipoDTO> tipoNf = tipBll.PopularComboboxNotaFiscalTipo();

            this.cmb_tipoNotaFiscal.DataSource = tipoNf;
            this.cmb_tipoNotaFiscal.DisplayMember = "tipoNotaFiscal";
            this.cmb_tipoNotaFiscal.SelectedIndex = -1;
        }

        private void PopularComboboxCliente()
        {
            List<ClienteDTO> cli = cliBll.PopularComboboxCliente();

            this.cmb_cliente.DataSource = cli;
            this.cmb_cliente.DisplayMember = "nomeFantasia";
            this.cmb_cliente.SelectedIndex = -1;
        }

        private void PopularComboboxBaseCliente(string cliente)
        {
            basDto.Cliente = cliente;

            List<BaseClienteDTO> baseCli = basBll.PopularComboboxBaseCliente(basDto);

            this.cmb_baseCliente.Enabled = true;
            this.cmb_baseCliente.DataSource = baseCli;
            this.cmb_baseCliente.DisplayMember = "nomeBase";
            this.cmb_baseCliente.SelectedIndex = -1;
        }

        private void PopularComboboxCondicaoPgto()
        {
            List<CondicaoPgtoDTO> cond = conBll.PopularComboboxCondicaoPgto();

            this.cmb_condPgto.DataSource = cond;
            this.cmb_condPgto.DisplayMember = "condicaoPgto";
            this.cmb_condPgto.ValueMember = "id";
            this.cmb_condPgto.SelectedIndex = -1;
        }

        private void PopularComboboxFormaPgto(string condicao)
        {
            frmDto.CondicaoPgto = condicao;

            List<FormaPgtoDTO> forma = frmBll.PopularComboboxFormaPgto(frmDto);

            this.cmb_formaPgto.Enabled = true;
            this.cmb_formaPgto.DataSource = forma;
            this.cmb_formaPgto.DisplayMember = "formaPgto";
            this.cmb_formaPgto.SelectedIndex = -1;
        }

        private void PopularComboboxPropostaComercial()
        {
            List<PropostaComercialDTO> proposta = comBll.PopularComboboxPropostaComercialStatus();

            this.cmb_servico.DataSource = proposta;
            this.cmb_servico.DisplayMember = "codigo";
            this.cmb_servico.SelectedIndex = -1;
        }

        private void AtualizarListaNotaFiscalForm()
        {
            frm_listaNotaFiscal.notaFiscalInstancia.ListarNotasFiscais();
        }

        public frm_addNotaFiscal()
        {
            InitializeComponent();
        }

        //Abrir Form com dados do XML da Nota Fiscal
        public frm_addNotaFiscal(Int32 id, string codigo, DateTime dataEmissao, string tipoNotaFiscal, string cliente, string baseCliente, string codigoVerificacao, string competencia, string numeroPedido, Int32 diasReceber, DateTime dataReceber, string descricao, Int32 valor)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            this.dtp_dataEmissao.Text = dataEmissao.ToString();
            //this.PopularComboboxTipoNotaFiscal();
            this.cmb_tipoNotaFiscal.Text = tipoNotaFiscal;
            //this.PopularComboboxCliente();
            this.cmb_cliente.Text = cliente;
            this.cmb_baseCliente.Text = baseCliente;
            this.txt_verificacao.Text = codigoVerificacao;
            this.txt_competencia.Text = competencia;
            this.txt_pedido.Text = numeroPedido;
            this.txt_diasReceber.Text = diasReceber.ToString();
            this.txt_dataRecebimento.Text = dataReceber.ToString();
            this.txt_descricao.Text = descricao;
            this.txt_valor.Text = valor.ToString();

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.dtp_dataEmissao.Enabled = false;
            this.cmb_tipoNotaFiscal.Enabled = false;
            this.cmb_cliente.Enabled = false;
            this.cmb_baseCliente.Enabled = false;
            this.txt_verificacao.Enabled = false;
            this.txt_competencia.Enabled = false;
            this.txt_pedido.Enabled = false;
            this.txt_diasReceber.Enabled = false;
            this.txt_dataRecebimento.Enabled = false;
            this.txt_descricao.Enabled = false;
            this.txt_valor.Enabled = false;
        }

        //Abrir Form sem dados do XML da Nota Fiscal
        public frm_addNotaFiscal(Int32 id, string codigo)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;

            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_atualizar.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.PopularComboboxTipoNotaFiscal();
            this.cmb_tipoNotaFiscal.SelectedIndex = -1;
            this.PopularComboboxCliente();
            this.cmb_cliente.SelectedIndex = -1;
            this.cmb_cliente.Enabled = true;
            this.cmb_baseCliente.Enabled = false;
            this.PopularComboboxCondicaoPgto();
            this.cmb_condPgto.SelectedIndex = -1;
            this.cmb_formaPgto.Enabled = false;
            this.PopularComboboxPropostaComercial();
            this.cmb_servico.SelectedIndex = -1;
            this.btn_addServico.Enabled = false;
            this.btn_excluirServico.Enabled = false;
            this.btn_limparLista.Enabled = false;
        }

        private void frm_addNotaFiscal_Load(object sender, EventArgs e)
        {
            this.lvw_listaServico.Columns.Add("Id", 30).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaServico.Columns.Add("Nota Fiscal", 90).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaServico.Columns.Add("Proposta", 90).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaServico.Columns.Add("Descrição", 350).TextAlign = HorizontalAlignment.Left;
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            clienteNotaFiscal = this.cmb_cliente.Text;

            if (clienteNotaFiscal == "SistemaSegsal.DTO.ClienteDTO")
            {
                return;
            }
            else
            {
                if(this.cmb_cliente.SelectedIndex == -1){
                    return;
                }
                else
                {
                    this.PopularComboboxBaseCliente(clienteNotaFiscal);
                    this.cmb_baseCliente.Enabled = true;
                }                
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarNotaFiscal();
        }

        private void cmb_condPgto_SelectedValueChanged(object sender, EventArgs e)
        {
            condPgtoNotaFiscal = this.cmb_condPgto.Text;

            if (condPgtoNotaFiscal == "SistemaSegsal.DTO.CondicaoPgtoDTO")
            {
                return;
            }
            else
            {
                if (this.cmb_condPgto.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    this.PopularComboboxFormaPgto(condPgtoNotaFiscal);
                    this.cmb_formaPgto.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
                     
        }

        private void cmb_condPgto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_servico_SelectedValueChanged(object sender, EventArgs e)
        {
            descricaoNotaFiscal = this.cmb_servico.Text;

            if (descricaoNotaFiscal == "SistemaSegsal.DTO.NotaFiscalDTO")
            {
                return;
            }
            else
            {
                if (this.cmb_servico.SelectedIndex == -1)
                {
                    return;
                }
                else
                {                    
                    this.btn_addServico.Enabled = true;
                }
            }
        }

        private void btn_excluirServico_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir esse item?", "Excluir Item!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Int32 linha = this.lvw_listaServico.Items.Count;

                lvw_listaServico.Items.RemoveAt(0);
                this.lvw_listaServico.SelectedItems.Clear();
            }
            else
            {
                this.btn_excluirServico.Enabled = false;                
            }            
        }

        private void btn_addServico_Click(object sender, EventArgs e)
        {
            if (cmb_servico.Text == "")
            {
                return;
            }
            else
            {
                this.btn_addServico.Enabled = true;

                string[] item = new string[4];

                string notaFiscal = this.txt_codigo.Text;
                comDto.Codigo = this.cmb_servico.Text;

                List<PropostaComercialDTO> prop = comBll.SelecionarPropostaComercial(comDto);

                Int32 qtdLinha = this.lvw_listaServico.Items.Count;

                item[0] = prop[0].Id.ToString();
                item[1] = notaFiscal;
                item[2] = prop[0].Codigo;
                item[3] = prop[0].Descricao;

                lvw_listaServico.Items.Add(new ListViewItem(item));

                this.cmb_servico.SelectedIndex = -1;
                this.btn_addServico.Enabled = false;
                this.btn_limparLista.Enabled = true;
            }
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir todos os itens?", "Limpar Lista!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lvw_listaServico.Items.Clear();
                this.btn_limparLista.Enabled = false;
            }            
        }

        private void lvw_listaServico_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaServico.SelectedItems.Count > 0)
            {
                this.btn_excluirServico.Enabled = true;
            }
            else
            {
                this.btn_excluirServico.Enabled = false;
            }
        }
    }
}
