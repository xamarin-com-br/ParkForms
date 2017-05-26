using NUnit.Framework;
using System;

using System.Collections.Generic;
using ParkApp.Models;
using ParkAppCore.Repositorio;
using Moq;
using ParkAppCore.Models;

namespace AppCoreTest02
{
    [TestFixture()]
    public class TestGaragemMock
    {
        [TestFixtureSetUp]
        public void TestCaseSetup()
        {

            IList<Garagem> usuarios = new List<Garagem>
            {
                new Garagem(){ ID = 1, Endereco = "Rua dos Almirantes, n° 695", Estrelas = 3, IsDisponivel = true, Latitude = "-96544", Longitude = "-47851", UsuarioID = 1, Inicio = DateTime.Today.AddHours(6),   Fim = DateTime.Today.AddHours(10), Foto = "01.png"} ,
                new Garagem(){ ID = 2, Endereco = "Rua dos Casacas, n° 14", Estrelas = 2, IsDisponivel = true, Latitude = "-11452", Longitude = "-17836", UsuarioID = 1, Inicio = DateTime.Today.AddHours(6),   Fim = DateTime.Today.AddHours(10), Foto = "02.png"},
                new Garagem(){ ID = 3, Endereco = "Rua das morcegas, n° 78", Estrelas = 5, IsDisponivel = true, Latitude = "-54236", Longitude = "-55896", UsuarioID = 1, Inicio = DateTime.Today.AddHours(6),   Fim = DateTime.Today.AddHours(10), Foto = "03.png"}
            };

            Mock<IRepository<Garagem>> mockDeviceRepository = new Mock<IRepository<Garagem>>();

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
