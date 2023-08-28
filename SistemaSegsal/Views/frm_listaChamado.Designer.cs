
namespace SistemaSegsal.Views
{
    partial class frm_listaChamado
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
            this.lvw_listaChamados = new System.Windows.Forms.ListView();
            this.btn_cancelarChamado = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.txt_valorChamado = new System.Windows.Forms.TextBox();
            this.txt_qtdChamado = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_listaChamados
            // 
            this.lvw_listaChamados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaChamados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaChamados.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaChamados.FullRowSelect = true;
            this.lvw_listaChamados.GridLines = true;
            this.lvw_listaChamados.HideSelection = false;
            this.lvw_listaChamados.Location = new System.Drawing.Point(28, 292);
            this.lvw_listaChamados.Name = "lvw_listaChamados";
            this.lvw_listaChamados.Size = new System.Drawing.Size(1309, 418);
            this.lvw_listaChamados.TabIndex = 2;
            this.lvw_listaChamados.UseCompatibleStateImageBehavior = false;
            this.lvw_listaChamados.View = System.Windows.Forms.View.Details;
            this.lvw_listaChamados.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaChamados_ItemSelectionChanged);
            // 
            // btn_cancelarChamado
            // 
            this.btn_cancelarChamado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelarChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarChamado.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelarChamado.FlatAppearance.BorderSize = 0;
            this.btn_cancelarChamado.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelarChamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelarChamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarChamado.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarChamado.ForeColor = System.Drawing.Color.White;
            this.btn_cancelarChamado.Image = global::SistemaSegsal.Properties.Resources.cancelar3;
            this.btn_cancelarChamado.Location = new System.Drawing.Point(1079, 66);
            this.btn_cancelarChamado.Name = "btn_cancelarChamado";
            this.btn_cancelarChamado.Size = new System.Drawing.Size(60, 55);
            this.btn_cancelarChamado.TabIndex = 17;
            this.btn_cancelarChamado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelarChamado.UseVisualStyleBackColor = false;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar2;
            this.btn_atualizar.Location = new System.Drawing.Point(469, 66);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(60, 55);
            this.btn_atualizar.TabIndex = 16;
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(1277, 66);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(60, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Image = global::SistemaSegsal.Properties.Resources.imprimir;
            this.btn_imprimir.Location = new System.Drawing.Point(1211, 66);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(60, 55);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatAppearance.BorderSize = 0;
            this.btn_finalizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.White;
            this.btn_finalizar.Image = global::SistemaSegsal.Properties.Resources.servico;
            this.btn_finalizar.Location = new System.Drawing.Point(1145, 66);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(60, 55);
            this.btn_finalizar.TabIndex = 3;
            this.btn_finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar;
            this.btn_deletar.Location = new System.Drawing.Point(1013, 66);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(60, 55);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(947, 66);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(60, 55);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(881, 66);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 55);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(815, 66);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 55);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar;
            this.btn_salvar.Location = new System.Drawing.Point(403, 66);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(60, 55);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_cancelarChamado);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_finalizar);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.lvw_listaChamados);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_title);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 60);
            this.panel3.TabIndex = 15;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(90, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(181, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Chamados";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.cmb_status);
            this.groupBox2.Controls.Add(this.txt_valorChamado);
            this.groupBox2.Controls.Add(this.txt_qtdChamado);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(28, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1309, 88);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listar Propostas por:";
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.White;
            this.cmb_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.ForeColor = System.Drawing.Color.Black;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(150, 33);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(225, 23);
            this.cmb_status.TabIndex = 5;
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
            // 
            // txt_valorChamado
            // 
            this.txt_valorChamado.BackColor = System.Drawing.Color.White;
            this.txt_valorChamado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorChamado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorChamado.ForeColor = System.Drawing.Color.Black;
            this.txt_valorChamado.Location = new System.Drawing.Point(533, 59);
            this.txt_valorChamado.Name = "txt_valorChamado";
            this.txt_valorChamado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorChamado.Size = new System.Drawing.Size(509, 16);
            this.txt_valorChamado.TabIndex = 4;
            // 
            // txt_qtdChamado
            // 
            this.txt_qtdChamado.BackColor = System.Drawing.Color.White;
            this.txt_qtdChamado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qtdChamado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdChamado.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdChamado.Location = new System.Drawing.Point(533, 22);
            this.txt_qtdChamado.Name = "txt_qtdChamado";
            this.txt_qtdChamado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_qtdChamado.Size = new System.Drawing.Size(509, 16);
            this.txt_qtdChamado.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaSegsal.Properties.Resources.operacional2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(28, 263);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1309, 23);
            this.textBox2.TabIndex = 45;
            this.textBox2.Text = " Lista de Chamados";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 36);
            this.panel2.TabIndex = 44;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(26, 33);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 44;
            this.textBox3.Text = " Status";
            // 
            // frm_listaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panel1);
            this.Name = "frm_listaChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listChamado";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listChamado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw_listaChamados;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_valorChamado;
        private System.Windows.Forms.TextBox txt_qtdChamado;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cancelarChamado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox3;
    }
}