using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class Cerc : Forma
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
        }
    }

    public class Dreptunghi : Forma
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

   public class Forma
    {
        public int Height { get; set; }
        public int Wight { get; set; }

        public virtual void Draw()
        {

        }
    }
}
