using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class EmployeeAmazon
    {
        protected int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); // Internal - accesibil din interiorul, din exteriorul clasei dar numai în cadrul assembly-ului
            var rating = calculator.Calculate(this);

            Console.WriteLine("Promote logic changed");
        }

     
    }
}
