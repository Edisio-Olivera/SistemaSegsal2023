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
using SistemaSegsal.DAO;
using SistemaSegsal.Views;

namespace SistemaSegsal.View
{
    public partial class frm_listaContatoCliente : Form
    {
        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        ClienteContatoDTO cntDto = new ClienteContatoDTO();
        ClienteContatoBLL cntBll = new ClienteContatoBLL();

        ClienteContatoStatusDTO ccsDto = new ClienteContatoStatusDTO();
        ClienteContatoStatusBLL ccsBll = new ClienteContatoStatusBLL();

        DepartamentoDTO depDto = new DepartamentoDTO();
        DepartamentoBLL depBll = new DepartamentoBLL();

        private void EstadoInicial()
        {
            //Visualização dos Botões
            //this.btn_novo.Visible = true;
            //this.btn_salvar.Visible = false;
            //this.btn_cancelar.Visible = false;
            //this.btn_editar.Visible = false;
            //this.btn_atualizar.Visible = false;
            //this.btn_deletar.Visible = false;
            //this.btn_sair.Visible = true;

            ////Posição dos Botões
            //this.btn_sair.Location = new Point(1258, 5);
            //this.btn_novo.Location = new Point(1177, 5);

            //this.txt_id.Enabled = false;
            //this.txt_cliente.Enabled = false;
            //this.txt_nome.Enabled = false;
            //this.txt_telefone.Enabled = false;
            //this.txt_email.Enabled = false;
            //this.cmb_departamento.Enabled = false;
            //this.cbx_status.Visible = false;
            //this.lvw_listaContatos.Enabled = true;

            //this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            //this.txt_cliente.BackColor = Color.FromArgb(192, 255, 255);
            //this.txt_nome.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_telefone.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_email.BackColor = Color.FromArgb(255, 255, 192);
            //this.cmb_departamento.BackColor = Color.FromArgb(255, 255, 192);

            //this.txt_id.Text = "";
            //this.txt_nome.Text = "";
            //this.txt_telefone.Text = "";
            //this.txt_email.Text = "";
            //this.cmb_departamento.Text = "";
            //this.cbx_status.Checked = false;
        }

        private void NovoContatoCliente()
        {
            //cntBll.CriarNovoContato(cntDto);

            //Int32 id = cntDto.Id + 1;

            //this.txt_id.Text = id.ToString();

            //this.btn_novo.Visible = false;
            //this.btn_salvar.Visible = true;
            //this.btn_cancelar.Visible = true;
            //this.btn_editar.Visible = false;
            //this.btn_atualizar.Visible = false;
            //this.btn_deletar.Visible = false;
            //this.btn_sair.Visible = false;

            ////Posição dos Botões
            //this.btn_cancelar.Location = new Point(1258, 5);
            //this.btn_salvar.Location = new Point(1177, 5);

            //this.txt_id.Enabled = false;
            //this.txt_cliente.Enabled = false;
            //this.txt_nome.Enabled = true;
            //this.txt_telefone.Enabled = true;
            //this.txt_email.Enabled = true;
            //this.cmb_departamento.Enabled = true;

            //this.PopularComboboxDepartamento();

            //this.lvw_listaContatos.Enabled = false;
            //this.txt_nome.Focus();
        }

        private void SalvarContatoCliente()
        {
            //cntDto.Id = Int32.Parse(this.txt_id.Text);
            //cntDto.Cliente = this.txt_cliente.Text;
            //cntDto.Nome = this.txt_nome.Text;
            //cntDto.Telefone = txt_telefone.Text;
            //cntDto.Email = this.txt_email.Text;
            //cntDto.Departamento = this.cmb_departamento.Text;
            //cntDto.Status = "Ativo";

            //cntBll.SalvarContatoCliente(cntDto);

            //MessageBox.Show("Contato SALVO com sucesso!", "SALVAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.EstadoInicial();
            //this.ListarContatos();
        }

        private void EditarContatoCliente()
        {
            //this.btn_novo.Visible = false;
            //this.btn_salvar.Visible = false;
            //this.btn_cancelar.Visible = true;
            //this.btn_editar.Visible = false;
            //this.btn_atualizar.Visible = true;
            //this.btn_deletar.Visible = false;
            //this.btn_sair.Visible = false;

            ////Posição dos Botões
            //this.btn_cancelar.Location = new Point(1258, 5);
            //this.btn_atualizar.Location = new Point(1177, 5);

            //this.txt_id.Enabled = false;
            //this.txt_cliente.Enabled = false;
            //this.txt_nome.Enabled = true;
            //this.txt_telefone.Enabled = true;
            //this.txt_email.Enabled = true;
            //this.cmb_departamento.Enabled = true;
            //this.cbx_status.Visible = true;
        }

        private void AtualizarContatoCliente()
        {
            //cntDto.Id = Int32.Parse(this.txt_id.Text);
            //cntDto.Cliente = this.txt_cliente.Text;
            //cntDto.Nome = this.txt_nome.Text;
            //cntDto.Telefone = txt_telefone.Text;
            //cntDto.Email = this.txt_email.Text;
            //cntDto.Departamento = this.cmb_departamento.Text;
            //if (this.cbx_status.Checked == true)
            //{
            //    cntDto.Status = "Ativo";
            //}
            //else
            //{
            //    cntDto.Status = "Inativo";
            //}

            //cntBll.EditarContatoCliente(cntDto);

            //MessageBox.Show("Contato ATUALIZADO com sucesso!", "ATUALIZAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.EstadoInicial();
            //this.ListarContatos();
        }

        private void DeletarContatoCliente()
        {
            //cntDto.Id = Int32.Parse(this.txt_id.Text);

            //DialogResult result = MessageBox.Show("Deseja realmente DELETAR este registro?", "DELETAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    cntBll.ExcluirContatoCliente(cntDto);

            //    MessageBox.Show("Contato DELETADO com sucesso!", "DELETAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}            

            //this.EstadoInicial();
            //this.ListarContatos();
        }

        private void SelecionarContatoCliente()
        {
            //cntDto.Id = Int32.Parse(this.lvw_listaContatos.SelectedItems[0].SubItems[0].Text);

            //List<ClienteContatoDTO> cont = cntBll.SelecionarContatoCliente(cntDto);

            //this.txt_id.Text = cont[0].Id.ToString();
            //this.txt_nome.Text = cont[0].Nome;
            //this.txt_telefone.Text = cont[0].Telefone;
            //this.txt_email.Text = cont[0].Email;

            //this.PopularComboboxDepartamento();

            //this.cmb_departamento.Text = cont[0].Departamento;
            //if(cont[0].Status == "Ativo")
            //{
            //    this.cbx_status.Checked = true;
            //}
            //else
            //{
            //    this.cbx_status.Checked = false;
            //}

            //this.btn_novo.Visible = false;
            //this.btn_salvar.Visible = false;
            //this.btn_cancelar.Visible = true;
            //this.btn_editar.Visible = true;
            //this.btn_atualizar.Visible = false;
            //this.btn_deletar.Visible = true;
            //this.btn_sair.Visible = false;

            ////Posição dos Botões
            //this.btn_cancelar.Location = new Point(1258, 5);
            //this.btn_deletar.Location = new Point(1177, 5);
            //this.btn_editar.Location = new Point(1096, 5);

            //this.cbx_status.Visible = true;
        }

        private void PopularComboboxDepartamento()
        {
            //List<DepartamentoDTO> dep = depBll.PopularComboboxDepartamento();

            //this.cmb_departamento.DataSource = dep;
            //this.cmb_departamento.DisplayMember = "departamento";
            //this.cmb_departamento.Text = "";
        }

        private void ListarContatos()
        {
            //cntDto.Cliente = this.txt_cliente.Text;

            this.lvw_listaContatos.Items.Clear();

            string[] item = new string[7];
            int prox = 1;
            var listaContato = cntBll.ListarContatoCliente(cntDto);            

            foreach (ClienteContatoDTO cont in listaContato)
            {
                item[0] = cont.Id.ToString();
                item[1] = prox.ToString();
                item[2] = cont.Departamento;
                item[3] = cont.Nome;
                item[4] = cont.Telefone;
                item[5] = cont.Email;
                item[6] = cont.Status;

                lvw_listaContatos.Items.Add(new ListViewItem(item));
                prox = prox + 1;
            }
        }


        public frm_listaContatoCliente()
        {
            InitializeComponent();
        }

        public frm_listaContatoCliente(string codigo, string cliente)
        {
            InitializeComponent();

            //this.txt_cliente.Text = cliente;

            cliDto.Codigo = codigo;
            List<ClienteDTO> cli = cliBll.SelecionarCliente(cliDto);

            this.img_logomarca.Image = Image.FromFile(Application.StartupPath + cli[0].Logomarca);
        }


        private void frm_listaContatoCliente_Load(object sender, EventArgs e)
        {
            //Designer do form
            this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";
            this.BackColor = Color.FromArgb(255, 255, 255);

            this.EstadoInicial();

            //Designer do listview
            this.lvw_listaContatos.BackColor = Color.FromArgb(255, 255, 192);

            this.lvw_listaContatos.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaContatos.Columns.Add("Item", 60).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaContatos.Columns.Add("Departamento", 250).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContatos.Columns.Add("Nome", 450).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContatos.Columns.Add("Telefone", 120).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContatos.Columns.Add("E-mail", 300).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaContatos.Columns.Add("Status", 100).TextAlign = HorizontalAlignment.Center;

            this.ListarContatos();            
        }        

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente CANCELAR este registro?", "CANCELAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.NovoContatoCliente();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarContatoCliente();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarContatoCliente();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarContatoCliente();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente SAIR deste formulário?", "SAIR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_listaCliente cli = new frm_listaCliente();
                cli.Visible = true;

                this.Close();
            }
        }

        private void lvw_listaContatos_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaContatos.SelectedItems.Count > 0)
            {
                this.SelecionarContatoCliente();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            this.DeletarContatoCliente();
        }
    }
}
