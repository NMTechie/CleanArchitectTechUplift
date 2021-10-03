using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.NewWayOfAPI.Exceptions
{
    public class SurveyPeriodException : Exception
    {
        public SurveyPeriodException(string exceptionMessage) : base(exceptionMessage) { }
    }
}
