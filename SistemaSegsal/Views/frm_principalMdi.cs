using SistemaSegsal.View;
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
    public partial class frm_principalMdi : Form
    {
        private int childFormNumber = 0;

        public static frm_principalMdi principalInstancia;

        public frm_principalMdi()
        {
            InitializeComponent();

            principalInstancia = this;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Janela " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void frm_principalMdi_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI;

            foreach(Control ctl in this.Controls)
            {
                try
                {
                    ctlMDI = (MdiClient)ctl;

                    ctlMDI.BackgroundImage = Properties.Resources.BackgroundSys;
                }
                catch (Exception)
                {

                }
            }

            //this.Icon = Icon.FromHandle(Application.StartupPath + @"\Imagens\Sistema\iconeSistema.ico");
        }

        private void propostasComerciaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Application.OpenForms.OfType<frm_listaPropostaComercial>().Count()>0)
            {
                MessageBox.Show("O Formulário Propostas Comerciais já está aberto!", "Formulário Aberto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {                    
                var prop = new frm_listaPropostaComercial();
                //prop.MdiParent = this;
                prop.Show();
            }
        }

        private void notasFiscaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_listaNotaFiscal>().Count() > 0)
            {
                MessageBox.Show("O Formulário Notas Fiscais já está aberto!", "Formulário Aberto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var not = new frm_listaNotaFiscal();
                not.MdiParent = this;
                not.Show();
            }
        }

        private void chamadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frm_listaChamado>().Count() > 0)
            {
                MessageBox.Show("O Formulário Chamados já está aberto!", "Formulário Aberto!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var chm = new frm_listaChamado();
                chm.MdiParent = this;
                chm.Show();
            }
        }
    }
}
