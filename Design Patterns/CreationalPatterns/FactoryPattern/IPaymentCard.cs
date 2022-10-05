using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public interface IPaymentCard
    {
        string GetName();
        string GetProviderInfo();
    }
}
