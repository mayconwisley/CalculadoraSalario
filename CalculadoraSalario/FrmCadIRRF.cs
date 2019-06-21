using Modelo;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraSalario
{
    public partial class FrmCadIRRF : Form
    {
        public FrmCadIRRF()
        {
            InitializeComponent();
        }
        NegIrrf negIrrf;
        ModIrrf modIrrf;
        int idIrrf;
        DateTime dtCompetencia;

        private void Cadastro(char opc)
        {

            negIrrf = new NegIrrf();
            modIrrf = new ModIrrf();
            try
            {

                modIrrf.Id = idIrrf;
                modIrrf.Competencia = DateTime.Parse(MktComp.Text);
                modIrrf.Limite = decimal.Parse(TxtLimite.Text.Trim());
                modIrrf.Porcentagem = decimal.Parse(TxtPorc.Text.Trim());
                modIrrf.Desconto = decimal.Parse(TxtDesconto.Text.Trim());

                switch (opc)
                {
                    case 'G':
                        negIrrf.Gravar(modIrrf);
                        break;
                    case 'A':
                        negIrrf.Alterar(modIrrf);
                        break;
                    case 'E':
                        negIrrf.Excluir(modIrrf);
                        break;
                    default:
                        break;
                }
                Reset();
                ListarIrrf(dtCompetencia);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListarIrrf(DateTime competencia)
        {
            negIrrf = new NegIrrf();
            try
            {
                DgvListaIRRF.DataSource = negIrrf.ListaIrrf(competencia);
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

            TxtDesconto.Text = "0,00";
            TxtPorc.Text = "0,00";
            TxtLimite.Text = "0,00";
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

        private void DgvListaIRRF_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                idIrrf = int.Parse(DgvListaIRRF.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                MktComp.Text = DgvListaIRRF.Rows[e.RowIndex].Cells["Competencia"].Value.ToString();
                TxtLimite.Text = DgvListaIRRF.Rows[e.RowIndex].Cells["Limite"].Value.ToString();
                TxtDesconto.Text = DgvListaIRRF.Rows[e.RowIndex].Cells["Desconto"].Value.ToString();
                TxtPorc.Text = DgvListaIRRF.Rows[e.RowIndex].Cells["Porc"].Value.ToString();
                BtnAlterar.Enabled = true;
                BtnExcluir.Enabled = true;
                BtnGravar.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCadIRRF_Load(object sender, EventArgs e)
        {
            dtCompetencia = DateTime.Parse(DateTime.Now.ToString("MM/yyyy"));
            MktComp.Text = dtCompetencia.ToString("MM/yyyy");
            ListarIrrf(dtCompetencia);
        }
    }
}
