using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaSegsal.Views;

namespace SistemaSegsal.Views
{
    public partial class calendarioChamadoInicio : Form
    {
        public calendarioChamadoInicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dataChamado = monthCalendar1.SelectionStart.ToShortDateString();

            frm_addChamado.calendInstancia.CaptarDataChamado(dataChamado);

            this.Visible = false;
        }
    }
}
