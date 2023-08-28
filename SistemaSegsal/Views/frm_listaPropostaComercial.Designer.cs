
namespace SistemaSegsal.View
{
    partial class frm_listaPropostaComercial
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_excluir = new System.Windows.Forms.Button();
            this.btn_servico = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmb_status = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.btn_novo = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.txt_valorProposta = new System.Windows.Forms.TextBox();
            this.txt_qtdProposta = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.img_logoEmpresa = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lvw_listaPropostaComercial = new System.Windows.Forms.ListView();
            this.label12 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btn_excluir);
            this.panel1.Controls.Add(this.btn_servico);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.cmb_status);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.txt_valorProposta);
            this.panel1.Controls.Add(this.txt_qtdProposta);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lvw_listaPropostaComercial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1370, 730);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(1042, 186);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(278, 16);
            this.textBox2.TabIndex = 22;
            this.textBox2.Text = "(*) Clique 2x para Editar a Proposta";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_excluir
            // 
            this.btn_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_excluir.FlatAppearance.BorderSize = 0;
            this.btn_excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_excluir.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_excluir.ForeColor = System.Drawing.Color.White;
            this.btn_excluir.Image = global::SistemaSegsal.Properties.Resources.deletar;
            this.btn_excluir.Location = new System.Drawing.Point(1085, 66);
            this.btn_excluir.Name = "btn_excluir";
            this.btn_excluir.Size = new System.Drawing.Size(60, 55);
            this.btn_excluir.TabIndex = 40;
            this.btn_excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_excluir.UseVisualStyleBackColor = false;
            this.btn_excluir.Click += new System.EventHandler(this.btn_excluir_Click);
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
            this.btn_servico.Location = new System.Drawing.Point(1150, 66);
            this.btn_servico.Name = "btn_servico";
            this.btn_servico.Size = new System.Drawing.Size(60, 55);
            this.btn_servico.TabIndex = 39;
            this.btn_servico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_servico.UseVisualStyleBackColor = false;
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
            this.btn_imprimir.Location = new System.Drawing.Point(1215, 66);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(60, 55);
            this.btn_imprimir.TabIndex = 38;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Location = new System.Drawing.Point(0, 128);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1370, 36);
            this.panel2.TabIndex = 23;
            // 
            // cmb_status
            // 
            this.cmb_status.BackColor = System.Drawing.Color.White;
            this.cmb_status.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_status.ForeColor = System.Drawing.Color.Black;
            this.cmb_status.FormattingEnabled = true;
            this.cmb_status.Location = new System.Drawing.Point(151, 85);
            this.cmb_status.Name = "cmb_status";
            this.cmb_status.Size = new System.Drawing.Size(225, 23);
            this.cmb_status.TabIndex = 5;
            this.cmb_status.SelectedValueChanged += new System.EventHandler(this.cmb_status_SelectedValueChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(27, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(1316, 23);
            this.textBox1.TabIndex = 22;
            this.textBox1.Text = " Lista de Propostas Comerciais";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.Black;
            this.textBox3.Location = new System.Drawing.Point(27, 85);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 23);
            this.textBox3.TabIndex = 22;
            this.textBox3.Text = " Status";
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_novo.FlatAppearance.BorderSize = 0;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novo.ForeColor = System.Drawing.Color.White;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(1019, 66);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(60, 55);
            this.btn_novo.TabIndex = 17;
            this.btn_novo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_novo.UseVisualStyleBackColor = false;
            this.btn_novo.Click += new System.EventHandler(this.btn_novo_Click_1);
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Red;
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
            this.btn_sair.Location = new System.Drawing.Point(1280, 66);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(60, 55);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // txt_valorProposta
            // 
            this.txt_valorProposta.BackColor = System.Drawing.Color.White;
            this.txt_valorProposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_valorProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_valorProposta.ForeColor = System.Drawing.Color.Black;
            this.txt_valorProposta.Location = new System.Drawing.Point(834, 682);
            this.txt_valorProposta.Name = "txt_valorProposta";
            this.txt_valorProposta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_valorProposta.Size = new System.Drawing.Size(509, 16);
            this.txt_valorProposta.TabIndex = 4;
            // 
            // txt_qtdProposta
            // 
            this.txt_qtdProposta.BackColor = System.Drawing.Color.White;
            this.txt_qtdProposta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_qtdProposta.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_qtdProposta.ForeColor = System.Drawing.Color.Black;
            this.txt_qtdProposta.Location = new System.Drawing.Point(834, 653);
            this.txt_qtdProposta.Name = "txt_qtdProposta";
            this.txt_qtdProposta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_qtdProposta.Size = new System.Drawing.Size(509, 16);
            this.txt_qtdProposta.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.img_logoEmpresa);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1370, 60);
            this.panel3.TabIndex = 16;
            // 
            // img_logoEmpresa
            // 
            this.img_logoEmpresa.Location = new System.Drawing.Point(0, 0);
            this.img_logoEmpresa.Name = "img_logoEmpresa";
            this.img_logoEmpresa.Size = new System.Drawing.Size(106, 60);
            this.img_logoEmpresa.TabIndex = 41;
            this.img_logoEmpresa.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(530, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(349, 45);
            this.label16.TabIndex = 7;
            this.label16.Text = "Propostas Comerciais";
            // 
            // lvw_listaPropostaComercial
            // 
            this.lvw_listaPropostaComercial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lvw_listaPropostaComercial.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaPropostaComercial.ForeColor = System.Drawing.Color.Black;
            this.lvw_listaPropostaComercial.FullRowSelect = true;
            this.lvw_listaPropostaComercial.GridLines = true;
            this.lvw_listaPropostaComercial.HideSelection = false;
            this.lvw_listaPropostaComercial.Location = new System.Drawing.Point(27, 212);
            this.lvw_listaPropostaComercial.Name = "lvw_listaPropostaComercial";
            this.lvw_listaPropostaComercial.Size = new System.Drawing.Size(1316, 427);
            this.lvw_listaPropostaComercial.TabIndex = 2;
            this.lvw_listaPropostaComercial.UseCompatibleStateImageBehavior = false;
            this.lvw_listaPropostaComercial.View = System.Windows.Forms.View.Details;
            this.lvw_listaPropostaComercial.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvw_listaPropostaComercial_ItemSelectionChanged);
            this.lvw_listaPropostaComercial.DoubleClick += new System.EventHandler(this.lvw_listaPropostaComercial_DoubleClick);
            this.lvw_listaPropostaComercial.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvw_listaPropostaComercial_MouseClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(326, 517);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(173, 15);
            this.label12.TabIndex = 13;
            this.label12.Text = "Lista de Propostas Comerciais";
            // 
            // frm_listaPropostaComercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1370, 730);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label12);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_listaPropostaComercial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_propostaComercial";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_listaPropostaComercial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.img_logoEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView lvw_listaPropostaComercial;
        private System.Windows.Forms.TextBox txt_qtdProposta;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ComboBox cmb_status;
        private System.Windows.Forms.TextBox txt_valorProposta;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btn_novo;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_excluir;
        private System.Windows.Forms.Button btn_servico;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox img_logoEmpresa;
    }
}