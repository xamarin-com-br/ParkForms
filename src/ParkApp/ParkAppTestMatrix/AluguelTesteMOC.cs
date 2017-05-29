using NUnit.Framework;
using ParkAppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using ParkAppCore.Repositorio;

namespace ParkAppTestMatrix
{
    [TestFixture]
    public class AluguelTesteMOC
    {
        [TestFixtureSetUp]
        public void TestCaseSetup()
        {
            IList<Aluguel> alugueis = new List<Aluguel> {
                new Aluguel() {ID=1, Inicio=DateTime.Now,Fim=DateTime.Now,VagaID=1,Ecoins=55,EcoinsUtilizados=25 },
                new Aluguel() {ID=2, Inicio=DateTime.Now,Fim=DateTime.Now,VagaID=2,Ecoins=65,EcoinsUtilizados=35 },
                new Aluguel() {ID=3, Inicio=DateTime.Now,Fim=DateTime.Now,VagaID=3,Ecoins=75,EcoinsUtilizados=45 },
                new Aluguel() {ID=4, Inicio=DateTime.Now,Fim=DateTime.Now,VagaID=4,Ecoins=85,EcoinsUtilizados=55 },
                new Aluguel() {ID=5, Inicio=DateTime.Now,Fim=DateTime.Now,VagaID=5,Ecoins=95,EcoinsUtilizados=65 }


            };
            Mock<IRepository<Aluguel>> mockDeviceRepository = new Mock<IRepository<Aluguel>>();

            

            mockDeviceRepository.Setup(x => x.Find()).Returns(alugueis);
            mockDeviceRepository.Setup(mr => mr.FindByID(It.IsAny<int>())).Returns((int i) => alugueis.Where(x => x.ID == i).Single());


            mockDeviceRepository.Setup(mr => mr.Insert(It.IsAny<Aluguel>())).Returns(
                (Aluguel target) =>
                {
                    DateTime now = DateTime.Now;

                    if (target.ID.Equals(default(int)))
                    {
                        // target.Inicio= now;
                       // target.Fim = now;
                        target.ID = alugueis.Count() + 1;
                        //target.Ecoins = 22;
                        //target.EcoinsUtilizados = 33;
                        //target.VagaID = 99;
                        alugueis.Add(target);

                    }
                    else
                    {
                        var original = alugueis.Where(q => q.ID == target.ID).Single();

                        if (original == null)
                        {
                            return false;
                        }

                        original.Inicio = target.Inicio;
                        original.Fim = target.Fim;
                        original.Ecoins = target.Ecoins;
                        original.EcoinsUtilizados = target.EcoinsUtilizados;
                        original.VagaID = target.VagaID;
                        
                    }

                    return true;
                });



            this.MockDevicesRepositoryGlobal = mockDeviceRepository.Object;
        }

        public  IRepository<Aluguel>  MockDevicesRepositoryGlobal;
        [Test]
        public void insertAlugelSuccess()
        {
            //arrange
            Aluguel novoAluguel = new Aluguel();
            novoAluguel.VagaID = 88;
            novoAluguel.Inicio = DateTime.Now;
            novoAluguel.Fim = DateTime.Now;
            novoAluguel.Ecoins = 10;
            novoAluguel.EcoinsUtilizados = 5;
                     
          
            this.MockDevicesRepositoryGlobal.Insert(novoAluguel);
            int alugueisTotal = this.MockDevicesRepositoryGlobal.Find().Count();
            Assert.AreEqual(6, alugueisTotal);            

        }

        [Test]
        public void vagaExiste()
        {
            Aluguel alguel = MockDevicesRepositoryGlobal.FindByID(2);
            bool retorno = alguel.GetVagaID(2);
            Assert.IsTrue(retorno);
        }
    }
}
