using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models
{
    public class Group:BaseEntity
    {
        string Label { get; set; }
        string Description { get; set; }
    }
}
