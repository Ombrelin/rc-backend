using System;
using System.Collections.Generic;
using RencontreContemporainesAPI.Models.Base;

namespace RencontreContemporainesAPI.Services.Interfaces
{
    public interface ICrudService<T> where T : BaseEntity
    {
        void Insert(T element);
        void Update(T element);
        void Delete(Guid elementId);
        List<T> GetAll();
    }
}