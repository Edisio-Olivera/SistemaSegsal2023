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
using SistemaSegsal.View;

namespace SistemaSegsal.Views
{
    public partial class frm_listaPropostaComercialServico : Form
    {
        private void Algoritmo()
        {
            //VINCULAR SERVIÇO/CHAMADO À PROPOSTA










        }
        PropostaComercialServicoDTO dto = new PropostaComercialServicoDTO();
        PropostaComercialServicoBLL bll = new PropostaComercialServicoBLL();

        PropostaComercialDTO proDto = new PropostaComercialDTO();
        PropostaComercialBLL proBll = new PropostaComercialBLL();

        PropostaComercialServicoTipoDTO tipDto = new PropostaComercialServicoTipoDTO();
        PropostaComercialServicoTipoBLL tipBll = new PropostaComercialServicoTipoBLL();

        ChamadoDTO chmDto = new ChamadoDTO();
        ChamadoBLL chmBll = new ChamadoBLL();

        Int32 valorProposta;

        private void EstadoInicial()
        {
            //Visualização dos Botões
            this.btn_novo.Visible = true;
            this.btn_cancelar.Visible = false;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_sair.Visible = true;
                        
            //Posição dos Botões            
            this.btn_sair.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_novo.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
            
            this.txt_codigo.Enabled = false;
            this.txt_dataProposta.Enabled = false;
            this.txt_cliente.Enabled = false;
            this.txt_titulo.Enabled = false;
            this.txt_valor.Enabled = false;

            this.txt_id.Enabled = false;
            this.cmb_tipoServico.Enabled = false;
            this.txt_qtd.Enabled = false;
            this.txt_descricao.Enabled = false;
            this.cmb_chamados.Visible = false;            
            this.txt_valorUnitario.Enabled = false;
            this.txt_valorTotal.Enabled = false;

            this.lvw_listaServico.Enabled = true;

            this.txt_id.Text = "";
            this.cmb_tipoServico.Text = "";
            this.txt_qtd.Text = "";
            this.lbl_descricao.Text = "Descrição";
            this.txt_descricao.Text = "";
            this.txt_valorUnitario.Text = "";
            this.txt_valorTotal.Text = "";

            //this.txt_id.BackColor = Color.FromArgb(192, 255, 255);
            //this.txt_codigo.BackColor = Color.FromArgb(192, 255, 255);
            //this.txt_dataProposta.BackColor = Color.White;
            //this.cmb_cliente.BackColor = Color.White;
            //this.cmb_base.BackColor = Color.White;
            //this.txt_titulo.BackColor = Color.White;
            //this.txt_descricao.BackColor = Color.White;
            //this.txt_observacao.BackColor = Color.White;
            //this.cmb_condPgto.BackColor = Color.White;
            //this.cmb_formaPgto.BackColor = Color.White;
            //this.txt_valor.BackColor = Color.White;
            //this.txt_status.BackColor = Color.White;
            //this.cmb_status.BackColor = Color.White;
            //this.cmb_status.Focus();
        }

        private void CriarNovoServico()
        {
            bll.CriarNovoServicoProposta(dto);

            Int32 id = dto.Id + 1;

            //frm_addPropostaComercialServico serv = new frm_addPropostaComercialServico(id);
            //serv.Visible = true;

            this.txt_id.Text = id.ToString();

            //Visualização dos Botões
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_salvar.Visible = true;
            this.btn_sair.Visible = false;

            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;            
            this.btn_atualizar.Visible = false;

            //Posição dos Botões            
            this.btn_salvar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);

            this.txt_codigo.Enabled = false;
            this.txt_dataProposta.Enabled = false;
            this.txt_cliente.Enabled = false;
            this.txt_titulo.Enabled = false;
            this.txt_valor.Enabled = false;

            this.txt_id.Enabled = false;

            this.PopularComboboxTipoServico();

            this.cmb_tipoServico.Enabled = true;
            this.txt_qtd.Enabled = true;
            this.txt_descricao.Enabled = true;
            this.txt_valorUnitario.Enabled = true;
            this.txt_valorTotal.Enabled = false;

            this.lvw_listaServico.Enabled = true;
        }

        private void SalvarServico()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Proposta = this.txt_codigo.Text;

            if(this.cmb_tipoServico.Text == "")
            {
                MessageBox.Show("Selcione um tipo de serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmb_tipoServico.Focus();
                return;
            }
            else
            {
                dto.TipoServico = this.cmb_tipoServico.Text;
            }
            
            if(this.txt_qtd.Text == "")
            {
                MessageBox.Show("Digite uma quantidade!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_qtd.Focus();
                return;
            }
            else
            {
                dto.Qtd = Int32.Parse(this.txt_qtd.Text);
            }
            
            if(this.cmb_tipoServico.Text == "Ordem de Serviço")
            {
                if (this.txt_descricao.Text == "")
                {
                    MessageBox.Show("Digite uma descrição!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.txt_descricao.Focus();
                    return;
                }
                else
                {
                    dto.Descricao = this.txt_descricao.Text;
                }
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }            
            
            if(this.txt_valorUnitario.Text == "")
            {
                MessageBox.Show("Digite um valor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_valorUnitario.Focus();
                return;
            }
            else
            {
                dto.ValorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
            }

            if(this.txt_valorTotal.Text == "")
            {
                dto.ValorTotal = dto.Qtd * dto.ValorUnitario;
            }
            else
            {
                dto.ValorTotal = Int32.Parse(this.txt_valorTotal.Text);
            }           

            //valorProposta = Int32.Parse(this.txt_valor.Text);

            //Salva o serviço
            bll.SalvarServicoProposta(dto);

            //Soma o valor do serviço com o da proposta
            this.SomarValorServico(dto.Proposta, dto.ValorTotal);            

            //Atualiza o valor da proposta no formulário
            List<PropostaComercialDTO> proposta = proBll.SelecionarPropostaComercial(proDto);
            Int32 valorPropostaAtual = proposta[0].Valor;
            this.txt_valor.Text = valorPropostaAtual.ToString("#,##0.00");

            MessageBox.Show("Serviço Salvo com sucesso!", "Salvar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //this.AtualizarPropostaChamado();
            this.EstadoInicial();
            this.ListarServico(dto.Proposta);
        }

        private void EditarServico()
        {
            //Visualização dos Botões
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = false;
            this.btn_deletar.Visible = false;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = true;
            this.btn_sair.Visible = true;

            //Posição dos Botões            
            this.btn_atualizar.Location = new Point(0, 100);
            this.btn_cancelar.Location = new Point(0, 160);

            this.txt_codigo.Enabled = false;
            this.txt_dataProposta.Enabled = false;
            this.txt_cliente.Enabled = false;
            this.txt_titulo.Enabled = false;
            this.txt_valor.Enabled = false;

            this.txt_id.Enabled = false;
            this.cmb_tipoServico.Enabled = true;
            this.txt_qtd.Enabled = true;
            this.txt_descricao.Enabled = false;
            this.txt_valorUnitario.Enabled = true;
            this.txt_valorTotal.Enabled = false;

            this.lvw_listaServico.Enabled = true;
        }

        private void AtualizarServico()
        {
            dto.Id = Int32.Parse(this.txt_id.Text);
            dto.Proposta = this.txt_codigo.Text;

            if (this.cmb_tipoServico.Text == "")
            {
                MessageBox.Show("Selcione um tipo de serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.cmb_tipoServico.Focus();
                return;
            }
            else
            {
                dto.TipoServico = this.cmb_tipoServico.Text;
            }

            if (this.txt_qtd.Text == "")
            {
                MessageBox.Show("Digite uma quantidade!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_qtd.Focus();
                return;
            }
            else
            {
                dto.Qtd = Int32.Parse(this.txt_qtd.Text);
            }

            if (this.txt_descricao.Text == "")
            {
                MessageBox.Show("Digite uma descrição!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_descricao.Focus();
                return;
            }
            else
            {
                dto.Descricao = this.txt_descricao.Text;
            }

            if (this.txt_valorUnitario.Text == "")
            {
                MessageBox.Show("Digite um valor!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_valorUnitario.Focus();
                return;
            }
            else
            {
                dto.ValorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
            }

            dto.ValorTotal = Int32.Parse(this.txt_valorTotal.Text);

            bll.EditarServicoProposta(dto);

            this.EditarValorServico(dto.Proposta);

            MessageBox.Show("Serviço Atualizado com sucesso!", "Atualizar!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.EstadoInicial();
            this.ListarServico(dto.Proposta);
        }

        private void ExcluirServico()
        {
            DialogResult result = MessageBox.Show("Deseja realmente Excluir esse serviço?", "Excluir!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //Exclue o serviço
                dto.Id = Int32.Parse(this.lvw_listaServico.SelectedItems[0].Text);
                proDto.Codigo = this.txt_codigo.Text;

                List<PropostaComercialServicoDTO> servico = bll.SelecionarServicoProposta(dto);
                Int32 valorServico = servico[0].ValorTotal;

                bll.ExcluirServicoProposta(dto);

                //Atualiza o valor da proposta
                this.SubtrairValorServico(proDto.Codigo, valorServico);

                List<PropostaComercialDTO> proposta = proBll.SelecionarPropostaComercial(proDto);
                Int32 valorPropostaAtual = proposta[0].Valor;
                this.txt_valor.Text = valorPropostaAtual.ToString("#,##0.00");

                MessageBox.Show("Serviço Excluído com sucesso!", "Excluir!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.EstadoInicial();
                this.ListarServico(dto.Proposta);
            }
            
        }

        public void SomarValorServico(string codigoProposta, Int32 valorServico)
        {
            //Selecionar o valor da proposta
            proDto.Codigo = codigoProposta;

            List<PropostaComercialDTO> proposta = proBll.SelecionarPropostaComercial(proDto);

            valorProposta = proposta[0].Valor;

            //Soma o valor do servico ao da proposta
            proDto.Valor = valorServico;

            proBll.AtualizarValorPropostaComercial(proDto);
        }

        public void SubtrairValorServico(string codigoProposta, Int32 valorServico)
        {
            //Selecionar o valor da proposta
            proDto.Codigo = codigoProposta;
            List<PropostaComercialDTO> proposta = proBll.SelecionarPropostaComercial(proDto);
            valorProposta = proposta[0].Valor;

            //Soma o valor do servico ao da proposta
            Int32 novoValorProposta = valorServico;

            if(novoValorProposta > 0)
            {
                proDto.Valor = (novoValorProposta * -1);
            }
            else
            {
                proDto.Valor = novoValorProposta;
            }            

            proBll.AtualizarValorPropostaComercial(proDto);
        }

        public void EditarValorServico(string codigoProposta)
        {
            //Selecionar o valor da proposta
            proDto.Codigo = codigoProposta;
            List<PropostaComercialDTO> proposta = proBll.SelecionarPropostaComercial(proDto);
            valorProposta = proposta[0].Valor;

            //Selecionar o valor errado
            dto.Id = Int32.Parse(this.lvw_listaServico.SelectedItems[0].Text);

            List<PropostaComercialServicoDTO> servico = bll.SelecionarServicoProposta(dto);
            Int32 valorUnitarioErradoServico = servico[0].ValorUnitario;
            Int32 valorTotalErradoServico = servico[0].ValorTotal;

            //Selecionar o valor novo
            Int32 qtd = Int32.Parse(this.txt_qtd.Text);
            Int32 novoValorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
            Int32 novoValorTotal = qtd * novoValorUnitario;

            //Calcular diferença
            Int32 diferencaValorProposta = novoValorTotal - valorTotalErradoServico;

            //Soma o valor do servico ao da proposta
            proDto.Valor = diferencaValorProposta;

            proBll.AtualizarValorPropostaComercial(proDto);
        }

        private void SelecionarServico()
        {
            dto.Id = Int32.Parse(this.lvw_listaServico.SelectedItems[0].Text);

            List<PropostaComercialServicoDTO> serv = bll.SelecionarServicoProposta(dto);

            this.txt_id.Text = serv[0].Id.ToString();
            this.cmb_tipoServico.Text = serv[0].TipoServico;

            switch (serv[0].TipoServico)
            {
                case "Manutenção Corretiva":
                    this.txt_descricao.Visible = true;
                    this.txt_descricao.Text = serv[0].Descricao;
                    this.cmb_chamados.Visible = false;
                    this.lbl_descricao.Text = "Descrição";
                break;

                case "Manutenção Preventiva":
                    this.txt_descricao.Visible = true;
                    this.txt_descricao.Text = serv[0].Descricao;
                    this.cmb_chamados.Visible = false;
                    this.lbl_descricao.Text = "Descrição";
                break;

                case "Mão de Obra":
                    this.txt_descricao.Visible = true;
                    this.txt_descricao.Text = serv[0].Descricao;
                    this.cmb_chamados.Visible = false;
                    this.lbl_descricao.Text = "Descrição";
                break;

                case "Equipamento":
                    this.txt_descricao.Visible = true;
                    this.txt_descricao.Text = serv[0].Descricao;
                    this.cmb_chamados.Visible = false;
                    this.lbl_descricao.Text = "Descrição";
                break;

                case "Material":
                    this.txt_descricao.Visible = true;
                    this.txt_descricao.Text = serv[0].Descricao;
                    this.cmb_chamados.Visible = false;
                    this.lbl_descricao.Text = "Descrição";
                break;

                case "Chamado":
                    this.txt_descricao.Visible = false;
                    this.PopularComboboxChamados();
                    this.cmb_chamados.Text = serv[0].Descricao;
                    this.cmb_chamados.Visible = true;
                    this.lbl_descricao.Text = "Chamado";
                break;
            }




            //if(serv[0].TipoServico == "Ordem de Serviço")
            //{
            //    this.txt_descricao.Visible = true;
            //    this.txt_descricao.Text = serv[0].Descricao;
            //    this.cmb_chamados.Visible = false;
            //    this.lbl_descricao.Text = "Descrição";
            //}
            //else if (serv[0].TipoServico == "Manutenção Corretiva")
            //{
            //    this.txt_descricao.Visible = false;
            //    this.PopularComboboxChamados();
            //    this.cmb_chamados.Text = serv[0].Descricao;
            //    this.cmb_chamados.Visible = true;
            //    this.lbl_descricao.Text = "Chamado";
            //}

            this.txt_qtd.Text = serv[0].Qtd.ToString();
            this.txt_valorUnitario.Text = serv[0].ValorUnitario.ToString("#,##0.00");
            this.txt_valorTotal.Text = serv[0].ValorTotal.ToString("#,##0.00");         

            //Visualização dos Botões
            this.btn_novo.Visible = false;
            this.btn_cancelar.Visible = true;
            this.btn_editar.Visible = true;
            this.btn_deletar.Visible = true;
            this.btn_salvar.Visible = false;
            this.btn_atualizar.Visible = false;
            this.btn_sair.Visible = false;

            //Posição dos Botões            
            this.btn_editar.Location = new Point(MedidasGeraisDTO.posicaoHor01, MedidasGeraisDTO.posicaoVer);
            this.btn_deletar.Location = new Point(MedidasGeraisDTO.posicaoHor02, MedidasGeraisDTO.posicaoVer);
            this.btn_cancelar.Location = new Point(MedidasGeraisDTO.posicaoHor03, MedidasGeraisDTO.posicaoVer);

            this.txt_id.Enabled = false;
            this.cmb_tipoServico.Enabled = false;
            this.txt_qtd.Enabled = false;
            this.txt_descricao.Enabled = false;
            this.txt_valorUnitario.Enabled = false;
            this.txt_valorTotal.Enabled = false;

            this.lvw_listaServico.Enabled = true;

        }

        private void SelecionarChamado(string codigo)
        {
            chmDto.Codigo = codigo;

            List<ChamadoDTO> chm = chmBll.SelecionarChamado(chmDto);

            //string chamadoCliente = chm[0].ChamadoCliente;
            string valorTotal = chm[0].ValorTotal.ToString("R$ #,##0.00");
        }

        private void PopularComboboxTipoServico()
        {
            List<PropostaComercialServicoTipoDTO> tip = tipBll.PopularComboboxPropostaComercialServicoTipo();

            this.cmb_tipoServico.DataSource = tip;
            this.cmb_tipoServico.DisplayMember = "descricao";
            this.cmb_tipoServico.Text = "";
        }

        private void PopularComboboxEquipamento()
        {
            //List<PropostaComercialServicoTipoDTO> tip = tipBll.PopularComboboxPropostaComercialServicoTipo();

            //this.cmb_tipoServico.DataSource = tip;
            //this.cmb_tipoServico.DisplayMember = "tipoServico";
            //this.cmb_tipoServico.Text = "";
        }

        private void PopularComboboxMaterial()
        {
            //List<PropostaComercialServicoTipoDTO> tip = tipBll.PopularComboboxPropostaComercialServicoTipo();

            //this.cmb_tipoServico.DataSource = tip;
            //this.cmb_tipoServico.DisplayMember = "tipoServico";
            //this.cmb_tipoServico.Text = "";
        }

        private void PopularComboboxChamados()
        {
            List<ChamadoDTO> chm = chmBll.PopularComboboxChamado();

            this.cmb_chamados.DataSource = chm;
            this.cmb_chamados.DisplayMember = "codigo";
            this.cmb_chamados.Text = "";
        }

        private void ListarServico(string codigo)
        {
            dto.Proposta = codigo;

            string[] item = new string[6];
            int prox = 1;

            var listaServico = bll.ListaServicoProposta(dto);

            this.lvw_listaServico.Items.Clear();

            foreach (PropostaComercialServicoDTO serv in listaServico)
            {
                item[0] = serv.Id.ToString();
                item[1] = prox.ToString();
                item[2] = serv.TipoServico;
                item[3] = serv.Descricao;
                item[4] = serv.ValorUnitario.ToString("R$ #,##0.00");
                item[5] = serv.ValorTotal.ToString("R$ #,##0.00");

                lvw_listaServico.Items.Add(new ListViewItem(item));
                prox++;
            }
        }

        private void AtualizarPropostaChamado()
        {
            string[] chamado = this.cmb_chamados.Text.Split('-');
            chmDto.Proposta = this.txt_codigo.Text;
            chmDto.Codigo = chamado[0];

            chmBll.AtualizarPropostaChamado(chmDto);
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
                frm_listaPropostaComercial prop = new frm_listaPropostaComercial();
                prop.Visible = true;

                this.Close();
            }
        }






        public frm_listaPropostaComercialServico()
        {
            InitializeComponent();
        }

        public frm_listaPropostaComercialServico(string codigo, string cliente, string baseCli, string dataProposta, string titulo, Int32 valor)
        {
            InitializeComponent();

            this.txt_codigo.Text = codigo;
            this.txt_dataProposta.Text = dataProposta;
            this.txt_cliente.Text = cliente + " - " + baseCli;

            this.txt_titulo.Text = titulo;
            this.txt_valor.Text = valor.ToString("#,##0.00");
        }

        private void frm_listaPropostaComercialServico_Load(object sender, EventArgs e)
        {
            //Designer do form
            this.Text = "Sistema de Gestão - SEGSAL Segurança Eletrônica - v 1.0";
            this.BackColor = Color.FromArgb(255, 255, 255);

            //this.EstadoInicial();

            //Designer do listview
            this.lvw_listaServico.BackColor = Color.FromArgb(255, 255, 192);

            //1068

            this.lvw_listaServico.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaServico.Columns.Add("Item", 60).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaServico.Columns.Add("Tipo Serviço", 205).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaServico.Columns.Add("Descrição do Serviço", 580).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaServico.Columns.Add("Valor Unitário", 100).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaServico.Columns.Add("Valor Total", 100).TextAlign = HorizontalAlignment.Right;

            //this.PopularComboboxTipoServico();

            string codigo = this.txt_codigo.Text;
            this.ListarServico(codigo);
            this.EstadoInicial();
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoServico();

            
        }

        private void txt_qtd_TextChanged(object sender, EventArgs e)
        {
            //Int32 qtd = Int32.Parse(this.txt_qtd.Text);
            //Int32 valorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
            //Int32 valorTotal;

            //if (this.txt_valorUnitario.Text == "")
            //{                
            //    return;
            //}
            //else if (this.txt_qtd.Text == "")
            //{
            //    return;
            //}
            //else
            //{
            //    valorTotal = qtd * valorUnitario;

            //    this.txt_valorTotal.Text = valorTotal.ToString();
            //}
        }

        private void txt_valorUnitario_TextChanged(object sender, EventArgs e)
        {
            //Int32 qtd = Int32.Parse(this.txt_qtd.Text);
            //Int32 valorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
            //Int32 valorTotal;

            //if (this.txt_valorUnitario.Text == "")
            //{
            //    return;
            //}
            //else if (this.txt_qtd.Text == "")
            //{
            //    return;
            //}
            //else
            //{                
            //    valorTotal = qtd * valorUnitario;

            //    this.txt_valorTotal.Text = valorTotal.ToString();
            //}
        }

        private void lvw_listaServico_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvw_listaServico.SelectedItems.Count > 0)
            {
                this.SelecionarServico();
            }            
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (this.txt_valorUnitario.Text == "")
            {
                MessageBox.Show("Digite o valor do serviço!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_valorUnitario.Focus();
                return;
            }
            else if(this.txt_qtd.Text == "")
            {
                MessageBox.Show("Digite uma quantdade!", "Campo Vazio!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txt_qtd.Focus();
                return;
            }
            else
            {
                Int32 qtd = Int32.Parse(this.txt_qtd.Text);
                Int32 valorUnitario = Int32.Parse(this.txt_valorUnitario.Text);
                Int32 valorTotal;

                valorTotal = qtd * valorUnitario;

                this.txt_valorTotal.Text = valorTotal.ToString();
            }
        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            this.SalvarServico();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            this.EditarServico();
        }

        private void btn_deletar_Click(object sender, EventArgs e)
        {
            this.ExcluirServico();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.CancelarRegistro();
        }

        private void btn_atualizar_Click(object sender, EventArgs e)
        {
            this.AtualizarServico();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.SairFormulario();
        }

        private void cmb_tipoServico_SelectedValueChanged(object sender, EventArgs e)
        {                 
            //string tipo = this.cmb_tipoServico.Text;

            //if(tipo == "")
            //{
            //    return;
            //}
            //else
            //{
            //    switch (tipo)
            //    {
            //        case "Ordem de Serviço":
            //            this.cmb_chamados.Visible = false;
            //            this.txt_descricao.Visible = true;
            //            this.txt_descricao.Location = new Point(160, 66);
            //            this.txt_descricao.Size = new Size(580, 23);
            //            this.txt_qtd.Text = "";
            //            this.lbl_descricao.Text = "Serviço";
            //            this.txt_valorUnitario.Text = "";
            //            this.txt_valorTotal.Text = "";
            //            this.lbl_mensagemChamado.Text = "";
            //            break;
            //        case "Chamado":
            //            this.txt_descricao.Visible = false;
            //            this.cmb_chamados.Visible = true;
            //            this.cmb_chamados.Location = new Point(160, 66);
            //            this.cmb_chamados.Size = new Size(580, 23);
            //            this.PopularComboboxChamados();
            //            this.txt_qtd.Text = 1.ToString();
            //            this.lbl_descricao.Text = "Chamado";
            //            this.txt_valorUnitario.Text = "";
            //            this.txt_valorTotal.Text = "";
            //            this.lbl_mensagemChamado.Text = "";
            //            break;
            //    }
            //}            
        }       

        private void cmb_chamados_SelectedValueChanged(object sender, EventArgs e)
        {
            if (this.cmb_chamados.Text == "SistemaSegsal.DTO.ChamadoDTO" || this.cmb_chamados.Text == "")
            {
                return;
            }

            else
            {
                string[] codigoChamado = this.cmb_chamados.Text.Split(' ');
                chmDto.Codigo = codigoChamado[0];

                List<ChamadoDTO> chamado = chmBll.SelecionarChamado(chmDto);

                this.txt_valorUnitario.Text = chamado[0].ValorTotal.ToString();
                this.txt_valorTotal.Text = chamado[0].ValorTotal.ToString();

                string proposta = chamado[0].Proposta; ;
                string statusCh = chamado[0].Status;

                if(proposta == "-")
                {
                    this.lbl_mensagemChamado.Text = "";
                    return;
                }
                else
                {
                    this.lbl_mensagemChamado.Text = "Chamado já vinculado à Proposta Comercial " + proposta;
                }
            }
        }

        private void cmb_chamados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_tipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvw_listaServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
