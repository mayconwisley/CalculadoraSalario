using BancoDados;
using Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                  "WHERE Competencia = @Competencia";
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
        public decimal PorcTeto(decimal salario)
        {
            decimal porc = 0;
            Crud = new CRUD();
            SQL = "SELECT Min(Porc_Faixa) " +
                  "FROM INSS " +
                  "WHERE @salario <= Teto_Faixa";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("salario", salario);
                porc = decimal.Parse(Crud.Executar(CommandType.Text, SQL).ToString());
                return porc;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
    }
}
