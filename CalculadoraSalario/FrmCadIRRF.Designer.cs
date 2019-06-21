namespace CalculadoraSalario
{
    partial class FrmCadIRRF
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DgvListaIRRF = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Limite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtDesconto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPorc = new System.Windows.Forms.TextBox();
            this.TxtLimite = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MktComp = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaIRRF)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaIRRF
            // 
            this.DgvListaIRRF.AllowUserToAddRows = false;
            this.DgvListaIRRF.AllowUserToDeleteRows = false;
            this.DgvListaIRRF.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaIRRF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaIRRF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaIRRF.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Competencia,
            this.Limite,
            this.Porc,
            this.Desconto});
            this.DgvListaIRRF.Location = new System.Drawing.Point(15, 116);
            this.DgvListaIRRF.MultiSelect = false;
            this.DgvListaIRRF.Name = "DgvListaIRRF";
            this.DgvListaIRRF.ReadOnly = true;
            this.DgvListaIRRF.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaIRRF.Size = new System.Drawing.Size(323, 169);
            this.DgvListaIRRF.TabIndex = 21;
            this.DgvListaIRRF.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaIRRF_CellDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Competencia
            // 
            this.Competencia.DataPropertyName = "Competencia";
            this.Competencia.HeaderText = "Competencia";
            this.Competencia.Name = "Competencia";
            this.Competencia.ReadOnly = true;
            this.Competencia.Visible = false;
            // 
            // Limite
            // 
            this.Limite.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Limite.DataPropertyName = "Limite";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N2";
            this.Limite.DefaultCellStyle = dataGridViewCellStyle1;
            this.Limite.HeaderText = "Limite";
            this.Limite.Name = "Limite";
            this.Limite.ReadOnly = true;
            this.Limite.Width = 59;
            // 
            // Porc
            // 
            this.Porc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Porc.DataPropertyName = "Porc";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Porc.DefaultCellStyle = dataGridViewCellStyle2;
            this.Porc.HeaderText = "%";
            this.Porc.Name = "Porc";
            this.Porc.ReadOnly = true;
            this.Porc.Width = 40;
            // 
            // Desconto
            // 
            this.Desconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Desconto.DataPropertyName = "Desconto";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N2";
            this.Desconto.DefaultCellStyle = dataGridViewCellStyle3;
            this.Desconto.HeaderText = "Desconto";
            this.Desconto.Name = "Desconto";
            this.Desconto.ReadOnly = true;
            this.Desconto.Width = 78;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(263, 70);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 18;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(263, 41);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 19;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(263, 12);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 20;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Desconto";
            // 
            // TxtDesconto
            // 
            this.TxtDesconto.Location = new System.Drawing.Point(177, 64);
            this.TxtDesconto.Name = "TxtDesconto";
            this.TxtDesconto.Size = new System.Drawing.Size(67, 20);
            this.TxtDesconto.TabIndex = 16;
            this.TxtDesconto.Text = "0,00";
            this.TxtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Porcentagem";
            // 
            // TxtPorc
            // 
            this.TxtPorc.Location = new System.Drawing.Point(90, 64);
            this.TxtPorc.Name = "TxtPorc";
            this.TxtPorc.Size = new System.Drawing.Size(81, 20);
            this.TxtPorc.TabIndex = 14;
            this.TxtPorc.Text = "0,00";
            this.TxtPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtLimite
            // 
            this.TxtLimite.Location = new System.Drawing.Point(15, 64);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.Size = new System.Drawing.Size(69, 20);
            this.TxtLimite.TabIndex = 13;
            this.TxtLimite.Text = "0,00";
            this.TxtLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Limite";
            // 
            // MktComp
            // 
            this.MktComp.Location = new System.Drawing.Point(15, 25);
            this.MktComp.Mask = "00/0000";
            this.MktComp.Name = "MktComp";
            this.MktComp.Size = new System.Drawing.Size(69, 20);
            this.MktComp.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Competência";
            // 
            // FrmCadIRRF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 302);
            this.Controls.Add(this.DgvListaIRRF);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtDesconto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtPorc);
            this.Controls.Add(this.TxtLimite);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktComp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadIRRF";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro IRRF";
            this.Load += new System.EventHandler(this.FrmCadIRRF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaIRRF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaIRRF;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtDesconto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPorc;
        private System.Windows.Forms.TextBox TxtLimite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox MktComp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Limite;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desconto;
    }
}