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
    public partial class frm_addCliente : Form
    {
        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        ClienteTipoDTO tipDto = new ClienteTipoDTO();
        ClienteTipoBLL tipBll = new ClienteTipoBLL();


        public void CriarNovoCliente()
        {
            cliBll.CriarNovoCliente(cliDto);

            Int32 id = cliDto.Id + 1;
            string codigo = "CLI-" + id.ToString("0000#");
            string dataRegistro = DateTime.Now.ToString("dd/MM/yyyy");

            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_salvar.Visible = true;
            

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            this.txt_dataRegistro.Text = dataRegistro;



        }





        private void PopularComboboxTipoCliente()
        {
            List<ClienteTipoDTO> tipo = tipBll.PopularComboboxTipoCliente();

            this.cmb_tipoCliente.DataSource = tipo;
            this.cmb_tipoCliente.DisplayMember = "tipoCliente";
            this.cmb_tipoCliente.Text = "";
        }

        private void SalvarClienteViaProposta()
        {
            cliDto.Id = Int32.Parse(this.txt_id.Text);
            cliDto.Codigo = this.txt_codigo.Text;
            string dataRegistro = this.txt_dataRegistro.Text;
            string[] dataRegistroQuebrada = dataRegistro.Split('/');
            string dia = dataRegistroQuebrada[0];
            string mes = dataRegistroQuebrada[1];
            string ano = dataRegistroQuebrada[2];

            if (dia == "" || mes == "" || ano == "")
            {
                MessageBox.Show("Por favor, Digite a Data da Proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataRegistro.Focus();
                return;
            }
            else
            {
                string dataRegistroBanco = ano + "-" + mes + "-" + dia;
                cliDto.DataRegistro = dataRegistroBanco;
            }

            if (this.cmb_tipoCliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione um tipo de cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoCliente.Focus();
                return;
            }
            else
            {
                cliDto.TipoCliente = this.cmb_tipoCliente.Text;
            }

            if (this.txt_razaoSocial.Text == "")
            {
                MessageBox.Show("Por favor, digite a razão social do cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_razaoSocial.Focus();
                return;
            }
            else
            {
                cliDto.RazaoSocial = this.txt_razaoSocial.Text;
            }

            if (this.txt_nomeFantasia.Text == "")
            {
                MessageBox.Show("Por favor, digite o nome fantasia do cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nomeFantasia.Focus();
                return;
            }
            else
            {
                cliDto.NomeFantasia = this.txt_nomeFantasia.Text;
            }
            
            cliDto.Status = "Ativo";            

            cliBll.SalvarCliente(cliDto);

            MessageBox.Show("Cliente Cadastrado com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.AtualizarComboboxClienteFormProposta();
            
            this.Close();                      
        }

        private void SalvarCliente()
        {
            cliDto.Id = Int32.Parse(this.txt_id.Text);
            cliDto.Codigo = this.txt_codigo.Text;
            string dataRegistro = this.txt_dataRegistro.Text;
            string[] dataRegistroQuebrada = dataRegistro.Split('/');
            string dia = dataRegistroQuebrada[0];
            string mes = dataRegistroQuebrada[1];
            string ano = dataRegistroQuebrada[2];

            if (dia == "" || mes == "" || ano == "")
            {
                MessageBox.Show("Por favor, Digite a Data da Proposta!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataRegistro.Focus();
                return;
            }
            else
            {
                string dataRegistroBanco = ano + "-" + mes + "-" + dia;
                cliDto.DataRegistro = dataRegistroBanco;
            }

            if (this.cmb_tipoCliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione um tipo de cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoCliente.Focus();
                return;
            }
            else
            {
                cliDto.TipoCliente = this.cmb_tipoCliente.Text;
            }

            if (this.txt_razaoSocial.Text == "")
            {
                MessageBox.Show("Por favor, digite a razão social do cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_razaoSocial.Focus();
                return;
            }
            else
            {
                cliDto.RazaoSocial = this.txt_razaoSocial.Text;
            }

            if (this.txt_nomeFantasia.Text == "")
            {
                MessageBox.Show("Por favor, digite o nome fantasia do cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nomeFantasia.Focus();
                return;
            }
            else
            {
                cliDto.NomeFantasia = this.txt_nomeFantasia.Text;
            }

            cliDto.Status = "Ativo";

            cliBll.SalvarCliente(cliDto);

            MessageBox.Show("Cliente Cadastrado com sucesso!", "Cadastrar Cliente!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.AtualizarComboboxClienteFormProposta();

            this.Close();
        }

        private void AtualizarCliente()
        {
            cliDto.Codigo = this.txt_codigo.Text;

            if(this.cmb_tipoCliente.Text == "")
            {
                MessageBox.Show("Por favor, selecione um tipo de cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoCliente.Focus();
                return;
            }
            else
            {
                cliDto.TipoCliente = this.cmb_tipoCliente.Text;
            }

            if(this.txt_razaoSocial.Text == "")
            {
                MessageBox.Show("Por favor, digite a razão social do cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_razaoSocial.Focus();
                return;
            }
            else
            {
                cliDto.RazaoSocial = this.txt_razaoSocial.Text;
            }
            
            if(this.txt_nomeFantasia.Text == "")
            {
                MessageBox.Show("Por favor, digite o nome fantasia do cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nomeFantasia.Focus();
                return;
            }
            else
            {
                cliDto.NomeFantasia = this.txt_nomeFantasia.Text;
            }
            
            if(this.cbx_status.Checked == true)
            {
                cliDto.Status = "Ativo";
            }
            else
            {
                cliDto.Status = "Inativo";
            }

            cliBll.EditarCliente(cliDto);

            MessageBox.Show("Cliente atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listaCliente cli = new frm_listaCliente();
            cli.Visible = true;

            this.Close();
        }


        


        public frm_addCliente()
        {
            InitializeComponent();
        }

        public frm_addCliente(Int32 id, string codigo, DateTime dataRegistro)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            this.txt_dataRegistro.Text = dataRegistro.ToString();

            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_editar.Visible = false;

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.cmb_tipoCliente.Enabled = true;
            this.txt_razaoSocial.Enabled = true;
            this.txt_nomeFantasia.Enabled = true;

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_tipoCliente.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_razaoSocial.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_nomeFantasia.BackColor = Color.FromArgb(255, 255, 192);

            this.btn_cancelar.Location = new Point(1258, 5);
            this.btn_salvar.Location = new Point(1177, 5);

            this.PopularComboboxTipoCliente();
        }

        public frm_addCliente(Int32 id, string codigo, DateTime dataRegistro, string tipoCliente, string razaoSocial, string nomeFantasia, string statusCliente, string logomarca)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            //this.dtp_dataRegistro.Value = dataRegistro;

            this.PopularComboboxTipoCliente();

            this.cmb_tipoCliente.Text = tipoCliente;
            this.txt_razaoSocial.Text = razaoSocial;
            this.txt_nomeFantasia.Text = nomeFantasia;
            if (statusCliente == "Ativo")
            {
                this.cbx_status.Checked = true;
            }
            else
            {
                this.cbx_status.Checked = false;
            }

            this.img_logomarca.Image = Image.FromFile(Application.StartupPath + logomarca);

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            //this.dtp_dataRegistro.Enabled = false;
            this.cmb_tipoCliente.Enabled = false;
            this.txt_razaoSocial.Enabled = false;
            this.txt_nomeFantasia.Enabled = false;
            this.cbx_status.Enabled = false;

            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            //this.dtp_dataRegistro.BackColor = Color.FromArgb(192, 255, 255);
            this.cmb_tipoCliente.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_razaoSocial.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_nomeFantasia.BackColor = Color.FromArgb(255, 255, 192);

            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_editar.Visible = true;

            this.btn_cancelar.Location = new Point(1258, 5);
            this.btn_editar.Location = new Point(1177, 5);
        }

        private void AtualizarComboboxClienteFormProposta()
        {
            frm_addPropostaComercial.clienteInstancia.PopularComboboxCliente();
        }

        private void frm_addCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.cmb_tipoCliente.Enabled = true;
            this.txt_razaoSocial.Enabled = true;
            this.txt_nomeFantasia.Enabled = true;
            this.cbx_status.Enabled = true;

            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = true;
            this.btn_editar.Visible = false;

            this.btn_cancelar.Location = new Point(1258, 5);
            this.btn_atualizar.Location = new Point(1177, 5);
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente ATUALIZAR este Cliente?", "Atualizar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.AtualizarCliente();

                frm_listaCliente cli = new frm_listaCliente();
                cli.Visible = true;

                this.Close();
            }            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente CANCELAR este registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_listaCliente cli = new frm_listaCliente();
                cli.Visible = true;

                this.Close();
            }
        }

        private void btn_salvarLogo_Click(object sender, EventArgs e)
        {
            string codigo = this.txt_codigo.Text + ".jpg";

            cliDto.Logomarca = @"\Imagens\Clientes\" + codigo;

            this.img_logomarca.Image.Save(@"\Imagens\Clientes\" + codigo, img_logomarca.Image.RawFormat);

            cliBll.SalvarLogomarcaCliente(cliDto);

            MessageBox.Show("Logomarca do cliente atualizada com sucesso!", "Logomarca Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listaCliente cli = new frm_listaCliente();
            cli.Visible = true;

            this.Close();

        }

        private void btn_cancelarLogo_Click(object sender, EventArgs e)
        {
            string codigo = this.txt_codigo.Text + ".jpg";

            cliDto.Logomarca = @"\Imagens\Clientes\sem_imagem.jpg";            

            cliBll.SalvarLogomarcaCliente(cliDto);

            MessageBox.Show("Logomarca do cliente deletada com sucesso!", "Logomarca Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listaCliente cli = new frm_listaCliente();
            cli.Visible = true;

            this.Close();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente SALVAR este Cliente?", "Salvar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.SalvarCliente();

                frm_listaCliente cli = new frm_listaCliente();
                cli.Visible = true;

                this.Close();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {

        }
    }
}
