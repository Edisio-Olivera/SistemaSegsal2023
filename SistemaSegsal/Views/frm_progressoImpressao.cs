using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.View;

namespace SistemaSegsal.Views
{
    public partial class frm_progressoImpressao : Form
    {
        public frm_progressoImpressao()
        {
            InitializeComponent();
        }

        private void frm_progressoImpressao_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Int32 tamBarra = 400 / 4;

            this.progressBar1.Increment(1);
            this.label1.Text = this.progressBar1.Value.ToString() + "%";
            //this.label1.Location = new Point(40 + (progressBar1.Value * 4), 195);

            //for (Int32 x = progressBar1.Value; x <= 100; this.progressBar1.Increment(1))
            //{
            //    this.label1.Text = x.ToString() + "%";

            //    if (progressBar1.Value < 25)
            //    {
            //        this.label2.Text = "Carregando dados...";
            //    }

            //    if (progressBar1.Value < 50 || progressBar1.Value > 25)
            //    {
            //        this.label2.Text = "Formatando página...";
            //    }

            //    if (progressBar1.Value < 75 || progressBar1.Value > 50)
            //    {
            //        this.label2.Text = "Criando pdf...";
            //    }

            //    if (progressBar1.Value < 100 || progressBar1.Value > 75)
            //    {
            //        this.label2.Text = "Finalizando...";
            //    }
            //}


            


            if (this.progressBar1.Value == 100)
            {
                this.timer1.Stop();
                this.Hide();
                MessageBox.Show("Impressão concluída com sucesso!", "Impressão", MessageBoxButtons.OK, MessageBoxIcon.Information);

                frm_listaPropostaComercial.propostaInstancia.EstadoInicial();
            }

        }
    }
}
