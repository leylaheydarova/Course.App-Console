using Cource.Core.Models.BaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models
{
    public class ScoreOfStudent:BaseEntity
    {   
        public DateTime Time {  get; set; }
        public Student student { get; set; }
        public Subjects subjects { get; set; }
    }
}
