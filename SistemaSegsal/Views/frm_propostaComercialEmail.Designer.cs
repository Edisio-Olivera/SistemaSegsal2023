
namespace SistemaSegsal.Views
{
    partial class frm_propostaComercialEmail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.txt_anexo = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_remetente = new System.Windows.Forms.TextBox();
            this.txt_destinatario = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txt_assunto = new System.Windows.Forms.TextBox();
            this.btn_enviarEmail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.BackColor = System.Drawing.Color.White;
            this.txt_mensagem.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_mensagem.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_mensagem.ForeColor = System.Drawing.Color.Black;
            this.txt_mensagem.Location = new System.Drawing.Point(157, 126);
            this.txt_mensagem.Multiline = true;
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(636, 64);
            this.txt_mensagem.TabIndex = 57;
            // 
            // txt_anexo
            // 
            this.txt_anexo.BackColor = System.Drawing.Color.White;
            this.txt_anexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_anexo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_anexo.ForeColor = System.Drawing.Color.Black;
            this.txt_anexo.Location = new System.Drawing.Point(157, 196);
            this.txt_anexo.Name = "txt_anexo";
            this.txt_anexo.Size = new System.Drawing.Size(465, 23);
            this.txt_anexo.TabIndex = 55;
            this.txt_anexo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(33, 126);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 64);
            this.textBox7.TabIndex = 44;
            this.textBox7.Text = "Mensagem";
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(33, 196);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(118, 23);
            this.textBox9.TabIndex = 40;
            this.textBox9.Text = " Anexo";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(33, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 35;
            this.textBox2.Text = " Destinatário";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(33, 39);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 46;
            this.textBox1.Text = " Remetente";
            // 
            // txt_remetente
            // 
            this.txt_remetente.BackColor = System.Drawing.Color.White;
            this.txt_remetente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_remetente.ForeColor = System.Drawing.Color.Black;
            this.txt_remetente.Location = new System.Drawing.Point(157, 39);
            this.txt_remetente.Name = "txt_remetente";
            this.txt_remetente.Size = new System.Drawing.Size(465, 23);
            this.txt_remetente.TabIndex = 34;
            // 
            // txt_destinatario
            // 
            this.txt_destinatario.BackColor = System.Drawing.Color.White;
            this.txt_destinatario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_destinatario.ForeColor = System.Drawing.Color.Black;
            this.txt_destinatario.Location = new System.Drawing.Point(157, 68);
            this.txt_destinatario.Name = "txt_destinatario";
            this.txt_destinatario.Size = new System.Drawing.Size(465, 23);
            this.txt_destinatario.TabIndex = 47;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(33, 97);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 39;
            this.textBox3.Text = " Assunto";
            // 
            // txt_assunto
            // 
            this.txt_assunto.BackColor = System.Drawing.Color.White;
            this.txt_assunto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_assunto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_assunto.ForeColor = System.Drawing.Color.Black;
            this.txt_assunto.Location = new System.Drawing.Point(157, 97);
            this.txt_assunto.Name = "txt_assunto";
            this.txt_assunto.Size = new System.Drawing.Size(636, 23);
            this.txt_assunto.TabIndex = 54;
            // 
            // btn_enviarEmail
            // 
            this.btn_enviarEmail.AccessibleDescription = "";
            this.btn_enviarEmail.AccessibleName = "";
            this.btn_enviarEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_enviarEmail.FlatAppearance.BorderSize = 0;
            this.btn_enviarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_enviarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_enviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviarEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviarEmail.ForeColor = System.Drawing.Color.White;
            this.btn_enviarEmail.Image = global::SistemaSegsal.Properties.Resources.email1;
            this.btn_enviarEmail.Location = new System.Drawing.Point(733, 215);
            this.btn_enviarEmail.Name = "btn_enviarEmail";
            this.btn_enviarEmail.Size = new System.Drawing.Size(60, 55);
            this.btn_enviarEmail.TabIndex = 58;
            this.btn_enviarEmail.Tag = "Cancelar";
            this.btn_enviarEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_enviarEmail.UseVisualStyleBackColor = false;
            this.btn_enviarEmail.Click += new System.EventHandler(this.btn_enviarEmail_Click);
            // 
            // frm_propostaComercialEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(851, 523);
            this.Controls.Add(this.btn_enviarEmail);
            this.Controls.Add(this.txt_mensagem);
            this.Controls.Add(this.txt_anexo);
            this.Controls.Add(this.txt_assunto);
            this.Controls.Add(this.txt_destinatario);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_remetente);
            this.Name = "frm_propostaComercialEmail";
            this.Text = "frm_propostaComercialEmail";
            this.Load += new System.EventHandler(this.frm_propostaComercialEmail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mensagem;
        private System.Windows.Forms.TextBox txt_anexo;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_remetente;
        private System.Windows.Forms.TextBox txt_destinatario;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txt_assunto;
        private System.Windows.Forms.Button btn_enviarEmail;
    }
}