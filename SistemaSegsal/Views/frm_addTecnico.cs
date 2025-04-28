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
using SistemaSegsal.View;
using System.Threading;
using System.IO;
using iText.Layout.Element;

namespace SistemaSegsal.Views
{
    public partial class frm_addTecnico : Form
    {
        TecnicoDTO dto = new TecnicoDTO();
        TecnicoBLL bll = new TecnicoBLL();

        SexoDTO sexDto = new SexoDTO();
        SexoBLL sexBll = new SexoBLL();

        FuncaoDTO fncDto = new FuncaoDTO();
        FuncaoBLL fncBll = new FuncaoBLL();

        UfDTO ufDto = new UfDTO();
        UfBLL ufBll = new UfBLL();

        CidadeDTO cidDto = new CidadeDTO();
        CidadeBLL cidBll = new CidadeBLL();

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        Thread t1;

        private void abrirFormListaTecnico(object obj)
        {
            Application.Run(new frm_listaTecnicos());
        }


        private void SalvarTecnico()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Codigo = this.txt_codigo.Text;
            dto.DataCadastro = DateTime.Now;
            
            if (this.txt_nome.Text == "")
            {
                MessageBox.Show("Por favor, Digite o nome do técnico!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nome.Focus();
                return;
            }
            else
            {
                dto.Nome = this.txt_nome.Text;
            }

            if (this.txt_nomeUsual.Text == "")
            {
                MessageBox.Show("Por favor, Digite o nome usual do técnico!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_nomeUsual.Focus();
                return;
            }
            else
            {
                dto.NomeUsual = this.txt_nomeUsual.Text;
            }

            if (this.cmb_sexo.Text == "")
            {
                MessageBox.Show("Por favor, Selecione o sexo do técnico!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_sexo.Focus();
                return;
            }
            else
            {
                dto.Sexo = this.cmb_sexo.Text;
            }

            dto.DataNascimento = this.dtp_dataNascimento.Value;

            if (this.txt_endereco.Text == "")
            {
                dto.Endereco = "-";
            }
            else
            {
                dto.Endereco = this.txt_endereco.Text;
            }

            if (this.txt_bairro.Text == "")
            {
                dto.Bairro = "-";
            }
            else
            {
                dto.Bairro = this.txt_bairro.Text;
            }

            if (this.cmb_uf.Text == "")
            {
                dto.Uf = "CE";
            }
            else
            {
                dto.Uf = this.cmb_uf.Text;
            }

            if (this.cmb_cidade.Text == "")
            {
                dto.Cidade = "Fortaleza";
            }
            else
            {
                dto.Cidade = this.cmb_cidade.Text;
            }

            dto.Cep = this.txt_cep.Text;
            dto.Telefone = this.txt_telefone.Text;

            if (this.txt_email.Text == "")
            {
                dto.Email = "-";
            }
            else
            {
                dto.Email = this.txt_email.Text;
            }

            if (this.txt_rg.Text == "")
            {
                dto.Rg = "-";
            }
            else
            {
                dto.Rg = this.txt_rg.Text;
            }

            dto.Cpf = this.txt_cpf.Text;

            if (this.cmb_funcao.Text == "")
            {
                dto.Funcao = "Fortaleza";
            }
            else
            {
                dto.Funcao = this.cmb_funcao.Text;
            }

            dto.DataAdmissao = this.dtp_dataAdmissao.Value;
            dto.Foto = @"\Técnicos\Fotos\sem_imagem.jpg";
            dto.Assinatura = @"\Técnicos\Assinaturas\sem_imagem.jpg";
            dto.Status = "Ativo";

            string diretorio = @"\Técnicos\" + dto.Codigo;

            if(!Directory.Exists(Application.StartupPath + diretorio))
            {
                Directory.CreateDirectory(Application.StartupPath + diretorio);
            }
            else
            {
                MessageBox.Show("O diretório que está tentando criar já existe!", "Criar Diretório!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            dto.Pasta = diretorio + @"\";

            bll.SalvarTecnico(dto);

            MessageBox.Show("Técnico cadastrado com com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            t1 = new Thread(abrirFormListaTecnico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        public void EditarTecnico()
        {

        }

        public void AtualizarTecnico()
        {

        }


        private void PopularComboboxSexo()
        {
            List<SexoDTO> sexo = sexBll.PopularComboboxSexo();

            this.cmb_sexo.DataSource = sexo;
            this.cmb_sexo.DisplayMember = "sexo";
            this.cmb_sexo.ValueMember = "id";
            this.cmb_sexo.SelectedIndex = -1;
        }

        private void PopularComboboxFuncao()
        {
            List<FuncaoDTO> funcao = fncBll.PopularComboboxFuncao();

            this.cmb_funcao.DataSource = funcao;
            this.cmb_funcao.DisplayMember = "funcao";
            this.cmb_funcao.ValueMember = "id";
            this.cmb_funcao.SelectedIndex = -1;
        }

        private void PopularComboboxUf()
        {
            List<UfDTO> uf = ufBll.PopularComboboxUf();

            this.cmb_uf.DataSource = uf;
            this.cmb_uf.DisplayMember = "sigla";
            this.cmb_uf.ValueMember = "id";
            this.cmb_uf.SelectedIndex = -1;
        }

        private void PopularComboboxCidade(string uf)
        {
            cidDto.Uf = uf;

            List<CidadeDTO> cidade = cidBll.PopularComboboxCidade(cidDto);

            this.cmb_cidade.Enabled = true;
            this.cmb_cidade.DataSource = cidade;
            this.cmb_cidade.DisplayMember = "cidade";
            this.cmb_cidade.ValueMember = "id";
            this.cmb_cidade.SelectedIndex = -1;
        }



        public frm_addTecnico()
        {
            InitializeComponent();
        }

        public frm_addTecnico(Int32 id, string codigo)
        {
            InitializeComponent();

            dto.Codigo = codigo;

            List<TecnicoDTO> tec = bll.SelecionarTecnico(dto);

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = codigo;
            this.txt_nome.Text = tec[0].Nome;
            this.txt_nomeUsual.Text = tec[0].NomeUsual;
            this.PopularComboboxSexo();
            this.cmb_sexo.Text = tec[0].Sexo;
            this.dtp_dataNascimento.Value = tec[0].DataNascimento;
            this.txt_endereco.Text = tec[0].Endereco;
            this.txt_bairro.Text = tec[0].Bairro;
            this.PopularComboboxUf();
            this.cmb_uf.Text = tec[0].Uf;
            this.cmb_cidade.Text = tec[0].Cidade;
            this.txt_cep.Text = tec[0].Cep;
            this.txt_telefone.Text = tec[0].Telefone;
            this.txt_email.Text = tec[0].Email;
            this.txt_rg.Text = tec[0].Rg;
            this.txt_cpf.Text = tec[0].Cpf;
            this.PopularComboboxFuncao();
            this.cmb_funcao.Text = tec[0].Funcao;
            this.dtp_dataAdmissao.Value = tec[0].DataAdmissao;
            this.img_foto.Image = System.Drawing.Image.FromFile(Application.StartupPath + tec[0].Foto);
            this.img_foto.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txt_id.Enabled = false;
            this.txt_codigo.Enabled = false;
            this.txt_nome.Enabled = false;
            this.txt_nomeUsual.Enabled = false;
            this.cmb_sexo.Enabled = false;
            this.dtp_dataNascimento.Enabled = false;
            this.txt_endereco.Enabled = false;
            this.txt_bairro.Enabled = false;
            this.cmb_uf.Enabled = false;
            this.cmb_cidade.Enabled = false;
            this.txt_cep.Enabled = false;
            this.txt_telefone.Enabled = false;
            this.txt_email.Enabled = false;
            this.txt_rg.Enabled = false;
            this.txt_cpf.Enabled = false;
            this.cmb_funcao.Enabled = false;
            this.dtp_dataAdmissao.Enabled = false;
        }

        public frm_addTecnico(Int32 id)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigo.Text = "TEC-" + id.ToString("00#");
            this.dtp_dataNascimento.Value = DateTime.Now.AddYears(-18);

            this.PopularComboboxSexo();
            this.PopularComboboxUf();
            this.PopularComboboxFuncao();

            this.cmb_cidade.Enabled = false;

            this.img_foto.Image = System.Drawing.Image.FromFile(Application.StartupPath + @"\Técnicos\Fotos\sem_imagem.jpg");
            this.img_foto.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void frm_cadTecnico_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarTecnico();
        }

        private void cmb_sexo_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_uf_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_uf.Text == "SistemaSegsal.DTO.UfDTO")
            {
                return;
            }
            else
            {
                if (this.cmb_uf.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    string estado = this.cmb_uf.Text;

                    this.PopularComboboxCidade(estado);
                    //this.btn_addBase.Enabled = true;
                    this.cmb_cidade.Enabled = true;
                    this.cmb_cidade.Focus();
                }
            }
        }
    }
}
