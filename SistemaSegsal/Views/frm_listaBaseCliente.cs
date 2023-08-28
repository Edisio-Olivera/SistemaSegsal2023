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

        private void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_contato.Visible = false;
            this.btn_sair.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = false;

            this.lvw_listaBasesCliente.Enabled = true;

            this.btn_sair.Location = new Point(1258, 5);
            this.btn_novo.Location = new Point(1177, 5);

            this.txt_codigo.Enabled = false;
            this.txt_nomeCliente.Enabled = false;
            this.txt_id.Enabled = false;
            this.dtp_dataRegistro.Enabled = false;
            this.txt_codigoBase.Enabled = false;
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

            this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_nomeCliente.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            this.dtp_dataRegistro.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_codigoBase.BackColor = Color.FromArgb(192, 255, 255);
            this.txt_nomeBase.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_endereco.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_complemento.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_bairro.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_uf.BackColor = Color.FromArgb(255, 255, 192);
            this.cmb_cidade.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_cep.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_cnpj.BackColor = Color.FromArgb(255, 255, 192);
            this.txt_inscEstadual.BackColor = Color.FromArgb(255, 255, 192);
            this.lvw_listaBasesCliente.BackColor = Color.FromArgb(255, 255, 192);
                        
            this.txt_id.Text = "";
            this.dtp_dataRegistro.Value = DateTime.Now;
            this.txt_codigoBase.Text = "";
            this.txt_nomeBase.Text = "";
            this.txt_endereco.Text = "";
            this.txt_complemento.Text = "";
            this.txt_bairro.Text = "";
            this.cmb_uf.Text = "";
            this.cmb_cidade.Text = "";
            this.txt_cep.Text = "";
            this.txt_cnpj.Text = "";
            this.txt_inscEstadual.Text = "";
            this.cbx_status.Checked = false;
        }

        private void NovoBaseCliente()
        {
            basBll.CriarNovoBaseCliente(basDto);

            Int32 id = basDto.Id + 1;
            this.txt_id.Text = id.ToString();
            string prox = "BAS-" + id.ToString("000#");
            this.txt_codigoBase.Text = prox;

            this.txt_codigo.Enabled = false;
            this.txt_nomeCliente.Enabled = false;
            this.txt_id.Enabled = false;
            this.dtp_dataRegistro.Enabled = false;
            this.txt_codigoBase.Enabled = false;

            this.txt_nomeBase.Enabled = true;
            this.txt_endereco.Enabled = true; 
            this.txt_complemento.Enabled = true;
            this.txt_bairro.Enabled = true;

            this.PopularComboboxUf();

            this.cmb_uf.Enabled = true;
            this.cmb_cidade.Enabled = false;
            this.txt_cep.Enabled = true;
            this.txt_cnpj.Enabled = true;
            this.txt_inscEstadual.Enabled = true;
            this.cbx_status.Enabled = true;

            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_contato.Visible = false;
            this.btn_sair.Visible = true;
            this.btn_salvar.Visible = true;
            this.btn_atualizar.Visible = false;

            this.lvw_listaBasesCliente.Enabled = false;

            this.btn_cancelar.Location = new Point(1258, 5);
            this.btn_salvar.Location = new Point(1177, 5);

            this.txt_nomeBase.Focus();
        }

        private void EditarBaseCliente()
        {
            this.txt_codigo.Enabled = false;
            this.txt_nomeCliente.Enabled = false;
            this.txt_id.Enabled = false;
            this.dtp_dataRegistro.Enabled = false;
            this.txt_codigoBase.Enabled = false;

            this.txt_nomeBase.Enabled = true;
            this.txt_endereco.Enabled = true;
            this.txt_complemento.Enabled = true;
            this.txt_bairro.Enabled = true;

            //this.PopularComboboxUf();

            this.cmb_uf.Enabled = true;
            this.cmb_cidade.Enabled = true;
            this.txt_cep.Enabled = true;
            this.txt_cnpj.Enabled = true;
            this.txt_inscEstadual.Enabled = true;
            this.cbx_status.Enabled = true;

            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_contato.Visible = false;
            this.btn_sair.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = true;

            this.lvw_listaBasesCliente.Enabled = false;

            this.btn_cancelar.Location = new Point(1258, 5);
            this.btn_atualizar.Location = new Point(1177, 5);

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

            //this.cmb_cidade.Enabled = true;
            this.cmb_cidade.DataSource = cidade;
            this.cmb_cidade.DisplayMember = "cidade";
            this.cmb_cidade.Text = "";
        }

        private void SalvarBaseCliente()
        {
            basDto.Id = Int32.Parse(this.txt_id.Text);
            basDto.Codigo = this.txt_codigoBase.Text;
            var dataReg = this.dtp_dataRegistro.Value.ToString("yyyy-MM-dd");
            basDto.DataRegistro = dataReg;
            
            if(this.txt_nomeBase.Text == "")
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

            if(this.txt_complemento.Text == "")
            {
                basDto.Complemento = "-";
            }
            else
            {
                basDto.Complemento = this.txt_complemento.Text;
            }

            if(this.txt_bairro.Text == "")
            {
                basDto.Bairro = "-";
            }
            else
            {
                basDto.Bairro = this.txt_bairro.Text;
            }

            if(this.cmb_uf.Text == "")
            {
                MessageBox.Show("Por favor, selecione um Estado para a Base do Cliente!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_uf.Focus();
                return;
            }
            else
            {
                basDto.Uf = this.cmb_uf.Text;
            }

            if(this.cmb_cidade.Text == "")
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
                basDto.Cnpj = this.txt_cnpj.Text;
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

            this.EstadoInicial();
            string cliente = basDto.Cliente;
            this.ListarBasesCliente(cliente);
        }

        private void AtualizarBaseCliente()
        {
            basDto.Codigo = this.txt_codigoBase.Text;

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
                basDto.Cnpj = this.txt_cnpj.Text;
            }

            if (this.txt_inscEstadual.Text == "")
            {
                basDto.InscEstadual = "-";
            }
            else
            {
                basDto.InscEstadual = this.txt_inscEstadual.Text;
            }

            if(this.cbx_status.Checked == true)
            {
                basDto.Status = "Ativo";
            }
            else
            {
                basDto.Status = "Inativo";
            }            

            basBll.EditarBaseCliente(basDto);

            MessageBox.Show("Base de Cliente ATUALIZADO com sucesso!", "ATUALIZAR!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
            string cliente = basDto.Cliente;
            this.ListarBasesCliente(cliente);
        }

        private void ListarBasesCliente(string cliente)
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

                this.txt_id.Text = baseCli[0].Id.ToString();
                this.txt_codigoBase.Text = baseCli[0].Codigo;
                var dataRegistro = baseCli[0].DataRegistro;
                this.dtp_dataRegistro.Value = DateTime.Parse(dataRegistro);
                this.txt_nomeBase.Text = baseCli[0].NomeBase;
                this.txt_endereco.Text = baseCli[0].Endereco;
                this.txt_complemento.Text = baseCli[0].Complemento;
                this.txt_bairro.Text = baseCli[0].Bairro;

                this.PopularComboboxUf();

                this.cmb_uf.Text = baseCli[0].Uf;
                this.cmb_cidade.Text = baseCli[0].Cidade;
                this.txt_cep.Text = baseCli[0].Cep;
                this.txt_cnpj.Text = baseCli[0].Cnpj;
                this.txt_inscEstadual.Text = baseCli[0].InscEstadual;
                if (baseCli[0].Status == "Ativo")
                {
                    this.cbx_status.Checked = true;
                }
                else
                {
                    this.cbx_status.Checked = false;
                }

                this.btn_novo.Visible = false;
                this.btn_cancelar.Visible = true;
                this.btn_editar.Visible = true;
                this.btn_deletar.Visible = true;
                this.btn_sair.Visible = false;
                this.btn_salvar.Visible = false;
                this.btn_atualizar.Visible = false;

                this.lvw_listaBasesCliente.Enabled = false;

                this.btn_cancelar.Location = new Point(1258, 5);
                this.btn_editar.Location = new Point(1177, 5);

                this.txt_codigo.Enabled = false;
                this.txt_nomeCliente.Enabled = false;
                this.txt_id.Enabled = false;
                this.dtp_dataRegistro.Enabled = false;
                this.txt_codigoBase.Enabled = false;

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
            }            
        }

        public frm_listaBaseCliente()
        {
            InitializeComponent();
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
            //Designer do form
            this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";
            this.BackColor = Color.FromArgb(255, 255, 255);

            this.EstadoInicial();

            //Designer do listview
            this.lvw_listaBasesCliente.BackColor = Color.FromArgb(255, 255, 192);

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
            this.NovoBaseCliente();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarBaseCliente();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarBaseCliente();
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
            if(this.cmb_uf.Text == "SistemaSegsal.DTO.UfDTO")
            {
                return;
            }
            else
            {
                string uf = this.cmb_uf.Text;

                this.PopularComboboxCidade(uf);

                this.cmb_cidade.Enabled = true;
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente CANCELAR este registro?", "CANCELAR!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
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
    }
}
