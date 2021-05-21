using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Pisica : Animal
    {
        public override void Mananca()
        {
            Console.WriteLine("Pisica mananca soareci"); // metoda abstracta se implementeaza in clasa derivata
        }
    }
}
