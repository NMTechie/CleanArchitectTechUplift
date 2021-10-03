using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DomainLayer.NewWayOfAPI.Entities;
using DomainLayer.NewWayOfAPI.Entities.SurveyPeriod;

namespace ApplicationLayer.NewWayOfAPI.UseCases.SurveyPeriod.Ports.Input
{
    /*
     * This is actually the incoming port.
     * Many call this as service as well
     * Thus choosen the folder as Ports (Incoming) 
     * But the file name is related to Service
     */
    interface ISurveyPeriodService
    {
        bool IsSurveyPeriodEditable(SurveyPeriodEntity surveyPeriod);
        public bool SaveSurveyPeriod(SurveyPeriodEntity surveyPeriod);
        public IList<SurveyPeriodEntity> GetSurveyPeriodList(long? surveyPeriodID = null);
    }
}
