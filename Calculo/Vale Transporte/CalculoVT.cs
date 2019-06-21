using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculo.Vale_Transporte
{
    public static class CalculoVT
    {
        public static decimal ValeTransporte(decimal salario, decimal porcentagem)
        {
            porcentagem = porcentagem / 100;
            return salario * porcentagem;
        }

    }
}
