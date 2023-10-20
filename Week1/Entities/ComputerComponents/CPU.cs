using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week1.Enums;

namespace Week1.Entities.ComputerComponents
{
    public class CPU
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public double ClockSpeed { get; set; }
        public CapacitySizeType ClockSpeedType { get; set; }
        public double Cache {  get; set; }
        public CapacitySizeType CacheType { get; set; }
        public CPU()
        {
            
        }
        public CPU(string brand, string model, double clockSpeed, CapacitySizeType clockSpeedType, double cache, CapacitySizeType cacheType)
        {
            Brand = brand;
            Model = model;
            ClockSpeed = clockSpeed;
            ClockSpeedType = clockSpeedType;
            Cache = cache;
            CacheType = cacheType;
        }
    }
}
