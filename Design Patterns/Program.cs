using Design_Patterns.BehavioralPatterns;
using Design_Patterns.Builder_Pattern;
using Design_Patterns.FactoryPattern;
using Design_Patterns.Prototype_Pattern;
using Design_Patterns.Singleton_Pattern;
using Design_Patterns.StructuralPatterns.AdapterPattern;
using Design_Patterns.StructuralPatterns.DecoratorPattern;
using Design_Patterns.StructuralPatterns.FacadePattern;
using Design_Patterns.StructuralPatterns.FlyweightPattern;
using Design_Patterns.StructuralPatterns.ProxyPattern;
using System;
using System.Reflection;
using System.Reflection.Emit;
using System.Security.AccessControl;
using System.Threading.Tasks.Sources;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Creational Patterns

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
            //OriginalFactoryPattern();
            //AbstractFactoryPattern();
            #endregion

            #endregion

            #region Structural Patterns

            #region Proxy Pattern
            //ProxyPattern();
            #endregion

            #region Decorator Pattern
            //DecoratorPattern();
            #endregion

            #region Adapter Pattern
            //AdapterPattern();
            #endregion

            #region Facade Pattern
            //FacadePattern();
            #endregion

            #region Flyweight Pattern
            //FlyweightPattern();
            #endregion

            #endregion

            #region Behvioral Patterns
            #region ChainOfResponsibility
            COR();
            #endregion
            #endregion
        }

        #region Creational Patterns

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
        IBuilder motorCycleBuilder = new MotorCycle("Honda");

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
            bool ParsedToInt = false; 
            
            //This label to goto if the code does not follow any bank.
            AskForCode:
            do
            {
                Console.Write("Enter your card number: ");
                cardNumber = Console.ReadLine();
                ParsedToInt = int.TryParse(cardNumber, out int cardNum);
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
            string cardNumber = null;
            int cardNum;
            bool ParsedToInt = false;

        //This label to goto if the code does not follow any bank.
        AskForCode:
            do
            {
                Console.Write("Enter your card number: ");
                cardNumber = Console.ReadLine();
                ParsedToInt = int.TryParse(cardNumber, out cardNum);
            }
            while (String.IsNullOrEmpty(cardNumber) || cardNumber.Length < 6 || !ParsedToInt);


            string bankCode = cardNumber.Substring(0, 6);
            string cardkind = cardNumber.Substring(0, 2);

            BankFactory bankFactory = new BankFactory();
            IBank bank = bankFactory.GetBank(bankCode);
            IPaymentCard paymentCard = bankFactory.GetPaymentCard(cardkind);

            if (bank != null || paymentCard != null)
            {
                Console.WriteLine(bank.WithDraw());
                Console.WriteLine("Card Name: " + paymentCard.GetName() + "\nProvider Info: " + paymentCard.GetProviderInfo());
            }
            else
            {
                Console.WriteLine("This bank is not found");
                goto AskForCode;
            }
        }
        #endregion
        #endregion


        #endregion

        #region Structural Patterns

        #region Proxy Pattern
        public static void ProxyPattern()
        {
            SMSServiceProxy proxy = new SMSServiceProxy();
            Console.WriteLine(proxy.SendSMS("12", "01123445464", "Message 1"));
            Console.WriteLine(proxy.SendSMS("12", "01123445464", "Message 2"));
            Console.WriteLine(proxy.SendSMS("12", "01123445464", "Message 3")); //Won't be sent.
            
        }
        #endregion

        #region Decorator Pattern

        public static void DecoratorPattern()
        {
            //Make an object of a class inherites from SMSService.
            ConcreteSMSService smsService = new ConcreteSMSService();

            //Make an object of NotificationEmailDecorator to send an email if the sms be sent.
            NotificationEmailDecorator emailDecorator = new NotificationEmailDecorator();

            //Set the service to send the sms msg, and send an email with this msg.
            emailDecorator.SetService(smsService);
            Console.WriteLine(emailDecorator.SendSMS("123", "011111", "Message1"));

        }

        #endregion

        #region Adapter Pattern
        public static void AdapterPatternBefore()
        {
            //Make this obj to use in the salaryCalc function.
            Employee emp = new Employee() { Name = "Employee1", BasicSalary = 1000 };

            //Make this obj to use its function to calculate the employee salary.
            SalaryCalculator EmpSalaryCalc = new SalaryCalculator();

            //Return the employee salary.
            var EmpSalary = EmpSalaryCalc.CalcSalary(emp);

            Console.WriteLine($"The employee basic Salary is: {emp.BasicSalary}, but now it is: {EmpSalary}");

            /*
             What we will do if we have another class with similar data and we want to calc the salary, but the CalcSalary function
            Need to pass an emp object.
             */

            MachineOperator machineOper = new MachineOperator() { Name = "Operater 1", BasicSalary = 2000, ShiftCode = "kr4l2jh252l6s" };

            //EmpSalaryCalc.CalcSalary(machineOper); //Error

            Employee empAdapter = new Employee() { Name = machineOper.Name, BasicSalary = machineOper.BasicSalary };

            var MachineOperAdapted = EmpSalaryCalc.CalcSalary(empAdapter);

            Console.WriteLine("Manual Adapting...");
            Console.WriteLine($"The Machine basic Salary is: {empAdapter.BasicSalary}, but now it is: {MachineOperAdapted}");
        }

        public static void AdapterPatternAfter()
        {
            //Make this obj to use in the salaryCalc function.
            Employee emp = new Employee() { Name = "Employee1", BasicSalary = 1000 };

            //Make this obj to use its function to calculate the employee salary.
            SalaryCalculator EmpSalaryCalc = new SalaryCalculator();

            //Return the employee salary.
            var EmpSalary = EmpSalaryCalc.CalcSalary(emp);

            Console.WriteLine($"The employee basic Salary is: {emp.BasicSalary}, but now it is: {EmpSalary}");

            MachineOperator machineOper = new MachineOperator() { Name = "Operater 1", BasicSalary = 2000, ShiftCode = "kr4l2jh252l6s" };

            SalaryAdapter SalaryAdapterToMachine = new SalaryAdapter();

            var MachineOperAdapted = SalaryAdapterToMachine.CalcSalary(machineOper);

            Console.WriteLine("Automatic Adapting by using SalaryAdapter class...");
            Console.WriteLine($"The Machine basic Salary is: {machineOper.BasicSalary}, but now it is: {MachineOperAdapted}");


        }

        public static void AdapterPattern()
        {
            AdapterPatternBefore();
            Console.WriteLine("******************************");
            AdapterPatternAfter();
        }
        #endregion

        #region Facade Pattern
        public static void FacadePatternBefore()
        {
            //Create basket
            ShoppingBasket basket = new ShoppingBasket();
            BasketItem item = new BasketItem() { ItemId = "123", ItemPrice = 50, Quantity = 3 };

            //Check stock 
            Inventory inventory = new Inventory();
            if (inventory.CheckItemQuantity(item.ItemId, item.Quantity))
                basket.AddItem(item);

            //Create Inventory Order
            InventoryOrder inventoryOrder = new InventoryOrder();
            inventoryOrder.CreateOrder(basket);

            //Create Invoice 
            PurchaseInvoice invoice = new PurchaseInvoice();
            var inv = invoice.CreateInvoice(basket, "address:132, id = 456, emai = x@gmai.com");

            //Payment 
            PaymentProcess payment = new PaymentProcess();
            payment.HandlePayment(inv.netTotal, "acc = 123456789");

            //Send SMS
            SmsNotifications sms = new SmsNotifications();
            sms.SendSms("123", "Invoice Created");
        }
        public static void FacadePattern()
        {
            //Create basket
            ShoppingBasket basket = new ShoppingBasket();
            BasketItem item1 = new BasketItem() { ItemId = "123", ItemPrice = 50, Quantity = 3 };
            BasketItem item2 = new BasketItem() { ItemId = "124", ItemPrice = 60, Quantity = 5 };
            basket.AddItem(item1);
            basket.AddItem(item2);

            //Create an order, using the facade layer(PurchaseOrder class).
            PurchaseOrder Order = new PurchaseOrder();
            Order.CreateOrder(basket, "name:omar, id:3, phoneNum:0111");
        }
        #endregion

        #region Flyweight Pattern
        public static void FlyweightPattern()
        {
            DiscountCalaFactory discountFactory = new DiscountCalaFactory();
            var calculator = discountFactory.GetDiscountCalc("day");
            var val = calculator.GetDiscountValue(DateTime.Now.Date);
            Console.WriteLine(val.ToString());
        }
        #endregion
        #endregion

        #region Behavioral Patterns

        #region ChainOfResponsibility
        public static void COR()
        {
            JobApplication jobApplication = new JobApplication();
            jobApplication.ApplicationName = "Omar";
            jobApplication.JobTitle = "Great Job";
            jobApplication.JobCode = "1234";
            jobApplication.Comments = new System.Text.StringBuilder();
        }
        #endregion

        #endregion
    }
}
