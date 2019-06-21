namespace CalculadoraSalario
{
    partial class FrmPrincipal
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
            this.MenuPrincipal = new System.Windows.Forms.MenuStrip();
            this.MenuTabelas = new System.Windows.Forms.ToolStripMenuItem();
            this.SubTabelaInss = new System.Windows.Forms.ToolStripMenuItem();
            this.SubTabelaIrrf = new System.Windows.Forms.ToolStripMenuItem();
            this.SubTabelaDependente = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtSalario = new System.Windows.Forms.TextBox();
            this.BtnCalcular = new System.Windows.Forms.Button();
            this.CbValeTransporte = new System.Windows.Forms.CheckBox();
            this.TxtPorcVT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOutrosVlr = new System.Windows.Forms.TextBox();
            this.BtnAdicionar = new System.Windows.Forms.Button();
            this.BtnRemover = new System.Windows.Forms.Button();
            this.DgvListaOutVlr = new System.Windows.Forms.DataGridView();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CbDesconto = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtDep = new System.Windows.Forms.TextBox();
            this.TxtResumo = new System.Windows.Forms.RichTextBox();
            this.MenuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaOutVlr)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuPrincipal
            // 
            this.MenuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuTabelas,
            this.MenuSair});
            this.MenuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.MenuPrincipal.Name = "MenuPrincipal";
            this.MenuPrincipal.Size = new System.Drawing.Size(378, 24);
            this.MenuPrincipal.TabIndex = 0;
            this.MenuPrincipal.Text = "menuStrip1";
            // 
            // MenuTabelas
            // 
            this.MenuTabelas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubTabelaInss,
            this.SubTabelaIrrf,
            this.SubTabelaDependente});
            this.MenuTabelas.Name = "MenuTabelas";
            this.MenuTabelas.Size = new System.Drawing.Size(58, 20);
            this.MenuTabelas.Text = "Tabelas";
            // 
            // SubTabelaInss
            // 
            this.SubTabelaInss.Name = "SubTabelaInss";
            this.SubTabelaInss.Size = new System.Drawing.Size(180, 22);
            this.SubTabelaInss.Text = "INSS";
            this.SubTabelaInss.Click += new System.EventHandler(this.SubTabelaInss_Click);
            // 
            // SubTabelaIrrf
            // 
            this.SubTabelaIrrf.Name = "SubTabelaIrrf";
            this.SubTabelaIrrf.Size = new System.Drawing.Size(180, 22);
            this.SubTabelaIrrf.Text = "IRRF";
            this.SubTabelaIrrf.Click += new System.EventHandler(this.SubTabelaIrrf_Click);
            // 
            // SubTabelaDependente
            // 
            this.SubTabelaDependente.Name = "SubTabelaDependente";
            this.SubTabelaDependente.Size = new System.Drawing.Size(180, 22);
            this.SubTabelaDependente.Text = "Dependente";
            this.SubTabelaDependente.Click += new System.EventHandler(this.SubTabelaDependente_Click);
            // 
            // MenuSair
            // 
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(38, 20);
            this.MenuSair.Text = "Sair";
            this.MenuSair.Click += new System.EventHandler(this.MenuSair_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(12, 40);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(92, 20);
            this.TxtSalario.TabIndex = 2;
            this.TxtSalario.Text = "0,00";
            this.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(291, 40);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 4;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // CbValeTransporte
            // 
            this.CbValeTransporte.AutoSize = true;
            this.CbValeTransporte.Location = new System.Drawing.Point(110, 42);
            this.CbValeTransporte.Name = "CbValeTransporte";
            this.CbValeTransporte.Size = new System.Drawing.Size(129, 17);
            this.CbValeTransporte.TabIndex = 5;
            this.CbValeTransporte.Text = "Usa Vale Transporte?";
            this.CbValeTransporte.UseVisualStyleBackColor = true;
            // 
            // TxtPorcVT
            // 
            this.TxtPorcVT.Location = new System.Drawing.Point(245, 40);
            this.TxtPorcVT.Name = "TxtPorcVT";
            this.TxtPorcVT.Size = new System.Drawing.Size(20, 20);
            this.TxtPorcVT.TabIndex = 6;
            this.TxtPorcVT.Text = "6";
            this.TxtPorcVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Outros Valores";
            // 
            // TxtOutrosVlr
            // 
            this.TxtOutrosVlr.Location = new System.Drawing.Point(12, 79);
            this.TxtOutrosVlr.Name = "TxtOutrosVlr";
            this.TxtOutrosVlr.Size = new System.Drawing.Size(92, 20);
            this.TxtOutrosVlr.TabIndex = 8;
            this.TxtOutrosVlr.Text = "0,00";
            this.TxtOutrosVlr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(206, 75);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(79, 23);
            this.BtnAdicionar.TabIndex = 9;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(287, 75);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(79, 23);
            this.BtnRemover.TabIndex = 9;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            // 
            // DgvListaOutVlr
            // 
            this.DgvListaOutVlr.AllowUserToAddRows = false;
            this.DgvListaOutVlr.AllowUserToDeleteRows = false;
            this.DgvListaOutVlr.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DgvListaOutVlr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DgvListaOutVlr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaOutVlr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Tipo,
            this.Valor});
            this.DgvListaOutVlr.Location = new System.Drawing.Point(12, 146);
            this.DgvListaOutVlr.Name = "DgvListaOutVlr";
            this.DgvListaOutVlr.ReadOnly = true;
            this.DgvListaOutVlr.Size = new System.Drawing.Size(354, 82);
            this.DgvListaOutVlr.TabIndex = 10;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 155;
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 155;
            // 
            // CbDesconto
            // 
            this.CbDesconto.AutoSize = true;
            this.CbDesconto.Location = new System.Drawing.Point(110, 81);
            this.CbDesconto.Name = "CbDesconto";
            this.CbDesconto.Size = new System.Drawing.Size(77, 17);
            this.CbDesconto.TabIndex = 11;
            this.CbDesconto.Text = "Descontos";
            this.CbDesconto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dependentes";
            // 
            // TxtDep
            // 
            this.TxtDep.Location = new System.Drawing.Point(12, 118);
            this.TxtDep.Name = "TxtDep";
            this.TxtDep.Size = new System.Drawing.Size(92, 20);
            this.TxtDep.TabIndex = 13;
            this.TxtDep.Text = "0";
            this.TxtDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtResumo
            // 
            this.TxtResumo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResumo.Location = new System.Drawing.Point(12, 251);
            this.TxtResumo.Name = "TxtResumo";
            this.TxtResumo.ReadOnly = true;
            this.TxtResumo.Size = new System.Drawing.Size(354, 156);
            this.TxtResumo.TabIndex = 14;
            this.TxtResumo.Text = "";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 419);
            this.Controls.Add(this.TxtResumo);
            this.Controls.Add(this.TxtDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CbDesconto);
            this.Controls.Add(this.DgvListaOutVlr);
            this.Controls.Add(this.BtnRemover);
            this.Controls.Add(this.BtnAdicionar);
            this.Controls.Add(this.TxtOutrosVlr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtPorcVT);
            this.Controls.Add(this.CbValeTransporte);
            this.Controls.Add(this.BtnCalcular);
            this.Controls.Add(this.TxtSalario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MenuPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Salário";
            this.MenuPrincipal.ResumeLayout(false);
            this.MenuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaOutVlr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuPrincipal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtSalario;
        private System.Windows.Forms.Button BtnCalcular;
        private System.Windows.Forms.CheckBox CbValeTransporte;
        private System.Windows.Forms.TextBox TxtPorcVT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOutrosVlr;
        private System.Windows.Forms.Button BtnAdicionar;
        private System.Windows.Forms.Button BtnRemover;
        private System.Windows.Forms.DataGridView DgvListaOutVlr;
        private System.Windows.Forms.ToolStripMenuItem MenuTabelas;
        private System.Windows.Forms.ToolStripMenuItem SubTabelaInss;
        private System.Windows.Forms.ToolStripMenuItem SubTabelaIrrf;
        private System.Windows.Forms.ToolStripMenuItem SubTabelaDependente;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.CheckBox CbDesconto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDep;
        private System.Windows.Forms.RichTextBox TxtResumo;
    }
}

