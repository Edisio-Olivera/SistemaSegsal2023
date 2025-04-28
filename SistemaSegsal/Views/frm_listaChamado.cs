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

namespace SistemaSegsal.Views
{
    public partial class frm_listaChamado : Form
    {
        ChamadoDTO dto = new ChamadoDTO();
        ChamadoBLL bll = new ChamadoBLL();

        //ClienteDTO cliDto = new ClienteDTO();
        //ClienteBLL cliBll = new ClienteBLL();

        //BaseClienteDTO basDto = new BaseClienteDTO();
        //BaseClienteBLL basBll = new BaseClienteBLL();

        //ClienteContatoDTO cntDto = new ClienteContatoDTO();
        //ClienteContatoBLL cntBll = new ClienteContatoBLL();

        //ChamadoAssuntoDTO assDto = new ChamadoAssuntoDTO();
        //ChamadoAssuntoBLL assBll = new ChamadoAssuntoBLL();

        //ChamadoUrgenciaDTO urgDto = new ChamadoUrgenciaDTO();
        //ChamadoUrgenciaBLL urgBll = new ChamadoUrgenciaBLL();

        ChamadoStatusDTO staDto = new ChamadoStatusDTO();
        ChamadoStatusBLL staBll = new ChamadoStatusBLL();

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        public static frm_listaChamado chamadoInstancia;        

        Thread t1;

        Int32 id;
        string codigo;
        string statusChamado;

        double larguraListView = 1280.0;

        private static double PercentOf(double valor, double total)
        {
            return (total / 100.0) * valor;
        }

        private void abrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
        }

        private void abrirFormAddChamadoNovo(object obj)
        {
            Application.Run(new frm_addChamado(id, codigo));
        }

        private void abrirFormAddChamadoEditar(object obj)
        {
            Application.Run(new frm_addChamado(codigo));
        }

        private void EstadoInicial()
        {
            //Botões de Registros
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_sair.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            //Botôes de Registro Selecionado
            this.btn_atendimento.Visible = false;
            this.btn_finalizar.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_cancelarChamado.Visible = false;            

            this.cmb_status.Enabled = true;
            this.lvw_listaChamados.Enabled = true;

            this.cmb_status.Focus();

            statusChamado = "Aberto";
            //this.ListarChamadosStatus(statusChamado);
            this.ListarChamados();

            this.lbl_qtdAberto.Text = this.ContarChamadoStatus(statusChamado).ToString();

            statusChamado = "Andamento";
            this.lbl_qtdAndamento.Text = this.ContarChamadoStatus(statusChamado).ToString();

            statusChamado = "Cancelado";
            this.lbl_qtdCancelado.Text = this.ContarChamadoStatus(statusChamado).ToString();

            statusChamado = "Fechado";
            this.lbl_qtdFechado.Text = this.ContarChamadoStatus(statusChamado).ToString();

            statusChamado = "Faturado";
            this.lbl_qtdFaturado.Text = this.ContarChamadoStatus(statusChamado).ToString();
        }

        private void CriarNovoChamado()
        {
            bll.CriarNovoChamado(dto);

            id = dto.Id;
            codigo = "CHM-" + id.ToString("00000#");

            this.Close();
            t1 = new Thread(abrirFormAddChamadoNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }        

        private void EditarChamado()
        {
            codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            this.Close();
            t1 = new Thread(abrirFormAddChamadoEditar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
        
        private void DeletarChamado()
        {
            dto.Codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            bll.DeletarChamado(dto);

            MessageBox.Show("Chamado Deletado com sucesso!", "Deletar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
            this.ListarChamados();
        }

        public void ListarChamados()
        {
            string[] item = new string[10];
            Int32 prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaChamado = bll.ListarChamado();

            this.lvw_listaChamados.Items.Clear();

            foreach (ChamadoDTO chm in listaChamado)
            {
                item[0] = chm.Id.ToString();
                item[1] = prox.ToString();
                item[2] = chm.Codigo;
                item[3] = chm.DataChamado.ToString("dd/MM/yyyy");
                item[4] = chm.Cliente + "-" + chm.BaseCliente;
                item[5] = chm.Equipamento;
                item[6] = chm.Assunto;
                item[7] = chm.Situacao + "-" + chm.Urgencia;
                item[8] = chm.ValorTotal.ToString("R$ #,##0.00");
                item[9] = chm.Status;

                lvw_listaChamados.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + chm.ValorTotal;
            }
            this.txt_qtdChamado.Text = "Qtd total de Chamados: " + qtd;
            this.txt_valorChamado.Text = "Valor Total de Chamados : " + valor.ToString("R$ #,##0.00");
        }

        public void ListarChamadosStatus(string statusChamado)
        {
            dto.Status = statusChamado;

            string[] item = new string[10];
            Int32 prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaChamado = bll.ListarChamadoStatus(dto);

            this.lvw_listaChamados.Items.Clear();

            foreach (ChamadoDTO chm in listaChamado)
            {
                item[0] = chm.Id.ToString();
                item[1] = prox.ToString();
                item[2] = chm.Codigo;
                item[3] = chm.DataChamado.ToString("dd/MM/yyyy");
                item[4] = chm.Cliente + "-" + chm.BaseCliente;
                item[5] = chm.Equipamento + " - " + chm.InformacaoCliente;
                item[6] = chm.Assunto;
                item[7] = chm.Situacao + "-" + chm.Urgencia;
                item[8] = chm.ValorTotal.ToString("R$ #,##0.00");
                item[9] = chm.Status;

                lvw_listaChamados.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + chm.ValorTotal;
            }

            this.txt_qtdChamado.Text = "Qtd de Chamados " + statusChamado + "(s): " + qtd;
            //this.txt_valorChamado.Text = "Valor Total de Chamados " + statusChamado + "s: " + valor.ToString("R$ #,##0.00");
        }

        private void SelecionarChamado()
        {
            //Botões de Registros
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_deletar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

            //Botôes de Registro Selecionado
            this.btn_atendimento.Visible = true;
            this.btn_finalizar.Visible = true;
            this.btn_imprimir.Visible = true;
            this.btn_cancelarChamado.Visible = true;

            this.btn_cancelarChamado.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_imprimir.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor02, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_finalizar.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor03, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_atendimento.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor04, MedidasGeraisDTO.posicaoSubMenuVer);

            this.cmb_status.Enabled = true;
            this.lvw_listaChamados.Enabled = true;

            this.cmb_status.Focus();            
        }

        private void PopularComboboxStatus()
        {
            List<ChamadoStatusDTO> stat = staBll.PopularComboboxChamadoStatus();

            this.cmb_status.DataSource = stat;
            this.cmb_status.DisplayMember = "status";

            this.cmb_status.Text = "";
        }

        private void CancelarChamado()
        {
            dto.Codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;
            dto.Status = "Cancelado";

            bll.AtualizarStatus(dto); 
        }

        private void FinalizarChamado()
        {
            dto.Codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            string dataFinalForm = DateTime.Now.ToShortDateString();
            string[] dataFinalQuebrada = dataFinalForm.Split('/');
            string dia = dataFinalQuebrada[0];
            string mes = dataFinalQuebrada[1];
            string ano = dataFinalQuebrada[2];

            string dataFinalBanco = ano + "-" + mes + "-" + dia;
            dto.DataFinal = DateTime.Parse(dataFinalBanco);

            dto.Status = "Fechado";

            bll.FinalizarChamado(dto);

            MessageBox.Show("Chamado Finalizado com sucesso!", "Deletar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string statusChamado = "Aberto";

            this.EstadoInicial();
            this.ListarChamadosStatus(statusChamado);
        }

        private void ImprimirChamado()
        {

        }

        private Int32 ContarChamadoStatus(string status)
        {
            dto.Status = status;

            Int32 qtd = bll.ContarChamadoStatus(dto);

            return qtd;
        }

        private void AbrirAtendimento()
        {
            string codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            frm_listaChamadoAtendimento atend = new frm_listaChamadoAtendimento(codigo);
            atend.Visible = true;

            this.Visible = false;
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                t1 = new Thread(abrirFormPrincipal);
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
                t1 = new Thread(abrirFormPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }

        public frm_listaChamado()
        {
            InitializeComponent();

            chamadoInstancia = this;
        }

        public frm_listaChamado(string statusChamado)
        {
            InitializeComponent();

            this.ListarChamadosStatus(statusChamado);
        }

        private void frm_listChamado_Load(object sender, EventArgs e)
        {
            this.lvw_listaChamados.Columns.Add("Id", (int)PercentOf(0, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Item", (int)PercentOf(4, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Número", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Data", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Cliente-Base", (int)PercentOf(16, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Equipamento", (int)PercentOf(32, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Assunto", (int)PercentOf(12, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Situação-Urgência", (int)PercentOf(9, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Valor Total", (int)PercentOf(6, larguraListView)).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaChamados.Columns.Add("Status", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Left;
            
            //this.PopularComboboxStatus();
            

            this.EstadoInicial();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoChamado();
        }

        private void lvw_listaChamados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaChamados.SelectedItems.Count > 0)
            {
                this.SelecionarChamado();                
            }
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            //string codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;
            //Int32 id = 1;

            //frm_addChamado chm = new frm_addChamado(codigo, id);
            //chm.Visible = true;
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarChamado();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AbrirAtendimento();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            this.DeletarChamado();
        }

        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_status.Text == "SistemaSegsal.DTO.ChamadoStatusDTO")
            {
                return;
            }

            else
            {
                string stat = this.cmb_status.Text;
                this.ListarChamadosStatus(stat);
                this.EstadoInicial();
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            this.FinalizarChamado();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void cmb_base_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_addCliente_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelarChamado_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse Chamado?", "Cancelar Chamado!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Chamado cancelado com sucesso!", "Cancelar Chamado!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.CancelarChamado();
                this.EstadoInicial();

                string stat = "Aberto";
                this.ListarChamadosStatus(stat);
            }
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_materialChamado_Click(object sender, EventArgs e)
        {

        }
    }
}
