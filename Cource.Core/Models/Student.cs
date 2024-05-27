using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models
{
    public class Student:Person
    {   
        Group group { get; set; }
        public override string ToString()
        {
            return base.ToString() + "-" + $"{group.Label}";
        }
    }
}
