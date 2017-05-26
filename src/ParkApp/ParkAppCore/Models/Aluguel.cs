using System;
using System.Collections.Generic;
using System.Text;

namespace ParkAppCore.Models
{
    public class Aluguel
    {
        public int ID { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public int VagaID { get; set; }
        public decimal Ecoins { get; set; }
        public decimal EcoinsUtilizados { get; set; }
    }
}
