using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificatori_de_acces
{
    public class Employee
    {
        public DateTime Birthdate { get; private set; }

        public Employee(DateTime birthdate) // Am creat acest constructor, pt ca am pus private la setarea variabilei Birthdate
        {
            Birthdate = birthdate;
        }
       
        public int Age
        {
            get
            {
                var timeSpan = DateTime.Today - Birthdate;
                var years = timeSpan.Days / 365;
                return years;
            }
        }
     
    }
}
