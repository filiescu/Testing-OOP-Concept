using System;

namespace MetodaStatica_MetodaNonstatica
{
    public class Person
    {
        public static int Count = 0;

        public void NonStaticMethod()
        {
            Console.WriteLine("NonStaticMethod");
           // StaticMethod(); // o metoda nonstatica poate apela o metoda statica
            Count++;
        }

        public static void StaticMethod()
        {
            Console.WriteLine("StaticMethod");
            //NonStaticMethod(); // o metoda statica nu poate apela o metoda nonstatica
            Count++;
        }
    }
}
