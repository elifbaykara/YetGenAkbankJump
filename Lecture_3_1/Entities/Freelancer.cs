using Lecture_3_1.Abstract;
using Lecture_3_1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_1.Entities
{
    public class Freelancer:Person<Guid>, ICsvConvertible
    {
        public string WorkExperience { get; set; }
        public List<Review> Reviews { get; set; }

        public string GetValuesCSV()
        {
            return $"{Id},{FirstName},{LastName},{CreatedOn}";
        }
    }
}
