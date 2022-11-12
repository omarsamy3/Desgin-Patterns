using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BehavioralPatterns
{
    public class TechnicalEvalHandler : BaseHandler
    {
        public override void HandleRequest(JobApplication request)
        {
            #region second handling scenario
            if(request.JobCode == "456")
            request.Comments.AppendLine("Technical handler comment");
            else
            {
                if (_nextHandler != null) _nextHandler.HandleRequest(request);
                else request.Comments.AppendLine("End at technical handler");
            }
            
            #endregion
        }
    }
}
