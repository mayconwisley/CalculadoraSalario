using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class ModIrrf
    {
        public int Id { get; set; }
        public DateTime Competencia { get; set; }
        public decimal Limite { get; set; }
        public decimal Porcentagem { get; set; }
        public decimal Desconto { get; set; }
    }
}
