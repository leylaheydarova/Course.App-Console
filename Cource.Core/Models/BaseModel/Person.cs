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

        private const int _maxFinLength = 7;

        protected Person()
        {
            if (Fin.Length > _maxFinLength)
            {
                Fin = Fin.Substring(0, _maxFinLength);
            }
        }
        public override string ToString()
        {
            return $"{ID} - {Fin}  {FullName}\nContact: {Email} - {PhoneNumber}";
        }
    }
}
