
namespace SistemaSegsal.View
{
    partial class frm_listaPropostaComercial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listaPropostaComercial));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_listarTodas = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_aprovar = new System.Windows.Forms.Button();
            this.btn_cancelarP = new System.Windows.Forms.Button();
            this.btn_os = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_enviarEmail = new System.Windows.Forms.Button();
            this.btn_servico = new System.Windows.Forms.Button();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_valorProposta = new System.Windows.Forms.TextBox();
            this.txt_qtdProposta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.lvw_listaPropostaComercial = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_listarTodas);
            this.panel1.Controls.Add(this.btn_filtrar);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.txt_valorProposta);
            this.panel1.Controls.Add(this.txt_qtdProposta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lvw_listaPropostaComercial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 712);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_listarTodas
            // 
            this.btn_listarTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_listarTodas.FlatAppearance.BorderSize = 0;
            this.btn_listarTodas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_listarTodas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_listarTodas.ForeColor = System.Drawing.Color.White;
            this.btn_listarTodas.Location = new System.Drawing.Point(1209, 130);
            this.btn_listarTodas.Name = "btn_listarTodas";
            this.btn_listarTodas.Size = new System.Drawing.Size(120, 23);
            this.btn_listarTodas.TabIndex = 31;
            this.btn_listarTodas.Text = "Listar Todas";
            this.btn_listarTodas.UseVisualStyleBackColor = false;
            this.btn_listarTodas.Click += new System.EventHandler(this.btn_listarTodas_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_filtrar.FlatAppearance.BorderSize = 0;
            this.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.ForeColor = System.Drawing.Color.White;
            this.btn_filtrar.Location = new System.Drawing.Point(381, 130);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(120, 23);
            this.btn_filtrar.TabIndex = 30;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = false;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(583, 129);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(864, 130);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 28;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1299, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Lista de Propostas Comerciais";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_aprovar);
            this.panel2.Controls.Add(this.btn_cancelarP);
            this.panel2.Controls.Add(this.btn_os);
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Controls.Add(this.btn_enviarEmail);
            this.panel2.Controls.Add(this.btn_servico);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1369, 50);
            this.panel2.TabIndex = 25;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btn_aprovar
            // 
            this.btn_aprovar.AccessibleDescription = "";
            this.btn_aprovar.AccessibleName = "";
            this.btn_aprovar.BackColor = System.Drawing.Color.LightGray;
            this.btn_aprovar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_aprovar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_aprovar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_aprovar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aprovar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aprovar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_aprovar.Image = global::SistemaSegsal.Properties.Resources.ordem25b;
            this.btn_aprovar.Location = new System.Drawing.Point(396, 3);
            this.btn_aprovar.Name = "btn_aprovar";
            this.btn_aprovar.Size = new System.Drawing.Size(150, 40);
            this.btn_aprovar.TabIndex = 45;
            this.btn_aprovar.Tag = "";
            this.btn_aprovar.Text = "     Aprovar";
            this.btn_aprovar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_aprovar.UseVisualStyleBackColor = false;
            this.btn_aprovar.Click += new System.EventHandler(this.btn_aprovar_Click);
            // 
            // btn_cancelarP
            // 
            this.btn_cancelarP.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancelarP.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cancelarP.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cancelarP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cancelarP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarP.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelarP.Image = global::SistemaSegsal.Properties.Resources.cancelar25b;
            this.btn_cancelarP.Location = new System.Drawing.Point(1176, 5);
            this.btn_cancelarP.Name = "btn_cancelarP";
            this.btn_cancelarP.Size = new System.Drawing.Size(150, 40);
            this.btn_cancelarP.TabIndex = 26;
            this.btn_cancelarP.Text = "     Cancelar";
            this.btn_cancelarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelarP.UseVisualStyleBackColor = false;
            this.btn_cancelarP.Click += new System.EventHandler(this.btn_cancelarP_Click);
            // 
            // btn_os
            // 
            this.btn_os.AccessibleDescription = "";
            this.btn_os.AccessibleName = "";
            this.btn_os.BackColor = System.Drawing.Color.LightGray;
            this.btn_os.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_os.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_os.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_os.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_os.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_os.Image = global::SistemaSegsal.Properties.Resources.ordem25b;
            this.btn_os.Location = new System.Drawing.Point(552, 3);
            this.btn_os.Name = "btn_os";
            this.btn_os.Size = new System.Drawing.Size(150, 40);
            this.btn_os.TabIndex = 43;
            this.btn_os.Tag = "";
            this.btn_os.Text = "     Criar O.S.";
            this.btn_os.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_os.UseVisualStyleBackColor = false;
            this.btn_os.Click += new System.EventHandler(this.btn_os_Click);
            this.btn_os.MouseHover += new System.EventHandler(this.button1_MouseHover);
            this.btn_os.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
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
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click_1);
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
            this.btn_enviarEmail.Location = new System.Drawing.Point(708, 3);
            this.btn_enviarEmail.Name = "btn_enviarEmail";
            this.btn_enviarEmail.Size = new System.Drawing.Size(150, 40);
            this.btn_enviarEmail.TabIndex = 44;
            this.btn_enviarEmail.Tag = "";
            this.btn_enviarEmail.Text = "     Enviar";
            this.btn_enviarEmail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_enviarEmail.UseVisualStyleBackColor = false;
            this.btn_enviarEmail.Click += new System.EventHandler(this.btn_enviarEmail_Click);
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
            this.btn_servico.Location = new System.Drawing.Point(864, 3);
            this.btn_servico.Name = "btn_servico";
            this.btn_servico.Size = new System.Drawing.Size(150, 40);
            this.btn_servico.TabIndex = 39;
            this.btn_servico.Text = "     Serviços";
            this.btn_servico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_servico.UseVisualStyleBackColor = false;
            this.btn_servico.Click += new System.EventHandler(this.btn_servico_Click_1);
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.White;
            this.cmb_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.ForeColor = System.Drawing.Color.Black;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(155, 130);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(220, 23);
            this.cmb_status.TabIndex = 5;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
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
            this.txt_valorProposta.TextChanged += new System.EventHandler(this.txt_valorProposta_TextChanged);
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
            this.txt_qtdProposta.TextChanged += new System.EventHandler(this.txt_qtdProposta_TextChanged);
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
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click_1);
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
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click_1);
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Image = ((System.Drawing.Image)(resources.GetObject("img_logoEmpresa.Image")));
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(70, 65);
            this.img_logoEmpresa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_logoEmpresa.TabIndex = 41;
            this.img_logoEmpresa.TabStop = false;
            this.img_logoEmpresa.Click += new System.EventHandler(this.img_logoEmpresa_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.ForeColor = System.Drawing.Color.White;
            this.lbl_titulo.Location = new System.Drawing.Point(80, 6);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(349, 45);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Propostas Comerciais";
            this.lbl_titulo.Click += new System.EventHandler(this.lbl_titulo_Click);
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
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click_1);
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
            this.btn_deletar.Click += new System.EventHandler(this.btn_excluir_Click);
            // 
            // lvw_listaPropostaComercial
            // 
            this.lvw_listaPropostaComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaPropostaComercial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_listaPropostaComercial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaPropostaComercial.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaPropostaComercial.FullRowSelect = true;
            this.lvw_listaPropostaComercial.GridLines = true;
            this.lvw_listaPropostaComercial.HideSelection = false;
            this.lvw_listaPropostaComercial.Location = new System.Drawing.Point(30, 200);
            this.lvw_listaPropostaComercial.Name = "lvw_listaPropostaComercial";
            this.lvw_listaPropostaComercial.Size = new System.Drawing.Size(1299, 445);
            this.lvw_listaPropostaComercial.TabIndex = 2;
            this.lvw_listaPropostaComercial.UseCompatibleStateImageBehavior = false;
            this.lvw_listaPropostaComercial.View = System.Windows.Forms.View.Details;
            this.lvw_listaPropostaComercial.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaPropostaComercial_ItemSelectionChanged);
            this.lvw_listaPropostaComercial.SelectedIndexChanged += new System.EventHandler(this.lvw_listaPropostaComercial_SelectedIndexChanged);
            this.lvw_listaPropostaComercial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvw_listaPropostaComercial_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Lista de Propostas Comerciais";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // frm_listaPropostaComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1355, 712);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaPropostaComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Propostas Comerciais";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaPropostaComercial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvw_listaPropostaComercial;
        private System.Windows.Forms.TextBox txt_qtdProposta;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_valorProposta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_servico;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_os;
        private System.Windows.Forms.Button btn_enviarEmail;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_cancelarP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_aprovar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.Button btn_listarTodas;
    }
}