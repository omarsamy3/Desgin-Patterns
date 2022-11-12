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
            #region First handling scenario
            request.Comments.AppendLine("HR handler comment");

            
            #endregion
        }
    }
}
