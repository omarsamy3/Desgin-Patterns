using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BehavioralPatterns
{
    public class HREvalHandler : BaseHandler
    {
        public override void HandleRequest(JobApplication request)
        {
            #region third handling scenario
            if(request.JobCode == "123")
            {
                request.Comments.AppendLine("HR handler comment");
                ToNextHandler(request);
            }
            else
            {
                ToNextHandler(request);
            }

            #endregion
        }

        private void ToNextHandler(JobApplication request)
        {
            if (_nextHandler != null) _nextHandler.HandleRequest(request);
            else request.Comments.AppendLine("End at hr handler");
        }
    }
}
