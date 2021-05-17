using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructori
{
   public class Customer
    {
        public int Id;
        public string Name;

        public Customer()
        {
            Console.WriteLine("Constructor fara param");
        }

        public Customer (int id)
        {
            this.Id = id;
            Console.WriteLine("Constructor cu un param");
        }
        public Customer(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            Console.WriteLine("Constructor cu doi param");
        }
    }
}
