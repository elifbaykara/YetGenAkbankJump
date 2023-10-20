using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Enums;

namespace Week1.Entities.ComputerComponents
{
    public class RAM
    {
        public string Brand { get; set; }
        public int Size { get; set; }
        public CapacitySizeType SizeType { get; set; }

        public RAM(string brand, int size, CapacitySizeType sizeType)
        {
            Brand = brand;
            Size = size;
            SizeType = sizeType;
        }
        public RAM()
        {
            
        }
    }
}
