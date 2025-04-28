
namespace SistemaSegsal.Views
{
    partial class frm_addContasPagar
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
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.cmb_contaBancaria = new System.Windows.Forms.ComboBox();
            this.cmb_formaPgto = new System.Windows.Forms.ComboBox();
            this.cmb_condPgto = new System.Windows.Forms.ComboBox();
            this.cmb_fornecedor = new System.Windows.Forms.ComboBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_editar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_qtdParcela = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txt_valorParcela = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.gbx_cartoes = new System.Windows.Forms.GroupBox();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.txt_saldoCartao = new System.Windows.Forms.TextBox();
            this.cmb_apelidoCartao = new System.Windows.Forms.ComboBox();
            this.txt_bandeiraCartao = new System.Windows.Forms.TextBox();
            this.txt_bancoCartao = new System.Windows.Forms.TextBox();
            this.txt_numeroCartao = new System.Windows.Forms.TextBox();
            this.txt_parcela = new System.Windows.Forms.TextBox();
            this.cbx_pago = new System.Windows.Forms.CheckBox();
            this.lbl_dataPagamento = new System.Windows.Forms.Label();
            this.txt_valorJuros = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.dtp_dataTransacao = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataVencimento = new System.Windows.Forms.DateTimePicker();
            this.dtp_dataPagamento = new System.Windows.Forms.DateTimePicker();
            this.txt_diaVencimento = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.gbx_cartoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(70, 269);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 23);
            this.label11.TabIndex = 128;
            this.label11.Text = "Valor (R$)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(70, 329);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 23);
            this.label8.TabIndex = 131;
            this.label8.Text = "Data Vencimento";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(70, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 23);
            this.label7.TabIndex = 132;
            this.label7.Text = "Parcela";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 53);
            this.label6.TabIndex = 133;
            this.label6.Text = "Descrição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 23);
            this.label5.TabIndex = 134;
            this.label5.Text = "Fornecedor";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(325, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 23);
            this.label3.TabIndex = 135;
            this.label3.Text = "Conta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(70, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 23);
            this.label14.TabIndex = 137;
            this.label14.Text = "Data Transação";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(325, 239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 23);
            this.label16.TabIndex = 140;
            this.label16.Text = "Forma Pgto";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(70, 239);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(120, 23);
            this.label15.TabIndex = 141;
            this.label15.Text = "Cond. Pgto";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(70, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 23);
            this.label1.TabIndex = 126;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(196, 269);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(123, 23);
            this.txt_valor.TabIndex = 114;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valor.TextChanged += new System.EventHandler(this.txt_valor_TextChanged);
            // 
            // cmb_contaBancaria
            // 
            this.cmb_contaBancaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_contaBancaria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_contaBancaria.FormattingEnabled = true;
            this.cmb_contaBancaria.Location = new System.Drawing.Point(451, 119);
            this.cmb_contaBancaria.Name = "cmb_contaBancaria";
            this.cmb_contaBancaria.Size = new System.Drawing.Size(123, 23);
            this.cmb_contaBancaria.TabIndex = 108;
            // 
            // cmb_formaPgto
            // 
            this.cmb_formaPgto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_formaPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_formaPgto.FormattingEnabled = true;
            this.cmb_formaPgto.Location = new System.Drawing.Point(451, 239);
            this.cmb_formaPgto.Name = "cmb_formaPgto";
            this.cmb_formaPgto.Size = new System.Drawing.Size(252, 23);
            this.cmb_formaPgto.TabIndex = 111;
            this.cmb_formaPgto.SelectedValueChanged += new System.EventHandler(this.cmb_formaPgto_SelectedValueChanged);
            // 
            // cmb_condPgto
            // 
            this.cmb_condPgto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_condPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_condPgto.FormattingEnabled = true;
            this.cmb_condPgto.Items.AddRange(new object[] {
            "À Vista",
            "À Prazo"});
            this.cmb_condPgto.Location = new System.Drawing.Point(196, 239);
            this.cmb_condPgto.Name = "cmb_condPgto";
            this.cmb_condPgto.Size = new System.Drawing.Size(123, 23);
            this.cmb_condPgto.TabIndex = 110;
            this.cmb_condPgto.SelectedValueChanged += new System.EventHandler(this.cmb_condPgto_SelectedValueChanged);
            // 
            // cmb_fornecedor
            // 
            this.cmb_fornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_fornecedor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fornecedor.FormattingEnabled = true;
            this.cmb_fornecedor.Location = new System.Drawing.Point(196, 149);
            this.cmb_fornecedor.Name = "cmb_fornecedor";
            this.cmb_fornecedor.Size = new System.Drawing.Size(378, 23);
            this.cmb_fornecedor.TabIndex = 109;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(196, 179);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(378, 53);
            this.txt_descricao.TabIndex = 117;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(196, 90);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 23);
            this.txt_id.TabIndex = 105;
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
            this.btn_atualizar.Location = new System.Drawing.Point(668, 3);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(150, 55);
            this.btn_atualizar.TabIndex = 69;
            this.btn_atualizar.Text = "     Atualizar";
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
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
            this.btn_salvar.Location = new System.Drawing.Point(862, 7);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(150, 55);
            this.btn_salvar.TabIndex = 67;
            this.btn_salvar.Text = "     Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaSegsal.Properties.Resources.financeiro2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 65);
            this.pictureBox1.TabIndex = 103;
            this.pictureBox1.TabStop = false;
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
            this.btn_cancelar.Location = new System.Drawing.Point(1018, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 70;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(90, 11);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(327, 33);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "CADASTRAR NOVA DESPESA";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.btn_editar.Location = new System.Drawing.Point(512, 3);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 55);
            this.btn_editar.TabIndex = 104;
            this.btn_editar.Text = "     Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 65);
            this.panel1.TabIndex = 107;
            // 
            // txt_qtdParcela
            // 
            this.txt_qtdParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_qtdParcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdParcela.Location = new System.Drawing.Point(451, 269);
            this.txt_qtdParcela.Name = "txt_qtdParcela";
            this.txt_qtdParcela.Size = new System.Drawing.Size(123, 23);
            this.txt_qtdParcela.TabIndex = 114;
            this.txt_qtdParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(325, 269);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 23);
            this.label20.TabIndex = 128;
            this.label20.Text = "Qtd Parcelas";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valorParcela
            // 
            this.txt_valorParcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_valorParcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorParcela.Location = new System.Drawing.Point(451, 299);
            this.txt_valorParcela.Name = "txt_valorParcela";
            this.txt_valorParcela.Size = new System.Drawing.Size(123, 23);
            this.txt_valorParcela.TabIndex = 114;
            this.txt_valorParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(325, 299);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(120, 23);
            this.label21.TabIndex = 128;
            this.label21.Text = "Valor Parcela (R$)";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gbx_cartoes
            // 
            this.gbx_cartoes.Controls.Add(this.label2);
            this.gbx_cartoes.Controls.Add(this.label27);
            this.gbx_cartoes.Controls.Add(this.label26);
            this.gbx_cartoes.Controls.Add(this.label25);
            this.gbx_cartoes.Controls.Add(this.label24);
            this.gbx_cartoes.Controls.Add(this.txt_diaVencimento);
            this.gbx_cartoes.Controls.Add(this.label23);
            this.gbx_cartoes.Controls.Add(this.txt_saldoCartao);
            this.gbx_cartoes.Controls.Add(this.cmb_apelidoCartao);
            this.gbx_cartoes.Controls.Add(this.txt_bandeiraCartao);
            this.gbx_cartoes.Controls.Add(this.txt_bancoCartao);
            this.gbx_cartoes.Controls.Add(this.txt_numeroCartao);
            this.gbx_cartoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbx_cartoes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_cartoes.Location = new System.Drawing.Point(800, 90);
            this.gbx_cartoes.Name = "gbx_cartoes";
            this.gbx_cartoes.Size = new System.Drawing.Size(415, 223);
            this.gbx_cartoes.TabIndex = 144;
            this.gbx_cartoes.TabStop = false;
            this.gbx_cartoes.Text = "Cartões";
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label27.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(26, 179);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(120, 23);
            this.label27.TabIndex = 142;
            this.label27.Text = "Saldo (R$)";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label26
            // 
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label26.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(26, 121);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(120, 23);
            this.label26.TabIndex = 142;
            this.label26.Text = "Bandeira";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label25.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(26, 91);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(120, 23);
            this.label25.TabIndex = 142;
            this.label25.Text = "Banco";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label24.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(26, 61);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(120, 23);
            this.label24.TabIndex = 142;
            this.label24.Text = "Número";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label23.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(26, 31);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(120, 23);
            this.label23.TabIndex = 142;
            this.label23.Text = "Apelido";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_saldoCartao
            // 
            this.txt_saldoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_saldoCartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_saldoCartao.Location = new System.Drawing.Point(152, 179);
            this.txt_saldoCartao.Name = "txt_saldoCartao";
            this.txt_saldoCartao.Size = new System.Drawing.Size(123, 23);
            this.txt_saldoCartao.TabIndex = 105;
            this.txt_saldoCartao.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmb_apelidoCartao
            // 
            this.cmb_apelidoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_apelidoCartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_apelidoCartao.FormattingEnabled = true;
            this.cmb_apelidoCartao.Items.AddRange(new object[] {
            "Crédito",
            "Débito"});
            this.cmb_apelidoCartao.Location = new System.Drawing.Point(152, 31);
            this.cmb_apelidoCartao.Name = "cmb_apelidoCartao";
            this.cmb_apelidoCartao.Size = new System.Drawing.Size(237, 23);
            this.cmb_apelidoCartao.TabIndex = 113;
            this.cmb_apelidoCartao.SelectedValueChanged += new System.EventHandler(this.cmb_apelidoCartao_SelectedValueChanged);
            // 
            // txt_bandeiraCartao
            // 
            this.txt_bandeiraCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_bandeiraCartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bandeiraCartao.Location = new System.Drawing.Point(152, 121);
            this.txt_bandeiraCartao.Name = "txt_bandeiraCartao";
            this.txt_bandeiraCartao.Size = new System.Drawing.Size(173, 23);
            this.txt_bandeiraCartao.TabIndex = 105;
            // 
            // txt_bancoCartao
            // 
            this.txt_bancoCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_bancoCartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bancoCartao.Location = new System.Drawing.Point(152, 91);
            this.txt_bancoCartao.Name = "txt_bancoCartao";
            this.txt_bancoCartao.Size = new System.Drawing.Size(173, 23);
            this.txt_bancoCartao.TabIndex = 105;
            // 
            // txt_numeroCartao
            // 
            this.txt_numeroCartao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_numeroCartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroCartao.Location = new System.Drawing.Point(152, 61);
            this.txt_numeroCartao.Name = "txt_numeroCartao";
            this.txt_numeroCartao.Size = new System.Drawing.Size(173, 23);
            this.txt_numeroCartao.TabIndex = 105;
            // 
            // txt_parcela
            // 
            this.txt_parcela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_parcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_parcela.Location = new System.Drawing.Point(196, 299);
            this.txt_parcela.Name = "txt_parcela";
            this.txt_parcela.Size = new System.Drawing.Size(123, 23);
            this.txt_parcela.TabIndex = 114;
            this.txt_parcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbx_pago
            // 
            this.cbx_pago.AutoSize = true;
            this.cbx_pago.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_pago.Location = new System.Drawing.Point(325, 331);
            this.cbx_pago.Name = "cbx_pago";
            this.cbx_pago.Size = new System.Drawing.Size(65, 23);
            this.cbx_pago.TabIndex = 145;
            this.cbx_pago.Text = "Pagar";
            this.cbx_pago.UseVisualStyleBackColor = true;
            this.cbx_pago.CheckedChanged += new System.EventHandler(this.cbx_pago_CheckedChanged);
            // 
            // lbl_dataPagamento
            // 
            this.lbl_dataPagamento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lbl_dataPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_dataPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dataPagamento.Location = new System.Drawing.Point(451, 329);
            this.lbl_dataPagamento.Name = "lbl_dataPagamento";
            this.lbl_dataPagamento.Size = new System.Drawing.Size(123, 23);
            this.lbl_dataPagamento.TabIndex = 131;
            this.lbl_dataPagamento.Text = "Data Pgto";
            this.lbl_dataPagamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valorJuros
            // 
            this.txt_valorJuros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_valorJuros.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorJuros.Location = new System.Drawing.Point(196, 359);
            this.txt_valorJuros.Name = "txt_valorJuros";
            this.txt_valorJuros.Size = new System.Drawing.Size(123, 23);
            this.txt_valorJuros.TabIndex = 114;
            this.txt_valorJuros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label28.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(70, 359);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(120, 23);
            this.label28.TabIndex = 128;
            this.label28.Text = "Juros (R$)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_valorTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTotal.Location = new System.Drawing.Point(451, 359);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.Size = new System.Drawing.Size(123, 23);
            this.txt_valorTotal.TabIndex = 114;
            this.txt_valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label29.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(325, 359);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(120, 23);
            this.label29.TabIndex = 128;
            this.label29.Text = "Valor Total (R$)";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_dataTransacao
            // 
            this.dtp_dataTransacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataTransacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataTransacao.Location = new System.Drawing.Point(196, 119);
            this.dtp_dataTransacao.Name = "dtp_dataTransacao";
            this.dtp_dataTransacao.Size = new System.Drawing.Size(123, 23);
            this.dtp_dataTransacao.TabIndex = 146;
            // 
            // dtp_dataVencimento
            // 
            this.dtp_dataVencimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataVencimento.Location = new System.Drawing.Point(196, 329);
            this.dtp_dataVencimento.Name = "dtp_dataVencimento";
            this.dtp_dataVencimento.Size = new System.Drawing.Size(123, 23);
            this.dtp_dataVencimento.TabIndex = 146;
            // 
            // dtp_dataPagamento
            // 
            this.dtp_dataPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataPagamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataPagamento.Location = new System.Drawing.Point(580, 329);
            this.dtp_dataPagamento.Name = "dtp_dataPagamento";
            this.dtp_dataPagamento.Size = new System.Drawing.Size(123, 23);
            this.dtp_dataPagamento.TabIndex = 146;
            // 
            // txt_diaVencimento
            // 
            this.txt_diaVencimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_diaVencimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diaVencimento.Location = new System.Drawing.Point(152, 149);
            this.txt_diaVencimento.Name = "txt_diaVencimento";
            this.txt_diaVencimento.Size = new System.Drawing.Size(123, 23);
            this.txt_diaVencimento.TabIndex = 105;
            this.txt_diaVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 23);
            this.label2.TabIndex = 142;
            this.label2.Text = "Dia Vencimento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_addContasPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 727);
            this.ControlBox = false;
            this.Controls.Add(this.dtp_dataPagamento);
            this.Controls.Add(this.dtp_dataVencimento);
            this.Controls.Add(this.dtp_dataTransacao);
            this.Controls.Add(this.cbx_pago);
            this.Controls.Add(this.gbx_cartoes);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_dataPagamento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_valorParcela);
            this.Controls.Add(this.txt_qtdParcela);
            this.Controls.Add(this.txt_valorJuros);
            this.Controls.Add(this.txt_valorTotal);
            this.Controls.Add(this.txt_parcela);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.cmb_contaBancaria);
            this.Controls.Add(this.cmb_formaPgto);
            this.Controls.Add(this.cmb_condPgto);
            this.Controls.Add(this.cmb_fornecedor);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addContasPagar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addContasPagar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_addContasPagar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbx_cartoes.ResumeLayout(false);
            this.gbx_cartoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.ComboBox cmb_contaBancaria;
        private System.Windows.Forms.ComboBox cmb_formaPgto;
        private System.Windows.Forms.ComboBox cmb_condPgto;
        private System.Windows.Forms.ComboBox cmb_fornecedor;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_qtdParcela;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox txt_valorParcela;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox gbx_cartoes;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txt_saldoCartao;
        private System.Windows.Forms.ComboBox cmb_apelidoCartao;
        private System.Windows.Forms.TextBox txt_bandeiraCartao;
        private System.Windows.Forms.TextBox txt_bancoCartao;
        private System.Windows.Forms.TextBox txt_numeroCartao;
        private System.Windows.Forms.TextBox txt_parcela;
        private System.Windows.Forms.CheckBox cbx_pago;
        private System.Windows.Forms.Label lbl_dataPagamento;
        private System.Windows.Forms.TextBox txt_valorJuros;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.DateTimePicker dtp_dataTransacao;
        private System.Windows.Forms.DateTimePicker dtp_dataVencimento;
        private System.Windows.Forms.DateTimePicker dtp_dataPagamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_diaVencimento;
    }
}