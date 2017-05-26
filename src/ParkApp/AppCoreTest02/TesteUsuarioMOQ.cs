using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;
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
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario() { ID = 1, Nome = "Jose", Senha = "1234", Login = "l1" },
                new Usuario() { ID = 2, Nome = "Jose2", Senha = "2", Login = "l2" },
                new Usuario() { ID = 3, Nome = "Jose3", Senha = "3", Login = "l3" }
            };

            Mock<IRepository<Usuario>> mockUsuarioRepository = new Mock<IRepository<Usuario>>();

            mockUsuarioRepository.Setup(mr => mr.Find()).Returns(usuarios);

            mockUsuarioRepository.Setup(mr => mr.Insert(It.IsAny<Usuario>())).Returns(
                (Usuario target) =>
                {
                    DateTime now = DateTime.Now;

                    if (target.ID.Equals(default(int)))
                    {
                        target.ID = usuarios.ToArray().Length + 1;
                        usuarios.Add(target);
                    }
                    else
                    {
                        var original = usuarios.Where(q => q.ID == target.ID).Single();

                        if (original == null)
                        {
                            return false;
                        }

                        original.Nome = target.Nome;
                        original.Login = target.Login;
                        original.Senha = target.Senha;
                        original.Ecoins = target.Ecoins;
                        original.Estrelas = target.Estrelas;
                        original.ID = target.ID;
                    }

                    return true;

                });

            Mock<IRepository<Usuario>> mockDeviceRepository = new Mock<IRepository<Usuario>>();

            mockDeviceRepository.Setup(mr => mr.Find()).Returns(usuarios);

            mockDeviceRepository.Setup(mr => mr.Find(It.IsAny<int>())).Returns((int i) => usuarios.Where(x => x.ID == i).Single());

            mockDeviceRepository.Setup(mr => mr.Remove(It.IsAny<Usuario>())).Returns((Usuario tar) => usuarios.Remove(tar));

            this.UsuariosMock = mockDeviceRepository.Object;
        }

        [Test()]
        public void TestInsert()
        {
            Usuario target = new Usuario();
            target.Nome = "Novo";
            target.Login = "Novo";
            target.Senha = "Novo";
            target.Ecoins = 10;
            target.Estrelas = 1;
            UsuariosMock.Insert(target);
            var total = UsuariosMock.Find().Count;
            Assert.AreEqual(3, total);
        }

        [Test()]
        public void TestRemove()
        {
            var usu = UsuariosMock.Find(1);
            UsuariosMock.Remove(usu);
            var total = UsuariosMock.Find().Count;
            Assert.AreEqual(2, total);
        }

        [Test()]
        public void TestFind()
        {
            var total = UsuariosMock.Find().Count;
            Assert.AreEqual(3, total);
        }

        [Test()]
        public void TestFindID()
        {
            var user = UsuariosMock.Find(1);
            Assert.IsNotNull(user);
        }

        [Test()]
        public void TestLoginAutenticacao()
        {
            var user = UsuariosMock.Find(1);
            Assert.AreEqual(user.Autenticar("l1", "1234"), true);
        }
    }
}
