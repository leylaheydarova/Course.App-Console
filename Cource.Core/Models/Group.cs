using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models
{
    public class Group:BaseEntity
    {
        public string Label { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Label} - {Description}";
        }
    }
}
