using Modelo;
using Negocio;
using System;
using System.Windows.Forms;


namespace CalculadoraSalario
{
    public partial class FrmCadDep : Form
    {
        public FrmCadDep()
        {
            InitializeComponent();
        }
        #region Classes
        NegDepen negDepen;
        ModDependente modDependente;
        ValidarNumeros validarNumeros;
        #endregion

        #region Variaveis e Objetos
        int idDepen;
        DateTime dtCompetencia;
        #endregion

        #region Funções
        private void Cadastro(char opc)
        {
            negDepen = new NegDepen();
            modDependente = new ModDependente();
            try
            {
                modDependente.Id = idDepen;
                modDependente.Competencia = DateTime.Parse(MktCompetencia.Text);
                modDependente.Valor = decimal.Parse(TxtValor.Text.Trim());

                switch (opc)
                {
                    case 'G':
                        negDepen.Gravar(modDependente);
                        break;
                    case 'A':
                        negDepen.Alterar(modDependente);
                        break;
                    case 'E':
                        negDepen.Excluir(modDependente);
                        break;
                    default:
                        break;
                }
                Reset();
                ListarDependente(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarDependente(DateTime competencia)
        {
            negDepen = new NegDepen();
            try
            {
                DgvListaDep.DataSource = negDepen.ListaDependente(competencia);
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

            TxtValor.Text = "0,00";
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

        private void DgvListaDep_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idDepen = int.Parse(DgvListaDep.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                TxtValor.Text = DgvListaDep.Rows[e.RowIndex].Cells["Valor"].Value.ToString();
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadDep_Load(object sender, EventArgs e)
        {
            dtCompetencia = DateTime.Parse(DateTime.Now.ToString("MM/yyyy"));
            MktCompetencia.Text = dtCompetencia.ToString("MM/yyyy");
            ListarDependente(dtCompetencia);
        }

        private void TxtValor_TextChanged(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtValor.Text = validarNumeros.Valor(TxtValor.Text.Trim());
            TxtValor.Select(TxtValor.Text.Length, 0);
        }

        private void TxtValor_Leave(object sender, EventArgs e)
        {
            validarNumeros = new ValidarNumeros();
            TxtValor.Text = validarNumeros.ZeroValor(TxtValor.Text.Trim());
            TxtValor.Text = validarNumeros.FormatarValor(TxtValor.Text.Trim());
        }

        private void TxtValor_Enter(object sender, EventArgs e)
        {
            if (TxtValor.Text == "0,00")
            {
                TxtValor.Text = "";
            }
        }
        #endregion
    }
}
