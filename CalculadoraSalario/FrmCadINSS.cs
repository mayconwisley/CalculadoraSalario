using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;
using Negocio;

namespace CalculadoraSalario
{
    public partial class FrmCadINSS : Form
    {
        public FrmCadINSS()
        {
            InitializeComponent();
        }
        NegInss negInss;
        ModInss modInss;
        int idInss;
        DateTime dtCompetencia;

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
    }
}
