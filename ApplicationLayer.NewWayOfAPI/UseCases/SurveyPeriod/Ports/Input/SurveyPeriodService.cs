using DomainLayer.NewWayOfAPI.Entities;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod.Ports.Input;
using ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Output;
using ApplicationLayer.NewWayOfAPI.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Input
{
    public class SurveyPeriodService : ISurveyPeriodService
    {
        private ISurveyPeriodDomainOperation _surveyPeriodPortIP;
        private ISurveyPeriodRepository _surveyPeriodRepository;
        public SurveyPeriodService(ISurveyPeriodDomainOperation surveyPeriodPortIP,ISurveyPeriodRepository surveyPeriodRepository)
        {
            _surveyPeriodPortIP = surveyPeriodPortIP;
            _surveyPeriodRepository = surveyPeriodRepository;
        }

        public bool IsSurveyPeriodEditable(SurveyPeriodEntity surveyPeriod)
        {
            throw new NotImplementedException();
        }

        public bool SaveSurveyPeriod(SurveyPeriodEntity surveyPeriod)
        {
            if (!_surveyPeriodPortIP.IsSurveyPeriodUnique(surveyPeriod) || !_surveyPeriodPortIP.IsValidSurveyPeriod(surveyPeriod))
            {
                throw new SurveyPeriodException("Invalid Survey Period");
            }
            return _surveyPeriodRepository.SaveSurveyPeriod(surveyPeriod);
        }

        public IList<SurveyPeriodEntity> GetSurveyPeriodList(long? surveyPeriodID=null)
        {
            throw new NotImplementedException();
        }
    }
}
