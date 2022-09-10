using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Singleton_Pattern
{
    public class Counter
    {
        public int count;
        private static Counter counter = null;
        private static object LockObj = new object();
            
        private Counter(){ }
        public static Counter GetInstance()
        {
            //Using double check to control multithreading.
            if (counter == null)
            {
                lock (LockObj) //lock to excute one thread first.
                {
                    if (counter == null) counter = new Counter();
                }
            }
            return counter;
        }
        public void AddOne() { count++; }
    }
}
