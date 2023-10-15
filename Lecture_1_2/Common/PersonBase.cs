using Lecture_1_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_2.Common
{
    //common ortak anlamına geliyor bu nedenle common adında bir klasör açtım :) student ve teacher 'de ortak olanları buraya yazıp bu classı onlara kalıtacağım :)
    public class PersonBase
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public void SayMyName() => Console.WriteLine($"{FirstName} {LastName}");
    }
}
