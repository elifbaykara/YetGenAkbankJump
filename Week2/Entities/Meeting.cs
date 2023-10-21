using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2.Abstract;
using Week2.Common;

namespace Week2.Entities
{
    public class Meeting : Event, INotification
    {
        public List<string> Guests { get; set; }

        public void GetNotification()
        {
            foreach (var guest in Guests)
            {
                Console.WriteLine($"Inviting : {guest}");
            }
        }
    }
}
