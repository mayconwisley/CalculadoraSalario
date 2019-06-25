using BancoDados;
using Modelo;
using System;
using System.Data;

namespace Negocio
{
    public class NegDepen
    {

        CRUD Crud;
        string SQL = string.Empty;
        public bool Gravar(ModDependente modDependente)
        {
            Crud = new CRUD();
            SQL = "INSERT INTO IrrfDependente (Competencia, Valor) " +
                  "VALUES (@Competencia, @Valor)";
            try
            {

                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", modDependente.Competencia);
                Crud.AdicionarParamentro("Valor", modDependente.Valor);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Alterar(ModDependente modDependente)
        {
            Crud = new CRUD();
            SQL = "UPDATE IrrfDependente " +
                  "SET Competencia = @Competencia, Valor = @Valor " +
                  "WHERE Id = @Id";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", modDependente.Competencia);
                Crud.AdicionarParamentro("Valor", modDependente.Valor);
                Crud.AdicionarParamentro("Id", modDependente.Id);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool Excluir(ModDependente modDependente)
        {
            Crud = new CRUD();
            SQL = "DELETE FROM IrrfDependente " +
                  "WHERE Id = @Id";
            try
            {

                Crud.LimparParametro();
                Crud.AdicionarParamentro("Id", modDependente.Id);
                Crud.Executar(CommandType.Text, SQL);
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListaDependente(DateTime Competencia)
        {
            Crud = new CRUD();
            SQL = "SELECT Id, Competencia, Valor " +
                  "FROM IrrfDependente " +
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
        public decimal ValorDependente(DateTime competencia)
        {
            decimal porc = 0;
            Crud = new CRUD();
            SQL = "SELECT Min(Valor) " +
                  "FROM IrrfDependente " +
                  "WHERE @Competencia <= Competencia";
            try
            {
                Crud.LimparParametro();
                Crud.AdicionarParamentro("Competencia", competencia);
                if (Crud.Executar(CommandType.Text, SQL) is null)
                {
                    return 0;
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
    }
}
