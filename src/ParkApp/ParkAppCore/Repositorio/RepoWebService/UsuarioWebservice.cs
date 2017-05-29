using System;
using System.Collections.Generic;
using ParkApp.Models;

namespace ParkAppCore.Repositorio.RepoWebService
{
    public class UsuarioWebservice : IRepository<Usuario>
    {
        public UsuarioWebservice()
        {
        }

        public IList<Usuario> Find()
        {
            throw new NotImplementedException();
        }

        public Usuario FindByID(int id)
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
