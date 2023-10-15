using Lecture_1_2.Common;
using Lecture_1_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_1_2.Entities
{
    public class Student:PersonBase
    {
 
        public int No { get; set; }

        public DateTimeOffset RegistrationDate { get; set; }
    }
}
