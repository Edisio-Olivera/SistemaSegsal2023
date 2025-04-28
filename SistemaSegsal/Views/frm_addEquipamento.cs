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
    public partial class frm_addEquipamento : Form
    {




        private void SalvarEquipamento()
        {

        }

        private void SalvarModeloEquipamento()
        {

        }












        public frm_addEquipamento(Int32 id)
        {
            InitializeComponent();

            this.txt_id.Text = id.ToString();
        }

        public frm_addEquipamento()
        {
            InitializeComponent();
        }

        private void frm_addEquipamento_Load(object sender, EventArgs e)
        {

        }
    }
}
