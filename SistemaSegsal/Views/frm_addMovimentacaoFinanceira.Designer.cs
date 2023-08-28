
namespace SistemaSegsal.Views
{
    partial class frm_addMovimentacaoFinanceira
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_base = new System.Windows.Forms.ComboBox();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.btn_addBase = new System.Windows.Forms.Button();
            this.btn_addCliente = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txt_dataRegistro = new System.Windows.Forms.MaskedTextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txt_tipoMovimentacao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.cmb_formaPgto = new System.Windows.Forms.ComboBox();
            this.cmb_condPgto = new System.Windows.Forms.ComboBox();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txt_qtdParcela = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.txt_dataTransacao = new System.Windows.Forms.MaskedTextBox();
            this.btn_dataTransacao = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.txt_dataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.txt_valorParcela = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.txt_valorJuros = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.txt_valorTotalParcela = new System.Windows.Forms.TextBox();
            this.btn_dataPagamento = new System.Windows.Forms.Button();
            this.txt_dataPagamento = new System.Windows.Forms.MaskedTextBox();
            this.textBox21 = new System.Windows.Forms.TextBox();
            this.btn_addCartao = new System.Windows.Forms.Button();
            this.textBox22 = new System.Windows.Forms.TextBox();
            this.cmb_conta = new System.Windows.Forms.ComboBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.cmb_cartao = new System.Windows.Forms.ComboBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.btn_addConta = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.txt_numeroParcela = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_pagarReceber = new System.Windows.Forms.Button();
            this.btn_diminuir = new System.Windows.Forms.Button();
            this.btn_aumentar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 36);
            this.panel2.TabIndex = 6;
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
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(592, 63);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(180, 60);
            this.btn_sair.TabIndex = 4;
            this.btn_sair.Text = "SAIR";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Green;
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(12, 63);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(180, 60);
            this.btn_novo.TabIndex = 5;
            this.btn_novo.Text = "NOVO REGISTRO";
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(784, 57);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(111, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(565, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "CADASTRAR NOVA MOVIMENTAÇÃO FINANCEIRA";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cmb_base.TabIndex = 47;
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
            this.cmb_cliente.TabIndex = 46;
            // 
            // btn_addBase
            // 
            this.btn_addBase.BackColor = System.Drawing.Color.Green;
            this.btn_addBase.FlatAppearance.BorderSize = 0;
            this.btn_addBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addBase.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addBase.ForeColor = System.Drawing.Color.White;
            this.btn_addBase.Location = new System.Drawing.Point(607, 290);
            this.btn_addBase.Name = "btn_addBase";
            this.btn_addBase.Size = new System.Drawing.Size(165, 23);
            this.btn_addBase.TabIndex = 45;
            this.btn_addBase.Text = "Nova Base do Cliente";
            this.btn_addBase.UseVisualStyleBackColor = false;
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
            this.btn_addCliente.TabIndex = 44;
            this.btn_addCliente.Text = "Novo Cliente";
            this.btn_addCliente.UseVisualStyleBackColor = false;
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
            this.textBox5.TabIndex = 36;
            this.textBox5.Text = " Base do Cliente";
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
            this.textBox4.TabIndex = 35;
            this.textBox4.Text = " Cliente";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(12, 320);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 34;
            this.textBox3.Text = " Descrição";
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
            this.textBox1.TabIndex = 40;
            this.textBox1.Text = " Id";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(136, 175);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 23);
            this.txt_id.TabIndex = 32;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Black;
            this.textBox2.Location = new System.Drawing.Point(12, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(118, 23);
            this.textBox2.TabIndex = 34;
            this.textBox2.Text = " Data Registro";
            // 
            // txt_dataRegistro
            // 
            this.txt_dataRegistro.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataRegistro.Location = new System.Drawing.Point(136, 204);
            this.txt_dataRegistro.Mask = "00/00/0000";
            this.txt_dataRegistro.Name = "txt_dataRegistro";
            this.txt_dataRegistro.Size = new System.Drawing.Size(123, 23);
            this.txt_dataRegistro.TabIndex = 42;
            this.txt_dataRegistro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dataRegistro.ValidatingType = typeof(System.DateTime);
            // 
            // textBox9
            // 
            this.textBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.ForeColor = System.Drawing.Color.Black;
            this.textBox9.Location = new System.Drawing.Point(483, 207);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(118, 23);
            this.textBox9.TabIndex = 34;
            this.textBox9.Text = "Tipo Registro";
            // 
            // txt_tipoMovimentacao
            // 
            this.txt_tipoMovimentacao.BackColor = System.Drawing.Color.White;
            this.txt_tipoMovimentacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tipoMovimentacao.ForeColor = System.Drawing.Color.Black;
            this.txt_tipoMovimentacao.Location = new System.Drawing.Point(607, 207);
            this.txt_tipoMovimentacao.Name = "txt_tipoMovimentacao";
            this.txt_tipoMovimentacao.Size = new System.Drawing.Size(44, 23);
            this.txt_tipoMovimentacao.TabIndex = 32;
            this.txt_tipoMovimentacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(657, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 51;
            this.label3.Text = "E - Entrada";
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.Color.White;
            this.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.ForeColor = System.Drawing.Color.Black;
            this.txt_descricao.Location = new System.Drawing.Point(136, 320);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(636, 23);
            this.txt_descricao.TabIndex = 48;
            // 
            // cmb_formaPgto
            // 
            this.cmb_formaPgto.BackColor = System.Drawing.Color.White;
            this.cmb_formaPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_formaPgto.ForeColor = System.Drawing.Color.Black;
            this.cmb_formaPgto.FormattingEnabled = true;
            this.cmb_formaPgto.Location = new System.Drawing.Point(136, 378);
            this.cmb_formaPgto.Name = "cmb_formaPgto";
            this.cmb_formaPgto.Size = new System.Drawing.Size(465, 23);
            this.cmb_formaPgto.TabIndex = 58;
            // 
            // cmb_condPgto
            // 
            this.cmb_condPgto.BackColor = System.Drawing.Color.White;
            this.cmb_condPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_condPgto.ForeColor = System.Drawing.Color.Black;
            this.cmb_condPgto.FormattingEnabled = true;
            this.cmb_condPgto.Location = new System.Drawing.Point(136, 349);
            this.cmb_condPgto.Name = "cmb_condPgto";
            this.cmb_condPgto.Size = new System.Drawing.Size(336, 23);
            this.cmb_condPgto.TabIndex = 57;
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.BackColor = System.Drawing.Color.White;
            this.txt_valorTotal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valorTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTotal.ForeColor = System.Drawing.Color.Black;
            this.txt_valorTotal.Location = new System.Drawing.Point(607, 466);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.Size = new System.Drawing.Size(123, 23);
            this.txt_valorTotal.TabIndex = 56;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.Black;
            this.textBox6.Location = new System.Drawing.Point(12, 378);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(118, 23);
            this.textBox6.TabIndex = 52;
            this.textBox6.Text = " Forma Pgto";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.Black;
            this.textBox7.Location = new System.Drawing.Point(12, 349);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(118, 23);
            this.textBox7.TabIndex = 53;
            this.textBox7.Text = " Cond. Pgto";
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.Black;
            this.textBox8.Location = new System.Drawing.Point(483, 466);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(118, 23);
            this.textBox8.TabIndex = 54;
            this.textBox8.Text = " Valor Total (R$)";
            // 
            // txt_qtdParcela
            // 
            this.txt_qtdParcela.BackColor = System.Drawing.Color.White;
            this.txt_qtdParcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdParcela.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdParcela.Location = new System.Drawing.Point(608, 349);
            this.txt_qtdParcela.Name = "txt_qtdParcela";
            this.txt_qtdParcela.Size = new System.Drawing.Size(61, 23);
            this.txt_qtdParcela.TabIndex = 59;
            this.txt_qtdParcela.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox13
            // 
            this.textBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox13.Enabled = false;
            this.textBox13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox13.ForeColor = System.Drawing.Color.Black;
            this.textBox13.Location = new System.Drawing.Point(12, 233);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(118, 23);
            this.textBox13.TabIndex = 34;
            this.textBox13.Text = " Data Transação";
            // 
            // txt_dataTransacao
            // 
            this.txt_dataTransacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataTransacao.Location = new System.Drawing.Point(136, 233);
            this.txt_dataTransacao.Mask = "00/00/0000";
            this.txt_dataTransacao.Name = "txt_dataTransacao";
            this.txt_dataTransacao.Size = new System.Drawing.Size(123, 23);
            this.txt_dataTransacao.TabIndex = 42;
            this.txt_dataTransacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dataTransacao.ValidatingType = typeof(System.DateTime);
            // 
            // btn_dataTransacao
            // 
            this.btn_dataTransacao.BackColor = System.Drawing.Color.Gray;
            this.btn_dataTransacao.FlatAppearance.BorderSize = 0;
            this.btn_dataTransacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dataTransacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dataTransacao.ForeColor = System.Drawing.Color.White;
            this.btn_dataTransacao.Location = new System.Drawing.Point(265, 233);
            this.btn_dataTransacao.Name = "btn_dataTransacao";
            this.btn_dataTransacao.Size = new System.Drawing.Size(56, 23);
            this.btn_dataTransacao.TabIndex = 43;
            this.btn_dataTransacao.Text = "Hoje";
            this.btn_dataTransacao.UseVisualStyleBackColor = false;
            // 
            // textBox14
            // 
            this.textBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox14.Enabled = false;
            this.textBox14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.Black;
            this.textBox14.Location = new System.Drawing.Point(12, 466);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(118, 23);
            this.textBox14.TabIndex = 34;
            this.textBox14.Text = " Data Vencimento";
            // 
            // txt_dataVencimento
            // 
            this.txt_dataVencimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataVencimento.Location = new System.Drawing.Point(136, 466);
            this.txt_dataVencimento.Mask = "00/00/0000";
            this.txt_dataVencimento.Name = "txt_dataVencimento";
            this.txt_dataVencimento.Size = new System.Drawing.Size(123, 23);
            this.txt_dataVencimento.TabIndex = 42;
            this.txt_dataVencimento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dataVencimento.ValidatingType = typeof(System.DateTime);
            // 
            // textBox15
            // 
            this.textBox15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox15.Enabled = false;
            this.textBox15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox15.ForeColor = System.Drawing.Color.Black;
            this.textBox15.Location = new System.Drawing.Point(12, 495);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(118, 23);
            this.textBox15.TabIndex = 54;
            this.textBox15.Text = " Valor Parcela (R$)";
            // 
            // txt_valorParcela
            // 
            this.txt_valorParcela.BackColor = System.Drawing.Color.White;
            this.txt_valorParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valorParcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorParcela.ForeColor = System.Drawing.Color.Black;
            this.txt_valorParcela.Location = new System.Drawing.Point(136, 495);
            this.txt_valorParcela.Name = "txt_valorParcela";
            this.txt_valorParcela.Size = new System.Drawing.Size(123, 23);
            this.txt_valorParcela.TabIndex = 56;
            // 
            // textBox17
            // 
            this.textBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox17.Enabled = false;
            this.textBox17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.ForeColor = System.Drawing.Color.Black;
            this.textBox17.Location = new System.Drawing.Point(483, 495);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(118, 23);
            this.textBox17.TabIndex = 54;
            this.textBox17.Text = " Valor Juros (R$)";
            // 
            // txt_valorJuros
            // 
            this.txt_valorJuros.BackColor = System.Drawing.Color.White;
            this.txt_valorJuros.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valorJuros.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorJuros.ForeColor = System.Drawing.Color.Black;
            this.txt_valorJuros.Location = new System.Drawing.Point(607, 495);
            this.txt_valorJuros.Name = "txt_valorJuros";
            this.txt_valorJuros.Size = new System.Drawing.Size(123, 23);
            this.txt_valorJuros.TabIndex = 56;
            // 
            // textBox19
            // 
            this.textBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox19.Enabled = false;
            this.textBox19.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox19.ForeColor = System.Drawing.Color.Black;
            this.textBox19.Location = new System.Drawing.Point(12, 524);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(118, 23);
            this.textBox19.TabIndex = 54;
            this.textBox19.Text = " Total Parcela (R$)";
            // 
            // txt_valorTotalParcela
            // 
            this.txt_valorTotalParcela.BackColor = System.Drawing.Color.White;
            this.txt_valorTotalParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valorTotalParcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTotalParcela.ForeColor = System.Drawing.Color.Black;
            this.txt_valorTotalParcela.Location = new System.Drawing.Point(136, 524);
            this.txt_valorTotalParcela.Name = "txt_valorTotalParcela";
            this.txt_valorTotalParcela.Size = new System.Drawing.Size(123, 23);
            this.txt_valorTotalParcela.TabIndex = 56;
            // 
            // btn_dataPagamento
            // 
            this.btn_dataPagamento.BackColor = System.Drawing.Color.Gray;
            this.btn_dataPagamento.FlatAppearance.BorderSize = 0;
            this.btn_dataPagamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dataPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dataPagamento.ForeColor = System.Drawing.Color.White;
            this.btn_dataPagamento.Location = new System.Drawing.Point(674, 553);
            this.btn_dataPagamento.Name = "btn_dataPagamento";
            this.btn_dataPagamento.Size = new System.Drawing.Size(56, 23);
            this.btn_dataPagamento.TabIndex = 62;
            this.btn_dataPagamento.Text = "Hoje";
            this.btn_dataPagamento.UseVisualStyleBackColor = false;
            // 
            // txt_dataPagamento
            // 
            this.txt_dataPagamento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataPagamento.Location = new System.Drawing.Point(607, 524);
            this.txt_dataPagamento.Mask = "00/00/0000";
            this.txt_dataPagamento.Name = "txt_dataPagamento";
            this.txt_dataPagamento.Size = new System.Drawing.Size(123, 23);
            this.txt_dataPagamento.TabIndex = 61;
            this.txt_dataPagamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_dataPagamento.ValidatingType = typeof(System.DateTime);
            // 
            // textBox21
            // 
            this.textBox21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox21.Enabled = false;
            this.textBox21.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox21.ForeColor = System.Drawing.Color.Black;
            this.textBox21.Location = new System.Drawing.Point(483, 524);
            this.textBox21.Name = "textBox21";
            this.textBox21.Size = new System.Drawing.Size(118, 23);
            this.textBox21.TabIndex = 60;
            this.textBox21.Text = " Data Pagamento";
            // 
            // btn_addCartao
            // 
            this.btn_addCartao.BackColor = System.Drawing.Color.Green;
            this.btn_addCartao.FlatAppearance.BorderSize = 0;
            this.btn_addCartao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addCartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addCartao.ForeColor = System.Drawing.Color.White;
            this.btn_addCartao.Location = new System.Drawing.Point(608, 407);
            this.btn_addCartao.Name = "btn_addCartao";
            this.btn_addCartao.Size = new System.Drawing.Size(164, 23);
            this.btn_addCartao.TabIndex = 44;
            this.btn_addCartao.Text = "Novo Cartão";
            this.btn_addCartao.UseVisualStyleBackColor = false;
            // 
            // textBox22
            // 
            this.textBox22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox22.Enabled = false;
            this.textBox22.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox22.ForeColor = System.Drawing.Color.Black;
            this.textBox22.Location = new System.Drawing.Point(12, 436);
            this.textBox22.Name = "textBox22";
            this.textBox22.Size = new System.Drawing.Size(118, 23);
            this.textBox22.TabIndex = 52;
            this.textBox22.Text = " Conta";
            // 
            // cmb_conta
            // 
            this.cmb_conta.BackColor = System.Drawing.Color.White;
            this.cmb_conta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_conta.ForeColor = System.Drawing.Color.Black;
            this.cmb_conta.FormattingEnabled = true;
            this.cmb_conta.Location = new System.Drawing.Point(136, 436);
            this.cmb_conta.Name = "cmb_conta";
            this.cmb_conta.Size = new System.Drawing.Size(465, 23);
            this.cmb_conta.TabIndex = 58;
            // 
            // textBox10
            // 
            this.textBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox10.Enabled = false;
            this.textBox10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox10.ForeColor = System.Drawing.Color.Black;
            this.textBox10.Location = new System.Drawing.Point(12, 407);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(118, 23);
            this.textBox10.TabIndex = 52;
            this.textBox10.Text = " Cartão";
            // 
            // cmb_cartao
            // 
            this.cmb_cartao.BackColor = System.Drawing.Color.White;
            this.cmb_cartao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cartao.ForeColor = System.Drawing.Color.Black;
            this.cmb_cartao.FormattingEnabled = true;
            this.cmb_cartao.Location = new System.Drawing.Point(136, 407);
            this.cmb_cartao.Name = "cmb_cartao";
            this.cmb_cartao.Size = new System.Drawing.Size(465, 23);
            this.cmb_cartao.TabIndex = 58;
            // 
            // textBox11
            // 
            this.textBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox11.Enabled = false;
            this.textBox11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox11.ForeColor = System.Drawing.Color.Black;
            this.textBox11.Location = new System.Drawing.Point(483, 349);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(118, 23);
            this.textBox11.TabIndex = 53;
            this.textBox11.Text = " Qtd Parcela";
            // 
            // btn_addConta
            // 
            this.btn_addConta.BackColor = System.Drawing.Color.Green;
            this.btn_addConta.FlatAppearance.BorderSize = 0;
            this.btn_addConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addConta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addConta.ForeColor = System.Drawing.Color.White;
            this.btn_addConta.Location = new System.Drawing.Point(608, 436);
            this.btn_addConta.Name = "btn_addConta";
            this.btn_addConta.Size = new System.Drawing.Size(164, 23);
            this.btn_addConta.TabIndex = 44;
            this.btn_addConta.Text = "Nova Conta";
            this.btn_addConta.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(657, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 51;
            this.label4.Text = "S - Saída";
            // 
            // textBox12
            // 
            this.textBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox12.Enabled = false;
            this.textBox12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.Black;
            this.textBox12.Location = new System.Drawing.Point(12, 552);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(118, 23);
            this.textBox12.TabIndex = 54;
            this.textBox12.Text = "Parcela";
            // 
            // txt_numeroParcela
            // 
            this.txt_numeroParcela.BackColor = System.Drawing.Color.White;
            this.txt_numeroParcela.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_numeroParcela.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroParcela.ForeColor = System.Drawing.Color.Black;
            this.txt_numeroParcela.Location = new System.Drawing.Point(136, 552);
            this.txt_numeroParcela.Name = "txt_numeroParcela";
            this.txt_numeroParcela.Size = new System.Drawing.Size(123, 23);
            this.txt_numeroParcela.TabIndex = 56;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.btn_salvar);
            this.panel3.Controls.Add(this.btn_editar);
            this.panel3.Controls.Add(this.btn_pagarReceber);
            this.panel3.Controls.Add(this.btn_cancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 611);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 90);
            this.panel3.TabIndex = 63;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.Green;
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar;
            this.btn_salvar.Location = new System.Drawing.Point(34, 18);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(180, 60);
            this.btn_salvar.TabIndex = 1;
            this.btn_salvar.Text = "SALVAR REGISTRO";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Green;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(220, 18);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(180, 60);
            this.btn_editar.TabIndex = 1;
            this.btn_editar.Text = "EDITAR REGISTRO";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(406, 18);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(180, 60);
            this.btn_cancelar.TabIndex = 1;
            this.btn_cancelar.Text = "CANCELAR REGISTRO";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_pagarReceber
            // 
            this.btn_pagarReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_pagarReceber.FlatAppearance.BorderSize = 0;
            this.btn_pagarReceber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pagarReceber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pagarReceber.ForeColor = System.Drawing.Color.White;
            this.btn_pagarReceber.Image = global::SistemaSegsal.Properties.Resources.pagar;
            this.btn_pagarReceber.Location = new System.Drawing.Point(592, 18);
            this.btn_pagarReceber.Name = "btn_pagarReceber";
            this.btn_pagarReceber.Size = new System.Drawing.Size(180, 60);
            this.btn_pagarReceber.TabIndex = 1;
            this.btn_pagarReceber.Text = "PAGAR REGISTRO";
            this.btn_pagarReceber.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_pagarReceber.UseVisualStyleBackColor = false;
            // 
            // btn_diminuir
            // 
            this.btn_diminuir.BackColor = System.Drawing.Color.Gray;
            this.btn_diminuir.FlatAppearance.BorderSize = 0;
            this.btn_diminuir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_diminuir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_diminuir.ForeColor = System.Drawing.Color.White;
            this.btn_diminuir.Location = new System.Drawing.Point(675, 349);
            this.btn_diminuir.Name = "btn_diminuir";
            this.btn_diminuir.Size = new System.Drawing.Size(47, 23);
            this.btn_diminuir.TabIndex = 43;
            this.btn_diminuir.Text = "<<";
            this.btn_diminuir.UseVisualStyleBackColor = false;
            this.btn_diminuir.Click += new System.EventHandler(this.btn_diminuir_Click);
            // 
            // btn_aumentar
            // 
            this.btn_aumentar.BackColor = System.Drawing.Color.Gray;
            this.btn_aumentar.FlatAppearance.BorderSize = 0;
            this.btn_aumentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_aumentar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_aumentar.ForeColor = System.Drawing.Color.White;
            this.btn_aumentar.Location = new System.Drawing.Point(728, 349);
            this.btn_aumentar.Name = "btn_aumentar";
            this.btn_aumentar.Size = new System.Drawing.Size(44, 23);
            this.btn_aumentar.TabIndex = 43;
            this.btn_aumentar.Text = ">>";
            this.btn_aumentar.UseVisualStyleBackColor = false;
            this.btn_aumentar.Click += new System.EventHandler(this.btn_aumentar_Click);
            // 
            // frm_addMovimentacaoFinanceira
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 701);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btn_dataPagamento);
            this.Controls.Add(this.txt_dataPagamento);
            this.Controls.Add(this.textBox21);
            this.Controls.Add(this.txt_qtdParcela);
            this.Controls.Add(this.cmb_cartao);
            this.Controls.Add(this.cmb_conta);
            this.Controls.Add(this.cmb_formaPgto);
            this.Controls.Add(this.cmb_condPgto);
            this.Controls.Add(this.txt_numeroParcela);
            this.Controls.Add(this.txt_valorTotalParcela);
            this.Controls.Add(this.txt_valorParcela);
            this.Controls.Add(this.txt_valorJuros);
            this.Controls.Add(this.txt_valorTotal);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox22);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox19);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.cmb_base);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.btn_addBase);
            this.Controls.Add(this.btn_addConta);
            this.Controls.Add(this.btn_addCartao);
            this.Controls.Add(this.btn_addCliente);
            this.Controls.Add(this.btn_aumentar);
            this.Controls.Add(this.btn_diminuir);
            this.Controls.Add(this.btn_dataTransacao);
            this.Controls.Add(this.txt_dataVencimento);
            this.Controls.Add(this.txt_dataTransacao);
            this.Controls.Add(this.txt_dataRegistro);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txt_tipoMovimentacao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addMovimentacaoFinanceira";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentação Financeira";
            this.Load += new System.EventHandler(this.frm_addMovimentacaoFinanceira_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_base;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.Button btn_addBase;
        private System.Windows.Forms.Button btn_addCliente;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox txt_dataRegistro;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txt_tipoMovimentacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.ComboBox cmb_formaPgto;
        private System.Windows.Forms.ComboBox cmb_condPgto;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txt_qtdParcela;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.MaskedTextBox txt_dataTransacao;
        private System.Windows.Forms.Button btn_dataTransacao;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.MaskedTextBox txt_dataVencimento;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox txt_valorParcela;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox txt_valorJuros;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.TextBox txt_valorTotalParcela;
        private System.Windows.Forms.Button btn_dataPagamento;
        private System.Windows.Forms.MaskedTextBox txt_dataPagamento;
        private System.Windows.Forms.TextBox textBox21;
        private System.Windows.Forms.Button btn_addCartao;
        private System.Windows.Forms.TextBox textBox22;
        private System.Windows.Forms.ComboBox cmb_conta;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ComboBox cmb_cartao;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Button btn_addConta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txt_numeroParcela;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_pagarReceber;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_diminuir;
        private System.Windows.Forms.Button btn_aumentar;
    }
}