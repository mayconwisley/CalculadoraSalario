using Modelo;
using Negocio;
using System;
using System.Windows.Forms;

namespace CalculadoraSalario
{
    public partial class FrmCadINSS : Form
    {
        public FrmCadINSS()
        {
            InitializeComponent();
        }
        #region Classes
        NegInss negInss;
        ModInss modInss;
        ValidarNumeros validarNumeros;
        #endregion
        #region Variaveis e Objetos
        int idInss;
        DateTime dtCompetencia;
        #endregion
        #region Funções
        private void Cadastro(char opc)
        {

            negInss = new NegInss();
            modInss = new ModInss();
            try
            {

                modInss.Id = idInss;
                modInss.Competencia = DateTime.Parse(MktComp.Text);
                modInss.Faixa = int.Parse(TxtFaixa.Text.Trim());
                modInss.Teto = decimal.Parse(TxtTeto.Text.Trim());
                modInss.Porcentagem = decimal.Parse(TxtPorc.Text.Trim());

                switch (opc)
                {
                    case 'G':
                        negInss.Gravar(modInss);
                        break;
                    case 'A':
                        negInss.Alterar(modInss);
                        break;
                    case 'E':
                        negInss.Excluir(modInss);
                        break;
                    default:
                        break;
                }
                Reset();
                ListarInss(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarInss(DateTime competencia)
        {
            negInss = new NegInss();
            try
            {
                DgvListaINSS.DataSource = negInss.ListaInss(competencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Reset()
        {
            BtnAlterar.Enabled = false;
            BtnExcluir.Enabled = false;
            BtnGravar.Enabled = true;

            TxtFaixa.Text = "0";
            TxtPorc.Text = "0,00";
            TxtTeto.Text = "0,00";
        }
        #endregion
        #region Padrão
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            Cadastro('G');
        }

        private void BtnAlterar_Click(object sender, EventArgs e)
        {
            Cadastro('A');
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            Cadastro('E');
        }

        private void FrmCadINSS_Load(object sender, EventArgs e)
        {
            dtCompetencia = DateTime.Parse(DateTime.Now.ToString("MM/yyyy"));
            MktComp.Text = dtCompetencia.ToString("MM/yyyy");
            ListarInss(dtCompetencia);
        }

        private void DgvListaINSS_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idInss = int.Parse(DgvListaINSS.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtFaixa.Text = DgvListaINSS.Rows[e.RowIndex].Cells["Faixa"].Value.ToString();
                TxtTeto.Text = DgvListaINSS.Rows[e.RowIndex].Cells["Teto_Faixa"].Value.ToString();
                TxtPorc.Text = DgvListaINSS.Rows[e.RowIndex].Cells["Porc_Faixa"].Value.ToString();
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TxtFaixa_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtFaixa.Text = validarNumeros.Numero(TxtFaixa.Text.Trim());
            TxtFaixa.Select(TxtFaixa.Text.Length, 0);
        }

        private void TxtFaixa_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtFaixa.Text = validarNumeros.ZeroNumero(TxtFaixa.Text.Trim());
            TxtFaixa.Text = validarNumeros.FormatarNumero(TxtFaixa.Text.Trim());
        }

        private void TxtFaixa_Enter(object sender, EventArgs e)
        {
            if (TxtFaixa.Text == "0")
            {
                TxtFaixa.Text = "";
            }
        }

        private void TxtTeto_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtTeto.Text = validarNumeros.Valor(TxtTeto.Text.Trim());
            TxtTeto.Select(TxtTeto.Text.Length, 0);

        }

        private void TxtTeto_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtTeto.Text = validarNumeros.ZeroValor(TxtTeto.Text.Trim());
            TxtTeto.Text = validarNumeros.FormatarValor(TxtTeto.Text.Trim());
        }

        private void TxtTeto_Enter(object sender, EventArgs e)
        {
            if (TxtTeto.Text == "0,00")
            {
                TxtTeto.Text = "";
            }
        }

        private void TxtPorc_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtPorc.Text = validarNumeros.Valor(TxtPorc.Text.Trim());
            TxtPorc.Select(TxtPorc.Text.Length, 0);

        }

        private void TxtPorc_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtPorc.Text = validarNumeros.ZeroValor(TxtPorc.Text.Trim());
            TxtPorc.Text = validarNumeros.FormatarValor(TxtPorc.Text.Trim());
        }

        private void TxtPorc_Enter(object sender, EventArgs e)
        {
            if (TxtPorc.Text == "0,00")
            {
                TxtPorc.Text = "";
            }
        }
        #endregion
    }
}
