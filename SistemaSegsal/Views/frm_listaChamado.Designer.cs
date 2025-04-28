
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.lbl_qtdFaturado = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lbl_qtdFechado = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbl_qtdCancelado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lbl_qtdAndamento = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_qtdAberto = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valorChamado = new System.Windows.Forms.TextBox();
            this.txt_qtdChamado = new System.Windows.Forms.TextBox();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_cancelarChamado = new System.Windows.Forms.Button();
            this.btn_finalizar = new System.Windows.Forms.Button();
            this.btn_atendimento = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lvw_listaChamados
            // 
            this.lvw_listaChamados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaChamados.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_listaChamados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaChamados.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaChamados.FullRowSelect = true;
            this.lvw_listaChamados.GridLines = true;
            this.lvw_listaChamados.HideSelection = false;
            this.lvw_listaChamados.Location = new System.Drawing.Point(30, 354);
            this.lvw_listaChamados.Name = "lvw_listaChamados";
            this.lvw_listaChamados.Size = new System.Drawing.Size(1299, 297);
            this.lvw_listaChamados.TabIndex = 2;
            this.lvw_listaChamados.UseCompatibleStateImageBehavior = false;
            this.lvw_listaChamados.View = System.Windows.Forms.View.Details;
            this.lvw_listaChamados.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaChamados_ItemSelectionChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_valorChamado);
            this.panel1.Controls.Add(this.txt_qtdChamado);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lvw_listaChamados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 749);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.panel5);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Location = new System.Drawing.Point(30, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1299, 154);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel8.Controls.Add(this.pictureBox6);
            this.panel8.Controls.Add(this.lbl_qtdFaturado);
            this.panel8.Controls.Add(this.label12);
            this.panel8.Location = new System.Drawing.Point(1039, 19);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(250, 121);
            this.panel8.TabIndex = 0;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SistemaSegsal.Properties.Resources.aberto;
            this.pictureBox6.Location = new System.Drawing.Point(194, 6);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(44, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            // 
            // lbl_qtdFaturado
            // 
            this.lbl_qtdFaturado.AutoSize = true;
            this.lbl_qtdFaturado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_qtdFaturado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdFaturado.Location = new System.Drawing.Point(10, 69);
            this.lbl_qtdFaturado.Name = "lbl_qtdFaturado";
            this.lbl_qtdFaturado.Size = new System.Drawing.Size(29, 33);
            this.lbl_qtdFaturado.TabIndex = 1;
            this.lbl_qtdFaturado.Text = "0";
            this.lbl_qtdFaturado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 1;
            this.label12.Text = "Faturados";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel7.Controls.Add(this.pictureBox5);
            this.panel7.Controls.Add(this.lbl_qtdFechado);
            this.panel7.Controls.Add(this.label10);
            this.panel7.Location = new System.Drawing.Point(782, 19);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 121);
            this.panel7.TabIndex = 0;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SistemaSegsal.Properties.Resources.aberto;
            this.pictureBox5.Location = new System.Drawing.Point(194, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(44, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // lbl_qtdFechado
            // 
            this.lbl_qtdFechado.AutoSize = true;
            this.lbl_qtdFechado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_qtdFechado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdFechado.Location = new System.Drawing.Point(10, 69);
            this.lbl_qtdFechado.Name = "lbl_qtdFechado";
            this.lbl_qtdFechado.Size = new System.Drawing.Size(29, 33);
            this.lbl_qtdFechado.TabIndex = 1;
            this.lbl_qtdFechado.Text = "0";
            this.lbl_qtdFechado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 15);
            this.label10.TabIndex = 1;
            this.label10.Text = "Fechados";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel6.Controls.Add(this.pictureBox4);
            this.panel6.Controls.Add(this.lbl_qtdCancelado);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Location = new System.Drawing.Point(525, 19);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 121);
            this.panel6.TabIndex = 0;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SistemaSegsal.Properties.Resources.aberto;
            this.pictureBox4.Location = new System.Drawing.Point(194, 6);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 1;
            this.pictureBox4.TabStop = false;
            // 
            // lbl_qtdCancelado
            // 
            this.lbl_qtdCancelado.AutoSize = true;
            this.lbl_qtdCancelado.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_qtdCancelado.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdCancelado.Location = new System.Drawing.Point(10, 69);
            this.lbl_qtdCancelado.Name = "lbl_qtdCancelado";
            this.lbl_qtdCancelado.Size = new System.Drawing.Size(29, 33);
            this.lbl_qtdCancelado.TabIndex = 1;
            this.lbl_qtdCancelado.Text = "0";
            this.lbl_qtdCancelado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 1;
            this.label8.Text = "Cancelados";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.lbl_qtdAndamento);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(268, 19);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 121);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SistemaSegsal.Properties.Resources.aberto;
            this.pictureBox3.Location = new System.Drawing.Point(194, 6);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(44, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lbl_qtdAndamento
            // 
            this.lbl_qtdAndamento.AutoSize = true;
            this.lbl_qtdAndamento.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_qtdAndamento.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdAndamento.Location = new System.Drawing.Point(10, 69);
            this.lbl_qtdAndamento.Name = "lbl_qtdAndamento";
            this.lbl_qtdAndamento.Size = new System.Drawing.Size(29, 33);
            this.lbl_qtdAndamento.TabIndex = 1;
            this.lbl_qtdAndamento.Text = "0";
            this.lbl_qtdAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 15);
            this.label6.TabIndex = 1;
            this.label6.Text = "Andamento";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Controls.Add(this.lbl_qtdAberto);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(11, 19);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(250, 121);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaSegsal.Properties.Resources.aberto;
            this.pictureBox2.Location = new System.Drawing.Point(194, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_qtdAberto
            // 
            this.lbl_qtdAberto.AutoSize = true;
            this.lbl_qtdAberto.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_qtdAberto.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_qtdAberto.Location = new System.Drawing.Point(10, 69);
            this.lbl_qtdAberto.Name = "lbl_qtdAberto";
            this.lbl_qtdAberto.Size = new System.Drawing.Size(29, 33);
            this.lbl_qtdAberto.TabIndex = 1;
            this.lbl_qtdAberto.Text = "0";
            this.lbl_qtdAberto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Abertos";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1302, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Lista de Propostas Comerciais";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valorChamado
            // 
            this.txt_valorChamado.BackColor = System.Drawing.Color.White;
            this.txt_valorChamado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorChamado.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorChamado.ForeColor = System.Drawing.Color.Black;
            this.txt_valorChamado.Location = new System.Drawing.Point(873, 679);
            this.txt_valorChamado.Name = "txt_valorChamado";
            this.txt_valorChamado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorChamado.Size = new System.Drawing.Size(463, 16);
            this.txt_valorChamado.TabIndex = 4;
            // 
            // txt_qtdChamado
            // 
            this.txt_qtdChamado.BackColor = System.Drawing.Color.White;
            this.txt_qtdChamado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qtdChamado.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdChamado.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdChamado.Location = new System.Drawing.Point(873, 659);
            this.txt_qtdChamado.Name = "txt_qtdChamado";
            this.txt_qtdChamado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_qtdChamado.Size = new System.Drawing.Size(463, 16);
            this.txt_qtdChamado.TabIndex = 4;
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.White;
            this.cmb_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.ForeColor = System.Drawing.Color.Black;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(152, 293);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(225, 23);
            this.cmb_status.TabIndex = 5;
            this.cmb_status.SelectedIndexChanged += new System.EventHandler(this.cmb_status_SelectedIndexChanged);
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Controls.Add(this.btn_cancelarChamado);
            this.panel2.Controls.Add(this.btn_finalizar);
            this.panel2.Controls.Add(this.btn_atendimento);
            this.panel2.Location = new System.Drawing.Point(0, 65);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 50);
            this.panel2.TabIndex = 44;
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
            this.btn_imprimir.Location = new System.Drawing.Point(1188, 3);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(150, 40);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.Text = "     Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
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
            this.btn_cancelarChamado.Location = new System.Drawing.Point(1032, 3);
            this.btn_cancelarChamado.Name = "btn_cancelarChamado";
            this.btn_cancelarChamado.Size = new System.Drawing.Size(150, 40);
            this.btn_cancelarChamado.TabIndex = 17;
            this.btn_cancelarChamado.Text = "     Cancelar";
            this.btn_cancelarChamado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelarChamado.UseVisualStyleBackColor = false;
            this.btn_cancelarChamado.Click += new System.EventHandler(this.btn_cancelarChamado_Click);
            // 
            // btn_finalizar
            // 
            this.btn_finalizar.BackColor = System.Drawing.Color.LightGray;
            this.btn_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_finalizar.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_finalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_finalizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_finalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_finalizar.Image = global::SistemaSegsal.Properties.Resources.finalizar25;
            this.btn_finalizar.Location = new System.Drawing.Point(869, 3);
            this.btn_finalizar.Name = "btn_finalizar";
            this.btn_finalizar.Size = new System.Drawing.Size(150, 40);
            this.btn_finalizar.TabIndex = 3;
            this.btn_finalizar.Text = "     Finalizar";
            this.btn_finalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_finalizar.UseVisualStyleBackColor = false;
            this.btn_finalizar.Click += new System.EventHandler(this.btn_finalizar_Click);
            // 
            // btn_atendimento
            // 
            this.btn_atendimento.BackColor = System.Drawing.Color.LightGray;
            this.btn_atendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atendimento.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btn_atendimento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btn_atendimento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_atendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atendimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atendimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atendimento.Image = global::SistemaSegsal.Properties.Resources.servico25b;
            this.btn_atendimento.Location = new System.Drawing.Point(705, 3);
            this.btn_atendimento.Name = "btn_atendimento";
            this.btn_atendimento.Size = new System.Drawing.Size(150, 40);
            this.btn_atendimento.TabIndex = 16;
            this.btn_atendimento.Text = "     Atendimento";
            this.btn_atendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atendimento.UseVisualStyleBackColor = false;
            this.btn_atendimento.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.btn_sair);
            this.panel3.Controls.Add(this.btn_novo);
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.lbl_title);
            this.panel3.Controls.Add(this.btn_editar);
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
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.pictureBox1.Image = global::SistemaSegsal.Properties.Resources.operacional2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
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
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.btn_editar.Location = new System.Drawing.Point(869, 5);
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
            // frm_listaChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaChamado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chamados";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listChamado_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw_listaChamados;
        private System.Windows.Forms.Button btn_atendimento;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_finalizar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_valorChamado;
        private System.Windows.Forms.TextBox txt_qtdChamado;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cancelarChamado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_qtdAberto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label lbl_qtdFaturado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lbl_qtdFechado;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lbl_qtdCancelado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_qtdAndamento;
        private System.Windows.Forms.Label label6;
    }
}