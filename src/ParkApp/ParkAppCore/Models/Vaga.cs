using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkApp.Model
{
    public class Vaga
    {
        public string Endereco { get; set; }
        public string Longitude { get; set; }
        public string Latitude{ get; set; }
        public int Estrelas { get; set; }
        public int UsuarioID { get; set; }
        public string Foto { get; set; }
        public bool IsDisponivel { get; set; }
    }
}
