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
using SistemaSegsal.View;
using System.Threading;
using System.Runtime.CompilerServices;

namespace SistemaSegsal.Views
{
    public partial class frm_addContasPagar : Form
    {
        ContaPagarDTO dto = new ContaPagarDTO();
        ContaPagarBLL bll = new ContaPagarBLL();

        MovimentacaoDTO movDto = new MovimentacaoDTO();
        MovimentacaoBLL movBll = new MovimentacaoBLL();

        ContaBancariaDTO cntDto = new ContaBancariaDTO();
        ContaBancariaBLL cntBll = new ContaBancariaBLL();

        FornecedorDTO forDto = new FornecedorDTO();
        FornecedorBLL forBll = new FornecedorBLL();

        CondicaoPgtoDTO cndDto = new CondicaoPgtoDTO();
        CondicaoPgtoBLL cndBll = new CondicaoPgtoBLL();

        FormaPgtoDTO frmDto = new FormaPgtoDTO();
        FormaPgtoBLL frmBll = new FormaPgtoBLL();

        CartaoBancoDTO crtDto = new CartaoBancoDTO();
        CartaoBancoBLL crtBll = new CartaoBancoBLL();

        CartaoBancoTipoDTO ctpDto = new CartaoBancoTipoDTO();
        CartaoBancoTipoBLL ctpBll = new CartaoBancoTipoBLL();

        Thread t1;

        Int32 id;
        DateTime dataRegistro;
        string contaBancaria;
        string fornecedor;
        string descricao;
        string condPgto;
        string formaPgto;
        string tipoMovimento;
        Int32 valorTransacao;
        Int32 qtdParcelas;
        string parcela;
        Int32 valorParcela;
        DateTime dataVencimento;
        DateTime dataPagamento;
        Int32 valorJuros;
        Int32 valorTotal;
        string status;


        private void abrirFormContaPagar(object obj)
        {
            Application.Run(new frm_listaContasPagar());
        }

        private void SalvarContaPagarAvista()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.DataRegistro = DateTime.Now;
            if(this.cmb_contaBancaria.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_contaBancaria.Focus();
                return;
            }
            else
            {
                dto.Conta = this.cmb_contaBancaria.Text;
            }
            if (this.cmb_fornecedor.Text == "")
            {
                MessageBox.Show("Por favor, selecione um fornecedor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_fornecedor.Focus();
                return;
            }
            else
            {
                dto.Fornecedor = this.cmb_fornecedor.Text;
            }            
            dto.TipoMovimentacao = "S";
            dto.DataTransacao = this.dtp_dataTransacao.Value;
            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Por favor, digite uma descrição!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }
            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma condição de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                dto.CondPgto = this.cmb_condPgto.Text;
            }
            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                dto.FormaPgto = this.cmb_formaPgto.Text;
            }

            if (this.txt_valor.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valor.Focus();
                return;
            }
            else
            {
                Int32 qtdCaracteresEntrada = this.txt_valor.Text.Length;
                Int32 valorG = 0;
                string valorFinal = "";

                for (Int32 x = 0; x < qtdCaracteresEntrada; x++)
                {
                    string[] valorTransacaoFinal = new string[qtdCaracteresEntrada];
                    string valorTransacao = this.txt_valor.Text;                    
                    
                    string val = valorTransacao.Substring(x, 1);

                    if(val == "." || val == ",")
                    {
                        
                    }
                    else
                    {
                        valorFinal = valorFinal + val;
                        
                    }
                }

                dto.ValorTransacao = Int32.Parse(valorFinal);
            }            
            dto.QtdParcela = Int32.Parse(this.txt_qtdParcela.Text);
            dto.Parcela = this.txt_parcela.Text;

            if (this.txt_valorParcela.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valor.Focus();
                return;
            }
            else
            {
                Int32 qtdCaracteresEntrada = this.txt_valorParcela.Text.Length;
                Int32 valorG = 0;
                string valorFinal = "";

                for (Int32 x = 0; x < qtdCaracteresEntrada; x++)
                {
                    string[] valorParcelaFinal = new string[qtdCaracteresEntrada];
                    string valorParcela = this.txt_valorParcela.Text;

                    string val = valorParcela.Substring(x, 1);

                    if (val == "." || val == ",")
                    {

                    }
                    else
                    {
                        valorFinal = valorFinal + val;

                    }
                }

                dto.ValorParcela = Int32.Parse(valorFinal);
            }
                        
            dto.DataVencimento = this.dtp_dataVencimento.Value;
            dto.DataPgtoReceb = this.dtp_dataPagamento.Value;

            if (this.txt_valorJuros.Text == "0")
            {
                dto.DescJuros = 0;
            }
            else
            {
                Int32 qtdCaracteresEntrada = this.txt_valorJuros.Text.Length;
                Int32 valorG = 0;
                string valorFinal = "";

                for (Int32 x = 0; x < qtdCaracteresEntrada; x++)
                {
                    string[] valorJurosFinal = new string[qtdCaracteresEntrada];
                    string valorJuros = this.txt_valorJuros.Text;

                    string val = valorJuros.Substring(x, 1);

                    if (val == "." || val == ",")
                    {

                    }
                    else
                    {
                        valorFinal = valorFinal + val;

                    }
                }

                dto.DescJuros = Int32.Parse(valorFinal);
            }

            if (this.txt_valorTotal.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valorTotal.Focus();
                return;
            }
            else
            {
                Int32 qtdCaracteresEntrada = this.txt_valorTotal.Text.Length;
                Int32 valorG = 0;
                string valorFinal = "";

                for (Int32 x = 0; x < qtdCaracteresEntrada; x++)
                {
                    string[] valorTotalFinal = new string[qtdCaracteresEntrada];
                    string valorTotal = this.txt_valorTotal.Text;

                    string val = valorTotal.Substring(x, 1);

                    if (val == "." || val == ",")
                    {

                    }
                    else
                    {
                        valorFinal = valorFinal + val;

                    }
                }

                dto.ValorTotal = Int32.Parse(valorFinal);
            }
                        
            dto.Status = "Pago";

            bll.SalvarContaPagar(dto);

            MessageBox.Show("Conta cadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormContaPagar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void SalvarContaPagarAprazo()
        {
            dto.DataRegistro = DateTime.Now;
            if (this.cmb_contaBancaria.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_contaBancaria.Focus();
                return;
            }
            else
            {
                dto.Conta = this.cmb_contaBancaria.Text;
            }
            if (this.cmb_fornecedor.Text == "")
            {
                MessageBox.Show("Por favor, selecione um fornecedor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_fornecedor.Focus();
                return;
            }
            else
            {
                dto.Fornecedor = this.cmb_fornecedor.Text;
            }
            dto.TipoMovimentacao = "S";
            dto.DataTransacao = this.dtp_dataTransacao.Value;
            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Por favor, digite uma descrição!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }
            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma condição de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                dto.CondPgto = this.cmb_condPgto.Text;
            }
            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                dto.FormaPgto = this.cmb_formaPgto.Text;
            }
            if (this.txt_valor.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valor.Focus();
                return;
            }
            else
            {
                string[] valorTransacao = this.txt_valor.Text.Split(',');
                string valorTransacaoReal = valorTransacao[0] + valorTransacao[1];
                dto.ValorTransacao = Int32.Parse(valorTransacaoReal);
            }
            dto.QtdParcela = Int32.Parse(this.txt_qtdParcela.Text);
            dto.Parcela = this.txt_parcela.Text;

            string[] valorPardela = this.txt_valorParcela.Text.Split(',');
            string valorParcelaReal = valorPardela[0] + valorPardela[1];
            dto.ValorParcela = Int32.Parse(valorParcelaReal);

            dto.DataVencimento = this.dtp_dataVencimento.Value;
            dto.DataPgtoReceb = this.dtp_dataPagamento.Value;

            if (this.txt_valorJuros.Text == "0")
            {
                dto.DescJuros = 0;
            }
            else
            {
                string[] valorJuros = this.txt_valorJuros.Text.Split(',');
                string valorJurosReal = valorJuros[0] + valorJuros[1];
                dto.DescJuros = Int32.Parse(valorJurosReal);
            }

            string[] valorTotal = this.txt_valorTotal.Text.Split(',');
            string valorTotalReal = valorTotal[0] + valorTotal[1];
            dto.ValorTotal = Int32.Parse(valorTotalReal);

            dto.Status = "A Pagar";

            Int32 qtdParcela = Int32.Parse(this.txt_qtdParcela.Text);

            for(Int32 x = 1; x < qtdParcela; x++)
            {
                bll.CriarNovoContaPagar(dto);

                dto.Conta = this.cmb_contaBancaria.Text;

            }
        }



        private void AtualizarContaPagar()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.DataRegistro = DateTime.Now;
            if (this.cmb_contaBancaria.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_contaBancaria.Focus();
                return;
            }
            else
            {
                dto.Conta = this.cmb_contaBancaria.Text;
            }
            if (this.cmb_fornecedor.Text == "")
            {
                MessageBox.Show("Por favor, selecione um fornecedor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_fornecedor.Focus();
                return;
            }
            else
            {
                dto.Fornecedor = this.cmb_fornecedor.Text;
            }
            dto.TipoMovimentacao = "S";
            dto.DataTransacao = this.dtp_dataTransacao.Value;
            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Por favor, digite uma descrição!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }
            if (this.cmb_condPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma condição de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_condPgto.Focus();
                return;
            }
            else
            {
                dto.CondPgto = this.cmb_condPgto.Text;
            }
            if (this.cmb_formaPgto.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma forma de pagamento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_formaPgto.Focus();
                return;
            }
            else
            {
                dto.FormaPgto = this.cmb_formaPgto.Text;
            }
            if (this.txt_valor.Text == "")
            {
                MessageBox.Show("Por favor, digite o valor da conta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_valor.Focus();
                return;
            }
            else
            {
                string[] valorTransacao = this.txt_valor.Text.Split(',');
                string valorTransacaoReal = valorTransacao[0] + valorTransacao[1];
                dto.ValorTransacao = Int32.Parse(valorTransacaoReal);
            }
            dto.QtdParcela = Int32.Parse(this.txt_qtdParcela.Text);
            dto.Parcela = this.txt_parcela.Text;

            string[] valorPardela = this.txt_valorParcela.Text.Split(',');
            string valorParcelaReal = valorPardela[0] + valorPardela[1];
            dto.ValorParcela = Int32.Parse(valorParcelaReal);

            dto.DataVencimento = this.dtp_dataVencimento.Value;
            dto.DataPgtoReceb = this.dtp_dataPagamento.Value;

            if (this.txt_valorJuros.Text == "0")
            {
                dto.DescJuros = 0;
            }
            else
            {
                string[] valorJuros = this.txt_valorJuros.Text.Split(',');
                string valorJurosReal = valorJuros[0] + valorJuros[1];
                dto.DescJuros = Int32.Parse(valorJurosReal);
            }

            string[] valorTotal = this.txt_valorTotal.Text.Split(',');
            string valorTotalReal = valorTotal[0] + valorTotal[1];
            dto.ValorTotal = Int32.Parse(valorTotalReal);

            dto.Status = "Pago";

            bll.EditarContaPagar(dto);

            MessageBox.Show("Conta cadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormContaPagar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }


        private void PagarCartaoCredito()
        {

        }


        public void PopularComboboxConta()
        {
            List<ContaBancariaDTO> conta = cntBll.PopularComboboxContaBancaria();

            this.cmb_contaBancaria.DataSource = conta;
            this.cmb_contaBancaria.DisplayMember = "nome";
            this.cmb_contaBancaria.Text = "";
        }

        public void PopularComboboxFornecedor()
        {
            List<FornecedorDTO> fornecedor = forBll.PopularComboboxFornecedor();

            this.cmb_fornecedor.DataSource = fornecedor;
            this.cmb_fornecedor.DisplayMember = "nomeFantasia";
            this.cmb_fornecedor.Text = "";
        }

        public void PopularComboboxCondicaoPgto()
        {
            List<CondicaoPgtoDTO> condicao = cndBll.PopularComboboxCondicaoPgto();

            this.cmb_condPgto.DataSource = condicao;
            this.cmb_condPgto.DisplayMember = "condicaoPgto";
            this.cmb_condPgto.Text = "";
        }

        private void PopularComboboxFormaPgto(string condicao)
        {
            frmDto.CondicaoPgto = condicao;

            List<FormaPgtoDTO> forma = frmBll.PopularComboboxFormaPgto(frmDto);

            this.cmb_formaPgto.Enabled = true;
            this.cmb_formaPgto.DataSource = forma;
            this.cmb_formaPgto.DisplayMember = "formaPgto";

            this.cmb_formaPgto.Text = "";
        }

        public void PopularComboboxCartaoBanco(string forma)
        {
            crtDto.TipoCartao = forma;

            List<CartaoBancoDTO> cartao = crtBll.PopularComboboxCartaoTipo(crtDto);
             
            this.cmb_apelidoCartao.DataSource = cartao;
            this.cmb_apelidoCartao.DisplayMember = "apelido";
            this.cmb_apelidoCartao.SelectedIndex = -1;
        }

        private static void FormatoMoeda(ref TextBox txt)
        {
            string n = string.Empty;
            double v = 0;

            try
            {
                n = txt.Text.Replace(",", "").Replace(".", "");
                if (n.Equals(""))
                    n = "";
                
                n = n.PadLeft(3, '0');
                if (n.Length > 3 & n.Substring(0, 1) == "0")
                    n = n.Substring(1, n.Length - 1);

                v = Convert.ToDouble(n) / 100;
                txt.Text = string.Format("{0:N}", v);

                txt.SelectionStart = txt.Text.Length;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SelecionarCartao(string apelido)
        {
            crtDto.Apelido = apelido;

            List<CartaoBancoDTO> cartao = crtBll.SelecionarCartaoBanco(crtDto);

            this.txt_bancoCartao.Text = cartao[0].Banco;
            this.txt_numeroCartao.Text = cartao[0].Numero;
            this.txt_bandeiraCartao.Text = cartao[0].Bandeira;
            this.txt_diaVencimento.Text = cartao[0].DiaVencimento.ToString();
            float saldo = (float)cartao[0].LimiteDisponivel / 100;
            this.txt_saldoCartao.Text = saldo.ToString("R$ #,##0.00");
        }

        //Nova despesa
        public frm_addContasPagar(Int32 id, DateTime dataRegistro)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.dtp_dataTransacao.Value = DateTime.Now;

            this.PopularComboboxConta();
            this.cmb_contaBancaria.SelectedIndex = -1;
            this.PopularComboboxFornecedor();
            this.cmb_fornecedor.SelectedIndex = -1;
            this.PopularComboboxCondicaoPgto();
            this.cmb_condPgto.SelectedIndex = -1;
            this.cmb_formaPgto.Enabled = false;
            this.txt_qtdParcela.Enabled = false;
            this.txt_parcela.Enabled = false;
            this.cbx_pago.Checked = false;
            this.dtp_dataPagamento.Visible = false;
            this.lbl_dataPagamento.Visible = false;
            this.txt_valorParcela.Enabled = false;
            this.txt_valorTotal.Enabled = false;
            this.cbx_pago.Visible = false;
            this.gbx_cartoes.Visible = false;
        }

        //Pagar despesa
        public frm_addContasPagar(Int32 id)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.dtp_dataTransacao.Value = DateTime.Now;

            dto.Id = id;
            List<ContaPagarDTO> pagar = bll.SelecionarContasPagar(dto);

            this.txt_id.Text = id.ToString();
            this.dtp_dataTransacao.Value = pagar[0].DataTransacao;
            this.PopularComboboxConta();
            this.cmb_contaBancaria.Text = pagar[0].Conta;            
            this.PopularComboboxFornecedor();
            this.cmb_fornecedor.Text = pagar[0].Fornecedor;



            this.PopularComboboxCondicaoPgto();
        }

        public frm_addContasPagar(Int32 id, string status)
        {
            InitializeComponent();
        }

        public frm_addContasPagar()
        {
            InitializeComponent();
        }

        private void frm_addContasPagar_Load(object sender, EventArgs e)
        {
            
        }

        private void cmb_condPgto_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_condPgto.Text == "SistemaSegsal.DTO.CondicaoPgtoDTO")
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
                    string condicao = this.cmb_condPgto.Text;

                    this.PopularComboboxFormaPgto(condicao);                    

                    this.cmb_condPgto.Enabled = true;
                    this.cmb_condPgto.Focus();

                    if(condicao == "À Vista")
                    {
                        this.txt_qtdParcela.Enabled = false;
                        this.txt_qtdParcela.Text = "1";
                        this.txt_parcela.Text = "1 de 1";
                        this.txt_valorJuros.Enabled = false;
                        this.txt_valorJuros.Text = "0";
                        this.cbx_pago.Visible = true;
                        this.cbx_pago.Checked = true;
                        this.dtp_dataVencimento.Value = this.dtp_dataTransacao.Value;
                        this.dtp_dataPagamento.Value = this.dtp_dataTransacao.Value;
                    }
                    else if(condicao == "À Prazo")
                    {
                        this.txt_qtdParcela.Enabled = true;
                        this.txt_qtdParcela.Text = "";
                        //Int32 qtdParc = Int32.Parse(this.txt_qtdParcela.Text);
                        this.txt_parcela.Text = "";
                        this.cbx_pago.Visible = false;
                        this.cbx_pago.Checked = false;
                        this.dtp_dataVencimento.Value = this.dtp_dataTransacao.Value;
                        this.dtp_dataPagamento.Value = this.dtp_dataTransacao.Value;
                    }                    
                }
            }
        }

        private void cbx_pago_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbx_pago.Checked)
            {
                this.lbl_dataPagamento.Visible = true;
                this.dtp_dataPagamento.Visible=true;
            }
            else
            {
                this.lbl_dataPagamento.Visible = false;
                this.dtp_dataPagamento.Visible = false;
            }
        }

        private void txt_valor_TextChanged(object sender, EventArgs e)
        {
            string condicao = this.cmb_condPgto.Text;

            FormatoMoeda(ref txt_valor);

            if(condicao == "À Vista")
            {
                this.txt_valorParcela.Text = this.txt_valor.Text;
                this.txt_valorTotal.Text = this.txt_valor.Text;
                
            }
        }

        private void cmb_formaPgto_SelectedValueChanged(object sender, EventArgs e)
        {
            string forma = this.cmb_formaPgto.Text;

            if (this.cmb_condPgto.Text == "SistemaSegsal.DTO.FormaPgtoDTO")
            {
                return;
            }
            else
            {
                if(forma == "Cartão de Crédito")
                {
                    this.gbx_cartoes.Visible = true;
                    this.PopularComboboxCartaoBanco("Crédito");
                }
                else
                {
                    this.gbx_cartoes.Visible = false;
                }
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string condicao = this.cmb_condPgto.Text;

            if(condicao == "À Vista")
            {
                this.SalvarContaPagarAvista();
            }
            else
            {
                this.SalvarContaPagarAprazo();
            }            
        }

        private void cmb_apelidoCartao_SelectedValueChanged(object sender, EventArgs e)
        {
            string apelido = this.cmb_apelidoCartao.Text;

            if (apelido == "SistemaSegsal.DTO.CartaoBancoDTO" || apelido == "")
            {
                this.txt_bancoCartao.Text = "";
                this.txt_numeroCartao.Text = "";
                this.txt_bandeiraCartao.Text = "";
                this.txt_diaVencimento.Text = "";
                this.txt_saldoCartao.Text = "";
                return;
            }
            else
            {
                this.SelecionarCartao(apelido);

            }
        }
    }
}
