using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Output
{
    public interface ISurveyPeriodRepository
    {
        public bool IsSurveyPeriodEditable(long surveyPeriodID);
        public bool SaveSurveyPeriod(SurveyPeriodEntity surveyPeriod);
        public IList<SurveyPeriodEntity> GetSurveyPeriodList(long? surveyPeriodID = null); 
    }
}
