using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.IRRF
{
    public class CalculoIRRF
    {
        public static decimal IRRF(decimal salario, decimal inss, decimal dependente, decimal porcentagem, decimal deducao)
        {
            decimal vlrBase;
            decimal vlrIRRF;
            porcentagem = porcentagem / 100;
            vlrBase = salario - inss - dependente;
            vlrIRRF = (vlrBase * porcentagem) - deducao;
            if (vlrIRRF <= 0)
            {
                return 0;
            }
            else
            {
                return vlrIRRF;
            }

        }
    }
}
