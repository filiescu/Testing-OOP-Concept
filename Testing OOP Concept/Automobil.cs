using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Automobil : IMasina
    {
        public bool Start()
        {
            Console.WriteLine("Automobil pornit");
            return true;
        }

        public bool Stop()
        {
            Console.WriteLine("Automobil oprit");
            return true;
        }
    }
}
