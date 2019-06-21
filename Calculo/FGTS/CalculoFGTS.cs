using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.FGTS
{
   public static class CalculoFGTS
    {
        public static decimal FGTS(decimal salario, decimal porcentagem)
        {
            porcentagem = porcentagem / 100;
            return salario * porcentagem;
        }
    }
}
