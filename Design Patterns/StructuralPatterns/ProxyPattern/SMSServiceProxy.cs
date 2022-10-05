using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.ProxyPattern
{
    public class SMSServiceProxy
    {
        //TODO: Count calls for each customer, if calls > 2 don't send sms.
        private SMSService _smsService;
        Dictionary<string, int> sentCount = new Dictionary<string, int>();

        public string SendSMS(string custId, string mobile, string sms)
        {
            //Lazy loading of the _smsService object until you call the function to send msg.
            if (_smsService == null) { _smsService = new ConcreteSMSService(); }

            //First Call 
            if (!sentCount.ContainsKey(custId))
            {
                sentCount.Add(custId, 1);
                return _smsService.SendSMS(custId, mobile, sms);
            }
            //Other calls.
            else
            {
                var customer = sentCount.Where(x => x.Key == custId).FirstOrDefault();
                if(customer.Value >= 2) 
                {
                    return "Not Sent! Your quota has finnished";
                }
                else
                {
                    sentCount[custId] = customer.Value + 1;
                    return _smsService.SendSMS(custId, mobile, sms);
                }
            }
        }
    }
}
