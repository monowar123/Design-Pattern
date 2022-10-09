using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Design_Pattern.Factory_Method;
using Design_Pattern.Abstract_Factory;
using Design_Pattern.Builder;
using Design_Pattern.Fluent_Interface;
using Design_Pattern.Prototype;
using Design_Pattern.SingletonPattern;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------Creational Design Pattern----------------------------
            //CallFactoryDesignPattern();

            //CallFactoryMethodDesignPattern();

            //CallAbstractFactoryDesignPattern();

            //CallBuilderDesignPattern();

            //CallFluentInterfaceDesignPattern();

            //CallPrototypeDesignPattern();

            //CallSingletonDesignPattern();

            //CallSingletonFromThread();

            CallLazySingletonFromThread();



            Console.ReadKey();
        }

        #region Creational Design Pattern

        static void CallFactoryDesignPattern()
        {
            ICreditCard creditCard = CreditCardFactory.GetCreditCard(CreditCardType.TITANIUM);


            if (creditCard != null)
            {
                Console.WriteLine("Card Type : {0}", creditCard.GetCardType());
                Console.WriteLine("Credit Limit : {0}", creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge : {0}", creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
        }

        static void CallFactoryMethodDesignPattern()
        {
            ICreditCard creditCard = new TitaniumFactory().CreateProduct();

            if (creditCard != null)
            {
                Console.WriteLine("Card Type : {0}", creditCard.GetCardType());
                Console.WriteLine("Credit Limit : {0}", creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge : {0}", creditCard.GetAnnualCharge());
            }
            else
            {
                Console.WriteLine("Invalid Card Type");
            }
        }

        static void CallAbstractFactoryDesignPattern()
        {
            AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            IAnimal animal = animalFactory.GetAnimal(AnimalType.CAT);

            Console.WriteLine(animal.Speak());
        }

        static void CallBuilderDesignPattern()
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();

            report = reportDirector.MakeReport(new ExcelReport());
            report.DisplayReport();

            Console.WriteLine("-----------------------");

            report = reportDirector.MakeReport(new PDFReport());
            report.DisplayReport();
        }

        static void CallFluentInterfaceDesignPattern()
        {

            //------------------Call Fluent Interface/Method chaining design pattern--------------------
            FluentEmployee employee = new FluentEmployee();
            employee.NameOfTheEmployee("Monowarul Islam").Born("01/01/1990").WorkingOn("Software").StaysAt("Dhaka");


            Console.WriteLine("Full Name: {0}", employee.FullName);
            Console.WriteLine("Date of Birth: {0}", employee.DateOfBirth);
            Console.WriteLine("Department: {0}", employee.Department);
            Console.WriteLine("Address: {0}", employee.Address);
        }


        //----------Used for Deep copy of object-----------
        static void CallPrototypeDesignPattern()
        {
            Person p1 = new Person()
            {
                name = "Monowarul Islam",
                dateOfBirth = Convert.ToDateTime("01/01/1990"),
                spouse = new Person() { name = "Shirin Simi", address = new Address() { district = "Chittagong"} },
                address = new Address() { houseNo = "118", streetNo = "4", postCode = "1205", district = "Dhaka" }
            };

            //Deep copy: Clone object
            Person p2 = new Person();
            p2 = p1.GetClone();

            //Assigining new value of person p2
            p2.name = "Horidas Roy";
            p2.dateOfBirth = Convert.ToDateTime("01/01/1993");
            p2.address.houseNo = "10";
            p2.spouse.name = "Purnima";
            p2.spouse.address.district = "Khulna";



            p1.DisplayMessage();
            Console.WriteLine("-----------------");
            p2.DisplayMessage();
        }

        static void CallSingletonDesignPattern()
        {
            Singleton fromTeacher = Singleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");

            Singleton fromStudent = Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

        static void CallSingletonFromThread()
        {
            Parallel.Invoke(
                () =>
                {
                    Singleton fromTeacher = Singleton.GetInstance;
                    fromTeacher.PrintDetails("From Teacher");
                },
                () =>
                {
                    Singleton fromStudent = Singleton.GetInstance;
                    fromStudent.PrintDetails("From Student");
                });
        }

        static void CallLazySingletonFromThread()
        {
            Parallel.Invoke(
                () =>
                {
                    LazySingleton fromTeacher = LazySingleton.GetInstance;
                    fromTeacher.PrintDetails("From Teacher");
                },
                () =>
                {
                    LazySingleton fromStudent = LazySingleton.GetInstance;
                    fromStudent.PrintDetails("From Student");
                });
        }

        #endregion


        #region Structural Design Patter

        #endregion


        #region Behavioral Design Pattern

        #endregion
    }
}
