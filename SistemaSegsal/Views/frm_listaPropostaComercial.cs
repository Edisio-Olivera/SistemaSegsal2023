using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.Auxiliar;
using SistemaSegsal.Views;
using SistemaSegsal.Relatorios;
using System.Diagnostics;
using Microsoft.Reporting;
using System.IO;
using Microsoft.Reporting.WinForms;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Kernel.Geom;
using iText.Layout.Element;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Layout.Properties;
using iText.Kernel.Colors;
//using iText.Layout.Element.Image;
using Image = iText.Layout.Element.Image;
using iText.Kernel.Pdf.Xobject;
using iText.IO.Image;
using iText.Kernel.Pdf.Canvas.Draw;
using iText.Layout.Borders;
using Color = System.Drawing.Color;


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

        OrdemServicoDTO ordDto = new OrdemServicoDTO();
        OrdemServicoBLL ordBll = new OrdemServicoBLL();

        Class1 cla = new Class1();

        MedidasGeraisDTO medFormDTO = new MedidasGeraisDTO();

        public static frm_listaPropostaComercial propostaInstancia;

        Thread t1;
        Int32 id = 0;
        string codigo;
        string dataProposta;
        string cliente;
        string baseCliente;
        string titulo;
        string descricao;
        string observacao;
        string condPgto;
        string formaPgto;
        Int32 valor = 0;
        string statusProp;
        string statusAtual;

        //Empresa
        string cabecalhoLinha1; //Nome Fantasia
        string cabecalhoLinha2; //CNPJ
        string cabecalhoLinha3; //Endereço
        string cabecalhoLinha4; //Contato
        string logomarcaCabecalho; //Logomarca
        string cnpjEmpresa;

        //Cliente
        string codigoBase;
        string nomeCliente;
        string nomeBaseCliente;
        string cnpjBaseCliente;
        string clienteLinha1; //Nome Fantasia
        string clienteLinha2; //Nome Base, CNPJ
        string clienteLinha3; //Endereço
        string nomeClienteBase;

        //Proposta
        string numeroProposta;
        //string dataProposta;
        string tituloProposta;
        string descricaoProposta;
        string observacaoProposta;
        string condPgtoProposta;
        string formaPgtoProposta;
        Int32 valorTotalProposta;
        string dataPropostaExtenso;        

        //Serviço Proposta
        List<PropostaComercialServicoDTO> listaServicoProposta;

        //static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
        //static BaseFont fonteCalibri = BaseFont.CreateFont("c:\\windows\\fonts\\calibri.ttf", BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
        //static BaseFont fonteHelvetica = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, false);
        //static BaseColor azulNavy = new BaseColor(0, 0, 128);
        //static BaseColor preto = new BaseColor(0, 0, 0);
        //static BaseColor branco = new BaseColor(255, 255, 255);
        //static BaseColor cinzaMedio = new BaseColor(158, 158, 158);
        //static BaseColor cinzaClaro = new BaseColor(240, 240, 240);
        //static BaseColor azulClaro = new BaseColor(128, 216, 255);
        //static BaseColor vermelho = new BaseColor(244, 81, 30);
        //static BaseColor amarelo = new BaseColor(255, 235, 59);        

        iTextSharp.text.pdf.draw.VerticalPositionMark seperator = new iTextSharp.text.pdf.draw.LineSeparator();

        //Estrutura do ListView
        private static double PercentOf(double valor, double total)
        {
            return (total / 100.0) * valor;
        }

        double larguraListView = 1280.0;
        Int32 colunaListView1 = 0;
        Int32 colunaListView2 = 4;
        Int32 colunaListView3 = 7;
        Int32 colunaListView4 = 7;
        Int32 colunaListView5 = 20;
        Int32 colunaListView6 = 41;
        Int32 colunaListView7 = 7;
        Int32 colunaListView8 = 7;
        Int32 colunaListView9 = 7;


        private void abrirFormAddPropostaNovo(object obj)
        {
            Application.Run(new frm_addPropostaComercial(id));
        }

        private void abrirFormAddPropostaEditar(object obj)
        {
            Application.Run(new frm_addPropostaComercial(codigo));
        }

        private void abrirFormListaPropostaServico(object obj)
        {
            Application.Run(new frm_listaPropostaComercialServico(codigo, cliente, baseCliente, dataProposta, titulo, valor));
        }

        private void abrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
        }

        public void EstadoInicial()
        {
            //Botões de Registros
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_sair.Visible = true;

            //Botôes de Registro Selecionado
            this.btn_servico.Visible = false;
            this.btn_os.Visible = false;
            this.btn_imprimir.Visible = false;            
            this.btn_enviarEmail.Visible = false;
            this.btn_cancelarP.Visible = false;

            this.btn_sair.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.cmb_status.Enabled = true;
            this.lvw_listaPropostaComercial.Enabled = true;

            this.cmb_status.Text = "";
            this.cmb_status.Focus();
        }

        //private void SelecionarPropostaEditar(string codigoProposta)
        //{
        //    dto.Codigo = codigoProposta;

        //    List<PropostaComercialDTO> prop = bll.SelecionarPropostaComercial(dto);

        //    Int32 id = prop[0].Id;
        //    string codigo = prop[0].Codigo;
        //    string dataProposta = prop[0].DataProposta;
        //    string cliente = prop[0].Cliente;
        //    string baseCliente = prop[0].BaseCliente;
        //    string titulo = prop[0].Titulo;
        //    string descricao = prop[0].Descricao;
        //    string observacao = prop[0].Observacao;
        //    string condPgto = prop[0].CondicaoPgto;
        //    string formaPgto = prop[0].FormaPgto;
        //    Int32 valor = prop[0].Valor;
        //    string statusProp = prop[0].Status;

        //    frm_addPropostaComercial proposta = new frm_addPropostaComercial(id, codigo, dataProposta, cliente, baseCliente, titulo, descricao, observacao, condPgto, formaPgto, valor, statusProp);
        //}

        private void CriarNovaProposta()
        {
            bll.CriarNovoPropostaComercial(dto);

            id = dto.Id + 1;

            this.Close();
            t1 = new Thread(abrirFormAddPropostaNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();         
        }

        private void EditarProposta()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            statusAtual = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[8].Text;

            if(statusAtual == "Criada" || statusAtual == "Enviada")
            {
                DialogResult resultCriada = MessageBox.Show("Deseja realmente editar esta Proposta?", "Editar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultCriada == DialogResult.Yes)
                {
                    this.Close();
                    t1 = new Thread(abrirFormAddPropostaEditar);
                    t1.SetApartmentState(ApartmentState.STA);
                    t1.Start();
                }
            }
            else
            {
                MessageBox.Show("Essa Proposta não poderá ser editada porque ela já foi aprovada, concluída, recebida ou está a receber!", "Editar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void CancelarProposta()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            statusAtual = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[8].Text;

            dto.Codigo = codigo;
            dto.Status = "Cancelada";

            if (statusAtual == "Criada" || statusAtual == "Enviada")
            {
                bll.AtualizarStatusProposta(dto);

                MessageBox.Show("Proposta Comercial cancelada com sucesso!", "Cancelar Proposta!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ListaPropostaComercial();
                this.EstadoInicial();
            }
            else if(statusAtual == "Cancelada")
            {
                MessageBox.Show("Proposta Comercial já foi cancelada!", "Cancelar Proposta!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

        }

        public void SelecionarProposta()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            statusAtual = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[8].Text;

            switch (statusAtual)
            {
                case  "Criada":
                    //Botões de Registros
                    this.btn_novo.Visible = false;
                    this.btn_cancelar.Visible = true;
                    this.btn_editar.Visible = true;
                    this.btn_deletar.Visible = true;
                    this.btn_sair.Visible = false;

                    this.btn_deletar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
                    this.btn_editar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
                    this.btn_cancelar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

                    //Botôes de Registro Selecionado
                    this.btn_cancelarP.Visible = true;
                    this.btn_imprimir.Visible = true;
                    this.btn_servico.Visible = true;
                    this.btn_enviarEmail.Visible = true;
                    this.btn_os.Visible = false;
                    this.btn_aprovar.Visible = false;

                    this.btn_enviarEmail.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_servico.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor02, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_imprimir.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor03, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_cancelarP.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor04, MedidasGeraisDTO.posicaoSubMenuVer);
                    break;

                case "Enviada":
                    //Botões de Registros
                    this.btn_novo.Visible = false;
                    this.btn_cancelar.Visible = true;
                    this.btn_editar.Visible = true;
                    this.btn_deletar.Visible = true;
                    this.btn_sair.Visible = false;

                    this.btn_deletar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
                    this.btn_editar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
                    this.btn_cancelar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

                    //Botôes de Registro Selecionado
                    this.btn_cancelarP.Visible = true;
                    this.btn_imprimir.Visible = true;
                    this.btn_servico.Visible = true;
                    this.btn_enviarEmail.Visible = false;
                    this.btn_os.Visible = false;
                    this.btn_aprovar.Visible = true;

                    this.btn_aprovar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_servico.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor02, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_imprimir.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor03, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_cancelarP.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor04, MedidasGeraisDTO.posicaoSubMenuVer);
                    break;

                case "Cancelada":
                    //Botões de Registros
                    this.btn_novo.Visible = false;
                    this.btn_cancelar.Visible = true;
                    this.btn_editar.Visible = true;
                    this.btn_deletar.Visible = true;
                    this.btn_sair.Visible = false;

                    this.btn_deletar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
                    this.btn_editar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
                    this.btn_cancelar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

                    //Botôes de Registro Selecionado
                    this.btn_cancelarP.Visible = false;
                    this.btn_imprimir.Visible = false;
                    this.btn_servico.Visible = false;
                    this.btn_enviarEmail.Visible = false;
                    this.btn_os.Visible = false;
                    this.btn_aprovar.Visible = true;

                    this.btn_aprovar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
                    break;

                case "Aprovada":
                    //Botões de Registros
                    this.btn_novo.Visible = false;
                    this.btn_cancelar.Visible = true;
                    this.btn_editar.Visible = false;
                    this.btn_deletar.Visible = false;
                    this.btn_sair.Visible = false;

                    this.btn_cancelar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);

                    //Botôes de Registro Selecionado
                    this.btn_cancelarP.Visible = true;
                    this.btn_imprimir.Visible = false;
                    this.btn_servico.Visible = false;
                    this.btn_enviarEmail.Visible = false;
                    this.btn_os.Visible = true;
                    this.btn_aprovar.Visible = false;

                    this.btn_cancelarP.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
                    this.btn_os.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor02, MedidasGeraisDTO.posicaoSubMenuVer);
                    break;

                case "Andamento":
                    break;

                case "Concluída":
                    break;

                case "A Receber":
                    break;
                        
                case "Recebida":
                    break;

            }

            //Botões de Registros
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_deletar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_editar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
            this.btn_cancelar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

            //Botôes de Registro Selecionado
            this.btn_cancelarP.Visible = true;
            this.btn_imprimir.Visible = true;
            this.btn_servico.Visible = true;
            this.btn_enviarEmail.Visible = true;
            this.btn_os.Visible = true;

            this.btn_os.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_enviarEmail.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor02, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_servico.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor03, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_imprimir.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor04, MedidasGeraisDTO.posicaoSubMenuVer);
            this.btn_cancelarP.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor05, MedidasGeraisDTO.posicaoSubMenuVer);
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

            codigo = dto.Codigo;
            cliente = pro[0].Cliente;
            baseCliente = pro[0].BaseCliente;
            dataProposta = pro[0].DataProposta.ToString("dd/MM/yyyy");
            titulo = pro[0].Titulo;
            valor = pro[0].Valor;
            
            this.Close();
            t1 = new Thread(abrirFormListaPropostaServico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
                
        private void ImprimirProposta()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

            //this.SelecionarDadosEmpresa();
            this.SelecionarDadosProposta(codigo);
            this.SelecionarDadosCliente();            
            this.SelecionarDadosServicoProposta(codigo);

            //Estrutura do Arquivo
            var nomeArquivo = "Proposta Comercial " + codigo;
            var localArquivo = Application.StartupPath + @"\Documentos\PropostaComercial\" + nomeArquivo + ".pdf";
            var imagemTopo = Application.StartupPath + @"\Imagens\Sistema\logo_impressao.jpg";
            var fonteBase = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            var fonteBaseBold = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);

            using (PdfWriter wPdf = new PdfWriter(localArquivo, new WriterProperties().SetPdfVersion(PdfVersion.PDF_2_0)))
            {
                var pdfDocument = new PdfDocument(wPdf);
                var pcPorMm = 72 / 25.2F; //pixels / milimetros
                var document = new Document(pdfDocument, PageSize.A4);
                    document.SetMargins(45 * pcPorMm, 10 * pcPorMm, 10 * pcPorMm, 10 * pcPorMm);
                    document.SetCharacterSpacing((float)0.2);

                //Cabeçalho
                ImageData imagemData = ImageDataFactory.Create(imagemTopo); //Imagem do Topo
                Image img = new Image(imagemData)
                    .ScaleAbsolute(190 * pcPorMm, 35 * pcPorMm)
                    .SetFixedPosition(1, 10 * pcPorMm, 250 * pcPorMm);

                //Linha Separadora
                SolidLine line = new SolidLine(1f);
                line.SetColor(ColorConstants.LIGHT_GRAY);
                LineSeparator linhaSeparadora = new LineSeparator(line);

                //Dados da Proposta                
                var dadosPropostaTitulo = new Paragraph() //Título
                    .SetFont(fonteBaseBold)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Dados da Proposta");
                
                var dadosPropostaLinha1 = new Paragraph() //Linha 1
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Número: " + numeroProposta + " - " + "Data: " + dataProposta);
                
                var dadosPropostaLinha2 = new Paragraph() //Linha 2
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Título: " + tituloProposta);
                
                var dadosPropostaLinha3 = new Paragraph() //Linha 3
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Descrição: " + descricaoProposta);
                
                var dadosPropostaLinha4 = new Paragraph() //Linha 4
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Observações: " + observacaoProposta);              

                //Dados do Cliente                
                var dadosClienteTitulo = new Paragraph() //Título
                    .SetFont(fonteBaseBold)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)            
                    .Add("Dados do Cliente");                

                var dadosClienteLinha1 = new Paragraph() //Linha 1
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add(nomeClienteBase);

                //Tabela de Serviços               
                var tabelaServicoTitulo = new Paragraph() //Título
                    .SetFont(fonteBaseBold)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Lista de Serviços");

                float[] columnWidths = { 5, 5, 5, 61, 12, 12 };
                Table tabela = new Table(UnitValue.CreatePercentArray(columnWidths))
                    .UseAllAvailableWidth()
                    .SetFont(fonteBase)
                    .SetFontSize(8);

                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(ColorConstants.DARK_GRAY)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph("Item"))); ;
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(ColorConstants.DARK_GRAY)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph("Qtd")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(ColorConstants.DARK_GRAY)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph("Tipo")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(ColorConstants.DARK_GRAY)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph("Descrição")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(ColorConstants.DARK_GRAY)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph("Valor Unit.")));
                tabela.AddHeaderCell(new Cell()
                    .SetTextAlignment(TextAlignment.CENTER)
                    .SetBorder(Border.NO_BORDER)
                    .SetBackgroundColor(ColorConstants.DARK_GRAY)
                    .SetFontColor(ColorConstants.WHITE)
                    .Add(new Paragraph("Total")));

                Int32 itemServico = 1;

                foreach (PropostaComercialServicoDTO s in listaServicoProposta)
                {
                    if (itemServico % 2 == 1)
                    {
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                            .Add(new Paragraph(itemServico.ToString())));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                            .Add(new Paragraph(s.Qtd.ToString())));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                            .Add(new Paragraph(s.TipoServico)));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                            .Add(new Paragraph(s.Descricao)));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                            .Add(new Paragraph(s.ValorUnitario.ToString("R$ #,##0.00"))));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.LIGHT_GRAY)
                            .Add(new Paragraph(s.ValorTotal.ToString("R$ #,##0.00"))));
                    }
                    else
                    {
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .Add(new Paragraph(itemServico.ToString())));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .Add(new Paragraph(s.Qtd.ToString())));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.CENTER)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .Add(new Paragraph(s.TipoServico)));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.LEFT)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .Add(new Paragraph(s.Descricao)));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .Add(new Paragraph(s.ValorUnitario.ToString("R$ #,##0.00"))));
                        tabela.AddCell(new Cell()
                            .SetTextAlignment(TextAlignment.RIGHT)
                            .SetBorder(Border.NO_BORDER)
                            .SetBackgroundColor(ColorConstants.WHITE)
                            .Add(new Paragraph(s.ValorTotal.ToString("R$ #,##0.00"))));
                    }

                    itemServico++;
                }

                tabela.AddFooterCell(new Cell(1, 6)
                    .SetFontSize(12)
                    .SetFont(fonteBaseBold)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetBackgroundColor(ColorConstants.ORANGE)
                    .SetBorder(Border.NO_BORDER)
                    .Add(new Paragraph("Total: " + valorTotalProposta.ToString("R$ #,##0.00"))));

                //Garantia                
                var dadosGarantiaTitulo = new Paragraph() //Título
                    .SetFont(fonteBaseBold)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Garantia");

                var dadosGarantiaLinha1 = new Paragraph() //Linha 1
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Serviço: 30 dias - Equipamento: De acordo com o fabricante");

                var formaPagamento = new Paragraph() //Linha 1
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.LEFT)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("Condição de Pgto: " + condPgtoProposta + " - Forma de Pgto: " + formaPgtoProposta);

                var mensagem = new Paragraph() //Linha 1
                    .SetFont(fonteBase)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.JUSTIFIED)
                    .SetFontColor(ColorConstants.BLACK)
                    .SetFirstLineIndent(30)
                    .Add("A SEGSAL - Segurança Eletrônica desde já agradece a oportunidade e se coloca à disposição para quaisquer esclarecimentos sobre este orçamento.");

                var dataPorExtenso = new Paragraph()
                    .SetFont(fonteBaseBold)
                    .SetFontSize(8)
                    .SetTextAlignment(TextAlignment.RIGHT)
                    .SetFontColor(ColorConstants.BLACK)
                    .Add(dataPropostaExtenso);

                document.Add(img);
                document.Add(dadosPropostaTitulo);
                document.Add(linhaSeparadora);
                document.Add(dadosPropostaLinha1);
                document.Add(dadosPropostaLinha2);
                document.Add(dadosPropostaLinha3);
                document.Add(dadosPropostaLinha4);
                document.Add(new Paragraph("\n"));
                document.Add(dadosClienteTitulo);
                document.Add(linhaSeparadora);
                document.Add(dadosClienteLinha1);
                document.Add(new Paragraph("\n"));
                document.Add(tabelaServicoTitulo);
                document.Add(linhaSeparadora);
                document.Add(tabela);
                document.Add(new Paragraph("\n"));
                document.Add(dadosGarantiaTitulo);
                document.Add(linhaSeparadora);
                document.Add(dadosGarantiaLinha1);
                document.Add(formaPagamento);
                document.Add(new Paragraph("\n"));
                document.Add(linhaSeparadora);
                document.Add(mensagem);
                document.Add(new Paragraph("\n"));
                document.Add(dataPorExtenso);

                document.Close();
                pdfDocument.Close();
            }

            frm_progressoImpressao print = new frm_progressoImpressao();
            print.Show();

            this.ListaPropostaComercial();
        }

        private void EnviarProposta()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            statusAtual = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[8].Text;

            dto.Codigo = codigo;
            dto.Status = "Enviada";

            if(statusAtual == "Criada")
            {
                bll.AtualizarStatusProposta(dto);

                MessageBox.Show("Proposta Comercial enviada com sucesso!", "Enviar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ListaPropostaComercial();
                this.EstadoInicial();
            }
            else
            {
                MessageBox.Show("Proposta Comercial já foi enviada!", "Enviar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }        
        }

        private void AprovarProposta()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            statusAtual = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[8].Text;

            dto.Codigo = codigo;
            dto.Status = "Aprovada";

            if(statusAtual == "Enviada")
            {
                bll.AtualizarStatusProposta(dto);

                MessageBox.Show("Proposta Comercial aprovada com sucesso!", "Aprovar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ListaPropostaComercial();
                this.EstadoInicial();
            }
            else
            {
                MessageBox.Show("Proposta Comercial já foi aprovada!", "Aprovar!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void SelecionarDadosEmpresa()
        {
            //Selecionar dados da Empresa
            List<EmpresaDTO> empresa = empBll.SelecionarEmpresa();

            cabecalhoLinha1 = empresa[0].NomeFantasia;
            string cnpjEmpresaBD = empresa[0].Cnpj;
 
            for (int i = 0; i < cnpjEmpresaBD.Length; i++)
            {
                if(i == 2)
                {
                    cnpjEmpresa = cnpjEmpresa + ".";
                }
                else if(i == 5)
                {
                    cnpjEmpresa = cnpjEmpresa + ".";
                }
                else if(i == 8)
                {
                    cnpjEmpresa = cnpjEmpresa + "/";
                }
                else if (i == 12)
                {
                    cnpjEmpresa = cnpjEmpresa + "-";
                }

                cnpjEmpresa = cnpjEmpresa + cnpjEmpresaBD.Substring(i, 1);
            }

            cabecalhoLinha2 = "CNPJ: " + cnpjEmpresa;
            cabecalhoLinha3 = empresa[0].Endereco + ", " + empresa[0].Complemento + ", " + empresa[0].Bairro + ", " + empresa[0].Cidade + "/" + empresa[0].Uf + ", CEP.: " + empresa[0].Cep;
            cabecalhoLinha4 = "Fone: " + empresa[0].Celular + " - E-mail: " + empresa[0].Email;

            logomarcaCabecalho = Application.StartupPath + empresa[0].LogoImpressao;
        }

        private void SelecionarDadosCliente()
        {
            //Selecionar dados do cliente
            nomeClienteBase = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[4].Text;
            string[] clienteQuebrado = nomeClienteBase.Split('-');

            cliDto.NomeFantasia = clienteQuebrado[0];
            basDto.Cliente = clienteQuebrado[0];
            basDto.NomeBase = clienteQuebrado[1];

            cliDto.Codigo = cliBll.SelecionarCodigoCliente(cliDto);
            basDto.Codigo = basBll.SelecionarCodigoBaseCliente(basDto);
            
            List<BaseClienteDTO> cliente = basBll.SelecionarBaseCliente(basDto);
            string cnpjBC = cliente[0].Cnpj;

            for (int i = 0; i < cnpjBC.Length; i++)
            {
                if (i == 2)
                {
                    cnpjBaseCliente = cnpjBaseCliente + ".";
                }
                else if (i == 5)
                {
                    cnpjBaseCliente = cnpjBaseCliente + ".";
                }
                else if (i == 8)
                {
                    cnpjBaseCliente = cnpjBaseCliente + "/";
                }
                else if (i == 12)
                {
                    cnpjBaseCliente = cnpjBaseCliente + "-";
                }

                cnpjBaseCliente = cnpjBaseCliente + cnpjBC.Substring(i, 1);
            }

            clienteLinha1 = cliente[0].Cliente + " - " + cliente[0].NomeBase; 
            clienteLinha2 = cnpjBaseCliente;
            clienteLinha3 = cliente[0].Endereco + ", " + cliente[0].Complemento + ", " + cliente[0].Bairro + ", " + cliente[0].Cidade + "/" + cliente[0].Uf + ", CEP.: " + cliente[0].Cep;
        }

        private void SelecionarDadosProposta(string codigo)
        {
            //Selecionar dados da Proposta
            dto.Codigo = codigo;
            List<PropostaComercialDTO> proposta = bll.SelecionarPropostaComercial(dto);

            numeroProposta = proposta[0].Codigo;
            dataProposta = proposta[0].DataProposta.ToString("dd/MM/yyyy");
            tituloProposta = proposta[0].Titulo;
            descricaoProposta = proposta[0].Descricao;
            observacaoProposta = proposta[0].Observacao;
            condPgtoProposta = proposta[0].CondicaoPgto;
            formaPgtoProposta = proposta[0].FormaPgto;
            valorTotalProposta = proposta[0].Valor;
            nomeCliente = proposta[0].Cliente;
            nomeBaseCliente = proposta[0].BaseCliente;
            string dataPropostaExt = proposta[0].DataProposta.ToString("dd/MMMM/yyyy");
            dataPropostaExtenso = "Fortaleza/CE, " + dataPropostaExt;            
        }

        private void SelecionarDadosServicoProposta(string codigo)
        {
            //Selecionar dados do Serviço da Proposta
            serDto.Proposta = codigo;
            listaServicoProposta = serBll.ListaServicoPropostaSigla(serDto);
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

            string[] item = new string[9];
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
                item[3] = pro.DataProposta.ToString("dd/MM/yyyy");
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

            if (status == "A Receber")
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
                item[3] = pro.DataProposta.ToString("dd/MM/yyyy");
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

        private void CriarOrdemServico()
        {
            codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;
            dto.Codigo = codigo;

            List<PropostaComercialDTO> propC = bll.SelecionarPropostaComercial(dto);

            string statusPC = propC[0].Status;
            string codigoPC = propC[0].Codigo;

            if(statusPC == "Aprovada")
            {
                ordBll.CriarNovoOrdemServico(ordDto);

                Int32 id = ordDto.Id + 1;
                string codigoOS = "OS-" + id.ToString("0000#");

                DateTime dataRegistro = DateTime.Now.Date;

                dto.Codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

                List<PropostaComercialDTO> prop = bll.SelecionarPropostaComercial(dto);

                ordDto.Id = id;
                ordDto.Codigo = codigoOS;
                ordDto.DataRegistro = dataRegistro;
                ordDto.Cliente = prop[0].Cliente;
                ordDto.BaseCliente = prop[0].BaseCliente;
                ordDto.Titulo = prop[0].Titulo;
                ordDto.Descricao = prop[0].Descricao;
                ordDto.Obsevacao = prop[0].Observacao;
                ordDto.Proposta = dto.Codigo;
                ordDto.Progresso = 0;
                ordDto.Status = "A Iniciar";

                ordBll.SalvarOrdemServico(ordDto);

                dto.OrdemServico = codigoOS;
                dto.Status = "Andamento";

                bll.CriarOrdemServicoPropostaComercial(dto);
                bll.AtualizarStatusProposta(dto);

                MessageBox.Show("Ordem de Serviço Nº " + codigoOS + " Cadastrada com sucesso!", "Criar Ordem de Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.cmb_status.Text = "Aprovada";
                this.ListaPropostaComercialStatus(this.cmb_status.Text);
            }
            else
            {
                MessageBox.Show("A Proposta Comercial Nº " + codigoPC + " não pode ser convertida em Ordem de Serviço porque não está aprovada!", "Erro ao Criar Ordem de Serviço!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }            
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
                t1 = new Thread(abrirFormPrincipal);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }
        }


        private void SalvarVariasPropostas()
        {
            //Excel.Application app = new Excel.Application();





            //dto.Id = Int32.Parse(prop5[0]);
            //dto.Codigo = prop5[1];
            //dto.DataProposta = DateTime.Parse(prop5[2]);
            //dto.Titulo = prop5[3];
            //dto.Descricao = prop5[4];
            //dto.Observacao = prop5[5];
            //dto.Cliente = prop5[6];
            //dto.BaseCliente = prop5[7];
            //dto.CondicaoPgto = prop5[8];
            //dto.FormaPgto = prop5[9];
            //dto.Valor = Int32.Parse(prop5[10]);
            //dto.Status = prop5[11];
            //dto.NotaFiscal = prop5[12];

            //bll.SalvarPropostaComercial(dto);            

            //MessageBox.Show("Salvo com sucesso!");



            












        }

        public frm_listaPropostaComercial()
        {
            InitializeComponent();

            propostaInstancia = this;
        }

        

        private void frm_listaPropostaComercial_Load(object sender, EventArgs e)
        {
            this.lvw_listaPropostaComercial.Columns.Add("Id", (int)PercentOf(colunaListView1, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Item", (int)PercentOf(colunaListView2, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Número", (int)PercentOf(colunaListView3, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Data", (int)PercentOf(colunaListView4, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lvw_listaPropostaComercial.Columns.Add("Cliente-Base", (int)PercentOf(colunaListView5, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lvw_listaPropostaComercial.Columns.Add("Título", (int)PercentOf(colunaListView6, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lvw_listaPropostaComercial.Columns.Add("Valor", (int)PercentOf(colunaListView7, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.lvw_listaPropostaComercial.Columns.Add("Nota Fiscal", (int)PercentOf(colunaListView8, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.lvw_listaPropostaComercial.Columns.Add("Status", (int)PercentOf(colunaListView9, larguraListView)).TextAlign = System.Windows.Forms.HorizontalAlignment.Left;

            this.EstadoInicial();
            this.cmb_status.Text = "";
            this.ListaPropostaComercial();
            this.PopularComboboxStatus();            
        }

        private void lvw_listaPropostaComercial_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaPropostaComercial.SelectedItems.Count > 0)
            {                
                this.SelecionarProposta();
            }
        }

        private void lvw_listaPropostaComercial_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmb_status_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_status.Text == "SistemaSegsal.DTO.PropostaComercialStatusDTO")
            {
                return;
            }

            else
            {
                //string status = this.cmb_status.Text;
                //this.ListaPropostaComercialStatus(status);
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            string status = this.cmb_status.Text;

            this.ListaPropostaComercialStatus(status);
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

        private void btn_servico_Click(object sender, EventArgs e)
        {
            this.ServicoProposta();
        }       

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            this.DeletarProposta();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                
        }

        private void btn_ordemServico_Click(object sender, EventArgs e)
        {
            this.CriarOrdemServico();
        }

        private void btn_servico_Click_1(object sender, EventArgs e)
        {
            this.ServicoProposta();
        }

        private void btn_imprimir_Click_1(object sender, EventArgs e)
        {            
            this.ImprimirProposta();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_os_Click(object sender, EventArgs e)
        {
            this.CriarOrdemServico();
        }

        private void btn_novo_Click_1(object sender, EventArgs e)
        {
            this.CriarNovaProposta();            
        }

        private void btn_editar_Click_1(object sender, EventArgs e)
        {
            this.EditarProposta();
        }

        private void btn_enviarEmail_Click(object sender, EventArgs e)
        {
             this.EnviarProposta();
        }

        private void btn_cancelar_Click_1(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_aprovar_Click(object sender, EventArgs e)
        {
            this.AprovarProposta();
        }

        private void btn_cancelarP_Click(object sender, EventArgs e)
        {
            this.CancelarProposta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.SalvarVariasPropostas();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_filtrar_Click_1(object sender, EventArgs e)
        {
            string status = this.cmb_status.Text;

            this.ListaPropostaComercialStatus(status);
        }

        private void btn_listarTodas_Click(object sender, EventArgs e)
        {
            this.ListaPropostaComercial();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_valorProposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_qtdProposta_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void img_logoEmpresa_Click(object sender, EventArgs e)
        {

        }

        private void lbl_titulo_Click(object sender, EventArgs e)
        {

        }

        private void lvw_listaPropostaComercial_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
