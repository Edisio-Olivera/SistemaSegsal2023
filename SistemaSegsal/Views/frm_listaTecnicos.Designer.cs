
namespace SistemaSegsal.Views
{
    partial class frm_listaTecnicos
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.txt_qtdProposta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_base = new System.Windows.Forms.Button();
            this.btn_epi = new System.Windows.Forms.Button();
            this.btn_documentos = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.txt_valorProposta = new System.Windows.Forms.TextBox();
            this.lvw_listaTecnico = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbx_inativo = new System.Windows.Forms.CheckBox();
            this.img_foto = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_servico = new System.Windows.Forms.Button();
            this.btn_enviarEmail = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(80, 6);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(148, 45);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Técnicos";
            // 
            // txt_qtdProposta
            // 
            this.txt_qtdProposta.BackColor = System.Drawing.Color.White;
            this.txt_qtdProposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qtdProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdProposta.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdProposta.Location = new System.Drawing.Point(816, 662);
            this.txt_qtdProposta.Name = "txt_qtdProposta";
            this.txt_qtdProposta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_qtdProposta.Size = new System.Drawing.Size(509, 16);
            this.txt_qtdProposta.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_editar);
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Controls.Add(this.img_logoEmpresa);
            this.panel3.Controls.Add(this.lbl_titulo);
            this.panel3.Controls.Add(this.btn_sair);
            this.panel3.Controls.Add(this.btn_novo);
            this.panel3.Controls.Add(this.btn_deletar);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1403, 65);
            this.panel3.TabIndex = 16;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.btn_editar.Location = new System.Drawing.Point(863, 6);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 55);
            this.btn_editar.TabIndex = 42;
            this.btn_editar.Text = "     Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelarR25;
            this.btn_cancelar.Location = new System.Drawing.Point(707, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 41;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Image = global::SistemaSegsal.Properties.Resources.recursosHumanos2;
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(70, 65);
            this.img_logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logoEmpresa.TabIndex = 41;
            this.img_logoEmpresa.TabStop = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair25;
            this.btn_sair.Location = new System.Drawing.Point(1175, 5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(150, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "     Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo25;
            this.btn_novo.Location = new System.Drawing.Point(551, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(150, 55);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.Text = "     Novo";
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar25;
            this.btn_deletar.Location = new System.Drawing.Point(1019, 5);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(150, 55);
            this.btn_deletar.TabIndex = 40;
            this.btn_deletar.Text = "     Deletar";
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1299, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lista de Propostas Comerciais";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_base);
            this.panel2.Controls.Add(this.btn_epi);
            this.panel2.Controls.Add(this.btn_documentos);
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 50);
            this.panel2.TabIndex = 25;
            // 
            // btn_base
            // 
            this.btn_base.AccessibleDescription = "";
            this.btn_base.AccessibleName = "";
            this.btn_base.BackColor = System.Drawing.Color.LightGray;
            this.btn_base.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_base.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_base.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_base.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_base.Image = global::SistemaSegsal.Properties.Resources.base25b;
            this.btn_base.Location = new System.Drawing.Point(396, 3);
            this.btn_base.Name = "btn_base";
            this.btn_base.Size = new System.Drawing.Size(150, 40);
            this.btn_base.TabIndex = 45;
            this.btn_base.Tag = "";
            this.btn_base.Text = "     Base";
            this.btn_base.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_base.UseVisualStyleBackColor = false;
            // 
            // btn_epi
            // 
            this.btn_epi.BackColor = System.Drawing.Color.LightGray;
            this.btn_epi.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_epi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_epi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_epi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_epi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_epi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_epi.Image = global::SistemaSegsal.Properties.Resources.servico25b;
            this.btn_epi.Location = new System.Drawing.Point(1175, 3);
            this.btn_epi.Name = "btn_epi";
            this.btn_epi.Size = new System.Drawing.Size(150, 40);
            this.btn_epi.TabIndex = 26;
            this.btn_epi.Text = "     EPI";
            this.btn_epi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_epi.UseVisualStyleBackColor = false;
            this.btn_epi.Click += new System.EventHandler(this.btn_epi_Click);
            // 
            // btn_documentos
            // 
            this.btn_documentos.AccessibleDescription = "";
            this.btn_documentos.AccessibleName = "";
            this.btn_documentos.BackColor = System.Drawing.Color.LightGray;
            this.btn_documentos.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_documentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_documentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_documentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_documentos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_documentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_documentos.Image = global::SistemaSegsal.Properties.Resources.documentos;
            this.btn_documentos.Location = new System.Drawing.Point(552, 3);
            this.btn_documentos.Name = "btn_documentos";
            this.btn_documentos.Size = new System.Drawing.Size(150, 40);
            this.btn_documentos.TabIndex = 43;
            this.btn_documentos.Tag = "";
            this.btn_documentos.Text = "     Documentos";
            this.btn_documentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_documentos.UseVisualStyleBackColor = false;
            this.btn_documentos.Click += new System.EventHandler(this.btn_documentos_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.LightGray;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_imprimir.Image = global::SistemaSegsal.Properties.Resources.imprimir25b;
            this.btn_imprimir.Location = new System.Drawing.Point(1020, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(150, 40);
            this.btn_imprimir.TabIndex = 38;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.Text = "     Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // txt_valorProposta
            // 
            this.txt_valorProposta.BackColor = System.Drawing.Color.White;
            this.txt_valorProposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorProposta.ForeColor = System.Drawing.Color.Black;
            this.txt_valorProposta.Location = new System.Drawing.Point(816, 691);
            this.txt_valorProposta.Name = "txt_valorProposta";
            this.txt_valorProposta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorProposta.Size = new System.Drawing.Size(509, 16);
            this.txt_valorProposta.TabIndex = 4;
            // 
            // lvw_listaTecnico
            // 
            this.lvw_listaTecnico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaTecnico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_listaTecnico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaTecnico.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaTecnico.FullRowSelect = true;
            this.lvw_listaTecnico.GridLines = true;
            this.lvw_listaTecnico.HideSelection = false;
            this.lvw_listaTecnico.Location = new System.Drawing.Point(30, 296);
            this.lvw_listaTecnico.Name = "lvw_listaTecnico";
            this.lvw_listaTecnico.Size = new System.Drawing.Size(1299, 349);
            this.lvw_listaTecnico.TabIndex = 2;
            this.lvw_listaTecnico.UseCompatibleStateImageBehavior = false;
            this.lvw_listaTecnico.View = System.Windows.Forms.View.Details;
            this.lvw_listaTecnico.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaTecnico_ItemSelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbx_inativo);
            this.panel1.Controls.Add(this.img_foto);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btn_servico);
            this.panel1.Controls.Add(this.btn_enviarEmail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txt_valorProposta);
            this.panel1.Controls.Add(this.txt_qtdProposta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lvw_listaTecnico);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 553);
            this.panel1.TabIndex = 14;
            // 
            // cbx_inativo
            // 
            this.cbx_inativo.AutoSize = true;
            this.cbx_inativo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_inativo.Location = new System.Drawing.Point(30, 238);
            this.cbx_inativo.Name = "cbx_inativo";
            this.cbx_inativo.Size = new System.Drawing.Size(70, 19);
            this.cbx_inativo.TabIndex = 33;
            this.cbx_inativo.Text = "Inativos";
            this.cbx_inativo.UseVisualStyleBackColor = true;
            this.cbx_inativo.CheckedChanged += new System.EventHandler(this.cbx_inativo_CheckedChanged);
            // 
            // img_foto
            // 
            this.img_foto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_foto.Location = new System.Drawing.Point(1238, 156);
            this.img_foto.Name = "img_foto";
            this.img_foto.Size = new System.Drawing.Size(91, 109);
            this.img_foto.TabIndex = 32;
            this.img_foto.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1237, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 23);
            this.label3.TabIndex = 27;
            this.label3.Text = "Foto";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_servico
            // 
            this.btn_servico.BackColor = System.Drawing.Color.LightGray;
            this.btn_servico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servico.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_servico.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_servico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_servico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_servico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_servico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_servico.Image = global::SistemaSegsal.Properties.Resources.servico25b;
            this.btn_servico.Location = new System.Drawing.Point(898, 182);
            this.btn_servico.Name = "btn_servico";
            this.btn_servico.Size = new System.Drawing.Size(150, 40);
            this.btn_servico.TabIndex = 39;
            this.btn_servico.Text = "     Serviços";
            this.btn_servico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_servico.UseVisualStyleBackColor = false;
            // 
            // btn_enviarEmail
            // 
            this.btn_enviarEmail.AccessibleDescription = "";
            this.btn_enviarEmail.AccessibleName = "";
            this.btn_enviarEmail.BackColor = System.Drawing.Color.LightGray;
            this.btn_enviarEmail.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_enviarEmail.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_enviarEmail.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_enviarEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_enviarEmail.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enviarEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_enviarEmail.Image = global::SistemaSegsal.Properties.Resources.email25b;
            this.btn_enviarEmail.Location = new System.Drawing.Point(732, 167);
            this.btn_enviarEmail.Name = "btn_enviarEmail";
            this.btn_enviarEmail.Size = new System.Drawing.Size(150, 40);
            this.btn_enviarEmail.TabIndex = 44;
            this.btn_enviarEmail.Tag = "";
            this.btn_enviarEmail.Text = "     Enviar";
            this.btn_enviarEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_enviarEmail.UseVisualStyleBackColor = false;
            // 
            // frm_listaTecnicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 553);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaTecnicos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listaTecnicos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaTecnicos_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_foto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_base;
        private System.Windows.Forms.Button btn_epi;
        private System.Windows.Forms.Button btn_documentos;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_enviarEmail;
        private System.Windows.Forms.TextBox txt_qtdProposta;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_servico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_valorProposta;
        private System.Windows.Forms.ListView lvw_listaTecnico;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox img_foto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbx_inativo;
    }
}