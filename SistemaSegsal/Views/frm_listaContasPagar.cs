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
using System.Management;

namespace SistemaSegsal.Views
{
    public partial class frm_listaContasPagar : Form
    {
        EmpresaDTO empDto = new EmpresaDTO();
        EmpresaBLL empBLL = new EmpresaBLL();

        ContaPagarDTO dto = new ContaPagarDTO();
        ContaPagarBLL bll = new ContaPagarBLL();

        Int32 id;
        DateTime dataRegistro;
        string status;
        Int32 mesNumero;
        float totalPagarMesAnoMoeda = 0;
        float totalPagarAnoMoeda = 0;
        float totalPagoMesAnoMoeda = 0;
        float totalPagoAnoMoeda = 0;
        float metaMes;
        float metaMesAno;
        string nomeEmpresa;
        Int32 mes;
        Int32 ano;
        string mesExtenso;

        Thread t1;

        double larguraListView = 1280.0;

        

        private string dadosEmpresa()
        {
            List<EmpresaDTO> emp = empBLL.SelecionarEmpresa();

            nomeEmpresa = emp[0].NomeFantasia;

            return nomeEmpresa;
        }

        private static double PercentOf(double valor, double total)
        {
            return (total / 100.0) * valor;
        }

        private void abrirFormPrincipal(object obj)
        {
            Application.Run(new frm_principal());
        }

        private void abrirFormAddContasPagarNovo(object obj)
        {
            Application.Run(new frm_addContasPagar(id, dataRegistro));
        }

        private void abrirFormAddContasPagarPagar(object obj)
        {
            Application.Run(new frm_addContasPagar(id));
        }

        private void EstadoInicial()
        {
            //Botões de Registros
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.cmb_ano.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_sair.Visible = true;

            this.btn_sair.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            //Botôes de Registro Selecionado
            this.btn_pagar.Visible = false;
            this.btn_imprimir.Visible = false;
            this.btn_cancelarChamado.Visible = false;

            this.cmb_mes.Enabled = true;
            this.lvw_listaContasPagar.Enabled = true;
            this.lbl_ano.Visible = false;
            this.cmb_anos.Visible = false;
            this.btn_filtrar.Visible = false;

            this.panel2.Size = new Size(1370, 0);
            this.panel10.Location = new Point(0, 70);
            this.groupBox1.Location = new Point(30, 195);
            this.label2.Location = new Point(30, 275);
            this.lvw_listaContasPagar.Location = new Point(30, 305);
            this.lvw_listaContasPagar.Size = new Size(1299, 363);

            this.cmb_mes.Focus();
        }

        private void CriarNovoContaPagar()
        {
            bll.CriarNovoContaPagar(dto);

            id = dto.Id + 1;
            dataRegistro = DateTime.Now;            

            this.Close();
            t1 = new Thread(abrirFormAddContasPagarNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }

        private void DeletarContaPagar()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Deletar esse registro?", "Deletar!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dto.Id = Int32.Parse(this.lvw_listaContasPagar.SelectedItems[0].Text);

                bll.ExcluirContaPagar(dto);

                MessageBox.Show("Conta a pagar deletada com sucesso!", "Deletar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.EstadoInicial();
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

        private Int32 SelecionarMesTextoNumero(string mesTexto)
        {
            switch (mesTexto)
            {
                case "Janeiro":
                    mesNumero = 1;
                    break;
                case "Fevereiro":
                    mesNumero = 2;
                    break;
                case "Março":
                    mesNumero = 3;
                    break;
                case "Abril":
                    mesNumero = 4;
                    break;
                case "Maio":
                    mesNumero = 5;
                    break;
                case "Junho":
                    mesNumero = 6;
                    break;
                case "Julho":
                    mesNumero = 7;
                    break;
                case "Agosto":
                    mesNumero = 8;
                    break;
                case "Setembro":
                    mesNumero = 9;
                    break;
                case "Outubro":
                    mesNumero = 10;
                    break;
                case "Novembro":
                    mesNumero = 11;
                    break;
                case "Dezembro":
                    mesNumero = 12;
                    break;
            }
            return mesNumero;
        }

        private string SelecionarMesTextoNumero(Int32 mesNum)
        {
            switch (mesNum)
            {
                case 1:
                    mesExtenso = "Janeiro";
                    break;
                case 2:
                    mesExtenso = "Fevereiro";
                    break;
                case 3:
                    mesExtenso = "Março";
                    break;
                case 4:
                    mesExtenso = "Abril";
                    break;
                case 5:
                    mesExtenso = "Maio";
                    break;
                case 6:
                    mesExtenso = "Junho";
                    break;
                case 7:
                    mesExtenso = "Julho";
                    break;
                case 8:
                    mesExtenso = "Agosto";
                    break;
                case 9:
                    mesExtenso = "Setembro";
                    break;
                case 10:
                    mesExtenso = "Outubro";
                    break;
                case 11:
                    mesExtenso = "Novembro";
                    break;
                case 12:
                    mesExtenso = "Dezembro";
                    break;
            }
            return mesExtenso;
        }

        public void ListarContasPagar()
        {
            string[] item = new string[15];
            int prox = 1;
            Int32 dias = 0;
            Int32 valor = 0;

            var listaContasPagar = bll.ListarContaPagar();

            this.lvw_listaContasPagar.Items.Clear();

            //int x = listaContasPagar.Count;

            foreach (ContaPagarDTO pg in listaContasPagar)
            {
                item[0] = pg.Id.ToString();
                item[1] = prox.ToString();
                item[2] = pg.Conta;
                item[3] = pg.Fornecedor;
                item[4] = pg.Descricao;
                item[5] = pg.FormaPgto;
                float vlTransacao = (float)pg.ValorTransacao / 100;
                item[6] = vlTransacao.ToString("R$ #,##0.00");
                item[7] = pg.Parcela;
                float vlParcela = (float)pg.ValorParcela / 100;
                item[8] = vlParcela.ToString("R$ #,##0.00");
                item[9] = pg.DataVencimento.ToString("dd/MM/yyyy");
                dias = (Int32)pg.DataVencimento.Subtract(DateTime.Today).TotalDays;
                if(dias < 0 && pg.Status == "A Pagar")
                {
                    item[10] = dias.ToString();
                    item[14] = "Atrasado";                           
                }
                else if(dias < 0 && pg.Status == "Pago")
                {
                    item[10] = "-";
                    item[14] = pg.Status;                    
                }
                else
                {
                    item[10] = dias.ToString();
                    item[14] = pg.Status;                    
                }
                string dataReceb = pg.DataPgtoReceb.ToString("dd/MM/yyyy");
                if(dataReceb == "01/01/2000")
                {
                    item[11] = "";
                }
                else
                {
                    item[11] = pg.DataPgtoReceb.ToString("dd/MM/yyyy");
                }
                float vlJuros = (float)pg.DescJuros / 100;
                
                float vlTotal = (float)pg.ValorTotal / 100;
                if(pg.Status == "A Pagar")
                {
                    item[12] = "";
                    item[13] = "";
                }
                else
                {
                    item[12] = vlJuros.ToString("R$ #,##0.00");
                    item[13] = vlTotal.ToString("R$ #,##0.00");
                }

                lvw_listaContasPagar.Items.Add(new ListViewItem(item));
                prox++;
                //i++;
            }
        }

        public void ListarContasPagarMes(string mes, Int32 ano)
        {
            dto.Mes = this.SelecionarMesTextoNumero(mes);
            dto.Ano = ano;

            string[] item = new string[16];
            int prox = 1;
            Int32 dias = 0;
            Int32 valor = 0;
            
            var listaContasPagar = bll.ListarContaPagarMes(dto);

            this.lvw_listaContasPagar.Items.Clear();

            foreach (ContaPagarDTO pg in listaContasPagar)
            {
                Int32 cor;

                item[0] = "";
                item[1] = prox.ToString();
                item[2] = pg.Conta;
                item[3] = pg.Fornecedor + " / " + pg.Descricao;
                item[4] = "";
                item[5] = pg.CondPgto + "/" + pg.FormaPgto;
                float vlTransacao = (float)pg.ValorTransacao / 100;
                item[6] = vlTransacao.ToString("R$ #,##0.00");
                item[7] = pg.Parcela;
                float vlParcela = (float)pg.ValorParcela / 100;
                item[8] = vlParcela.ToString("R$ #,##0.00");
                item[9] = pg.DataVencimento.ToString("dd/MM/yyyy");
                dias = (Int32)pg.DataVencimento.Subtract(DateTime.Today).TotalDays;
                if (dias <= 0 && pg.Status == "A Pagar")
                {
                    item[10] = dias.ToString();
                    item[14] = "Atrasado";
                    cor = 0;                    
                }
                else if (pg.Status == "Pago")
                {
                    item[10] = "-";
                    item[14] = pg.Status;
                    cor = 2;
                }
                else
                {
                    item[10] = dias.ToString();
                    item[14] = pg.Status;
                    cor = 1;
                }
                string dataReceb = pg.DataPgtoReceb.ToString("dd/MM/yyyy");
                if (dataReceb == "01/01/2000")
                {
                    item[11] = "";
                }
                else
                {
                    item[11] = pg.DataPgtoReceb.ToString("dd/MM/yyyy");
                }
                float vlJuros = (float)pg.DescJuros / 100;

                float vlTotal = (float)pg.ValorTotal / 100;
                if (pg.Status == "A Pagar")
                {
                    item[12] = "";
                    item[13] = "";
                }
                else
                {
                    item[12] = vlJuros.ToString("R$ #,##0.00");
                    item[13] = vlTotal.ToString("R$ #,##0.00");
                }
                item[15] = pg.Id.ToString();
                
                lvw_listaContasPagar.Items.Add(new ListViewItem(item, cor));
                prox++;
                //i++;
            }
        }

        private float SomarContasPagarMesAno(Int32 mesSel, Int32 anoSel)
        {
            float valorPagarMesAnoMoeda = 0;
            string tipo;
            totalPagarMesAnoMoeda = 0;

            Int32 qtd = bll.ContarMovimentacao();

            for(int x = 1;x <= qtd; x++)
            {
                dto.Id = x;

                List<ContaPagarDTO> cp = bll.SelecionarContasPagar(dto);

                mes = cp[0].DataVencimento.Month;
                ano = cp[0].DataVencimento.Year;
                tipo = cp[0].TipoMovimentacao;

                if (mes == mesSel && ano == anoSel && tipo == "S")
                {
                    bll.SelecionarContaPagar(dto);

                    valorPagarMesAnoMoeda = (float)dto.ValorParcela / 100;
                }
                else
                {
                    valorPagarMesAnoMoeda = 0;
                }

                totalPagarMesAnoMoeda = totalPagarMesAnoMoeda + valorPagarMesAnoMoeda;

            }

            return totalPagarMesAnoMoeda;            
        }

        private float SomarContasPagarAno(Int32 anoSel)
        {
            float valorPagarAnoMoeda = 0;
            string tipo;
            totalPagarAnoMoeda = 0;

            Int32 qtd = bll.ContarMovimentacao();

            for(int x = 1; x <= qtd; x++)
            {
                dto.Id = x;

                List<ContaPagarDTO> cp = bll.SelecionarContasPagar(dto);

                ano = cp[0].DataVencimento.Year;
                tipo = cp[0].TipoMovimentacao; 

                if (ano == anoSel && tipo == "S")
                {
                    bll.SelecionarContaPagar(dto);

                    valorPagarAnoMoeda = (float)dto.ValorParcela / 100;
                }
                else
                {
                    valorPagarAnoMoeda = 0;
                }
                totalPagarAnoMoeda = totalPagarAnoMoeda + valorPagarAnoMoeda;

            }
            return totalPagarAnoMoeda;            
        }

        private float SomarContasPagasMesAno(Int32 mesSel, Int32 anoSel)
        {
            float valorPagoMesAnoMoeda = 0;
            string tipo;
            totalPagoMesAnoMoeda = 0;

            Int32 qtd = bll.ContarMovimentacao();

            for (int x = 1; x <= qtd; x++)
            {
                dto.Id = x;

                List<ContaPagarDTO> cp = bll.SelecionarContasPagar(dto);

                mes = cp[0].DataVencimento.Month;
                ano = cp[0].DataVencimento.Year;
                tipo = cp[0].TipoMovimentacao;
                status = cp[0].Status;

                if (mes == mesSel && ano == anoSel && tipo == "S" && status == "Pago")
                {
                    bll.SelecionarContaPagar(dto);

                    valorPagoMesAnoMoeda = (float)dto.ValorParcela / 100;
                }
                else
                {
                    valorPagoMesAnoMoeda = 0;
                }

                totalPagoMesAnoMoeda = totalPagoMesAnoMoeda + valorPagoMesAnoMoeda;

            }

            return totalPagoMesAnoMoeda;            
        }

        private float SomarContasPagasAno(Int32 anoSel)
        {
            float valorPagoAnoMoeda = 0;
            string tipo;
            totalPagoAnoMoeda = 0;

            Int32 qtd = bll.ContarMovimentacao();

            for (int x = 1; x <= qtd; x++)
            {
                dto.Id = x;

                List<ContaPagarDTO> cp = bll.SelecionarContasPagar(dto);

                ano = cp[0].DataVencimento.Year;
                tipo = cp[0].TipoMovimentacao;
                status = cp[0].Status;

                if (ano == anoSel && tipo == "S" && status == "Pago")
                {
                    bll.SelecionarContaPagar(dto);

                    valorPagoAnoMoeda = (float)dto.ValorParcela / 100;
                }
                else
                {
                    valorPagoAnoMoeda = 0;
                }

                totalPagoAnoMoeda = totalPagoAnoMoeda + valorPagoAnoMoeda;
            }

            return totalPagoAnoMoeda;            
        }

        private float MetaMesAtingida(float valorTotal, float valorPago)
        {
            //(100 / valorTotal) * valorPago           
            if (valorTotal == 0 && valorPago == 0)
            {
                return metaMes = 0;
            }
            else
            {
                metaMes = (100 / valorTotal) * valorPago;

                return metaMes;
            }
        }

        private float MetaMesAnoAtingida(float valorTotal, float valorPago)
        {
            //(100 / valorTotal) * valorPago           

            if(valorTotal == 0 && valorPago == 0)
            {
                return metaMesAno = 0;
            }
            else
            {
                metaMesAno = (100 / valorTotal) * valorPago;

                return metaMesAno;
            }            
        }

        private void PopularComboboxMes()
        {
            this.cmb_mes.Items.Add("Janeiro");
            this.cmb_mes.Items.Add("Fevereiro");
            this.cmb_mes.Items.Add("Março");
            this.cmb_mes.Items.Add("Abril");
            this.cmb_mes.Items.Add("Maio");
            this.cmb_mes.Items.Add("Junho");
            this.cmb_mes.Items.Add("Julho");
            this.cmb_mes.Items.Add("Agosto");
            this.cmb_mes.Items.Add("Setembro");
            this.cmb_mes.Items.Add("Outubro");
            this.cmb_mes.Items.Add("Novembro");
            this.cmb_mes.Items.Add("Dezembro");
        }

        private void PopularComboboxAno()
        {
            for(int x = 2022; x <= 2030; x++)
            {
                this.cmb_anos.Items.Add(x.ToString());
            }
        }

        private void SelecionarDadosContasPagarMesAno(string mesExt, Int32 anoSel)
        {
            this.lbl_valorPagarMes.Text = 0.ToString("R$ #,##0.00");
            this.lbl_valorJaPagoMes.Text = 0.ToString("R$ #,##0.00");
            this.lbl_valorPagarAno.Text = 0.ToString("R$ #,##0.00");
            this.lbl_valorJaPagoAno.Text = 0.ToString("R$ #,##0.00");
            this.pgb_metaMes.Value = 0;
            this.pgb_metaAno.Value = 0;

            this.ListarContasPagarMes(mesExt, anoSel);

            this.SomarContasPagarMesAno(mesNumero, anoSel);
            this.lbl_valorPagarMes.Text = totalPagarMesAnoMoeda.ToString("R$ #,##0.00");
            this.SomarContasPagarAno(anoSel);
            this.lbl_valorPagarAno.Text = totalPagarAnoMoeda.ToString("R$ #,##0.00");
            this.SomarContasPagasMesAno(mesNumero, anoSel);
            this.lbl_valorJaPagoMes.Text = totalPagoMesAnoMoeda.ToString("R$ #,##0.00");
            this.SomarContasPagasAno(anoSel);
            this.lbl_valorJaPagoAno.Text = totalPagoAnoMoeda.ToString("R$ #,##0.00");
            this.MetaMesAtingida(totalPagarMesAnoMoeda, totalPagoMesAnoMoeda);
            this.lbl_metaMes.Text = metaMes.ToString("##0.00") + "%";
            this.MetaMesAnoAtingida(totalPagarAnoMoeda, totalPagoAnoMoeda);
            this.lbl_metaAno.Text = metaMesAno.ToString("##0.00") + "%";

            float pagarMes = totalPagarMesAnoMoeda - totalPagoMesAnoMoeda;
            this.lbl_pagarMes.Text = pagarMes.ToString("R$ #,##0.00");

            float pagarAno = totalPagarAnoMoeda - totalPagoAnoMoeda;
            this.lbl_pagarAno.Text = pagarAno.ToString("R$ #,##0.00");
            
            this.pgb_metaMes.Value = (Int32)metaMes;            
            this.pgb_metaAno.Value = (Int32)metaMesAno;
        }

        private void PagarConta()
        {
            id = Int32.Parse(this.lvw_listaContasPagar.SelectedItems[0].SubItems[15].Text);
            status = this.lvw_listaContasPagar.SelectedItems[0].SubItems[14].Text;

            if(status == "Pago")
            {
                return;
            }
            else
            {
                id = dto.Id + 1;

                this.Close();
                t1 = new Thread(abrirFormAddContasPagarPagar);
                t1.SetApartmentState(ApartmentState.STA);
                t1.Start();
            }

            //MessageBox.Show("Id: " + id.ToString() + ", Status: " + status);
        }

        public frm_listaContasPagar()
        {
            InitializeComponent();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoContaPagar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frm_listaContasPagar_Load(object sender, EventArgs e)
        {
            this.dadosEmpresa();
            this.Text = "Gestão Empresa V. 1.0 - " + nomeEmpresa + " - Financeiro: Contas a Pagar";

            this.lvw_listaContasPagar.Columns.Add("", 30).TextAlign = HorizontalAlignment.Center;                       
            this.lvw_listaContasPagar.Columns.Add("Item", 40).TextAlign = HorizontalAlignment.Center;//0
            this.lvw_listaContasPagar.Columns.Add("Conta", 90).TextAlign = HorizontalAlignment.Left;//1
            this.lvw_listaContasPagar.Columns.Add("Fornecedor/Descrição", 270).TextAlign = HorizontalAlignment.Left;//2
            this.lvw_listaContasPagar.Columns.Add("Descrição", 0).TextAlign = HorizontalAlignment.Left;//3
            this.lvw_listaContasPagar.Columns.Add("Condição/Forma Pgto", 150).TextAlign = HorizontalAlignment.Left;//4
            this.lvw_listaContasPagar.Columns.Add("(R$) Transação", 100).TextAlign = HorizontalAlignment.Right;//5
            this.lvw_listaContasPagar.Columns.Add("Parcela", 60).TextAlign = HorizontalAlignment.Center;//6
            this.lvw_listaContasPagar.Columns.Add("(R$) Parcela", 90).TextAlign = HorizontalAlignment.Right;//7
            this.lvw_listaContasPagar.Columns.Add("Vencimento", 80).TextAlign = HorizontalAlignment.Center;//8
            this.lvw_listaContasPagar.Columns.Add("A Vencer", 60).TextAlign = HorizontalAlignment.Center;//9
            this.lvw_listaContasPagar.Columns.Add("Pagamento", 80).TextAlign = HorizontalAlignment.Center;//10
            this.lvw_listaContasPagar.Columns.Add("(R$) Juros", 80).TextAlign = HorizontalAlignment.Right;//11
            this.lvw_listaContasPagar.Columns.Add("(R$) Total", 90).TextAlign = HorizontalAlignment.Right;//12
            this.lvw_listaContasPagar.Columns.Add("Status", 60).TextAlign = HorizontalAlignment.Left;//13
            this.lvw_listaContasPagar.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center; //14

            this.lvw_listaContasPagar.SmallImageList = imageList1;

            Int32 mes = DateTime.Now.Month;

            this.SelecionarMesTextoNumero(mes);

            Int32 anoSel = DateTime.Now.Year;

            this.SelecionarDadosContasPagarMesAno(mesExtenso, anoSel);

            this.PopularComboboxMes();
            this.PopularComboboxAno();
            this.ListarContasPagarMes(mesExtenso, anoSel);
            this.EstadoInicial();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            this.DeletarContaPagar();
        }

        private void lvw_listaContasPagar_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaContasPagar.SelectedItems.Count > 0)
            {
                Int32 id = Int32.Parse(this.lvw_listaContasPagar.SelectedItems[0].SubItems[15].Text);
                string status = this.lvw_listaContasPagar.SelectedItems[0].SubItems[14].Text;

                //MessageBox.Show(status + "/n" +                    id.ToString());

                this.btn_cancelar.Visible = true;
                this.btn_deletar.Visible = false;
                this.btn_novo.Visible = false;
                this.btn_sair.Visible = false;
                this.cmb_ano.Visible = true;
                this.btn_deletar.Visible = true;

                this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
                this.btn_deletar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
                this.cmb_ano.Location = new Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

                this.btn_pagar.Visible = true;

                this.btn_pagar.Location = new System.Drawing.Point(MedidasGeraisDTO.posicaoSubMenuHor01, MedidasGeraisDTO.posicaoSubMenuVer);

                //Botôes de Registro Selecionado
                this.btn_pagar.Visible = true;
                this.btn_imprimir.Visible = false;
                this.btn_cancelarChamado.Visible = false;

                //this.cmb_mes.Enabled = true;
                //this.lvw_listaContasPagar.Enabled = true;
                //this.lbl_ano.Visible = false;
                //this.cmb_anos.Visible = false;
                //this.btn_filtrar.Visible = false;

                this.panel2.Size = new Size(1370, 50);
                this.panel10.Location = new Point(0, 120);
                this.groupBox1.Location = new Point(30, 245);
                this.label2.Location = new Point(30, 325);
                this.lvw_listaContasPagar.Location = new Point(30, 355);
                this.lvw_listaContasPagar.Size = new Size(1299, 313);
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_pagar_Click(object sender, EventArgs e)
        {
            this.PagarConta();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.SomarContasPagarMesAno();
        }

        private void cmb_mes_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_mes.Text == "")
            {
                return;
            }
            else
            {                                
                this.btn_filtrar.Visible = true;
                this.cmb_anos.Visible = true;
                this.lbl_ano.Visible = true;
                this.cmb_anos.Text = "";

                this.cmb_anos.Focus();
            }
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {            
            string mesExt = this.cmb_mes.Text;          

            Int32 anoSel = Int32.Parse(this.cmb_anos.Text);           

            this.SelecionarDadosContasPagarMesAno(mesExt, anoSel);
        }
    }
}
