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

        public void EstadoInicial()
        {
            //Administrativo
            this.btn_empresa.Visible = false;
            this.btn_clientes.Visible = false;
            this.btn_fornecedores.Visible = false;
            this.btn_frota.Visible = false;

            //Recursos Humanos
            this.btn_funcionarios.Visible = false;
            this.btn_tecnicos.Visible = false;
            this.btn_documentacao.Visible = false;
            this.btn_frequencia.Visible = false;

            //Financeiro
            this.btn_propostas.Visible = false;
            this.btn_notasFiscais.Visible = false;
            this.btn_contasReceber.Visible = false;
            this.btn_contasPagar.Visible = false;
            this.btn_livroCaixa.Visible = false;
            this.btn_cotacao.Visible = false;

            //Operacional
            this.btn_chamados.Visible = false;
            this.btn_servicos.Visible = false;
            this.btn_equipamentos.Visible = false;
            this.btn_epi.Visible = false;
            this.btn_ferramentas.Visible = false;

            //Essenciais
            this.btn_calculadora.Visible = false;
            this.btn_word.Visible = false;
            this.btn_excel.Visible = false;
            this.btn_blocoNotas.Visible = false;
        }

        public void Administrativo()
        {
            //Administrativo
            this.btn_empresa.Visible = true;
            this.btn_clientes.Visible = true;
            this.btn_fornecedores.Visible = true;
            this.btn_frota.Visible = true;

            this.btn_empresa.Location = new Point(5, 5);
            this.btn_clientes.Location = new Point(5, 60);
            this.btn_fornecedores.Location = new Point(5, 115);
            this.btn_frota.Location = new Point(5, 170);

            //Recursos Humanos
            this.btn_funcionarios.Visible = false;
            this.btn_tecnicos.Visible = false;
            this.btn_documentacao.Visible = false;
            this.btn_frequencia.Visible = false;

            //Financeiro
            this.btn_propostas.Visible = false;
            this.btn_notasFiscais.Visible = false;
            this.btn_contasReceber.Visible = false;
            this.btn_contasPagar.Visible = false;
            this.btn_livroCaixa.Visible = false;
            this.btn_cotacao.Visible = false;

            //Operacional
            this.btn_chamados.Visible = false;
            this.btn_servicos.Visible = false;
            this.btn_equipamentos.Visible = false;
            this.btn_epi.Visible = false;
            this.btn_ferramentas.Visible = false;

            //Essenciais
            this.btn_calculadora.Visible = false;
            this.btn_word.Visible = false;
            this.btn_excel.Visible = false;
            this.btn_blocoNotas.Visible = false;

        }

        public void RecursosHumanos()
        {
            //Administrativo
            this.btn_empresa.Visible = false;
            this.btn_clientes.Visible = false;
            this.btn_fornecedores.Visible = false;
            this.btn_frota.Visible = false;            

            //Recursos Humanos
            this.btn_funcionarios.Visible = true;
            this.btn_tecnicos.Visible = true;
            this.btn_documentacao.Visible = true;
            this.btn_frequencia.Visible = true;

            this.btn_funcionarios.Location = new Point(5, 5);
            this.btn_tecnicos.Location = new Point(5, 60);
            this.btn_documentacao.Location = new Point(5, 115);
            this.btn_frequencia.Location = new Point(5, 170);

            //Financeiro
            this.btn_propostas.Visible = false;
            this.btn_notasFiscais.Visible = false;
            this.btn_contasReceber.Visible = false;
            this.btn_contasPagar.Visible = false;
            this.btn_livroCaixa.Visible = false;
            this.btn_cotacao.Visible = false;

            //Operacional
            this.btn_chamados.Visible = false;
            this.btn_servicos.Visible = false;
            this.btn_equipamentos.Visible = false;
            this.btn_epi.Visible = false;
            this.btn_ferramentas.Visible = false;

            //Essenciais
            this.btn_calculadora.Visible = false;
            this.btn_word.Visible = false;
            this.btn_excel.Visible = false;
            this.btn_blocoNotas.Visible = false;
        }

        public void Financeiro()
        {
            //Administrativo
            this.btn_empresa.Visible = false;
            this.btn_clientes.Visible = false;
            this.btn_fornecedores.Visible = false;
            this.btn_frota.Visible = false;

            //Recursos Humanos
            this.btn_funcionarios.Visible = false;
            this.btn_tecnicos.Visible = false;
            this.btn_documentacao.Visible = false;
            this.btn_frequencia.Visible = false;

            //Financeiro
            this.btn_propostas.Visible = true;
            this.btn_notasFiscais.Visible = true;
            this.btn_contasReceber.Visible = true;
            this.btn_contasPagar.Visible = true;
            this.btn_livroCaixa.Visible = true;
            this.btn_cotacao.Visible = true;

            this.btn_propostas.Location = new Point(5, 5);
            this.btn_notasFiscais.Location = new Point(5, 60);
            this.btn_contasReceber.Location = new Point(5, 115);
            this.btn_contasPagar.Location = new Point(5, 170);
            this.btn_livroCaixa.Location = new Point(5, 225);
            this.btn_cotacao.Location = new Point(5, 280);

            //Operacional
            this.btn_chamados.Visible = false;
            this.btn_servicos.Visible = false;
            this.btn_equipamentos.Visible = false;
            this.btn_epi.Visible = false;
            this.btn_ferramentas.Visible = false;

            //Essenciais
            this.btn_calculadora.Visible = false;
            this.btn_word.Visible = false;
            this.btn_excel.Visible = false;
            this.btn_blocoNotas.Visible = false;
        }

        public void Operacional()
        {
            //Administrativo
            this.btn_empresa.Visible = false;
            this.btn_clientes.Visible = false;
            this.btn_fornecedores.Visible = false;
            this.btn_frota.Visible = false;

            //Recursos Humanos
            this.btn_funcionarios.Visible = false;
            this.btn_tecnicos.Visible = false;
            this.btn_documentacao.Visible = false;
            this.btn_frequencia.Visible = false;

            //Financeiro
            this.btn_propostas.Visible = false;
            this.btn_notasFiscais.Visible = false;
            this.btn_contasReceber.Visible = false;
            this.btn_contasPagar.Visible = false;
            this.btn_livroCaixa.Visible = false;
            this.btn_cotacao.Visible = false;            

            //Operacional
            this.btn_chamados.Visible = true;
            this.btn_servicos.Visible = true;
            this.btn_equipamentos.Visible = true;
            this.btn_epi.Visible = true;
            this.btn_ferramentas.Visible = true;

            this.btn_chamados.Location = new Point(5, 5);
            this.btn_servicos.Location = new Point(5, 60);
            this.btn_equipamentos.Location = new Point(5, 115);
            this.btn_epi.Location = new Point(5, 170);
            this.btn_ferramentas.Location = new Point(5, 225);

            //Essenciais
            this.btn_calculadora.Visible = false;
            this.btn_word.Visible = false;
            this.btn_excel.Visible = false;
            this.btn_blocoNotas.Visible = false;
        }

        public void Essenciais()
        {
            //Administrativo
            this.btn_empresa.Visible = false;
            this.btn_clientes.Visible = false;
            this.btn_fornecedores.Visible = false;
            this.btn_frota.Visible = false;

            //Recursos Humanos
            this.btn_funcionarios.Visible = false;
            this.btn_tecnicos.Visible = false;
            this.btn_documentacao.Visible = false;
            this.btn_frequencia.Visible = false;

            //Financeiro
            this.btn_propostas.Visible = false;
            this.btn_notasFiscais.Visible = false;
            this.btn_contasReceber.Visible = false;
            this.btn_contasPagar.Visible = false;
            this.btn_livroCaixa.Visible = false;
            this.btn_cotacao.Visible = false;

            //Operacional
            this.btn_chamados.Visible = false;
            this.btn_servicos.Visible = false;
            this.btn_equipamentos.Visible = false;
            this.btn_epi.Visible = false;
            this.btn_ferramentas.Visible = false;            

            //Essenciais
            this.btn_calculadora.Visible = true;
            this.btn_word.Visible = true;
            this.btn_excel.Visible = true;
            this.btn_blocoNotas.Visible = true;

            this.btn_calculadora.Location = new Point(5, 5);
            this.btn_word.Location = new Point(5, 60);
            this.btn_excel.Location = new Point(5, 115);
            this.btn_blocoNotas.Location = new Point(5, 170);
        }

        public void Sobre()
        {
            //Administrativo
            this.btn_empresa.Visible = false;
            this.btn_clientes.Visible = false;
            this.btn_fornecedores.Visible = false;
            this.btn_frota.Visible = false;

            //Recursos Humanos
            this.btn_funcionarios.Visible = false;
            this.btn_tecnicos.Visible = false;
            this.btn_documentacao.Visible = false;
            this.btn_frequencia.Visible = false;

            //Financeiro
            this.btn_propostas.Visible = false;
            this.btn_notasFiscais.Visible = false;
            this.btn_contasReceber.Visible = false;
            this.btn_contasPagar.Visible = false;
            this.btn_livroCaixa.Visible = false;
            this.btn_cotacao.Visible = false;

            //Operacional
            this.btn_chamados.Visible = false;
            this.btn_servicos.Visible = false;
            this.btn_equipamentos.Visible = false;
            this.btn_epi.Visible = false;
            this.btn_ferramentas.Visible = false;

            //Essenciais
            this.btn_calculadora.Visible = false;
            this.btn_word.Visible = false;
            this.btn_excel.Visible = false;
            this.btn_blocoNotas.Visible = false;
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





        public frm_principal()
        {
            InitializeComponent();
        }

        

        private void frm_principal_Load(object sender, EventArgs e)
        {
            this.CarregarDadosEmpresa();
            this.EstadoInicial();
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
            this.Operacional();
        }

        private void btn_administrativo_Click(object sender, EventArgs e)
        {
            this.Administrativo();
        }

        private void btn_recursosHumanos_Click(object sender, EventArgs e)
        {
            this.RecursosHumanos();
        }

        private void btn_financeiro_Click(object sender, EventArgs e)
        {
            this.Financeiro();
        }

        private void btn_essenciais_Click(object sender, EventArgs e)
        {
            this.Essenciais();
        }

        private void btn_sobre_Click(object sender, EventArgs e)
        {
            this.Sobre();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair do Sistema?", "Sair do Sistema!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btn_calculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"calc.exe");
        }

        private void btn_word_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"winword.exe");
        }

        private void btn_excel_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"excel.exe");
        }

        private void btn_blocoNotas_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"notepad.exe");
        }

        private void btn_chamados_Click(object sender, EventArgs e)
        {
            frm_listaChamado cham = new frm_listaChamado();
            cham.Visible = true;

            this.Visible = false;
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
            frm_listaPropostaComercial pc = new frm_listaPropostaComercial();
            pc.Visible = true;

            this.Visible = false;
        }

        private void btn_notasFiscais_Click(object sender, EventArgs e)
        {
            frm_listaNotaFiscal form = new frm_listaNotaFiscal();
            form.Visible = true;

            this.Visible = false;
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
            frm_empresa emp = new frm_empresa();
            emp.Visible = true;

            this.Visible = false;
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            frm_listaCliente cli = new frm_listaCliente();
            cli.Visible = true;

            this.Visible = false;
        }

        private void btn_fornecedores_Click(object sender, EventArgs e)
        {
            frm_listaFornecedor forn = new frm_listaFornecedor();
            forn.Visible = true;

            this.Visible = false;
        }

        private void btn_frota_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var arquivoXmlNotaFiscal = Application.StartupPath + @"\Documentos\NotaFiscal\XMLNotasFiscais\nota_90.xml";

            using (XmlReader xmlNota = XmlReader.Create(arquivoXmlNotaFiscal))
            {
                while (xmlNota.Read())
                {
                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "CodigoVerificacao")
                        this.textBox2.Text = xmlNota.ReadElementString();
                }
            }

        }
    }
}
