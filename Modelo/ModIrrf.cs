﻿using System;

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
