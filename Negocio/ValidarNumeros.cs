using System;

namespace Negocio
{
    public class ValidarNumeros
    {
        string strValor = string.Empty;
        int posicao = 0;

        public string Valor(string valor)
        {
            try
            {
                foreach (char x in valor)
                {
                    posicao = "1234567890,.".IndexOf(x);
                    if (posicao >= 0)
                    {
                        if (x == Convert.ToChar(","))
                        {
                            if (strValor.IndexOf(",") < 0)
                            {
                                strValor = strValor + x;
                            }
                        }
                        else
                        {
                            strValor = strValor + x;
                        }
                    }
                }
                return strValor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string FormatarValor(string valor)
        {
            decimal formatar = decimal.Parse(valor);
            strValor = formatar.ToString("#,##0.00");
            if (strValor == "0,00")
            {
                strValor = "0,00";
            }
            return strValor;
        }

        public string ZeroValor(string valor)
        {
            strValor = valor;
            if (valor == "")
            {
                strValor = "0,00";
            }
            return strValor;
        }
        public string Numero(string valor)
        {
            try
            {
                foreach (char x in valor)
                {
                    posicao = "1234567890".IndexOf(x);
                    if (posicao >= 0)
                    {
                        strValor = strValor + x;
                    }
                }
                return strValor;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string FormatarNumero(string valor)
        {
            decimal formatar = decimal.Parse(valor);
            strValor = formatar.ToString("0");
            if (strValor == "0")
            {
                strValor = "0";
            }
            return strValor;
        }

        public string ZeroNumero(string valor)
        {
            strValor = valor;
            if (valor == "")
            {
                strValor = "0";
            }
            return strValor;
        }
    }
}
