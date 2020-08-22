using System;
using System.Collections.Generic;
using System.Linq;
using RencontreContemporainesAPI.Models.Base;
using RencontreContemporainesAPI.Repositories;
using RencontreContemporainesAPI.Services.Interfaces;

namespace RencontreContemporainesAPI.Services
{
    public class CrudService<T> : ICrudService<T> where T : BaseEntity
    {
        private readonly IRepository<T> repository;

        public CrudService(IRepository<T> repository)
        {
            this.repository = repository;
        }

        public void Insert(T element)
        {
            this.repository.Insert(element);
        }

        public void Update(T element)
        {
            this.repository.Update(element);
        }

        public void Delete(Guid elementId)
        {
            this.repository.Delete(elementId);
        }

        public List<T> GetAll()
        {
            return repository.GetAll().ToList();
        }
    }
}