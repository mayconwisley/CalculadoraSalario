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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.LblInfDep = new System.Windows.Forms.Label();
            this.LblinfVT = new System.Windows.Forms.Label();
            this.LblInfOutroValores = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lklGitHub = new System.Windows.Forms.LinkLabel();
            this.MktCompetencia = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.SubTabelaInss.Size = new System.Drawing.Size(138, 22);
            this.SubTabelaInss.Text = "INSS";
            this.SubTabelaInss.Click += new System.EventHandler(this.SubTabelaInss_Click);
            // 
            // SubTabelaIrrf
            // 
            this.SubTabelaIrrf.Name = "SubTabelaIrrf";
            this.SubTabelaIrrf.Size = new System.Drawing.Size(138, 22);
            this.SubTabelaIrrf.Text = "IRRF";
            this.SubTabelaIrrf.Click += new System.EventHandler(this.SubTabelaIrrf_Click);
            // 
            // SubTabelaDependente
            // 
            this.SubTabelaDependente.Name = "SubTabelaDependente";
            this.SubTabelaDependente.Size = new System.Drawing.Size(138, 22);
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
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Salário Base";
            // 
            // TxtSalario
            // 
            this.TxtSalario.Location = new System.Drawing.Point(12, 38);
            this.TxtSalario.Name = "TxtSalario";
            this.TxtSalario.Size = new System.Drawing.Size(76, 20);
            this.TxtSalario.TabIndex = 1;
            this.TxtSalario.Text = "0,00";
            this.TxtSalario.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSalario.TextChanged += new System.EventHandler(this.TxtSalario_TextChanged);
            this.TxtSalario.Enter += new System.EventHandler(this.TxtSalario_Enter);
            this.TxtSalario.Leave += new System.EventHandler(this.TxtSalario_Leave);
            // 
            // BtnCalcular
            // 
            this.BtnCalcular.Location = new System.Drawing.Point(291, 38);
            this.BtnCalcular.Name = "BtnCalcular";
            this.BtnCalcular.Size = new System.Drawing.Size(75, 23);
            this.BtnCalcular.TabIndex = 7;
            this.BtnCalcular.Text = "Calcular";
            this.BtnCalcular.UseVisualStyleBackColor = true;
            this.BtnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // CbValeTransporte
            // 
            this.CbValeTransporte.AutoSize = true;
            this.CbValeTransporte.Location = new System.Drawing.Point(110, 40);
            this.CbValeTransporte.Name = "CbValeTransporte";
            this.CbValeTransporte.Size = new System.Drawing.Size(129, 17);
            this.CbValeTransporte.TabIndex = 4;
            this.CbValeTransporte.Text = "Usa Vale Transporte?";
            this.CbValeTransporte.UseVisualStyleBackColor = true;
            this.CbValeTransporte.CheckedChanged += new System.EventHandler(this.CbValeTransporte_CheckedChanged);
            // 
            // TxtPorcVT
            // 
            this.TxtPorcVT.Location = new System.Drawing.Point(245, 38);
            this.TxtPorcVT.Name = "TxtPorcVT";
            this.TxtPorcVT.Size = new System.Drawing.Size(20, 20);
            this.TxtPorcVT.TabIndex = 6;
            this.TxtPorcVT.Text = "0";
            this.TxtPorcVT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPorcVT.Visible = false;
            this.TxtPorcVT.TextChanged += new System.EventHandler(this.TxtPorcVT_TextChanged);
            this.TxtPorcVT.Enter += new System.EventHandler(this.TxtPorcVT_Enter);
            this.TxtPorcVT.Leave += new System.EventHandler(this.TxtPorcVT_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Outros Valores";
            // 
            // TxtOutrosVlr
            // 
            this.TxtOutrosVlr.Location = new System.Drawing.Point(12, 118);
            this.TxtOutrosVlr.Name = "TxtOutrosVlr";
            this.TxtOutrosVlr.Size = new System.Drawing.Size(76, 20);
            this.TxtOutrosVlr.TabIndex = 3;
            this.TxtOutrosVlr.Text = "0,00";
            this.TxtOutrosVlr.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtOutrosVlr.TextChanged += new System.EventHandler(this.TxtOutrosVlr_TextChanged);
            this.TxtOutrosVlr.Enter += new System.EventHandler(this.TxtOutrosVlr_Enter);
            this.TxtOutrosVlr.Leave += new System.EventHandler(this.TxtOutrosVlr_Leave);
            // 
            // BtnAdicionar
            // 
            this.BtnAdicionar.Location = new System.Drawing.Point(206, 116);
            this.BtnAdicionar.Name = "BtnAdicionar";
            this.BtnAdicionar.Size = new System.Drawing.Size(79, 23);
            this.BtnAdicionar.TabIndex = 8;
            this.BtnAdicionar.Text = "Adicionar";
            this.BtnAdicionar.UseVisualStyleBackColor = true;
            this.BtnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // BtnRemover
            // 
            this.BtnRemover.Location = new System.Drawing.Point(287, 116);
            this.BtnRemover.Name = "BtnRemover";
            this.BtnRemover.Size = new System.Drawing.Size(79, 23);
            this.BtnRemover.TabIndex = 9;
            this.BtnRemover.Text = "Remover";
            this.BtnRemover.UseVisualStyleBackColor = true;
            this.BtnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
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
            this.DgvListaOutVlr.Location = new System.Drawing.Point(12, 144);
            this.DgvListaOutVlr.MultiSelect = false;
            this.DgvListaOutVlr.Name = "DgvListaOutVlr";
            this.DgvListaOutVlr.ReadOnly = true;
            this.DgvListaOutVlr.RowHeadersWidth = 5;
            this.DgvListaOutVlr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvListaOutVlr.Size = new System.Drawing.Size(354, 82);
            this.DgvListaOutVlr.TabIndex = 10;
            this.DgvListaOutVlr.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaOutVlr_CellDoubleClick);
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "Tipo";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 155;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            this.Valor.DefaultCellStyle = dataGridViewCellStyle2;
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            this.Valor.Width = 155;
            // 
            // CbDesconto
            // 
            this.CbDesconto.AutoSize = true;
            this.CbDesconto.Location = new System.Drawing.Point(110, 120);
            this.CbDesconto.Name = "CbDesconto";
            this.CbDesconto.Size = new System.Drawing.Size(72, 17);
            this.CbDesconto.TabIndex = 5;
            this.CbDesconto.Text = "Desconto";
            this.CbDesconto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Dependentes";
            // 
            // TxtDep
            // 
            this.TxtDep.Location = new System.Drawing.Point(12, 77);
            this.TxtDep.Name = "TxtDep";
            this.TxtDep.Size = new System.Drawing.Size(76, 20);
            this.TxtDep.TabIndex = 2;
            this.TxtDep.Text = "0";
            this.TxtDep.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDep.TextChanged += new System.EventHandler(this.TxtDep_TextChanged);
            this.TxtDep.Enter += new System.EventHandler(this.TxtDep_Enter);
            this.TxtDep.Leave += new System.EventHandler(this.TxtDep_Leave);
            // 
            // TxtResumo
            // 
            this.TxtResumo.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtResumo.Location = new System.Drawing.Point(12, 281);
            this.TxtResumo.Name = "TxtResumo";
            this.TxtResumo.ReadOnly = true;
            this.TxtResumo.Size = new System.Drawing.Size(354, 156);
            this.TxtResumo.TabIndex = 11;
            this.TxtResumo.Text = "";
            // 
            // LblInfDep
            // 
            this.LblInfDep.AutoSize = true;
            this.LblInfDep.Location = new System.Drawing.Point(94, 80);
            this.LblInfDep.Name = "LblInfDep";
            this.LblInfDep.Size = new System.Drawing.Size(28, 13);
            this.LblInfDep.TabIndex = 15;
            this.LblInfDep.Text = "0,00";
            // 
            // LblinfVT
            // 
            this.LblinfVT.AutoSize = true;
            this.LblinfVT.Location = new System.Drawing.Point(271, 41);
            this.LblinfVT.Name = "LblinfVT";
            this.LblinfVT.Size = new System.Drawing.Size(15, 13);
            this.LblinfVT.TabIndex = 16;
            this.LblinfVT.Text = "%";
            this.LblinfVT.Visible = false;
            // 
            // LblInfOutroValores
            // 
            this.LblInfOutroValores.AutoSize = true;
            this.LblInfOutroValores.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInfOutroValores.Location = new System.Drawing.Point(12, 229);
            this.LblInfOutroValores.Name = "LblInfOutroValores";
            this.LblInfOutroValores.Size = new System.Drawing.Size(14, 14);
            this.LblInfOutroValores.TabIndex = 17;
            this.LblInfOutroValores.Text = ".";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.label4.Location = new System.Drawing.Point(308, 440);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 9);
            this.label4.TabIndex = 18;
            this.label4.Text = "Maycon Wisley";
            // 
            // lklGitHub
            // 
            this.lklGitHub.AutoSize = true;
            this.lklGitHub.Location = new System.Drawing.Point(12, 440);
            this.lklGitHub.Name = "lklGitHub";
            this.lklGitHub.Size = new System.Drawing.Size(38, 13);
            this.lklGitHub.TabIndex = 19;
            this.lklGitHub.TabStop = true;
            this.lklGitHub.Text = "Github";
            this.lklGitHub.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklGitHub_LinkClicked);
            // 
            // MktCompetencia
            // 
            this.MktCompetencia.Location = new System.Drawing.Point(206, 80);
            this.MktCompetencia.Mask = "00/0000";
            this.MktCompetencia.Name = "MktCompetencia";
            this.MktCompetencia.Size = new System.Drawing.Size(67, 20);
            this.MktCompetencia.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(204, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Competência";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 458);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MktCompetencia);
            this.Controls.Add(this.lklGitHub);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblInfOutroValores);
            this.Controls.Add(this.LblinfVT);
            this.Controls.Add(this.LblInfDep);
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
            this.MainMenuStrip = this.MenuPrincipal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora Salário Simples";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtDep;
        private System.Windows.Forms.RichTextBox TxtResumo;
        private System.Windows.Forms.Label LblInfDep;
        private System.Windows.Forms.Label LblinfVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.Label LblInfOutroValores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel lklGitHub;
        private System.Windows.Forms.MaskedTextBox MktCompetencia;
        private System.Windows.Forms.Label label5;
    }
}

