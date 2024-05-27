using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public void Add(T entity);
        public void Update(T entity);
        public void Delete(int id);
        public T GetByID(int id);
        public ICollection<T> GetAll(); 
    }
}
