using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week3.Entities;

namespace Week3.Services
{
    public class ShippingService
    {
        public decimal CalculateTax(Product product, string country)
        {
            if (country == "U.S.A")
                return product.Price * 1.2m;
            else if (country == "Türkiye")
                return product.Price * 1.1m;
            else if(country =="Spain")
                return product.Price*1.4m;

            return -1;
        }

    }
}
