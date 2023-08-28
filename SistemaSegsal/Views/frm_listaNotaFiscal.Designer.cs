
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_pagar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
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
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Image = global::SistemaSegsal.Properties.Resources.financeiro2;
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(70, 60);
            this.img_logoEmpresa.TabIndex = 42;
            this.img_logoEmpresa.TabStop = false;
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
            this.btn_sair.Location = new System.Drawing.Point(1277, 66);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(60, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
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
            this.btn_novo.Location = new System.Drawing.Point(947, 66);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 55);
            this.btn_novo.TabIndex = 38;
            this.btn_novo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click);
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
            this.btn_pagar.Location = new System.Drawing.Point(1211, 66);
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
            this.btn_deletar.Location = new System.Drawing.Point(1145, 66);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(60, 55);
            this.btn_deletar.TabIndex = 39;
            this.btn_deletar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_deletar.UseVisualStyleBackColor = false;
            this.btn_deletar.Click += new System.EventHandler(this.btn_deletar_Click);
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
            this.btn_cancelar.Location = new System.Drawing.Point(1013, 66);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(60, 55);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
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
            this.btn_editar.Location = new System.Drawing.Point(1079, 66);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(60, 55);
            this.btn_editar.TabIndex = 40;
            this.btn_editar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_editar.UseVisualStyleBackColor = false;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // lvw_listaNotaFiscal
            // 
            this.lvw_listaNotaFiscal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaNotaFiscal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaNotaFiscal.FullRowSelect = true;
            this.lvw_listaNotaFiscal.GridLines = true;
            this.lvw_listaNotaFiscal.HideSelection = false;
            this.lvw_listaNotaFiscal.Location = new System.Drawing.Point(28, 287);
            this.lvw_listaNotaFiscal.Name = "lvw_listaNotaFiscal";
            this.lvw_listaNotaFiscal.Size = new System.Drawing.Size(1309, 390);
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
            this.cmb_status.Location = new System.Drawing.Point(152, 84);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(173, 23);
            this.cmb_status.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_valorNotaFiscal);
            this.groupBox2.Controls.Add(this.txt_qtdNotaFiscal);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(28, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1309, 83);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
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
            this.btn_filtrar.Location = new System.Drawing.Point(584, 83);
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
            this.cmb_ano.Location = new System.Drawing.Point(455, 84);
            this.cmb_ano.Name = "cmb_ano";
            this.cmb_ano.Size = new System.Drawing.Size(123, 23);
            this.cmb_ano.TabIndex = 37;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Location = new System.Drawing.Point(0, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 36);
            this.panel1.TabIndex = 42;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(28, 84);
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
            this.textBox1.Location = new System.Drawing.Point(331, 84);
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
            this.textBox2.Location = new System.Drawing.Point(28, 258);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(1309, 23);
            this.textBox2.TabIndex = 43;
            this.textBox2.Text = " Lista de Notas Fiscais";
            // 
            // frm_listaNotaFiscal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 707);
            this.ControlBox = false;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmb_ano);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_novo);
            this.Controls.Add(this.cmb_status);
            this.Controls.Add(this.btn_pagar);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_deletar);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.lvw_listaNotaFiscal);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaNotaFiscal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_listaNotaFiscal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaNotaFiscal_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
    }
}