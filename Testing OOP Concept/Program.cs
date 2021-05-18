using Clasa_Derivata;
using Composition;
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
            //qwq
            //StaticMethod();
            //ConstructorMethod();
            AccessModifiers();
            //InheritanceMethod();
            //CompositionMethod();
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
            var emp = new Employee();
            emp.Name = "Florea";
            Console.WriteLine(emp.Name); // public - accesibil din interiorul şi din exteriorul clasei

            //var rating = employee.CalculateRating(); //eroare -- private - accesibil numai din interiorul clasei

            //Console.WriteLine(employee.GetEmployeeDetails()); // eroare -- protected - accesibil numai din interiorul clasei şi a claselor derivate

            var details_emp = new EmployeeDetails();
            details_emp.SetDetails();
            Console.WriteLine(details_emp) ;
        }

        ///////////////////////// Mostenire //////////////////////////////////

        static void InheritanceMethod()
        {
            var text = new Text();
            text.Width = 1;
            text.Copy();
            text.FontSize = 3;
        }

        ///////////////////////// Composition //////////////////////////////////

        static void CompositionMethod()
        {
            var log = new Logger();
            var installer = new Installer(log);
            var dbMigrator = new DbMigrator(log);

            dbMigrator.Migrate();
            installer.Install();
        }
    }
}
