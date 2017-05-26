using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkApp.Models
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public int Estrelas { get; set; }
        public string Foto { get; set; }
        public decimal Ecoins { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return (login.Equals(this.Login) && senha.Equals(this.Senha));
        }
    }
}
