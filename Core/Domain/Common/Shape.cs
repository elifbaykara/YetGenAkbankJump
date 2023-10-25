using Lecture_4_1.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_1.Domain.Common
{
    public abstract class Shape:EntityBase<Guid>, ISaveable
    {
        public string Type { get; set; }

        public abstract decimal GetArea();
        public string GetInfo()
        {
            return Type;
        }
      
    }
}
