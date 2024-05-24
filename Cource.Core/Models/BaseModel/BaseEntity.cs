using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models.BaseModel
{
    public abstract class BaseEntity
    {
        public int ID { get; set; }
        public DateTime Createdat { get; set; }
        public DateTime Updatedat { get; set; }

    }
}
