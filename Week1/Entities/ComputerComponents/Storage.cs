using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Enums;

namespace Week1.Entities.ComputerComponents
{
    public class Storage
    {
        public string Brand { get; set; }
        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

        public Storage(string brand, int size, CapacitySizeType sizeType)
        {
            Brand = brand;
            Size = size;
            SizeType = sizeType;
        }
        public Storage()
        {
            
        }

    }
}
