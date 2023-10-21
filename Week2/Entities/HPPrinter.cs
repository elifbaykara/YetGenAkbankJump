using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Common;

namespace Week2.Entities
{

    interface IPrinter
    {
        void PrintPage();
    }

    public class HPPrinter : IPrinter
    {
        public void PrintPage()
        {
            Console.WriteLine("Printing in Color ");
        }
    }
}
