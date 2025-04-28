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
    public partial class frm_listaOrdemServico : Form
    {
        OrdemServicoDTO dto = new OrdemServicoDTO();
        OrdemServicoBLL bll = new OrdemServicoBLL();



        private void EstadoInicial()
        {
            //Visualização dos Botões

            //this.btn_sair.Visible = true;

            //this.cmb_status.BackColor = Color.FromArgb(255, 255, 192);

            ////Posição dos Botões            

            ////this.btn_sair.Location = new Point(0, 160);


            //this.cmb_status.Enabled = true;
            //this.lvw_listaPropostaComercial.Enabled = true;


            //this.cmb_status.BackColor = Color.White;
            //this.cmb_status.Focus();

        }

        /*
        public void ListaOrdemServicoStatus(string status)
        {
            dto.Status = status;

            string[] item = new string[8];
            int prox = 1;
            Int32 qtd = 0;

            var listaOrdemServico = bll.ListarOrdemServicoStatus(dto);

            this.lvw_listaOrdemServico.Items.Clear();

            foreach (OrdemServicoDTO os in listaOrdemServico)
            {
                item[0] = os.Id.ToString();
                item[1] = prox.ToString();
                item[2] = os.Codigo;
                item[3] = os.DataRegistro;
                item[4] = os.Cliente + "-" + os.BaseCliente;
                item[5] = os.Titulo;
                item[6] = os.Valor.ToString("R$ #,##0.00");
                item[7] = os.Status;

                lvw_listaOrdemServico.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            if (status == "A Receber")
            {
                this.txt_valorProposta.Text = "Valor Total em Propostas " + status + ": " + valor.ToString("R$ #,##0.00");
                this.txt_qtdProposta.Text = "Nº de Propostas " + status + ": " + qtd.ToString();
            }
            else
            {
                this.txt_valorProposta.Text = "Valor Total em Propostas " + status + "s: " + valor.ToString("R$ #,##0.00");
                this.txt_qtdProposta.Text = "Nº de Propostas " + status + "s: " + qtd.ToString();
            }

        }

        */

        public void ListaOrdemServico()
        {
            //dto.Status = status;

            string[] item = new string[8];
            int prox = 1;
            Int32 qtd = 0;

            var listaOrdemServico = bll.ListarOrdemServico();

            this.lvw_listaOrdemServico.Items.Clear();

            foreach (OrdemServicoDTO os in listaOrdemServico)
            {
                item[0] = os.Id.ToString();
                item[1] = prox.ToString();
                item[2] = os.Codigo;
                item[3] = os.DataRegistro.ToString("dd/MM/yyyy");
                item[4] = os.Cliente + "-" + os.BaseCliente;
                item[5] = os.Proposta + " - " + os.Titulo;
                item[6] = os.Progresso.ToString();
                item[7] = os.Status;

                lvw_listaOrdemServico.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            //if (status == "A Receber")
            //{
            //    this.txt_valorProposta.Text = "Valor Total em Propostas " + status + ": " + valor.ToString("R$ #,##0.00");
            //    this.txt_qtdProposta.Text = "Nº de Propostas " + status + ": " + qtd.ToString();
            //}
            //else
            //{
            //    this.txt_valorProposta.Text = "Valor Total em Propostas " + status + "s: " + valor.ToString("R$ #,##0.00");
            //    this.txt_qtdProposta.Text = "Nº de Propostas " + status + "s: " + qtd.ToString();
            //}

        }


        public frm_listaOrdemServico()
        {
            InitializeComponent();
        }

        private void frm_listaOrdemServico_Load(object sender, EventArgs e)
        {
            this.EstadoInicial();

            //1370
            this.lvw_listaOrdemServico.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaOrdemServico.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaOrdemServico.Columns.Add("Número", 85).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaOrdemServico.Columns.Add("Data", 90).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaOrdemServico.Columns.Add("Cliente-Base", 250).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaOrdemServico.Columns.Add("Título", 640).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaOrdemServico.Columns.Add("Progresso (%)", 100).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaOrdemServico.Columns.Add("Status", 80).TextAlign = HorizontalAlignment.Left;

            //this.txt_qtdProposta.Text = "Nº de Propostas: ";

            this.ListaOrdemServico();
            //this.PopularComboboxStatus();
        }
    }
}
