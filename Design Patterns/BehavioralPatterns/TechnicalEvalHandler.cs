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
            #region First handling scenario
            request.Comments.AppendLine("Technical handler comment");

            if (_nextHandler != null) _nextHandler.HandleRequest(request);
            else request.ShowComments();
            #endregion
        }
    }
}
