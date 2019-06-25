using Calculo.FGTS;
using Calculo.INSS;
using Calculo.IRRF;
using Calculo.Vale_Transporte;
using Negocio;
using System;
using System.Data;
using System.Windows.Forms;
namespace CalculadoraSalario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        #region Formularios
        FrmCadINSS cadINSS;
        FrmCadIRRF cadIRRF;
        FrmCadDep cadDep;
        #endregion

        #region Classes
        NegInss negInss;
        NegIrrf negIrrf;
        NegDepen negDepen;
        ValidarNumeros validarNumeros;
        #endregion

        #region Variaveis e Objetos
        decimal vlrSalario = 0, vlrPercVT = 0, vlrOutroDesconto = 0, vlrProvento = 0, vlrDesconto = 0;

        decimal calcSalario = 0, calcVT = 0;

        decimal porcInss = 0, calcINSS = 0, calcTeto = 0;

        decimal porcIrrf = 0, descIrrf = 0, calcIRRF = 0, calcLimite = 0;

        decimal calcFGTS = 0;

        decimal vlrDependente = 0, qtdDepentende = 0;

        int idOutrosValores = 0;

        DateTime dtCompetencia;
        DataTable outroValores;
        #endregion

        #region Funções
        private void Calculo_INSS(decimal salario)
        {
            negInss = new NegInss();
            dtCompetencia = DateTime.Parse(DateTime.Now.ToString("MM/yyyy"));
            try
            {
                porcInss = negInss.PorcTeto(salario);
                calcTeto = negInss.Teto(dtCompetencia);
                if (salario > calcTeto)
                {
                    salario = calcTeto;
                }


                calcINSS = CalculoINSS.INSS(salario, porcInss);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculo_Irrf(decimal salario, decimal inss)
        {
            negIrrf = new NegIrrf();
            negDepen = new NegDepen();
            dtCompetencia = DateTime.Parse(DateTime.Now.ToString("MM/yyyy"));
            try
            {
                porcIrrf = negIrrf.PorcLimite(salario);
                descIrrf = negIrrf.Desconto(salario);
                vlrDependente = negDepen.ValorDependente(dtCompetencia);
                vlrDependente = vlrDependente * qtdDepentende;
                calcLimite = negIrrf.Limite(dtCompetencia);

                if (salario < calcLimite)
                {
                    porcIrrf = 0;
                    descIrrf = 0;
                }

                calcIRRF = CalculoIRRF.IRRF(salario, inss, vlrDependente, porcIrrf, descIrrf);

                if (calcIRRF <= 0)
                {
                    porcIrrf = 0;
                    descIrrf = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculo()
        {
            vlrSalario = decimal.Parse(TxtSalario.Text.Trim());
            vlrPercVT = decimal.Parse(TxtPorcVT.Text.Trim());
            qtdDepentende = int.Parse(TxtDep.Text.Trim());

            Calculo_INSS(vlrSalario);
            Calculo_Irrf(vlrSalario, calcINSS);

            calcVT = CalculoVT.ValeTransporte(vlrSalario, vlrPercVT);
            calcFGTS = CalculoFGTS.FGTS(vlrSalario, 8);

            calcSalario = (vlrSalario - (calcINSS + calcIRRF + calcVT)) + vlrOutroDesconto;

            TxtResumo.Text = "INSS - " + porcInss.ToString("#00.00") + " .........: " + calcINSS.ToString("#,##0.00") +
                             "\nIRRF - " + porcIrrf.ToString("#00.00") + " - " + descIrrf.ToString("#,000.00") + ".: " + calcIRRF.ToString("#,##0.00") +
                             "\nFGTS..................: " + calcFGTS.ToString("#,##0.00") +
                             "\nVale Transporte.......: " + calcVT.ToString("#,##0.00") +
                             "\nOutros Valores........: " + vlrOutroDesconto.ToString("#,##0.00") +
                             "\n\nSalário Liquido.....: " + calcSalario.ToString("#,##0.00");

        }

        private void AdicionarOutrosDescontos(string tipo, decimal valor)
        {
            outroValores = new DataTable();
            try
            {
                DgvListaOutVlr.Rows.Add(tipo, valor);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Calculo_OutrasVerbas()
        {
            string strTipo;
            try
            {
                vlrProvento = 0;
                vlrDesconto = 0;
                foreach (DataGridViewRow row in DgvListaOutVlr.Rows)
                {
                    strTipo = row.Cells["Tipo"].Value.ToString();
                    if (strTipo == "Provento")
                    {
                        vlrProvento += decimal.Parse(row.Cells["Valor"].Value.ToString());
                    }
                    else
                    {
                        vlrDesconto += decimal.Parse(row.Cells["Valor"].Value.ToString());
                    }

                }

                vlrOutroDesconto = vlrProvento - vlrDesconto;

                LblInfOutroValores.Text = "Proventos: " + vlrProvento.ToString("#,##0.00") +
                                          "\nDescontos: " + vlrDesconto.ToString("#,##0.00") +
                                          "\nTotal:" + vlrOutroDesconto.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool RemoverOutrosDescontos(int indexOutroValor)
        {
            try
            {
                DgvListaOutVlr.Rows.RemoveAt(indexOutroValor);
                DgvListaOutVlr.Update();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        #endregion

        #region Padrão
        private void CbValeTransporte_CheckedChanged(object sender, EventArgs e)
        {
            if (CbValeTransporte.Checked)
            {
                TxtPorcVT.Visible = true;
                LblinfVT.Visible = true;
                TxtPorcVT.Text = "6";
                vlrPercVT = decimal.Parse(TxtPorcVT.Text.Trim());
            }
            else
            {
                TxtPorcVT.Visible = false;
                LblinfVT.Visible = false;
                TxtPorcVT.Text = "0";
                vlrPercVT = 0;
            }
        }

        private void TxtSalario_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtSalario.Text = validarNumeros.Valor(TxtSalario.Text.Trim());
            TxtSalario.Select(TxtSalario.Text.Length, 0);
        }

        private void TxtSalario_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtSalario.Text = validarNumeros.ZeroValor(TxtSalario.Text.Trim());
            TxtSalario.Text = validarNumeros.FormatarValor(TxtSalario.Text.Trim());
        }

        private void TxtSalario_Enter(object sender, EventArgs e)
        {
            if (TxtSalario.Text == "0,00")
            {
                TxtSalario.Text = "";
            }
        }

        private void TxtOutrosVlr_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtOutrosVlr.Text = validarNumeros.Valor(TxtOutrosVlr.Text.Trim());
            TxtOutrosVlr.Select(TxtOutrosVlr.Text.Length, 0);
        }

        private void TxtOutrosVlr_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtOutrosVlr.Text = validarNumeros.ZeroValor(TxtOutrosVlr.Text.Trim());
            TxtOutrosVlr.Text = validarNumeros.FormatarValor(TxtOutrosVlr.Text.Trim());
        }

        private void TxtOutrosVlr_Enter(object sender, EventArgs e)
        {
            if (TxtOutrosVlr.Text == "0,00")
            {
                TxtOutrosVlr.Text = "";
            }
        }

        private void TxtDep_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtDep.Text = validarNumeros.Numero(TxtDep.Text.Trim());
            TxtDep.Select(TxtDep.Text.Length, 0);
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            string strTipo;

            if (CbDesconto.Checked)
            {
                strTipo = "Desconto";
            }
            else
            {
                strTipo = "Provento";
            }
            vlrOutroDesconto = decimal.Parse(TxtOutrosVlr.Text.Trim());

            AdicionarOutrosDescontos(strTipo, vlrOutroDesconto);
            Calculo_OutrasVerbas();
            Calculo();
        }

        private void DgvListaOutVlr_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idOutrosValores = e.RowIndex;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnRemover_Click(object sender, EventArgs e)
        {
            RemoverOutrosDescontos(idOutrosValores);
            Calculo_OutrasVerbas();
            Calculo();
        }

        private void TxtDep_Enter(object sender, EventArgs e)
        {
            if (TxtDep.Text == "0")
            {
                TxtDep.Text = "";
            }
        }

        private void TxtPorcVT_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtPorcVT.Text = validarNumeros.Numero(TxtPorcVT.Text.Trim());
            TxtPorcVT.Select(TxtPorcVT.Text.Length, 0);
        }

        private void TxtPorcVT_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtPorcVT.Text = validarNumeros.ZeroNumero(TxtPorcVT.Text.Trim());
            TxtPorcVT.Text = validarNumeros.FormatarNumero(TxtPorcVT.Text.Trim());
        }

        private void TxtPorcVT_Enter(object sender, EventArgs e)
        {
            if (TxtPorcVT.Text == "0")
            {
                TxtPorcVT.Text = "";
            }
        }

        private void TxtDep_Leave(object sender, EventArgs e)
        {
            negDepen = new NegDepen();
            validarNumeros = new ValidarNumeros();
            try
            {
                TxtDep.Text = validarNumeros.ZeroNumero(TxtDep.Text.Trim());
                qtdDepentende = int.Parse(TxtDep.Text.Trim());
                TxtDep.Text = validarNumeros.FormatarNumero(TxtDep.Text.Trim());


                vlrDependente = negDepen.ValorDependente(dtCompetencia);
                vlrDependente = vlrDependente * qtdDepentende;

                LblInfDep.Text = vlrDependente.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void SubTabelaInss_Click(object sender, EventArgs e)
        {
            cadINSS = new FrmCadINSS();
            cadINSS.ShowDialog();
        }

        private void SubTabelaIrrf_Click(object sender, EventArgs e)
        {
            cadIRRF = new FrmCadIRRF();
            cadIRRF.ShowDialog();
        }

        private void SubTabelaDependente_Click(object sender, EventArgs e)
        {
            cadDep = new FrmCadDep();
            cadDep.ShowDialog();
        }

        private void MenuSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
