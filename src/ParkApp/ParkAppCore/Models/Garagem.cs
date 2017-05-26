using System;
using System.Collections.Generic;
using System.Text;

namespace ParkAppCore.Models
{
    public class Garagem
    {
        public string Endereco { get; set; }
        public string Longitude { get; set; }
        public string Latitude { get; set; }
        public int Estrelas { get; set; }
        public int UsuarioID { get; set; }
        public string Foto { get; set; }
        public bool IsDisponivel { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
    }
}
