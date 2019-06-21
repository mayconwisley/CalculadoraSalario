using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoDados
{
   public class Conexao
    {
        protected SQLiteConnection liteConnection;
        private string strConexao = @"Data Source=|DataDirectory|BancoDados\CalcFolha.db; Password=123456";

        protected bool Conectar()
        {
            liteConnection = new SQLiteConnection(strConexao);
            try
            {
                liteConnection.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception(ex.Message);
            }
        }
        protected bool Desconectar()
        {
            try
            {
                if (liteConnection.State != ConnectionState.Closed)
                {
                    liteConnection.Close();
                    liteConnection.Dispose();
                    return true;
                }
                else
                {
                    liteConnection.Dispose();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
