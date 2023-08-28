
namespace SistemaSegsal.Views
{
    partial class frm_listaPropostaComercialServico
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_addServico = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.cmb_descricao = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmb_tipoServico = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_qtd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_valorTotal = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_descricao = new System.Windows.Forms.TextBox();
            this.txt_valorUnitario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_dataProposta = new System.Windows.Forms.MaskedTextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvw_listaServico = new System.Windows.Forms.ListView();
            this.label15 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_servico = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btn_addServico);
            this.groupBox2.Controls.Add(this.btn_calcular);
            this.groupBox2.Controls.Add(this.cmb_descricao);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.cmb_tipoServico);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_qtd);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_valorTotal);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_descricao);
            this.groupBox2.Controls.Add(this.txt_valorUnitario);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_id);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(275, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 135);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados do Serviço";
            // 
            // btn_addServico
            // 
            this.btn_addServico.BackColor = System.Drawing.Color.Navy;
            this.btn_addServico.FlatAppearance.BorderSize = 0;
            this.btn_addServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addServico.ForeColor = System.Drawing.Color.White;
            this.btn_addServico.Location = new System.Drawing.Point(631, 86);
            this.btn_addServico.Name = "btn_addServico";
            this.btn_addServico.Size = new System.Drawing.Size(37, 24);
            this.btn_addServico.TabIndex = 13;
            this.btn_addServico.Text = "+";
            this.btn_addServico.UseVisualStyleBackColor = false;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(815, 86);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(89, 24);
            this.btn_calcular.TabIndex = 13;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // cmb_descricao
            // 
            this.cmb_descricao.BackColor = System.Drawing.Color.White;
            this.cmb_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_descricao.ForeColor = System.Drawing.Color.Black;
            this.cmb_descricao.FormattingEnabled = true;
            this.cmb_descricao.Location = new System.Drawing.Point(29, 86);
            this.cmb_descricao.Name = "cmb_descricao";
            this.cmb_descricao.Size = new System.Drawing.Size(596, 23);
            this.cmb_descricao.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(26, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Descrição do Serviço";
            // 
            // cmb_tipoServico
            // 
            this.cmb_tipoServico.BackColor = System.Drawing.Color.White;
            this.cmb_tipoServico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipoServico.ForeColor = System.Drawing.Color.Black;
            this.cmb_tipoServico.FormattingEnabled = true;
            this.cmb_tipoServico.Location = new System.Drawing.Point(113, 40);
            this.cmb_tipoServico.Name = "cmb_tipoServico";
            this.cmb_tipoServico.Size = new System.Drawing.Size(225, 23);
            this.cmb_tipoServico.TabIndex = 5;
            this.cmb_tipoServico.SelectedValueChanged += new System.EventHandler(this.cmb_tipoServico_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Tipo de Serviço";
            // 
            // txt_qtd
            // 
            this.txt_qtd.BackColor = System.Drawing.Color.White;
            this.txt_qtd.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtd.ForeColor = System.Drawing.Color.Black;
            this.txt_qtd.Location = new System.Drawing.Point(344, 40);
            this.txt_qtd.Name = "txt_qtd";
            this.txt_qtd.Size = new System.Drawing.Size(78, 23);
            this.txt_qtd.TabIndex = 7;
            this.txt_qtd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_qtd.TextChanged += new System.EventHandler(this.txt_qtd_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(341, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Qtd";
            // 
            // txt_valorTotal
            // 
            this.txt_valorTotal.BackColor = System.Drawing.Color.White;
            this.txt_valorTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorTotal.ForeColor = System.Drawing.Color.Black;
            this.txt_valorTotal.Location = new System.Drawing.Point(911, 86);
            this.txt_valorTotal.Name = "txt_valorTotal";
            this.txt_valorTotal.Size = new System.Drawing.Size(135, 23);
            this.txt_valorTotal.TabIndex = 7;
            this.txt_valorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(908, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 12;
            this.label10.Text = "Valor Total";
            // 
            // txt_descricao
            // 
            this.txt_descricao.BackColor = System.Drawing.Color.White;
            this.txt_descricao.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_descricao.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descricao.ForeColor = System.Drawing.Color.Black;
            this.txt_descricao.Location = new System.Drawing.Point(29, 86);
            this.txt_descricao.Name = "txt_descricao";
            this.txt_descricao.Size = new System.Drawing.Size(639, 23);
            this.txt_descricao.TabIndex = 7;
            // 
            // txt_valorUnitario
            // 
            this.txt_valorUnitario.BackColor = System.Drawing.Color.White;
            this.txt_valorUnitario.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorUnitario.ForeColor = System.Drawing.Color.Black;
            this.txt_valorUnitario.Location = new System.Drawing.Point(674, 86);
            this.txt_valorUnitario.Name = "txt_valorUnitario";
            this.txt_valorUnitario.Size = new System.Drawing.Size(135, 23);
            this.txt_valorUnitario.TabIndex = 7;
            this.txt_valorUnitario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_valorUnitario.TextChanged += new System.EventHandler(this.txt_valorUnitario_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(671, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Valor Unitário";
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(29, 40);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(78, 23);
            this.txt_id.TabIndex = 7;
            this.txt_id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Id";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txt_dataProposta);
            this.groupBox1.Controls.Add(this.txt_cliente);
            this.groupBox1.Controls.Add(this.txt_valor);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txt_codigo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_titulo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(275, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1068, 125);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Proposta";
            // 
            // txt_dataProposta
            // 
            this.txt_dataProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dataProposta.Location = new System.Drawing.Point(158, 41);
            this.txt_dataProposta.Mask = "00/00/0000";
            this.txt_dataProposta.Name = "txt_dataProposta";
            this.txt_dataProposta.Size = new System.Drawing.Size(100, 23);
            this.txt_dataProposta.TabIndex = 22;
            this.txt_dataProposta.ValidatingType = typeof(System.DateTime);
            // 
            // txt_cliente
            // 
            this.txt_cliente.BackColor = System.Drawing.Color.White;
            this.txt_cliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cliente.ForeColor = System.Drawing.Color.Black;
            this.txt_cliente.Location = new System.Drawing.Point(264, 41);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(641, 23);
            this.txt_cliente.TabIndex = 16;
            // 
            // txt_valor
            // 
            this.txt_valor.BackColor = System.Drawing.Color.White;
            this.txt_valor.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valor.ForeColor = System.Drawing.Color.Black;
            this.txt_valor.Location = new System.Drawing.Point(911, 82);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(135, 23);
            this.txt_valor.TabIndex = 16;
            this.txt_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(908, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 15);
            this.label13.TabIndex = 15;
            this.label13.Text = "Valor Total (R$)";
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.Black;
            this.txt_codigo.Location = new System.Drawing.Point(29, 41);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 23);
            this.txt_codigo.TabIndex = 7;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Data Proposta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Código";
            // 
            // txt_titulo
            // 
            this.txt_titulo.BackColor = System.Drawing.Color.White;
            this.txt_titulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_titulo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_titulo.ForeColor = System.Drawing.Color.Black;
            this.txt_titulo.Location = new System.Drawing.Point(29, 82);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(876, 23);
            this.txt_titulo.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Título";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(264, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Cliente";
            // 
            // lvw_listaServico
            // 
            this.lvw_listaServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaServico.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaServico.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaServico.FullRowSelect = true;
            this.lvw_listaServico.GridLines = true;
            this.lvw_listaServico.HideSelection = false;
            this.lvw_listaServico.Location = new System.Drawing.Point(275, 387);
            this.lvw_listaServico.Name = "lvw_listaServico";
            this.lvw_listaServico.Size = new System.Drawing.Size(1068, 298);
            this.lvw_listaServico.TabIndex = 15;
            this.lvw_listaServico.UseCompatibleStateImageBehavior = false;
            this.lvw_listaServico.View = System.Windows.Forms.View.Details;
            this.lvw_listaServico.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaServico_ItemSelectionChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(272, 369);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(98, 15);
            this.label15.TabIndex = 18;
            this.label15.Text = "Lista de Serviços";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btn_atualizar);
            this.panel2.Controls.Add(this.btn_sair);
            this.panel2.Controls.Add(this.btn_imprimir);
            this.panel2.Controls.Add(this.btn_servico);
            this.panel2.Controls.Add(this.btn_deletar);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_novo);
            this.panel2.Controls.Add(this.btn_salvar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 747);
            this.panel2.TabIndex = 20;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 80);
            this.panel3.TabIndex = 22;
            // 
            // btn_atualizar
            // 
            this.btn_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_atualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_atualizar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_atualizar.FlatAppearance.BorderSize = 0;
            this.btn_atualizar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_atualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_atualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_atualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atualizar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atualizar.ForeColor = System.Drawing.Color.White;
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.atualizar2;
            this.btn_atualizar.Location = new System.Drawing.Point(0, 460);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(250, 60);
            this.btn_atualizar.TabIndex = 16;
            this.btn_atualizar.Text = "                      Atualizar";
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            this.btn_atualizar.Click += new System.EventHandler(this.btn_atualizar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_sair.FlatAppearance.BorderSize = 0;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.ForeColor = System.Drawing.Color.White;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(0, 520);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(250, 60);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.Text = "                               Sair";
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_imprimir.FlatAppearance.BorderSize = 0;
            this.btn_imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_imprimir.ForeColor = System.Drawing.Color.White;
            this.btn_imprimir.Image = global::SistemaSegsal.Properties.Resources.imprimir;
            this.btn_imprimir.Location = new System.Drawing.Point(0, 160);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(250, 60);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.Text = "                        Imprimir";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_servico
            // 
            this.btn_servico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_servico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servico.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_servico.FlatAppearance.BorderSize = 0;
            this.btn_servico.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_servico.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_servico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_servico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_servico.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_servico.ForeColor = System.Drawing.Color.White;
            this.btn_servico.Image = global::SistemaSegsal.Properties.Resources.servico;
            this.btn_servico.Location = new System.Drawing.Point(0, 580);
            this.btn_servico.Name = "btn_servico";
            this.btn_servico.Size = new System.Drawing.Size(250, 60);
            this.btn_servico.TabIndex = 3;
            this.btn_servico.Text = "                         Serviço";
            this.btn_servico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_servico.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_deletar.FlatAppearance.BorderSize = 0;
            this.btn_deletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_deletar.ForeColor = System.Drawing.Color.White;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar;
            this.btn_deletar.Location = new System.Drawing.Point(0, 340);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(250, 60);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.Text = "                          Excluir";
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(0, 280);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(250, 60);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.Text = "                            Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(0, 220);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(250, 60);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "                       Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(0, 100);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(250, 60);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.Text = "                            Novo";
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salvar.FlatAppearance.BorderSize = 0;
            this.btn_salvar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar;
            this.btn_salvar.Location = new System.Drawing.Point(0, 400);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(250, 60);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "                           Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            this.btn_salvar.Click += new System.EventHandler(this.btn_salvar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(250, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 80);
            this.panel1.TabIndex = 21;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(20, 15);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(499, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Serviços da Proposta Comercial";
            // 
            // frm_listaPropostaComercialServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 747);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lvw_listaServico);
            this.Controls.Add(this.label15);
            this.Name = "frm_listaPropostaComercialServico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listaPropostaComercialServico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaPropostaComercialServico_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmb_tipoServico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_titulo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvw_listaServico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_servico;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.ComboBox cmb_descricao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_qtd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_valorTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_descricao;
        private System.Windows.Forms.TextBox txt_valorUnitario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txt_dataProposta;
        private System.Windows.Forms.Button btn_addServico;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Panel panel3;
    }
}