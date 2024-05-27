using Cource.Core.Models.BaseModel;
using Cource.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cource.Data.Repositories.Implements
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private static ICollection<T> _entities = new List<T>();
        public void Add(T entity) => _entities.Add(entity);


        public void Delete(int id)
        {
            T entity = GetByID(id);
            if (entity != null) _entities.Remove(entity);
        }

        public ICollection<T> GetAll() => _entities;

     

        public T GetByID(int id) => _entities.FirstOrDefault(x => x.ID == id);

        public void Update(T entity)
        {
           T updatedentity = GetByID(entity.ID);
            if (updatedentity != null)
            {
                updatedentity = entity;
            }
        }
    }
}
