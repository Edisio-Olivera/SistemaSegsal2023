
namespace SistemaSegsal.Views
{
    partial class frm_listaContasPagar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_listaContasPagar));
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_ano = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_cancelarChamado = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lbl_vencidoAno = new System.Windows.Forms.Label();
            this.lbl_pagarAno = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_valorJaPagoAno = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pgb_metaAno = new System.Windows.Forms.ProgressBar();
            this.lbl_metaAno = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_vencidoMes = new System.Windows.Forms.Label();
            this.lbl_pagarMes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_valorJaPagoMes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pgb_metaMes = new System.Windows.Forms.ProgressBar();
            this.lbl_metaMes = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_valorPagarAno = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbl_valorPagarMes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lvw_listaContasPagar = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_ano = new System.Windows.Forms.Label();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.cmb_anos = new System.Windows.Forms.ComboBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(90, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(245, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Contas a Pagar";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_sair);
            this.panel3.Controls.Add(this.btn_novo);
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_title);
            this.panel3.Controls.Add(this.cmb_ano);
            this.panel3.Controls.Add(this.btn_deletar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 65);
            this.panel3.TabIndex = 15;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair25;
            this.btn_sair.Location = new System.Drawing.Point(1188, 3);
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
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo25;
            this.btn_novo.Location = new System.Drawing.Point(548, 2);
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
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelarR25;
            this.btn_cancelar.Location = new System.Drawing.Point(705, 2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaSegsal.Properties.Resources.financeiro2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 65);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_ano
            // 
            this.cmb_ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cmb_ano.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_ano.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.cmb_ano.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.cmb_ano.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmb_ano.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.cmb_ano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_ano.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ano.ForeColor = System.Drawing.Color.White;
            this.cmb_ano.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.cmb_ano.Location = new System.Drawing.Point(869, 5);
            this.cmb_ano.Name = "cmb_ano";
            this.cmb_ano.Size = new System.Drawing.Size(150, 55);
            this.cmb_ano.TabIndex = 5;
            this.cmb_ano.Text = "     Editar";
            this.cmb_ano.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.cmb_ano.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar25;
            this.btn_deletar.Location = new System.Drawing.Point(1032, 2);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(150, 55);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Text = "     Deletar";
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 329);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1299, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Lista de Contas a Pagar";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Mês";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_mes
            // 
            this.cmb_mes.BackColor = System.Drawing.Color.White;
            this.cmb_mes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mes.ForeColor = System.Drawing.Color.Black;
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Location = new System.Drawing.Point(151, 28);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(166, 23);
            this.cmb_mes.TabIndex = 5;
            this.cmb_mes.SelectedValueChanged += new System.EventHandler(this.cmb_mes_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btn_pagar);
            this.panel2.Controls.Add(this.btn_cancelarChamado);
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 50);
            this.panel2.TabIndex = 44;
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.LightGray;
            this.btn_pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_pagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_pagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_pagar.Image = global::SistemaSegsal.Properties.Resources.pagar25b;
            this.btn_pagar.Location = new System.Drawing.Point(789, 6);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(150, 40);
            this.btn_pagar.TabIndex = 16;
            this.btn_pagar.Text = "     Pagar";
            this.btn_pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // btn_cancelarChamado
            // 
            this.btn_cancelarChamado.BackColor = System.Drawing.Color.LightGray;
            this.btn_cancelarChamado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelarChamado.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_cancelarChamado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_cancelarChamado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_cancelarChamado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelarChamado.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelarChamado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelarChamado.Image = global::SistemaSegsal.Properties.Resources.cancelar25b;
            this.btn_cancelarChamado.Location = new System.Drawing.Point(945, 6);
            this.btn_cancelarChamado.Name = "btn_cancelarChamado";
            this.btn_cancelarChamado.Size = new System.Drawing.Size(150, 40);
            this.btn_cancelarChamado.TabIndex = 17;
            this.btn_cancelarChamado.Text = "     Cancelar";
            this.btn_cancelarChamado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelarChamado.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.LightGray;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_imprimir.Image = global::SistemaSegsal.Properties.Resources.imprimir25b;
            this.btn_imprimir.Location = new System.Drawing.Point(1101, 6);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(150, 40);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.Text = "     Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Controls.Add(this.lbl_vencidoAno);
            this.panel7.Controls.Add(this.lbl_pagarAno);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.lbl_valorJaPagoAno);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Controls.Add(this.label17);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(891, 10);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 100);
            this.panel7.TabIndex = 47;
            // 
            // lbl_vencidoAno
            // 
            this.lbl_vencidoAno.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vencidoAno.ForeColor = System.Drawing.Color.Orange;
            this.lbl_vencidoAno.Location = new System.Drawing.Point(89, 67);
            this.lbl_vencidoAno.Name = "lbl_vencidoAno";
            this.lbl_vencidoAno.Size = new System.Drawing.Size(143, 24);
            this.lbl_vencidoAno.TabIndex = 48;
            this.lbl_vencidoAno.Text = "R$";
            this.lbl_vencidoAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pagarAno
            // 
            this.lbl_pagarAno.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagarAno.ForeColor = System.Drawing.Color.Red;
            this.lbl_pagarAno.Location = new System.Drawing.Point(89, 42);
            this.lbl_pagarAno.Name = "lbl_pagarAno";
            this.lbl_pagarAno.Size = new System.Drawing.Size(143, 24);
            this.lbl_pagarAno.TabIndex = 48;
            this.lbl_pagarAno.Text = "R$";
            this.lbl_pagarAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 15);
            this.label14.TabIndex = 48;
            this.label14.Text = "Vencido";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_valorJaPagoAno
            // 
            this.lbl_valorJaPagoAno.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorJaPagoAno.ForeColor = System.Drawing.Color.Green;
            this.lbl_valorJaPagoAno.Location = new System.Drawing.Point(89, 17);
            this.lbl_valorJaPagoAno.Name = "lbl_valorJaPagoAno";
            this.lbl_valorJaPagoAno.Size = new System.Drawing.Size(143, 24);
            this.lbl_valorJaPagoAno.TabIndex = 48;
            this.lbl_valorJaPagoAno.Text = "R$";
            this.lbl_valorJaPagoAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 15);
            this.label10.TabIndex = 48;
            this.label10.Text = "A Pagar";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(11, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 15);
            this.label17.TabIndex = 48;
            this.label17.Text = "Pago";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Gray;
            this.label18.Location = new System.Drawing.Point(4, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(75, 15);
            this.label18.TabIndex = 48;
            this.label18.Text = "Pago no Ano";
            // 
            // pgb_metaAno
            // 
            this.pgb_metaAno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pgb_metaAno.Location = new System.Drawing.Point(10, 52);
            this.pgb_metaAno.Name = "pgb_metaAno";
            this.pgb_metaAno.Size = new System.Drawing.Size(174, 10);
            this.pgb_metaAno.TabIndex = 49;
            // 
            // lbl_metaAno
            // 
            this.lbl_metaAno.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_metaAno.ForeColor = System.Drawing.Color.Gray;
            this.lbl_metaAno.Location = new System.Drawing.Point(10, 65);
            this.lbl_metaAno.Name = "lbl_metaAno";
            this.lbl_metaAno.Size = new System.Drawing.Size(174, 20);
            this.lbl_metaAno.TabIndex = 48;
            this.lbl_metaAno.Text = "%";
            this.lbl_metaAno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(7, 32);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 15);
            this.label16.TabIndex = 48;
            this.label16.Text = "Meta atingida";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.lbl_vencidoMes);
            this.panel5.Controls.Add(this.lbl_pagarMes);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.lbl_valorJaPagoMes);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(233, 10);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 100);
            this.panel5.TabIndex = 47;
            // 
            // lbl_vencidoMes
            // 
            this.lbl_vencidoMes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_vencidoMes.ForeColor = System.Drawing.Color.Orange;
            this.lbl_vencidoMes.Location = new System.Drawing.Point(89, 68);
            this.lbl_vencidoMes.Name = "lbl_vencidoMes";
            this.lbl_vencidoMes.Size = new System.Drawing.Size(143, 24);
            this.lbl_vencidoMes.TabIndex = 48;
            this.lbl_vencidoMes.Text = "R$";
            this.lbl_vencidoMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_pagarMes
            // 
            this.lbl_pagarMes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagarMes.ForeColor = System.Drawing.Color.Red;
            this.lbl_pagarMes.Location = new System.Drawing.Point(89, 43);
            this.lbl_pagarMes.Name = "lbl_pagarMes";
            this.lbl_pagarMes.Size = new System.Drawing.Size(143, 24);
            this.lbl_pagarMes.TabIndex = 48;
            this.lbl_pagarMes.Text = "R$";
            this.lbl_pagarMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 15);
            this.label6.TabIndex = 48;
            this.label6.Text = "Vencido";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_valorJaPagoMes
            // 
            this.lbl_valorJaPagoMes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorJaPagoMes.ForeColor = System.Drawing.Color.Green;
            this.lbl_valorJaPagoMes.Location = new System.Drawing.Point(89, 18);
            this.lbl_valorJaPagoMes.Name = "lbl_valorJaPagoMes";
            this.lbl_valorJaPagoMes.Size = new System.Drawing.Size(143, 24);
            this.lbl_valorJaPagoMes.TabIndex = 48;
            this.lbl_valorJaPagoMes.Text = "R$";
            this.lbl_valorJaPagoMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 15);
            this.label5.TabIndex = 48;
            this.label5.Text = "A Pagar";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 15);
            this.label7.TabIndex = 48;
            this.label7.Text = "Pago";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(4, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 15);
            this.label8.TabIndex = 48;
            this.label8.Text = "Pago no Mês";
            // 
            // pgb_metaMes
            // 
            this.pgb_metaMes.ForeColor = System.Drawing.Color.Red;
            this.pgb_metaMes.Location = new System.Drawing.Point(14, 53);
            this.pgb_metaMes.Name = "pgb_metaMes";
            this.pgb_metaMes.Size = new System.Drawing.Size(174, 10);
            this.pgb_metaMes.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.pgb_metaMes.TabIndex = 49;
            // 
            // lbl_metaMes
            // 
            this.lbl_metaMes.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_metaMes.ForeColor = System.Drawing.Color.Gray;
            this.lbl_metaMes.Location = new System.Drawing.Point(14, 68);
            this.lbl_metaMes.Name = "lbl_metaMes";
            this.lbl_metaMes.Size = new System.Drawing.Size(174, 19);
            this.lbl_metaMes.TabIndex = 48;
            this.lbl_metaMes.Text = "%";
            this.lbl_metaMes.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(11, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 15);
            this.label9.TabIndex = 48;
            this.label9.Text = "Meta atingida";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.White;
            this.panel9.Controls.Add(this.lbl_metaAno);
            this.panel9.Controls.Add(this.pgb_metaAno);
            this.panel9.Controls.Add(this.label27);
            this.panel9.Controls.Add(this.label16);
            this.panel9.Location = new System.Drawing.Point(1137, 10);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(195, 100);
            this.panel9.TabIndex = 47;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Gray;
            this.label27.Location = new System.Drawing.Point(4, 4);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 15);
            this.label27.TabIndex = 48;
            this.label27.Text = "Meta ano";
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Controls.Add(this.pgb_metaMes);
            this.panel8.Controls.Add(this.label23);
            this.panel8.Controls.Add(this.lbl_metaMes);
            this.panel8.Controls.Add(this.label9);
            this.panel8.Location = new System.Drawing.Point(479, 10);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(200, 100);
            this.panel8.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Gray;
            this.label23.Location = new System.Drawing.Point(4, 4);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 15);
            this.label23.TabIndex = 48;
            this.label23.Text = "Meta mês";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.lbl_valorPagarAno);
            this.panel6.Controls.Add(this.label19);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Controls.Add(this.label13);
            this.panel6.Location = new System.Drawing.Point(685, 10);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 47;
            // 
            // lbl_valorPagarAno
            // 
            this.lbl_valorPagarAno.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorPagarAno.ForeColor = System.Drawing.Color.Red;
            this.lbl_valorPagarAno.Location = new System.Drawing.Point(14, 55);
            this.lbl_valorPagarAno.Name = "lbl_valorPagarAno";
            this.lbl_valorPagarAno.Size = new System.Drawing.Size(171, 30);
            this.lbl_valorPagarAno.TabIndex = 48;
            this.lbl_valorPagarAno.Text = "R$";
            this.lbl_valorPagarAno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label19
            // 
            this.label19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Gray;
            this.label19.Location = new System.Drawing.Point(51, 39);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 15);
            this.label19.TabIndex = 48;
            this.label19.Text = "Total no ano";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(73, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 15);
            this.label12.TabIndex = 48;
            this.label12.Text = "mês";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gray;
            this.label13.Location = new System.Drawing.Point(4, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 15);
            this.label13.TabIndex = 48;
            this.label13.Text = "A Pagar no Ano";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.lbl_valorPagarMes);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(27, 10);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 47;
            // 
            // lbl_valorPagarMes
            // 
            this.lbl_valorPagarMes.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valorPagarMes.ForeColor = System.Drawing.Color.Red;
            this.lbl_valorPagarMes.Location = new System.Drawing.Point(14, 55);
            this.lbl_valorPagarMes.Name = "lbl_valorPagarMes";
            this.lbl_valorPagarMes.Size = new System.Drawing.Size(173, 30);
            this.lbl_valorPagarMes.TabIndex = 48;
            this.lbl_valorPagarMes.Text = "R$";
            this.lbl_valorPagarMes.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(52, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 15);
            this.label4.TabIndex = 48;
            this.label4.Text = "Total no mês";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(4, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 48;
            this.label3.Text = "A Pagar no Mês";
            // 
            // lvw_listaContasPagar
            // 
            this.lvw_listaContasPagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaContasPagar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_listaContasPagar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaContasPagar.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaContasPagar.FullRowSelect = true;
            this.lvw_listaContasPagar.GridLines = true;
            this.lvw_listaContasPagar.HideSelection = false;
            this.lvw_listaContasPagar.Location = new System.Drawing.Point(30, 355);
            this.lvw_listaContasPagar.Name = "lvw_listaContasPagar";
            this.lvw_listaContasPagar.Size = new System.Drawing.Size(1299, 333);
            this.lvw_listaContasPagar.TabIndex = 2;
            this.lvw_listaContasPagar.UseCompatibleStateImageBehavior = false;
            this.lvw_listaContasPagar.View = System.Windows.Forms.View.Details;
            this.lvw_listaContasPagar.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaContasPagar_ItemSelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lvw_listaContasPagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 742);
            this.panel1.TabIndex = 15;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_ano);
            this.groupBox1.Controls.Add(this.btn_filtrar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmb_mes);
            this.groupBox1.Controls.Add(this.cmb_anos);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 246);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1299, 70);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pesquisar por:";
            // 
            // lbl_ano
            // 
            this.lbl_ano.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_ano.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_ano.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ano.Location = new System.Drawing.Point(322, 28);
            this.lbl_ano.Name = "lbl_ano";
            this.lbl_ano.Size = new System.Drawing.Size(119, 23);
            this.lbl_ano.TabIndex = 46;
            this.lbl_ano.Text = "Ano";
            this.lbl_ano.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackColor = System.Drawing.Color.Navy;
            this.btn_filtrar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_filtrar.FlatAppearance.BorderSize = 0;
            this.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_filtrar.ForeColor = System.Drawing.Color.White;
            this.btn_filtrar.Location = new System.Drawing.Point(565, 28);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(108, 23);
            this.btn_filtrar.TabIndex = 48;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = false;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // cmb_anos
            // 
            this.cmb_anos.BackColor = System.Drawing.Color.White;
            this.cmb_anos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_anos.ForeColor = System.Drawing.Color.Black;
            this.cmb_anos.FormattingEnabled = true;
            this.cmb_anos.Location = new System.Drawing.Point(447, 28);
            this.cmb_anos.Name = "cmb_anos";
            this.cmb_anos.Size = new System.Drawing.Size(112, 23);
            this.cmb_anos.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel10.Controls.Add(this.panel7);
            this.panel10.Controls.Add(this.panel4);
            this.panel10.Controls.Add(this.panel5);
            this.panel10.Controls.Add(this.panel6);
            this.panel10.Controls.Add(this.panel9);
            this.panel10.Controls.Add(this.panel8);
            this.panel10.Location = new System.Drawing.Point(0, 120);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1400, 120);
            this.panel10.TabIndex = 47;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "red (1).png");
            this.imageList1.Images.SetKeyName(1, "yellow (1).png");
            this.imageList1.Images.SetKeyName(2, "green (1).png");
            // 
            // frm_listaContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 742);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão SEGSAL";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaContasPagar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button cmb_ano;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_cancelarChamado;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvw_listaContasPagar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_valorPagarMes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_valorJaPagoMes;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ProgressBar pgb_metaMes;
        private System.Windows.Forms.Label lbl_metaMes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_valorPagarAno;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ProgressBar pgb_metaAno;
        private System.Windows.Forms.Label lbl_metaAno;
        private System.Windows.Forms.Label lbl_valorJaPagoAno;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbl_ano;
        private System.Windows.Forms.ComboBox cmb_anos;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_pagarAno;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_pagarMes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_vencidoAno;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_vencidoMes;
        private System.Windows.Forms.Label label6;
    }
}