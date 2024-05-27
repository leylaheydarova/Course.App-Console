using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models
{
    public class Subjects:BaseEntity
    {
        public string Name {  get; set; }

        public override string ToString()
        {
            return $"{ID} - {Name}";
        }
    }
}
