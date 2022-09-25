using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.FactoryPattern
{
    public interface IBankFactory
    {
        //Return the kind of bank dealing with.
        IBank GetBank(string bankCode);

        IPaymentCard GetPaymentCard(string cardNumber);
    }
}
