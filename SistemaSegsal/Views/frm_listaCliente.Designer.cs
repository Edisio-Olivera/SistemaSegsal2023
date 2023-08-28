
namespace SistemaSegsal.Views
{
    partial class frm_listaCliente
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.lvw_listaClientes = new System.Windows.Forms.ListView();
            this.label20 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.img_logomarca = new System.Windows.Forms.PictureBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_base = new System.Windows.Forms.Button();
            this.btn_contato = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logomarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 30);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.img_logoEmpresa);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 80);
            this.panel1.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(326, 10);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(144, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Clientes";
            // 
            // lvw_listaClientes
            // 
            this.lvw_listaClientes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaClientes.FullRowSelect = true;
            this.lvw_listaClientes.GridLines = true;
            this.lvw_listaClientes.HideSelection = false;
            this.lvw_listaClientes.Location = new System.Drawing.Point(32, 386);
            this.lvw_listaClientes.Name = "lvw_listaClientes";
            this.lvw_listaClientes.Size = new System.Drawing.Size(672, 313);
            this.lvw_listaClientes.TabIndex = 4;
            this.lvw_listaClientes.UseCompatibleStateImageBehavior = false;
            this.lvw_listaClientes.View = System.Windows.Forms.View.Details;
            this.lvw_listaClientes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaClientes_ItemSelectionChanged);
            this.lvw_listaClientes.SelectedIndexChanged += new System.EventHandler(this.lvw_listaClientes_SelectedIndexChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(579, 147);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(67, 15);
            this.label20.TabIndex = 50;
            this.label20.Text = "Logomarca";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 15);
            this.label5.TabIndex = 39;
            this.label5.Text = "Lista de Clientes";
            // 
            // img_logomarca
            // 
            this.img_logomarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_logomarca.Location = new System.Drawing.Point(582, 165);
            this.img_logomarca.Name = "img_logomarca";
            this.img_logomarca.Size = new System.Drawing.Size(167, 147);
            this.img_logomarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logomarca.TabIndex = 46;
            this.img_logomarca.TabStop = false;
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
            this.btn_atualizar.Location = new System.Drawing.Point(339, 223);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 70);
            this.btn_atualizar.TabIndex = 48;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
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
            this.btn_salvar.Location = new System.Drawing.Point(258, 223);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 70);
            this.btn_salvar.TabIndex = 47;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(501, 223);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 70);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_editar.Location = new System.Drawing.Point(177, 299);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 70);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
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
            this.btn_deletar.Location = new System.Drawing.Point(258, 299);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 70);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_base
            // 
            this.btn_base.BackColor = System.Drawing.Color.Navy;
            this.btn_base.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_base.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_base.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_base.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_base.Image = global::SistemaSegsal.Properties.Resources.base3;
            this.btn_base.Location = new System.Drawing.Point(339, 299);
            this.btn_base.Name = "btn_base";
            this.btn_base.Size = new System.Drawing.Size(75, 70);
            this.btn_base.TabIndex = 3;
            this.btn_base.UseVisualStyleBackColor = false;
            this.btn_base.Click += new System.EventHandler(this.btn_base_Click);
            // 
            // btn_contato
            // 
            this.btn_contato.BackColor = System.Drawing.Color.Navy;
            this.btn_contato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_contato.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_contato.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_contato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_contato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_contato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_contato.Image = global::SistemaSegsal.Properties.Resources.contato;
            this.btn_contato.Location = new System.Drawing.Point(420, 299);
            this.btn_contato.Name = "btn_contato";
            this.btn_contato.Size = new System.Drawing.Size(75, 70);
            this.btn_contato.TabIndex = 2;
            this.btn_contato.Tag = "";
            this.btn_contato.UseVisualStyleBackColor = false;
            this.btn_contato.Click += new System.EventHandler(this.btn_contato_Click);
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
            this.btn_sair.Location = new System.Drawing.Point(501, 299);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 70);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.btn_novo.Location = new System.Drawing.Point(420, 223);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 70);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(144, 80);
            this.img_logoEmpresa.TabIndex = 51;
            this.img_logoEmpresa.TabStop = false;
            // 
            // frm_listaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 701);
            this.Controls.Add(this.img_logomarca);
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lvw_listaClientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_base);
            this.Controls.Add(this.btn_contato);
            this.Name = "frm_listaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listaCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logomarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_base;
        private System.Windows.Forms.Button btn_contato;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.ListView lvw_listaClientes;
        private System.Windows.Forms.PictureBox img_logomarca;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
    }
}