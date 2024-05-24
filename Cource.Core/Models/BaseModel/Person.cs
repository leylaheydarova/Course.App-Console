using System;
using System.Collections.Generic;
using System.Text;

namespace Cource.Core.Models.BaseModel
{
    public abstract class Person:BaseEntity
    {
        public string FullName { get; set; }
        public string Fin { get; set; } //not more than 7 chars
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"{ID} - {Fin}  {FullName}\nContact: {Email} - {PhoneNumber}";
        }
    }
}
