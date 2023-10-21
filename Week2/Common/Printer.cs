using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Common
{
    //Sınıflar arası davranış farklılığı olunca direkt olarak sınıflardan kalıtım gerçekleştiremeyiz. Diyelim ki biri siyah-beyaz diğeri renkli çıktı alıyor ortak bir yerden metot alacağız. O zaman ne yapmalıyız ?
    public class Printer
    {
        public void PrintPage()
        {
            Console.WriteLine("Printing in Color ");
        }


    }
}
