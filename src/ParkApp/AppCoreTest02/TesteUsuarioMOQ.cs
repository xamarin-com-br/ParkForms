using NUnit.Framework;
using System;

using System.Collections.Generic;
using ParkApp.Models;
using ParkAppCore.Repositorio;
using Moq;

namespace AppCoreTest02
{
    [TestFixture()]
    public class TesteUsuarioMOQ
    {
        [TestFixtureSetUp]
		public void TestCaseSetup()
		{

            IList<Usuario> usuarios = new List<Usuario>
            {
                new Usuario(){ ID = 1, Nome = "Jose", Senha = "1234", Login = "l1" } ,
                new Usuario(){ ID = 2, Nome = "Jose2", Senha = "1234", Login = "l2" },
                new Usuario(){ ID = 3, Nome = "Jose3", Senha = "1234", Login = "l3" } 
            };


            Mock<IRepository<Usuario>> mockDeviceRepository = new Mock<IRepository<Usuario>>();

			mockDeviceRepository.Setup(mr => mr.Find()).Returns(usuarios);

			//mockDeviceRepository.Setup(mr => mr.Find( It.IsAny<int>() )).Returns((int i) => devices.Where(x => x.ID == i).Single());

            //mockDeviceRepository.Setup( i => i.Insert(It.IsAny<Usuario>() ) ).Returns{ usuarios.Add(It.IsAny<Usuario>());} ;

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
		}

		[Test()]
		public void TestFindID()
		{
		}
    }
}
