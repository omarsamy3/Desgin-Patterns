using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.ProxyPattern
{
    public class ConcreteSMSService : SMSService
    {
        public override string SendSMS(string CustId, string Mobile, string SMS)
        {
            return $"Customer Id: {CustId}, SMS sent to {Mobile}, {SMS}";
        }
    }
}
