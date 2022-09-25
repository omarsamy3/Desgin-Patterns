using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public class MasterCard : IPaymentCard
    {
        public string GetName()
        {
            return "Master Card";
        }

        public string GetProviderInfo()
        {
            return "Master";
        }
    }
}
