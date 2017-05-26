using System;
using System.Collections.Generic;

namespace ParkAppCore.Repositorio
{
    public interface IRepository<T>
    {
        bool Insert(T obj);
        bool Remove(T obj);
        bool Update(T obj);
        IList<T> Find();
        T Find(int id);
    }
}
