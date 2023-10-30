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
using Microsoft.Reporting;
using System.IO;
using Microsoft.Reporting.WinForms;
using iTextSharp.text;
using iTextSharp.text.pdf;

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

        public static frm_listaPropostaComercial propostaInstancia;

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

        //Proposta
        string numeroProposta;
        string dataProposta;
        string tituloProposta;
        string descricaoProposta;
        string observacaoProposta;
        string condPgtoProposta;
        string formaPgtoProposta;
        Int32 valorTotalProposta;
        string dataPropostaExtenso;        

        //Serviço Proposta
        List<PropostaComercialServicoDTO> listaServicoProposta;


        static BaseFont fonteBase = BaseFont.CreateFont(BaseFont.COURIER, BaseFont.CP1252, false);
        static BaseColor azulNavy = new BaseColor(0, 0, 128);
        static BaseColor preto = new BaseColor(0, 0, 0);
        static BaseColor branco = new BaseColor(255, 255, 255);
        static BaseColor cinzaMedio = new BaseColor(158, 158, 158);
        static BaseColor cinzaClaro = new BaseColor(240, 240, 240);
        static BaseColor azulClaro = new BaseColor(128, 216, 255);
        static BaseColor vermelho = new BaseColor(244, 81, 30);
        static BaseColor amarelo = new BaseColor(255, 235, 59);

        iTextSharp.text.pdf.draw.VerticalPositionMark seperator = new iTextSharp.text.pdf.draw.LineSeparator();

        private void EstadoInicial()
        {
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_servico.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_sair.Location = new Point(1277, 5);
            this.btn_novo.Location = new Point(1212, 5);

            this.cmb_status.Enabled = true;
            this.lvw_listaPropostaComercial.Enabled = true;

            this.cmb_status.Focus();
        }

        public void CarregarDadosEmpresa()
        {
            //List<EmpresaDTO> empresa = empBll.SelecionarEmpresa();
            //cabecalhoL1 = empresa[0].NomeFantasia;
            //cabecalhoL2 = "CNPJ: " + empresa[0].Cnpj;
            //cabecalhoL3 = empresa[0].Endereco + ", " + empresa[0].Complemento + ", " + empresa[0].Bairro + ", " + empresa[0].Cidade + "/" + empresa[0].Uf + ", CEP.: " + empresa[0].Cep;
            //cabecalhoL4 = "Fone: " + empresa[0].Celular + " - E-mail: " + empresa[0].Email;
            //logomarcaCabecalho = Application.StartupPath + empresa[0].LogoImpressao;
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

        public void SelecionarCodigoProposta()
        {
            //Visualização dos Botões
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_servico.Visible = true;
            this.btn_imprimir.Visible = true;
            this.btn_sair.Visible = false;

            //Posição dos Botões            
            this.btn_imprimir.Location = new Point(1277, 5);
            this.btn_servico.Location = new Point(1212, 5);
            this.btn_deletar.Location = new Point(1147, 5);
            this.btn_editar.Location = new Point(1082, 5);
            this.btn_cancelar.Location = new Point(1017, 5);
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

        
        private void ImprimirProposta(string numeroProposta)
        {
            this.SelecionarDadosEmpresa();
            this.SelecionarDadosProposta(numeroProposta);
            this.SelecionarDadosCliente();            
            this.SelecionarDadosServicoProposta(numeroProposta);

            //Estrutura do Relatório
            var pcPorMm = 72 / 25.2F; //pixels / milimetros
            var pdf = new Document(PageSize.A4, 10 * pcPorMm, 10 * pcPorMm, 10 * pcPorMm, 10 * pcPorMm); //Margens do documento
            var nomeArquivo = Application.StartupPath + @"\Documentos\PropostaComercial\Proposta Comercial " + numeroProposta + ".pdf";
            var arquivo = new FileStream(nomeArquivo, FileMode.Create);
            var writer = PdfWriter.GetInstance(pdf, arquivo);
            pdf.Open();
            
            //Cabeçalho
            var fonteCabecalhoLinha1 = new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, cinzaMedio);
            var fonteCabecalhoLinha2 = new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, cinzaMedio);
            var fonteCabecalhoLinha3 = new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.NORMAL, cinzaMedio);
            var fonteCabecalhoLinha4 = new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.NORMAL, cinzaMedio);

            var textoCabecalhoLinha1 = new Paragraph(cabecalhoLinha1, fonteCabecalhoLinha1); //Linha 1
            textoCabecalhoLinha1.Alignment = Element.ALIGN_RIGHT;

            var textoCabecalhoLinha2 = new Paragraph(cabecalhoLinha2, fonteCabecalhoLinha2); //Linha 2
            textoCabecalhoLinha2.Alignment = Element.ALIGN_RIGHT;

            var textoCabecalhoLinha3 = new Paragraph(cabecalhoLinha3, fonteCabecalhoLinha3); //Linha 3
            textoCabecalhoLinha3.Alignment = Element.ALIGN_RIGHT;

            var textoCabecalhoLinha4 = new Paragraph(cabecalhoLinha4, fonteCabecalhoLinha4); //Linha 4
            textoCabecalhoLinha4.Alignment = Element.ALIGN_RIGHT;

            var caminhoImagem = logomarcaCabecalho; //Logomarca
            if (File.Exists(caminhoImagem))
            {
                iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(caminhoImagem);
                float razaoAlturaLargura = logo.Width / logo.Height;
                float alturaLogo = 60;
                float larguraLogo = alturaLogo * razaoAlturaLargura;
                logo.ScaleToFit(larguraLogo, alturaLogo);
                var margemEsquerda = pdf.LeftMargin;
                var margemTopo = pdf.PageSize.Height - pdf.TopMargin - 54;
                logo.SetAbsolutePosition(margemEsquerda, margemTopo);
                writer.DirectContent.AddImage(logo, false);
            }

            //Título do Relatório
            PdfPTable tituloRelatorio = new PdfPTable(1);
            tituloRelatorio.TotalWidth = 190 * pcPorMm;
            tituloRelatorio.LockedWidth = true;
            tituloRelatorio.SetWidths(new float[] { 190 * pcPorMm });

            PdfPCell celulaTituloRelatorio = new PdfPCell(new Phrase("PROPOSTA COMERCIAL", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaTituloRelatorio.BackgroundColor = amarelo;
            celulaTituloRelatorio.Colspan = 2;
            celulaTituloRelatorio.HorizontalAlignment = 1;
            celulaTituloRelatorio.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaTituloRelatorio.FixedHeight = 20;
            tituloRelatorio.AddCell(celulaTituloRelatorio);

            //Tabela Dados data Proposta
            PdfPTable dadosDataProposta = new PdfPTable(4);
            dadosDataProposta.TotalWidth = 190 * pcPorMm;
            dadosDataProposta.LockedWidth = true;
            dadosDataProposta.SetWidths(new float[] { 30 * pcPorMm, 65 * pcPorMm, 30 * pcPorMm, 65 * pcPorMm });

            PdfPCell celulaDataProposta = new PdfPCell(new Phrase("Dados da Proposta", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaDataProposta.BackgroundColor = cinzaClaro;
            celulaDataProposta.Colspan = 4;
            celulaDataProposta.HorizontalAlignment = 1;
            celulaDataProposta.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaDataProposta.FixedHeight = 20;
            dadosDataProposta.AddCell(celulaDataProposta);

            dadosDataProposta.AddCell(new Phrase("Código:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosDataProposta.AddCell(new Phrase(numeroProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));
            dadosDataProposta.AddCell(new Phrase("Data:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosDataProposta.AddCell(new Phrase(dataProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));

            //Tabela Dados da Proposta
            PdfPTable dadosProposta = new PdfPTable(2);
            dadosProposta.TotalWidth = 190 * pcPorMm;
            dadosProposta.LockedWidth = true;
            dadosProposta.SetWidths(new float[] { 30 * pcPorMm, 160 * pcPorMm });
     
            dadosProposta.AddCell(new Phrase("Título:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosProposta.AddCell(new Phrase(tituloProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, vermelho)));
            dadosProposta.AddCell(new Phrase("Descrição:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosProposta.AddCell(new Phrase(descricaoProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));
            dadosProposta.AddCell(new Phrase("Observação:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosProposta.AddCell(new Phrase(observacaoProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));

            //Tabela Dados do Cliente
            PdfPTable dadosCliente = new PdfPTable(2);
            dadosCliente.TotalWidth = 190 * pcPorMm;
            dadosCliente.LockedWidth = true;
            dadosCliente.SetWidths(new float[] { 30 * pcPorMm, 160 * pcPorMm });

            PdfPCell celulaCliente = new PdfPCell(new Phrase("Dados do Cliente", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaCliente.BackgroundColor = cinzaClaro;
            celulaCliente.Colspan = 2;
            celulaCliente.HorizontalAlignment = 1;
            celulaCliente.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaCliente.FixedHeight = 20;
            dadosCliente.AddCell(celulaCliente);

            dadosCliente.AddCell(new Phrase("Nome Fantasia:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosCliente.AddCell(new Phrase(clienteLinha1, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));
            dadosCliente.AddCell(new Phrase("CNPJ:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosCliente.AddCell(new Phrase(clienteLinha2, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));
            dadosCliente.AddCell(new Phrase("Endereço:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosCliente.AddCell(new Phrase(clienteLinha3, new iTextSharp.text.Font(fonteBase, 10, iTextSharp.text.Font.NORMAL, preto)));

            //TabelaTitulo Serviço
            PdfPTable tituloServico = new PdfPTable(1);
            tituloServico.TotalWidth = 190 * pcPorMm;
            tituloServico.LockedWidth = true;
            tituloServico.SetWidths(new float[] { 190 * pcPorMm });

            PdfPCell celulaTituloServico = new PdfPCell(new Phrase("Lista de Serviços", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaTituloServico.BackgroundColor = cinzaClaro;
            celulaTituloServico.Colspan = 2;
            celulaTituloServico.HorizontalAlignment = 1;
            celulaTituloServico.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaTituloServico.FixedHeight = 20;
            tituloServico.AddCell(celulaTituloServico);

            //Tabela dados do Serviço da Proposta
            PdfPTable tabelaServico = new PdfPTable(6);
            tabelaServico.SetWidths(new float[] { 10 * pcPorMm, 10 * pcPorMm, 15 * pcPorMm, 105 * pcPorMm, 30 * pcPorMm, 30 * pcPorMm });
            tabelaServico.DefaultCell.BorderWidth = 0;
            tabelaServico.WidthPercentage = 100;

            CriarCelulaServico(tabelaServico, "Item", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaServico(tabelaServico, "Qtd", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaServico(tabelaServico, "Tipo", PdfPCell.ALIGN_CENTER, true);
            CriarCelulaServico(tabelaServico, "Descrição", PdfPCell.ALIGN_LEFT, true);
            CriarCelulaServico(tabelaServico, "Valor Unit.", PdfPCell.ALIGN_RIGHT, true);
            CriarCelulaServico(tabelaServico, "Valor Total", PdfPCell.ALIGN_RIGHT, true);

            Int32 itemServico = 1;

            foreach (PropostaComercialServicoDTO s in listaServicoProposta)
            {
                
                CriarCelulaServico(tabelaServico, itemServico.ToString(), PdfPCell.ALIGN_CENTER, true);
                CriarCelulaServico(tabelaServico, s.Qtd.ToString(), PdfPCell.ALIGN_CENTER, true);
                CriarCelulaServico(tabelaServico, s.TipoServico, PdfPCell.ALIGN_CENTER, true);
                CriarCelulaServico(tabelaServico, s.Descricao, PdfPCell.ALIGN_LEFT, true);
                CriarCelulaServico(tabelaServico, s.ValorUnitario.ToString("R$ #,##0.00"), PdfPCell.ALIGN_RIGHT, true);
                CriarCelulaServico(tabelaServico, s.ValorTotal.ToString("R$ #,##0.00"), PdfPCell.ALIGN_RIGHT, true);

                itemServico++;
            }


            //Valor da Proposta
            PdfPTable valorProposta = new PdfPTable(1);
            valorProposta.TotalWidth = 190 * pcPorMm;
            valorProposta.LockedWidth = true;
            valorProposta.SetWidths(new float[] { 190 * pcPorMm });

            PdfPCell celulaValor = new PdfPCell(new Phrase("Valor Total:     " + valorTotalProposta.ToString("R$ #,##0.00"), new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaValor.BackgroundColor = amarelo;
            celulaValor.Colspan = 2;
            celulaValor.HorizontalAlignment = 2;
            celulaValor.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaValor.FixedHeight = 20;
            valorProposta.AddCell(celulaValor);

            //Tabela Dados da Garantia
            PdfPTable dadosGarantia = new PdfPTable(4);
            dadosGarantia.TotalWidth = 190 * pcPorMm;
            dadosGarantia.LockedWidth = true;
            dadosGarantia.SetWidths(new float[] { 30 * pcPorMm, 50 * pcPorMm, 30 * pcPorMm, 80 * pcPorMm });

            PdfPCell celulaGarantia = new PdfPCell(new Phrase("Garantia", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaGarantia.BackgroundColor = cinzaClaro;
            celulaGarantia.Colspan = 4;
            celulaGarantia.HorizontalAlignment = 1;
            celulaGarantia.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaGarantia.FixedHeight = 20;
            dadosGarantia.AddCell(celulaGarantia);

            dadosGarantia.AddCell(new Phrase("Serviço:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosGarantia.AddCell(new Phrase("30 dias", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));
            dadosGarantia.AddCell(new Phrase("Equipamento:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosGarantia.AddCell(new Phrase("De acordo com o fabricante", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));

            //Tabela Dados do Comercial
            PdfPTable dadosComerciais = new PdfPTable(4);
            dadosComerciais.TotalWidth = 190 * pcPorMm;
            dadosComerciais.LockedWidth = true;
            dadosComerciais.SetWidths(new float[] { 30 * pcPorMm, 50 * pcPorMm, 30 * pcPorMm, 80 * pcPorMm });

            PdfPCell celulaComercial = new PdfPCell(new Phrase("Dados Comerciais", new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.BOLD, preto)));
            celulaComercial.BackgroundColor = cinzaClaro;
            celulaComercial.Colspan = 4;
            celulaComercial.HorizontalAlignment = 1;
            celulaComercial.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaComercial.FixedHeight = 20;
            dadosComerciais.AddCell(celulaComercial);

            dadosComerciais.AddCell(new Phrase("Cond. Pgto:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosComerciais.AddCell(new Phrase(condPgtoProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));
            dadosComerciais.AddCell(new Phrase("Forma Pgto:", new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.BOLD, preto)));
            dadosComerciais.AddCell(new Phrase(formaPgtoProposta, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.NORMAL, preto)));

            //Mensagem
            PdfPTable mensagem = new PdfPTable(1);
            mensagem.TotalWidth = 190 * pcPorMm;
            mensagem.LockedWidth = true;
            mensagem.SetWidths(new float[] { 190 * pcPorMm });

            PdfPCell celulaMensagem = new PdfPCell(new Phrase("A SEGSAL - Segurança Eletrônica desde já agradece a oportunidade e se coloca à disposição para quaisquer esclarecimentos sobre este orçamento.", new iTextSharp.text.Font(fonteBase, 10, iTextSharp.text.Font.ITALIC, preto)));
            celulaMensagem.BackgroundColor = branco;
            celulaMensagem.Colspan = 2;
            celulaMensagem.HorizontalAlignment = 0;
            celulaMensagem.VerticalAlignment = PdfPCell.ALIGN_TOP;
            celulaMensagem.FixedHeight = 30;
            mensagem.AddCell(celulaMensagem);

            //Data por Extenso
            Paragraph dataExtenso = new Paragraph(dataPropostaExtenso, new iTextSharp.text.Font(fonteBase, 12, iTextSharp.text.Font.ITALIC, preto)); 
            //Assinatura
            var caminhoAssinatura = Application.StartupPath + @"\Imagens\Sistema\assinatura.png"; //Assinatura
            if (File.Exists(caminhoImagem))
            {
                iTextSharp.text.Image ass = iTextSharp.text.Image.GetInstance(caminhoAssinatura);
                float razaoAlturaLargura = ass.Width / ass.Height;
                float alturaLogo = 30;
                float larguraLogo = alturaLogo * razaoAlturaLargura;
                ass.ScaleToFit(larguraLogo, alturaLogo);
                var margemEsquerda = pdf.LeftMargin + 280;
                var margemTopo = pdf.PageSize.Height - pdf.TopMargin - 800;
                ass.SetAbsolutePosition(margemEsquerda, margemTopo);
                writer.DirectContent.AddImage(ass, false);
            }


            pdf.Add(textoCabecalhoLinha1);
            pdf.Add(textoCabecalhoLinha2);
            pdf.Add(textoCabecalhoLinha3);
            pdf.Add(textoCabecalhoLinha4);
            pdf.Add(new Chunk("\n"));
            pdf.Add(tituloRelatorio);
            pdf.Add(new Chunk("\n"));
            pdf.Add(dadosDataProposta);
            pdf.Add(dadosProposta);
            pdf.Add(new Chunk("\n"));
            pdf.Add(dadosCliente);
            pdf.Add(new Chunk("\n"));
            pdf.Add(tituloServico);
            pdf.Add(tabelaServico);
            pdf.Add(valorProposta);
            pdf.Add(new Chunk("\n"));
            pdf.Add(dadosGarantia);
            pdf.Add(new Chunk("\n"));
            pdf.Add(dadosComerciais);
            pdf.Add(mensagem);
            pdf.Add(new Chunk("\n"));
            pdf.Add(dataExtenso);

            pdf.Close();
            arquivo.Close();

            MessageBox.Show("Proposta Comercial Nº " + dto.Codigo + " impressa com sucesso!", "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);






            //Cabeçalho
            //Paragraph cabecalho = new Paragraph();
            //cabecalho.Font = new System.Drawing.Font(Font.FontFamily.COURIER, 12);

            ////Código da base do Cliente
            //string baseCliente = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[4].Text;
            //string[] baseC = baseCliente.Split('-');
            //basDto.NomeBase = baseC[1];

            //string codBase = basBll.SelecionarCodigoBaseCliente(basDto);




            //this.SelecionarDadosCliente(codBase);
            //this.SelecionarDadosProposta(codigoProposta);
            ////this.SelecionarDadosServicoProposta(codigoProposta);


            //ReportViewer reportViewer = new ReportViewer();
            //reportViewer.ProcessingMode = ProcessingMode.Local;

            ////Caminho do relatório
            //reportViewer.LocalReport.ReportEmbeddedResource = "SistemaSegsal.Relatorios.rel_propostaComercial.rdlc";

            ////Parâmetros do relatório
            //List<ReportParameter> listaReportParameter = new List<ReportParameter>();

            //listaReportParameter.Add(new ReportParameter("cabecalhoL1", cabecalhoL1));
            //listaReportParameter.Add(new ReportParameter("cabecalhoL2", cabecalhoL2));
            //listaReportParameter.Add(new ReportParameter("cabecalhoL3", cabecalhoL3));
            //listaReportParameter.Add(new ReportParameter("cabecalhoL4", cabecalhoL4));

            //listaReportParameter.Add(new ReportParameter("numeroProposta", numeroProposta));
            //listaReportParameter.Add(new ReportParameter("dataProposta", dataProposta));
            //listaReportParameter.Add(new ReportParameter("titulo", titulo));
            //listaReportParameter.Add(new ReportParameter("descricao", descricao));
            //listaReportParameter.Add(new ReportParameter("observacao", observacao));
            //listaReportParameter.Add(new ReportParameter("condPgto", condPgto));
            //listaReportParameter.Add(new ReportParameter("formaPgto", formaPgto));
            //listaReportParameter.Add(new ReportParameter("dataPropostaExtenso", dataPropostaExtenso));

            //listaReportParameter.Add(new ReportParameter("clienteL1", clienteL1));
            //listaReportParameter.Add(new ReportParameter("clienteL2", clienteL2));

            //reportViewer.LocalReport.SetParameters(listaReportParameter);

            ////Parâmetros do render
            //Warning[] warnings;
            //string[] streamids;
            //string mimeType;
            //string encoding;
            //string extension;

            //byte[] bytePdf = reportViewer.LocalReport.Render("Pdf", null, out mimeType, out encoding, out extension, out streamids, out warnings);

            //FileStream fileStreamPDF = null;

            //string nomeArquivoPdf = Application.StartupPath + @"\Documentos\PropostaComercial\" + numeroProposta + ".pdf";

            //fileStreamPDF = new FileStream(nomeArquivoPdf, FileMode.Create);
            //fileStreamPDF.Write(bytePdf, 0, bytePdf.Length);
            //fileStreamPDF.Close();

            //Process.Start(nomeArquivoPdf);

        }

        static void CriarCelulaServico(PdfPTable tabelaServico, string texto, int alinhamentoHoriz = PdfPCell.ALIGN_LEFT, bool negrito = false, bool italico = false, int tamanhoFonte = 8, int alturaCelula = 20)
        {
            int estilo = iTextSharp.text.Font.NORMAL;
            if(negrito && italico)
            {
                estilo = iTextSharp.text.Font.BOLDITALIC;
            }
            else if(negrito)
            {
                estilo = iTextSharp.text.Font.BOLD;
            }
            else if(italico)
            {
                estilo = iTextSharp.text.Font.ITALIC;
            }

            var fonteCelula = new iTextSharp.text.Font(fonteBase, tamanhoFonte, estilo, BaseColor.BLACK);
            var bgColor = branco;

            if (tabelaServico.Rows.Count % 2 == 1)
            {
                bgColor = cinzaClaro;
            }

            PdfPCell celulaServico = new PdfPCell(new Phrase(texto, new iTextSharp.text.Font(fonteBase, 8, iTextSharp.text.Font.NORMAL, preto)));
            celulaServico.HorizontalAlignment = alinhamentoHoriz;
            celulaServico.VerticalAlignment = PdfPCell.ALIGN_MIDDLE;
            celulaServico.Border = 1;
            celulaServico.BorderWidthBottom = 0.5f;
            celulaServico.FixedHeight = alturaCelula;
            celulaServico.PaddingBottom = 5;
            celulaServico.BackgroundColor = bgColor;
            tabelaServico.AddCell(celulaServico);
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
            string nomeClienteBase = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[4].Text;
            string[] clienteQuebrado = nomeClienteBase.Split('-');

            cliDto.NomeFantasia = clienteQuebrado[0];
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
            dataProposta = proposta[0].DataProposta;
            tituloProposta = proposta[0].Titulo;
            descricaoProposta = proposta[0].Descricao;
            observacaoProposta = proposta[0].Observacao;
            condPgtoProposta = proposta[0].CondicaoPgto;
            formaPgtoProposta = proposta[0].FormaPgto;
            valorTotalProposta = proposta[0].Valor;
            nomeCliente = proposta[0].Cliente;
            nomeBaseCliente = proposta[0].BaseCliente;
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
            listaServicoProposta = serBll.ListaServicoProposta(serDto);


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

        private void CriarOrdemServico(string codigoP)
        {
            dto.Codigo = codigoP;

            List<PropostaComercialDTO> propC = bll.SelecionarPropostaComercial(dto);

            string statusPC = propC[0].Status;
            string codigoPC = propC[0].Codigo;

            if(statusPC == "Aprovada")
            {
                ordBll.CriarNovoOrdemServico(ordDto);

                Int32 id = ordDto.Id;
                string codigoOS = "OS-" + id.ToString("0000#");

                string dataRegistro = DateTime.Now.Date.ToString("yyyy-MM-dd");

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
                ordDto.Status = "Iniciada";

                ordBll.SalvarOrdemServico(ordDto);

                dto.OrdemServico = codigoOS;

                bll.CriarOrdemServicoPropostaComercial(dto);

                MessageBox.Show("Ordem de Serviço Nº " + codigoOS + " Cadastrada com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.ListaPropostaComercial();
            }
            else
            {
                MessageBox.Show("A Proposta Comercial Nº " + codigoPC + " não pode ser convertida em Ordem de Serviço porque não está aprovada!", "Aviso!", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            //this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";
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
            //this.CarregarDadosEmpresa();
        }

        private void lvw_listaPropostaComercial_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaPropostaComercial.SelectedItems.Count > 0)
            {
                this.SelecionarCodigoProposta();
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
            if (this.cmb_status.Text == "SistemaSegsal.DTO.PropostaComercialStatusDTO")
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
            string status = this.cmb_status.Text;

            this.ListaPropostaComercialStatus(status);
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //this.EditarProposta();
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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void lvw_listaPropostaComercial_DoubleClick(object sender, EventArgs e)
        {
            //string codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;


            //this.SelecionarProposta(codigo);
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

        private void btn_ordemServico_Click(object sender, EventArgs e)
        {
            string codigo = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

            this.CriarOrdemServico(codigo);
        }

        private void btn_servico_Click_1(object sender, EventArgs e)
        {
            this.ServicoProposta();
        }

        private void btn_imprimir_Click_1(object sender, EventArgs e)
        {
            string numeroProposta = this.lvw_listaPropostaComercial.SelectedItems[0].SubItems[2].Text;

            this.ImprimirProposta(numeroProposta);
        }
    }
}
