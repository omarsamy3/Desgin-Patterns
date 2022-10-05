using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.ProxyPattern
{
    public abstract class SMSService
    {
        public abstract string SendSMS(string CustId, string Mobile, string SMS);
    }
}
