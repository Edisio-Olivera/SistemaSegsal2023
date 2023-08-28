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

        ChamadoUrgenciaDTO urgDto = new ChamadoUrgenciaDTO();
        ChamadoUrgenciaBLL urgBll = new ChamadoUrgenciaBLL();

        ChamadoStatusDTO staDto = new ChamadoStatusDTO();
        ChamadoStatusBLL staBll = new ChamadoStatusBLL();

        public static frm_addChamado calendInstancia;

        private void SalvarChamado()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;

            string dataChamadoForm = this.txt_dataChamado.Text;
            string[] dataChamadoQuebrada = dataChamadoForm.Split('/');
            string dia = dataChamadoQuebrada[0];
            string mes = dataChamadoQuebrada[1];
            string ano = dataChamadoQuebrada[2];

            if (dia == "" || mes == "" || ano == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataChamado.Focus();
                return;
            }
            else
            {
                string dataChamadoBanco = ano + "-" + mes + "-" + dia;
                dto.DataChamado = dataChamadoBanco;
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
            dto.Status = "Aberto";

            bll.SalvarNovoChamado(dto);

            MessageBox.Show("Chamado Cadastrado com sucesso!", "Cadastrar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.EstadoInicial();
            //this.ListarChamados();
        }

        private void AtualizarChamado()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;

            string dataChamadoForm = this.txt_dataChamado.Text;
            string[] dataChamadoQuebrada = dataChamadoForm.Split('/');
            string dia = dataChamadoQuebrada[0];
            string mes = dataChamadoQuebrada[1];
            string ano = dataChamadoQuebrada[2];

            if (dia == "" || mes == "" || ano == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataChamado.Focus();
                return;
            }
            else
            {
                string dataChamadoBanco = ano + "-" + mes + "-" + dia;
                dto.DataChamado = dataChamadoBanco;
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
            dto.Status = "Aberto";

            bll.EditarChamado(dto);

            MessageBox.Show("Chamado Atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.EstadoInicial();
            //this.ListarChamados();
        }

        private void PopularComboboxCliente()
        {
            List<ClienteDTO> cliente = cliBll.PopularComboboxCliente();

            this.cmb_cliente.DataSource = cliente;
            this.cmb_cliente.DisplayMember = "nomeFantasia";

            this.cmb_cliente.Text = "";
        }

        private void PopularComboboxBaseCliente(string cliente)
        {
            basDto.Cliente = cliente;

            List<BaseClienteDTO> baseCli = basBll.PopularComboboxBaseCliente(basDto);

            this.cmb_baseCliente.Enabled = true;
            //this.btn_addBaseCliente.Enabled = true;
            this.cmb_baseCliente.DataSource = baseCli;
            this.cmb_baseCliente.DisplayMember = "nomeBase";

            this.cmb_baseCliente.Text = "";
        }

        private void PopularComboboxContatoCliente(string cliente)
        {
            cntDto.Cliente = cliente;

            List<ClienteContatoDTO> contato = cntBll.PopularComboboxContatoCliente(cntDto);

            this.cmb_solicitante.Enabled = true;
            //this.btn_addContatoCliente.Enabled = true;
            this.cmb_solicitante.DataSource = contato;
            this.cmb_solicitante.DisplayMember = "nome";

            this.cmb_solicitante.Text = "";
        }

        private void PopularComboboxAssunto()
        {
            List<ChamadoAssuntoDTO> assunto = assBll.PopularComboboxAssunto();

            this.cmb_assunto.DataSource = assunto;
            this.cmb_assunto.DisplayMember = "assunto";

            this.cmb_assunto.Text = "";
        }

        private void PopularComboboxUrgencia()
        {
            List<ChamadoUrgenciaDTO> urgencia = urgBll.PopularComboboxUrgencia();

            this.cmb_urgencia.DataSource = urgencia;
            this.cmb_urgencia.DisplayMember = "urgencia";

            this.cmb_urgencia.Text = "";
        }

        


        public void CaptarDataChamado(string dataChamado)
        {
            this.txt_dataChamado.Text = dataChamado;
        }







        public frm_addChamado()
        {
            InitializeComponent();

            calendInstancia = this;
        }

        public frm_addChamado(Int32 id, string codigo)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;

            this.PopularComboboxCliente();
            this.PopularComboboxAssunto();
            this.PopularComboboxUrgencia();
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
                //this.btn_addBaseCliente.Enabled = false;
                //this.btn_addContatoCliente.Enabled = false;
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
}
