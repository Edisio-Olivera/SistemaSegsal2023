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
    public partial class frm_listaTecnicoDocumento : Form
    {
        TecnicoDocumentoDTO dto = new TecnicoDocumentoDTO();
        TecnicoDocumentoBLL bll = new TecnicoDocumentoBLL();

        DocumentoDTO docDto = new DocumentoDTO();
        DocumentoBLL docBll = new DocumentoBLL();

        DocumentoTipoDTO tipDto = new DocumentoTipoDTO();
        DocumentoTipoBLL tipBll = new DocumentoTipoBLL();

        TecnicoDTO tecDto = new TecnicoDTO();
        TecnicoBLL tecBll = new TecnicoBLL();        

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        Thread t1;

        Int32 id;
        string codigo;

        double larguraListView = 1280.0;

        private void AbrirFormListaTecnico(object obj)
        {
            Application.Run(new frm_listaTecnicos());
        }

        private void EstadoInicial()
        {
            this.gpb_tecnico.Visible = true;
            this.gpb_documento.Visible = false;

            this.lbl_lista.Location = new Point(35, 220);
            this.lvw_listaDocumento.Location = new Point(35, 246);
            this.lvw_listaDocumento.Size = new Size(1300, 412);

            //Botões de Registros
            this.btn_novo.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_sair.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            codigo = this.txt_codigoTecnico.Text;
            this.ListaDocumentoTecnico(codigo);

            this.lvw_listaDocumento.Enabled = true;
        }

        private void CriarNovoDocumentoTecnico()
        {
            bll.CriarNovoDocumentoTecnico(dto);

            this.txt_id.Text = dto.Id.ToString();
            this.txt_id.Enabled = false;
            this.gpb_tecnico.Visible = true;
            this.gpb_documento.Visible = true;

            this.lbl_lista.Location = new Point(35, 340);
            this.lvw_listaDocumento.Location = new Point(35, 366);
            this.lvw_listaDocumento.Size = new Size(1300, 292);

            this.PopularComboboxTipoDocumento();
            this.cmb_tipoDocumento.Enabled = true;
            this.cmb_documento.Enabled = false;
            this.dtp_dataRealizado.Enabled = true;
            this.dtp_dataRealizado.Value = DateTime.Now;
            this.lbl_dataVencimento.Visible = false;
            this.dtp_dataVencimento.Visible = false;

            //Botões de Registros
            this.btn_novo.Visible = false;
            this.btn_salvar.Visible = true;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.lbl_diasVencer.Visible = false;
            this.lbl_status.Visible = false;
            this.lvw_listaDocumento.Enabled = false;
        }

        private void SalvarDocumentoTecnico()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Tecnico = this.txt_nomeTecnico.Text;

            if(this.cmb_tipoDocumento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um tipo de documento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoDocumento.Focus();
                return;
            }
            else
            {
                dto.Tipo = this.cmb_tipoDocumento.Text;
            }

            if(this.cmb_documento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um documento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_documento.Focus();
                return;
            }
            else
            {
                dto.Documento = this.cmb_documento.Text;
            }            
            
            dto.DataRealizado = this.dtp_dataRealizado.Value;
            
            DateTime dataRealizado = dto.DataRealizado;
            Int32 dias = Int32.Parse(this.txt_diasVencimento.Text);            
            
            dto.DataVencimento = dataRealizado.AddDays(dias);
            
            if(this.txt_observacao.Text == "")
            {
                dto.Observacao = "-";
            }
            else
            {
                dto.Observacao = this.txt_observacao.Text;
            }
            
            dto.Status = "Válido";

            bll.SalvarDocumentoTecnico(dto);

            MessageBox.Show("Documento cadastrado com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
        }

        private void EditarDocumentoTecnico()
        {
            this.lbl_lista.Location = new Point(35, 340);
            this.lvw_listaDocumento.Location = new Point(35, 366);
            this.lvw_listaDocumento.Size = new Size(1300, 292);

            this.cmb_tipoDocumento.Enabled = true;
            this.cmb_documento.Enabled = true;
            this.dtp_dataRealizado.Enabled = true;
            this.lbl_dataVencimento.Visible = true;
            this.dtp_dataVencimento.Visible = true;

            //Botões de Registros
            this.btn_novo.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_atualizar.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_atualizar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.lbl_diasVencer.Visible = false;
            this.lbl_status.Visible = false;
            this.lvw_listaDocumento.Enabled = false;
        }

        private void AtualizarDocumentoTecnico()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);

            if (this.cmb_tipoDocumento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um tipo de documento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_tipoDocumento.Focus();
                return;
            }
            else
            {
                dto.Tipo = this.cmb_tipoDocumento.Text;
            }

            if (this.cmb_documento.Text == "")
            {
                MessageBox.Show("Por favor, Selecione um documento!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.cmb_documento.Focus();
                return;
            }
            else
            {
                dto.Documento = this.cmb_documento.Text;
            }

            dto.DataRealizado = this.dtp_dataRealizado.Value;

            DateTime dataRealizado = dto.DataRealizado;
            Int32 dias = Int32.Parse(this.txt_diasVencimento.Text);

            dto.DataVencimento = dataRealizado.AddDays(dias);

            if (this.txt_observacao.Text == "")
            {
                dto.Observacao = "-";
            }
            else
            {
                dto.Observacao = this.txt_observacao.Text;
            }

            bll.EditarDocumentoTecnico(dto);

            MessageBox.Show("Documento atualizado com sucesso!", "Editar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();

        }

        private void ExcluirDocumentoTecnico()
        {
            dto.Id = Int32.Parse(this.lvw_listaDocumento.SelectedItems[0].Text);

            bll.ExcluirDocumentoTecnico(dto);

            MessageBox.Show("Documento excluído com sucesso!", "Deletar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
        }

        private void SelecionarDocumentoTecnico()
        {
            dto.Id = Int32.Parse(this.lvw_listaDocumento.SelectedItems[0].Text);

            List<TecnicoDocumentoDTO> tecDoc = bll.SelecionarDocumentoTecnico(dto);

            this.txt_id.Text = tecDoc[0].Id.ToString();
            this.PopularComboboxTipoDocumento();
            this.cmb_tipoDocumento.Text = tecDoc[0].Tipo;
            this.cmb_documento.Text = tecDoc[0].Documento;
            this.dtp_dataRealizado.Value = tecDoc[0].DataRealizado;
            this.dtp_dataVencimento.Value = tecDoc[0].DataVencimento;
            this.txt_observacao.Text = tecDoc[0].Observacao;

            //Botões de Registros
            this.btn_novo.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_atualizar.Visible = false;
            this.btn_sair.Visible = false;

            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_deletar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

            this.txt_id.Enabled = false;
            this.cmb_tipoDocumento.Enabled = false;
            this.cmb_documento.Enabled = false;
            this.dtp_dataRealizado.Enabled = false;
            this.dtp_dataVencimento.Enabled = false;
            this.txt_observacao.Enabled = false;

            this.gpb_tecnico.Visible = true;
            this.gpb_documento.Visible = true;

            this.lbl_lista.Location = new Point(35, 340);
            this.lvw_listaDocumento.Location = new Point(35, 366);
            this.lvw_listaDocumento.Size = new Size(1300, 292);

            this.lbl_diasVencer.Visible = true;
            this.lbl_status.Visible = true;

            DateTime dataVencimento = tecDoc[0].DataVencimento;
            Int32 diasVencer = dataVencimento.Subtract(DateTime.Now).Days;
            this.lbl_diasVencer.Text = diasVencer.ToString() + " dias a vencer";

            this.lbl_status.Text = tecDoc[0].Status;
        }

        private void ListaDocumentoTecnico(string tecnico)
        {
            dto.Tecnico = tecnico;

            string[] item = new string[9];
            Int32 prox = 1;
            Int32 qtd = 0;

            var listaDocumentoTecnico = bll.ListarDocumentoTecnico(dto);

            this.lvw_listaDocumento.Items.Clear();

            foreach (TecnicoDocumentoDTO tec in listaDocumentoTecnico)
            {
                item[0] = tec.Id.ToString();
                item[1] = prox.ToString();
                item[2] = tec.Tipo;
                item[3] = tec.Documento;
                item[4] = tec.DataRealizado.ToString("dd/MM/yyyy");
                item[5] = tec.DataVencimento.ToString("dd/MM/yyyy");

                TimeSpan diasVencer = tec.DataVencimento - DateTime.Now;
                //Int32 venc = Convert.ToInt32(diasVencer);

                //if(venc <= 30)
                //{
                    item[6] = diasVencer.TotalDays.ToString("00#");
                    //item[8] = "A Vencer";
                //}
                //else if(venc <= 0)
                //{
                //    item[6] = "-";
                //    item[8] = "Vencido";
                //}
                //else
                //{
                //    item[6] = diasVencer.TotalDays.ToString("00#");
                    item[8] = tec.Status;
                //}

                item[7] = tec.Observacao;

                lvw_listaDocumento.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                qtd = qtd + 1;
            }

            //this.txt_qtdProposta.Text = "Nº de Técnicos: " + qtd.ToString();
        }

        private static double PercentOf(double valor, double total)
        {
            return (total / 100.0) * valor;
        }

        private void PopularComboboxTipoDocumento()
        {
            List<DocumentoTipoDTO> tipo = tipBll.PopularComboboxDocumentoTipo();

            this.cmb_tipoDocumento.DataSource = tipo;
            this.cmb_tipoDocumento.DisplayMember = "tipo";
            this.cmb_tipoDocumento.ValueMember = "id";
            this.cmb_tipoDocumento.SelectedIndex = -1;
        }

        private void PopularComboboxDocumento(string tipo)
        {
            docDto.Tipo = tipo;

            List<DocumentoDTO> documento = docBll.PopularComboboxDocumento(docDto);

            this.cmb_documento.Enabled = true;
            this.cmb_documento.DataSource = documento;
            this.cmb_documento.DisplayMember = "documento";
            this.cmb_documento.ValueMember = "id";
            this.cmb_documento.SelectedIndex = -1;
        }        

        private void CancelarRegistro()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
        }

        private void SairFormulario()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                t1 = new Thread(AbrirFormListaTecnico);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }


        public frm_listaTecnicoDocumento()
        {
            InitializeComponent();
        }

        public frm_listaTecnicoDocumento(string codigo)
        {
            InitializeComponent();

            tecDto.Codigo = codigo;

            List<TecnicoDTO> tec = tecBll.SelecionarTecnico(tecDto);

            this.txt_codigoTecnico.Text = tec[0].Codigo;
            this.txt_nomeTecnico.Text = tec[0].Nome;

            this.txt_codigoTecnico.Enabled = false;
            this.txt_nomeTecnico.Enabled = false;

            this.EstadoInicial();            
        }

        private void frm_listaTecnicoDocumento_Load(object sender, EventArgs e)
        {
            this.lvw_listaDocumento.Columns.Add("Id", (int)PercentOf(0, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaDocumento.Columns.Add("Item", (int)PercentOf(4, larguraListView)).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaDocumento.Columns.Add("Tipo Documento", (int)PercentOf(12, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaDocumento.Columns.Add("Documento", (int)PercentOf(15, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaDocumento.Columns.Add("Data Realizado", (int)PercentOf(10, larguraListView)).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaDocumento.Columns.Add("Data Vencimento", (int)PercentOf(10, larguraListView)).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaDocumento.Columns.Add("Dias a Vencer", (int)PercentOf(8, larguraListView)).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaDocumento.Columns.Add("Observação", (int)PercentOf(34, larguraListView)).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaDocumento.Columns.Add("Status", (int)PercentOf(7, larguraListView)).TextAlign = HorizontalAlignment.Left;

            //this.EstadoInicial();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoDocumentoTecnico();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void cmb_tipoDocumento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_tipoDocumento.Text == "SistemaSegsal.DTO.DocumentoTipoDTO")
            {
                return;
            }
            else
            {
                if (this.cmb_tipoDocumento.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    string tipo = this.cmb_tipoDocumento.Text;

                    this.PopularComboboxDocumento(tipo);
                    this.txt_diasVencimento.Visible = false;
                    this.cmb_documento.Enabled = true;
                    this.cmb_documento.Focus();
                }
            }
        }

        private void dtp_dataRealizado_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataRealizado = this.dtp_dataRealizado.Value;
            Int32 validade = Int32.Parse(this.txt_diasVencimento.Text);
            DateTime dataVencimento = dataRealizado.AddDays(validade);

            this.dtp_dataVencimento.Value = dataVencimento;

            //this.lbl_dataVencimento.Visible = true;
            //this.dtp_dataVencimento.Visible = true;
        }

        private void cmb_documento_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_documento.Text == "SistemaSegsal.DTO.DocumentoDTO")
            {
                return;
            }
            else
            {
                if (this.cmb_documento.SelectedIndex == -1)
                {
                    return;
                }
                else
                {
                    docDto.Documento = this.cmb_documento.Text; ;

                    List<DocumentoDTO> doc = docBll.SelecionarDocumento(docDto);

                    this.txt_diasVencimento.Text = doc[0].Validade.ToString();
                }                
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarDocumentoTecnico();
        }

        private void lvw_listaDocumento_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaDocumento.SelectedItems.Count > 0)
            {
                this.SelecionarDocumentoTecnico();
            }
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente excluir esse documento?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.ExcluirDocumentoTecnico();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarDocumentoTecnico();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarDocumentoTecnico();
        }
    }
}
