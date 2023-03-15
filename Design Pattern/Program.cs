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
using Design_Pattern.Structural_Design_Pattern.Adapter;
using Design_Pattern.Creational_Design_Pattern.Factory_Method_2;
using Design_Pattern.Creational_Design_Pattern.Abstract_Factory_02;
using Design_Pattern.Structural_Design_Pattern.Facade;
using Design_Pattern.Structural_Design_Pattern.Decorator;
using Design_Pattern.Structural_Design_Pattern.Decorator_02;

namespace Design_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //----------------Creational Design Pattern----------------------------
            //CallFactoryDesignPattern();

            //CallFactoryMethodDesignPattern();

            //CallFactoryMethod_02_DesignPattern();

            //CallAbstractFactoryDesignPattern();

            //CallAbstractFactory_02_DesignPattern();

            //CallBuilderDesignPattern();

            //CallFluentInterfaceDesignPattern();

            //CallPrototypeDesignPattern();

            //CallSingletonDesignPattern();

            //CallSingletonFromThread();

            //CallLazySingletonFromThread();


            //----------------Structural Design Pattern-----------------
            //CallAdapterDesignPattern();

            //CallFacadeDesignPattern();

            //CallDecoratorDesignPattern();

            CallDecorator_02_DesignPattern();



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

        static void CallFactoryMethod_02_DesignPattern()
        {
            ITransport transport = new RoadLogistics().GetTransport();
            Console.WriteLine(transport.DeliverProduct());
            Console.WriteLine("Cost: {0}", transport.CalculateCost());

            transport = new SeaLogistics().GetTransport();
            Console.WriteLine(transport.DeliverProduct());
            Console.WriteLine("Cost: {0}", transport.CalculateCost());
        }

        static void CallAbstractFactoryDesignPattern()
        {
            AnimalFactory animalFactory = AnimalFactory.CreateAnimalFactory(FactoryType.LAND);
            IAnimal animal = animalFactory.GetAnimal(AnimalType.CAT);

            Console.WriteLine("Animal Factory Type: {0}", animalFactory.GetType().Name);
            Console.WriteLine("Animal Type: {0}", animal.GetType().Name);
            Console.WriteLine(animal.Speak());

            Console.WriteLine();

            animalFactory = AnimalFactory.CreateAnimalFactory(FactoryType.SEA);
            animal = animalFactory.GetAnimal(AnimalType.SHARK);

            Console.WriteLine("Animal Factory Type: {0}", animalFactory.GetType().Name);
            Console.WriteLine("Animal Type: {0}", animal.GetType().Name);
            Console.WriteLine(animal.Speak());
        }

        static void CallAbstractFactory_02_DesignPattern()
        {
            IFurnitureFactory furnitureFactory = new VictorianFurnitureFactory();
            IChair chair = furnitureFactory.GetChair();
            ISofa sofa = furnitureFactory.GetSofa();
            ITable table = furnitureFactory.GetTable();

            Console.WriteLine("Name: {0}, Price: {1}", chair.GetName(), chair.GetPrice());
            Console.WriteLine("Name: {0}, Price: {1}", sofa.GetName(), sofa.GetPrice());
            Console.WriteLine("Name: {0}, Price: {1}", table.GetName(), table.GetPrice());
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


        //-------Method chaining (Fluent Interface)-----------------
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


        //----------Used for Deep copy of object (Prototype)-----------
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
        static void CallAdapterDesignPattern()
        {
            string[,] employeesArray = new string[5, 4]
            {
                {"101","John","SE","10000"},
                {"102","Smith","SE","20000"},
                {"103","Dev","SSE","30000"},
                {"104","Pam","SE","40000"},
                {"105","Sara","SSE","50000"}
            };

            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
        }


        static void CallFacadeDesignPattern()
        {
            VideoConverter converter = new VideoConverter(@"D:\Image\abc.mpeg");
            converter.Convert("MP4");
        }

        static void CallDecoratorDesignPattern()
        {
            //ICake cake = new ChokolateCake();
            //cake.AddLayer("Basic layer");

            //ICakeDecorator cakeDecorator = new CakeMessageDecorator(cake);
            //cakeDecorator.Decorate("Happy Birthday");
            //cake.PrintLayers();

            ICakeDecorator cakeDecorator = new CakeMessageDecorator(new ChokolateCake());
            cakeDecorator.AddLayer("Basic Layer");
            cakeDecorator.Decorate("Happy Birthday");
            cakeDecorator.PrintLayers(); 
        }

        static void CallDecorator_02_DesignPattern()
        {
            //IWidget widget = new TextField(10, 12);
            //widget.Draw();

            BorderDecorator borderDecorator = new BorderDecorator(new TextField(10, 12));
            borderDecorator.DrawWithFeature();

            ScrollbarDecorator scrollbarDecorator = new ScrollbarDecorator(new TextField(15, 20));
            scrollbarDecorator.DrawWithFeature();
                
        }


        #endregion


        #region Behavioral Design Pattern

        #endregion
    }
}
