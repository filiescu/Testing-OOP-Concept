using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfism
{
    public class Violonist : Muzician
    {
        public override void Canta(string name)
        {
            Console.WriteLine("{0} canta la vioara", name);
        }
    }
}
