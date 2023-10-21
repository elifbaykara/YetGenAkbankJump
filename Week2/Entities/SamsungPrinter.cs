using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Common;

interface IPrinter
{
    void PrintPage();
}

namespace Week2.Entities
{

    public class SamsungPrinter : IPrinter
    {
        public void PrintPage()
        {
            Console.WriteLine("Print in Black and White");
        }
    }
}
