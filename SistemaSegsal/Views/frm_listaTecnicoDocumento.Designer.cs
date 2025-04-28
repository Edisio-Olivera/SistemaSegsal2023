namespace SistemaSegsal.Views
{
    partial class frm_listaTecnicoDocumento
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
            this.lbl_lista = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lvw_listaDocumento = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.gpb_tecnico = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_nomeTecnico = new System.Windows.Forms.TextBox();
            this.txt_codigoTecnico = new System.Windows.Forms.TextBox();
            this.gpb_documento = new System.Windows.Forms.GroupBox();
            this.dtp_dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataRealizado = new System.Windows.Forms.DateTimePicker();
            this.cmb_documento = new System.Windows.Forms.ComboBox();
            this.lbl_dataVencimento = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_documento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_tipoDocumento = new System.Windows.Forms.ComboBox();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.txt_diasVencimento = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.lbl_diasVencer = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.gpb_tecnico.SuspendLayout();
            this.gpb_documento.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_lista
            // 
            this.lbl_lista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_lista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_lista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lista.Location = new System.Drawing.Point(35, 340);
            this.lbl_lista.Name = "lbl_lista";
            this.lbl_lista.Size = new System.Drawing.Size(1300, 23);
            this.lbl_lista.TabIndex = 34;
            this.lbl_lista.Text = "Lista de Documentos";
            this.lbl_lista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.btn_editar.Location = new System.Drawing.Point(534, 6);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 55);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "     Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar25;
            this.btn_deletar.Location = new System.Drawing.Point(489, 7);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(150, 55);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Text = "     Excluir";
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 50);
            this.panel2.TabIndex = 33;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar25;
            this.btn_atualizar.Location = new System.Drawing.Point(819, 7);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(150, 55);
            this.btn_atualizar.TabIndex = 16;
            this.btn_atualizar.Text = "     Atualizar";
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair25;
            this.btn_sair.Location = new System.Drawing.Point(1158, 5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(150, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "     Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(80, 6);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(384, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Documentos do Técnico";
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo25;
            this.btn_novo.Location = new System.Drawing.Point(690, 6);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(150, 55);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "     Novo";
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar25;
            this.btn_cancelar.Location = new System.Drawing.Point(1002, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar25;
            this.btn_salvar.Location = new System.Drawing.Point(846, 6);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(150, 55);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "     Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 65);
            this.panel1.TabIndex = 32;
            // 
            // lvw_listaDocumento
            // 
            this.lvw_listaDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaDocumento.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaDocumento.FullRowSelect = true;
            this.lvw_listaDocumento.GridLines = true;
            this.lvw_listaDocumento.HideSelection = false;
            this.lvw_listaDocumento.Location = new System.Drawing.Point(35, 366);
            this.lvw_listaDocumento.Name = "lvw_listaDocumento";
            this.lvw_listaDocumento.Size = new System.Drawing.Size(1300, 292);
            this.lvw_listaDocumento.TabIndex = 29;
            this.lvw_listaDocumento.UseCompatibleStateImageBehavior = false;
            this.lvw_listaDocumento.View = System.Windows.Forms.View.Details;
            this.lvw_listaDocumento.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaDocumento_ItemSelectionChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(287, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nome";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gpb_tecnico
            // 
            this.gpb_tecnico.BackColor = System.Drawing.Color.White;
            this.gpb_tecnico.Controls.Add(this.label1);
            this.gpb_tecnico.Controls.Add(this.label11);
            this.gpb_tecnico.Controls.Add(this.txt_nomeTecnico);
            this.gpb_tecnico.Controls.Add(this.txt_codigoTecnico);
            this.gpb_tecnico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_tecnico.ForeColor = System.Drawing.Color.Black;
            this.gpb_tecnico.Location = new System.Drawing.Point(35, 130);
            this.gpb_tecnico.Name = "gpb_tecnico";
            this.gpb_tecnico.Size = new System.Drawing.Size(1300, 76);
            this.gpb_tecnico.TabIndex = 30;
            this.gpb_tecnico.TabStop = false;
            this.gpb_tecnico.Text = "Dados do Técnico";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Código";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_nomeTecnico
            // 
            this.txt_nomeTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_nomeTecnico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeTecnico.ForeColor = System.Drawing.Color.Black;
            this.txt_nomeTecnico.Location = new System.Drawing.Point(412, 33);
            this.txt_nomeTecnico.Name = "txt_nomeTecnico";
            this.txt_nomeTecnico.Size = new System.Drawing.Size(331, 23);
            this.txt_nomeTecnico.TabIndex = 16;
            // 
            // txt_codigoTecnico
            // 
            this.txt_codigoTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigoTecnico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoTecnico.ForeColor = System.Drawing.Color.Black;
            this.txt_codigoTecnico.Location = new System.Drawing.Point(158, 33);
            this.txt_codigoTecnico.Name = "txt_codigoTecnico";
            this.txt_codigoTecnico.Size = new System.Drawing.Size(123, 23);
            this.txt_codigoTecnico.TabIndex = 7;
            this.txt_codigoTecnico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gpb_documento
            // 
            this.gpb_documento.BackColor = System.Drawing.Color.White;
            this.gpb_documento.Controls.Add(this.lbl_diasVencer);
            this.gpb_documento.Controls.Add(this.lbl_status);
            this.gpb_documento.Controls.Add(this.dtp_dataVencimento);
            this.gpb_documento.Controls.Add(this.dtp_dataRealizado);
            this.gpb_documento.Controls.Add(this.cmb_documento);
            this.gpb_documento.Controls.Add(this.lbl_dataVencimento);
            this.gpb_documento.Controls.Add(this.label7);
            this.gpb_documento.Controls.Add(this.label5);
            this.gpb_documento.Controls.Add(this.lbl_documento);
            this.gpb_documento.Controls.Add(this.label2);
            this.gpb_documento.Controls.Add(this.label6);
            this.gpb_documento.Controls.Add(this.cmb_tipoDocumento);
            this.gpb_documento.Controls.Add(this.txt_observacao);
            this.gpb_documento.Controls.Add(this.txt_diasVencimento);
            this.gpb_documento.Controls.Add(this.txt_id);
            this.gpb_documento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpb_documento.ForeColor = System.Drawing.Color.Black;
            this.gpb_documento.Location = new System.Drawing.Point(35, 220);
            this.gpb_documento.Name = "gpb_documento";
            this.gpb_documento.Size = new System.Drawing.Size(1300, 100);
            this.gpb_documento.TabIndex = 31;
            this.gpb_documento.TabStop = false;
            this.gpb_documento.Text = "Dados do Documento";
            // 
            // dtp_dataVencimento
            // 
            this.dtp_dataVencimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataVencimento.Location = new System.Drawing.Point(412, 61);
            this.dtp_dataVencimento.Name = "dtp_dataVencimento";
            this.dtp_dataVencimento.Size = new System.Drawing.Size(120, 23);
            this.dtp_dataVencimento.TabIndex = 36;
            // 
            // dtp_dataRealizado
            // 
            this.dtp_dataRealizado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataRealizado.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataRealizado.Location = new System.Drawing.Point(161, 61);
            this.dtp_dataRealizado.Name = "dtp_dataRealizado";
            this.dtp_dataRealizado.Size = new System.Drawing.Size(120, 23);
            this.dtp_dataRealizado.TabIndex = 36;
            this.dtp_dataRealizado.ValueChanged += new System.EventHandler(this.dtp_dataRealizado_ValueChanged);
            // 
            // cmb_documento
            // 
            this.cmb_documento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_documento.FormattingEnabled = true;
            this.cmb_documento.Location = new System.Drawing.Point(749, 32);
            this.cmb_documento.Name = "cmb_documento";
            this.cmb_documento.Size = new System.Drawing.Size(322, 23);
            this.cmb_documento.TabIndex = 14;
            this.cmb_documento.SelectedValueChanged += new System.EventHandler(this.cmb_documento_SelectedValueChanged);
            // 
            // lbl_dataVencimento
            // 
            this.lbl_dataVencimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_dataVencimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dataVencimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataVencimento.Location = new System.Drawing.Point(286, 61);
            this.lbl_dataVencimento.Name = "lbl_dataVencimento";
            this.lbl_dataVencimento.Size = new System.Drawing.Size(120, 23);
            this.lbl_dataVencimento.TabIndex = 28;
            this.lbl_dataVencimento.Text = "Data Vencimento";
            this.lbl_dataVencimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(35, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 23);
            this.label7.TabIndex = 28;
            this.label7.Text = "Data Realizado";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(287, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 23);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo Documento";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_documento
            // 
            this.lbl_documento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_documento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_documento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_documento.Location = new System.Drawing.Point(624, 32);
            this.lbl_documento.Name = "lbl_documento";
            this.lbl_documento.Size = new System.Drawing.Size(119, 23);
            this.lbl_documento.TabIndex = 28;
            this.lbl_documento.Text = "Documento";
            this.lbl_documento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(624, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Observação";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 28;
            this.label6.Text = "Id";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_tipoDocumento
            // 
            this.cmb_tipoDocumento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_tipoDocumento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoDocumento.ForeColor = System.Drawing.Color.Black;
            this.cmb_tipoDocumento.FormattingEnabled = true;
            this.cmb_tipoDocumento.Location = new System.Drawing.Point(412, 32);
            this.cmb_tipoDocumento.Name = "cmb_tipoDocumento";
            this.cmb_tipoDocumento.Size = new System.Drawing.Size(204, 23);
            this.cmb_tipoDocumento.TabIndex = 5;
            this.cmb_tipoDocumento.SelectedValueChanged += new System.EventHandler(this.cmb_tipoDocumento_SelectedValueChanged);
            // 
            // txt_observacao
            // 
            this.txt_observacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_observacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacao.ForeColor = System.Drawing.Color.Black;
            this.txt_observacao.Location = new System.Drawing.Point(749, 61);
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(322, 23);
            this.txt_observacao.TabIndex = 7;
            // 
            // txt_diasVencimento
            // 
            this.txt_diasVencimento.BackColor = System.Drawing.Color.White;
            this.txt_diasVencimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diasVencimento.ForeColor = System.Drawing.Color.Black;
            this.txt_diasVencimento.Location = new System.Drawing.Point(548, 61);
            this.txt_diasVencimento.Name = "txt_diasVencimento";
            this.txt_diasVencimento.Size = new System.Drawing.Size(70, 23);
            this.txt_diasVencimento.TabIndex = 7;
            this.txt_diasVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(160, 32);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(121, 23);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1, 658);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(28, 36);
            this.button1.TabIndex = 35;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbl_status
            // 
            this.lbl_status.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_status.ForeColor = System.Drawing.Color.Red;
            this.lbl_status.Location = new System.Drawing.Point(1077, 61);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(217, 23);
            this.lbl_status.TabIndex = 37;
            this.lbl_status.Text = "status";
            this.lbl_status.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbl_diasVencer
            // 
            this.lbl_diasVencer.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_diasVencer.ForeColor = System.Drawing.Color.Red;
            this.lbl_diasVencer.Location = new System.Drawing.Point(1077, 32);
            this.lbl_diasVencer.Name = "lbl_diasVencer";
            this.lbl_diasVencer.Size = new System.Drawing.Size(217, 23);
            this.lbl_diasVencer.TabIndex = 37;
            this.lbl_diasVencer.Text = "dias";
            this.lbl_diasVencer.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // frm_listaTecnicoDocumento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 712);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_lista);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvw_listaDocumento);
            this.Controls.Add(this.gpb_tecnico);
            this.Controls.Add(this.gpb_documento);
            this.Name = "frm_listaTecnicoDocumento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addTecnicoDocumento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaTecnicoDocumento_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gpb_tecnico.ResumeLayout(false);
            this.gpb_tecnico.PerformLayout();
            this.gpb_documento.ResumeLayout(false);
            this.gpb_documento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_lista;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvw_listaDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpb_tecnico;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_nomeTecnico;
        private System.Windows.Forms.TextBox txt_codigoTecnico;
        private System.Windows.Forms.GroupBox gpb_documento;
        private System.Windows.Forms.ComboBox cmb_documento;
        private System.Windows.Forms.Label lbl_dataVencimento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_documento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_tipoDocumento;
        private System.Windows.Forms.TextBox txt_diasVencimento;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.DateTimePicker dtp_dataVencimento;
        private System.Windows.Forms.DateTimePicker dtp_dataRealizado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.Label lbl_diasVencer;
        private System.Windows.Forms.Label lbl_status;
    }
}