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
    public partial class frm_listaTecnicos : Form
    {
        TecnicoDTO dto = new TecnicoDTO();
        TecnicoBLL bll = new TecnicoBLL();

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        Thread t1;

        Int32 id;
        string codigo;

        double larguraListView = 1280.0;

        private void AbrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
        }

        private void AbrirFormAddTecnicoNovo(object obj)
        {
            Application.Run(new frm_addTecnico(id));
        }

        private void AbrirFormAddTecnicoEditar(object obj)
        {
            Application.Run(new frm_addTecnico(id, codigo));
        }

        private void AbrirFormDocumentoTecnico()
        {
            Application.Run(new frm_listaTecnicoDocumento(codigo));
        }

        private void AbrirFormEpiTecnico()
        {
            //Application.Run(new frm_listaTecnicoEpi(codigo));
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
            this.btn_epi.Visible = false;
            this.btn_documentos.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_base.Visible = false;

            //this.cmb_status.Enabled = true;
            //this.lvw_listaChamados.Enabled = true;

            //this.cmb_status.Focus();
        }


        public void CriarNovoTecnico()
        {
            bll.CriarNovoTecnico(dto);

            id = dto.Id + 1;

            this.Close();
            t1 = new Thread(AbrirFormAddTecnicoNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void EditarTecnico()
        {
            id = Int32.Parse(this.lvw_listaTecnico.SelectedItems[0].Text);
            codigo = this.lvw_listaTecnico.SelectedItems[0].SubItems[2].Text;

            this.Close();
            t1 = new Thread(AbrirFormAddTecnicoEditar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void CriarDocumentoTecnico()
        {
            codigo = this.lvw_listaTecnico.SelectedItems[0].SubItems[2].Text;

            this.Close();
            t1 = new Thread(AbrirFormDocumentoTecnico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void SelecionarTecnico()
        {
            codigo = this.lvw_listaTecnico.SelectedItems[0].SubItems[2].Text;

            dto.Codigo = codigo;

            List<TecnicoDTO> tec = bll.SelecionarTecnico(dto);

            this.img_foto.Image = Image.FromFile(Application.StartupPath + tec[0].Foto);
            this.img_foto.SizeMode = PictureBoxSizeMode.StretchImage;

            //Botões de Registros
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_deletar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

            //Botôes de Registro Selecionado
            this.btn_epi.Visible = true;
            this.btn_documentos.Visible = true;
            this.btn_imprimir.Visible = true;
            this.btn_base.Visible = true;

            this.btn_epi.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_documentos.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor02, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_imprimir.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor03, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_base.Location = new Point(MedidasGeraisDTO.posicaoSubMenuHor04, MedidasGeraisDTO.posicaoSubMenuVer);
        }




        public void ListaTecnico()
        {
            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaTecnico = bll.ListarTecnico();

            this.lvw_listaTecnico.Items.Clear();

            foreach (TecnicoDTO tec in listaTecnico)
            {
                item[0] = tec.Id.ToString();
                item[1] = prox.ToString();
                item[2] = tec.Codigo;
                item[3] = tec.Nome;
                item[4] = tec.Cpf;
                item[5] = tec.Telefone;
                item[6] = tec.DataNascimento.ToString("dd/MM/yyyy");
                item[7] = tec.Status;

                lvw_listaTecnico.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            this.txt_qtdProposta.Text = "Nº de Técnicos: " + qtd.ToString();
        }

        public void ListaTecnicoAtivo()
        {
            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaTecnico = bll.ListarTecnicoAtivo();

            this.lvw_listaTecnico.Items.Clear();

            foreach (TecnicoDTO tec in listaTecnico)
            {
                item[0] = tec.Id.ToString();
                item[1] = prox.ToString();
                item[2] = tec.Codigo;
                item[3] = tec.Nome;
                item[4] = tec.Cpf;
                item[5] = tec.Telefone;
                item[6] = tec.DataNascimento.ToString("dd/MM/yyyy");
                item[7] = tec.Status;

                lvw_listaTecnico.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            this.txt_qtdProposta.Text = "Nº de Técnicos: " + qtd.ToString();
        }

        public void ListaTecnicoInativo()
        {
            string[] item = new string[8];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaTecnico = bll.ListarTecnicoInativo();

            this.lvw_listaTecnico.Items.Clear();

            foreach (TecnicoDTO tec in listaTecnico)
            {
                item[0] = tec.Id.ToString();
                item[1] = prox.ToString();
                item[2] = tec.Codigo;
                item[3] = tec.Nome;
                item[4] = tec.Cpf;
                item[5] = tec.Telefone;
                item[6] = tec.DataNascimento.ToString("dd/MM/yyyy");
                item[7] = tec.Status;

                lvw_listaTecnico.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            this.txt_qtdProposta.Text = "Nº de Técnicos: " + qtd.ToString();
        }

        private static double PercentOf(double valor, double total)
        {
            return (total / 100.0) * valor;
        }


        public frm_listaTecnicos()
        {
            InitializeComponent();
        }

        private void frm_listaTecnicos_Load(object sender, EventArgs e)
        {
            this.img_foto.Image = Image.FromFile(Application.StartupPath + @"\Técnicos\Fotos\sem_imagem.jpg");
            this.img_foto.SizeMode = PictureBoxSizeMode.StretchImage;

            this.lvw_listaTecnico.Columns.Add("Id", (int)PercentOf(0, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaTecnico.Columns.Add("Item", (int)PercentOf(4, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaTecnico.Columns.Add("Código", (int)PercentOf(6, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaTecnico.Columns.Add("Nome", (int)PercentOf(50, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lvw_listaTecnico.Columns.Add("CPF", (int)PercentOf(10, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvw_listaTecnico.Columns.Add("Telefone", (int)PercentOf(10, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvw_listaTecnico.Columns.Add("Data Nascimento", (int)PercentOf(10, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvw_listaTecnico.Columns.Add("Status", (int)PercentOf(10, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            this.ListaTecnicoAtivo();
            //this.PopularComboboxStatus();

            this.EstadoInicial();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoTecnico();
        }

        private void cbx_inativo_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbx_inativo.Checked)
            {
                this.ListaTecnicoInativo();
            }
            else
            {
                this.ListaTecnicoAtivo();
            }
        }

        private void lvw_listaTecnico_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaTecnico.SelectedItems.Count > 0)
            {
                this.SelecionarTecnico();
            }            
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarTecnico();
        }

        private void btn_documentos_Click(object sender, EventArgs e)
        {
            this.CriarDocumentoTecnico();
        }

        private void btn_epi_Click(object sender, EventArgs e)
        {

        }
    }
}
