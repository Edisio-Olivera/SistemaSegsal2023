
namespace SistemaSegsal.Views
{
    partial class frm_listaBaseCliente
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
            this.lvw_listaBasesCliente = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_contato = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.cbx_status = new System.Windows.Forms.CheckBox();
            this.dtp_dataRegistro = new System.Windows.Forms.DateTimePicker();
            this.cmb_uf = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nomeBase = new System.Windows.Forms.TextBox();
            this.txt_codigoBase = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nomeCliente = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_inscEstadual = new System.Windows.Forms.TextBox();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.img_logomarca = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logomarca)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_listaBasesCliente
            // 
            this.lvw_listaBasesCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaBasesCliente.FullRowSelect = true;
            this.lvw_listaBasesCliente.GridLines = true;
            this.lvw_listaBasesCliente.HideSelection = false;
            this.lvw_listaBasesCliente.Location = new System.Drawing.Point(32, 446);
            this.lvw_listaBasesCliente.Name = "lvw_listaBasesCliente";
            this.lvw_listaBasesCliente.Size = new System.Drawing.Size(1303, 255);
            this.lvw_listaBasesCliente.TabIndex = 7;
            this.lvw_listaBasesCliente.UseCompatibleStateImageBehavior = false;
            this.lvw_listaBasesCliente.View = System.Windows.Forms.View.Details;
            this.lvw_listaBasesCliente.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaBasesCliente_ItemSelectionChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1358, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_contato);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1358, 80);
            this.panel1.TabIndex = 5;
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
            this.btn_salvar.Location = new System.Drawing.Point(578, 5);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(75, 70);
            this.btn_salvar.TabIndex = 9;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
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
            this.btn_atualizar.Location = new System.Drawing.Point(677, 5);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(75, 70);
            this.btn_atualizar.TabIndex = 8;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(24, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(225, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Bases Cliente";
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
            this.btn_editar.Location = new System.Drawing.Point(934, 5);
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
            this.btn_deletar.Location = new System.Drawing.Point(1015, 5);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 70);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.UseVisualStyleBackColor = false;
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
            this.btn_contato.Image = global::SistemaSegsal.Properties.Resources.imprimir;
            this.btn_contato.Location = new System.Drawing.Point(1177, 5);
            this.btn_contato.Name = "btn_contato";
            this.btn_contato.Size = new System.Drawing.Size(75, 70);
            this.btn_contato.TabIndex = 2;
            this.btn_contato.Tag = "";
            this.btn_contato.UseVisualStyleBackColor = false;
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
            this.btn_novo.Location = new System.Drawing.Point(772, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 70);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // cbx_status
            // 
            this.cbx_status.AutoSize = true;
            this.cbx_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_status.Location = new System.Drawing.Point(427, 131);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(53, 19);
            this.cbx_status.TabIndex = 9;
            this.cbx_status.Text = "Ativo";
            this.cbx_status.UseVisualStyleBackColor = true;
            // 
            // dtp_dataRegistro
            // 
            this.dtp_dataRegistro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataRegistro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataRegistro.Location = new System.Drawing.Point(109, 47);
            this.dtp_dataRegistro.Name = "dtp_dataRegistro";
            this.dtp_dataRegistro.Size = new System.Drawing.Size(109, 23);
            this.dtp_dataRegistro.TabIndex = 35;
            // 
            // cmb_uf
            // 
            this.cmb_uf.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_uf.FormattingEnabled = true;
            this.cmb_uf.Location = new System.Drawing.Point(427, 88);
            this.cmb_uf.Name = "cmb_uf";
            this.cmb_uf.Size = new System.Drawing.Size(85, 23);
            this.cmb_uf.TabIndex = 4;
            this.cmb_uf.SelectedValueChanged += new System.EventHandler(this.cmb_uf_SelectedValueChanged);
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(26, 47);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 23);
            this.txt_codigo.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(109, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 15);
            this.label3.TabIndex = 42;
            this.label3.Text = "Data";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Código";
            // 
            // txt_nomeBase
            // 
            this.txt_nomeBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomeBase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeBase.Location = new System.Drawing.Point(155, 47);
            this.txt_nomeBase.Name = "txt_nomeBase";
            this.txt_nomeBase.Size = new System.Drawing.Size(357, 23);
            this.txt_nomeBase.TabIndex = 0;
            // 
            // txt_codigoBase
            // 
            this.txt_codigoBase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoBase.Location = new System.Drawing.Point(26, 47);
            this.txt_codigoBase.Name = "txt_codigoBase";
            this.txt_codigoBase.Size = new System.Drawing.Size(123, 23);
            this.txt_codigoBase.TabIndex = 43;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(152, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 15);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nome da Base";
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(28, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(75, 23);
            this.txt_id.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 15);
            this.label6.TabIndex = 38;
            this.label6.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "UF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(152, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Nome Fantasia";
            // 
            // txt_nomeCliente
            // 
            this.txt_nomeCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeCliente.Location = new System.Drawing.Point(155, 47);
            this.txt_nomeCliente.Name = "txt_nomeCliente";
            this.txt_nomeCliente.Size = new System.Drawing.Size(357, 23);
            this.txt_nomeCliente.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.img_logomarca);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_nomeCliente);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 131);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(643, 96);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Cliente";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_cnpj);
            this.groupBox2.Controls.Add(this.txt_cep);
            this.groupBox2.Controls.Add(this.cbx_status);
            this.groupBox2.Controls.Add(this.txt_bairro);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_inscEstadual);
            this.groupBox2.Controls.Add(this.txt_codigoBase);
            this.groupBox2.Controls.Add(this.cmb_cidade);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cmb_uf);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txt_complemento);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_endereco);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_nomeBase);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1303, 178);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados da Base do Cliente";
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.Location = new System.Drawing.Point(26, 129);
            this.txt_cnpj.Mask = "##,###,###/####-##";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(191, 23);
            this.txt_cnpj.TabIndex = 7;
            // 
            // txt_cep
            // 
            this.txt_cep.Location = new System.Drawing.Point(881, 88);
            this.txt_cep.Mask = "##,###-###";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(131, 23);
            this.txt_cep.TabIndex = 6;
            // 
            // txt_bairro
            // 
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(26, 88);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(395, 23);
            this.txt_bairro.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(23, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 15);
            this.label10.TabIndex = 38;
            this.label10.Text = "Bairro";
            // 
            // txt_inscEstadual
            // 
            this.txt_inscEstadual.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inscEstadual.Location = new System.Drawing.Point(222, 129);
            this.txt_inscEstadual.Name = "txt_inscEstadual";
            this.txt_inscEstadual.Size = new System.Drawing.Size(199, 23);
            this.txt_inscEstadual.TabIndex = 8;
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.Location = new System.Drawing.Point(518, 88);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(357, 23);
            this.cmb_cidade.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(515, 71);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 15);
            this.label11.TabIndex = 37;
            this.label11.Text = "Cidade";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(219, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 15);
            this.label14.TabIndex = 38;
            this.label14.Text = "Inscrição Estadual";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(23, 113);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 15);
            this.label13.TabIndex = 39;
            this.label13.Text = "CNPJ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(878, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 15);
            this.label12.TabIndex = 39;
            this.label12.Text = "CEP";
            // 
            // txt_complemento
            // 
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_complemento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complemento.Location = new System.Drawing.Point(881, 47);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(380, 23);
            this.txt_complemento.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(878, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 15);
            this.label9.TabIndex = 39;
            this.label9.Text = "Complemento";
            // 
            // txt_endereco
            // 
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(518, 47);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(357, 23);
            this.txt_endereco.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 15);
            this.label8.TabIndex = 39;
            this.label8.Text = "Endereço";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 428);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(142, 15);
            this.label15.TabIndex = 39;
            this.label15.Text = "Lista de Bases do Cliente";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtp_dataRegistro);
            this.groupBox3.Controls.Add(this.txt_id);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(681, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(247, 96);
            this.groupBox3.TabIndex = 48;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dados do Registro";
            // 
            // img_logomarca
            // 
            this.img_logomarca.Location = new System.Drawing.Point(530, 16);
            this.img_logomarca.Name = "img_logomarca";
            this.img_logomarca.Size = new System.Drawing.Size(91, 71);
            this.img_logomarca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logomarca.TabIndex = 42;
            this.img_logomarca.TabStop = false;
            // 
            // frm_listaBaseCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1358, 726);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvw_listaBasesCliente);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label15);
            this.Name = "frm_listaBaseCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listaBaseCliente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaBaseCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logomarca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvw_listaBasesCliente;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_contato;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.CheckBox cbx_status;
        private System.Windows.Forms.DateTimePicker dtp_dataRegistro;
        private System.Windows.Forms.ComboBox cmb_uf;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nomeBase;
        private System.Windows.Forms.TextBox txt_codigoBase;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nomeCliente;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_inscEstadual;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.PictureBox img_logomarca;
    }
}