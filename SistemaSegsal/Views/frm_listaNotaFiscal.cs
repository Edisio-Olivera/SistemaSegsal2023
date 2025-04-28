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
using SistemaSegsal.View;
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Threading;
using static iText.StyledXmlParser.Jsoup.Select.Evaluator;

namespace SistemaSegsal.Views
{
    public partial class frm_listaNotaFiscal : Form
    {

        NotaFiscalDTO ntaDto = new NotaFiscalDTO();
        NotaFiscalBLL ntaBll = new NotaFiscalBLL();

        NotaFiscalTipoDTO tipDto = new NotaFiscalTipoDTO();
        NotaFiscalTipoBLL tipBll = new NotaFiscalTipoBLL();

        NotaFiscalStatusDTO staDto = new NotaFiscalStatusDTO();
        NotaFiscalStatusBLL staBll = new NotaFiscalStatusBLL();

        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBll = new EmpresaBLL();

        ClienteDTO cliDto = new ClienteDTO();
        ClienteBLL cliBll = new ClienteBLL();

        BaseClienteDTO basDto = new BaseClienteDTO();
        BaseClienteBLL basBll = new BaseClienteBLL();

        Thread t1;

        Int32 id;
        string codigo;

        public static frm_listaNotaFiscal notaFiscalInstancia;


        string[] meses = { "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };
        Int32 valorTotalNotasFiscaisMesAno;
        Int32 valorTotalNotasFiscaisAno;
        Int32 qtdNotasFiscaisMesAno;
        Int32 qtdNotasFiscaisAno;
        Int32 anoAtual = DateTime.Now.Year;

        private void abrirFormAddNotaFiscalNovo(object obj)
        {
            Application.Run(new frm_addNotaFiscal(id, codigo));
        }

        private void EstadoInicial()
        {
            //Botões de Registros
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_sair.Visible = true;

            //Botôes de Registro Selecionado
            this.btn_relatorioAnual.Visible = false;
            this.btn_receber.Visible = false;
            this.btn_cancelarRegistro.Visible = false;

            this.btn_sair.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);


            //this.btn_novo.Visible = true;
            //this.btn_cancelar.Visible = false;
            //this.btn_editar.Visible = false;
            //this.btn_deletar.Visible = false;
            //this.btn_receber.Visible = false;
            //this.btn_sair.Visible = true;

            //this.lvw_listaNotaFiscal.Enabled = true;

            //this.btn_sair.Location = new Point(1277, 5);
            //this.btn_novo.Location = new Point(1211, 5);

            this.lbl_mes01.Text = meses[0];
            this.lbl_mes02.Text = meses[1];
            this.lbl_mes03.Text = meses[2];
            this.lbl_ano.Text = anoAtual.ToString();

            ContarNotasFiscaisMesAno(1, anoAtual);
            this.lbl_qtdNotasMes1.Text = qtdNotasFiscaisMesAno.ToString();

            ContarNotasFiscaisMesAno(2, anoAtual);
            this.lbl_qtdNotasMes2.Text = qtdNotasFiscaisMesAno.ToString();

            ContarNotasFiscaisMesAno(3, anoAtual);
            this.lbl_qtdNotasMes3.Text = qtdNotasFiscaisMesAno.ToString();

            ContarNotasFiscaisAno(anoAtual);
            this.lbl_qtdNotasAno.Text = qtdNotasFiscaisAno.ToString();

            //SomarNotasFiscaisMesAno(1, anoAtual);
            //this.lbl_qtdNotasMes1.Text = qtdNotasFiscaisMesAno.ToString();

            //SomarNotasFiscaisMesAno(2, anoAtual);
            //this.lbl_qtdNotasMes2.Text = qtdNotasFiscaisMesAno.ToString();

            //SomarNotasFiscaisMesAno(3, anoAtual);
            //this.lbl_qtdNotasMes3.Text = qtdNotasFiscaisMesAno.ToString();

            //SomarNotasFiscaisAno(anoAtual);
            //this.lbl_qtdNotasAno.Text = qtdNotasFiscaisAno.ToString();

        }

        private void NovoNotaFiscal()
        {
            ntaBll.CriarNovoNotaFiscal(ntaDto);

            id = ntaDto.Id + 1;
            codigo = "NF-" + id.ToString("0000#");

            this.Close();
            t1 = new Thread(abrirFormAddNotaFiscalNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void EditarNotaFiscal()
        {

        }

        private void AtualizarNotaFiscal()
        {

        }

        private void ExcluirNotaFiscal()
        {
            ntaDto.Codigo = this.lvw_listaNotaFiscal.SelectedItems[0].SubItems[2].Text;

            ntaBll.ExcluirNotaFiscal(ntaDto);

            MessageBox.Show("Nota Fiscal Excluída com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();

            this.ListarNotasFiscais();
        }

        private void ReceberNotaFiscal()
        {
            ntaDto.Codigo = this.lvw_listaNotaFiscal.SelectedItems[0].SubItems[2].Text;
            ntaDto.Status = "Recebida";

            ntaBll.ReceberNotaFiscal(ntaDto);

            MessageBox.Show("Nota Fiscal Recebida com sucesso!", "Receber Nota Fiscal!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();

            this.ListarNotasFiscais();
        }

        private void PopularComboboxStatusNotaFiscal()
        {
            List<NotaFiscalStatusDTO> statusNf = staBll.PopularComboboxNotaFiscalStatus();

            this.cmb_status.DataSource = statusNf;
            this.cmb_status.DisplayMember = "status";
            this.cmb_status.Text = "";
        }

        private void PopularComboboxAnoNotaFiscal()
        {
            List<EmpresaDTO> emp = empBll.SelecionarEmpresa();

            DateTime anoData = emp[0].DataAbertura;
            Int32 anoAbertura = anoData.Year;
            Int32 anoItem = anoAbertura;
            Int32 anoAtual = DateTime.Now.Year;

            for (Int32 i = anoItem; i <= anoAtual; i++)
            {
                this.cmb_ano.Items.Add(i);
            }
        }

        public void ListarNotasFiscais()
        {
            string[] item = new string[9];
            int prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaNotaFiscal = ntaBll.ListarNotasFiscais();

            this.lvw_listaNotaFiscal.Items.Clear();

            foreach (NotaFiscalDTO nta in listaNotaFiscal)
            {
                item[0] = nta.Id.ToString();
                item[1] = prox.ToString();
                item[2] = nta.Codigo;
                item[3] = nta.DataEmissao.ToString("dd/MM/yyyy");
                item[4] = nta.Servico;
                item[5] = nta.DataRecebimento.ToString("dd/MM/yyyy");
                item[6] = nta.Valor.ToString("R$ #,##0.00");

                DateTime dataVencer = nta.DataRecebimento;
                Int32 dias = ((DateTime.Now.Subtract(dataVencer)).Days * -1) + 1;

                if (dias < 0 || nta.Status == "Recebida")
                {
                    item[7] = "-";
                }
                else
                {
                    item[7] = dias.ToString();
                }

                item[8] = nta.Status;

                lvw_listaNotaFiscal.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + nta.Valor;
            }
        }

        private void ListarNotasFiscaisAno(Int32 anoNf)
        {
            ntaDto.Ano = anoNf;

            string[] item = new string[9];
            int prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaNotaFiscal = ntaBll.ListarNotasFiscaisAno(ntaDto);

            this.lvw_listaNotaFiscal.Items.Clear();

            foreach (NotaFiscalDTO nta in listaNotaFiscal)
            {
                item[0] = nta.Id.ToString();
                item[1] = prox.ToString();
                item[2] = nta.Codigo;
                item[3] = nta.DataEmissao.ToString("dd/MM/yyyy");
                item[4] = nta.Servico;
                item[5] = nta.DataRecebimento.ToString("dd/MM/yyyy");
                item[6] = nta.Valor.ToString("R$ #,##0.00");

                DateTime dataVencer = nta.DataRecebimento;
                Int32 dias = ((DateTime.Now.Subtract(dataVencer)).Days * -1) + 1;

                if (dias < 0 || nta.Status == "Recebida")
                {
                    item[7] = "-";
                }
                else
                {
                    item[7] = dias.ToString();
                }

                item[8] = nta.Status;

                lvw_listaNotaFiscal.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + nta.Valor;
            }
        }

        private void ListarNotasFiscaisStatus(string statusNf)
        {
            ntaDto.Status = statusNf;

            string[] item = new string[11];
            int prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaNotaFiscal = ntaBll.ListarNotasFiscaisStatus(ntaDto);

            this.lvw_listaNotaFiscal.Items.Clear();

            foreach (NotaFiscalDTO nta in listaNotaFiscal)
            {
                item[0] = nta.Id.ToString();
                item[1] = prox.ToString();
                item[2] = nta.Codigo;
                item[3] = nta.DataEmissao.ToString("dd/MM/yyyy");
                item[4] = nta.Servico;
                item[5] = nta.DataRecebimento.ToString("dd/MM/yyyy");
                item[6] = nta.Valor.ToString("R$ #,##0.00");

                DateTime dataVencer = nta.DataRecebimento;
                Int32 dias = ((DateTime.Now.Subtract(dataVencer)).Days * -1) + 1;

                if (dias < 0)
                {
                    item[7] = "-";
                }
                else
                {
                    item[7] = dias.ToString();
                }

                lvw_listaNotaFiscal.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + nta.Valor;
            }
        }

        private void ListarNotasFiscaisAnoStatus(string statusNf, Int32 anoNf)
        {
            ntaDto.Status = statusNf;
            ntaDto.Ano = anoNf;

            string[] item = new string[11];
            int prox = 1;
            Int32 qtd = 0;
            Int32 valor = 0;

            var listaNotaFiscal = ntaBll.ListarNotasFiscaisAnoStatus(ntaDto);

            this.lvw_listaNotaFiscal.Items.Clear();

            foreach (NotaFiscalDTO nta in listaNotaFiscal)
            {
                item[0] = nta.Id.ToString();
                item[1] = prox.ToString();
                item[2] = nta.Codigo;
                item[3] = nta.DataEmissao.ToString();
                item[4] = nta.Servico;
                item[5] = nta.DataRecebimento.ToString();
                item[6] = nta.Valor.ToString("R$ #,##0.00");

                DateTime dataVencer = nta.DataRecebimento;
                Int32 dias = ((DateTime.Now.Subtract(dataVencer)).Days * -1) + 1;

                if (dias < 0)
                {
                    item[7] = "-";
                }
                else
                {
                    item[7] = dias.ToString();
                }

                lvw_listaNotaFiscal.Items.Add(new ListViewItem(item));
                prox++;
                qtd++;
                valor = valor + nta.Valor;
            }
        }

        public void LerXmlNotaFiscal()
        {
            Int32 id;
            string codigo;
            DateTime dataEmissao = DateTime.Now;
            DateTime dataReceber = DateTime.Now;
            string tipoNotaFiscal = "Nota de Serviço";
            Int32 diasReceber = 30;
            string cliente;
            string baseCliente;
            string cnpj;
            string codigoVerificacao = "";
            string competencia = "";
            string numeroPedido = "";
            string descricao = "";
            Int32 valor = 0;
            string tag = "";

            ntaBll.CriarNovoNotaFiscal(ntaDto);

            Int32 qtdNF = ntaBll.SelecionarUltimoIdNotaFiscal() + 1;

            id = qtdNF;
            codigo = "NF-" + id.ToString("0000#");

            var arquivoXmlNotaFiscal = Application.StartupPath + @"\Documentos\NotaFiscal\XMLNotasFiscais\nota_" + qtdNF + ".xml";

            using (XmlReader xmlNota = XmlReader.Create(arquivoXmlNotaFiscal))
            {
                //CNPJ
                while (xmlNota.Read())
                {
                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "TomadorServico")
                        tag = "Tomador";
                    else if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "OrgaoGerador")
                        tag = "Prestador";

                    if (tag == "Tomador" && xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "Cnpj")
                    {
                        basDto.Cnpj = xmlNota.ReadElementString();
                        cnpj = basDto.Cnpj;
                    }
                }
            }

            using (XmlReader xmlNota = XmlReader.Create(arquivoXmlNotaFiscal))
            {
                while (xmlNota.Read())
                {
                    //Data Emissão e Data de Recebimento
                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "DataEmissao")
                    {
                        string primeiraData = xmlNota.ReadElementString().Substring(0, 10);
                        string[] dataQuebrada = primeiraData.Split('-');
                        string dia = dataQuebrada[2];
                        string mes = dataQuebrada[1];
                        string ano = dataQuebrada[0];
                        string dataEmissaoOrganizada = dia + "/" + mes + "/" + ano;
                        dataEmissao = DateTime.Parse(dataEmissaoOrganizada);
                        dataReceber = dataEmissao.AddDays(diasReceber);
                    }


                    //Competência
                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "Competencia")
                    {
                        string primeiraData = xmlNota.ReadElementString().Substring(0, 7);
                        string[] dataQuebrada = primeiraData.Split('-');
                        string mes = dataQuebrada[1];
                        string ano = dataQuebrada[0];
                        competencia = mes + "/" + ano;
                    }

                    //Código de Verificação
                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "CodigoVerificacao")
                        codigoVerificacao = xmlNota.ReadElementString();

                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "Discriminacao")
                    {
                        string[] discriminacao = xmlNota.ReadElementString().Split(' ');

                        //Número do Pedido
                        numeroPedido = discriminacao[2].Substring(0, 10);

                        //Descrição do Serviço
                        descricao = discriminacao[3];
                    }

                    //Valor
                    if (xmlNota.NodeType == XmlNodeType.Element && xmlNota.Name == "ValorServicos")
                        valor = Int32.Parse(xmlNota.ReadElementString());
                }
            }

            List<BaseClienteDTO> bc = basBll.SelecionarBaseClienteCnpj(basDto);

            //Cliente
            cliente = bc[0].Cliente;

            //Base Cliente
            baseCliente = bc[0].NomeBase;

            frm_addNotaFiscal nota = new frm_addNotaFiscal(id, codigo, dataEmissao, tipoNotaFiscal, cliente, baseCliente, codigoVerificacao, competencia, numeroPedido, diasReceber, dataReceber, descricao, valor);

            nota.Visible = true;
        }

        private void MesPorExtendo(Int32 mes)
        {

        }

        private Int32 SomarNotasFiscaisMesAno(Int32 mes, Int32 ano)
        {
            ntaDto.Mes = mes;
            ntaDto.Ano = ano;

            valorTotalNotasFiscaisMesAno = ntaBll.SomarNotasFiscaisMesAno(ntaDto);

            return valorTotalNotasFiscaisMesAno;
        }

        private Int32 SomarNotasFiscaisAno(Int32 ano)
        {
            ntaDto.Ano = ano;

            valorTotalNotasFiscaisAno = ntaBll.SomarNotasFiscaisAno(ntaDto);

            return valorTotalNotasFiscaisAno;
        }

        private Int32 ContarNotasFiscaisMesAno(Int32 mes, Int32 ano)
        {
            ntaDto.Mes = mes;
            ntaDto.Ano = ano;

            qtdNotasFiscaisMesAno = ntaBll.ContarNotasFiscaisMesAno(ntaDto);

            return qtdNotasFiscaisMesAno;
        }

        private Int32 ContarNotasFiscaisAno(Int32 ano)
        {
            ntaDto.Ano = ano;

            qtdNotasFiscaisAno = ntaBll.ContarNotasFiscaisAno(ntaDto);

            return qtdNotasFiscaisAno;
        }

        private void Faturamento()
        {









        }

        private void AtualizarComboboxClienteFormProposta()
        {
            //frm_listaNotaFiscal.notaFiscalInstancia.ListarNotasFiscais();
        }

        public frm_listaNotaFiscal()
        {
            InitializeComponent();

            notaFiscalInstancia = this;
        }       

        private void frm_listaNotaFiscal_Load(object sender, EventArgs e)
        {
            //Designer do form
            

            this.EstadoInicial();

            //Designer do listview
            this.lvw_listaNotaFiscal.BackColor = Color.FromArgb(255, 255, 192);

            //1063

            this.lvw_listaNotaFiscal.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaNotaFiscal.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaNotaFiscal.Columns.Add("Código", 80).TextAlign = HorizontalAlignment.Center;       
            this.lvw_listaNotaFiscal.Columns.Add("Data Emissão", 90).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaNotaFiscal.Columns.Add("Serviço", 200).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaNotaFiscal.Columns.Add("Data Receb.", 90).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaNotaFiscal.Columns.Add("Valor", 100).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaNotaFiscal.Columns.Add("Dias a Receber",100).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaNotaFiscal.Columns.Add("Status", 100).TextAlign = HorizontalAlignment.Center;

            Int32 anoNf = DateTime.Now.Year;
            string statusNf = "A Receber";

            this.ListarNotasFiscaisAno(anoNf);
            this.PopularComboboxStatusNotaFiscal();
            this.PopularComboboxAnoNotaFiscal();
            //this.Faturamento();
            //this.GraficoFaturamento();
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            Int32 qtdNF = ntaBll.SelecionarUltimoIdNotaFiscal() + 1;

            var arquivoXmlNotaFiscal = Application.StartupPath + @"\Documentos\NotaFiscal\XMLNotasFiscais\nota_" + qtdNF + ".xml";

            if (File.Exists(arquivoXmlNotaFiscal))
            {
                this.LerXmlNotaFiscal();
            }
            else
            {
                this.NovoNotaFiscal();
            }            
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            if (this.cmb_status.Text != "" && this.cmb_ano.Text == "")
            {
                string statusNf = this.cmb_status.Text; ;

                this.ListarNotasFiscaisStatus(statusNf);
            }
            else if (this.cmb_status.Text == "" && this.cmb_ano.Text != "")
            {
                Int32 anoNf = Int32.Parse(this.cmb_ano.Text);

                this.ListarNotasFiscaisAno(anoNf);
            }
            else if (this.cmb_status.Text != "" && this.cmb_ano.Text != "")
            {
                string statusNf = this.cmb_status.Text; ;
                Int32 anoNf = Int32.Parse(this.cmb_ano.Text);

                this.ListarNotasFiscaisAnoStatus(statusNf, anoNf);
            }
            else
            {
                this.ListarNotasFiscais();
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarNotaFiscal();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            this.ExcluirNotaFiscal();
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Cancelar esse registro?", "Cancelar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.EstadoInicial();
            }
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarNotaFiscal();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            this.ReceberNotaFiscal();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_principal pri = new frm_principal();
                pri.Visible = true;

                this.Close();
            }
        }

        private void lvw_listaNotaFiscal_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(this.lvw_listaNotaFiscal.SelectedItems.Count > 0)
            {
                this.btn_novo.Visible = false;
                this.btn_cancelar.Visible = true;
                this.btn_editar.Visible = true;
                this.btn_deletar.Visible = true;
                this.btn_receber.Visible = true;
                this.btn_sair.Visible = false;

                this.btn_receber.Location = new Point(1277, 66);
                this.btn_deletar.Location = new Point(1211, 66);
                this.btn_editar.Location = new Point(1145, 66);
                this.btn_cancelar.Location = new Point(1079, 66);

                
            }
        }

        private void cmb_cliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_dataEmissao_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_lerXml_Click(object sender, EventArgs e)
        {
            this.LerXmlNotaFiscal();
        }

        private void cmb_cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvw_listaNotaFiscal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btn_proximo_Click(object sender, EventArgs e)
        {
            string mes1 = this.lbl_mes01.Text;
            string mes2 = this.lbl_mes02.Text;
            string mes3 = this.lbl_mes03.Text;
            Int32 x = 0;

            switch (mes1)
            {
                case "Janeiro":
                    x = 0;
                break;
                case "Fevereiro":
                    x = 1;
                break;
                case "Março":
                    x = 2;
                break;
                case "Abril":
                    x = 3;
                break;
                case "Maio":
                    x = 4;
                break;
                case "Junho":
                    x = 5;
                break;
                case "Julho":
                    x = 6;
                break;
                case "Agosto":
                    x = 7;
                break;
                case "Setembro":
                    x = 8;
                break;
                case "Outubro":
                    x = 9;
                break;
            }

            if(mes3 == "Dezembro")
            {
                return;
            }
            else
            {
                x++;
                this.lbl_mes01.Text = meses[x];
                qtdNotasFiscaisMesAno = ContarNotasFiscaisMesAno(x + 1, anoAtual);
                this.lbl_qtdNotasMes1.Text = qtdNotasFiscaisMesAno.ToString();
                x++;
                this.lbl_mes02.Text = meses[x];
                qtdNotasFiscaisMesAno = ContarNotasFiscaisMesAno(x + 1, anoAtual);
                this.lbl_qtdNotasMes2.Text = qtdNotasFiscaisMesAno.ToString();
                x++;
                this.lbl_mes03.Text = meses[x];
                qtdNotasFiscaisMesAno = ContarNotasFiscaisMesAno(x + 1, anoAtual);
                this.lbl_qtdNotasMes3.Text = qtdNotasFiscaisMesAno.ToString();
            }

        }

        private void btn_anterior_Click(object sender, EventArgs e)
        {
            string mes1 = this.lbl_mes01.Text;
            string mes2 = this.lbl_mes02.Text;
            string mes3 = this.lbl_mes03.Text;
            Int32 x = 0;

            switch (mes3)
            {
                case "Março":
                    x = 2;
                break;
                case "Abril":
                    x = 3;
                break;
                case "Maio":
                    x = 4;
                break;
                case "Junho":
                    x = 5;
                break;
                case "Julho":
                    x = 6;
                break;
                case "Agosto":
                    x = 7;
                break;
                case "Setembro":
                    x = 8;
                break;
                case "Outubro":
                    x = 9;
                break;
                case "Novembro":
                    x = 10;
                break;
                case "Dezembro":
                    x = 11;
                break;
            }

            if (mes1 == "Janeiro")
            {
                return;
            }
            else
            {
                x--;
                this.lbl_mes03.Text = meses[x];
                qtdNotasFiscaisMesAno = ContarNotasFiscaisMesAno(x + 1, anoAtual);
                this.lbl_qtdNotasMes3.Text = qtdNotasFiscaisMesAno.ToString();
                x--;
                this.lbl_mes02.Text = meses[x];
                qtdNotasFiscaisMesAno = ContarNotasFiscaisMesAno(x + 1, anoAtual);
                this.lbl_qtdNotasMes2.Text = qtdNotasFiscaisMesAno.ToString();
                x--;
                this.lbl_mes01.Text = meses[x];
                qtdNotasFiscaisMesAno = ContarNotasFiscaisMesAno(x + 1, anoAtual);
                this.lbl_qtdNotasMes1.Text = qtdNotasFiscaisMesAno.ToString();
            }
        }
    }
}
