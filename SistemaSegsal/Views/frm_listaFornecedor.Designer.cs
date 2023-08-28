
namespace SistemaSegsal.Views
{
    partial class frm_listaFornecedor
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
            this.lvw_listaClientes = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_deletar = new System.Windows.Forms.Button();
            this.btn_base = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_novo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvw_listaClientes
            // 
            this.lvw_listaClientes.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvw_listaClientes.FullRowSelect = true;
            this.lvw_listaClientes.GridLines = true;
            this.lvw_listaClientes.HideSelection = false;
            this.lvw_listaClientes.Location = new System.Drawing.Point(3, 178);
            this.lvw_listaClientes.Name = "lvw_listaClientes";
            this.lvw_listaClientes.Size = new System.Drawing.Size(1303, 428);
            this.lvw_listaClientes.TabIndex = 7;
            this.lvw_listaClientes.UseCompatibleStateImageBehavior = false;
            this.lvw_listaClientes.View = System.Windows.Forms.View.Details;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1339, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_editar);
            this.panel1.Controls.Add(this.btn_deletar);
            this.panel1.Controls.Add(this.btn_base);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.btn_sair);
            this.panel1.Controls.Add(this.btn_novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 80);
            this.panel1.TabIndex = 5;
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.White;
            this.lbl_title.Location = new System.Drawing.Point(24, 17);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(230, 45);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Fornecedores";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Image = global::SistemaSegsal.Properties.Resources.cancelar;
            this.btn_cancelar.Location = new System.Drawing.Point(853, 5);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 70);
            this.btn_cancelar.TabIndex = 6;
            this.btn_cancelar.UseVisualStyleBackColor = false;
            // 
            // btn_editar
            // 
            this.btn_editar.BackColor = System.Drawing.Color.Navy;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Image = global::SistemaSegsal.Properties.Resources.editar;
            this.btn_editar.Location = new System.Drawing.Point(934, 5);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(75, 70);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.UseVisualStyleBackColor = false;
            // 
            // btn_deletar
            // 
            this.btn_deletar.BackColor = System.Drawing.Color.Navy;
            this.btn_deletar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_deletar.Image = global::SistemaSegsal.Properties.Resources.deletar;
            this.btn_deletar.Location = new System.Drawing.Point(1015, 5);
            this.btn_deletar.Name = "btn_deletar";
            this.btn_deletar.Size = new System.Drawing.Size(75, 70);
            this.btn_deletar.TabIndex = 4;
            this.btn_deletar.UseVisualStyleBackColor = false;
            // 
            // btn_base
            // 
            this.btn_base.BackColor = System.Drawing.Color.Navy;
            this.btn_base.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_base.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_base.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_base.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_base.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_base.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_base.Image = global::SistemaSegsal.Properties.Resources.base3;
            this.btn_base.Location = new System.Drawing.Point(1096, 4);
            this.btn_base.Name = "btn_base";
            this.btn_base.Size = new System.Drawing.Size(75, 70);
            this.btn_base.TabIndex = 3;
            this.btn_base.UseVisualStyleBackColor = false;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.BackColor = System.Drawing.Color.Navy;
            this.btn_imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_imprimir.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_imprimir.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imprimir.Image = global::SistemaSegsal.Properties.Resources.imprimir;
            this.btn_imprimir.Location = new System.Drawing.Point(1177, 5);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 70);
            this.btn_imprimir.TabIndex = 2;
            this.btn_imprimir.Tag = "";
            this.btn_imprimir.UseVisualStyleBackColor = false;
            // 
            // btn_sair
            // 
            this.btn_sair.BackColor = System.Drawing.Color.Navy;
            this.btn_sair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_sair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_sair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_sair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sair.Image = global::SistemaSegsal.Properties.Resources.sair;
            this.btn_sair.Location = new System.Drawing.Point(1258, 5);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 70);
            this.btn_sair.TabIndex = 1;
            this.btn_sair.UseVisualStyleBackColor = false;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_novo
            // 
            this.btn_novo.BackColor = System.Drawing.Color.Navy;
            this.btn_novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_novo.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btn_novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btn_novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Navy;
            this.btn_novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novo.Image = global::SistemaSegsal.Properties.Resources.novo;
            this.btn_novo.Location = new System.Drawing.Point(772, 5);
            this.btn_novo.Name = "btn_novo";
            this.btn_novo.Size = new System.Drawing.Size(75, 70);
            this.btn_novo.TabIndex = 0;
            this.btn_novo.UseVisualStyleBackColor = false;
            // 
            // frm_listaFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1339, 581);
            this.Controls.Add(this.lvw_listaClientes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frm_listaFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_fornecedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvw_listaClientes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_deletar;
        private System.Windows.Forms.Button btn_base;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_novo;
    }
}