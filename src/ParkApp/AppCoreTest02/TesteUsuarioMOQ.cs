using NUnit.Framework;
using System;

using System.Collections.Generic;
using ParkApp.Models;
using ParkAppCore.Repositorio;
using Moq;
using System.Collections.ObjectModel;

namespace AppCoreTest02
{
    [TestFixture()]
    public class TesteUsuarioMOQ
    {
        public Mock<IRepository<Usuario>> MockRepository;

        public IRepository<Usuario> UsuariosMock;

        [TestFixtureSetUp]
		public void TestCaseSetup()
		{
            Usuario[] usuarios =
            {
                new Usuario() { ID = 1, Nome = "Jose", Senha = "1234", Login = "l1" },
                new Usuario() { ID = 2, Nome = "Jose2", Senha = "2", Login = "l2" },
                new Usuario() { ID = 3, Nome = "Jose3", Senha = "3", Login = "l3" }
            };

            Mock<IRepository<Usuario>> mockUsuarioRepository = new Mock<IRepository<Usuario>>();
        
            mockUsuarioRepository.Setup(mr => mr.Find()).Returns(usuarios);

            //mockUsuarioRepository.Setup(mr => mr.Insert(It.IsAny<Usuario>())).Returns(
            //    (Usuario target) =>
            //    {
            //        DateTime now = DateTime.Now;

            //        if (target.ID.Equals(default(int)))
            //        {
            //            target.Nome = "Novo";
            //            target.Login = "Novo";
            //            target.Senha = "Novo";
            //            target.Ecoins = 10;
            //            target.Estrelas = 1;
            //            target.ID = usuarios.ToArray().Length + 1;
            //            usuarios.Add(target);
            //        }
            //        else
            //        {
            //            var original = usuarios.ToArray().ToL(q => q.DeviceId == target.DeviceId).Single();

            //            if (original == null)
            //            {
            //                return false;
            //            }

            //            original.Name = target.Name;
            //            original.Price = target.Price;
            //            original.Description = target.Description;
            //            original.DateModified = now;
            //        }

            //        return true;
            //    });



            Mock<IRepository<Usuario>> mockDeviceRepository = new Mock<IRepository<Usuario>>();

			mockDeviceRepository.Setup(mr => mr.Find()).Returns(usuarios);

            mockDeviceRepository.Setup(i => i.Insert(It.IsAny<Usuario>()));

            //mockDeviceRepository.Setup(mr => mr.Find( It.IsAny<int>() )).Returns((int i) => devices.Where(x => x.ID == i).Single());

            //mockDeviceRepository.Setup( i => i.Insert(It.IsAny<Usuario>() ) ).Returns{ usuarios.Add(It.IsAny<Usuario>());} ;
            this.UsuariosMock = mockDeviceRepository.Object;
		}

		[Test()]
        public void TestInsert()
        {
            
        }

		[Test()]
		public void TestRemove()
		{
		}

		[Test()]
		public void TestFind()
		{
            var lista =  UsuariosMock.Find();
            Assert.AreEqual(lista.Count, 3);

		}

		[Test()]
		public void TestFindID()
		{
		}

		[Test()]
		public void TestLoginAutenticacao()
		{
            var lista = UsuariosMock.Find();
            Assert.AreEqual(lista[0].Autenticar("jose", "1234"),true);

		}


    }
}
