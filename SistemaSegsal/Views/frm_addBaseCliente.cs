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
    public partial class frm_addBaseCliente : Form
    {
        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        CidadeDTO cidDto = new CidadeDTO();
        CidadeBLL cidBll = new CidadeBLL();

        UfDTO ufDto = new UfDTO();
        UfBLL ufBll = new UfBLL();

        private void NovoBaseCliente(Int32 id, string codigo, DateTime dataRegistro, string cliente)
        {
            basDto.Id = id;

            basBll.CriarNovoBaseCliente(basDto);

            this.txt_id.Text = id.ToString();
            this.txt_codigoBase.Text = codigo;
            this.txt_dataRegistro.Text = dataRegistro.ToString("dd/MM/yyyy");
            this.txt_cliente.Text = cliente;

            this.txt_id.Enabled = false;
            this.txt_codigoBase.Enabled = false;
            this.txt_dataRegistro.Enabled = false;
            this.txt_cliente.Enabled = false;
            this.txt_nomeBase.Enabled = true;
            this.txt_endereco.Enabled = true;
            this.txt_complemento.Enabled = true;
            this.txt_bairro.Enabled = true;

            this.PopularComboboxUf();

            this.cmb_uf.Enabled = true;

            //this.PopularComboboxCidade(cmb_uf.Text);

            this.cmb_cidade.Enabled = false;
            this.txt_cep.Enabled = true;
            this.txt_cnpj.Enabled = true;
            this.txt_inscEstadual.Enabled = true;
            this.cbx_status.Enabled = true;

            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_salvar.Visible = true;
            this.btn_atualizar.Visible = false;

            this.btn_cancelar.Location = new Point(700, 5);
            this.btn_salvar.Location = new Point(634, 5);
            this.txt_nomeBase.Focus();
        }

        private void CarregarBaseCliente(string codigo)
        {
            basDto.Codigo = codigo;

            List<BaseClienteDTO> bas = basBll.SelecionarBaseCliente(basDto);

            this.txt_id.Text = bas[0].Id.ToString();
            this.txt_codigoBase.Text = bas[0].Codigo;
            this.txt_dataRegistro.Text = bas[0].DataRegistro;
            this.txt_cliente.Text = bas[0].Cliente;
            this.txt_nomeBase.Text = bas[0].NomeBase;
            this.txt_endereco.Text = bas[0].Endereco;
            this.txt_complemento.Text = bas[0].Complemento;
            this.txt_bairro.Text = bas[0].Bairro;

            this.PopularComboboxUf();

            this.cmb_uf.Text = bas[0].Uf;

            this.PopularComboboxCidade(bas[0].Uf);

            this.cmb_cidade.Text = bas[0].Cidade;
            this.txt_cep.Text = bas[0].Cep;
            this.txt_cnpj.Text = bas[0].Cnpj;
            this.txt_inscEstadual.Text = bas[0].InscEstadual;

            if (bas[0].Status == "Ativo")
            {
                this.cbx_status.Checked = true;
            }
            else
            {
                this.cbx_status.Checked = false;
            }

            this.txt_id.Enabled = false;
            this.txt_codigoBase.Enabled = false;
            this.txt_dataRegistro.Enabled = false;
            this.txt_cliente.Enabled = false;
            this.txt_nomeBase.Enabled = false;
            this.txt_endereco.Enabled = false;
            this.txt_complemento.Enabled = false;
            this.txt_bairro.Enabled = false;
            this.cmb_uf.Enabled = false;
            this.cmb_cidade.Enabled = false;
            this.txt_cep.Enabled = false;
            this.txt_cnpj.Enabled = false;
            this.txt_inscEstadual.Enabled = false;
            this.cbx_status.Enabled = false;

            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = true;

            this.btn_cancelar.Location = new Point(700, 5);
            this.btn_atualizar.Location = new Point(634, 5);
        }

        private void EditarBaseCliente()
        {
            this.txt_id.Enabled = false;
            this.txt_codigoBase.Enabled = false;
            this.txt_dataRegistro.Enabled = false;
            this.txt_cliente.Enabled = false;            

            this.txt_nomeBase.Enabled = true;
            this.txt_endereco.Enabled = true;
            this.txt_complemento.Enabled = true;
            this.txt_bairro.Enabled = true;

            this.PopularComboboxUf();

            this.cmb_uf.Enabled = true;
            this.cmb_cidade.Enabled = true;
            this.txt_cep.Enabled = true;
            this.txt_cnpj.Enabled = true;
            this.txt_inscEstadual.Enabled = true;
            this.cbx_status.Enabled = true;

            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = true;

            this.btn_cancelar.Location = new Point(500, 5);
            this.btn_atualizar.Location = new Point(480, 5);

            this.txt_nomeBase.Enabled = true;
            this.txt_endereco.Enabled = true;
            this.txt_complemento.Enabled = true;
            this.txt_bairro.Enabled = true;
            this.cmb_uf.Enabled = true;
            this.cmb_cidade.Enabled = true;
            this.txt_cep.Enabled = true;
            this.txt_cnpj.Enabled = true;
            this.txt_inscEstadual.Enabled = true;
            this.cbx_status.Enabled = true;

            this.txt_nomeBase.Focus();
        }

        private void PopularComboboxUf()
        {
            List<UfDTO> estado = ufBll.PopularComboboxUf();

            this.cmb_uf.DataSource = estado;
            this.cmb_uf.DisplayMember = "sigla";
            this.cmb_uf.Text = "";
        }

        private void PopularComboboxCidade(string estado)
        {
            cidDto.Uf = estado;

            List<CidadeDTO> cidade = cidBll.PopularComboboxCidade(cidDto);

            this.cmb_cidade.Enabled = true;
            this.cmb_cidade.DataSource = cidade;
            this.cmb_cidade.DisplayMember = "cidade";
            this.cmb_cidade.Text = "";
        }

        private void SalvarBaseCliente()
        {
            basDto.Id = Int32.Parse(this.txt_id.Text);
            basDto.Codigo = this.txt_codigoBase.Text;

            string dataRegistroForm = this.txt_dataRegistro.Text;
            string[] dataRegistroQuebrada = dataRegistroForm.Split('/');
            string dia = dataRegistroQuebrada[0];
            string mes = dataRegistroQuebrada[1];
            string ano = dataRegistroQuebrada[2];

            string dataChamadoBanco = ano + "-" + mes + "-" + dia;
            basDto.DataRegistro = dataChamadoBanco;

            basDto.Cliente = this.txt_cliente.Text;

            if (this.txt_nomeBase.Text == "")
            {
                MessageBox.Show("Por favor, digite um nome para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nomeBase.Focus();
                return;
            }
            else
            {
                basDto.NomeBase = this.txt_nomeBase.Text;
            }

            if (this.txt_endereco.Text == "")
            {
                basDto.Endereco = "-";
            }
            else
            {
                basDto.Endereco = this.txt_endereco.Text;
            }

            if (this.txt_complemento.Text == "")
            {
                basDto.Complemento = "-";
            }
            else
            {
                basDto.Complemento = this.txt_complemento.Text;
            }

            if (this.txt_bairro.Text == "")
            {
                basDto.Bairro = "-";
            }
            else
            {
                basDto.Bairro = this.txt_bairro.Text;
            }

            if (this.cmb_uf.Text == "")
            {
                MessageBox.Show("Por favor, selecione um Estado para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_uf.Focus();
                return;
            }
            else
            {
                basDto.Uf = this.cmb_uf.Text;
            }

            if (this.cmb_cidade.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma Cidade para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cidade.Focus();
                return;
            }
            else
            {
                basDto.Cidade = this.cmb_cidade.Text;
            }

            if (this.txt_cep.Text == "")
            {
                basDto.Cep = "-";
            }
            else
            {
                basDto.Cep = this.txt_cep.Text;
            }

            if (this.txt_cnpj.Text == "")
            {                
                basDto.Cnpj = "-";
            }
            else
            {
                //00.000.000/0000-00
                var cnpj = this.txt_cnpj.Text;

                basDto.Cnpj = string.Join("", cnpj.ToCharArray().Where(Char.IsDigit));
            }

            if (this.txt_inscEstadual.Text == "")
            {
                basDto.InscEstadual = "-";
            }
            else
            {
                basDto.InscEstadual = this.txt_inscEstadual.Text;
            }

            basDto.Status = "Ativo";

            basBll.SalvarBaseCliente(basDto);

            MessageBox.Show("Base de Cliente SALVO com sucesso!", "SALVAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string cliente = basDto.Cliente;
            //frm_listaBaseCliente.baseClienteInstancia.ListarBasesCliente(cliente);
        }

        private void AtualizarBaseCliente()
        {
            basDto.Codigo = this.txt_codigoBase.Text;
            basDto.Cliente = this.txt_cliente.Text;

            if (this.txt_nomeBase.Text == "")
            {
                MessageBox.Show("Por favor, digite um nome para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nomeBase.Focus();
                return;
            }
            else
            {
                basDto.NomeBase = this.txt_nomeBase.Text;
            }

            if (this.txt_endereco.Text == "")
            {
                basDto.Endereco = "-";
            }
            else
            {
                basDto.Endereco = this.txt_endereco.Text;
            }

            if (this.txt_complemento.Text == "")
            {
                basDto.Complemento = "-";
            }
            else
            {
                basDto.Complemento = this.txt_complemento.Text;
            }

            if (this.txt_bairro.Text == "")
            {
                basDto.Bairro = "-";
            }
            else
            {
                basDto.Bairro = this.txt_bairro.Text;
            }

            if (this.cmb_uf.Text == "")
            {
                MessageBox.Show("Por favor, selecione um Estado para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_uf.Focus();
                return;
            }
            else
            {
                basDto.Uf = this.cmb_uf.Text;
            }

            if (this.cmb_cidade.Text == "")
            {
                MessageBox.Show("Por favor, selecione uma Cidade para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_cidade.Focus();
                return;
            }
            else
            {
                basDto.Cidade = this.cmb_cidade.Text;
            }

            if (this.txt_cep.Text == "")
            {
                basDto.Cep = "-";
            }
            else
            {
                basDto.Cep = this.txt_cep.Text;
            }

            if (this.txt_cnpj.Text == "")
            {
                basDto.Cnpj = "-";
            }
            else
            {
                //00.000.000/0000-00
                var cnpj = this.txt_cnpj.Text;

                basDto.Cnpj = string.Join("", cnpj.ToCharArray().Where(Char.IsDigit));
            }

            if (this.txt_inscEstadual.Text == "")
            {
                basDto.InscEstadual = "-";
            }
            else
            {
                basDto.InscEstadual = this.txt_inscEstadual.Text;
            }

            if (this.cbx_status.Checked == true)
            {
                basDto.Status = "Ativo";
            }
            else
            {
                basDto.Status = "Inativo";
            }

            basBll.EditarBaseCliente(basDto);

            MessageBox.Show("Base de Cliente Atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            string cliente = basDto.Cliente;
            //frm_listaBaseCliente.baseClienteInstancia.ListarBasesCliente(cliente);
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente CANCELAR este registro?", "CANCELAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        public frm_addBaseCliente()
        {
            InitializeComponent();
        }

        //Novo Base Cliente
        public frm_addBaseCliente(Int32 id, string codigo, DateTime dataRegistro, string cliente)
        {
            InitializeComponent();

            this.NovoBaseCliente(id, codigo, dataRegistro, cliente);            
        }

        //Editar Base Cliente
        public frm_addBaseCliente(string codigo)
        {
            InitializeComponent();

            this.CarregarBaseCliente(codigo);            
        }

        private void frm_addBaseCliente_Load(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarBaseCliente();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarBaseCliente();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarBaseCliente();
        }

        private void cmb_uf_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_uf.Text == "SistemaSegsal.DTO.UfDTO")
            {
                return;
            }
            else
            {
                string uf = this.cmb_uf.Text;

                this.PopularComboboxCidade(uf);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }
    }
}
