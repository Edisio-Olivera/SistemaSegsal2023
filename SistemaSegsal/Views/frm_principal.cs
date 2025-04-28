using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Data.OleDb;
using SistemaSegsal.DAO;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.Views;
using System.Threading;

namespace SistemaSegsal.View
{
    public partial class frm_principal : Form
    {
        Conexao conexao = new Conexao();
        OleDbCommand cmd = new OleDbCommand();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();
    
        Thread t1;

        public void CarregarDadosEmpresa()
        {
            List<EmpresaDTO> emp = empBll.SelecionarEmpresa();

            string logoEmpresa = emp[0].Logo;
            string nomeFantasia = emp[0].NomeFantasia;
            this.Text = "Sistema de Gestão - " + nomeFantasia + " - v 1.0";
        }

        //Administrativo
        private void abrirFormEmpresa(object obj)
        {
            Application.Run(new frm_empresa());
        }

        private void mnu_empresa_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormEmpresa);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormCliente(object obj)
        {
            Application.Run(new frm_listaCliente());
        }

        private void mnu_cliente_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormCliente);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormFornecedor(object obj)
        {
            Application.Run(new frm_listaFornecedor());
        }

        private void mnu_fornecedor_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormFornecedor);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormEquipamento(object obj)
        {
            Application.Run(new frm_listaEquipamento());
        }

        private void mnu_equipamento_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormEquipamento);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormEpi(object obj)
        {
            Application.Run(new frm_listaEpi());
        }

        private void mnu_epi_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormEpi);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormFerramenta(object obj)
        {
            Application.Run(new frm_listaFerramenta());
        }

        private void mnu_ferramenta_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormFerramenta);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormFrota(object obj)
        {
            Application.Run(new frm_listaFrota());
        }

        private void mnu_frota_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormFrota);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Recursos Humanos
        private void abrirFormFuncionario(object obj)
        {
            Application.Run(new frm_listaFuncionarios());
        }

        private void mnu_funcionario_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormFuncionario);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormTecnico(object obj)
        {
            Application.Run(new frm_listaTecnicos());
        }

        private void mnu_tecnico_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormTecnico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormDocumentacao(object obj)
        {
            Application.Run(new frm_listaDocumentacao());
        }

        private void mnu_documentacao_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormDocumentacao);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }        

        //Financeiro
        private void abrirFormProposta(object obj)
        {
            Application.Run(new frm_listaPropostaComercial());
        }

        private void mnu_proposta_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormProposta);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormNotaFiscal(object obj)
        {
            Application.Run(new frm_listaNotaFiscal());
        }

        private void mnu_notaFiscal_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormNotaFiscal);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormContasPagar(object obj)
        {
            Application.Run(new frm_listaContasPagar());
        }

        private void mnu_pagar_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormContasPagar);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormContasReceber(object obj)
        {
            Application.Run(new frm_listaContasReceber());
        }

        private void mnu_receber_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormContasReceber);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        //Operacional
        private void abrirFormChamados(object obj)
        {
            Application.Run(new frm_listaChamado());
        }

        private void mnu_chamado_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormChamados);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormOrdemServico(object obj)
        {
            Application.Run(new frm_listaOrdemServico());
        }

        private void ordensDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormOrdemServico);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void abrirFormApr(object obj)
        {
            Application.Run(new frm_listaApr());
        }

        //Essenciais
        private void mnu_blocoNota_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"notepad.exe");
        }

        private void mnu_excel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"excel.exe");
        }

        private void mnu_word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"winword.exe");
        }

        private void mnu_calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"calc.exe");
        }

        //Sobre



        public frm_principal()
        {
            InitializeComponent();
        }        

        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.CarregarDadosEmpresa();            
        }   
        
        private void mnu_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair do Sistema?", "Sair do Sistema!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnu_apr_Click(object sender, EventArgs e)
        {
            this.Close();
            t1 = new Thread(abrirFormApr);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
