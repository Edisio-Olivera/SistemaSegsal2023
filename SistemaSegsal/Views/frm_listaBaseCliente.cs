using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.Views;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;

namespace SistemaSegsal.Views
{
    public partial class frm_listaBaseCliente : Form
    {
        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        CidadeDTO cidDto = new CidadeDTO();
        CidadeBLL cidBll = new CidadeBLL();

        UfDTO ufDto = new UfDTO();
        UfBLL ufBll = new UfBLL();

        public static frm_listaBaseCliente baseClienteInstancia;

        private void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_contato.Visible = false;
            this.btn_sair.Visible = true;

            this.lvw_listaBasesCliente.Enabled = true;

            this.btn_sair.Location = new Point(1258, 5);
            this.btn_novo.Location = new Point(1177, 5);

            this.txt_codigo.Enabled = false;
            this.txt_nomeCliente.Enabled = false;

            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_nomeCliente.BackColor = Color.FromArgb(192, 255, 255);
        }
        
        private void CriarNovoBaseCliente()
        {
            basBll.CriarNovoBaseCliente(basDto);

            Int32 id = basDto.Id + 1;
            string codigo = "BAS-" + id.ToString("000#");
            DateTime dataRegistro = DateTime.Now.Date;
            string cliente = this.txt_nomeCliente.Text;

            frm_addBaseCliente cli = new frm_addBaseCliente(id, codigo, dataRegistro, cliente);
            cli.Visible = true;
        }

        private void EditarBaseCliente()
        {
            string codigo = this.lvw_listaBasesCliente.SelectedItems[0].SubItems[2].Text;

            frm_addBaseCliente bas = new frm_addBaseCliente(codigo);
            bas.Visible = true;
        }

        public void Mensagem()
        {
            MessageBox.Show("Mensagem qualquer!");
        }

        public void ListarBasesCliente(string cliente)
        {
            basDto.Cliente = cliente;

            this.lvw_listaBasesCliente.Items.Clear();

            string[] item = new string[8];
            int prox = 1;
            var listaBaseCliente = basBll.ListarBasesClienteCodigo(basDto);

            foreach (BaseClienteDTO bas in listaBaseCliente)
            {
                item[0] = bas.Id.ToString();
                item[1] = prox.ToString();
                item[2] = bas.Codigo;
                item[3] = bas.NomeBase;
                item[4] = bas.Cidade + "/" + bas.Uf;
                item[5] = bas.Cnpj;
                item[6] = bas.InscEstadual;
                item[7] = bas.Status;

                lvw_listaBasesCliente.Items.Add(new ListViewItem(item));
                prox = prox + 1;
            }
        }

        private void SelecionarBaseCliente()
        {
            if(this.lvw_listaBasesCliente.SelectedItems.Count > 0)
            {
                basDto.Codigo = this.lvw_listaBasesCliente.SelectedItems[0].SubItems[2].Text;

                List<BaseClienteDTO> baseCli = basBll.SelecionarBaseCliente(basDto);                

                this.btn_novo.Visible = false;
                this.btn_cancelar.Visible = true;
                this.btn_editar.Visible = true;
                this.btn_deletar.Visible = true;
                this.btn_sair.Visible = false;

                this.btn_cancelar.Location = new Point(1277, 5);
                this.btn_editar.Location = new Point(1212, 5);
                this.btn_deletar.Location = new Point(1147, 5);             
            }            
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente CANCELAR este registro?", "CANCELAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
        }

        private void SairFormulario()
        {
            DialogResult result = MessageBox.Show("Deseja realmente SAIR deste formulário?", "SAIR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_listaCliente cli = new frm_listaCliente();
                cli.Visible = true;

                this.Close();
            }
        }

        public frm_listaBaseCliente()
        {
            InitializeComponent();

            baseClienteInstancia = this;
        }

        public frm_listaBaseCliente(string codigo, string nomeFantasia)
        {
            InitializeComponent();

            this.txt_codigo.Text = codigo;
            this.txt_nomeCliente.Text = nomeFantasia;

            cliDto.Codigo = codigo;

            List<ClienteDTO> cli = cliBll.SelecionarCliente(cliDto);

            this.img_logomarca.Image = Image.FromFile(Application.StartupPath + cli[0].Logomarca);
        }

        private void frm_listaBaseCliente_Load(object sender, EventArgs e)
        {
            this.EstadoInicial();

            this.lvw_listaBasesCliente.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaBasesCliente.Columns.Add("Item", 60).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaBasesCliente.Columns.Add("Código", 80).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaBasesCliente.Columns.Add("Nome da Base", 350).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaBasesCliente.Columns.Add("Cidade/UF", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaBasesCliente.Columns.Add("CNPJ", 250).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaBasesCliente.Columns.Add("Insc. Estadual", 250).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaBasesCliente.Columns.Add("Status", 90).TextAlign = HorizontalAlignment.Left;

            string cliente = this.txt_nomeCliente.Text;
            this.ListarBasesCliente(cliente);            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoBaseCliente();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {

        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarBaseCliente();
        }

        private void lvw_listaBasesCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            this.SelecionarBaseCliente();
        }

        private void cmb_uf_SelectedValueChanged(object sender, EventArgs e)
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
    }
}
