namespace CalculadoraSalario
{
    partial class FrmCadINSS
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.MktComp = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtFaixa = new System.Windows.Forms.TextBox();
            this.TxtTeto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtPorc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.DgvListaINSS = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teto_Faixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porc_Faixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaINSS)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Competência";
            // 
            // MktComp
            // 
            this.MktComp.Location = new System.Drawing.Point(12, 25);
            this.MktComp.Mask = "00/0000";
            this.MktComp.Name = "MktComp";
            this.MktComp.Size = new System.Drawing.Size(69, 20);
            this.MktComp.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Faixa";
            // 
            // TxtFaixa
            // 
            this.TxtFaixa.Location = new System.Drawing.Point(12, 64);
            this.TxtFaixa.Name = "TxtFaixa";
            this.TxtFaixa.Size = new System.Drawing.Size(32, 20);
            this.TxtFaixa.TabIndex = 3;
            this.TxtFaixa.Text = "1";
            this.TxtFaixa.TextChanged += new System.EventHandler(this.TxtFaixa_TextChanged);
            this.TxtFaixa.Enter += new System.EventHandler(this.TxtFaixa_Enter);
            this.TxtFaixa.Leave += new System.EventHandler(this.TxtFaixa_Leave);
            // 
            // TxtTeto
            // 
            this.TxtTeto.Location = new System.Drawing.Point(50, 64);
            this.TxtTeto.Name = "TxtTeto";
            this.TxtTeto.Size = new System.Drawing.Size(81, 20);
            this.TxtTeto.TabIndex = 4;
            this.TxtTeto.Text = "0,00";
            this.TxtTeto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTeto.TextChanged += new System.EventHandler(this.TxtTeto_TextChanged);
            this.TxtTeto.Enter += new System.EventHandler(this.TxtTeto_Enter);
            this.TxtTeto.Leave += new System.EventHandler(this.TxtTeto_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Teto";
            // 
            // TxtPorc
            // 
            this.TxtPorc.Location = new System.Drawing.Point(137, 64);
            this.TxtPorc.Name = "TxtPorc";
            this.TxtPorc.Size = new System.Drawing.Size(67, 20);
            this.TxtPorc.TabIndex = 6;
            this.TxtPorc.Text = "0,00";
            this.TxtPorc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPorc.TextChanged += new System.EventHandler(this.TxtPorc_TextChanged);
            this.TxtPorc.Enter += new System.EventHandler(this.TxtPorc_Enter);
            this.TxtPorc.Leave += new System.EventHandler(this.TxtPorc_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Porcentagem";
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(260, 12);
            this.BtnGravar.Name = "BtnGravar";
            this.BtnGravar.Size = new System.Drawing.Size(75, 23);
            this.BtnGravar.TabIndex = 8;
            this.BtnGravar.Text = "Gravar";
            this.BtnGravar.UseVisualStyleBackColor = true;
            this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Enabled = false;
            this.BtnAlterar.Location = new System.Drawing.Point(260, 41);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 8;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(260, 70);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(75, 23);
            this.BtnExcluir.TabIndex = 8;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // DgvListaINSS
            // 
            this.DgvListaINSS.AllowUserToAddRows = false;
            this.DgvListaINSS.AllowUserToDeleteRows = false;
            this.DgvListaINSS.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaINSS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaINSS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaINSS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Competencia,
            this.Faixa,
            this.Teto_Faixa,
            this.Porc_Faixa});
            this.DgvListaINSS.Location = new System.Drawing.Point(12, 116);
            this.DgvListaINSS.MultiSelect = false;
            this.DgvListaINSS.Name = "DgvListaINSS";
            this.DgvListaINSS.ReadOnly = true;
            this.DgvListaINSS.RowHeadersWidth = 5;
            this.DgvListaINSS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaINSS.Size = new System.Drawing.Size(323, 169);
            this.DgvListaINSS.TabIndex = 9;
            this.DgvListaINSS.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaINSS_CellDoubleClick);
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
            this.Competencia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Competencia.DataPropertyName = "Competencia";
            dataGridViewCellStyle25.Format = "MM/yyyy";
            dataGridViewCellStyle25.NullValue = null;
            this.Competencia.DefaultCellStyle = dataGridViewCellStyle25;
            this.Competencia.HeaderText = "Competência";
            this.Competencia.Name = "Competencia";
            this.Competencia.ReadOnly = true;
            this.Competencia.Visible = false;
            // 
            // Faixa
            // 
            this.Faixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Faixa.DataPropertyName = "Faixa";
            this.Faixa.HeaderText = "Faixa";
            this.Faixa.Name = "Faixa";
            this.Faixa.ReadOnly = true;
            this.Faixa.Width = 57;
            // 
            // Teto_Faixa
            // 
            this.Teto_Faixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Teto_Faixa.DataPropertyName = "Teto_Faixa";
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle26.Format = "N2";
            dataGridViewCellStyle26.NullValue = null;
            this.Teto_Faixa.DefaultCellStyle = dataGridViewCellStyle26;
            this.Teto_Faixa.HeaderText = "Teto_Faixa";
            this.Teto_Faixa.Name = "Teto_Faixa";
            this.Teto_Faixa.ReadOnly = true;
            this.Teto_Faixa.Width = 85;
            // 
            // Porc_Faixa
            // 
            this.Porc_Faixa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Porc_Faixa.DataPropertyName = "Porc_Faixa";
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle27.Format = "N2";
            dataGridViewCellStyle27.NullValue = null;
            this.Porc_Faixa.DefaultCellStyle = dataGridViewCellStyle27;
            this.Porc_Faixa.HeaderText = "Porc_Faixa";
            this.Porc_Faixa.Name = "Porc_Faixa";
            this.Porc_Faixa.ReadOnly = true;
            this.Porc_Faixa.Width = 85;
            // 
            // FrmCadINSS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 302);
            this.Controls.Add(this.DgvListaINSS);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtPorc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtTeto);
            this.Controls.Add(this.TxtFaixa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MktComp);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadINSS";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro INSS";
            this.Load += new System.EventHandler(this.FrmCadINSS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaINSS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MktComp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtFaixa;
        private System.Windows.Forms.TextBox TxtTeto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtPorc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.DataGridView DgvListaINSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teto_Faixa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porc_Faixa;
    }
}