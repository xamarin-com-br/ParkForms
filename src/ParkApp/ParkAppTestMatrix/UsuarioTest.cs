using NUnit.Framework;
using ParkApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkAppTestMatrix
{
    [TestFixture]
    public class UsuarioTest
    {
        [Test]
        public void UsuarioSalvo()
        {
            Usuario novoUsuario = new Usuario();           


            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }

        [Test]
        public void UsuarioNãoSalva()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
    }
}
