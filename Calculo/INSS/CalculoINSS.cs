using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.INSS
{
    public static class CalculoINSS
    {
        public static decimal INSS(decimal salario, decimal porcentagem)
        {
            decimal VlrInss;
            porcentagem = porcentagem / 100;
            VlrInss = salario * porcentagem;
            return VlrInss;
        }

    }
}
