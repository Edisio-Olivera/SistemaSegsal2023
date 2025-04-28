
namespace SistemaSegsal.Views
{
    partial class frm_addBaseCliente
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
            this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
            this.txt_cep = new System.Windows.Forms.MaskedTextBox();
            this.cbx_status = new System.Windows.Forms.CheckBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_inscEstadual = new System.Windows.Forms.TextBox();
            this.txt_codigoBase = new System.Windows.Forms.TextBox();
            this.cmb_cidade = new System.Windows.Forms.ComboBox();
            this.cmb_uf = new System.Windows.Forms.ComboBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_nomeBase = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_dataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.panel16 = new System.Windows.Forms.Panel();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_cnpj
            // 
            this.txt_cnpj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cnpj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cnpj.Location = new System.Drawing.Point(156, 390);
            this.txt_cnpj.Mask = "##,###,###/####-##";
            this.txt_cnpj.Name = "txt_cnpj";
            this.txt_cnpj.Size = new System.Drawing.Size(123, 23);
            this.txt_cnpj.TabIndex = 7;
            // 
            // txt_cep
            // 
            this.txt_cep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_cep.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cep.Location = new System.Drawing.Point(156, 360);
            this.txt_cep.Mask = "##,###-###";
            this.txt_cep.Name = "txt_cep";
            this.txt_cep.Size = new System.Drawing.Size(123, 23);
            this.txt_cep.TabIndex = 6;
            // 
            // cbx_status
            // 
            this.cbx_status.AutoSize = true;
            this.cbx_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_status.Location = new System.Drawing.Point(288, 424);
            this.cbx_status.Name = "cbx_status";
            this.cbx_status.Size = new System.Drawing.Size(55, 19);
            this.cbx_status.TabIndex = 9;
            this.cbx_status.Text = "Ativo";
            this.cbx_status.UseVisualStyleBackColor = true;
            // 
            // txt_bairro
            // 
            this.txt_bairro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_bairro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bairro.Location = new System.Drawing.Point(156, 300);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(533, 23);
            this.txt_bairro.TabIndex = 3;
            // 
            // txt_inscEstadual
            // 
            this.txt_inscEstadual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_inscEstadual.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inscEstadual.Location = new System.Drawing.Point(156, 420);
            this.txt_inscEstadual.Name = "txt_inscEstadual";
            this.txt_inscEstadual.Size = new System.Drawing.Size(123, 23);
            this.txt_inscEstadual.TabIndex = 8;
            // 
            // txt_codigoBase
            // 
            this.txt_codigoBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigoBase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigoBase.Location = new System.Drawing.Point(156, 120);
            this.txt_codigoBase.Name = "txt_codigoBase";
            this.txt_codigoBase.Size = new System.Drawing.Size(123, 23);
            this.txt_codigoBase.TabIndex = 43;
            // 
            // cmb_cidade
            // 
            this.cmb_cidade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_cidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cidade.FormattingEnabled = true;
            this.cmb_cidade.Location = new System.Drawing.Point(411, 331);
            this.cmb_cidade.Name = "cmb_cidade";
            this.cmb_cidade.Size = new System.Drawing.Size(278, 23);
            this.cmb_cidade.TabIndex = 5;
            // 
            // cmb_uf
            // 
            this.cmb_uf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_uf.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_uf.FormattingEnabled = true;
            this.cmb_uf.Location = new System.Drawing.Point(156, 330);
            this.cmb_uf.Name = "cmb_uf";
            this.cmb_uf.Size = new System.Drawing.Size(123, 23);
            this.cmb_uf.TabIndex = 4;
            this.cmb_uf.SelectedValueChanged += new System.EventHandler(this.cmb_uf_SelectedValueChanged);
            // 
            // txt_complemento
            // 
            this.txt_complemento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_complemento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_complemento.Location = new System.Drawing.Point(156, 270);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(533, 23);
            this.txt_complemento.TabIndex = 2;
            // 
            // txt_endereco
            // 
            this.txt_endereco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_endereco.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_endereco.Location = new System.Drawing.Point(156, 240);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(533, 23);
            this.txt_endereco.TabIndex = 1;
            // 
            // txt_nomeBase
            // 
            this.txt_nomeBase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_nomeBase.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nomeBase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nomeBase.Location = new System.Drawing.Point(156, 210);
            this.txt_nomeBase.Name = "txt_nomeBase";
            this.txt_nomeBase.Size = new System.Drawing.Size(533, 23);
            this.txt_nomeBase.TabIndex = 0;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(156, 90);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 23);
            this.txt_id.TabIndex = 43;
            // 
            // txt_dataRegistro
            // 
            this.txt_dataRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_dataRegistro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataRegistro.Location = new System.Drawing.Point(156, 150);
            this.txt_dataRegistro.Mask = "##/##/####";
            this.txt_dataRegistro.Name = "txt_dataRegistro";
            this.txt_dataRegistro.Size = new System.Drawing.Size(123, 23);
            this.txt_dataRegistro.TabIndex = 6;
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.Location = new System.Drawing.Point(156, 180);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(533, 23);
            this.txt_cliente.TabIndex = 43;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar25;
            this.btn_salvar.Location = new System.Drawing.Point(756, 2);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(150, 55);
            this.btn_salvar.TabIndex = 50;
            this.btn_salvar.Text = "     Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.btn_editar.Location = new System.Drawing.Point(600, 2);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 55);
            this.btn_editar.TabIndex = 51;
            this.btn_editar.Text = "     Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar25;
            this.btn_atualizar.Location = new System.Drawing.Point(444, 3);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(150, 55);
            this.btn_atualizar.TabIndex = 49;
            this.btn_atualizar.Text = "     Atualizar";
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelarR25;
            this.btn_cancelar.Location = new System.Drawing.Point(912, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 52;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel16.Controls.Add(this.img_logoEmpresa);
            this.panel16.Controls.Add(this.btn_cancelar);
            this.panel16.Controls.Add(this.btn_atualizar);
            this.panel16.Controls.Add(this.label4);
            this.panel16.Controls.Add(this.btn_editar);
            this.panel16.Controls.Add(this.btn_salvar);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.ForeColor = System.Drawing.Color.Navy;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1351, 65);
            this.panel16.TabIndex = 55;
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Image = global::SistemaSegsal.Properties.Resources.administrativo2;
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(70, 65);
            this.img_logoEmpresa.TabIndex = 53;
            this.img_logoEmpresa.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(80, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(229, 45);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cliente - Base";
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(30, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 23);
            this.label10.TabIndex = 56;
            this.label10.Text = "Id";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(30, 120);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(120, 23);
            this.label17.TabIndex = 56;
            this.label17.Text = "Código";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(30, 150);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(120, 23);
            this.label18.TabIndex = 56;
            this.label18.Text = "Data Registro";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 180);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 23);
            this.label19.TabIndex = 56;
            this.label19.Text = "Cliente";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(30, 209);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 23);
            this.label20.TabIndex = 56;
            this.label20.Text = "Nome Base";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(30, 239);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 23);
            this.label21.TabIndex = 56;
            this.label21.Text = "Endereço";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(30, 270);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(120, 23);
            this.label22.TabIndex = 56;
            this.label22.Text = "Complemento";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(30, 300);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 23);
            this.label23.TabIndex = 56;
            this.label23.Text = "Bairro";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(30, 331);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 23);
            this.label24.TabIndex = 56;
            this.label24.Text = "UF";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(30, 359);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 23);
            this.label25.TabIndex = 56;
            this.label25.Text = "CEP";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(30, 390);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 23);
            this.label26.TabIndex = 56;
            this.label26.Text = "CNPJ";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(30, 420);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 23);
            this.label27.TabIndex = 56;
            this.label27.Text = "Insc. Estadual";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(285, 331);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 23);
            this.label28.TabIndex = 56;
            this.label28.Text = "Cidade";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_addBaseCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1351, 661);
            this.ControlBox = false;
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.cbx_status);
            this.Controls.Add(this.txt_cnpj);
            this.Controls.Add(this.txt_inscEstadual);
            this.Controls.Add(this.txt_cep);
            this.Controls.Add(this.cmb_cidade);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.cmb_uf);
            this.Controls.Add(this.txt_codigoBase);
            this.Controls.Add(this.txt_dataRegistro);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_nomeBase);
            this.Controls.Add(this.txt_endereco);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addBaseCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão SEGSAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_addBaseCliente_Load);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MaskedTextBox txt_cnpj;
        private System.Windows.Forms.MaskedTextBox txt_cep;
        private System.Windows.Forms.CheckBox cbx_status;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_inscEstadual;
        private System.Windows.Forms.TextBox txt_codigoBase;
        private System.Windows.Forms.ComboBox cmb_cidade;
        private System.Windows.Forms.ComboBox cmb_uf;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_nomeBase;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.MaskedTextBox txt_dataRegistro;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
    }
}