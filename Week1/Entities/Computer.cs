using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Week1.Entities.ComputerComponents;
using Week1.Enums;

namespace Week1.Entities
{
    public class Computer
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public CPU CPU { get; set; } //şimdi storage için ayrı bir sürü property cpu için de aynı şekilde yani böyle giderse bizim computer classını yönetmemiz zorlaşır bu nedenle entities altına başka bir class açıp oraya ekleyelim :)
  
        public RAM RAM { get; set; }
        public Storage Storage { get; set; } //yani aslında ben storage classını buraya yazdım, artık tek tek buraya yazmaktansa storage classındaki storage kullanıyorum :)
         
        public Computer()
        {
            Random random = new Random();
            Id = random.Next(10000, int.MaxValue);
        }
        public Computer(string brand, string model, CPU cPU, RAM rAM, Storage storage) : this(brand, model)
        {
            CPU = cPU;
            Storage = storage;
            RAM = rAM;
        }

        public Computer(string brand, string model) : this()
        {
            Brand = brand;
            Model = model;
        }
        //Birden fazla, farklı farklı ctor tanımlayabilirsin !!!!!!!!!!Ama binlerce id olduğunu düşün tek tek nasıl akılda tutacaksın ? 
        //Random id ataması yapsak ?
        //Önce diyelim ki 4 parametreli conts çağırdık. This içindeki brand ve model alacak ardından oradaki this () yerine gidip id alacak ve sonra kendi yerine dönüp cpu ve ram alacak :)

    }
}
