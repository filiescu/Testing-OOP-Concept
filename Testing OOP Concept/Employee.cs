using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modificatori_de_acces
{
    public class Employee
    {
        protected int Id { get; set; }
        public string Name { get; set; }

        private int CalculateRating(bool excludeOrders)
        {
            return 0;
        }

        public void Promote()
        {
            var rating = CalculateRating(excludeOrders: true); // private - accesibil numai din interiorul clasei
            if (rating == 0)
            {
                Console.WriteLine("Promoted to Level 1");
            }
            else
                Console.WriteLine("Promoted to level 2");
        }

        protected void GetEmployeeDetails()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Id: {0}", Id); // protected - accesibil numai din interiorul clasei şi a claselor derivate
        }
     
    }
}
