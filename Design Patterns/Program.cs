using Design_Patterns.Builder_Pattern;
using Design_Patterns.FactoryPattern;
using Design_Patterns.Prototype_Pattern;
using Design_Patterns.Singleton_Pattern;
using System;
using System.Reflection.Emit;
using System.Security.AccessControl;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Singleton Pattern
            //OneThread();
            //MultiThreading();
            #endregion

            #region Prototype Pattern
            //ShallowCopy();
            //DeepCopy();
            #endregion

            #region Builder Pattern
            //BuilderPattern();
            #endregion

            #region Factory Pattern
            OriginalFactoryPattern();
            #endregion
        }

        #region Singleton Pattern

        public static void OneThread()
        {
            Counter counter = Counter.GetInstance();
            Console.WriteLine(counter.count);
            counter.AddOne();
            Console.WriteLine(counter.count);

            Console.WriteLine("*********************************");

            Counter counter0 = Counter.GetInstance();
            Console.WriteLine(counter0.count);
            counter0.AddOne();
            Console.WriteLine(counter0.count);
        }

        public static void MultiThreading()
        {
            Task Task1 = Task.Factory.StartNew(() =>
            {
                Counter counter1 = Counter.GetInstance();
                counter1.AddOne();
                Console.WriteLine("counter 1: " + counter1.count);
            });


            Task Task2 = Task.Factory.StartNew(() =>
            {
                Counter counter2 = Counter.GetInstance();
                counter2.AddOne();
                Console.WriteLine("counter 2: " + counter2.count);
            });

            Console.ReadKey();
        }

        #endregion

        #region Prototype Pattern
        #region Shallow Copy
        public static void ShallowCopy()
        {
            EmployeePrototype TempEmp1 = new TempEmployee();
            TempEmp1.Name = "temp employee 1";
            TempEmp1.Id = 1;
            TempEmp1.EmpAddress = new Address
            { City = "city 1", Building = "B1", StreetName = "street name" };

            EmployeePrototype TempEmp2 = TempEmp1.ShallowCopy();

            Console.WriteLine("============ Temp Emp 1 Original Values =============");
            Console.WriteLine(TempEmp1.ToString());
            Console.WriteLine("============ Temp Emp 2 Original Values =============");
            Console.WriteLine(TempEmp2.ToString());


            Console.WriteLine("====================================================");
            //Change the reference object data leads to change the original object due to the shallow copy.
            TempEmp2.EmpAddress.City = "New City";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("============ Temp Emp 1 After Change =============");
            Console.WriteLine(TempEmp1.ToString());
            Console.WriteLine("============ Temp Emp 2 After Change =============");
            Console.WriteLine(TempEmp2.ToString());
        }

        #endregion
        #region Deep Copy
        public static void DeepCopy()
        {
            EmployeePrototype TempEmp1 = new TempEmployee();
            TempEmp1.Name = "temp employee 1";
            TempEmp1.Id = 1;
            TempEmp1.EmpAddress = new Address
            { City = "city 1", Building = "B1", StreetName = "street name" };

            EmployeePrototype TempEmp2 = TempEmp1.DeepCopy();

            Console.WriteLine("============ Temp Emp 1 Original Values =============");
            Console.WriteLine(TempEmp1.ToString());
            Console.WriteLine("============ Temp Emp 2 Original Values =============");
            Console.WriteLine(TempEmp2.ToString());


            Console.WriteLine("====================================================");
            //Change the reference object data leads to No Change in the original object due to the deep copy.
            TempEmp2.EmpAddress.City = "New City";
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("============ Temp Emp 1 After Change =============");
            Console.WriteLine(TempEmp1.ToString());
            Console.WriteLine("============ Temp Emp 2 After Change =============");
            Console.WriteLine(TempEmp2.ToString());
        }

        #endregion

        #endregion

        #region Builder Pattern
        public static void BuilderPattern()
        {
        Console.WriteLine("\t \t \t \t \t \t***Builder Pattern*** \n \n \n", Console.ForegroundColor = ConsoleColor.Yellow);
            Director director = new Director();
        IBuilder carBuilder = new Car("Jeep");
        IBuilder motorCycleBuilder = new MotorCycle("Hoda");

        //Making Car
        director.Construct(carBuilder);
            Product car = carBuilder.GetVehicle();
        Console.WriteLine($"\t Car {car.Show()}");

            //Making MotorCycle
            director.Construct(motorCycleBuilder);
            Product motorCycle = motorCycleBuilder.GetVehicle();
        Console.WriteLine($"\t MotorCycle {motorCycle.Show()}");
        }
        #endregion

        #region Factory Pattern
        
        #region Original
        public static void OriginalFactoryPattern()
        {
            string cardNumber = null;
            int cardNum;
            bool ParsedToInt = false; 
            AskForCode:
            do
            {
                Console.Write("Enter your card number: ");
                cardNumber = Console.ReadLine();
                ParsedToInt = int.TryParse(cardNumber, out cardNum);
            }
            while (String.IsNullOrEmpty(cardNumber) || cardNumber.Length < 6 || !ParsedToInt);

            
            string bankCode = cardNumber.Substring(0, 6);

            BankFactory bankFactory = new BankFactory();
            IBank bank = bankFactory.GetBank(bankCode);

            if (bank != null)
                Console.WriteLine(bank.WithDraw());

            else
            {
                Console.WriteLine("This bank is not found");
                goto AskForCode;
            }
        }
        #endregion

        #region Abstract
        public static void AbstractFactoryPattern()
        {

        }
        #endregion
        #endregion
    }
}
