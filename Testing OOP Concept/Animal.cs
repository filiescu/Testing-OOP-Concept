using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public abstract class Animal
    {
        public abstract void Mananca(); // metoda abstracta nu are o implemantare

        public void Doarme()
        {
            Console.WriteLine("Sleeping...");
        }
    }
}
