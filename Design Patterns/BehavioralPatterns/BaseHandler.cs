using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.BehavioralPatterns
{
    public abstract class BaseHandler
    {
        protected BaseHandler _nextHandler;

        public void SetNext(BaseHandler handler)
        {
            _nextHandler = handler;
        }

        public abstract void HandleRequest(JobApplication request);
    }
}
