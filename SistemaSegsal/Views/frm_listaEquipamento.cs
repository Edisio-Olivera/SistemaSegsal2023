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
using System.Threading;

namespace SistemaSegsal.Views
{
    public partial class frm_listaEquipamento : Form
    {
        EquipamentoDTO dto = new EquipamentoDTO();
        EquipamentoBLL bll = new EquipamentoBLL();

        EquipamentoCategoriaDTO catDto = new EquipamentoCategoriaDTO();
        EquipamentoCategoriaBLL catBll = new EquipamentoCategoriaBLL();

        UnidadeDTO uniDto = new UnidadeDTO();
        UnidadeBLL uniBll = new UnidadeBLL();

        Thread t1;

        Int32 id;
        string categoria;
        string fabricante;
        string unidade;
        string modelo;
        string ncm;
        Int32 estoque;
        Int32 valorCompra;
        Int32 valorVenda;
        string imagem;

        private void abrirFormAddEquipamentoNovo(object obj)
        {
            Application.Run(new frm_addEquipamento(id));
        }

        private void EstadoInicial()
        {

        }

        private void CriarNovoEquipamento()
        {
            bll.CriarNovoEquipamento(dto);

            id = dto.Id;



        }

        private void EditarEquipamnto()
        {

        }

        private void ExcluirEquipamento()
        {

        }

        private void SelecionarEquipamento()
        {

        }


        private void PopularComboboxCategoria()
        {
            List<EquipamentoCategoriaDTO> cat = catBll.PopularComboboxEquipamentoCategoria();

            this.cmb_categoria.DataSource = cat;
            this.cmb_categoria.DisplayMember = "categoria";
            this.cmb_categoria.Text = "";
        }

        private void ListarEquipamento()
        {
            string[] item = new string[6];
            int prox = 1;

            var listaEquipamento = bll.ListarEquipamento();

            this.lvw_listaEquipamento.Items.Clear();

            foreach (EquipamentoDTO cat in listaEquipamento)
            {
                item[0] = cat.Id.ToString();
                item[1] = prox.ToString();
                item[2] = cat.Categoria;
                //item[3] = cat.Descritivo;
                item[4] = cat.Ncm;
                item[5] = cat.Estoque.ToString();
                item[4] = cat.ValorCompra.ToString("R$ #,##0.00");
                item[5] = cat.ValorVenda.ToString("R$ #,##0.00");

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
            }
        }

        private void ListarEquipamentoCategoria(string categoria)
        {
            dto.Categoria = categoria;

            string[] item = new string[6];
            int prox = 1;

            var listaEquipamento = bll.ListarEquipamentoCategoria(dto);

            this.lvw_listaEquipamento.Items.Clear();

            foreach (EquipamentoDTO cat in listaEquipamento)
            {
                item[0] = cat.Id.ToString();
                item[1] = prox.ToString();
                item[2] = cat.Categoria;
                //item[3] = cat.Descritivo;
                item[4] = cat.Ncm;
                item[5] = cat.Estoque.ToString();
                item[4] = cat.ValorCompra.ToString("R$ #,##0.00");
                item[5] = cat.ValorVenda.ToString("R$ #,##0.00");

                lvw_listaEquipamento.Items.Add(new ListViewItem(item));
                prox++;
            }
        }








        public frm_listaEquipamento()
        {
            InitializeComponent();
        }

        private void frm_listaEquipamento_Load(object sender, EventArgs e)
        {






            this.lvw_listaEquipamento.Columns.Add("Id", 0).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Item", 60).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Categoria", 235).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("Descrição", 570).TextAlign = HorizontalAlignment.Left;
            this.lvw_listaEquipamento.Columns.Add("NCM", 100).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Estoque", 100).TextAlign = HorizontalAlignment.Center;
            this.lvw_listaEquipamento.Columns.Add("Valor Compra", 100).TextAlign = HorizontalAlignment.Right;
            this.lvw_listaEquipamento.Columns.Add("Valor Venda", 100).TextAlign = HorizontalAlignment.Right;

            this.PopularComboboxCategoria();
            this.ListarEquipamento();
            
        }

        private void btn_novo_Click(object sender, EventArgs e)
        {
            this.CriarNovoEquipamento();

            this.Close();
            t1 = new Thread(abrirFormAddEquipamentoNovo);
            t1.SetApartmentState(ApartmentState.STA);
            t1.Start();
        }
    }
}
