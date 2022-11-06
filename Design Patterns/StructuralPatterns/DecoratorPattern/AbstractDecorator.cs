using Design_Patterns.StructuralPatterns.ProxyPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.DecoratorPattern
{
    public class AbstractDecorator : SMSService
    {
        //Make an object from SMSService to set before calling the SendSMS function.
        protected SMSService notificationService;

        //Must be called to set the service before calling SendSMS function.
        public void SetService(SMSService service)
        {
            notificationService = service;
        }

        //Send the SMS message after check out the service.
        public override string SendSMS(string CustId, string Mobile, string SMS)
        {
            if(notificationService != null)
            {
                return notificationService.SendSMS(CustId, Mobile, SMS);
            }
            else
            {
                return "Notification service not initialized!";
            }
        }
    }
}
