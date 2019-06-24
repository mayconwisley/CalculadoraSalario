using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BancoDados;
using Modelo;
namespace Negocio
{
    public class NegIrrf
    {
        CRUD Crud;

        string SQL = string.Empty;
        public bool Gravar(ModIrrf modIrrf)
        {
            Crud = new CRUD();
            SQL = "INSERT INTO IRRF (Competencia, Limite, Porc, Desconto) " +
                  "VALUES (@Competencia, @Limite, @Porc, @Desconto)";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", modIrrf.Competencia);
                Crud.AdicionarParamentro("Limite", modIrrf.Limite);
                Crud.AdicionarParamentro("Porc", modIrrf.Porcentagem);
                Crud.AdicionarParamentro("Desconto", modIrrf.Desconto);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Alterar(ModIrrf modIrrf)
        {
            Crud = new CRUD();
            SQL = "UPDATE IRRF " +
                  "SET Competencia = @Competencia, Limite = @Limite, Porc = @Porc, Desconto = @Desconto " +
                  "WHERE Id = @Id";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", modIrrf.Competencia);
                Crud.AdicionarParamentro("Limite", modIrrf.Limite);
                Crud.AdicionarParamentro("Porc", modIrrf.Porcentagem);
                Crud.AdicionarParamentro("Desconto", modIrrf.Desconto);
                Crud.AdicionarParamentro("Id", modIrrf.Id);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(ModIrrf modIrrf)
        {
            Crud = new CRUD();
            SQL = "DELETE FROM IRRF " +
                  "WHERE Id = @Id";
            try
            {

                Crud.LimparParametro();
                Crud.AdicionarParamentro("Id", modIrrf.Id);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaIrrf(DateTime Competencia)
        {
            Crud = new CRUD();
            SQL = "SELECT Id, Competencia, Limite, Porc, Desconto " +
                  "FROM IRRF " +
                  "WHERE Competencia = @Competencia " +
                  "ORDER BY Limite ASC";
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
        public decimal PorcLimite(decimal salario)
        {
            decimal porc = 0;
            Crud = new CRUD();
            SQL = "SELECT Max(Porc) " +
                  "FROM IRRF " +
                  "WHERE @salario >= Limite";
            try
            {
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
        public decimal Desconto(decimal salario)
        {
            decimal porc = 0;
            Crud = new CRUD();
            SQL = "SELECT Max(Desconto) " +
                  "FROM IRRF " +
                  "WHERE @salario >= Limite";
            try
            {
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
        public decimal Limite(DateTime competencia)
        {
            decimal limite = 0;
            Crud = new CRUD();
            SQL = "SELECT Min(Limite) " +
                  "FROM IRRF " +
                  "WHERE Competencia = @Competencia";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", competencia);
                limite = decimal.Parse(Crud.Executar(CommandType.Text, SQL).ToString());
                return limite;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }

    }
}
