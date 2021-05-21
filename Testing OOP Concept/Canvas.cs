using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    public class Canvas
    {
       public void DrawShape(List<Forma> shapes)
        {
            foreach(var forma in shapes)
            {
                forma.Draw();
            }
        }
    }
}
