using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaSegsal.Views
{
    public partial class frm_listaChamadoAtendimento : Form
    {


        private void EstadoInicial()
        {

        }

        private void CriarNovoAtendimento()
        {

        }

        private void SalvarAtendimeno()
        {

        }

        private void EditarAtendimento()
        {

        }

        private void AtualizarAtendimento()
        {

        }

        private void DeletarAtendimento()
        {

        }



        public frm_listaChamadoAtendimento()
        {
            InitializeComponent();
        }

        public frm_listaChamadoAtendimento(string codigo, DateTime dataChamado, string localSetor, Int32 valor)
        {
            InitializeComponent();

            this.txt_codigo.Text = codigo;
            this.txt_dataChamado.Text = dataChamado.ToString();
            this.txt_local.Text = localSetor;
            this.txt_valor.Text = valor.ToString("#,##0.00");
        }

        private void frm_listaChamadoAtendimento_Load(object sender, EventArgs e)
        {

        }
    }
}
