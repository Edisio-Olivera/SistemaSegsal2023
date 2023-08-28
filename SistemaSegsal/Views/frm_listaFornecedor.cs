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
using SistemaSegsal.DTO;
using SistemaSegsal.BLL;

namespace SistemaSegsal.Views
{
    public partial class frm_listaFornecedor : Form
    {
        public frm_listaFornecedor()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja realmente Sair deste formulário?", "Sair!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frm_principal prin = new frm_principal();
                prin.Visible = true;

                this.Close();
            }
        }
    }
}
