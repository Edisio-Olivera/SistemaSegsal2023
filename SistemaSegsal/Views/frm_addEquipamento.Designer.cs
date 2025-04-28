
namespace SistemaSegsal.Views
{
    partial class frm_addEquipamento
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
            this.img_imagem = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_valorVenda = new System.Windows.Forms.TextBox();
            this.txt_valorCompra = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.txt_estoque = new System.Windows.Forms.TextBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmb_unidade = new System.Windows.Forms.ComboBox();
            this.btn_atualizar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_descritivo = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_ncm = new System.Windows.Forms.TextBox();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.btn_salvar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_fabricante = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_imagem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // img_imagem
            // 
            this.img_imagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.img_imagem.Location = new System.Drawing.Point(842, 97);
            this.img_imagem.Name = "img_imagem";
            this.img_imagem.Size = new System.Drawing.Size(264, 250);
            this.img_imagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_imagem.TabIndex = 29;
            this.img_imagem.TabStop = false;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label16.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(85, 353);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(119, 23);
            this.label16.TabIndex = 28;
            this.label16.Text = "Valor Compra (R$)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label15.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(85, 321);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 23);
            this.label15.TabIndex = 28;
            this.label15.Text = "Estoque";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_valorVenda
            // 
            this.txt_valorVenda.BackColor = System.Drawing.Color.White;
            this.txt_valorVenda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valorVenda.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorVenda.ForeColor = System.Drawing.Color.Black;
            this.txt_valorVenda.Location = new System.Drawing.Point(210, 385);
            this.txt_valorVenda.Name = "txt_valorVenda";
            this.txt_valorVenda.Size = new System.Drawing.Size(123, 23);
            this.txt_valorVenda.TabIndex = 17;
            // 
            // txt_valorCompra
            // 
            this.txt_valorCompra.BackColor = System.Drawing.Color.White;
            this.txt_valorCompra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_valorCompra.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorCompra.ForeColor = System.Drawing.Color.Black;
            this.txt_valorCompra.Location = new System.Drawing.Point(210, 353);
            this.txt_valorCompra.Name = "txt_valorCompra";
            this.txt_valorCompra.Size = new System.Drawing.Size(123, 23);
            this.txt_valorCompra.TabIndex = 17;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.Color.White;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar25;
            this.btn_cancelar.Location = new System.Drawing.Point(886, 3);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(150, 55);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.Text = "     Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // txt_estoque
            // 
            this.txt_estoque.BackColor = System.Drawing.Color.White;
            this.txt_estoque.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_estoque.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_estoque.ForeColor = System.Drawing.Color.Black;
            this.txt_estoque.Location = new System.Drawing.Point(210, 321);
            this.txt_estoque.Name = "txt_estoque";
            this.txt_estoque.Size = new System.Drawing.Size(123, 23);
            this.txt_estoque.TabIndex = 17;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(80, 6);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(226, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Equipamento";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(85, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 23);
            this.label9.TabIndex = 28;
            this.label9.Text = "Unidade";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_unidade
            // 
            this.cmb_unidade.BackColor = System.Drawing.Color.White;
            this.cmb_unidade.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_unidade.ForeColor = System.Drawing.Color.Black;
            this.cmb_unidade.FormattingEnabled = true;
            this.cmb_unidade.Location = new System.Drawing.Point(210, 257);
            this.cmb_unidade.Name = "cmb_unidade";
            this.cmb_unidade.Size = new System.Drawing.Size(123, 23);
            this.cmb_unidade.TabIndex = 5;
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
            this.btn_atualizar.Image = global::SistemaSegsal.Properties.Resources.sair25;
            this.btn_atualizar.Location = new System.Drawing.Point(1158, 5);
            this.btn_atualizar.Name = "btn_atualizar";
            this.btn_atualizar.Size = new System.Drawing.Size(150, 55);
            this.btn_atualizar.TabIndex = 1;
            this.btn_atualizar.Text = "     Atualizar";
            this.btn_atualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_atualizar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editar.ForeColor = System.Drawing.Color.White;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar25;
            this.btn_editar.Location = new System.Drawing.Point(572, 5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(150, 55);
            this.btn_editar.TabIndex = 0;
            this.btn_editar.Text = "     Editar";
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 23);
            this.label1.TabIndex = 28;
            this.label1.Text = "Descritivo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(85, 161);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "Categoria";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label17.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(85, 385);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 23);
            this.label17.TabIndex = 28;
            this.label17.Text = "Valor Venda (R$)";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 28;
            this.label3.Text = "NCM";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(85, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 23);
            this.label11.TabIndex = 28;
            this.label11.Text = "Código";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_descritivo
            // 
            this.txt_descritivo.BackColor = System.Drawing.Color.White;
            this.txt_descritivo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descritivo.ForeColor = System.Drawing.Color.Black;
            this.txt_descritivo.Location = new System.Drawing.Point(210, 225);
            this.txt_descritivo.Name = "txt_descritivo";
            this.txt_descritivo.Size = new System.Drawing.Size(502, 23);
            this.txt_descritivo.TabIndex = 16;
            // 
            // txt_codigo
            // 
            this.txt_codigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_codigo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.ForeColor = System.Drawing.Color.Black;
            this.txt_codigo.Location = new System.Drawing.Point(210, 129);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(123, 23);
            this.txt_codigo.TabIndex = 7;
            this.txt_codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_ncm
            // 
            this.txt_ncm.BackColor = System.Drawing.Color.White;
            this.txt_ncm.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ncm.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ncm.ForeColor = System.Drawing.Color.Black;
            this.txt_ncm.Location = new System.Drawing.Point(210, 289);
            this.txt_ncm.Name = "txt_ncm";
            this.txt_ncm.Size = new System.Drawing.Size(123, 23);
            this.txt_ncm.TabIndex = 17;
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.BackColor = System.Drawing.Color.White;
            this.cmb_categoria.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_categoria.ForeColor = System.Drawing.Color.Black;
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(210, 161);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(248, 23);
            this.cmb_categoria.TabIndex = 5;
            // 
            // btn_salvar
            // 
            this.btn_salvar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_salvar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_salvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_salvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salvar.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvar.ForeColor = System.Drawing.Color.White;
            this.btn_salvar.Image = global::SistemaSegsal.Properties.Resources.salvar25;
            this.btn_salvar.Location = new System.Drawing.Point(728, 4);
            this.btn_salvar.Name = "btn_salvar";
            this.btn_salvar.Size = new System.Drawing.Size(150, 55);
            this.btn_salvar.TabIndex = 15;
            this.btn_salvar.Text = "     Salvar";
            this.btn_salvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_salvar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btn_atualizar);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_salvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 65);
            this.panel1.TabIndex = 32;
            // 
            // txt_id
            // 
            this.txt_id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_id.Enabled = false;
            this.txt_id.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.ForeColor = System.Drawing.Color.Black;
            this.txt_id.Location = new System.Drawing.Point(210, 97);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(123, 23);
            this.txt_id.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(85, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 28;
            this.label2.Text = "Id";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cmb_fabricante
            // 
            this.cmb_fabricante.BackColor = System.Drawing.Color.White;
            this.cmb_fabricante.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_fabricante.ForeColor = System.Drawing.Color.Black;
            this.cmb_fabricante.FormattingEnabled = true;
            this.cmb_fabricante.Location = new System.Drawing.Point(210, 193);
            this.cmb_fabricante.Name = "cmb_fabricante";
            this.cmb_fabricante.Size = new System.Drawing.Size(248, 23);
            this.cmb_fabricante.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(85, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 28;
            this.label4.Text = "Fabricante";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_addEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 543);
            this.Controls.Add(this.img_imagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmb_categoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txt_ncm);
            this.Controls.Add(this.cmb_fabricante);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cmb_unidade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_estoque);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_descritivo);
            this.Controls.Add(this.txt_valorCompra);
            this.Controls.Add(this.txt_valorVenda);
            this.Name = "frm_addEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_addEquipamento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_addEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_imagem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox img_imagem;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_valorVenda;
        private System.Windows.Forms.TextBox txt_valorCompra;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.TextBox txt_estoque;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmb_unidade;
        private System.Windows.Forms.Button btn_atualizar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_descritivo;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_ncm;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private System.Windows.Forms.Button btn_salvar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_fabricante;
        private System.Windows.Forms.Label label4;
    }
}