using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models
{
    public class Lessons:BaseEntity
    {
        public Subjects subjects {  get; set; }
        public Teacher teacher { get; set; }
        public Group group { get; set; }

        public override string ToString()
        {
            return $"{ID}: {group} - {subjects} - {teacher}";
        }
    }
}
