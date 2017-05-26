using System;
using System.Collections.Generic;
using ParkApp.Models;

namespace ParkAppCore.Repositorio.RepoSQLite
{
    public class UsuarioSQLite : IRepository<Usuario>
    {
        public UsuarioSQLite()
        {
        }

        public IList<Usuario> Find()
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
