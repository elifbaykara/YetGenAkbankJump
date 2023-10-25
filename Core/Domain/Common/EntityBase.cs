using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4_1.Domain.Common
{
    public class EntityBase<TKey>
    {
        public TKey Id { get; set; }
        public DateTimeOffset CreatedOn { get; set; }
    }
}
