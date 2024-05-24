using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Data.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        public void Add(T id);
        public void Update(T id);
        public void Delete(T id);
        public T GetByID(T id);
        public ICollection<T> GetAll(); 
    }
}
