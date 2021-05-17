using Clasa_Derivata;
using Constructori;
using MetodaStatica_MetodaNonstatica;
using Modificatori_de_acces;
using System;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            //StaticMethod();
            //ConstructorMethod();
            //AccessModifiers();
            InheritanceMethod();
        }
       
        ////////////////////// MetodaStatica_MetodaNonstatica ///////////////////////
        
        static void StaticMethod() 
        {
            var person1 = new Person();
            person1.NonStaticMethod();
            Console.WriteLine(Person.Count);

            var person2 = new Person();
            person2.NonStaticMethod();
            Console.WriteLine(Person.Count);

            var person3 = new Person();
            person3.NonStaticMethod();
            Console.WriteLine(Person.Count);

            Person.StaticMethod();

            Console.WriteLine(Person.Count++);
            Console.WriteLine(Person.Count++);
        }

        ///////////////////////// Constructori //////////////////////////////////
       
        static void ConstructorMethod()
        {
            var customer = new Customer(1, "Ionescu");
            Console.WriteLine(customer.Id + " " + customer.Name);

            var customer2 = new Customer
            {
                Id = 2,
                Name = "Popescu"
            };
            Console.WriteLine(customer2.Id + " " + customer2.Name);
        }

        ///////////////////////// Modificatori de acces //////////////////////////////////
        
        static void AccessModifiers()
        {
            var employee = new Employee(new DateTime(1982, 1, 1));
            Console.WriteLine(employee.Age);
        }

        ///////////////////////// Mostenire //////////////////////////////////
        
        static void InheritanceMethod()
        {
            var text = new Text();
            text.Width = 1;
            text.Copy();
            text.FontSize = 3;
        }

    }
}
