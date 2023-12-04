using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YetGenAkbankJump.Domain.Enums;

namespace YetGenAkbankJump.Domain.Entities
{
    public class Student:EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; } //normalde bunlar class olur Country Country olmalıydı
        public string City { get; set; }
        public string Company { get; set; }
        public bool IsGraduated { get; set; }
        public int Age { get; set; }
        public decimal? RegistrationFee { get; set; }
        public Gender Gender { get; set; }
    }
}
