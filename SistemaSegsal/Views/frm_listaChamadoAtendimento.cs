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
    public partial class frm_listaChamadoAtendimento : Form
    {
        ChamadoDTO chmDto = new ChamadoDTO();
        ChamadoBLL chmBll = new ChamadoBLL();

        ChamadoAtendimentoDTO dto = new ChamadoAtendimentoDTO();
        ChamadoAtendimentoBLL bll = new ChamadoAtendimentoBLL();

        public static frm_listaChamadoAtendimento atendimentoIntancia;

        private void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_sair.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_editar.Visible = false;

            this.btn_sair.Location = new Point(1278, 10);
            this.btn_novo.Location = new Point(1212, 10);

            this.txt_codigo.Enabled = false;
            this.txt_dataChamado.Enabled = false;
            this.txt_local.Enabled = false;
            this.txt_valor.Enabled = false;
        }

        private void CriarNovoAtendimento()
        {
            bll.CriarNovoAtendimentoChamado(dto);

            Int32 id = dto.Id + 1;
            string codigo = this.txt_codigo.Text;

            frm_addChamadoAtendimento atd = new frm_addChamadoAtendimento(id, codigo);
            atd.Visible = true;
        }

        private void EditarAtendimento()
        {
            Int32 id = Int32.Parse(this.lvw_listaAtendimento.SelectedItems[0].Text);

            frm_addChamadoAtendimento atd = new frm_addChamadoAtendimento(id);
            atd.Visible = true;
        }

        private void DeletarAtendimento()
        {
            dto.Id = Int32.Parse(this.lvw_listaAtendimento.SelectedItems[0].Text);

            DialogResult result = MessageBox.Show("Deseja realmente Deletar esse Atendimento?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bll.DeletarAtendimentoChamado(dto);
            }            
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
                this.Visible = false;

                frm_listaChamado chm = new frm_listaChamado();
                chm.Visible = true;
            }
        }

        public void ListarAtendimentoChamados(string codigo)
        {
            dto.Chamado = codigo;

            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaAtendimento = bll.ListarAtendimentoChamado(dto);

            this.lvw_listaAtendimento.Items.Clear();

            foreach (ChamadoAtendimentoDTO atd in listaAtendimento)
            {
                item[0] = atd.Id.ToString();
                item[1] = prox.ToString();                
                item[2] = atd.DataInicio + " - " + atd.HoraInicio;
                item[3] = atd.DataFinal + " - " + atd.HoraFinal;
                item[4] = atd.Tipo;
                item[5] = atd.Tecnico;
                item[6] = atd.AtividadeRealizada;
                item[7] = atd.Valor.ToString("R$ #,##0.00");

                lvw_listaAtendimento.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + atd.Valor;
            }
            //this.txt_qtdChamado.Text = "Qtd total de Chamados: " + qtd;
            //this.txt_valorChamado.Text = "Valor Total de Chamados : " + valor.ToString("R$ #,##0.00");
        }




        public frm_listaChamadoAtendimento()
        {
            InitializeComponent();

            atendimentoIntancia = this;
        }

        public frm_listaChamadoAtendimento(string codigo)
        {
            InitializeComponent();

            chmDto.Codigo = codigo;

            List<ChamadoDTO> chm = chmBll.SelecionarChamado(chmDto);

            this.txt_codigo.Text = codigo;
            this.txt_dataChamado.Text = chm[0].DataChamado.ToString();
            string descricao = chm[0].LocalSetor + " | " + chm[0].Equipamento;
            this.txt_local.Text = descricao; ;
            this.txt_valor.Text = chm[0].ValorTotal.ToString("#,##0.00");
        }

        private void frm_listaChamadoAtendimento_Load(object sender, EventArgs e)
        {
            this.EstadoInicial();

            this.lvw_listaAtendimento.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaAtendimento.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;            
            this.lvw_listaAtendimento.Columns.Add("Data Início - Hora Início", 150).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaAtendimento.Columns.Add("Data Final - Hora Final", 150).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaAtendimento.Columns.Add("Tipo", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaAtendimento.Columns.Add("Técnico", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaAtendimento.Columns.Add("Descrição do Atendimento", 500).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaAtendimento.Columns.Add("Valor", 90).TextAlign = HorizontalAlignment.Right;

            string codigo = this.txt_codigo.Text;
            this.ListarAtendimentoChamados(codigo);
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoAtendimento();
        }

        private void lvw_listaAtendimento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvw_listaAtendimento_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaAtendimento.SelectedItems.Count > 0)
            {
                this.btn_novo.Visible = false;
                this.btn_cancelar.Visible = true;
                this.btn_editar.Visible = true;
                this.btn_deletar.Visible = true;
                this.btn_sair.Visible = false;

                this.btn_cancelar.Location = new Point(1278, 10);
                this.btn_editar.Location = new Point(1212, 10);
                this.btn_deletar.Location = new Point(1146, 10);
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarAtendimento();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
