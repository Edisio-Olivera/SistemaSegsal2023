
namespace SistemaSegsal.Views
{
    partial class frm_addNotaFiscal
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
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.cmb_tipoNotaFiscal = new System.Windows.Forms.ComboBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_verificacao = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.cmb_cliente = new System.Windows.Forms.ComboBox();
            this.cmb_baseCliente = new System.Windows.Forms.ComboBox();
            this.txt_competencia = new System.Windows.Forms.MaskedTextBox();
            this.txt_pedido = new System.Windows.Forms.TextBox();
            this.txt_diasReceber = new System.Windows.Forms.TextBox();
            this.txt_dataRecebimento = new System.Windows.Forms.MaskedTextBox();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_dataEmissao = new System.Windows.Forms.DateTimePicker();
            this.cmb_condPgto = new System.Windows.Forms.ComboBox();
            this.cmb_formaPgto = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cmb_servico = new System.Windows.Forms.ComboBox();
            this.btn_addServico = new System.Windows.Forms.Button();
            this.lvw_listaServico = new System.Windows.Forms.ListView();
            this.label16 = new System.Windows.Forms.Label();
            this.dtp_dataRecebimento = new System.Windows.Forms.DateTimePicker();
            this.btn_excluirServico = new System.Windows.Forms.Button();
            this.btn_limparLista = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.btn_editar.Location = new System.Drawing.Point(696, 4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 55);
            this.btn_editar.TabIndex = 48;
            this.btn_editar.Text = "     Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
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
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelarR25;
            this.btn_cancelar.Location = new System.Drawing.Point(540, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 47;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
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
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar25;
            this.btn_salvar.Location = new System.Drawing.Point(852, 3);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(150, 55);
            this.btn_salvar.TabIndex = 44;
            this.btn_salvar.Text = "     Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
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
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar25;
            this.btn_atualizar.Location = new System.Drawing.Point(1008, 3);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(150, 55);
            this.btn_atualizar.TabIndex = 46;
            this.btn_atualizar.Text = "     Atualizar";
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // cmb_tipoNotaFiscal
            // 
            this.cmb_tipoNotaFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_tipoNotaFiscal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoNotaFiscal.FormattingEnabled = true;
            this.cmb_tipoNotaFiscal.Location = new System.Drawing.Point(195, 198);
            this.cmb_tipoNotaFiscal.Name = "cmb_tipoNotaFiscal";
            this.cmb_tipoNotaFiscal.Size = new System.Drawing.Size(212, 23);
            this.cmb_tipoNotaFiscal.TabIndex = 2;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigo.Enabled = false;
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(195, 140);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 23);
            this.txt_codigo.TabIndex = 50;
            // 
            // txt_verificacao
            // 
            this.txt_verificacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_verificacao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_verificacao.Location = new System.Drawing.Point(195, 285);
            this.txt_verificacao.Name = "txt_verificacao";
            this.txt_verificacao.Size = new System.Drawing.Size(212, 23);
            this.txt_verificacao.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(195, 111);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 23);
            this.txt_id.TabIndex = 49;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Navy;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1259, 65);
            this.panel1.TabIndex = 51;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaSegsal.Properties.Resources.financeiro2;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 60);
            this.pictureBox1.TabIndex = 67;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(90, 16);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(156, 33);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "NOTA FISCAL";
            // 
            // cmb_cliente
            // 
            this.cmb_cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_cliente.FormattingEnabled = true;
            this.cmb_cliente.Location = new System.Drawing.Point(195, 227);
            this.cmb_cliente.Name = "cmb_cliente";
            this.cmb_cliente.Size = new System.Drawing.Size(212, 23);
            this.cmb_cliente.TabIndex = 3;
            this.cmb_cliente.SelectedValueChanged += new System.EventHandler(this.cmb_cliente_SelectedValueChanged);
            // 
            // cmb_baseCliente
            // 
            this.cmb_baseCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_baseCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_baseCliente.FormattingEnabled = true;
            this.cmb_baseCliente.Location = new System.Drawing.Point(195, 256);
            this.cmb_baseCliente.Name = "cmb_baseCliente";
            this.cmb_baseCliente.Size = new System.Drawing.Size(212, 23);
            this.cmb_baseCliente.TabIndex = 4;
            // 
            // txt_competencia
            // 
            this.txt_competencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_competencia.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_competencia.Location = new System.Drawing.Point(537, 285);
            this.txt_competencia.Mask = "00/0000";
            this.txt_competencia.Name = "txt_competencia";
            this.txt_competencia.Size = new System.Drawing.Size(123, 23);
            this.txt_competencia.TabIndex = 6;
            this.txt_competencia.ValidatingType = typeof(System.DateTime);
            // 
            // txt_pedido
            // 
            this.txt_pedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_pedido.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pedido.Location = new System.Drawing.Point(195, 314);
            this.txt_pedido.Name = "txt_pedido";
            this.txt_pedido.Size = new System.Drawing.Size(212, 23);
            this.txt_pedido.TabIndex = 7;
            // 
            // txt_diasReceber
            // 
            this.txt_diasReceber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_diasReceber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diasReceber.Location = new System.Drawing.Point(537, 314);
            this.txt_diasReceber.Name = "txt_diasReceber";
            this.txt_diasReceber.Size = new System.Drawing.Size(123, 23);
            this.txt_diasReceber.TabIndex = 8;
            // 
            // txt_dataRecebimento
            // 
            this.txt_dataRecebimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_dataRecebimento.Enabled = false;
            this.txt_dataRecebimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataRecebimento.Location = new System.Drawing.Point(782, 172);
            this.txt_dataRecebimento.Mask = "00/00/0000";
            this.txt_dataRecebimento.Name = "txt_dataRecebimento";
            this.txt_dataRecebimento.Size = new System.Drawing.Size(123, 23);
            this.txt_dataRecebimento.TabIndex = 64;
            this.txt_dataRecebimento.ValidatingType = typeof(System.DateTime);
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.Location = new System.Drawing.Point(782, 140);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(465, 23);
            this.txt_descricao.TabIndex = 54;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.Location = new System.Drawing.Point(666, 374);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(118, 23);
            this.txt_valor.TabIndex = 54;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 23);
            this.label1.TabIndex = 67;
            this.label1.Text = "Id";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 67;
            this.label2.Text = "Código";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 23);
            this.label3.TabIndex = 67;
            this.label3.Text = "Data Emissão";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 23);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tipo de Nota";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 23);
            this.label5.TabIndex = 67;
            this.label5.Text = "Cliente";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 23);
            this.label6.TabIndex = 67;
            this.label6.Text = "Base";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(71, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 23);
            this.label7.TabIndex = 67;
            this.label7.Text = "Código Verificação";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 23);
            this.label8.TabIndex = 67;
            this.label8.Text = "Número Pedido";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(666, 314);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 23);
            this.label9.TabIndex = 67;
            this.label9.Text = "Data Recebimento";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(118, 23);
            this.label10.TabIndex = 67;
            this.label10.Text = "Descrição";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(413, 285);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(118, 23);
            this.label11.TabIndex = 67;
            this.label11.Text = "Competência";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(413, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 23);
            this.label12.TabIndex = 67;
            this.label12.Text = "Dias a Receber";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(540, 374);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 23);
            this.label13.TabIndex = 67;
            this.label13.Text = "Valor";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_dataEmissao
            // 
            this.dtp_dataEmissao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataEmissao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataEmissao.Location = new System.Drawing.Point(195, 169);
            this.dtp_dataEmissao.Name = "dtp_dataEmissao";
            this.dtp_dataEmissao.Size = new System.Drawing.Size(123, 23);
            this.dtp_dataEmissao.TabIndex = 1;
            // 
            // cmb_condPgto
            // 
            this.cmb_condPgto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_condPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_condPgto.FormattingEnabled = true;
            this.cmb_condPgto.Location = new System.Drawing.Point(195, 343);
            this.cmb_condPgto.Name = "cmb_condPgto";
            this.cmb_condPgto.Size = new System.Drawing.Size(212, 23);
            this.cmb_condPgto.TabIndex = 9;
            this.cmb_condPgto.SelectedIndexChanged += new System.EventHandler(this.cmb_condPgto_SelectedIndexChanged);
            this.cmb_condPgto.SelectedValueChanged += new System.EventHandler(this.cmb_condPgto_SelectedValueChanged);
            // 
            // cmb_formaPgto
            // 
            this.cmb_formaPgto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_formaPgto.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_formaPgto.FormattingEnabled = true;
            this.cmb_formaPgto.Location = new System.Drawing.Point(537, 343);
            this.cmb_formaPgto.Name = "cmb_formaPgto";
            this.cmb_formaPgto.Size = new System.Drawing.Size(247, 23);
            this.cmb_formaPgto.TabIndex = 10;
            this.cmb_formaPgto.SelectedValueChanged += new System.EventHandler(this.cmb_cliente_SelectedValueChanged);
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label14.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(71, 343);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(118, 23);
            this.label14.TabIndex = 67;
            this.label14.Text = "Condição Pgto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(413, 343);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(118, 23);
            this.label15.TabIndex = 67;
            this.label15.Text = "Forma Pgto";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_servico
            // 
            this.cmb_servico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.cmb_servico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_servico.FormattingEnabled = true;
            this.cmb_servico.Location = new System.Drawing.Point(195, 373);
            this.cmb_servico.Name = "cmb_servico";
            this.cmb_servico.Size = new System.Drawing.Size(212, 23);
            this.cmb_servico.TabIndex = 11;
            this.cmb_servico.SelectedValueChanged += new System.EventHandler(this.cmb_servico_SelectedValueChanged);
            // 
            // btn_addServico
            // 
            this.btn_addServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_addServico.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_addServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_addServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_addServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addServico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addServico.ForeColor = System.Drawing.Color.White;
            this.btn_addServico.Location = new System.Drawing.Point(413, 372);
            this.btn_addServico.Name = "btn_addServico";
            this.btn_addServico.Size = new System.Drawing.Size(118, 24);
            this.btn_addServico.TabIndex = 69;
            this.btn_addServico.Text = "Lançar";
            this.btn_addServico.UseVisualStyleBackColor = false;
            this.btn_addServico.Click += new System.EventHandler(this.btn_addServico_Click);
            // 
            // lvw_listaServico
            // 
            this.lvw_listaServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaServico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaServico.FullRowSelect = true;
            this.lvw_listaServico.GridLines = true;
            this.lvw_listaServico.HideSelection = false;
            this.lvw_listaServico.Location = new System.Drawing.Point(70, 433);
            this.lvw_listaServico.Name = "lvw_listaServico";
            this.lvw_listaServico.Size = new System.Drawing.Size(590, 156);
            this.lvw_listaServico.TabIndex = 70;
            this.lvw_listaServico.UseCompatibleStateImageBehavior = false;
            this.lvw_listaServico.View = System.Windows.Forms.View.Details;
            this.lvw_listaServico.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaServico_ItemSelectionChanged);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(70, 407);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(590, 23);
            this.label16.TabIndex = 67;
            this.label16.Text = "Lista de Serviços";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dtp_dataRecebimento
            // 
            this.dtp_dataRecebimento.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_dataRecebimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_dataRecebimento.Location = new System.Drawing.Point(790, 314);
            this.dtp_dataRecebimento.Name = "dtp_dataRecebimento";
            this.dtp_dataRecebimento.Size = new System.Drawing.Size(123, 23);
            this.dtp_dataRecebimento.TabIndex = 68;
            // 
            // btn_excluirServico
            // 
            this.btn_excluirServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluirServico.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_excluirServico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_excluirServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_excluirServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluirServico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluirServico.ForeColor = System.Drawing.Color.White;
            this.btn_excluirServico.Location = new System.Drawing.Point(666, 433);
            this.btn_excluirServico.Name = "btn_excluirServico";
            this.btn_excluirServico.Size = new System.Drawing.Size(118, 24);
            this.btn_excluirServico.TabIndex = 69;
            this.btn_excluirServico.Text = "Excluir";
            this.btn_excluirServico.UseVisualStyleBackColor = false;
            this.btn_excluirServico.Click += new System.EventHandler(this.btn_excluirServico_Click);
            // 
            // btn_limparLista
            // 
            this.btn_limparLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_limparLista.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_limparLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_limparLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_limparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limparLista.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limparLista.ForeColor = System.Drawing.Color.White;
            this.btn_limparLista.Location = new System.Drawing.Point(666, 463);
            this.btn_limparLista.Name = "btn_limparLista";
            this.btn_limparLista.Size = new System.Drawing.Size(118, 24);
            this.btn_limparLista.TabIndex = 71;
            this.btn_limparLista.Text = "Limpar";
            this.btn_limparLista.UseVisualStyleBackColor = false;
            this.btn_limparLista.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // frm_addNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1259, 724);
            this.ControlBox = false;
            this.Controls.Add(this.btn_limparLista);
            this.Controls.Add(this.lvw_listaServico);
            this.Controls.Add(this.btn_excluirServico);
            this.Controls.Add(this.btn_addServico);
            this.Controls.Add(this.dtp_dataRecebimento);
            this.Controls.Add(this.dtp_dataEmissao);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_competencia);
            this.Controls.Add(this.txt_dataRecebimento);
            this.Controls.Add(this.cmb_baseCliente);
            this.Controls.Add(this.cmb_servico);
            this.Controls.Add(this.cmb_formaPgto);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.cmb_cliente);
            this.Controls.Add(this.cmb_condPgto);
            this.Controls.Add(this.txt_descricao);
            this.Controls.Add(this.cmb_tipoNotaFiscal);
            this.Controls.Add(this.txt_diasReceber);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_pedido);
            this.Controls.Add(this.txt_verificacao);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_addNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nota Fiscal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_addNotaFiscal_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.ComboBox cmb_tipoNotaFiscal;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_verificacao;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cmb_cliente;
        private System.Windows.Forms.ComboBox cmb_baseCliente;
        private System.Windows.Forms.MaskedTextBox txt_competencia;
        private System.Windows.Forms.TextBox txt_pedido;
        private System.Windows.Forms.TextBox txt_diasReceber;
        private System.Windows.Forms.MaskedTextBox txt_dataRecebimento;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_dataEmissao;
        private System.Windows.Forms.ComboBox cmb_condPgto;
        private System.Windows.Forms.ComboBox cmb_formaPgto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cmb_servico;
        private System.Windows.Forms.Button btn_addServico;
        private System.Windows.Forms.ListView lvw_listaServico;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker dtp_dataRecebimento;
        private System.Windows.Forms.Button btn_excluirServico;
        private System.Windows.Forms.Button btn_limparLista;
    }
}