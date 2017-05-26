using System;
using ParkApp.Models;
using System.Collections.Generic;

namespace ParkAppCore.Repositorio.Mocks
{
    public class UsuarioMock : IRepository<Usuario>
    {
       
        public UsuarioMock()
        {
        }

        public IList<Usuario> Find()
        {
            throw new NotImplementedException();
        }

        public Usuario Find(int id)
        {
            throw new NotImplementedException();
        }

        public bool Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
