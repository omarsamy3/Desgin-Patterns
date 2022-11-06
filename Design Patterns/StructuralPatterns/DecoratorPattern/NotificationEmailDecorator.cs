using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.StructuralPatterns.DecoratorPattern
{
    public class NotificationEmailDecorator : AbstractDecorator
    {
        public string SMSSendNotification(string custId, string msg)
        {
            return $"sms {msg}, send to {custId}, at {DateTime.Now.ToLongDateString()}";
        }

        public override string SendSMS(string CustId, string Mobile, string SMS)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(base.SendSMS(CustId, Mobile, SMS));

            //Decorator method to send mail.
            result.AppendLine(SMSSendNotification(CustId, SMS));

            return result.ToString();
        }
    }
}
