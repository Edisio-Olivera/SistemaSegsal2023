
namespace SistemaSegsal.View
{
    partial class frm_listaContatoCliente
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmb_departamento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.cbx_status = new System.Windows.Forms.CheckBox();
            this.lvw_listaContatos = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.img_logomarca = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logomarca)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 30);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1363, 80);
            this.panel1.TabIndex = 2;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Navy;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(607, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 70);
            this.btn_editar.TabIndex = 40;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(24, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(159, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Contatos";
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Navy;
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar;
            this.btn_deletar.Location = new System.Drawing.Point(688, 3);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 70);
            this.btn_deletar.TabIndex = 39;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(853, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 70);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Navy;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(445, 3);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 70);
            this.btn_novo.TabIndex = 38;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar2;
            this.btn_atualizar.Location = new System.Drawing.Point(934, 5);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 70);
            this.btn_atualizar.TabIndex = 5;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Navy;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(1258, 5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 70);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Navy;
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar;
            this.btn_salvar.Location = new System.Drawing.Point(772, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 70);
            this.btn_salvar.TabIndex = 2;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(26, 87);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(75, 23);
            this.txt_id.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 111);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Departamento";
            // 
            // cmb_departamento
            // 
            this.cmb_departamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_departamento.FormattingEnabled = true;
            this.cmb_departamento.Location = new System.Drawing.Point(527, 128);
            this.cmb_departamento.Name = "cmb_departamento";
            this.cmb_departamento.Size = new System.Drawing.Size(251, 23);
            this.cmb_departamento.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(104, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Nome";
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nome.Location = new System.Drawing.Point(107, 87);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(414, 23);
            this.txt_nome.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(152, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "E-mail";
            // 
            // txt_email
            // 
            this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txt_email.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(155, 128);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(366, 23);
            this.txt_email.TabIndex = 5;
            // 
            // txt_telefone
            // 
            this.txt_telefone.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefone.Location = new System.Drawing.Point(26, 128);
            this.txt_telefone.Mask = "(##)#####-####";
            this.txt_telefone.Name = "txt_telefone";
            this.txt_telefone.Size = new System.Drawing.Size(123, 23);
            this.txt_telefone.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.img_logomarca);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.cbx_status);
            this.groupBox1.Controls.Add(this.txt_id);
            this.groupBox1.Controls.Add(this.txt_telefone);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_departamento);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txt_nome);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1301, 184);
            this.groupBox1.TabIndex = 35;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Contato";
            // 
            // txt_cliente
            // 
            this.txt_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(26, 45);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(282, 23);
            this.txt_cliente.TabIndex = 0;
            // 
            // cbx_status
            // 
            this.cbx_status.AutoSize = true;
            this.cbx_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_status.Location = new System.Drawing.Point(784, 132);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(53, 19);
            this.cbx_status.TabIndex = 35;
            this.cbx_status.Text = "Ativo";
            this.cbx_status.UseVisualStyleBackColor = true;
            // 
            // lvw_listaContatos
            // 
            this.lvw_listaContatos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaContatos.FullRowSelect = true;
            this.lvw_listaContatos.GridLines = true;
            this.lvw_listaContatos.HideSelection = false;
            this.lvw_listaContatos.Location = new System.Drawing.Point(30, 382);
            this.lvw_listaContatos.Name = "lvw_listaContatos";
            this.lvw_listaContatos.Size = new System.Drawing.Size(1303, 314);
            this.lvw_listaContatos.TabIndex = 36;
            this.lvw_listaContatos.UseCompatibleStateImageBehavior = false;
            this.lvw_listaContatos.View = System.Windows.Forms.View.Details;
            this.lvw_listaContatos.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaContatos_ItemSelectionChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(27, 364);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 15);
            this.label12.TabIndex = 37;
            this.label12.Text = "Lista de Contatos";
            // 
            // img_logomarca
            // 
            this.img_logomarca.Location = new System.Drawing.Point(1114, 22);
            this.img_logomarca.Name = "img_logomarca";
            this.img_logomarca.Size = new System.Drawing.Size(167, 147);
            this.img_logomarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logomarca.TabIndex = 47;
            this.img_logomarca.TabStop = false;
            // 
            // frm_listaContatoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1363, 719);
            this.Controls.Add(this.lvw_listaContatos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_listaContatoCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listaContatoCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaContatoCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logomarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb_departamento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.MaskedTextBox txt_telefone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbx_status;
        private System.Windows.Forms.ListView lvw_listaContatos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.PictureBox img_logomarca;
    }
}