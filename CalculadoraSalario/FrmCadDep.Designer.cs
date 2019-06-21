namespace CalculadoraSalario
{
    partial class FrmCadDep
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
            this.DgvListaDep = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnGravar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Competencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDep)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvListaDep
            // 
            this.DgvListaDep.AllowUserToAddRows = false;
            this.DgvListaDep.AllowUserToDeleteRows = false;
            this.DgvListaDep.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaDep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Competencia,
            this.Valor});
            this.DgvListaDep.Location = new System.Drawing.Point(14, 120);
            this.DgvListaDep.MultiSelect = false;
            this.DgvListaDep.Name = "DgvListaDep";
            this.DgvListaDep.ReadOnly = true;
            this.DgvListaDep.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaDep.Size = new System.Drawing.Size(323, 169);
            this.DgvListaDep.TabIndex = 21;
            this.DgvListaDep.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaDep_CellDoubleClick);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Enabled = false;
            this.BtnExcluir.Location = new System.Drawing.Point(262, 74);
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
            this.BtnAlterar.Location = new System.Drawing.Point(262, 45);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(75, 23);
            this.BtnAlterar.TabIndex = 19;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnGravar
            // 
            this.BtnGravar.Location = new System.Drawing.Point(262, 16);
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
            this.label4.Location = new System.Drawing.Point(11, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Valor";
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(14, 74);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.Size = new System.Drawing.Size(67, 20);
            this.TxtValor.TabIndex = 16;
            this.TxtValor.Text = "0,00";
            this.TxtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(14, 29);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(69, 20);
            this.MktCompetencia.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Competência";
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
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // FrmCadDep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 302);
            this.Controls.Add(this.DgvListaDep);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnGravar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadDep";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Dependente";
            this.Load += new System.EventHandler(this.FrmCadDep_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaDep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvListaDep;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnGravar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Competencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}