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
using MySql.Data.MySqlClient;
using SistemaSegsal.DAO;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using SistemaSegsal.Views;

namespace SistemaSegsal.View
{
    public partial class frm_principal : Form
    {
        Conexao conexao = new Conexao();
        MySqlCommand cmd = new MySqlCommand();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        Int32 posicao1 = 5;
        Int32 posicao2 = 60;
        Int32 posicao3 = 115;
        Int32 posicao4 = 170;
        Int32 posicao5 = 225;
        Int32 posicao6 = 280;
        Int32 posicao7 = 335;
        






        public void CarregarDadosEmpresa()
        {
            List<EmpresaDTO> emp = empBll.SelecionarEmpresa();

            string logoEmpresa = emp[0].Logo;
            string nomeFantasia = emp[0].NomeFantasia;

            //this.img_logoEmpresa.Image = Image.FromFile(Application.StartupPath + logoEmpresa);
            //this.img_logoEmpresa.SizeMode = PictureBoxSizeMode.StretchImage;

            this.Text = "Sistema de Gestão - " + nomeFantasia + " - v 1.0";
        }





        public frm_principal()
        {
            InitializeComponent();
        }

        

        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.CarregarDadosEmpresa();
        }

        private void mnu_propostaComercial_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void notaFiscalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void chamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //this.Operacional();
        }

        private void btn_administrativo_Click(object sender, EventArgs e)
        {
            //this.Administrativo();
        }

        private void btn_recursosHumanos_Click(object sender, EventArgs e)
        {
            //this.RecursosHumanos();
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            //this.Financeiro();
        }

        private void btn_essenciais_Click(object sender, EventArgs e)
        {
            //this.Essenciais();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            //this.Sobre();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("Deseja realmente Sair do Sistema?", "Sair do Sistema!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (result == DialogResult.Yes)
            //{
            //    this.Close();
            //}
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_word_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_blocoNotas_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_chamados_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_servicos_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_equipamentos_Click(object sender, EventArgs e)
        {

        }

        private void btn_epi_Click(object sender, EventArgs e)
        {

        }

        private void btn_ferramentas_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_propostas_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_notasFiscais_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_contasReceber_Click(object sender, EventArgs e)
        {

        }

        private void btn_contasPagar_Click(object sender, EventArgs e)
        {

        }

        private void btn_livroCaixa_Click(object sender, EventArgs e)
        {

        }

        private void btn_cotacao_Click(object sender, EventArgs e)
        {

        }

        private void btn_funcionarios_Click(object sender, EventArgs e)
        {

        }

        private void btn_tecnicos_Click(object sender, EventArgs e)
        {

        }

        private void btn_documentacao_Click(object sender, EventArgs e)
        {

        }

        private void btn_frequencia_Click(object sender, EventArgs e)
        {

        }

        private void btn_empresa_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_fornecedores_Click(object sender, EventArgs e)
        {

        }

        private void btn_frota_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void ordensDeServiçosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listaOrdemServico os = new frm_listaOrdemServico();
            os.Visible = true;

            this.Visible = false;
        }

        private void mnu_empresa_Click(object sender, EventArgs e)
        {
            frm_empresa emp = new frm_empresa();
            emp.Visible = true;

            this.Visible = false;
        }

        private void mnu_fornecedor_Click(object sender, EventArgs e)
        {
            frm_listaFornecedor forn = new frm_listaFornecedor();
            forn.Visible = true;

            this.Visible = false;
        }

        private void mnu_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair do Sistema?", "Sair do Sistema!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void mnu_cliente_Click(object sender, EventArgs e)
        {
            frm_listaCliente cli = new frm_listaCliente();
            cli.Visible = true;

            this.Visible = false;
        }

        private void mnu_notaFiscal_Click(object sender, EventArgs e)
        {
            frm_listaNotaFiscal form = new frm_listaNotaFiscal();
            form.Visible = true;

            this.Visible = false;
        }

        private void mnu_proposta_Click(object sender, EventArgs e)
        {
            frm_listaPropostaComercial pc = new frm_listaPropostaComercial();
            pc.Visible = true;

            this.Visible = false;
        }

        private void mnu_ferramenta_Click(object sender, EventArgs e)
        {
            frm_listaPropostaComercial pc = new frm_listaPropostaComercial();
            pc.Visible = true;

            this.Visible = false;
        }

        private void mnu_chamado_Click(object sender, EventArgs e)
        {
            frm_listaChamado cham = new frm_listaChamado();
            cham.Visible = true;

            this.Visible = false;
        }

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
    }
}
