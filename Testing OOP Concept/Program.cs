using Amazon;
using Clasa_Derivata;
using Composition;
using Constructori;
using MetodaStatica_MetodaNonstatica;
using Modificatori_de_acces;
using System;
using System.Collections.Generic;
using UpcastingDowncasting;
using Virtual;
using Animal;
using Interface;
using Polimorfism;

namespace Program
{

    class Program
    {
        static void Main(string[] args)
        {
            //StaticMethod();
            //ConstructorMethod();
            //AccessModifiers();
            //InheritanceMethod();
            //CompositionMethod();
            //UpcastingDowncastingMethod();
            //VirtualMethod();
            // AbstractMethod();
            //InterfaceMethod();
            PolymorphismMethod();
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

            Car car = new Car("ABC123"); // Constructorul clasei de baza este initializat inaintea constructorului clasei derivate.
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
            //Console.WriteLine(details_emp.ToString()) ;

            var employeeAmazon = new EmployeeAmazon();
            //Amazon.RateCalculator calculator = new RateCalculator(); // eroare -- internal -- este accesibil doar in cadrul assembly-ului
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

        ///////////////////////// Upcasting Downcasting //////////////////////////////////

        static void UpcastingDowncastingMethod()
        {
            var text = new TextShape();
            Shape shape = text; // upcasting este conversia de la clasa derivata la clasa de baza.

            text.Height = 100;
            shape.Height = 200;

            Console.WriteLine(text.Height); // afiseaza 200 pt ca shape si text sunt referinte catre acelasi obiect

            TextShape text2 = (TextShape)shape; // Downcasting este conversia de la clasa de baza la clasa derivata.

        }

        ///////////////////////// Virtual Method //////////////////////////////////
        
        static void VirtualMethod()
        {
            var shapes = new List<Forma>();
            shapes.Add(new Cerc());
            shapes.Add(new Dreptunghi());

            var canvas = new Canvas();
            canvas.DrawShape(shapes);
        }

        ///////////////////////// Abstract Method //////////////////////////////////

        static void AbstractMethod()
        {
            //var animal = new Animal(); // nu se creaza o instanta pentru clasa abstracta
            var pisica = new Pisica();
            pisica.Mananca(); // apeleaza metoda abstracta
            pisica.Doarme(); // apeleaza metoda normala
        }

        ///////////////////////// Interfaces //////////////////////////////////

        static void InterfaceMethod()
        {
            var automobil = new Automobil();
            Start(automobil);

            var masinaTunsIarba = new MasinaTunsIarba();
            Start(masinaTunsIarba);
        }

        public static void Start(IMasina masina) // aceasta metoda poate sa porneasca orice implementeza interfata IMasina (ex. automobil, cuptor cu microunde etc)
        {
            masina.Start();
        }

        ///////////////////////// Polimorfism //////////////////////////////////

        static void PolymorphismMethod()
        {
            List<Muzician> muzicieni = new List<Muzician>();

            // Un obiect poate fi declarat pe o clasa si instantiat pe alta
            Muzician violonist = new Violonist();
            Muzician chitarist = new Chitarist();

            // adaug muzicieni de tipuri deferiti
            muzicieni.Add(violonist);
            muzicieni.Add(chitarist);

            foreach (Muzician m in muzicieni)
            {
                if (m is Violonist)
                {
                    m.Canta("Ionut");
                }
                if (m is Chitarist)
                {
                    m.Canta("Matei");
                }
            }
        }
    }
}

