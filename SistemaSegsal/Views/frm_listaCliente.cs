using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.View;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.DAO;

namespace SistemaSegsal.Views
{
    public partial class frm_listaCliente : Form
    {
        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        ClienteTipoDTO tipDto = new ClienteTipoDTO();
        ClienteTipoBLL tipBll = new ClienteTipoBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        ClienteStatusDTO staDto = new ClienteStatusDTO();
        ClienteStatusBLL staBll = new ClienteStatusBLL();

        PropostaComercialDTO proDto = new PropostaComercialDTO();
        PropostaComercialBLL proBll = new PropostaComercialBLL();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        public static frm_listaCliente clienteInstancia;

        private void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_base.Visible = false;
            this.btn_contato.Visible = false;
            this.btn_sair.Visible = true;

            this.lvw_listaClientes.Enabled = true;

            this.btn_sair.Location = new Point(1277, 5);
            this.btn_novo.Location = new Point(1212, 5);            

            //this.img_logomarca.Image = Image.FromFile(Application.StartupPath + @"\Imagens\Clientes\sem_imagem.jpg");
        }
        
        private void NovoCliente()
        {
            cliBll.CriarNovoCliente(cliDto);

            Int32 id = cliDto.Id + 1;
            string codigo = "CLI-" + id.ToString("000#");
            DateTime dataRegistro = DateTime.Now.Date;

            frm_addCliente cli = new frm_addCliente(id, codigo, dataRegistro);
            cli.Visible = true;            
        }

        private void EditarCliente()
        {
            string codigo = this.lvw_listaClientes.SelectedItems[0].SubItems[2].Text;

            frm_addCliente cliente = new frm_addCliente(codigo);
            cliente.Visible = true;
        }
        
        private void DeletarCliente()
        {
            DialogResult result = MessageBox.Show("Deseja realmente DELETAR este Cliente?", "DELETAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Int32 qtdBases = Int32.Parse(this.lvw_listaClientes.SelectedItems[0].SubItems[6].Text);

                if(qtdBases > 0)
                {
                    MessageBox.Show("O Cliente possui " + qtdBases + " cadastradas e, não pode ser deletado!", "Qtd de Bases!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    return;
                }
                else
                {
                    cliDto.Codigo = lvw_listaClientes.SelectedItems[0].SubItems[2].Text;

                    cliBll.ExcluirCliente(cliDto);

                    this.EstadoInicial();
                    this.ListarClientes();
                }
            }            
        }

        private void BaseCliente()
        {
            cliDto.Codigo = lvw_listaClientes.SelectedItems[0].SubItems[2].Text;

            List<ClienteDTO> cli = cliBll.SelecionarCliente(cliDto);

            string codigo = cli[0].Codigo;
            string nomeFantasia = cli[0].NomeFantasia;

            frm_listaBaseCliente baseCli = new frm_listaBaseCliente(codigo, nomeFantasia);
            baseCli.Visible = true;

            this.Close();
        }

        public void ListarClientes()
        {
            string[] item = new string[7];
            int prox = 1;
            var listaCliente = cliBll.ListarClientes();

            this.lvw_listaClientes.Items.Clear();

            foreach (ClienteDTO pro in listaCliente)
            {
                item[0] = pro.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pro.Codigo;
                item[3] = pro.TipoCliente;
                item[4] = pro.RazaoSocial;
                item[5] = pro.NomeFantasia;

                basDto.Cliente = pro.NomeFantasia;
                Int32 qtdBase = basBll.ContarBasesPorCliente(basDto);

                item[6] = qtdBase.ToString();

                lvw_listaClientes.Items.Add(new ListViewItem(item));
                prox = prox + 1;
            }
        }

        public void ListarClientesStatus(string statusCliente)
        {
            cliDto.Status = statusCliente;
            string[] item = new string[8];
            int prox = 1;
            var listaCliente = cliBll.ListarClientesStatus(cliDto);

            this.lvw_listaClientes.Items.Clear();

            foreach (ClienteDTO pro in listaCliente)
            {
                item[0] = pro.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pro.Codigo;
                item[3] = pro.TipoCliente;
                item[4] = pro.RazaoSocial;
                item[5] = pro.NomeFantasia;

                basDto.Cliente = pro.NomeFantasia;
                Int32 qtdBase = basBll.ContarBasesPorCliente(basDto);

                item[6] = qtdBase.ToString();

                lvw_listaClientes.Items.Add(new ListViewItem(item));
                prox = prox + 1;
            }
        }

        private void SelecionarCliente()
        {
            cliDto.Codigo = this.lvw_listaClientes.SelectedItems[0].SubItems[2].Text;

            List<ClienteDTO> cli = cliBll.SelecionarCliente(cliDto);

            string logoCli = cli[0].Logomarca;

            this.img_logomarca.Image = Image.FromFile(Application.StartupPath + logoCli);

            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_base.Visible = true;
            this.btn_contato.Visible = true;
            this.btn_sair.Visible = false;

            this.lvw_listaClientes.Enabled = true;

            this.btn_cancelar.Location = new Point(1277, 5);
            this.btn_contato.Location = new Point(1212, 5);
            this.btn_base.Location = new Point(1147, 5);
            this.btn_deletar.Location = new Point(1082, 5);
            this.btn_editar.Location = new Point(1017, 5);            
        }

        private void PopularComboboxStatusCliente()
        {
            List<ClienteStatusDTO> sta = staBll.PopularComboboxCliente();

            this.cmb_status.DataSource = sta;
            this.cmb_status.DisplayMember = "status";
            this.cmb_status.Text = "";
        }

        private void SairFormulario()
        {
            DialogResult result = MessageBox.Show("Deseja realmente SAIR deste formulário?", "SAIR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_principal pri = new frm_principal();
                pri.Visible = true;

                this.Close();
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

        public frm_listaCliente()
        {
            InitializeComponent();

            clienteInstancia = this;
        }

        private void frm_listaCliente_Load(object sender, EventArgs e)
        {            
            this.EstadoInicial();

            //1309
            this.lvw_listaClientes.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaClientes.Columns.Add("Item", 60).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaClientes.Columns.Add("Código", 80).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaClientes.Columns.Add("Tipo", 150).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaClientes.Columns.Add("Razao Social", 400).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaClientes.Columns.Add("Nome Fantasia", 519).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaClientes.Columns.Add("Qtd Bases", 80).TextAlign = HorizontalAlignment.Center;

            string statusCli = "Ativo";
            this.ListarClientesStatus(statusCli);
            this.PopularComboboxStatusCliente();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.NovoCliente();
        }

        private void lvw_listaClientes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaClientes.SelectedItems.Count > 0)
            {
                this.SelecionarCliente();                
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarCliente();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void lvw_listaClientes_SelectedIndexChanged(object sender, EventArgs e)
        {            
            
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            this.DeletarCliente();
        }

        private void btn_base_Click(object sender, EventArgs e)
        {
            this.BaseCliente();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_contato_Click(object sender, EventArgs e)
        {
            string codigo = this.lvw_listaClientes.SelectedItems[0].SubItems[2].Text;
            string cliente = this.lvw_listaClientes.SelectedItems[0].SubItems[5].Text;
            
            frm_listaContatoCliente cont = new frm_listaContatoCliente(codigo, cliente);           
            cont.Visible = true;

            this.Close();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_status.Text == "SistemaSegsal.DTO.ClienteStatusDTO")
            {
                return;
            }
            else
            {
                string status = this.cmb_status.Text;

                this.ListarClientesStatus(status);
            }
        }
    }
}
