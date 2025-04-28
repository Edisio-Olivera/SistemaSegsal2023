using SistemaSegsal.DTO;
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
using SistemaSegsal.Auxiliar;
using SistemaSegsal.Views;
using System.Threading;

namespace SistemaSegsal.Views
{
    public partial class frm_listaApr : Form
    {
        AprDTO dto = new AprDTO();
        AprBLL bll = new AprBLL();

        double larguraListView = 1280.0;

        Thread t1;

        private void abrirFormAddApr(object obj)
        {
            Application.Run(new frm_addApr());
        }

        public void EstadoInicial()
        {
            //Botões de Registros
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_sair.Visible = true;

            //Botôes de Registro Selecionado
            this.btn_tecnico.Visible = false;
            this.btn_imprimir.Visible = false;

            this.btn_sair.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.lvw_listaApr.Enabled = true;
        }

        private void CriarApr()
        {

        }

        private void ListaApr()
        {
            string[] item = new string[10];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaApr = bll.ListarApr();

            this.lvw_listaApr.Items.Clear();

            foreach (AprDTO apr in listaApr)
            {
                item[0] = apr.Id.ToString();
                item[1] = prox.ToString();
                item[2] = apr.Codigo;
                item[3] = apr.DataEmissao.ToString("dd/MM/yyyy");
                item[4] = apr.LocalSetor;
                item[5] = apr.Equipamento;
                item[6] = apr.DataInicio.ToString("dd/MM/yyyy");
                item[7] = apr.DataFinal.ToString("dd/MM/yyyy");
                item[8] = apr.Descricao;
                item[9] = apr.Status;

                lvw_listaApr.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            //this.txt_valorProposta.Text = "Valor Total em Propostas: " + valor.ToString("R$ #,##0.00");
            //this.txt_qtdProposta.Text = "Nº de Propostas: " + qtd.ToString();
        }


        public frm_listaApr()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private static double PercentOf(double valor, double total)
        {
            return (total / 100.0) * valor;
        }

        private void frm_listaApr_Load(object sender, EventArgs e)
        {
            this.lvw_listaApr.Columns.Add("Id", (int)PercentOf(0, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaApr.Columns.Add("Item", (int)PercentOf(4, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaApr.Columns.Add("Código", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaApr.Columns.Add("Data Emissão", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaApr.Columns.Add("Local/Setor", (int)PercentOf(20, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaApr.Columns.Add("Equipamento", (int)PercentOf(20, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaApr.Columns.Add("Data Início", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaApr.Columns.Add("Data Final", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaApr.Columns.Add("descrição", (int)PercentOf(21, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaApr.Columns.Add("Status", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Left;

            this.EstadoInicial();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormAddApr);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
