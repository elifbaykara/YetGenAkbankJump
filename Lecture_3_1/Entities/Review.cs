using Lecture_3_1.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_3_1.Entities
{
    public class Review:EntityBase<Guid>
    {
        public string Text { get; set; }
        public int Point {  get; set; }

    }
}
