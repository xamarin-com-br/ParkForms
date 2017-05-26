using ParkAppCore.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParkAppCore.Repositorio.Mocks
{
    public class GaragemMock : IRepository<Garagem>
    {
        public IList<Garagem> Find()
        {
            throw new NotImplementedException();
        }

        public Garagem Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Garagem obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Garagem obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Garagem obj)
        {
            throw new NotImplementedException();
        }
    }
}
