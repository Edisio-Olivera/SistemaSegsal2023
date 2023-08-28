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
using SistemaSegsal.Relatorios;
using System.Diagnostics;
using Microsoft.Reporting.WebForms;
using System.IO;

namespace SistemaSegsal.View
{
    public partial class frm_listaPropostaComercial : Form
    {        
        PropostaComercialDTO dto = new PropostaComercialDTO();
        PropostaComercialBLL bll = new PropostaComercialBLL();

        PropostaComercialServicoDTO serDto = new PropostaComercialServicoDTO();
        PropostaComercialServicoBLL serBll = new PropostaComercialServicoBLL();
        
        PropostaComercialStatusDTO stDto = new PropostaComercialStatusDTO();
        PropostaComercialStatusBLL stBll = new PropostaComercialStatusBLL();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        CondicaoPgtoDTO cpDto = new CondicaoPgtoDTO();
        CondicaoPgtoBLL cpBll = new CondicaoPgtoBLL();

        FormaPgtoDTO fpDto = new FormaPgtoDTO();
        FormaPgtoBLL fpBll = new FormaPgtoBLL();

        public static frm_listaPropostaComercial propostaInstancia;

        //Empresa
        string cabecalhoL1;
        string cabecalhoL2;
        string cabecalhoL3;
        string cabecalhoL4;
        string logomarca;

        //Cliente
        string clienteL1;
        string clienteL2;

        //Proposta
        string numeroProposta;
        string dataProposta;
        string titulo;
        string descricao;
        string observacao;
        string condPgto;
        string formaPgto;
        Int32 valorProposta;
        string dataPropostaExtenso;

        //Serviço Proposta

        private void EstadoInicial()
        {
            //Visualização dos Botões

            this.btn_sair.Visible = true;

            this.cmb_status.BackColor = Color.FromArgb(255, 255, 192);

            //Posição dos Botões            

            //this.btn_sair.Location = new Point(0, 160);

            
            this.cmb_status.Enabled = true;
            this.lvw_listaPropostaComercial.Enabled = true;    

           
            this.cmb_status.BackColor = Color.White;
            this.cmb_status.Focus();

        }

        public void CarregarDadosEmpresa()
        {
            List<EmpresaDTO> emp = empBll.SelecionarEmpresa();

            string logoEmpresa = emp[0].Logo;
            string nomeFantasia = emp[0].NomeFantasia;

            this.img_logoEmpresa.Image = Image.FromFile(Application.StartupPath + logoEmpresa);
            this.img_logoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Text = "Sistema de Gestão - " + nomeFantasia + " - v 1.0";
        }

        private void SelecionarProposta(string codigoProposta)
        {
            dto.Codigo = codigoProposta;

            List<PropostaComercialDTO> prop = bll.SelecionarPropostaComercial(dto);

            Int32 id = prop[0].Id;
            string codigo = prop[0].Codigo;
            string dataProposta = prop[0].DataProposta;
            string cliente = prop[0].Cliente;
            string baseCliente = prop[0].BaseCliente;
            string titulo = prop[0].Titulo;
            string descricao = prop[0].Descricao;
            string observacao = prop[0].Observacao;
            string condPgto = prop[0].CondicaoPgto;
            string formaPgto = prop[0].FormaPgto;
            Int32 valor = prop[0].Valor;
            string statusProp = prop[0].Status;

            frm_addPropostaComercial proposta = new frm_addPropostaComercial(id, codigo, dataProposta, cliente, baseCliente, titulo, descricao, observacao, condPgto, formaPgto, valor, statusProp);
            proposta.Visible = true;

            //Visualização dos Botões
            //this.btn_novo.Visible = false;
            //this.btn_cancelar.Visible = true;
            //this.btn_editar.Visible = true;
            //this.btn_deletar.Visible = true;
            //this.btn_servico.Visible = true;
            //this.btn_imprimir.Visible = true;
            //this.btn_sair.Visible = false;

            //Posição dos Botões            
            //this.btn_imprimir.Location = new Point(0, 100);
            //this.btn_servico.Location = new Point(0, 160);
            //this.btn_deletar.Location = new Point(0, 220);
            //this.btn_editar.Location = new Point(0, 280);
            //this.btn_cancelar.Location = new Point(0, 340);


            //this.txt_id.Enabled = false;
            //this.txt_codigo.Enabled = false;
            //this.txt_dataProposta.Enabled = false;
            //this.cmb_cliente.Enabled = false;
            //this.cmb_base.Enabled = false;
            //this.txt_titulo.Enabled = false;
            //this.txt_descricao.Enabled = false;
            //this.txt_observacao.Enabled = false;
            //this.cmb_condPgto.Enabled = false;
            //this.cmb_formaPgto.Enabled = false;
            //this.txt_valor.Enabled = false;
            //this.txt_status.Enabled = false;

            //this.label13.Visible = true;
            //this.label14.Visible = true;
            //this.txt_valor.Visible = true;
            //this.txt_status.Visible = true;          

        }

        private void CriarNovaProposta()
        {
            bll.CriarNovoPropostaComercial(dto);

            Int32 id = dto.Id + 1;
            
            frm_addPropostaComercial prop = new frm_addPropostaComercial(id);
            prop.Visible = true;
        }

        

        private void EditarProposta()
        {
            //Visualização dos Botões

            this.btn_sair.Visible = false;

            //Posição dos Botões

                      

            

            this.cmb_status.Enabled = false;
            this.lvw_listaPropostaComercial.Enabled = false;
        }

        public void SelecionarProposta()
        {

        }

        private void DeletarProposta()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Deletar esse registro?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dto.Codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

                bll.ExcluirPropostaComercial(dto);

                MessageBox.Show("Proposta Comercial Excluída com com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //this.EstadoInicial();
                this.ListaPropostaComercial();
            }            
        }

        private void ServicoProposta()
        {
            dto.Codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

            List<PropostaComercialDTO> pro = bll.SelecionarPropostaComercial(dto);

            string codigo = dto.Codigo;
            string cliente = pro[0].Cliente;
            string baseCli = pro[0].BaseCliente;
            DateTime dataProp = DateTime.Parse(pro[0].DataProposta);
            string dataProposta = dataProp.ToString("dd/MM/yyyy");
            string titulo = pro[0].Titulo;
            Int32 valor = pro[0].Valor;

            frm_listaPropostaComercialServico serv = new frm_listaPropostaComercialServico(codigo, cliente, baseCli, dataProposta, titulo, valor);
            serv.Visible = true;

            this.Close();
        }

        private void ImprimirProposta()
        {
            //Código da base do Cliente
            string baseCliente = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[4].Text;
            string[] baseC = baseCliente.Split('-');
            basDto.NomeBase = baseC[1];

            string codBase = basBll.SelecionarCodigoBaseCliente(basDto);

            //Código da Proposta
            string codigoProposta = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

            this.SelecionarDadosEmpresa();
            this.SelecionarDadosCliente(codBase);
            this.SelecionarDadosProposta(codigoProposta);
            //this.SelecionarDadosServicoProposta(codigoProposta);


            ReportViewer reportViewer = new ReportViewer();
            reportViewer.ProcessingMode = ProcessingMode.Local;

            //Caminho do relatório
            reportViewer.LocalReport.ReportEmbeddedResource = "SistemaSegsal.Relatorios.rel_propostaComercial.rdlc";

            //Parâmetros do relatório
            List<ReportParameter> listaReportParameter = new List<ReportParameter>();

            listaReportParameter.Add(new ReportParameter("cabecalhoL1", cabecalhoL1));
            listaReportParameter.Add(new ReportParameter("cabecalhoL2", cabecalhoL2));
            listaReportParameter.Add(new ReportParameter("cabecalhoL3", cabecalhoL3));
            listaReportParameter.Add(new ReportParameter("cabecalhoL4", cabecalhoL4));

            listaReportParameter.Add(new ReportParameter("numeroProposta", numeroProposta));
            listaReportParameter.Add(new ReportParameter("dataProposta", dataProposta));
            listaReportParameter.Add(new ReportParameter("titulo", titulo));
            listaReportParameter.Add(new ReportParameter("descricao", descricao));
            listaReportParameter.Add(new ReportParameter("observacao", observacao));
            listaReportParameter.Add(new ReportParameter("condPgto", condPgto));
            listaReportParameter.Add(new ReportParameter("formaPgto", formaPgto));
            listaReportParameter.Add(new ReportParameter("dataPropostaExtenso", dataPropostaExtenso));

            listaReportParameter.Add(new ReportParameter("clienteL1", clienteL1));
            listaReportParameter.Add(new ReportParameter("clienteL2", clienteL2));

            reportViewer.LocalReport.SetParameters(listaReportParameter);

            //Parâmetros do render
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytePdf = reportViewer.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

            FileStream fileStreamPDF = null;

            string nomeArquivoPdf = Application.StartupPath + @"\Documentos\PropostaComercial\" + numeroProposta + ".pdf";

            fileStreamPDF = new FileStream(nomeArquivoPdf, FileMode.Create);
            fileStreamPDF.Write(bytePdf, 0, bytePdf.Length);
            fileStreamPDF.Close();

            Process.Start(nomeArquivoPdf);
















        }

        private void SelecionarDadosEmpresa()
        {
            //Selecionar dados da Empresa
            List<EmpresaDTO> empresa = empBll.SelecionarEmpresa();

            cabecalhoL1 = empresa[0].NomeFantasia;
            cabecalhoL2 = "CNPJ: " + empresa[0].Cnpj;
            cabecalhoL3 = empresa[0].Endereco + ", " + empresa[0].Complemento + ", " + empresa[0].Bairro + ", " + empresa[0].Cidade + "/" + empresa[0].Uf + ", CEP.: " + empresa[0].Cep;
            cabecalhoL4 = "Fone: " + empresa[0].Celular + " - E-mail: " + empresa[0].Email;

            logomarca = Application.StartupPath + empresa[0].LogoImpressao;
        }

        private void SelecionarDadosCliente(string codigo)
        {
            //Selecionar dados do cliente
            basDto.Codigo = codigo;
            List<BaseClienteDTO> cliente = basBll.SelecionarBaseCliente(basDto);

            clienteL1 = cliente[0].Cliente + " - " + cliente[0].NomeBase + " - CNPJ: " + cliente[0].Cnpj;
            clienteL2 = cliente[0].Endereco + ", " + cliente[0].Complemento + ", " + cliente[0].Bairro + ", " + cliente[0].Cidade + "/" + cliente[0].Uf + ", CEP.: " + cliente[0].Cep;
        }

        private void SelecionarDadosProposta(string codigo)
        {
            //Selecionar dados da Proposta
            dto.Codigo = codigo;
            List<PropostaComercialDTO> proposta = bll.SelecionarPropostaComercial(dto);

            numeroProposta = proposta[0].Codigo;
            dataProposta = proposta[0].DataProposta;
            titulo = proposta[0].Titulo;
            descricao = proposta[0].Descricao;
            observacao = proposta[0].Observacao;
            condPgto = proposta[0].CondicaoPgto;
            formaPgto = proposta[0].FormaPgto;
            valorProposta = proposta[0].Valor;
            string dataPropostaExt = DateTime.Parse(proposta[0].DataProposta).ToString("dd/MMMM/yyyy");
            string[] dataQuebrada = dataPropostaExt.Split('/');
            string dia = dataQuebrada[0];
            string mes = dataQuebrada[1];
            string ano = dataQuebrada[2];
            dataPropostaExtenso = "Fortaleza/CE, " + dia + " de " + mes + " de " + ano;
        }

        private void SelecionarDadosServicoProposta(string codigo)
        {
            //Selecionar dados do Serviço da Proposta
            serDto.Proposta = codigo;
            List<PropostaComercialServicoDTO> servico = serBll.SelecionarServicoProposta(serDto);
        }
        
        private void PopularComboboxStatus()
        {
            List<PropostaComercialStatusDTO> statusProposta = stBll.PopularComboboxPropostaComercialStatus();

            this.cmb_status.DataSource = statusProposta;
            this.cmb_status.DisplayMember = "status";
            this.cmb_status.Text = "";
        }

        public void ListaPropostaComercialStatus(string status)
        {
            dto.Status = status;

            string[] item = new string[8];
            int prox = 1;
            Int32 valor = 0;
            Int32 qtd = 0;

            var listaProposta = bll.ListarPropostaComercialStatus(dto);
            
            this.lvw_listaPropostaComercial.Items.Clear();

            foreach (PropostaComercialDTO pro in listaProposta)
            {
                item[0] = pro.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pro.Codigo;
                item[3] = pro.DataProposta;
                item[4] = pro.Cliente + "-" + pro.BaseCliente;
                item[5] = pro.Titulo;
                item[6] = pro.Valor.ToString("R$ #,##0.00");
                item[7] = pro.NotaFiscal;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                valor = valor + pro.Valor;
                qtd = qtd + 1;
            }

            if(status == "A Receber")
            {
                this.txt_valorProposta.Text = "Valor Total em Propostas " + status + ": " + valor.ToString("R$ #,##0.00");
                this.txt_qtdProposta.Text = "Nº de Propostas " + status + ": " + qtd.ToString();
            }
            else
            {
                this.txt_valorProposta.Text = "Valor Total em Propostas " + status + "s: " + valor.ToString("R$ #,##0.00");
                this.txt_qtdProposta.Text = "Nº de Propostas " + status + "s: " + qtd.ToString();
            }
            
        }

        public void ListaPropostaComercial()
        {            
            string[] item = new string[9];
            Int32 prox = 1;
            Int32 valor = 0;
            Int32 qtd = 0;

            var listaProposta = bll.ListarPropostaComercial();

            this.lvw_listaPropostaComercial.Items.Clear();

            foreach (PropostaComercialDTO pro in listaProposta)
            {
                item[0] = pro.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pro.Codigo;
                item[3] = pro.DataProposta;
                item[4] = pro.Cliente + "-" + pro.BaseCliente;
                item[5] = pro.Titulo;
                item[6] = pro.Valor.ToString("R$ #,##0.00");
                item[7] = pro.NotaFiscal;
                item[8] = pro.Status;

                lvw_listaPropostaComercial.Items.Add(new ListViewItem(item));
                prox = prox + 1;
                valor = valor + pro.Valor;
                qtd = qtd + 1;
            }

            this.txt_valorProposta.Text = "Valor Total em Propostas: " + valor.ToString("R$ #,##0.00");
            this.txt_qtdProposta.Text = "Nº de Propostas: " + qtd.ToString();
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
                frm_principal pri = new frm_principal();
                pri.Visible = true;

                this.Close();
            }
        }

        public frm_listaPropostaComercial()
        {
            InitializeComponent();

            propostaInstancia = this;
        }


        private void frm_listaPropostaComercial_Load(object sender, EventArgs e)
        {
            //Designer do form
            this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";
            //this.BackColor = Color.FromArgb(255, 255, 255);

            this.EstadoInicial();

            //1370
            this.lvw_listaPropostaComercial.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Número", 85).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Data", 90).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Cliente-Base", 300).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPropostaComercial.Columns.Add("Título", 500).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPropostaComercial.Columns.Add("Valor", 100).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaPropostaComercial.Columns.Add("Nota Fiscal", 100).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaPropostaComercial.Columns.Add("Status", 80).TextAlign = HorizontalAlignment.Left;

            //this.txt_qtdProposta.Text = "Nº de Propostas: ";

            this.ListaPropostaComercial();
            this.PopularComboboxStatus();
            this.CarregarDadosEmpresa();
        }

        private void lvw_listaPropostaComercial_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(lvw_listaPropostaComercial.SelectedItems.Count > 0)
            {
                this.SelecionarProposta();
            }
            
        }

        private void lvw_listaPropostaComercial_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovaProposta();            
        }

        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if(this.cmb_status.Text == "SistemaSegsal.DTO.PropostaComercialStatusDTO")
            {                
                return;
            }
            
            else
            {
                string status = this.cmb_status.Text;

                //this.ListaPropostaComercialStatus(status);                
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            //string status = this.cmb_status.Text;

            //this.ListaPropostaComercialStatus(status);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarProposta();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente DELETAR esta Proposta?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.DeletarProposta();

                this.ListaPropostaComercial();
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_condPgto_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_servico_Click(object sender, EventArgs e)
        {
            this.ServicoProposta();
        }

        private void btn_dataProposta_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
            this.ImprimirProposta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void lvw_listaPropostaComercial_DoubleClick(object sender, EventArgs e)
        {
            string codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

            this.SelecionarProposta(codigo);           

        }

        private void btn_novo_Click_1(object sender, EventArgs e)
        {
            this.CriarNovaProposta();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.DeletarProposta();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
