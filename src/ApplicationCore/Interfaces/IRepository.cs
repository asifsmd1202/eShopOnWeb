using ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface IRepository<T> where T : BaseEntify
    {
        T GetById(int id);
        List<T> List();
        List<T> List(ISpecification<T> spec);
        T Add(T entify);
        void Update(T entity);
        void Delete(T entity);
    }
}
