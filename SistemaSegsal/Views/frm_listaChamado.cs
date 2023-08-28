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

namespace SistemaSegsal.Views
{
    public partial class frm_listaChamado : Form
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

        private void EstadoInicial()
        {
            //Menu
            this.btn_novo.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_finalizar.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_cancelarChamado.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_sair.Location = new Point(1277, 66);
            this.btn_novo.Location = new Point(1211, 66);
            

            //Painel 02
            this.cmb_status.Enabled = true;

            //Listview
            this.lvw_listaChamados.Enabled = true;
            //=======================================================            
        }

        private void CriarChamado()
        {
            bll.CriarNovoChamado(dto);

            Int32 id = dto.Id + 1;
            string codigo = "CHM-" + id.ToString("000#");

            frm_addChamado cham = new frm_addChamado(id, codigo);
            cham.Visible = true;
        }

        

        private void EditarChamado()
        {
            this.btn_novo.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_finalizar.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_cancelarChamado.Visible = false;
            this.btn_sair.Visible = false;

            

            this.lvw_listaChamados.Enabled = false;

            this.btn_atualizar.Location = new Point(0, 80);
            this.btn_cancelar.Location = new Point(0, 140);

            

            this.cmb_status.Enabled = false;
        }

        

        private void DeletarChamado()
        {
            dto.Codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            bll.DeletarChamado(dto);

            MessageBox.Show("Chamado Deletado com sucesso!", "Deletar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
            this.ListarChamados();
        }

        private void ListarChamados()
        {
            string[] item = new string[9];
            Int32 prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaChamado = bll.ListarChamado();

            this.lvw_listaChamados.Items.Clear();

            foreach (ChamadoDTO pro in listaChamado)
            {
                item[0] = pro.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pro.Codigo;
                item[3] = pro.DataChamado;
                item[4] = pro.Cliente + "-" + pro.BaseCliente;
                item[5] = pro.Solucao;
                item[6] = pro.Assunto + "-" + pro.Urgencia;
                item[7] = pro.ValorTotal.ToString("R$ #,##0.00");
                item[8] = pro.Status;

                lvw_listaChamados.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + pro.ValorTotal;
            }
            this.txt_qtdChamado.Text = "Qtd total de Chamados: " + qtd;
            this.txt_valorChamado.Text = "Valor Total de Chamados : " + valor.ToString("R$ #,##0.00");
        }

        private void ListarChamadosStatus(string statusChamado)
        {
            dto.Status = statusChamado;

            string[] item = new string[9];
            Int32 prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaChamado = bll.ListarChamadoStatus(dto);

            this.lvw_listaChamados.Items.Clear();

            foreach (ChamadoDTO pro in listaChamado)
            {
                item[0] = pro.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pro.Codigo;
                item[3] = pro.DataChamado;
                item[4] = pro.Cliente + "-" + pro.BaseCliente;
                item[5] = pro.Solucao;
                item[6] = pro.Assunto + "-" + pro.Urgencia;
                item[7] = pro.ValorTotal.ToString("R$ #,##0.00");
                item[8] = pro.Status;

                lvw_listaChamados.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + pro.ValorTotal;
            }

            this.txt_qtdChamado.Text = "Qtd de Chamados " + statusChamado + "s: " + qtd;
            this.txt_valorChamado.Text = "Valor Total de Chamados " + statusChamado + "s: " + valor.ToString("R$ #,##0.00");
        }

        private void SelecionarChamado()
        {
            dto.Codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            List<ChamadoDTO> chm = bll.SelecionarChamado(dto);

            

            this.btn_novo.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_finalizar.Visible = true;
            this.btn_imprimir.Visible = true;
            this.btn_cancelarChamado.Visible = true;
            this.btn_sair.Visible = false;

            

            this.lvw_listaChamados.Enabled = true;

            this.btn_editar.Location = new Point(0, 80);
            this.btn_deletar.Location = new Point(0, 140);
            this.btn_finalizar.Location = new Point(0, 200);
            this.btn_imprimir.Location = new Point(0, 260);
            this.btn_cancelarChamado.Location = new Point(0, 320);
            this.btn_cancelar.Location = new Point(0, 380);

           

           
        }

        private void PopularComboboxStatus()
        {
            List<ChamadoStatusDTO> stat = staBll.PopularComboboxChamadoStatus();

            this.cmb_status.DataSource = stat;
            this.cmb_status.DisplayMember = "status";

            this.cmb_status.Text = "";
        }



        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
        }

        private void SairFormulario()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_principal pri = new frm_principal();
                pri.Visible = true;

                this.Close();
            }
        }

        public frm_listaChamado()
        {
            InitializeComponent();
        }

        private void frm_listChamado_Load(object sender, EventArgs e)
        {
            //Designer do form
            this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";
            //this.BackColor = Color.FromArgb(255, 255, 255);

            this.EstadoInicial();

            //Designer do listview
            //this.lvw_listaPropostaComercial.BackColor = Color.Gray;
            //this.lvw_listaPropostaComercial.ForeColor = Color.White;

            this.lvw_listaChamados.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Número", 80).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Data Chamado", 95).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaChamados.Columns.Add("Cliente-Base", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Solução", 400).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Assunto - Urgência", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaChamados.Columns.Add("Valor Total", 80).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaChamados.Columns.Add("Status", 0).TextAlign = HorizontalAlignment.Right;
            
            this.PopularComboboxStatus();
            string statusChamado = "Aberto";
            this.ListarChamadosStatus(statusChamado);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarChamado();
        }

        private void lvw_listaChamados_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaChamados.SelectedItems.Count > 0)
            {
                string stat = this.lvw_listaChamados.SelectedItems[0].SubItems[8].Text;

                //if (stat == "Aberto")
                //{
                //    this.SelecionarChamado();
                //    this.txt_dataFinal.Visible = false;
                //}
                //else
                //{
                //    this.SelecionarChamado();
                //    this.txt_dataFinal.Visible = true;
                //}
                
            }
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

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
            }
        }

        private void btn_finalizar_Click(object sender, EventArgs e)
        {
            dto.Codigo = this.lvw_listaChamados.SelectedItems[0].SubItems[2].Text;

            List<ChamadoDTO> cham = bll.SelecionarChamado(dto);

            string codigo = cham[0].Codigo;
            DateTime dataChamado = DateTime.Parse(cham[0].DataChamado);
            string localSetor = cham[0].LocalSetor;
            Int32 valor = cham[0].ValorTotal;

            frm_listaChamadoAtendimento atend = new frm_listaChamadoAtendimento(codigo, dataChamado, localSetor, valor);
            atend.Visible = true;

            this.Close();
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
    }
}
