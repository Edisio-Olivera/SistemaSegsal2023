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


        private void SalvarNotaFiscal()
        {
            ntaDto.Id = Int32.Parse(this.txt_id.Text);
            ntaDto.Codigo = this.txt_codigo.Text;

            string dataEmissao = this.txt_dataEmissao.Text;
            string[] dataEmissaoQuebrada = dataEmissao.Split('/');
            string dia = dataEmissaoQuebrada[0];
            string mes = dataEmissaoQuebrada[1];
            string ano = dataEmissaoQuebrada[2];

            if (dia == "" || mes == "" || ano == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataEmissao.Focus();
                return;
            }
            else
            {
                string dataEmissaoBanco = ano + "-" + mes + "-" + dia;
                ntaDto.DataEmissao = dataEmissaoBanco.ToString();
            }

            if (this.txt_diasReceber.Text == "")
            {
                MessageBox.Show("Por favor, digite o número de Dias a Receber!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_diasReceber.Focus();
                return;
            }
            else
            {
                Int32 diasPgto = Int32.Parse(this.txt_diasReceber.Text);
                DateTime dataEmissaoForm = DateTime.Parse(dataEmissao);
                DateTime dataRecebimento = dataEmissaoForm.AddDays(diasPgto);
                ntaDto.DataRecebimento = dataRecebimento.ToString("yyyy-MM-dd");
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

            string competencia = this.txt_dataEmissao.Text;
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

            ntaBll.SalvarNotaFiscal(ntaDto);

            MessageBox.Show("Nota Fiscal Cadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Visible = false;

            this.AtualizarListaNotaFiscalForm();
        }


        private void PopularComboboxTipoNotaFiscal()
        {
            List<NotaFiscalTipoDTO> tipoNf = tipBll.PopularComboboxNotaFiscalTipo();

            this.cmb_tipoNotaFiscal.DataSource = tipoNf;
            this.cmb_tipoNotaFiscal.DisplayMember = "tipoNotaFiscal";
            this.cmb_tipoNotaFiscal.Text = "";
        }

        private void PopularComboboxCliente()
        {
            List<ClienteDTO> cli = cliBll.PopularComboboxCliente();

            this.cmb_cliente.DataSource = cli;
            this.cmb_cliente.DisplayMember = "nomeFantasia";
            this.cmb_cliente.Text = "";
        }

        private void PopularComboboxBaseCliente(string cliente)
        {
            basDto.Cliente = cliente;

            List<BaseClienteDTO> baseCli = basBll.PopularComboboxBaseCliente(basDto);

            this.cmb_baseCliente.Enabled = true;
            this.cmb_baseCliente.DataSource = baseCli;
            this.cmb_baseCliente.DisplayMember = "nomeBase";

            this.cmb_baseCliente.Text = "";
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
            this.txt_dataEmissao.Text = dataEmissao.ToString();
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
            this.txt_dataEmissao.Enabled = false;
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
        }

        private void frm_addNotaFiscal_Load(object sender, EventArgs e)
        {

        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_cliente.Text == "SistemaSegsal.DTO.ClienteDTO")
            {
                return;
            }
            else
            {
                string cliente = this.cmb_cliente.Text;

                this.PopularComboboxBaseCliente(cliente);

                this.cmb_baseCliente.Enabled = true;
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarNotaFiscal();
        }
    }
}
