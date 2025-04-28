using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.Relatorios;

namespace SistemaSegsal.Relatorios
{
    public partial class frm_relatorioPropostaComercial : Form
    {
        PropostaComercialDTO dto = new PropostaComercialDTO();
        PropostaComercialBLL bll = new PropostaComercialBLL();

        PropostaComercialServicoDTO serDto = new PropostaComercialServicoDTO();
        PropostaComercialServicoBLL serBll = new PropostaComercialServicoBLL();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

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
        string codigoProposta;
        string dataProposta;
        string titulo;
        string descricao;
        string observacao;
        string condPgto;
        string formaPgto;
        Int32 valorProposta;
        string dataPropostaExtenso;

        //Serviço Proposta


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

            codigoProposta = proposta[0].Codigo;
            dataProposta = proposta[0].DataProposta.ToString("dd/MM/yyyy");
            titulo = proposta[0].Titulo;
            descricao = proposta[0].Descricao;
            observacao = proposta[0].Observacao;
            condPgto = proposta[0].CondicaoPgto;
            formaPgto = proposta[0].FormaPgto;
            valorProposta = proposta[0].Valor;
            string dataPropostaExt = proposta[0].DataProposta.ToString("dd/MMMM/yyyy");
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

        

        


        public frm_relatorioPropostaComercial(string codigobase, string codigoProposta)
        {
            InitializeComponent();

            this.SelecionarDadosEmpresa();
            this.SelecionarDadosCliente(codigobase);
            this.SelecionarDadosProposta(codigoProposta);
            //this.SelecionarDadosServicoProposta(codigoProposta);
        }

        private void frm_relatorioPropostaComercial_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "rel_propostaComercial.rdlc";

            //this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("img_logomarca", logomarca));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cabecalhoL1", cabecalhoL1));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cabecalhoL2", cabecalhoL2));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cabecalhoL3", cabecalhoL3));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("cabecalhoL4", cabecalhoL4));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("numeroProposta", codigoProposta));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataProposta", dataProposta));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("titulo", titulo));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("descricao", descricao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("observacao", observacao));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("condPgto", condPgto));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("formaPgto", formaPgto));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataPropostaExtenso", dataPropostaExtenso));

            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("clienteL1", clienteL1));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("clienteL2", clienteL2));


            this.reportViewer1.RefreshReport();
        }
    }
}
