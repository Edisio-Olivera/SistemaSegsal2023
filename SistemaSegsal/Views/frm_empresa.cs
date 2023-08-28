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
    public partial class frm_empresa : Form
    {
        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        CidadeDTO cidDto = new CidadeDTO();
        CidadeBLL cidBll = new CidadeBLL();

        UfDTO ufDto = new UfDTO();
        UfBLL ufBll = new UfBLL();

        private void EstadoInicial()
        {
            //this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            //this.txt_razaoSocial.BackColor = Color.Gold;
            //this.txt_nomeFantasia.BackColor = Color.Gold;
            //this.txt_porte.BackColor = Color.Gold;
            //this.dtp_dataAbertura.BackColor = Color.Gold;
            //this.txt_cnpj.BackColor = Color.Gold;
            //this.txt_inscEstadual.BackColor = Color.Gold;
            //this.txt_naturezaJuridica.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_atividadePrincipal.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_endereco.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_complemento.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_bairro.BackColor = Color.FromArgb(255, 255, 192);
            //this.cmb_uf.BackColor = Color.FromArgb(255, 255, 192);
            //this.cmb_cidade.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_cep.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_email.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_senha.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_telefone.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_celular.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_site.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_instagram.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_facebook.BackColor = Color.FromArgb(255, 255, 192);
            //this.txt_youtube.BackColor = Color.FromArgb(255, 255, 192);

            this.txt_id.Enabled = false;
            this.txt_razaoSocial.Enabled = false;
            this.txt_nomeFantasia.Enabled = false;
            this.txt_porte.Enabled = false;
            this.dtp_dataAbertura.Enabled = false;
            this.txt_cnpj.Enabled = false;
            this.txt_inscEstadual.Enabled = false;
            this.txt_naturezaJuridica.Enabled = false;
            this.txt_atividadePrincipal.Enabled = false;
            this.txt_endereco.Enabled = false;
            this.txt_complemento.Enabled = false;
            this.txt_bairro.Enabled = false;
            this.cmb_uf.Enabled = false;
            this.cmb_cidade.Enabled = false;
            this.txt_cep.Enabled = false;
            this.txt_email.Enabled = false;
            this.txt_senha.Enabled = false;
            this.txt_telefone.Enabled = false;
            this.txt_celular.Enabled = false;
            this.txt_site.Enabled = false;
            this.txt_instagram.Enabled = false;
            this.txt_facebook.Enabled = false;
            this.txt_youtube.Enabled = false;

            this.btn_editar.Visible = true;
            this.btn_sair.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_cancelar.Visible = false;

            this.btn_sair.Location = new Point(68, 712);
            this.btn_editar.Location = new Point(68, 646);

            this.btn_pesqLogo.Enabled = false;
            this.btn_cancelarLogo.Enabled = false;
            this.btn_salvarLogo.Enabled = false;

            this.btn_pesqLogomarca.Enabled = false;
            this.btn_cancelarLogomarca.Enabled = false;
            this.btn_salvarLogomarca.Enabled = false;
        }

        private void CarregarDadosEmpresa()
        {
            List<EmpresaDTO> emp = empBll.SelecionarEmpresa();

            this.txt_id.Text = emp[0].Id.ToString();
            this.txt_razaoSocial.Text = emp[0].RazaoSocial;
            this.txt_nomeFantasia.Text = emp[0].NomeFantasia;
            this.txt_porte.Text = emp[0].Porte;
            var dataAbertura = emp[0].DataAbertura;
            this.dtp_dataAbertura.Value = DateTime.Parse(dataAbertura);
            this.txt_cnpj.Text = emp[0].Cnpj;
            this.txt_inscEstadual.Text = emp[0].InscricaoEstadual;
            this.txt_naturezaJuridica.Text = emp[0].NaturezaJuridica;
            this.txt_atividadePrincipal.Text = emp[0].AtividadePrincipal;
            this.txt_endereco.Text = emp[0].Endereco;
            this.txt_complemento.Text = emp[0].Complemento;
            this.txt_bairro.Text = emp[0].Bairro;

            this.PopularComboboxUf();

            this.cmb_uf.Text = emp[0].Uf;

            this.PopularComboboxCidade(emp[0].Uf);

            this.cmb_cidade.Text = emp[0].Cidade;
            this.txt_cep.Text = emp[0].Cep;
            this.txt_email.Text = emp[0].Email;
            this.txt_senha.Text = emp[0].Senha;
            this.txt_telefone.Text = emp[0].Telefone;
            this.txt_celular.Text = emp[0].Celular;
            this.txt_site.Text = emp[0].Site;
            this.txt_instagram.Text = emp[0].Instagram;
            this.txt_facebook.Text = emp[0].Facebook;
            this.txt_youtube.Text = emp[0].Youtube;

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

        private void EditarEmpresa()
        {
            this.txt_id.Enabled = false;
            this.txt_razaoSocial.Enabled = true;
            this.txt_nomeFantasia.Enabled = true;
            this.txt_porte.Enabled = true;
            this.dtp_dataAbertura.Enabled = true;
            this.txt_cnpj.Enabled = true;
            this.txt_inscEstadual.Enabled = true;
            this.txt_naturezaJuridica.Enabled = true;
            this.txt_atividadePrincipal.Enabled = true;
            this.txt_endereco.Enabled = true;
            this.txt_complemento.Enabled = true;
            this.txt_bairro.Enabled = true;
            this.cmb_uf.Enabled = true;           
            this.cmb_cidade.Enabled = true;
            this.txt_cep.Enabled = true;
            this.txt_email.Enabled = true;
            this.txt_senha.Enabled = true;
            this.txt_telefone.Enabled = true;
            this.txt_celular.Enabled = true;
            this.txt_site.Enabled = true;
            this.txt_instagram.Enabled = true;
            this.txt_facebook.Enabled = true;
            this.txt_youtube.Enabled = true;

            this.btn_editar.Visible = false;
            this.btn_sair.Visible = false;
            this.btn_atualizar.Visible = true;
            this.btn_cancelar.Visible = true;

            this.btn_cancelar.Location = new Point(68, 712);
            this.btn_atualizar.Location = new Point(68, 646);

            this.btn_pesqLogo.Enabled = true;
            this.btn_cancelarLogo.Enabled = false;
            this.btn_salvarLogo.Enabled = false;

            this.btn_pesqLogomarca.Enabled = true;
            this.btn_cancelarLogomarca.Enabled = false;
            this.btn_salvarLogomarca.Enabled = false;
        }

        private void AtualizarEmpresa()
        {
            empDto.RazaoSocial = this.txt_id.Text;
            empDto.RazaoSocial = this.txt_razaoSocial.Text;
            empDto.NomeFantasia = this.txt_nomeFantasia.Text;
            empDto.Porte = this.txt_porte.Text;
            string dataAbertura = dtp_dataAbertura.Value.ToString("yyyy-MM-dd");  
            empDto.DataAbertura = dataAbertura;
            empDto.Cnpj = this.txt_cnpj.Text;
            empDto.InscricaoEstadual = this.txt_inscEstadual.Text;
            empDto.NaturezaJuridica = this.txt_naturezaJuridica.Text;
            empDto.AtividadePrincipal = this.txt_atividadePrincipal.Text;
            empDto.Endereco = this.txt_endereco.Text;
            empDto.Complemento = this.txt_complemento.Text;
            empDto.Bairro = this.txt_bairro.Text;
            empDto.Uf = this.cmb_uf.Text;
            empDto.Cidade = this.cmb_cidade.Text;
            empDto.Cep = this.txt_cep.Text;
            empDto.Email = this.txt_email.Text;
            empDto.Senha = this.txt_senha.Text;
            empDto.Telefone = this.txt_telefone.Text;
            empDto.Celular = this.txt_celular.Text;
            empDto.Site = this.txt_site.Text;
            empDto.Instagram = this.txt_instagram.Text;
            empDto.Facebook = this.txt_facebook.Text;
            empDto.Youtube = this.txt_youtube.Text;

            empBll.EditarEmpresa(empDto);

            MessageBox.Show("Dados atualizados com sucesso!", "Dados da Empresa!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
        }

        public frm_empresa()
        {
            InitializeComponent();
        }

        private void frm_empresa_Load(object sender, EventArgs e)
        {
            //Designer do form
            this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";

            this.EstadoInicial();
            this.CarregarDadosEmpresa();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarEmpresa();
        }

        private void cmb_uf_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_uf.Text == "SistemaSegsal.DTO.UfDTO")
            {
                return;
            }
            else
            {
                string estado = this.cmb_uf.Text;

                this.PopularComboboxCidade(estado);

                this.cmb_cidade.Enabled = true;
                this.cmb_cidade.Focus();
            }


        }

        private void cmb_uf_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarEmpresa();
        }
    }
}
