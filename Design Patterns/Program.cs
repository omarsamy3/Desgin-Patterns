using Design_Patterns.Singleton_Pattern;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Singleton Pattern
            //OneThread();
            MultiThreading();
            #endregion
        }

        #region Singleton Pattern

        public static void OneThread()
        {
            #region One Thread
            Counter counter = Counter.GetInstance();
            Console.WriteLine(counter.count);
            counter.AddOne();
            Console.WriteLine(counter.count);

            Console.WriteLine("*********************************");

            Counter counter0 = Counter.GetInstance();
            Console.WriteLine(counter0.count);
            counter0.AddOne();
            Console.WriteLine(counter0.count);
            #endregion
        }

        public static void MultiThreading()
        {
            #region Multihreading

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
            #endregion
        }

        #endregion

    }
}
