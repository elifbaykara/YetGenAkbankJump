using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public decimal Balance { get; private set; }

        public Account(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Balance = 10000;
        }
        public void WithDraw(decimal amount)
        {
            if(Balance-amount >= 0)
            {
                Balance -= amount;
            }
        }
    }
}
