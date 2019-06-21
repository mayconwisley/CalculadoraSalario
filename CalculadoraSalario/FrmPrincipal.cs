using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculo.INSS;
using Calculo.IRRF;
using Calculo.Vale_Transporte;
using Calculo.FGTS;
using Negocio;
namespace CalculadoraSalario
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        FrmCadINSS cadINSS;
        FrmCadIRRF cadIRRF;
        FrmCadDep cadDep;

        NegInss negInss;
        NegIrrf negIrrf;
        NegDepen negDepen;

        #region Variaveis
        decimal vlrSalario = 0, vlrPercVT = 0, vlrINSS = 0, vlrIRRF = 0;
        decimal calcSalario = 0, calcVT = 0, porcInss = 0, calcINSS = 0, porcIrrf = 0, descIrrf = 0, calcIRRF = 0, calcFGTS = 0;
        decimal vlrDependente = 0, qtdDepentende = 0;

        DateTime dtCompetencia;

        #endregion



        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Calculo();
        }

        private void Calculo_INSS(decimal salario)
        {
            negInss = new NegInss();

            try
            {
                porcInss = negInss.PorcTeto(salario);
                calcINSS = CalculoINSS.INSS(vlrSalario, porcInss);

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
                calcIRRF = CalculoIRRF.IRRF(salario, inss, vlrDependente, porcIrrf, descIrrf);
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

            calcSalario = vlrSalario - (calcINSS + calcIRRF + calcVT);

            TxtResumo.Text = "Valor INSS.........: " + calcINSS.ToString("#,##0.00") +
                             "\nValor IRRF.........: " + calcIRRF.ToString("#,##0.00") +
                             "\nValor FGTS.........: " + calcFGTS.ToString("#,##0.00") +
                             "\nVale Transporte....: " + calcVT.ToString("#,##0.00") +
                             "\nOutros Valores.....: " + calcIRRF.ToString("#,##0.00") +
                             "\n\nSalário Liquido..: " + calcSalario.ToString("#,##0.00");

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
    }
}
