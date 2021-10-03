using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Output;

namespace DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Input
{
    public class SurveyPeriodDomainAdapter : ISurveyPeriodDomainPortIP
    {
        private ISurveyPeriodDomainRepository _domainRepository;
        public SurveyPeriodDomainAdapter(ISurveyPeriodDomainRepository surveyPeriodDomainRepository)
        {
            _domainRepository = surveyPeriodDomainRepository;
        }
        public bool IsSurveyPeriodUnique(SurveyPeriodEntity surveyPeriod)
        {
            return _domainRepository.CheckSurveyPeriodNameIsUnique(surveyPeriod.SurveryPeriodName);
        }

        public bool IsValidSurveyPeriod(SurveyPeriodEntity surveyPeriod)
        {
            if (surveyPeriod.StartDate > surveyPeriod.EndDate)
            {
                throw new Exception("Invalid Date Range of the Survey Period");
            }
            return surveyPeriod.StartDate < surveyPeriod.EndDate;
        }
    }
}
