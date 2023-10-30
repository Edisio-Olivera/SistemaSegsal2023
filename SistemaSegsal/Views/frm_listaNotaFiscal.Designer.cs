
namespace SistemaSegsal.Views
{
    partial class frm_listaNotaFiscal
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lvw_listaNotaFiscal = new System.Windows.Forms.ListView();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_valorNotaFiscal = new System.Windows.Forms.TextBox();
            this.txt_qtdNotaFiscal = new System.Windows.Forms.TextBox();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.cmb_ano = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_mes1 = new System.Windows.Forms.Label();
            this.lbl_mes2 = new System.Windows.Forms.Label();
            this.lbl_mes3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbl_anoAtual = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_proximo = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_faturamentoAnual = new System.Windows.Forms.Label();
            this.lbl_faturamentoMes1 = new System.Windows.Forms.Label();
            this.lbl_faturamentoMes2 = new System.Windows.Forms.Label();
            this.lbl_faturamentoMes3 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.img_logoEmpresa);
            this.panel2.Controls.Add(this.lbl_title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 60);
            this.panel2.TabIndex = 5;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(90, 8);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(216, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Notas Fiscais";
            // 
            // lvw_listaNotaFiscal
            // 
            this.lvw_listaNotaFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaNotaFiscal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaNotaFiscal.FullRowSelect = true;
            this.lvw_listaNotaFiscal.GridLines = true;
            this.lvw_listaNotaFiscal.HideSelection = false;
            this.lvw_listaNotaFiscal.Location = new System.Drawing.Point(28, 365);
            this.lvw_listaNotaFiscal.Name = "lvw_listaNotaFiscal";
            this.lvw_listaNotaFiscal.Size = new System.Drawing.Size(728, 312);
            this.lvw_listaNotaFiscal.TabIndex = 38;
            this.lvw_listaNotaFiscal.UseCompatibleStateImageBehavior = false;
            this.lvw_listaNotaFiscal.View = System.Windows.Forms.View.Details;
            this.lvw_listaNotaFiscal.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaNotaFiscal_ItemSelectionChanged);
            this.lvw_listaNotaFiscal.SelectedIndexChanged += new System.EventHandler(this.lvw_listaNotaFiscal_SelectedIndexChanged);
            // 
            // cmb_status
            // 
            this.cmb_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(153, 285);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(173, 23);
            this.cmb_status.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_valorNotaFiscal);
            this.groupBox2.Controls.Add(this.txt_qtdNotaFiscal);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 683);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1309, 83);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txt_valorNotaFiscal
            // 
            this.txt_valorNotaFiscal.BackColor = System.Drawing.Color.White;
            this.txt_valorNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorNotaFiscal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorNotaFiscal.ForeColor = System.Drawing.Color.Black;
            this.txt_valorNotaFiscal.Location = new System.Drawing.Point(776, 51);
            this.txt_valorNotaFiscal.Name = "txt_valorNotaFiscal";
            this.txt_valorNotaFiscal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorNotaFiscal.Size = new System.Drawing.Size(509, 16);
            this.txt_valorNotaFiscal.TabIndex = 41;
            // 
            // txt_qtdNotaFiscal
            // 
            this.txt_qtdNotaFiscal.BackColor = System.Drawing.Color.White;
            this.txt_qtdNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qtdNotaFiscal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdNotaFiscal.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdNotaFiscal.Location = new System.Drawing.Point(776, 22);
            this.txt_qtdNotaFiscal.Name = "txt_qtdNotaFiscal";
            this.txt_qtdNotaFiscal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_qtdNotaFiscal.Size = new System.Drawing.Size(509, 16);
            this.txt_qtdNotaFiscal.TabIndex = 42;
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_filtrar.FlatAppearance.BorderSize = 0;
            this.btn_filtrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_filtrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_filtrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_filtrar.ForeColor = System.Drawing.Color.White;
            this.btn_filtrar.Location = new System.Drawing.Point(585, 284);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(108, 24);
            this.btn_filtrar.TabIndex = 40;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = false;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // cmb_ano
            // 
            this.cmb_ano.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_ano.FormattingEnabled = true;
            this.cmb_ano.Location = new System.Drawing.Point(456, 285);
            this.cmb_ano.Name = "cmb_ano";
            this.cmb_ano.Size = new System.Drawing.Size(123, 23);
            this.cmb_ano.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_pagar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Location = new System.Drawing.Point(0, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 65);
            this.panel1.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(29, 285);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 43;
            this.textBox3.Text = " Status";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(332, 285);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = " Ano";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(28, 336);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(728, 23);
            this.textBox2.TabIndex = 43;
            this.textBox2.Text = " Lista de Notas Fiscais";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.lbl_mes3);
            this.panel3.Controls.Add(this.lbl_faturamentoMes1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(699, 142);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 117);
            this.panel3.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(48, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 19);
            this.label1.TabIndex = 46;
            this.label1.Text = "Faturamento do Mês";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.lbl_mes2);
            this.panel4.Controls.Add(this.lbl_faturamentoMes2);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(409, 142);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(258, 117);
            this.panel4.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 46;
            this.label2.Text = "Faturamento do Mês";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel5.Controls.Add(this.lbl_mes1);
            this.panel5.Controls.Add(this.lbl_faturamentoMes3);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(119, 142);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(258, 117);
            this.panel5.TabIndex = 44;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Faturamento do Mês";
            // 
            // lbl_mes1
            // 
            this.lbl_mes1.AutoSize = true;
            this.lbl_mes1.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes1.ForeColor = System.Drawing.Color.White;
            this.lbl_mes1.Location = new System.Drawing.Point(48, 85);
            this.lbl_mes1.Name = "lbl_mes1";
            this.lbl_mes1.Size = new System.Drawing.Size(49, 19);
            this.lbl_mes1.TabIndex = 46;
            this.lbl_mes1.Text = "Mes 1";
            this.lbl_mes1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_mes2
            // 
            this.lbl_mes2.AutoSize = true;
            this.lbl_mes2.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes2.ForeColor = System.Drawing.Color.White;
            this.lbl_mes2.Location = new System.Drawing.Point(43, 85);
            this.lbl_mes2.Name = "lbl_mes2";
            this.lbl_mes2.Size = new System.Drawing.Size(49, 19);
            this.lbl_mes2.TabIndex = 46;
            this.lbl_mes2.Text = "Mes 2";
            this.lbl_mes2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_mes3
            // 
            this.lbl_mes3.AutoSize = true;
            this.lbl_mes3.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes3.ForeColor = System.Drawing.Color.White;
            this.lbl_mes3.Location = new System.Drawing.Point(48, 85);
            this.lbl_mes3.Name = "lbl_mes3";
            this.lbl_mes3.Size = new System.Drawing.Size(49, 19);
            this.lbl_mes3.TabIndex = 46;
            this.lbl_mes3.Text = "Mes 3";
            this.lbl_mes3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel6.Controls.Add(this.lbl_anoAtual);
            this.panel6.Controls.Add(this.lbl_faturamentoAnual);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Location = new System.Drawing.Point(1079, 142);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(258, 117);
            this.panel6.TabIndex = 44;
            // 
            // lbl_anoAtual
            // 
            this.lbl_anoAtual.AutoSize = true;
            this.lbl_anoAtual.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_anoAtual.ForeColor = System.Drawing.Color.White;
            this.lbl_anoAtual.Location = new System.Drawing.Point(48, 85);
            this.lbl_anoAtual.Name = "lbl_anoAtual";
            this.lbl_anoAtual.Size = new System.Drawing.Size(35, 19);
            this.lbl_anoAtual.TabIndex = 46;
            this.lbl_anoAtual.Text = "Ano";
            this.lbl_anoAtual.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 19);
            this.label5.TabIndex = 46;
            this.label5.Text = "Faturamento Anual";
            // 
            // btn_proximo
            // 
            this.btn_proximo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_proximo.FlatAppearance.BorderSize = 0;
            this.btn_proximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_proximo.Image = global::SistemaSegsal.Properties.Resources.FF;
            this.btn_proximo.Location = new System.Drawing.Point(989, 142);
            this.btn_proximo.Name = "btn_proximo";
            this.btn_proximo.Size = new System.Drawing.Size(58, 117);
            this.btn_proximo.TabIndex = 45;
            this.btn_proximo.UseVisualStyleBackColor = false;
            this.btn_proximo.Click += new System.EventHandler(this.btn_proximo_Click);
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Image = global::SistemaSegsal.Properties.Resources.REW;
            this.btn_anterior.Location = new System.Drawing.Point(29, 142);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(58, 117);
            this.btn_anterior.TabIndex = 45;
            this.btn_anterior.UseVisualStyleBackColor = false;
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Image = global::SistemaSegsal.Properties.Resources.financeiro2;
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(70, 60);
            this.img_logoEmpresa.TabIndex = 42;
            this.img_logoEmpresa.TabStop = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(947, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 55);
            this.btn_novo.TabIndex = 38;
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(1013, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 55);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(1277, 5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(60, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(1079, 5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(60, 55);
            this.btn_editar.TabIndex = 40;
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_pagar
            // 
            this.btn_pagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_pagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_pagar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_pagar.FlatAppearance.BorderSize = 0;
            this.btn_pagar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_pagar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_pagar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_pagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagar.ForeColor = System.Drawing.Color.White;
            this.btn_pagar.Image = global::SistemaSegsal.Properties.Resources.pagar;
            this.btn_pagar.Location = new System.Drawing.Point(1211, 5);
            this.btn_pagar.Name = "btn_pagar";
            this.btn_pagar.Size = new System.Drawing.Size(60, 55);
            this.btn_pagar.TabIndex = 41;
            this.btn_pagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_pagar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pagar.UseVisualStyleBackColor = false;
            this.btn_pagar.Click += new System.EventHandler(this.btn_pagar_Click);
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar;
            this.btn_deletar.Location = new System.Drawing.Point(1145, 5);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(60, 55);
            this.btn_deletar.TabIndex = 39;
            this.btn_deletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // chart1
            // 
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(773, 336);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            series2.YValuesPerPoint = 6;
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(564, 341);
            this.chart1.TabIndex = 46;
            this.chart1.Text = "chart1";
            // 
            // lbl_faturamentoAnual
            // 
            this.lbl_faturamentoAnual.AutoSize = true;
            this.lbl_faturamentoAnual.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faturamentoAnual.ForeColor = System.Drawing.Color.White;
            this.lbl_faturamentoAnual.Location = new System.Drawing.Point(46, 37);
            this.lbl_faturamentoAnual.Name = "lbl_faturamentoAnual";
            this.lbl_faturamentoAnual.Size = new System.Drawing.Size(64, 33);
            this.lbl_faturamentoAnual.TabIndex = 46;
            this.lbl_faturamentoAnual.Text = "Fatu";
            // 
            // lbl_faturamentoMes1
            // 
            this.lbl_faturamentoMes1.AutoSize = true;
            this.lbl_faturamentoMes1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faturamentoMes1.ForeColor = System.Drawing.Color.White;
            this.lbl_faturamentoMes1.Location = new System.Drawing.Point(46, 35);
            this.lbl_faturamentoMes1.Name = "lbl_faturamentoMes1";
            this.lbl_faturamentoMes1.Size = new System.Drawing.Size(64, 33);
            this.lbl_faturamentoMes1.TabIndex = 46;
            this.lbl_faturamentoMes1.Text = "Fatu";
            // 
            // lbl_faturamentoMes2
            // 
            this.lbl_faturamentoMes2.AutoSize = true;
            this.lbl_faturamentoMes2.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faturamentoMes2.ForeColor = System.Drawing.Color.White;
            this.lbl_faturamentoMes2.Location = new System.Drawing.Point(41, 35);
            this.lbl_faturamentoMes2.Name = "lbl_faturamentoMes2";
            this.lbl_faturamentoMes2.Size = new System.Drawing.Size(64, 33);
            this.lbl_faturamentoMes2.TabIndex = 46;
            this.lbl_faturamentoMes2.Text = "Fatu";
            // 
            // lbl_faturamentoMes3
            // 
            this.lbl_faturamentoMes3.AutoSize = true;
            this.lbl_faturamentoMes3.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_faturamentoMes3.ForeColor = System.Drawing.Color.White;
            this.lbl_faturamentoMes3.Location = new System.Drawing.Point(46, 35);
            this.lbl_faturamentoMes3.Name = "lbl_faturamentoMes3";
            this.lbl_faturamentoMes3.Size = new System.Drawing.Size(64, 33);
            this.lbl_faturamentoMes3.TabIndex = 46;
            this.lbl_faturamentoMes3.Text = "Fatu";
            // 
            // frm_listaNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 772);
            this.ControlBox = false;
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_proximo);
            this.Controls.Add(this.btn_anterior);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.cmb_ano);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lvw_listaNotaFiscal);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaNotaFiscal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ListView lvw_listaNotaFiscal;
        private System.Windows.Forms.Button btn_pagar;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.ComboBox cmb_ano;
        private System.Windows.Forms.TextBox txt_valorNotaFiscal;
        private System.Windows.Forms.TextBox txt_qtdNotaFiscal;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_mes3;
        private System.Windows.Forms.Label lbl_mes2;
        private System.Windows.Forms.Label lbl_mes1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbl_anoAtual;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_proximo;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label lbl_faturamentoAnual;
        private System.Windows.Forms.Label lbl_faturamentoMes1;
        private System.Windows.Forms.Label lbl_faturamentoMes2;
        private System.Windows.Forms.Label lbl_faturamentoMes3;
    }
}