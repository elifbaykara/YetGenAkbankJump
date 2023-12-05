using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YetGenAkbankJump.Domain.Entities
{
    public class Category:EntityBase<Guid>
    {
        public string Name{ get; set; }
        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}
