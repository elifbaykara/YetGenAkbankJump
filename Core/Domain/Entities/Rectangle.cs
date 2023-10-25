using Lecture_4_1.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_1.Domain.Entities
{
    public class Rectangle : Shape
    {
        public decimal ASide { get; set; }
        public decimal BSide { get; set; }

        public Rectangle()
        {
            Type = "Rectangle";
        }

        public override decimal GetArea()
        {
            return ASide * BSide;
        }
    }
}
