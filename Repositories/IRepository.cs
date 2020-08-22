using System;
using System.Collections.Generic;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Repositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        ICollection<T> GetAll();
        T GetById(Guid id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(Guid id);
    }
}