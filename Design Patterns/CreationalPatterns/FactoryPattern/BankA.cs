using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public class BankA : IBank
    {
        public string WithDraw()
        {
            return "Your request is handling by BankA";
        }
    }
}
