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
            #region third handling scenario
            if(request.JobCode == "456")
            {
                request.Comments.AppendLine("Technical handler comment");
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
            else request.Comments.AppendLine("End at technical handler");
        }
    }
}
