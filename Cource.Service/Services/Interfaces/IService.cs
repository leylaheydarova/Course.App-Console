using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Service.Services.Interfaces
{
    public interface IService
    {
        public void Add();
        public void Delete();
        public void Update();
        public void GetByID();
        public void GetAll();
    }
}
