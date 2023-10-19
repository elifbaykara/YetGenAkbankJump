using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_1.Common
{
    public class Person<TKey>:EntityBase<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
