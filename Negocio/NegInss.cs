using BancoDados;
using Modelo;
using System;
using System.Data;

namespace Negocio
{
    public class NegInss
    {
        CRUD Crud;
        string SQL = string.Empty;
        public bool Gravar(ModInss modInss)
        {
            Crud = new CRUD();
            SQL = "INSERT INTO INSS (Competencia, Faixa, Teto_Faixa, Porc_Faixa) " +
                  "VALUES (@Competencia, @Faixa, @Teto_Faixa, @Porc_Faixa)";
            try
            {

                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", modInss.Competencia);
                Crud.AdicionarParamentro("Faixa", modInss.Faixa);
                Crud.AdicionarParamentro("Teto_Faixa", modInss.Teto);
                Crud.AdicionarParamentro("Porc_Faixa", modInss.Porcentagem);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Alterar(ModInss modInss)
        {
            Crud = new CRUD();
            SQL = "UPDATE INSS " +
                  "SET Competencia = @Competencia, Faixa = @Faixa, Teto_Faixa = @Teto_Faixa, Porc_Faixa = @Porc_Faixa " +
                  "WHERE Id = @Id";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", modInss.Competencia);
                Crud.AdicionarParamentro("Faixa", modInss.Faixa);
                Crud.AdicionarParamentro("Teto_Faixa", modInss.Teto);
                Crud.AdicionarParamentro("Porc_Faixa", modInss.Porcentagem);
                Crud.AdicionarParamentro("Id", modInss.Id);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(ModInss modInss)
        {
            Crud = new CRUD();
            SQL = "DELETE FROM INSS " +
                  "WHERE Id = @Id";
            try
            {

                Crud.LimparParametro();
                Crud.AdicionarParamentro("Id", modInss.Id);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListaInss(DateTime Competencia)
        {
            Crud = new CRUD();
            SQL = "SELECT Id, Competencia, Faixa, Teto_Faixa, Porc_Faixa " +
                  "FROM INSS " +
                  "WHERE Competencia = @Competencia " +
                  "ORDER BY Teto_Faixa ASC";
            try
            {

                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", Competencia);
                DataTable dataTable = Crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable ListaInssTudo()
        {
            Crud = new CRUD();
            SQL = "SELECT Id, Competencia, Faixa, Teto_Faixa, Porc_Faixa " +
                  "FROM INSS " +
                  "ORDER BY Competencia DESC, Teto_Faixa ASC";
            try
            {

                Crud.LimparParametro();
                DataTable dataTable = Crud.Consulta(CommandType.Text, SQL);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal PorcTeto(decimal salario)
        {
            decimal porc = 0;
            decimal teto = 0;
            Crud = new CRUD();
            DateTime dtCompetencia = DateTime.Parse(DateTime.Now.ToString("MM/yyyy"));
            teto = Teto(dtCompetencia);

            SQL = "SELECT Min(Porc_Faixa) " +
                  "FROM INSS " +
                  "WHERE Teto_Faixa >= @salario";
            try
            {
                if (salario >= teto)
                {
                    salario = teto;
                }

                Crud.LimparParametro();
                Crud.AdicionarParamentro("salario", salario);
                if (Crud.Executar(CommandType.Text, SQL).ToString() == "")
                {
                    return porc = 0;
                }
                else
                {
                    porc = decimal.Parse(Crud.Executar(CommandType.Text, SQL).ToString());
                    return porc;
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public decimal Teto(DateTime competencia)
        {
            decimal porc = 0;
            Crud = new CRUD();
            SQL = "SELECT Max(Teto_Faixa) " +
                  "FROM INSS " +
                  "WHERE Competencia = @Competencia";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", competencia);
                porc = decimal.Parse(Crud.Executar(CommandType.Text, SQL).ToString());
                return porc;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

        public DateTime UltimaCompetencia()
        {
            Crud = new CRUD();
            SQL = "SELECT Competencia " +
                  "FROM INSS " +
                  "GROUP BY Competencia " +
                  "ORDER BY Competencia DESC ";
            try
            {
                Crud.LimparParametro();
                string dtCompetencia = Crud.Executar(CommandType.Text, SQL).ToString();




                if (dtCompetencia != null)
                {
                    return DateTime.Parse(dtCompetencia);
                }
                else
                {
                    return DateTime.Today;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
