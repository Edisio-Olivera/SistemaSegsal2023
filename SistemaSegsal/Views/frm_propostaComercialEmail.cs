using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace SistemaSegsal.Views
{
    public partial class frm_propostaComercialEmail : Form
    {

        private void EnviarEmail()
        {
            try
            {
                using (SmtpClient smtp = new SmtpClient())
                {
                    using (MailMessage email = new MailMessage())
                    {
                        //Servidor SMTP
                        smtp.Host = "smtp.gmail.com";
                        smtp.UseDefaultCredentials = false;
                        smtp.Credentials = new System.Net.NetworkCredential("segsal.seguranca@gmail.com", "segsal");
                        smtp.Port = 587;
                        smtp.EnableSsl = true;

                        //Email (Mensagem)
                        email.From = new MailAddress(this.txt_remetente.Text);
                        email.To.Add(this.txt_destinatario.Text);
                        email.Subject = this.txt_assunto.Text;
                        email.IsBodyHtml = false;
                        email.Body = txt_mensagem.Text;

                        //Enviar email
                        smtp.Send(email);
                    }
                }

                MessageBox.Show("Email enviado com sucesso!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }



        public frm_propostaComercialEmail()
        {
            InitializeComponent();
        }

        public frm_propostaComercialEmail(string remetente, string assunto, string mensagem)
        {
            InitializeComponent();

            this.txt_remetente.Text = remetente;
            this.txt_assunto.Text = assunto;
            this.txt_mensagem.Text = mensagem;
        }

        private void frm_propostaComercialEmail_Load(object sender, EventArgs e)
        {

        }

        private void btn_enviarEmail_Click(object sender, EventArgs e)
        {
            this.EnviarEmail();
        }
    }
}
