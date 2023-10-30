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

namespace SistemaSegsal.Views
{
    public partial class frm_addChamadoAtendimento : Form
    {
        ChamadoDTO chmDto = new ChamadoDTO();
        ChamadoBLL chmBll = new ChamadoBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();

        ChamadoAtendimentoDTO dto = new ChamadoAtendimentoDTO();
        ChamadoAtendimentoBLL bll = new ChamadoAtendimentoBLL();

        ChamadoAtendimentoTipoDTO tipDto = new ChamadoAtendimentoTipoDTO();
        ChamadoAtendimentoTipoBLL tipBll = new ChamadoAtendimentoTipoBLL();

        private void EstadoInicial()
        {
            
        }

        private void SalvarAtendimento()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Chamado = this.txt_codigoChamado.Text;

            if (this.cmb_tipoAtendimento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Tipo de Atendimento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoAtendimento.Focus();
                return;
            }
            else
            {
                dto.Tipo = this.cmb_tipoAtendimento.Text;
            }

            string dataInicioForm = this.txt_dataInicio.Text;
            string[] dataInicioQuebrada = dataInicioForm.Split('/');
            string diaInicio = dataInicioQuebrada[0];
            string mesInicio = dataInicioQuebrada[1];
            string anoInicio = dataInicioQuebrada[2];

            if (diaInicio == "" || mesInicio == "" || anoInicio == "")
            {
                MessageBox.Show("Por favor, Digite a Data de Início!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataInicio.Focus();
                return;
            }
            else
            {
                string dataInicioBanco = anoInicio + "-" + mesInicio + "-" + diaInicio;
                dto.DataInicio = dataInicioBanco;
            }

            string horaInicioForm = this.txt_horaInicio.Text;
            string[] horaInicioQuebrada = horaInicioForm.Split(':');
            string horaInicio = horaInicioQuebrada[0];
            string minutoInicio = horaInicioQuebrada[1];
            string segundoInicio = horaInicioQuebrada[2];

            if (horaInicio == "" || minutoInicio == "" || segundoInicio == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_horaInicio.Focus();
                return;
            }
            else
            {
                string horaInicioBanco = horaInicio + ":" + minutoInicio + ":" + segundoInicio;
                dto.HoraInicio = horaInicioBanco;
            }

            if (this.cmb_tecnico.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Técnico!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tecnico.Focus();
                return;
            }
            else
            {
                dto.Tecnico = this.cmb_tecnico.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Por favor, Digite uma descrição da atividade realizada!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                dto.AtividadeRealizada = this.txt_descricao.Text;
            }

            string dataFinalForm = this.txt_dataFinal.Text;
            string[] dataFinalQuebrada = dataFinalForm.Split('/');
            string diaFinal = dataFinalQuebrada[0];
            string mesFinal = dataFinalQuebrada[1];
            string anoFinal = dataFinalQuebrada[2];

            if (diaFinal == "" || mesFinal == "" || anoFinal == "")
            {
                MessageBox.Show("Por favor, Digite a Data de Início!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataInicio.Focus();
                return;
            }
            else
            {
                string dataFinalBanco = anoFinal + "-" + mesFinal + "-" + diaFinal;
                dto.DataFinal = dataFinalBanco;
            }

            string horaFinalForm = this.txt_horaFinal.Text;
            string[] horaFinalQuebrada = horaFinalForm.Split(':');
            string horaFinal = horaFinalQuebrada[0];
            string minutoFinal = horaFinalQuebrada[1];
            string segundoFinal = horaFinalQuebrada[2];

            if (horaFinal == "" || minutoFinal == "" || segundoFinal == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_horaFinal.Focus();
                return;
            }
            else
            {
                string horaFinalBanco = horaFinal + ":" + minutoFinal + ":" + segundoFinal;
                dto.HoraFinal = horaFinalBanco;
            }

            if (this.txt_valor.Text == "")
            {
                dto.Valor = 0;
            }
            else
            {
                dto.Valor = Int32.Parse(this.txt_valor.Text);
            }

            bll.SalvarAtendimentoChamado(dto);

            MessageBox.Show("Atendimento Cadastrado com sucesso!", "Cadastrar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listaChamadoAtendimento.atendimentoIntancia.ListarAtendimentoChamados(dto.Chamado);

            this.Visible = false;


        }

        private void AtualizarAtendimento()
        {
            dto.Chamado = this.txt_codigoChamado.Text;

            if (this.cmb_tipoAtendimento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Tipo de Atendimento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoAtendimento.Focus();
                return;
            }
            else
            {
                dto.Tipo = this.cmb_tipoAtendimento.Text;
            }

            string dataInicioForm = this.txt_dataInicio.Text;
            string[] dataInicioQuebrada = dataInicioForm.Split('/');
            string diaInicio = dataInicioQuebrada[0];
            string mesInicio = dataInicioQuebrada[1];
            string anoInicio = dataInicioQuebrada[2];

            if (diaInicio == "" || mesInicio == "" || anoInicio == "")
            {
                MessageBox.Show("Por favor, Digite a Data de Início!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataInicio.Focus();
                return;
            }
            else
            {
                string dataInicioBanco = anoInicio + "-" + mesInicio + "-" + diaInicio;
                dto.DataInicio = dataInicioBanco;
            }

            string horaInicioForm = this.txt_horaInicio.Text;
            string[] horaInicioQuebrada = horaInicioForm.Split(':');
            string horaInicio = horaInicioQuebrada[0];
            string minutoInicio = horaInicioQuebrada[1];
            string segundoInicio = horaInicioQuebrada[2];

            if (horaInicio == "" || minutoInicio == "" || segundoInicio == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_horaInicio.Focus();
                return;
            }
            else
            {
                string horaInicioBanco = horaInicio + ":" + minutoInicio + ":" + segundoInicio;
                dto.HoraInicio = horaInicioBanco;
            }

            if (this.cmb_tecnico.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um Técnico!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tecnico.Focus();
                return;
            }
            else
            {
                dto.Tecnico = this.cmb_tecnico.Text;
            }

            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Por favor, Digite uma descrição da atividade realizada!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                dto.AtividadeRealizada = this.txt_descricao.Text;
            }

            string dataFinalForm = this.txt_dataFinal.Text;
            string[] dataFinalQuebrada = dataFinalForm.Split('/');
            string diaFinal = dataFinalQuebrada[0];
            string mesFinal = dataFinalQuebrada[1];
            string anoFinal = dataFinalQuebrada[2];

            if (diaFinal == "" || mesFinal == "" || anoFinal == "")
            {
                MessageBox.Show("Por favor, Digite a Data de Início!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_dataInicio.Focus();
                return;
            }
            else
            {
                string dataFinalBanco = anoFinal + "-" + mesFinal + "-" + diaFinal;
                dto.DataFinal = dataFinalBanco;
            }

            string horaFinalForm = this.txt_horaFinal.Text;
            string[] horaFinalQuebrada = horaFinalForm.Split(':');
            string horaFinal = horaFinalQuebrada[0];
            string minutoFinal = horaFinalQuebrada[1];
            string segundoFinal = horaFinalQuebrada[2];

            if (horaFinal == "" || minutoFinal == "" || segundoFinal == "")
            {
                MessageBox.Show("Por favor, Digite a Data do Chamado!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.txt_horaFinal.Focus();
                return;
            }
            else
            {
                string horaFinalBanco = horaFinal + ":" + minutoFinal + ":" + segundoFinal;
                dto.HoraFinal = horaFinalBanco;
            }

            if (this.txt_valor.Text == "")
            {
                dto.Valor = 0;
            }
            else
            {
                dto.Valor = Int32.Parse(this.txt_valor.Text);
            }

            bll.EditarAtendimentoChamado(dto);

            MessageBox.Show("Atendimento Atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            frm_listaChamadoAtendimento.atendimentoIntancia.ListarAtendimentoChamados(dto.Chamado);

            this.Visible = false;
        }

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Visible = false;
            }
        }

        private void PopularComboboxTipoAtendimento()
        {
            List<ChamadoAtendimentoTipoDTO> tipo = tipBll.PopularComboboxTipoAtendimento();

            this.cmb_tipoAtendimento.DataSource = tipo;
            this.cmb_tipoAtendimento.DisplayMember = "tipo";

            this.cmb_tipoAtendimento.Text = "";
        }

        private void PopularComboboxTecnico()
        {
            List<TecnicoDTO> tecnico = tecBll.PopularComboboxTecnico();

            this.cmb_tecnico.DataSource = tecnico;
            this.cmb_tecnico.DisplayMember = "nomeCurto";

            this.cmb_tecnico.Text = "";
        }

        public frm_addChamadoAtendimento()
        {
            InitializeComponent();
        }

        //Novo Atendimento
        public frm_addChamadoAtendimento(Int32 id, string chamado)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
            this.txt_codigoChamado.Text = chamado;

            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_atualizar.Visible = false;

            this.btn_cancelar.Location = new Point(712,10);
            this.btn_salvar.Location = new Point(646, 10);

            this.PopularComboboxTipoAtendimento();
            this.PopularComboboxTecnico();
        }

        //Editar Atendimento
        public frm_addChamadoAtendimento(Int32 id)
        {
            InitializeComponent();

            dto.Id = id;

            List<ChamadoAtendimentoDTO> atd = bll.SelecionarAtendimentoChamado(dto);

            this.txt_id.Text = atd[0].Id.ToString();
            this.txt_codigoChamado.Text = atd[0].Chamado;
            this.PopularComboboxTipoAtendimento();
            this.cmb_tipoAtendimento.Text = atd[0].Tipo;
            this.txt_dataInicio.Text = atd[0].DataInicio;
            this.txt_horaInicio.Text = atd[0].HoraInicio;
            this.PopularComboboxTecnico();
            this.cmb_tecnico.Text = atd[0].Tecnico;
            this.txt_descricao.Text = atd[0].AtividadeRealizada;
            this.txt_dataFinal.Text = atd[0].DataFinal;
            this.txt_horaFinal.Text = atd[0].HoraFinal;
            this.txt_valor.Text = atd[0].Valor.ToString();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarAtendimento();
        }

        private void frm_addChamadoAtendimento_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarAtendimento();
        }
    }
}
