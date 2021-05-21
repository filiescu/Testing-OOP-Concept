using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    public class Muzician
    {
        public virtual void Canta (string name)
        {
            Console.WriteLine("{0} name", name);
        }
    }
}
