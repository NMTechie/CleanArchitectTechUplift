using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Output;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Output;

namespace InfrastructureLayer.NewWayOfAPI.Persistance
{
    public class SurveyPeriodApplicationRepository : ISurveyPeriodRepository
    {
        private ISurveyPeriodDomainRepository _domainRepository;
        public SurveyPeriodApplicationRepository(ISurveyPeriodDomainRepository domainRepository)
        {
            _domainRepository = domainRepository;
        }
        public IList<SurveyPeriodEntity> GetSurveyPeriodList(long? surveyPeriodID = null)
        {
            throw new NotImplementedException();
        }

        public bool IsSurveyPeriodEditable(long surveyPeriodID)
        {
            throw new NotImplementedException();
        }

        public bool SaveSurveyPeriod(SurveyPeriodEntity surveyPeriod)
        {
            bool retVal = false;
            retVal = surveyPeriod.SurveyPeriodId == null ? _domainRepository.Create() : _domainRepository.Update();
            return retVal;
        }
    }
}
