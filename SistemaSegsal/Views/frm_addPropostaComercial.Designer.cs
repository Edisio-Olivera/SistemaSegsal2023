
namespace SistemaSegsal.Views
{
    partial class frm_addPropostaComercial
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_dataProposta = new System.Windows.Forms.Button();
            this.txt_dataProposta = new System.Windows.Forms.MaskedTextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cmb_base = new System.Windows.Forms.ComboBox();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txt_observacao = new System.Windows.Forms.TextBox();
            this.cmb_formaPgto = new System.Windows.Forms.ComboBox();
            this.cmb_condPgto = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btn_addCliente = new System.Windows.Forms.Button();
            this.btn_addBase = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.img_logoEmpresa);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 60);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(213, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRAR NOVA PROPOSTA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 36);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(243, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre com as Informações abaixo:";
            // 
            // btn_dataProposta
            // 
            this.btn_dataProposta.BackColor = System.Drawing.Color.Gray;
            this.btn_dataProposta.FlatAppearance.BorderSize = 0;
            this.btn_dataProposta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dataProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dataProposta.ForeColor = System.Drawing.Color.White;
            this.btn_dataProposta.Location = new System.Drawing.Point(265, 233);
            this.btn_dataProposta.Name = "btn_dataProposta";
            this.btn_dataProposta.Size = new System.Drawing.Size(56, 23);
            this.btn_dataProposta.TabIndex = 27;
            this.btn_dataProposta.Text = "Hoje";
            this.btn_dataProposta.UseVisualStyleBackColor = false;
            this.btn_dataProposta.Click += new System.EventHandler(this.btn_dataProposta_Click);
            // 
            // txt_dataProposta
            // 
            this.txt_dataProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataProposta.Location = new System.Drawing.Point(136, 233);
            this.txt_dataProposta.Mask = "00/00/0000";
            this.txt_dataProposta.Name = "txt_dataProposta";
            this.txt_dataProposta.Size = new System.Drawing.Size(123, 23);
            this.txt_dataProposta.TabIndex = 26;
            this.txt_dataProposta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.Black;
            this.txt_codigo.Location = new System.Drawing.Point(136, 204);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 23);
            this.txt_codigo.TabIndex = 22;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(136, 175);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 23);
            this.txt_id.TabIndex = 21;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(12, 175);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 21;
            this.textBox1.Text = " Id";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(12, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 21;
            this.textBox2.Text = " Código";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(12, 233);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 21;
            this.textBox3.Text = " Data";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.Black;
            this.textBox4.Location = new System.Drawing.Point(12, 262);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(118, 23);
            this.textBox4.TabIndex = 21;
            this.textBox4.Text = " Cliente";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.Black;
            this.textBox5.Location = new System.Drawing.Point(12, 291);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 23);
            this.textBox5.TabIndex = 21;
            this.textBox5.Text = " Base do Cliente";
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(12, 320);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 23);
            this.textBox6.TabIndex = 21;
            this.textBox6.Text = " Título";
            // 
            // cmb_base
            // 
            this.cmb_base.BackColor = System.Drawing.Color.White;
            this.cmb_base.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_base.ForeColor = System.Drawing.Color.Black;
            this.cmb_base.FormattingEnabled = true;
            this.cmb_base.Location = new System.Drawing.Point(136, 291);
            this.cmb_base.Name = "cmb_base";
            this.cmb_base.Size = new System.Drawing.Size(465, 23);
            this.cmb_base.TabIndex = 29;
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.BackColor = System.Drawing.Color.White;
            this.cmb_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.ForeColor = System.Drawing.Color.Black;
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(136, 262);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(465, 23);
            this.cmb_cliente.TabIndex = 28;
            this.cmb_cliente.SelectedValueChanged += new System.EventHandler(this.cmb_cliente_SelectedValueChanged);
            // 
            // txt_titulo
            // 
            this.txt_titulo.BackColor = System.Drawing.Color.White;
            this.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.ForeColor = System.Drawing.Color.Black;
            this.txt_titulo.Location = new System.Drawing.Point(136, 320);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(636, 23);
            this.txt_titulo.TabIndex = 30;
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.Color.White;
            this.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.ForeColor = System.Drawing.Color.Black;
            this.txt_descricao.Location = new System.Drawing.Point(136, 349);
            this.txt_descricao.Multiline = true;
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(636, 64);
            this.txt_descricao.TabIndex = 31;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(12, 349);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 64);
            this.textBox7.TabIndex = 21;
            this.textBox7.Text = "Descrição";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(12, 419);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(118, 64);
            this.textBox8.TabIndex = 21;
            this.textBox8.Text = "Observações";
            // 
            // txt_observacao
            // 
            this.txt_observacao.BackColor = System.Drawing.Color.White;
            this.txt_observacao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_observacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_observacao.ForeColor = System.Drawing.Color.Black;
            this.txt_observacao.Location = new System.Drawing.Point(136, 419);
            this.txt_observacao.Multiline = true;
            this.txt_observacao.Name = "txt_observacao";
            this.txt_observacao.Size = new System.Drawing.Size(636, 64);
            this.txt_observacao.TabIndex = 31;
            // 
            // cmb_formaPgto
            // 
            this.cmb_formaPgto.BackColor = System.Drawing.Color.White;
            this.cmb_formaPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_formaPgto.ForeColor = System.Drawing.Color.Black;
            this.cmb_formaPgto.FormattingEnabled = true;
            this.cmb_formaPgto.Location = new System.Drawing.Point(136, 518);
            this.cmb_formaPgto.Name = "cmb_formaPgto";
            this.cmb_formaPgto.Size = new System.Drawing.Size(465, 23);
            this.cmb_formaPgto.TabIndex = 33;
            // 
            // cmb_condPgto
            // 
            this.cmb_condPgto.BackColor = System.Drawing.Color.White;
            this.cmb_condPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_condPgto.ForeColor = System.Drawing.Color.Black;
            this.cmb_condPgto.FormattingEnabled = true;
            this.cmb_condPgto.Location = new System.Drawing.Point(136, 489);
            this.cmb_condPgto.Name = "cmb_condPgto";
            this.cmb_condPgto.Size = new System.Drawing.Size(465, 23);
            this.cmb_condPgto.TabIndex = 32;
            this.cmb_condPgto.SelectedValueChanged += new System.EventHandler(this.cmb_condPgto_SelectedValueChanged);
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(12, 489);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(118, 23);
            this.textBox10.TabIndex = 21;
            this.textBox10.Text = " Cond. Pgto";
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(12, 518);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(118, 23);
            this.textBox11.TabIndex = 21;
            this.textBox11.Text = " Forma Pgto";
            // 
            // btn_addCliente
            // 
            this.btn_addCliente.BackColor = System.Drawing.Color.Green;
            this.btn_addCliente.FlatAppearance.BorderSize = 0;
            this.btn_addCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCliente.ForeColor = System.Drawing.Color.White;
            this.btn_addCliente.Location = new System.Drawing.Point(607, 262);
            this.btn_addCliente.Name = "btn_addCliente";
            this.btn_addCliente.Size = new System.Drawing.Size(165, 23);
            this.btn_addCliente.TabIndex = 27;
            this.btn_addCliente.Text = "Novo Cliente";
            this.btn_addCliente.UseVisualStyleBackColor = false;
            this.btn_addCliente.Click += new System.EventHandler(this.btn_addCliente_Click);
            // 
            // btn_addBase
            // 
            this.btn_addBase.BackColor = System.Drawing.Color.Green;
            this.btn_addBase.FlatAppearance.BorderSize = 0;
            this.btn_addBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBase.ForeColor = System.Drawing.Color.White;
            this.btn_addBase.Location = new System.Drawing.Point(607, 291);
            this.btn_addBase.Name = "btn_addBase";
            this.btn_addBase.Size = new System.Drawing.Size(165, 23);
            this.btn_addBase.TabIndex = 27;
            this.btn_addBase.Text = "Nova Base do Cliente";
            this.btn_addBase.UseVisualStyleBackColor = false;
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(12, 547);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(118, 23);
            this.textBox9.TabIndex = 21;
            this.textBox9.Text = " Valor (R$)";
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.White;
            this.txt_valor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.ForeColor = System.Drawing.Color.Black;
            this.txt_valor.Location = new System.Drawing.Point(136, 547);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(123, 23);
            this.txt_valor.TabIndex = 30;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox14.Enabled = false;
            this.textBox14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Black;
            this.textBox14.Location = new System.Drawing.Point(12, 576);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(118, 23);
            this.textBox14.TabIndex = 21;
            this.textBox14.Text = " Status";
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar;
            this.btn_salvar.Location = new System.Drawing.Point(448, 68);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(60, 55);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(646, 68);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 55);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cabcelar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(712, 68);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(60, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(382, 68);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 55);
            this.btn_novo.TabIndex = 1;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(580, 68);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(60, 55);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar2;
            this.btn_atualizar.Location = new System.Drawing.Point(514, 68);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(60, 55);
            this.btn_atualizar.TabIndex = 34;
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // txt_status
            // 
            this.txt_status.BackColor = System.Drawing.Color.White;
            this.txt_status.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_status.ForeColor = System.Drawing.Color.Black;
            this.txt_status.Location = new System.Drawing.Point(136, 576);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(123, 23);
            this.txt_status.TabIndex = 30;
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(110, 60);
            this.img_logoEmpresa.TabIndex = 35;
            this.img_logoEmpresa.TabStop = false;
            // 
            // frm_addPropostaComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 701);
            this.ControlBox = false;
            this.Controls.Add(this.btn_atualizar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_salvar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.cmb_formaPgto);
            this.Controls.Add(this.cmb_condPgto);
            this.Controls.Add(this.txt_observacao);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.txt_titulo);
            this.Controls.Add(this.cmb_base);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.btn_addBase);
            this.Controls.Add(this.btn_addCliente);
            this.Controls.Add(this.btn_dataProposta);
            this.Controls.Add(this.txt_dataProposta);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addPropostaComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proposta Comercial";
            this.Load += new System.EventHandler(this.frm_addPropostaComercial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_dataProposta;
        private System.Windows.Forms.MaskedTextBox txt_dataProposta;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ComboBox cmb_base;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txt_observacao;
        private System.Windows.Forms.ComboBox cmb_formaPgto;
        private System.Windows.Forms.ComboBox cmb_condPgto;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btn_addCliente;
        private System.Windows.Forms.Button btn_addBase;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
    }
}