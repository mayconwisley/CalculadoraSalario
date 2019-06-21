using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModInss
    {
        public int Id { get; set; }
        public DateTime Competencia { get; set; }
        public int Faixa { get; set; }
        public decimal Teto { get; set; }
        public decimal Porcentagem { get; set; }
    }
}
